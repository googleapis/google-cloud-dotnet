// Copyright 2016 Google Inc. All Rights Reserved.
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
using Google.Cloud.ClientTesting;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Datastore.V1.IntegrationTests
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// All entities use the same partition, which is then wiped at the end of the run.
    /// </summary>
    [CollectionDefinition(nameof(DatastoreFixture))]
    public sealed class DatastoreFixture : CloudProjectFixtureBase, ICollectionFixture<DatastoreFixture>
    {
        private const int RetryCount = 10;
        private static readonly TimeSpan RetryDelay = TimeSpan.FromSeconds(3);

        public string NamespaceId { get; }
        public PartitionId PartitionId => new PartitionId { ProjectId = ProjectId, NamespaceId = NamespaceId };

        public DatastoreFixture()
        {
            NamespaceId = IdGenerator.FromDateTime(prefix: "test-");
        }

        public override void Dispose()
        {
            var client = DatastoreClient.Create();
            // Delete all the entities in our partition.
            // TODO: Transactions? Paging?
            var query = new Query { Projection = { DatastoreConstants.KeyProperty } };
            var response = client.RunQuery(new RunQueryRequest { ProjectId = ProjectId, PartitionId = PartitionId, Query = query });
            var deletions = response.Batch.EntityResults.Select(entityResult => entityResult.Entity.ToDelete());
            client.Commit(ProjectId, CommitRequest.Types.Mode.NonTransactional, deletions);
        }

        // Helper methods to retry query operations. Global queries are eventually consistent, so we retry queries for a short while.
        // (Most of the time the results are valid immediately anyway, in practice.)
        public void RetryQuery(Action check)
        {
            int attempt = 0;
            while (true)
            {
                try
                {
                    check();
                    return;
                }
                catch (Exception) when (attempt < RetryCount)
                {
                    attempt++;
                    Thread.Sleep(RetryDelay);
                }
            }
        }

        public async Task RetryQueryAsync(Func<Task> check)
        {
            int attempt = 0;
            while (true)
            {
                try
                {
                    await check().ConfigureAwait(false);
                    return;
                }
                catch (Exception) when (attempt < RetryCount)
                {
                    attempt++;
                    await Task.Delay(RetryDelay);
                }
            }
        }

        public DatastoreDb CreateDatastoreDb(string namespaceId = null)
        {
            string effectiveNamespace = namespaceId ?? NamespaceId;
            var builder = new DatastoreDbBuilder
            {
                ProjectId = ProjectId,
                NamespaceId = effectiveNamespace,
                EmulatorDetection = EmulatorDetection.ProductionOrEmulator
            };
            return builder.Build();
        }
    }
}
