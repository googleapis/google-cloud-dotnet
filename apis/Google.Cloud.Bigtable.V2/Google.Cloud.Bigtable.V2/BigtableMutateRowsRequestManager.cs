// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.Linq;
using Google.Api.Gax.Grpc;
using Grpc.Core;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Performs retries for <see cref="BigtableClient.MutateRows(MutateRowsRequest, CallSettings)"/> operations.
    /// </summary>
    internal class BigtableMutateRowsRequestManager
    {
        private readonly MutateRowsRequest _originalRequest;

        /// <summary>
        /// The new request to send. This starts as the original request. If retries occur, this
        /// request will contain the subset of Entries that need to be retried.
        /// </summary>
        internal MutateRowsRequest RetryRequest { get; private set; }
        
        /// <summary>
        /// When doing retries, the retry sends a partial set of the original Entries that failed with a
        /// retryable status. This array contains a mapping of indices from the <see cref="RetryRequest"/> 
        /// to <see cref="_originalRequest"/>.
        /// </summary>
        private int[] _mapToOriginalIndex;

        /// <summary>
        /// This list tracks failed RPC status codes thats should be retried
        /// </summary> 
        private readonly HashSet<int> _rertriableCodes;

        /// <summary>
        /// This array tracks the cumulative set of results across all RPC requests.
        /// Maps to the original request's entries indices.
        /// </summary> 
        private readonly Rpc.Status[] _results;

        private static readonly Rpc.Status StatusInternal = new Rpc.Status
        {
            Code = (int)StatusCode.Internal,
            Message = "Response was not returned for this index"
        };

        private bool _messageIsInvalid;

        private static MutateRowsResponse.Types.Entry CreateEntry(int i, Rpc.Status status)
        {
            return new MutateRowsResponse.Types.Entry { Index = i, Status = status };
        }

        /// <summary>
        /// Contains possible processing statuses
        /// </summary>
        internal enum ProcessingStatus
        {
            /// <summary> All responses produced OK. </summary>
            SUCCESS,

            /// <summary> All responses produced OK or a retryable code. </summary>
            RETRYABLE,

            /// <summary> All responses had a non-retryable code. </summary>
            NOT_RETRYABLE,

            /// <summary> The response was invalid, missing index, etc. </summary>
            INVALID
        }

        /// <summary>
        /// Constructor for retrying failed mutation entries.
        /// </summary>
        /// <param name="retryStatuses">
        /// Collection of Grpc status codes to retry on.</param>
        /// <param name="mutateRowsRequest">
        /// <see cref="MutateRowsRequest"/> that was received from the user.</param>
        internal BigtableMutateRowsRequestManager(IEnumerable<StatusCode> retryStatuses, MutateRowsRequest mutateRowsRequest)
        {
            _originalRequest = mutateRowsRequest;
            //RetryRequest = null;

            _results = new Rpc.Status[_originalRequest.Entries.Count];

            // This is a map between RetryRequest and _originalRequest. For now, 
            //RetryRequest == _originalRequest, but they could diverge if a retry occurs.
            _mapToOriginalIndex = Enumerable.Range(0, _originalRequest.Entries.Count).ToArray();
            
            _rertriableCodes = new HashSet<int>(retryStatuses.Select(status => (int)status));
        }

        /// <summary>
        /// Adds the content of the MutateRowsResponse message to the <see cref="_results"/>
        /// </summary>
        /// <param name="response">
        /// A MutateRowsResponse message received from MutateRows call.</param>
        internal void SetStatus(MutateRowsResponse response)
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
                _results[_mapToOriginalIndex[index]] = entry.Status;
            }
        }

        /// <summary>
        /// This method is called when all calls to <see cref="SetStatus(MutateRowsResponse)"/> are complete.
        /// </summary>
        /// <returns>
        /// ProcessingStatus of the accumulated responses - success, invalid, retryable, non-retryable.
        /// </returns>
        internal ProcessingStatus OnOk()
        {
            // Sanity check to make sure that every mutation received a response.
            _messageIsInvalid = _messageIsInvalid || _results.Any(result => result == null);
            
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
            for (int i = 0; i < _results.Length; i++)
            {
                Rpc.Status status = _results[i];
                if (status.Code == (int)StatusCode.OK)
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
                    RetryRequest = null;
                    break;
                }
            }

            if (processingStatus == ProcessingStatus.RETRYABLE)
            {
                CreateRetryRequest(toRetry);
            }
            return processingStatus;
        }

        /// <summary>
        /// Creates a new MutateRowsRequest that's a subset of the original request that
        /// corresponds to a set of indices.
        /// </summary>
        /// <param name="indiciesToRetry">
        /// LIst of ints that represents indicies of entries that failed.
        /// </param>
        /// <returns>
        /// Returns new <see cref="MutateRowRequest"/>.
        /// </returns>
        private void CreateRetryRequest(List<int> indiciesToRetry)
        {
            RetryRequest = new MutateRowsRequest();
            _mapToOriginalIndex = new int[indiciesToRetry.Count];
            for (int i = 0; i < _mapToOriginalIndex.Length; i++)
            {
                _mapToOriginalIndex[i] = indiciesToRetry[i];
                RetryRequest.Entries.Add(_originalRequest.Entries[indiciesToRetry[i]]);
            }
        }

        /// <summary>
        /// Builds full response from the accumulation of all calls to
        /// onMessage/onOK.
        /// </summary>
        /// <returns>MutateRowsResponse</returns>
        internal MutateRowsResponse BuildResponse() => new MutateRowsResponse
        {
            Entries = { _results.Select((result, i) => CreateEntry(i, result ?? StatusInternal))}
        };
    }
}
