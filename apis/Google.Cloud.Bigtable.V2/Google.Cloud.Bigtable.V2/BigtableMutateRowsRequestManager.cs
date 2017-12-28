// Copyright 2017 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Performs retries for <see cref="BigtableClient.MutateRows"/> operations.
    /// </summary>
    public class BigtableMutateRowsRequestManager
    {
        private readonly MutateRowsRequest _originalRequest;

        /// <summary>
        /// The new request to send. This starts as the original request. If retries occur, this
        /// request will contain the subset of Entries that need to be retried.
        /// </summary>
        private volatile MutateRowsRequest _modifiedRequest;

        /// <summary>
        /// When doing retries, the retry sends a partial set of the original Entries that failed with a
        /// retryable status. This array contains a mapping of indices from the <see cref="_modifiedRequest"/> 
        /// to <see cref="_originalRequest"/>.
        /// </summary>
        private int[] _mapToOriginalIndex;

        /// <summary>
        /// This list tracks failed RPC status codes thats should be retried
        /// </summary> 
        private readonly List<int> _rertriableCodes;

        /// <summary>
        /// This array tracks the cumulative set of results across all RPC requests.
        /// </summary> 
        private Rpc.Status[] Results { get; }

        private readonly Rpc.Status STATUS_INTERNAL = new Rpc.Status
        {
            Code = GetGrpcCode(Grpc.Core.StatusCode.Internal),
            Message = "Response Was Not Returned For This Index"
        };

        private bool _messageIsInvalid;

        /// <summary>
        /// This method returns code digit from <see cref="Grpc.Core.StatusCode"/>.
        /// </summary>
        private static int GetGrpcCode(Grpc.Core.StatusCode status)
        {
            return (int)status;
        }

        private static MutateRowsResponse.Types.Entry CreateEntry(int i, Rpc.Status status)
        {
            return new MutateRowsResponse.Types.Entry { Index = i, Status = status };
        }

        /// <summary>
        /// Containes possible processing statuses
        /// </summary>
        public enum ProcessingStatus
        {
            /// <summary> All responses produced OK. </summary>
            SUCCESS,

            /// <summary> All responses produced OK or a retruable code. </summary>
            RETRYABLE,

            /// <summary> Some responses had a non-retriable code. </summary>
            NOT_RETRYABLE,

            /// <summary> The response was invalid, missing index, etc. </summary>
            INVALID
        }

        /// <summary>
        /// Constructor for retrying failed mutation entries
        /// </summary>
        /// <param name="retryStatuses"></param>
        /// <param name="mutateRowsRequest"></param>
        public BigtableMutateRowsRequestManager(IEnumerable<Grpc.Core.StatusCode> retryStatuses, MutateRowsRequest mutateRowsRequest)
        {
            _originalRequest = mutateRowsRequest;
            _modifiedRequest = mutateRowsRequest;

            Results = new Rpc.Status[_originalRequest.Entries.Count];

            // This is a map between _modifiedRequest and _originalRequest. For now, 
            //_modifiedRequest == _originalRequest, but they could diverge if a retry occurs.
            _mapToOriginalIndex = new int[_originalRequest.Entries.Count];
            for (int i = 0; i < _mapToOriginalIndex.Length; i++)
            {
                _mapToOriginalIndex[i] = i;
            }

            _rertriableCodes = GetRetriableCodes(retryStatuses);
        }

        private List<int> GetRetriableCodes(IEnumerable<Grpc.Core.StatusCode> statusCode)
        {
            var codes = new List<int>();
            foreach (var status in statusCode)
            {
                codes.Add(GetGrpcCode(status));
            }
            return codes;
        }

        /// <summary>
        /// Adds the content of the MutateRowsResponse message to the <see cref="Results"/>
        /// </summary>
        /// <param name="response"></param>
        public void SetStatus(MutateRowsResponse response)
        {
            foreach (var entry in response.Entries)
            {
                int index = (int)entry.Index;

                if (index >= _mapToOriginalIndex.Length || index < 0)
                {
                    _messageIsInvalid = true;
                    break;
                }
                // Set the result
                Results[_mapToOriginalIndex[index]] = entry.Status;
            }
        }

        /// <summary>
        /// This method is called when all calls to <see cref="SetStatus(MutateRowsResponse)"/> are complete.
        /// </summary>
        /// <returns>
        /// ProcessingStatus of the accumulated responses - success, invalid, retryable, non-retryable.
        /// </returns>
        public ProcessingStatus OnOk()
        {
            // Sanity check to make sure that every mutation received a response.
            if (!_messageIsInvalid)
            {
                for (int i = 0; i < Results.Length; i++)
                {
                    if (Results[i] == null)
                    {
                        _messageIsInvalid = true;
                        break;
                    }
                }
            }

            // There was a problem in the data found in SetStatus(), so fail the RPC.
            if (_messageIsInvalid)
            {
                return ProcessingStatus.INVALID;
            }

            // This list hold indices of entries to be included in retry request
            List<int> toRetry = new List<int>();
            ProcessingStatus processingStatus = ProcessingStatus.SUCCESS;

            // Check the current state to determine the state of the results.
            // There are three states: OK, Fail, or Partial Retry.
            for (int i = 0; i < Results.Length; i++)
            {
                Rpc.Status status = Results[i];
                if (status.Code == GetGrpcCode(Grpc.Core.StatusCode.OK))
                {
                    continue;
                }
                if (_rertriableCodes.Contains(status.Code))
                {
                    // An individual mutation failed with a retryable code, usually DEADLINE_EXCEEDED.
                    toRetry.Add(i);
                    if (processingStatus == ProcessingStatus.SUCCESS)
                    {
                        processingStatus = ProcessingStatus.RETRYABLE;
                    }
                }
                else
                {
                    // Don't retry if even a single response is not retryable.
                    processingStatus = ProcessingStatus.NOT_RETRYABLE;
                    break;
                }
            }

            if (toRetry.Count > 0)
            {
                _modifiedRequest = CreateRetryRequest(toRetry);
            }
            return processingStatus;
        }

        /// <summary>
        /// Returns modified MutateRowsRequest.
        /// </summary>
        /// <returns></returns>
        public MutateRowsRequest GetRetryRequest()
        {
            return _modifiedRequest;
        }

        /// <summary>
        /// Creates a new MutateRowsRequest that's a subset of the original request that
        /// corresponds to a set of indices.
        /// </summary>
        /// <param name="indiciesToRetry">
        /// LIst of ints that represents indicies of entries that failed.
        /// </param>
        /// <returns>
        /// Returns modified <see cref="MutateRowRequest"/>.
        /// </returns>
        private MutateRowsRequest CreateRetryRequest(List<int> indiciesToRetry)
        {
            _modifiedRequest = new MutateRowsRequest();
            _mapToOriginalIndex = new int[indiciesToRetry.Count];
            for (int i = 0; i < _mapToOriginalIndex.Length; i++)
            {
                _mapToOriginalIndex[i] = indiciesToRetry[i];
                _modifiedRequest.Entries.Add(_originalRequest.Entries[indiciesToRetry[i]]);
            }
            return _modifiedRequest;
        }

        /// <summary>
        /// Builds full response from the accumulation of all calls to
        /// onMessage/onOK.
        /// </summary>
        /// <returns>MutateRowsResponse</returns>
        public MutateRowsResponse BuildResponse()
        {
            List<MutateRowsResponse.Types.Entry> entries = new List<MutateRowsResponse.Types.Entry>();

            for (int i = 0; i < Results.Length; i++)
            {
                Rpc.Status status = Results[i] == null ? STATUS_INTERNAL : Results[i];
                entries.Add(CreateEntry(i, status));
            }
            return new MutateRowsResponse { Entries = { entries } };
        }
    }
}
