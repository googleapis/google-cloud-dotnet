// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Api.Gax.Grpc.Testing;
using Google.Cloud.Firestore.V1;
using Grpc.Core;
using System.Collections.Generic;
using System.Linq;
using static Google.Cloud.Firestore.V1.FirestoreClient;

namespace Google.Cloud.Firestore.Tests
{
    /// <summary>
    ///  A query stream that simply returns the responses provided at construction time.
    /// </summary>
    internal class FakeQueryStream : RunQueryStream
    {
        internal FakeQueryStream(IEnumerable<RunQueryResponse> responses)
        {
            var adapter = new AsyncStreamAdapter<RunQueryResponse>(responses.ToAsyncEnumerable().GetAsyncEnumerator(default));
            GrpcCall = new AsyncServerStreamingCall<RunQueryResponse>(adapter, null, null, null, () => { });
        }

        public override AsyncServerStreamingCall<RunQueryResponse> GrpcCall { get; }
    }
}
