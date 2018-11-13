// Copyright 2018 Google LLC
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

using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1.Tests
{
    public partial class SessionPoolTests
    {
        // Note: we can't created a DetachedSessionPool directly, but we can create a SessionPool
        // and recreate a session.
        public sealed class DetachedSessionPoolTests
        {
            [Fact]
            public void ReleaseDetachedSession_NoDelete()
            {
                var logger = new InMemoryLogger();
                var mock = SpannerClientHelpers.CreateMockClient(logger);
                var pool = new SessionPool(mock.Object, new SessionPoolOptions());
                var session = pool.CreateDetachedSession(s_sampleSessionName, s_sampleTransactionId, ModeOneofCase.ReadOnly);

                // No calls to DeleteSession
                session.ReleaseToPool(false);
                logger.AssertNoWarningsOrErrors();
            }

            [Fact]
            public void ReleaseDetachedSession_Delete()
            {
                var logger = new InMemoryLogger();
                var mock = SpannerClientHelpers.CreateMockClient(logger);
                // We will force the session to be deleted, so check it happens in the mock.
                mock.Setup(client => client.DeleteSessionAsync(new DeleteSessionRequest { SessionName = s_sampleSessionName }, null))
                    .Returns(Task.FromResult(0))
                    .Verifiable();

                var pool = new SessionPool(mock.Object, new SessionPoolOptions());
                var session = pool.CreateDetachedSession(s_sampleSessionName, s_sampleTransactionId, ModeOneofCase.ReadOnly);

                // Logically, the deletion happens asynchronously. However, everything completes synchronously so we don't need
                // to sleep or anything to wait for the call to come through.
                session.ReleaseToPool(true);
                logger.AssertNoWarningsOrErrors();
                mock.Verify();
            }
        }
    }
}
