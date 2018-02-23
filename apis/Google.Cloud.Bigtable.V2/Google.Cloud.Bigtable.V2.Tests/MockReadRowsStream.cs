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

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class MockReadRowsStream : ReadRowsStream
    {
        public MockReadRowsStream(params ReadRowsResponse[] responses)
            : base(new UnderlyingReadRowsStream(responses)) { }

        private class UnderlyingReadRowsStream : BigtableServiceApiClient.ReadRowsStream
        {
            private IAsyncEnumerator<ReadRowsResponse> _responseStream;

            public UnderlyingReadRowsStream(params ReadRowsResponse[] responses) =>
                _responseStream = responses.ToAsyncEnumerable().GetEnumerator();

            public override AsyncServerStreamingCall<ReadRowsResponse> GrpcCall => null;
            public override IAsyncEnumerator<ReadRowsResponse> ResponseStream => _responseStream;
        }
    }
}
