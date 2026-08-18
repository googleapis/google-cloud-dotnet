// Copyright 2026 Google LLC
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

using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1.Internal.Logging;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    /// <summary>
    /// TBase classes for test fixture for queues.
    /// </summary>
    [CollectionDefinition(nameof(SpannerQueueFixture))]
    public class SpannerQueueFixture : SpannerFixtureBase, ICollectionFixture<SpannerQueueFixture>, IAsyncLifetime
    {
        public string QueueName => "QueueTest";

        /// <summary>
        /// Creates the queue. This method is only called when a new database has been created.
        /// </summary>
        protected async Task CreateQueue() => await ExecuteDdl(
            $@"CREATE QUEUE {QueueName} (
                UserId        STRING(100) NOT NULL,
                MessageId     STRING(100) NOT NULL,
                Payload       BYTES(MAX) NOT NULL,
                ) PRIMARY KEY(UserId, MessageId),
                OPTIONS(receive_mode= ""PULL"")");

        protected async Task ExecuteDdl(string ddl)
        {
            using var connection = GetConnection();
            _ = await connection.CreateDdlCommand(ddl).ExecuteNonQueryAsync();
        }

        public override void Dispose()
        {
            base.Dispose();
            RetryHelpers.MaybeLogStats($"Disposal of fixture for {QueueName}");
        }

        public async Task InitializeAsync()
        {
            if (Database.Fresh)
            {
                Logger.DefaultLogger.Debug($"Creating queue {QueueName}");
                await CreateQueue();
            }
        }

        public Task DisposeAsync() => Task.Run(Dispose);
    }
}
