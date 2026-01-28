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

using System;
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
            private static readonly TimeSpan s_releaseWaitTime = TimeSpan.FromSeconds(1);

            [Fact]
            public async Task ReleaseDetachedSession_NoRollback()
            {
                var logger = new InMemoryLogger();
                var mock = SpannerClientHelpers.CreateMockClient(logger);
                var pool = new SessionPool(mock, new SessionPoolOptions());
                var session = pool.CreateDetachedSession(s_sampleSessionName, s_sampleTransactionId, ModeOneofCase.ReadOnly);

                // No calls to any method, we haven't configure anything.
                session.ReleaseToPool(false);
                // We wait a little in real time because ReleaseToPool ends up disposing but
                // in a fire and forget manner.
                await Task.Delay(s_releaseWaitTime);
                logger.AssertNoWarningsOrErrors();
                
            }
        }
    }
}
