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
using Google.Api.Gax;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Datastore.V1Beta3.PropertyOrder.Types;
using static Google.Datastore.V1Beta3.ReadOptions.Types;

namespace Google.Datastore.V1Beta3.Snippets
{
    [Collection(nameof(DatastoreSnippetFixture))]
    public class DatastoreDbSnippets
    {
        private readonly DatastoreSnippetFixture _fixture;

        public DatastoreDbSnippets(DatastoreSnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Lookup()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Lookup(*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("book");
            Key key1 = keyFactory.CreateKey("pride_and_prejudice");
            Key key2 = keyFactory.CreateKey("not_present");

            IReadOnlyList<Entity> entities = db.Lookup(key1, key2);
            Console.WriteLine(entities[0]); // Pride and Prejudice entity
            Console.WriteLine(entities[1]); // Nothing (value is null reference)
            // End snippet

            Entity entity = entities[0];
            Assert.Equal("Jane Austen", (string)entity["author"]);
            Assert.Equal("Pride and Prejudice", (string)entity["title"]);
            Assert.Null(entities[1]);
        }

        [Fact]
        public void StructuredQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQueryPageStream(Query,string,ReadConsistency)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Query query = new Query("book")
            {
                Filter = Filter.Equal("author", "Jane Austen")
            };
            IPagedEnumerable<RunQueryResponse, Entity> results = db.RunQueryPageStream(query);
            foreach (Entity entity in results.Flatten())
            {
                Console.WriteLine(entity);
            }
            // EndSnippet

            // This will run the query again, admittedly...
            List<Entity> entities = results.Flatten().ToList();
            Assert.Equal(1, entities.Count);
            Entity book = entities[0];
            Assert.Equal("Jane Austen", (string)book["author"]);
            Assert.Equal("Pride and Prejudice", (string)book["title"]);
        }

        [Fact]
        public void GqlQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQuery(GqlQuery,string,ReadConsistency)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            GqlQuery gqlQuery = new GqlQuery
            {
                QueryString = "SELECT * FROM book WHERE author = @author",
                NamedBindings = { { "author", new GqlQueryParameter { Value = "Jane Austen" } } },
            };
            // Note: no page streaming for GQL yet.
            RunQueryResponse response = db.RunQuery(gqlQuery);
            foreach (EntityResult result in response.Batch.EntityResults)
            {
                Console.WriteLine(result.Entity);
            }
            // End snippet

            // This will run the query again, admittedly...
            Assert.Equal(1, response.Batch.EntityResults.Count);
            Entity book = response.Batch.EntityResults[0].Entity;
            Assert.Equal("Jane Austen", (string)book["author"]);
            Assert.Equal("Pride and Prejudice", (string)book["title"]);
        }

