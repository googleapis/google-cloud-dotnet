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
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Datastore.V1Beta3.CommitRequest.Types;
using static Google.Datastore.V1Beta3.PropertyFilter.Types;
using static Google.Datastore.V1Beta3.ReadOptions.Types;

namespace Google.Datastore.V1Beta3.Snippets
{
    [Collection(nameof(DatastoreSnippetFixture))]
    public class DatastoreClientSnippets
    {
        private readonly DatastoreSnippetFixture _fixture;

        public DatastoreClientSnippets(DatastoreSnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Lookup()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Lookup
            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "book");
            Key key1 = keyFactory.CreateKey("pride_and_prejudice");
            Key key2 = keyFactory.CreateKey("not_present");

            DatastoreClient client = DatastoreClient.Create();
            LookupResponse response = client.Lookup(
                projectId,
                new ReadOptions { ReadConsistency = ReadConsistency.Strong },
                new[] { key1, key2 });
            Console.WriteLine($"Found: {response.Found.Count}");
            Console.WriteLine($"Deferred: {response.Deferred.Count}");
            Console.WriteLine($"Missing: {response.Missing.Count}");
            // End snippet

            Entity entity = response.Found[0].Entity;
            Assert.Equal("Jane Austen", (string)entity["author"]);
            Assert.Equal("Pride and Prejudice", (string)entity["title"]);
        }

        [Fact]
        public void StructuredQuery()
        {
            string projectId = _fixture.ProjectId;
            PartitionId partitionId = _fixture.PartitionId;
            string kind = _fixture.BookKind;

            // Snippet: RunQuery(string,PartitionId,ReadOptions,Query,CallSettings)
            DatastoreClient client = DatastoreClient.Create();
            Query query = new Query
            {
                Kind = { new KindExpression { Name = kind } },
                Filter = new Filter
                {
                    PropertyFilter = new PropertyFilter
                    {
                        Property = new PropertyReference("author"),
                        Op = Operator.Equal,
                        Value = "Jane Austen"
                    }
                }
            };
            RunQueryResponse response = client.RunQuery(
                projectId,
                partitionId,
                new ReadOptions { ReadConsistency = ReadConsistency.Eventual },
                query);

            foreach (EntityResult result in response.Batch.EntityResults)
            {
                Console.WriteLine(result.Entity);
            }
            // EndSnippet

            Assert.Equal(1, response.Batch.EntityResults.Count);
            Entity entity = response.Batch.EntityResults[0].Entity;
            Assert.Equal("Jane Austen", (string)entity["author"]);
            Assert.Equal("Pride and Prejudice", (string)entity["title"]);
        }

        [Fact]
        public void GqlQuery()
        {
            string projectId = _fixture.ProjectId;
            PartitionId partitionId = _fixture.PartitionId;
            string kind = _fixture.BookKind;

            // Snippet: RunQuery(string,PartitionId,ReadOptions,GqlQuery,CallSettings)
            DatastoreClient client = DatastoreClient.Create();
            GqlQuery gqlQuery = new GqlQuery
            {
                QueryString = "SELECT * FROM book WHERE author = @author",
                NamedBindings = { { "author", new GqlQueryParameter { Value = "Jane Austen" } } },
            };
            RunQueryResponse response = client.RunQuery(
                projectId,
                partitionId,
                new ReadOptions { ReadConsistency = ReadConsistency.Eventual },
                gqlQuery);

            foreach (EntityResult result in response.Batch.EntityResults)
            {
                Console.WriteLine(result.Entity);
            }
            // End snippet

            Assert.Equal(1, response.Batch.EntityResults.Count);
            Entity entity = response.Batch.EntityResults[0].Entity;
            Assert.Equal("Jane Austen", (string)entity["author"]);
            Assert.Equal("Pride and Prejudice", (string)entity["title"]);
        }

        [Fact]
        public void AddEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // TODO: Fix transaction handling. (Should roll back automatically.)

            // Snippet: Commit(string,Mode,ByteString,*,CallSettings)
            DatastoreClient client = DatastoreClient.Create();
            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "book");
            Entity book1 = new Entity
            {
                Key = keyFactory.CreateInsertionKey(),
                ["author"] = "Harper Lee",
                ["title"] = "To Kill a Mockingbird",
                ["publication_date"] = new DateTime(1960, 7, 11, 0, 0, 0, DateTimeKind.Utc)
            };
            Entity book2 = new Entity
            {
                Key = keyFactory.CreateInsertionKey(),
                ["author"] = "Charlotte Brontë",
                ["title"] = "Jane Eyre",
                ["publication_date"] = new DateTime(1847, 10, 16, 0, 0, 0, DateTimeKind.Utc)
            };
            ByteString transaction = client.BeginTransaction(projectId).Transaction;
            CommitResponse response = client.Commit(
                projectId,
                Mode.Transactional,
                transaction,
                new[] { book1.ToInsert(), book2.ToInsert() });

            IEnumerable<Key> insertedKeys = response.MutationResults.Select(r => r.Key);
            Console.WriteLine($"Inserted keys: {string.Join(",", insertedKeys)}");
            // End snippet
        }

        [Fact]
        public void Overview()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            // Snippet: Overview
            var client = DatastoreClient.Create();

            var keyFactory = new KeyFactory(projectId, namespaceId, "message");
            var entity = new Entity
            {
                Key = keyFactory.CreateInsertionKey(),
                ["created"] = DateTime.UtcNow,
                ["text"] = "Text of the message"
            };
            var transaction = client.BeginTransaction(projectId).Transaction;
            var commitResponse = client.Commit(projectId, Mode.Transactional, transaction, new[] { entity.ToInsert() });
            var insertedKey = commitResponse.MutationResults[0].Key;
            // End snippet
        }
    }
}
