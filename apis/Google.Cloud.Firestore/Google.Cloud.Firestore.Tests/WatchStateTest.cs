// Copyright 2019, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Firestore.V1;
using Grpc.Core;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    /// <summary>
    /// Most tests for WatchState are via proto conformance tests. This class is used for tests
    /// which aren't currently in that set.
    /// </summary>
    public class WatchStateTest
    {
        [Fact]
        public async Task TargetRemoved()
        {
            var db = FirestoreDb.Create("project", "database", new FakeFirestoreClient());
            var query = db.Collection("col");

            var state = new WatchState(query, (snapshot, token) => throw new Exception("Unexpected callback"));
            string message = "MESSAGE_TO_FIND";
            var response = new ListenResponse
            {
                TargetChange = new TargetChange
                {
                    TargetChangeType = TargetChange.Types.TargetChangeType.Remove,
                    TargetIds = { WatchStream.WatchTargetId },
                    Cause = new Rpc.Status { Code = (int) Rpc.Code.ResourceExhausted, Message = message }
                }
            };
            var exception = await Assert.ThrowsAsync<RpcException>(() => state.HandleResponseAsync(response, default));

            Assert.Equal(StatusCode.ResourceExhausted, exception.StatusCode);
            Assert.Contains(message, exception.Message);
        }
    }
}
