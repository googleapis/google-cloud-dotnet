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
using static Google.Cloud.Datastore.V1.CommitRequest.Types;
using static Google.Cloud.Datastore.V1.PropertyOrder.Types;
using static Google.Cloud.Datastore.V1.ReadOptions.Types;

namespace Google.Cloud.Datastore.V1.Snippets
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

            // Snippet: Lookup(*,*,*,*)
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
        public void RunQuery()
        {
            string projectId = _fixture.ProjectId;
            PartitionId partitionId = _fixture.PartitionId;
            
            // Snippet: RunQuery(RunQueryRequest,*)
            DatastoreClient client = DatastoreClient.Create();

            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = projectId,
                PartitionId = partitionId,
                ReadOptions = new ReadOptions { ReadConsistency = ReadConsistency.Eventual },
            };
            // Structured query
            request.Query = new Query("book")
            {
                Filter = Filter.Equal("author", "Jane Austen")
            };
            RunQueryResponse response = client.RunQuery(request);
            foreach (EntityResult result in response.Batch.EntityResults)
            {
                Console.WriteLine(result.Entity);
            }

            // Equivalent GQL query
            request.GqlQuery = new GqlQuery
            {
                QueryString = "SELECT * FROM book WHERE author = @author",
                NamedBindings = { { "author", "Jane Austen" } },
            };
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

            // Sample: AddEntity
            DatastoreClient client = DatastoreClient.Create();
            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "book");
            Entity book1 = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["author"] = "Harper Lee",
                ["title"] = "To Kill a Mockingbird",
                ["publication_date"] = new DateTime(1960, 7, 11, 0, 0, 0, DateTimeKind.Utc),
                ["genres"] = new[] { "Southern drama", "Courtroom drama", "Bildungsroman" }
            };
            Entity book2 = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["author"] = "Charlotte Brontë",
                ["title"] = "Jane Eyre",
                ["publication_date"] = new DateTime(1847, 10, 16, 0, 0, 0, DateTimeKind.Utc),
                ["genres"] = new[] { "Gothic", "Romance", "Bildungsroman" }
            };

            ByteString transactionId = client.BeginTransaction(projectId).Transaction;
            using (DatastoreTransaction transaction = DatastoreTransaction.Create(client, projectId, namespaceId, transactionId))
            {
                transaction.Insert(book1, book2);
                CommitResponse response = transaction.Commit();
                IEnumerable<Key> insertedKeys = response.MutationResults.Select(r => r.Key);
                Console.WriteLine($"Inserted keys: {string.Join(",", insertedKeys)}");
            }
            // End sample
        }

        [Fact]
        public void AllocateIds()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: AllocateIds(*,*,*)
            DatastoreClient client = DatastoreClient.Create();
            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "message");
            AllocateIdsResponse response = client.AllocateIds(projectId,
                new[] { keyFactory.CreateIncompleteKey(), keyFactory.CreateIncompleteKey() }
            );
            Entity entity1 = new Entity { Key = response.Keys[0], ["text"] = "Text 1" };
            Entity entity2 = new Entity { Key = response.Keys[1], ["text"] = "Text 2" };
            // End snippet

            Assert.NotEqual(entity1, entity2);
        }

        [Fact]
        public void NamespaceQuery()
        {
            string projectId = _fixture.ProjectId;

            // Sample: NamespaceQuery
            DatastoreClient client = DatastoreClient.Create();
            PartitionId partitionId = new PartitionId(projectId);
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = projectId,
                PartitionId = partitionId,
                Query = new Query(DatastoreConstants.NamespaceKind)
            };
            RunQueryResponse response = client.RunQuery(request);
            foreach (EntityResult result in response.Batch.EntityResults)
            {
                Console.WriteLine(result.Entity.Key.Path.Last().Name);
            }
            // End sample
        }

        [Fact]
        public void KindQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            PartitionId partitionId = new PartitionId(projectId, namespaceId);

            // Sample: KindQuery
            DatastoreClient client = DatastoreClient.Create();
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = projectId,
                PartitionId = partitionId,
                Query = new Query(DatastoreConstants.KindKind)
            };
            RunQueryResponse response = client.RunQuery(request);
            foreach (EntityResult result in response.Batch.EntityResults)
            {
                Console.WriteLine(result.Entity.Key.Path.Last().Name);
            }
            // End sample
        }

        [Fact]
        public void PropertyQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            PartitionId partitionId = new PartitionId(projectId, namespaceId);

            // Sample: PropertyQuery
            DatastoreClient client = DatastoreClient.Create();
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = projectId,
                PartitionId = partitionId,
                Query = new Query(DatastoreConstants.PropertyKind)
                {
                    Projection = { DatastoreConstants.KeyProperty }
                }
            };
            RunQueryResponse response = client.RunQuery(request);
            foreach (EntityResult result in response.Batch.EntityResults)
            {
                Key key = result.Entity.Key;
                string propertyName = key.Path.Last().Name;
                string kind = key.GetParent().Path.Last().Name;
                Console.WriteLine($"Kind: {kind}; Property: {propertyName}");
            }
            // End sample
        }

        [Fact]
        public void Overview()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            // Sample: Overview
            DatastoreClient client = DatastoreClient.Create();

            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "message");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["created"] = DateTime.UtcNow,
                ["text"] = "Text of the message",
                ["tags"] = new[] { "tag1", "tag2" }
            };
            ByteString transactionId = client.BeginTransaction(projectId).Transaction;
            using (DatastoreTransaction transaction = DatastoreTransaction.Create(client, projectId, namespaceId, transactionId))
            {
                transaction.Insert(entity);
                CommitResponse commitResponse = transaction.Commit();
                Key insertedKey = commitResponse.MutationResults[0].Key;
                Console.WriteLine($"Inserted key: {insertedKey}");
            }
            // End sample
        }

        // Snippets ported from https://cloud.google.com/datastore/docs/concepts/entities

        [Fact]
        public void CreateEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Sample: CreateEntity
            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "Task");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["category"] = "Personal",
                ["done"] = false,
                ["priority"] = 4,
                ["description"] = "Learn Cloud Datastore",
                ["percent_complete"] = 75.0
            };
            // End sample
        }

        [Fact]
        public void InsertEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Sample: InsertEntity
            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "Task");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["category"] = "Personal",
                ["done"] = false,
                ["priority"] = 4,
                ["description"] = "Learn Cloud Datastore",
                ["percent_complete"] = 75.0
            };
            DatastoreClient client = DatastoreClient.Create();
            CommitResponse response = client.Commit(projectId, Mode.NonTransactional, new[] { entity.ToInsert() });
            Key insertedKey = response.MutationResults[0].Key;
            // End sample
        }

        [Fact]
        public void LookupEntity()
        {
            string projectId = _fixture.ProjectId;
            Key key = _fixture.LearnDatastoreKey;

            // Sample: LookupEntity
            DatastoreClient client = DatastoreClient.Create();
            LookupResponse response = client.Lookup(
                projectId,
                new ReadOptions { ReadConsistency = ReadConsistency.Eventual },
                new[] { key });

            Entity entity = response.Found[0].Entity;
            // End sample
        }

        [Fact]
        public void UpdateEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            Key key = _fixture.LearnDatastoreKey;

            // Sample: UpdateEntity
            DatastoreClient client = DatastoreClient.Create();
            ByteString transactionId = client.BeginTransaction(projectId).Transaction;
            using (DatastoreTransaction transaction = DatastoreTransaction.Create(client, projectId, namespaceId, transactionId))
            {
                Entity entity = transaction.Lookup(key);
                entity["priority"] = 5;
                transaction.Update(entity);
                transaction.Commit();
            }
            // End sample
        }

        [Fact]
        public void DeleteEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Copied from InsertEntity; we want to create a new one to delete.
            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "Task");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["category"] = "Personal",
                ["done"] = false,
                ["priority"] = 4,
                ["description"] = "Learn Cloud Datastore",
                ["percent_complete"] = 75.0
            };
            DatastoreClient insertClient = DatastoreClient.Create();
            CommitResponse response = insertClient.Commit(projectId, Mode.NonTransactional, new[] { entity.ToInsert() });
            Key key = response.MutationResults[0].Key;

            // Sample: DeleteEntity
            DatastoreClient client = DatastoreClient.Create();
            // If you have an entity instead of just a key, then entity.ToDelete() would work too.
            CommitResponse commit = insertClient.Commit(projectId, Mode.NonTransactional, new[] { key.ToDelete() });
            // End sample
        }

        // Batch lookup etc are currently obvious given the array creation.
        // If we simplify single-entity operations, we may need more snippets here.

        [Fact]
        public void AncestorPaths()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Sample: AncestorPaths
            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "User");
            Key taskKey = keyFactory.CreateKey("alice").WithElement("Task", "sampleTask");

            Key multiLevelKey = keyFactory
                .CreateKey("alice")
                .WithElement("TaskList", "default")
                .WithElement("Task", "sampleTask");
            // End sample
        }

        [Fact]
        public void ArrayProperties()
        {
            // Sample: ArrayProperties
            Entity entity = new Entity
            {
                ["tags"] = new ArrayValue { Values = { "fun", "programming" } },
                ["collaborators"] = new ArrayValue { Values = { "alice", "bob" } }
            };
            // End sample
        }

        // Snippets ported from https://cloud.google.com/datastore/docs/concepts/queries

        [Fact(Skip = "Requires composite index configuration")]
        public void CompositeFilterQuery()
        {
            string projectId = _fixture.ProjectId;
            PartitionId partitionId = _fixture.PartitionId;

            // Sample: CompositeFilter
            Query query = new Query("Task")
            {
                Filter = Filter.And(
                    Filter.Equal("done", false),
                    Filter.GreaterThanOrEqual("priority", 4)
                ),
                Order = { { "priority", Direction.Descending } }
            };

            DatastoreClient client = DatastoreClient.Create();
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = projectId,
                PartitionId = partitionId,
                ReadOptions = new ReadOptions { ReadConsistency = ReadConsistency.Eventual },
                Query = query
            };
            RunQueryResponse response = client.RunQuery(request);
            foreach (EntityResult result in response.Batch.EntityResults)
            {
                Entity entity = result.Entity;
                Console.WriteLine((string)entity["description"]);
            }
            // TODO: Results beyond this batch?
            // End sample
        }

        [Fact]
        public void KeyQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Sample: KeyQuery
            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "Task");
            Query query = new Query("Task")
            {
                Filter = Filter.GreaterThan(DatastoreConstants.KeyProperty, keyFactory.CreateKey("someTask"))
            };
            // End sample
        }

        [Fact]
        public void AncestorQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Sample: AncestorQuery
            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "Task");
            Query query = new Query("Task")
            {
                Filter = Filter.HasAncestor(keyFactory.CreateKey("someTask"))
            };
            // End sample
        }

        [Fact]
        public void KindlessQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Sample: KindlessQuery
            KeyFactory keyFactory = new KeyFactory(projectId, namespaceId, "Task");
            Key lastSeenKey = keyFactory.CreateKey(100L);
            Query query = new Query
            {
                Filter = Filter.GreaterThan(DatastoreConstants.KeyProperty, lastSeenKey)
            };
            // End sample
        }

        [Fact]
        public void KeysOnlyQuery()
        {
            // Sample: KeysOnlyQuery
            Query query = new Query("Task")
            {
                Projection = { DatastoreConstants.KeyProperty }
            };
            // End sample
        }

        [Fact(Skip = "Requires composite index configuration")]
        public void ProjectionQuery()
        {
            string projectId = _fixture.ProjectId;
            PartitionId partitionId = _fixture.PartitionId;

            // Sample: ProjectionQuery
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = projectId,
                PartitionId = partitionId,
                Query = new Query("Task")
                {
                    Projection = { "priority", "percentage_complete" }
                }
            };
            DatastoreClient client = DatastoreClient.Create();
            RunQueryResponse response = client.RunQuery(request);
            foreach (EntityResult result in response.Batch.EntityResults)
            {
                Entity entity = result.Entity;
                Console.WriteLine($"{(int)entity["priority"]}: {(double?)entity["percentage_complete"]}");
            }
            // End sample
        }

        [Fact]
        public void GroupingQuery()
        {
            // Sample: GroupingQuery
            Query query = new Query("Task")
            {
                Projection = { "category", "priority" },
                DistinctOn = { "category" },
                Order =
                {
                    { "category", Direction.Ascending },
                    { "priority", Direction.Ascending }
                }
            };
            // End sample
        }

        [Fact]
        public void ArrayQueryComparison()
        {
            // Sample: ArrayQuery
            Query query = new Query("Task")
            {
                Filter = Filter.And(
                    Filter.GreaterThan("tag", "learn"),
                    Filter.LessThan("tag", "math")
                )
            };
            // End sample
        }

        [Fact]
        public void ArrayQueryEquality()
        {
            // Sample: ArrayQuery
            Query query = new Query("Task")
            {
                Filter = Filter.And(
                    Filter.GreaterThan("equal", "fun"),
                    Filter.LessThan("equal", "programming")
                )
            };
            // End sample
        }

        [Fact]
        public void PaginateWithCursor()
        {
            string projectId = _fixture.ProjectId;
            PartitionId partitionId = _fixture.PartitionId;

            ByteString pageCursor = null;
            int pageSize = 5;
            // Sample: PaginateWithCursor
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = projectId,
                PartitionId = partitionId,
                ReadOptions = new ReadOptions { ReadConsistency = ReadConsistency.Eventual },
                Query = new Query("Task") { Limit = pageSize, StartCursor = pageCursor ?? ByteString.Empty }
            };
            DatastoreClient client = DatastoreClient.Create();

            RunQueryResponse response = client.RunQuery(request);
            foreach (EntityResult result in response.Batch.EntityResults)
            {
                Entity entity = result.Entity;
                // Do something with the task entity
            }
            ByteString nextPageCursor = response.Batch.EndCursor;
            // End sample
        }

        [Fact]
        public void OrderingWithInequalityFilter()
        {
            // Sample: OrderingWithInequalityFilter
            Query query = new Query("Task")
            {
                Filter = Filter.GreaterThan("priority", 3),
                Order =
                {
                    // This property must be sorted first, as it is in the inequality filter
                    // This property must be sorted first, as it is in the inequality filter
                    { "priority", Direction.Ascending },
                    { "created", Direction.Ascending }
                }
            };
            // End sample
        }

        // Snippets ported from https://cloud.google.com/datastore/docs/concepts/transactions

        [Fact]
        public void TransactionReadAndWrite()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            long amount = 1000L;
            Key fromKey = CreateAccount("Jill", 20000L);
            Key toKey = CreateAccount("Beth", 15500L);

            // Sample: TransactionReadAndWrite
            DatastoreClient client = DatastoreClient.Create();
            ByteString transactionId = client.BeginTransaction(projectId).Transaction;
            using (DatastoreTransaction transaction = DatastoreTransaction.Create(client, projectId, namespaceId, transactionId))
            {
                // The return value from DatastoreTransaction.Get contains the fetched entities
                // in the same order as they are in the call.
                IReadOnlyList<Entity> entities = transaction.Lookup(fromKey, toKey);
                Entity from = entities[0];
                Entity to = entities[1];
                from["balance"] = (long)from["balance"] - amount;
                to["balance"] = (long)to["balance"] - amount;
                transaction.Update(from);
                transaction.Update(to);
                transaction.Commit();
            }
            // End sample
        }

        // Used by TransactionReadAndWrite. Could promote to the fixture.
        private Key CreateAccount(string name, long balance)
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            DatastoreClient client = DatastoreClient.Create();
            KeyFactory factory = new KeyFactory(projectId, namespaceId, "Account");
            Entity entity = new Entity
            {
                Key = factory.CreateIncompleteKey(),
                ["name"] = name,
                ["balance"] = balance
            };
            CommitResponse response = client.Commit(projectId, Mode.NonTransactional, new[] { entity.ToInsert() });
            return response.MutationResults[0].Key;
        }
    }
}