        [Fact]
        public void AddEntity_Transactional()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: AddEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("book");
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

            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                transaction.Insert(book1, book2);
                CommitResponse response = transaction.Commit();
                IEnumerable<Key> insertedKeys = response.MutationResults.Select(r => r.Key);
                Console.WriteLine($"Inserted keys: {string.Join(",", insertedKeys)}");
            }
            // End snippet
        }

        [Fact]
        public void AddEntity_NonTransactional()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: AddEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("book");
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
            IReadOnlyList<Key> insertedKeys = db.Insert(book1, book2);
            Console.WriteLine($"Inserted keys: {string.Join(",", insertedKeys)}");
            // End snippet
        }

        [Fact]
        public void AllocateId()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: AllocateId
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");
            Key key = db.AllocateId(keyFactory.CreateInsertionKey());
            // End snippet
        }

        [Fact]
        public void AllocateIds()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: AllocateId
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");
            IReadOnlyList<Key> keys = db.AllocateIds(keyFactory.CreateInsertionKey(), keyFactory.CreateInsertionKey());
            // End snippet

            Assert.Equal(2, keys.Count);
            Assert.NotEqual(keys[0], keys[1]);
        }

        [Fact]
        public void NamespaceQuery()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: NamespaceQuery
            DatastoreDb db = DatastoreDb.Create(projectId, "");
            Query query = new Query(DatastoreConstants.NamespaceKind);
            foreach (Entity entity in db.RunQueryPageStream(query).Flatten())
            {
                Console.WriteLine(entity.Key.Path.Last().Name);
            }
            // End snippet
        }

        [Fact]
        public void KindQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: KindQuery
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Query query = new Query(DatastoreConstants.KindKind);
            foreach (Entity entity in db.RunQueryPageStream(query).Flatten())
            {
                Console.WriteLine(entity.Key.Path.Last().Name);
            }
            // End snippet
        }

        [Fact]
        public void PropertyQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: PropertyQuery
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Query query = new Query(DatastoreConstants.PropertyKind);
            foreach (Entity entity in db.RunQueryPageStream(query).Flatten())
            {
                Console.WriteLine(entity.Key.Path.Last().Name);
            }
            // End snippet
        }

        [Fact]
        public void Overview()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            // Snippet: Overview
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);

            var keyFactory = db.CreateKeyFactory("message");
            var entity = new Entity
            {
                Key = keyFactory.CreateInsertionKey(),
                ["created"] = DateTime.UtcNow,
                ["text"] = "Text of the message"
            };
            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                transaction.Insert(entity);
                var commitResponse = transaction.Commit();
                var insertedKey = commitResponse.MutationResults[0].Key;
                Console.WriteLine($"Inserted key: {insertedKey}");
            }
            // End snippet
        }

        // Snippets ported from https://cloud.google.com/datastore/docs/concepts/entities

        [Fact]
        public void CreateEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: CreateEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("Task");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateInsertionKey(),
                ["type"] = "Personal",
                ["done"] = false,
                ["priority"] = 4,
                ["description"] = "Learn Cloud Datastore",
                ["percent_complete"] = 75.0
            };
            // End snippet
        }

        [Fact]
        public void InsertEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: InsertEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("Task");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateInsertionKey(),
                ["type"] = "Personal",
                ["done"] = false,
                ["priority"] = 4,
                ["description"] = "Learn Cloud Datastore",
                ["percent_complete"] = 75.0
            };
            Key insertedKey = db.Insert(entity);
            // End snippet
        }

        [Fact]
        public void LookupEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            Key key = _fixture.LearnDatastoreKey;

            // Snippet: LookupEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Entity entity = db.Lookup(key);
            // End snippet
        }

        [Fact]
        public void UpdateEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            Key key = _fixture.LearnDatastoreKey;

            // Snippet: UpdateEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                Entity entity = transaction.Lookup(key);
                entity["priority"] = 5;
                transaction.Update(entity);
                transaction.Commit();
            }
            // End snippet
        }

        [Fact]
        public void DeleteEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Copied from InsertEntity; we want to create a new one to delete.
            DatastoreDb insertClient = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = insertClient.CreateKeyFactory("Task");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateInsertionKey(),
                ["type"] = "Personal",
                ["done"] = false,
                ["priority"] = 4,
                ["description"] = "Learn Cloud Datastore",
                ["percent_complete"] = 75.0
            };
            Key insertedKey = insertClient.Insert(entity);

            // Snippet: DeleteEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            // If you have an entity instead of just a key, then entity.ToDelete() would work too.
            db.Delete(insertedKey);
            // End snippet
        }

        // Batch lookup etc are currently obvious given the array creation.
        // If we simplify single-entity operations, we may need more snippets here.

        [Fact]
        public void AncestorPaths()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: AncestorPaths
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("User");
            Key taskKey = keyFactory.CreateKey("alice").WithElement("Task", "sampleTask");

            Key multiLevelKey = keyFactory
                .CreateKey("alice")
                .WithElement("TaskList", "default")
                .WithElement("Task", "sampleTask");
            // End snippet
        }

        [Fact]
        public void ArrayProperties()
        {
            // Snippet: ArrayProperties
            Entity entity = new Entity
            {
                ["tags"] = new ArrayValue { Values = { "fun", "programming" } },
                ["collaborators"] = new ArrayValue { Values = { "alice", "bob" } }
            };
            // End snippet
        }

        // Snippets ported from https://cloud.google.com/datastore/docs/concepts/queries

        [Fact(Skip = "Requires composite index configuration")]
        public void CompositeFilterQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: CompositeFilter
            Query query = new Query("Task")
            {
                Filter = Filter.And(
                    Filter.Equal("done", false),
                    Filter.GreaterThanOrEqual("priority", 4)
                ),
                Order = { { "priority", Direction.Descending } },
            };

            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);            
            foreach (Entity entity in db.RunQueryPageStream(query).Flatten())
            {
                Console.WriteLine((string)entity["description"]);
            }
            // TODO: Results beyond this batch?
            // End snippet           
        }

        [Fact]
        public void KeyQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: KeyQuery
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("Task");
            Query query = new Query("Task")
            {
                Filter = Filter.GreaterThan(DatastoreConstants.KeyProperty, keyFactory.CreateKey("someTask"))
            };
            // End snippet
        }
        
        [Fact]
        public void AncestorQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: AncestorQuery
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("Task");
            Query query = new Query("Task")
            {
                Filter = Filter.HasAncestor(keyFactory.CreateKey("someTask"))
            };
            // End snippet
        }

        [Fact]
        public void KindlessQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: KindlessQuery
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("Task");
            Key lastSeenKey = keyFactory.CreateKey(100L);
            Query query = new Query
            {
                Filter = Filter.GreaterThan(DatastoreConstants.KeyProperty, lastSeenKey)
            };
            // End snippet
        }

        [Fact]
        public void KeysOnlyQuery()
        {
            // Snippet: KeysOnlyQuery
            Query query = new Query("Task")
            {
                Projection = { DatastoreConstants.KeyProperty }
            };
            // End snippet
        }

        [Fact(Skip = "Requires composite index configuration")]
        public void ProjectionQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: ProjectionQuery
            Query query = new Query("Task")
            {
                Projection = { "priority", "percentage_complete" }
            };
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            foreach (Entity entity in db.RunQueryPageStream(query).Flatten())
            {
                Console.WriteLine($"{(int)entity["priority"]}: {(double?)entity["percentage_complete"]}");
            }            
            // End snippet
        }

        [Fact]
        public void GroupingQuery()
        {
            // Snippet: GroupingQuery
            Query query = new Query("Task")
            {
                Projection = { "type", "priority" },
                DistinctOn = { new PropertyReference("type") },
                Order =
                {
                    { "type", Direction.Ascending },
                    { "priority", Direction.Ascending }
                }
            };
            // End snippet
        }

        [Fact]
        public void ArrayQueryComparison()
        {
            // Snippet: ArrayQuery
            Query query = new Query("Task")
            {
                Filter = Filter.And(
                    Filter.GreaterThan("tag", "learn"),
                    Filter.LessThan("tag", "math")
                )
            };
            // End snippet
        }

        [Fact]
        public void ArrayQueryEquality()
        {
            // Snippet: ArrayQuery
            Query query = new Query("Task")
            {
                Filter = Filter.And(
                    Filter.GreaterThan("equal", "fun"),
                    Filter.LessThan("equal", "programming")
                )
            };
            // End snippet
        }

        [Fact]
        public void PaginateWithCursor()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            ByteString pageCursor = null;
            int pageSize = 5;
            // Snippet: PaginateWithCursor
            Query query = new Query("Task") { Limit = pageSize, StartCursor = pageCursor ?? ByteString.Empty };
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);

            RunQueryResponse response = db.RunQuery(query, ReadConsistency.Eventual);
            foreach (EntityResult result in response.Batch.EntityResults)
            {
                Entity entity = result.Entity;
                // Do something with the task entity
            }
            ByteString nextPageCursor = response.Batch.EndCursor;
            // End snippet
        }

        [Fact]
        public void OrderingWithInequalityFilter()
        {
            // Snippet: OrderingWithInequalityFilter
            Query query = new Query("Task")
            {
                Filter = Filter.GreaterThan("priority", 3),
                Order =
                {
                    // This property must be sorted first, as it is in the inequality filter
                    { "priority", Direction.Ascending },
                    { "created", Direction.Ascending }
                }
            };
            // End snippet
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

            // Snippet TransactionReadAndWrite
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            using (DatastoreTransaction transaction = db.BeginTransaction())
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
            // End snippet
        }

        // Used by TransactionReadAndWrite. Could promote to the fixture.
        private Key CreateAccount(string name, long balance)
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory factory = db.CreateKeyFactory("Account");
            Entity entity = new Entity
            {
                Key = factory.CreateInsertionKey(),
                ["name"] = name,
                ["balance"] = balance
            };
            return db.Insert(entity);
        }
    }
}
