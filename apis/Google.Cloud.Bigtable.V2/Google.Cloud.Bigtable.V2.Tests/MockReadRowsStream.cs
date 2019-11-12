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

using Grpc.Core;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class MockReadRowsStream : BigtableServiceApiClient.ReadRowsStream
    {
        private readonly ReadRowsResponse[] _responses;
        private readonly AsyncServerStreamingCall<ReadRowsResponse> _call;

        public MockReadRowsStream(params ReadRowsResponse[] responses)
        {
            _responses = responses;
            var reader = new ResponseReader(this, responses.ToAsyncEnumerable().GetAsyncEnumerator());
            _call = new AsyncServerStreamingCall<ReadRowsResponse>(reader, null, () => Status.DefaultSuccess, null, () => { });
        }

        public IEnumerable<ReadRowsResponse> Responses => _responses;

        /// <summary>
        /// Indicates whether the <see cref="ResponseStream"/> should throw an Unavailable
        /// <see cref="RpcException"/> after providing all responses, as opposed to finishing normally.
        /// </summary>
        public bool ShouldErrorAtEnd { get; set; }

        public override AsyncServerStreamingCall<ReadRowsResponse> GrpcCall => _call;

        private class ResponseReader : IAsyncStreamReader<ReadRowsResponse>
        {
            private readonly MockReadRowsStream _owner;
            private IAsyncEnumerator<ReadRowsResponse> _underlyingStream;

            public ResponseReader(MockReadRowsStream owner, IAsyncEnumerator<ReadRowsResponse> underlyingStream)
            {
                _owner = owner;
                _underlyingStream = underlyingStream;
            }

            public ReadRowsResponse Current { get; set; }

            // No-op rather than starting asynchronous disposal. This is only ever for an array anyway.
            public void Dispose() { }

            public async Task<bool> MoveNext(CancellationToken cancellationToken)
            {
                if (await _underlyingStream.MoveNextAsync(cancellationToken))
                {
                    Current = _underlyingStream.Current;
                    return true;
                }

                if (_owner.ShouldErrorAtEnd)
                {
                    throw new RpcException(new Status(StatusCode.Unavailable, "Unavailable"));
                }

                return false;
            }
        }
    }
}
