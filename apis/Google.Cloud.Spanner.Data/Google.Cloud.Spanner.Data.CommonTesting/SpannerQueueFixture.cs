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

using Google.Cloud.Spanner.V1.Internal.Logging;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    /// <summary>
    /// Base classes for test fixtures for queues.
    /// </summary>
    public abstract class SpannerQueueFixture : SpannerFixtureBase, IAsyncLifetime
    {
        public string QueueName { get; }

        public SpannerQueueFixture(string queueName)
        {
            QueueName = queueName;
        }

        /// <summary>
        /// Creates the queue. This method is only called when a new database has been created.
        /// </summary>
        protected abstract Task CreateQueue();

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
            RetryHelpers.ResetStats();
            Logger.DefaultLogger.Debug($"Ready to run tests");
            RetryHelpers.MaybeLogStats($"Population of {QueueName}");
            RetryHelpers.ResetStats();
        }

        public Task DisposeAsync() => Task.CompletedTask;
    }
}
