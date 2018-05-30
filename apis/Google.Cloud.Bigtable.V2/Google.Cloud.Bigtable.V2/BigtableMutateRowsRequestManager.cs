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
        /// The next request to send. This starts as the original request. If retries occur, this
        /// request will contain the subset of Entries that need to be retried.
        /// </summary>
        internal MutateRowsRequest NextRequest { get; private set; }

        /// <summary>
        /// When doing retries, the retry sends a partial set of the original Entries that failed with a
        /// retryable status. This array contains a mapping of indices from the <see cref="NextRequest"/> 
        /// to <see cref="_originalRequest"/>.
        /// </summary>
        private int[] _mapToOriginalIndex;

        /// <summary>
        /// This set tracks failed RPC status codes thats should be retried
        /// </summary> 
        private readonly HashSet<int> _retryableCodes;

        /// <summary>
        /// This array tracks the cumulative set of results across all RPC requests.
        /// Maps to the original request's entries indices.
        /// </summary> 
        private readonly Rpc.Status[] _results;

        private bool _messageIsInvalid;

        private static Rpc.Status StatusInternal => new Rpc.Status
        {
            Code = (int)StatusCode.Internal,
            Message = "Response was not returned for this index"
        };

        private static MutateRowsResponse.Types.Entry CreateEntry(int i, Rpc.Status status) =>
            new MutateRowsResponse.Types.Entry {Index = i, Status = status};

        /// <summary>
        /// Contains possible processing statuses
        /// </summary>
        internal enum ProcessingStatus
        {
            /// <summary> All responses produced OK or a retryable code. </summary>
            Retryable,

            /// <summary> All responses produced OK or at least one response had a non-retryable code. </summary>
            NotRetryable,

            /// <summary> The response was invalid, missing index, etc. </summary>
            Invalid
        }

        /// <summary>
        /// Constructor for <see cref="BigtableMutateRowsRequestManager"/>.
        /// </summary>
        /// <param name="retryStatuses">
        /// Collection of Grpc status codes to retry on.</param>
        /// <param name="mutateRowsRequest"><see cref="MutateRowsRequest"/> that was received from the user.</param>
        internal BigtableMutateRowsRequestManager(IEnumerable<StatusCode> retryStatuses, MutateRowsRequest mutateRowsRequest)
        {
            _originalRequest = mutateRowsRequest;
            NextRequest = _originalRequest;

            _results = new Rpc.Status[_originalRequest.Entries.Count];
            
            _retryableCodes = new HashSet<int>(retryStatuses.Select(status => (int)status));
        }

        /// <summary>
        /// Reads MutateRowsResponse message and saves the statuses of all request Entries.
        /// </summary>
        /// <param name="response">
        /// A MutateRowsResponse message received from MutateRows call.</param>
        internal void SetStatus(MutateRowsResponse response)
        {
            foreach (var entry in response.Entries)
            {
                int index = (int)entry.Index;
                if (_mapToOriginalIndex != null)
                {
                    if (index >= _mapToOriginalIndex.Length || index < 0)
                    {
                        _messageIsInvalid = true;
                        break;
                    }
                    index = _mapToOriginalIndex[index];
                }
                if (index >= _results.Length || index < 0)
                {
                    _messageIsInvalid = true;
                    break;
                }
                // Set the result
                _results[index] = entry.Status;
            }
        }

        /// <summary>
        /// This method is called when all calls to <see cref="SetStatus(MutateRowsResponse)"/> are complete.
        /// </summary>
        /// <returns>
        /// ProcessingStatus of the accumulated responses - invalid, retryable, non-retryable.
        /// </returns>
        internal ProcessingStatus OnOk()
        {
            // Sanity check to make sure that every mutation received a response.
            _messageIsInvalid = _messageIsInvalid || _results.Any(result => result == null);
            
            // There was a problem in the data found in SetStatus(), so fail the RPC.
            if (_messageIsInvalid)
            {
                return ProcessingStatus.Invalid;
            }

            // This list hold indices of entries to be included in retry request
            List<int> toRetry = null;
            ProcessingStatus processingStatus = ProcessingStatus.NotRetryable;

            // Check the current state to determine the state of the results.
            // There are three states: OK, Fail, or Partial Retry.
            for (int i = 0; i < _results.Length; i++)
            {
                Rpc.Status status = _results[i];
                if (status.Code == (int)StatusCode.OK)
                {
                    continue;
                }
                if (_retryableCodes.Contains(status.Code))
                {
                    if (toRetry == null)
                    {
                        toRetry = new List<int>();
                    }
                    // An individual mutation failed with a retryable code, usually DEADLINE_EXCEEDED.
                    toRetry.Add(i);
                    processingStatus = ProcessingStatus.Retryable;
                }
                else
                {
                    // Don't retry if even a single response is not retryable.
                    processingStatus = ProcessingStatus.NotRetryable;
                    break;
                }
            }

            if (processingStatus == ProcessingStatus.Retryable)
            {
                CreateRetryRequest(toRetry);
            }
            else
            {
                NextRequest = null;
            }
            return processingStatus;
        }

        /// <summary>
        /// Creates a new MutateRowsRequest that's a subset of the original request that
        /// corresponds to a set of indices.
        /// </summary>
        /// <param name="indiciesToRetry">
        /// List of ints that represents indicies of entries that failed.
        /// </param>
        private void CreateRetryRequest(List<int> indiciesToRetry)
        {
            NextRequest = new MutateRowsRequest
            {
                TableName = _originalRequest.TableName,
                AppProfileId = _originalRequest.AppProfileId
            };
            _mapToOriginalIndex = new int[indiciesToRetry.Count];
            for (int i = 0; i < _mapToOriginalIndex.Length; i++)
            {
                _mapToOriginalIndex[i] = indiciesToRetry[i];
                NextRequest.Entries.Add(_originalRequest.Entries[indiciesToRetry[i]]);
            }
        }

        /// <summary>
        /// Builds full response from the accumulation of all calls to
        /// <see cref="SetStatus"/> and <see cref="OnOk"/>.
        /// </summary>
        /// <returns>MutateRowsResponse</returns>
        internal MutateRowsResponse BuildResponse() => new MutateRowsResponse
        {
            Entries = { _results.Select((result, i) => CreateEntry(i, result ?? StatusInternal))}
        };
    }
}
