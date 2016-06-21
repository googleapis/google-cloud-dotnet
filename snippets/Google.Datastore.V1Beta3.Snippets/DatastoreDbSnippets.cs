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
using System.Threading.Tasks;
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
        public async Task LookupAsync()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Lookup(*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("book");
            Key key1 = keyFactory.CreateKey("pride_and_prejudice");
            Key key2 = keyFactory.CreateKey("not_present");

            IReadOnlyList<Entity> entities = await db.LookupAsync(key1, key2);
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

            // Snippet: RunQuery(Query,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Query query = new Query("book")
            {
                Filter = Filter.Equal("author", "Jane Austen")
            };
            DatastoreQueryResults results = db.RunQuery(query);
            // DatastoreQueryResults implements IEnumerable<Entity>, but you can
            // call AsEntityResults(), AsBatches() or AsResponses() to see the query
            // results in whatever way makes most sense for your application.
            foreach (Entity entity in results)
            {
                Console.WriteLine(entity);
            }
            // End snippet

            // This will run the query again, admittedly...
            List<Entity> entities = results.ToList();
            Assert.Equal(1, entities.Count);
            Entity book = entities[0];
            Assert.Equal("Jane Austen", (string)book["author"]);
            Assert.Equal("Pride and Prejudice", (string)book["title"]);
        }

        [Fact]
        public async Task StructuredQueryAsync()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQueryAsync(Query,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Query query = new Query("book")
            {
                Filter = Filter.Equal("author", "Jane Austen")
            };
            DatastoreAsyncQueryResults results = db.RunQueryAsync(query);
            // DatastoreAsyncQueryResults implements IAsyncEnumerable<Entity>, but you can
            // call AsEntityResults(), AsBatches() or AsResponses() to see the query
            // results in whatever way makes most sense for your application.
            await results.ForEachAsync(entity =>
            {
                Console.WriteLine(entity);
            });
            // End snippet

            // This will run the query again, admittedly...
            List<Entity> entities = await results.ToList();
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

            // Snippet: RunQuery(GqlQuery,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            GqlQuery gqlQuery = new GqlQuery
            {
                QueryString = "SELECT * FROM book WHERE author = @author",
                NamedBindings = { { "author", new GqlQueryParameter { Value = "Jane Austen" } } },
            };
            DatastoreQueryResults results = db.RunQuery(gqlQuery);
            // DatastoreQueryResults implements IEnumerable<Entity>, but you can
            // call AsEntityResults(), AsBatches() or AsResponses() to see the query
            // results in whatever way makes most sense for your application.
            foreach (Entity entity in results)
            {
                Console.WriteLine(entity);
            }
            // End snippet

            // This will run the query again, admittedly...
            List<Entity> entities = results.ToList();
            Assert.Equal(1, entities.Count);
            Entity book = entities[0];
            Assert.Equal("Jane Austen", (string)book["author"]);
            Assert.Equal("Pride and Prejudice", (string)book["title"]);
        }

        [Fact]
        public async Task GqlQueryAsync()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQueryAsync(GqlQuery,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            GqlQuery gqlQuery = new GqlQuery
            {
                QueryString = "SELECT * FROM book WHERE author = @author",
                NamedBindings = { { "author", new GqlQueryParameter { Value = "Jane Austen" } } },
            };
            DatastoreAsyncQueryResults results = db.RunQueryAsync(gqlQuery);
            // DatastoreAsyncQueryResults implements IAsyncEnumerable<Entity>, but you can
            // call AsEntityResults(), AsBatches() or AsResponses() to see the query
            // results in whatever way makes most sense for your application.
            await results.ForEachAsync(entity =>
            {
                Console.WriteLine(entity);
            });
            // End snippet

            // This will run the query again, admittedly...
            List<Entity> entities = await results.ToList();
            Assert.Equal(1, entities.Count);
            Entity book = entities[0];
            Assert.Equal("Jane Austen", (string)book["author"]);
            Assert.Equal("Pride and Prejudice", (string)book["title"]);
        }

        [Fact]
        public void AddEntity_Transactional()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Sample: AddEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("book");
            Entity book1 = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["author"] = "Harper Lee",
                ["title"] = "To Kill a Mockingbird",
                ["publication_date"] = new DateTime(1960, 7, 11, 0, 0, 0, DateTimeKind.Utc)
            };
            Entity book2 = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
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
            // End sample
        }

        [Fact]
        public void AddEntity_NonTransactional()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Insert(Entity[])
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("book");
            Entity book1 = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["author"] = "Harper Lee",
                ["title"] = "To Kill a Mockingbird",
                ["publication_date"] = new DateTime(1960, 7, 11, 0, 0, 0, DateTimeKind.Utc)
            };
            Entity book2 = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["author"] = "Charlotte Brontë",
                ["title"] = "Jane Eyre",
                ["publication_date"] = new DateTime(1847, 10, 16, 0, 0, 0, DateTimeKind.Utc)
            };
            IReadOnlyList<Key> insertedKeys = db.Insert(book1, book2);
            Console.WriteLine($"Inserted keys: {string.Join(",", insertedKeys)}");
            // End snippet
        }

        [Fact]
        public async Task AddEntity_NonTransactional_Async()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: InsertAsync(*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("book");
            Entity book1 = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["author"] = "Harper Lee",
                ["title"] = "To Kill a Mockingbird",
                ["publication_date"] = new DateTime(1960, 7, 11, 0, 0, 0, DateTimeKind.Utc)
            };
            Entity book2 = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["author"] = "Charlotte Brontë",
                ["title"] = "Jane Eyre",
                ["publication_date"] = new DateTime(1847, 10, 16, 0, 0, 0, DateTimeKind.Utc)
            };
            IReadOnlyList<Key> insertedKeys = await db.InsertAsync(book1, book2);
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
            Key key = db.AllocateId(keyFactory.CreateIncompleteKey());
            // End snippet
        }

        [Fact]
        public async Task AllocateIdAsync()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: AllocateIdAsync
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");
            Key key = await db.AllocateIdAsync(keyFactory.CreateIncompleteKey());
            // End snippet
        }

        [Fact]
        public void AllocateIds()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: AllocateIds(*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");
            IReadOnlyList<Key> keys = db.AllocateIds(keyFactory.CreateIncompleteKey(), keyFactory.CreateIncompleteKey());
            // End snippet

            Assert.Equal(2, keys.Count);
            Assert.NotEqual(keys[0], keys[1]);
        }

        [Fact]
        public async Task AllocateIdsAsync()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: AllocateIdsAsync(*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");
            IReadOnlyList<Key> keys = await db.AllocateIdsAsync(keyFactory.CreateIncompleteKey(), keyFactory.CreateIncompleteKey());
            // End snippet

            Assert.Equal(2, keys.Count);
            Assert.NotEqual(keys[0], keys[1]);
        }

        [Fact]
        public void NamespaceQuery()
        {
            string projectId = _fixture.ProjectId;

            // Sample: NamespaceQuery
            DatastoreDb db = DatastoreDb.Create(projectId, "");
            Query query = new Query(DatastoreConstants.NamespaceKind);
            foreach (Entity entity in db.RunQuery(query))
            {
                Console.WriteLine(entity.Key.Path.Last().Name);
            }
            // End sample
        }

        [Fact]
        public void KindQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Sample: KindQuery
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Query query = new Query(DatastoreConstants.KindKind);
            foreach (Entity entity in db.RunQuery(query))
            {
                Console.WriteLine(entity.Key.Path.Last().Name);
            }
            // End sample
        }

        [Fact]
        public void PropertyQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Sample: PropertyQuery
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Query query = new Query(DatastoreConstants.PropertyKind);
            foreach (Entity entity in db.RunQuery(query))
            {
                Console.WriteLine(entity.Key.Path.Last().Name);
            }
            // End sample
        }

        [Fact]
        public void Overview()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            // Sample: Overview
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);

            var keyFactory = db.CreateKeyFactory("message");
            var entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
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
            // End sample
        }

        // Snippets ported from https://cloud.google.com/datastore/docs/concepts/entities

        [Fact]
        public void CreateEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Sample: CreateEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("Task");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["type"] = "Personal",
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
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("Task");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["type"] = "Personal",
                ["done"] = false,
                ["priority"] = 4,
                ["description"] = "Learn Cloud Datastore",
                ["percent_complete"] = 75.0
            };
            Key insertedKey = db.Insert(entity);
            // End sample
        }

        [Fact]
        public void LookupEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            Key key = _fixture.LearnDatastoreKey;

            // Sample: LookupEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Entity entity = db.Lookup(key);
            // End sample
        }

        [Fact]
        public void UpdateEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            Key key = _fixture.LearnDatastoreKey;

            // Sample: UpdateEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            using (DatastoreTransaction transaction = db.BeginTransaction())
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
            DatastoreDb insertClient = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = insertClient.CreateKeyFactory("Task");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["type"] = "Personal",
                ["done"] = false,
                ["priority"] = 4,
                ["description"] = "Learn Cloud Datastore",
                ["percent_complete"] = 75.0
            };
            Key insertedKey = insertClient.Insert(entity);

            // Sample: DeleteEntity
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            // If you have an entity instead of just a key, then entity.ToDelete() would work too.
            db.Delete(insertedKey);
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
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("User");
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
            string namespaceId = _fixture.NamespaceId;

            // Sample: CompositeFilter
            Query query = new Query("Task")
            {
                Filter = Filter.And(
                    Filter.Equal("done", false),
                    Filter.GreaterThanOrEqual("priority", 4)
                ),
                Order = { { "priority", Direction.Descending } },
            };

            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);            
            foreach (Entity entity in db.RunQuery(query))
            {
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
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("Task");
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
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("Task");
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
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("Task");
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
            string namespaceId = _fixture.NamespaceId;

            // Sample: ProjectionQuery
            Query query = new Query("Task")
            {
                Projection = { "priority", "percentage_complete" }
            };
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            foreach (Entity entity in db.RunQuery(query))
            {
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
                Projection = { "type", "priority" },
                DistinctOn = { "type" },
                Order =
                {
                    "type", // If only the name is specified, it's implicitly ascending
                    { "priority", Direction.Ascending } // Either direction can be specified explicitly
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
            string namespaceId = _fixture.NamespaceId;

            ByteString pageCursor = null;
            int pageSize = 5;
            // Sample: PaginateWithCursor
            Query query = new Query("Task") { Limit = pageSize, StartCursor = pageCursor ?? ByteString.Empty };
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);

            List<EntityResult> entityResults = db.RunQuery(query, ReadConsistency.Eventual).AsEntityResults().ToList();
            foreach (EntityResult result in entityResults)
            {
                Entity entity = result.Entity;
                // Do something with the task entity
            }
            // If we retrieved as many entities as we requested, there may be another page of results.
            // (There may not be any more results, but the query stopped executing when it had found
            // as many as we asked for.)
            // If we ran out of results, this is definitely the last page.
            if (entityResults.Count == pageSize)
            {
                ByteString nextPageCursor = entityResults.Last().Cursor;
                // Store nextPageCursor to get the next page later.
            }
            // End sample
        }

        [Fact]
        public void OrderingWithInequalityFilter()
        {
            // Sample: OrderingWithInequalityFilter
            Query query = new Query("Task")
            {
                Filter = Filter.GreaterThan("priority", 3),
                // The "priority" property must be sorted first, as it is in the inequality filter
                Order = { "priority", "created" },
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
            // End sample
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
                Key = factory.CreateIncompleteKey(),
                ["name"] = name,
                ["balance"] = balance
            };
            return db.Insert(entity);
        }
    }
}
