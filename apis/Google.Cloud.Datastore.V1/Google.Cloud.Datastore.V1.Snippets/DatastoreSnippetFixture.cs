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
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Datastore.V1.Snippets
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// All entities use the same partition, which is then wiped at the end of the run.
    /// </summary>
    [CollectionDefinition(nameof(DatastoreSnippetFixture))]
    public sealed class DatastoreSnippetFixture : IDisposable, ICollectionFixture<DatastoreSnippetFixture>
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";

        public string ProjectId { get; }
        public string NamespaceId { get; }
        public PartitionId PartitionId => new PartitionId { ProjectId = ProjectId, NamespaceId = NamespaceId };
        public string BookKind = "book";
        public string TaskKind = "Task";
        private Key _prideAndPrejudiceKey;
        public Key PrideAndPrejudiceKey => _prideAndPrejudiceKey.Clone();
        private Key _learnDatastoreKey;
        public Key LearnDatastoreKey => _learnDatastoreKey.Clone();

        public DatastoreSnippetFixture()
        {
            ProjectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }
            NamespaceId = "test-" + Guid.NewGuid();
            AddSampleBooks();
            AddSampleTasks();
        }

        private void AddSampleBooks()
        {
            var client = DatastoreClient.Create();
            var keyFactory = new KeyFactory(ProjectId, NamespaceId, BookKind);
            var entity = new Entity
            {
                Key = keyFactory.CreateKey("pride_and_prejudice"),
                ["title"] = "Pride and Prejudice",
                ["publication_date"] = new DateTime(1813, 1, 28, 0, 0, 0, DateTimeKind.Utc),
                ["author"] = "Jane Austen"
            };
            var response = client.Commit(ProjectId, CommitRequest.Types.Mode.NonTransactional, new[] { entity.ToInsert() });
            _prideAndPrejudiceKey = response.MutationResults[0].Key;
        }

        private void AddSampleTasks()
        {
            var client = DatastoreClient.Create();
            var keyFactory = new KeyFactory(ProjectId, NamespaceId, TaskKind);
            var entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["category"] = "Personal",
                ["done"] = false,
                ["priority"] = 4,
                ["description"] = "Learn Cloud Datastore",
                ["percent_complete"] = 75.0
            };
            var response = client.Commit(ProjectId, CommitRequest.Types.Mode.NonTransactional, new[] { entity.ToInsert() });
            _learnDatastoreKey = response.MutationResults[0].Key;
        }

        public void Dispose()
        {
            var client = DatastoreClient.Create();
            // Delete all the entities in our partition.
            // TODO: Transactions? Paging?
            var query = new Query { Projection = { DatastoreConstants.KeyProperty } };
            var response = client.RunQuery(new RunQueryRequest { ProjectId = ProjectId, PartitionId = PartitionId, Query = query });
            var deletions = response.Batch.EntityResults.Select(entityResult => entityResult.Entity.ToDelete());
            client.Commit(ProjectId, CommitRequest.Types.Mode.NonTransactional, deletions);
        }
    }
}
