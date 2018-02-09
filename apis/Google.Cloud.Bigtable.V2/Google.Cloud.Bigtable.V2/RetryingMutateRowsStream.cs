// Copyright 2018 Google Inc. All rights reserved.
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

using Google.Api.Gax.Grpc;
using Grpc.Core;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

using static Google.Cloud.Bigtable.V2.BigtableMutateRowsRequestManager;

namespace Google.Cloud.Bigtable.V2
{
    internal class RetryingMutateRowsStream : BigtableClient.MutateRowsStream
    {
        private readonly CallSettings _callSettings;
        private readonly BigtableClient _client;
        private readonly MutateRowsRequest _initialRequest;
        private readonly BigtableClient.MutateRowsStream _initialStream;
        private readonly RetryingResponseEnumerator _responseEnumerator;
        private readonly RetrySettings _streamRetrySettings;

        private BigtableClient.MutateRowsStream _currentStream;

        internal RetryingMutateRowsStream(
            BigtableClient client,
            MutateRowsRequest initialRequest,
            BigtableClient.MutateRowsStream initialStream,
            CallSettings callSettings,
            RetrySettings streamRetrySettings)
        {
            Debug.Assert(!(initialStream is RetryingMutateRowsStream));
            Debug.Assert(callSettings.Timing?.Retry == null);

            _client = client;
            _initialRequest = initialRequest;
            _initialStream = initialStream;
            _currentStream = initialStream;
            _callSettings = callSettings;
            _streamRetrySettings = streamRetrySettings;

            _responseEnumerator = new RetryingResponseEnumerator(this);
        }

        /// <inheritdoc/>
        public override AsyncServerStreamingCall<MutateRowsResponse> GrpcCall => _currentStream.GrpcCall;

        /// <inheritdoc/>
        public override IAsyncEnumerator<MutateRowsResponse> ResponseStream => _responseEnumerator;

        private class RetryingResponseEnumerator : IAsyncEnumerator<MutateRowsResponse>
        {
            private readonly RetryingMutateRowsStream _owner;
            private bool _hasBeenEnumerated;

            public RetryingResponseEnumerator(RetryingMutateRowsStream owner)
            {
                _owner = owner;
            }

            public MutateRowsResponse Current { get; private set; }

            public void Dispose() { }

            public async Task<bool> MoveNext(CancellationToken cancellationToken)
            {
                if (_hasBeenEnumerated)
                {
                    return false;
                }

                _hasBeenEnumerated = true;
                
                // TODO: Should the request manager be using the retry filter? We would need to fabricate RpcExceptions
                StatusCode[] retryStatuses = { StatusCode.DeadlineExceeded, StatusCode.Unavailable };
                var requestManager = new BigtableMutateRowsRequestManager(retryStatuses, _owner._initialRequest);

                var status = await ProcessResult(requestManager, _owner._initialStream, cancellationToken).ConfigureAwait(false);
                if (status == ProcessingStatus.Retryable)
                {
                    var retryInvoker = ApiCallRetryExtensions.WithRetry<MutateRowsRequest, BigtableClient.MutateRowsStream>(
                        (request, callSettings) =>
                        {
                            // We should never be retrying the retry requests.
                            Debug.Assert(callSettings?.Timing?.Retry == null);
                            _owner._currentStream = _owner._client.MutateRows(requestManager.RetryRequest, callSettings);
                            return Task.FromResult(_owner._currentStream);
                        },
                        _owner._client.Clock,
                        _owner._client.Scheduler,
                        async retryResponse => 
                            await ProcessResult(requestManager, retryResponse, cancellationToken).ConfigureAwait(false) != ProcessingStatus.Retryable,
                        _owner._streamRetrySettings);

                    await retryInvoker(null, _owner._callSettings).ConfigureAwait(false);
                }
                Current = requestManager.BuildResponse();
                return true;
            }

            private async Task<ProcessingStatus> ProcessResult(
                BigtableMutateRowsRequestManager requestManager,
                BigtableClient.MutateRowsStream result,
                CancellationToken cancellationToken)
            {
                var stream = result.ResponseStream;
                while (await stream.MoveNext(cancellationToken).ConfigureAwait(false))
                {
                    requestManager.SetStatus(stream.Current);
                }
                return requestManager.OnOk();
            }
        }
    }
}

