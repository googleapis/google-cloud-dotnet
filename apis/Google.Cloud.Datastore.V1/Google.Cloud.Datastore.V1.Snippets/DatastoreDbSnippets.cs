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
using static Google.Cloud.Datastore.V1.PropertyOrder.Types;
using static Google.Cloud.Datastore.V1.QueryResultBatch.Types;
using static Google.Cloud.Datastore.V1.ReadOptions.Types;

namespace Google.Cloud.Datastore.V1.Snippets
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

        // See-also: Lookup(*)
        // Member: Lookup(IEnumerable<Key>, *, *)
        // Member: Lookup(Key, *, *)
        // See [Lookup](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task LookupAsync()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: LookupAsync(*)
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

        // See-also: LookupAsync(*)
        // Member: LookupAsync(IEnumerable<Key>, *, *)
        // Member: LookupAsync(Key, *, *)
        // See [LookupAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void LazyStructuredQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQueryLazily(Query,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Query query = new Query("book")
            {
                Filter = Filter.Equal("author", "Jane Austen")
            };
            LazyDatastoreQuery results = db.RunQueryLazily(query);
            // LazyDatastoreQuery implements IEnumerable<Entity>, but you can
            // call AsResponses() to see the raw RPC responses, or
            // GetAllResults() to get all the results into memory, complete with
            // the end cursor and the reason for the query finishing.
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
        public async Task LazyStructuredQueryAsync()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQueryLazilyAsync(Query,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Query query = new Query("book")
            {
                Filter = Filter.Equal("author", "Jane Austen")
            };
            AsyncLazyDatastoreQuery results = db.RunQueryLazilyAsync(query);
            // AsyncLazyDatastoreQuery implements IAsyncEnumerable<Entity>, but you can
            // call AsResponses() to see the raw RPC responses, or
            // GetAllResultsAsync() to get all the results into memory, complete with
            // the end cursor and the reason for the query finishing.
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
        public void LazyGqlQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQueryLazily(GqlQuery,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            GqlQuery gqlQuery = new GqlQuery
            {
                QueryString = "SELECT * FROM book WHERE author = @author",
                NamedBindings = { { "author", "Jane Austen" } },
            };
            LazyDatastoreQuery results = db.RunQueryLazily(gqlQuery);
            // LazyDatastoreQuery implements IEnumerable<Entity>, but you can
            // call AsResponses() to see the raw RPC responses, or
            // GetAllResults() to get all the results into memory, complete with
            // the end cursor and the reason for the query finishing.
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
        public async Task LazyGqlQueryAsync()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQueryLazilyAsync(GqlQuery,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            GqlQuery gqlQuery = new GqlQuery
            {
                QueryString = "SELECT * FROM book WHERE author = @author",
                NamedBindings = { { "author", "Jane Austen" } },
            };
            AsyncLazyDatastoreQuery results = db.RunQueryLazilyAsync(gqlQuery);
            // AsyncLazyDatastoreQuery implements IAsyncEnumerable<Entity>, but you can
            // call AsResponses() to see the raw RPC responses, or
            // GetAllResultsAsync() to get all the results into memory, complete with
            // the end cursor and the reason for the query finishing.
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
        public void EagerStructuredQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQuery(Query,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Query query = new Query("book")
            {
                Filter = Filter.Equal("author", "Jane Austen"),
                Limit = 10
            };
            // RunQuery fetches all the results into memory in a single call.
            // Constrast this with RunQueryLazily, which merely prepares an enumerable
            // query. Always specify a limit when you use RunQuery, to avoid running
            // out of memory.
            DatastoreQueryResults results = db.RunQuery(query);
            foreach (Entity entity in results.Entities)
            {
                Console.WriteLine(entity);
            }
            // End snippet

            // This will run the query again, admittedly...
            Assert.Equal(1, results.Entities.Count);
            Entity book = results.Entities[0];
            Assert.Equal("Jane Austen", (string)book["author"]);
            Assert.Equal("Pride and Prejudice", (string)book["title"]);
        }

        [Fact]
        public async Task EagerStructuredQueryAsync()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQueryAsync(Query,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            Query query = new Query("book")
            {
                Filter = Filter.Equal("author", "Jane Austen"),
                Limit = 10
            };
            DatastoreQueryResults results = await db.RunQueryAsync(query);
            // RunQuery fetches all the results into memory in a single call.
            // Constrast this with RunQueryLazily, which merely prepares an enumerable
            // query. Always specify a limit when you use RunQuery, to avoid running
            // out of memory.
            foreach (Entity entity in results.Entities)
            {
                Console.WriteLine(entity);
            }
            // End snippet

            // This will run the query again, admittedly...
            Assert.Equal(1, results.Entities.Count);
            Entity book = results.Entities[0];
            Assert.Equal("Jane Austen", (string)book["author"]);
            Assert.Equal("Pride and Prejudice", (string)book["title"]);
        }

        [Fact]
        public void EagerGqlQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQuery(GqlQuery,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            GqlQuery gqlQuery = new GqlQuery
            {
                QueryString = "SELECT * FROM book WHERE author = @author LIMIT @limit",
                NamedBindings = {
                    { "author", "Jane Austen" },
                    { "limit", 10 }
                }
            };
            DatastoreQueryResults results = db.RunQuery(gqlQuery);
            // RunQuery fetches all the results into memory in a single call.
            // Constrast this with RunQueryLazily, which merely prepares an enumerable
            // query. Always specify a limit when you use RunQuery, to avoid running
            // out of memory.
            foreach (Entity entity in results.Entities)
            {
                Console.WriteLine(entity);
            }
            // End snippet

            // This will run the query again, admittedly...
            Assert.Equal(1, results.Entities.Count);
            Entity book = results.Entities[0];
            Assert.Equal("Jane Austen", (string)book["author"]);
            Assert.Equal("Pride and Prejudice", (string)book["title"]);
        }

        [Fact]
        public async Task EagerGqlQueryAsync()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQueryAsync(GqlQuery,*,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            GqlQuery gqlQuery = new GqlQuery
            {
                QueryString = "SELECT * FROM book WHERE author = @author",
                NamedBindings = { { "author", "Jane Austen" } },
            };
            DatastoreQueryResults results = await db.RunQueryAsync(gqlQuery);
            // RunQuery fetches all the results into memory in a single call.
            // Constrast this with RunQueryLazily, which merely prepares an enumerable
            // query. Always specify a limit when you use RunQuery, to avoid running
            // out of memory.
            foreach (Entity entity in results.Entities)
            {
                Console.WriteLine(entity);
            }
            // End snippet

            // This will run the query again, admittedly...
            Assert.Equal(1, results.Entities.Count);
            Entity book = results.Entities[0];
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
            IReadOnlyList<Key> insertedKeys = db.Insert(book1, book2);
            Console.WriteLine($"Inserted keys: {string.Join(",", insertedKeys)}");
            // End snippet
        }

        // See-also: Insert(Entity[])
        // Member: Insert(Entity, CallSettings)
        // Member: Insert(IEnumerable<Entity>, CallSettings)
        // See [Insert](ref) for an example using an alternative overload.
        // End see-also

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
            IReadOnlyList<Key> insertedKeys = await db.InsertAsync(book1, book2);
            Console.WriteLine($"Inserted keys: {string.Join(",", insertedKeys)}");
            // End snippet
        }

        // See-also: InsertAsync(*)
        // Member: InsertAsync(Entity, CallSettings)
        // Member: InsertAsync(IEnumerable<Entity>, CallSettings)
        // See [InsertAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void Update()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Update(Entity, CallSettings)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("book");
            Entity book = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["author"] = "Harper Lee",
                ["title"] = "Tequila Mockingbird",
                ["publication_date"] = new DateTime(1960, 7, 11, 0, 0, 0, DateTimeKind.Utc),
                ["genres"] = new[] { "Southern drama", "Courtroom drama", "Bildungsroman" }
            };
            db.Insert(book);

            // Correct the typo in memory
            book["title"] = "To Kill a Mockingbird";
            // Then update the entity in Datastore
            db.Update(book);
            // End snippet

            var fetched = db.Lookup(book.Key);
            Assert.Equal("To Kill a Mockingbird", (string) fetched["title"]);
        }

        // See-also: Update(Entity, CallSettings)
        // Member: Update(*)
        // Member: Update(IEnumerable<Entity>, *)
        // See [Update](ref) for an example using an alternative overload.
        // End see-also

        // See-also: Update(Entity, CallSettings)
        // Member: UpdateAsync(Entity, CallSettings)
        // Member: UpdateAsync(*)
        // Member: UpdateAsync(IEnumerable<Entity>, *)
        // See [Update](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void Upsert()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Upsert(Entity[])
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("book");
            Entity book1 = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["author"] = "Harper Lee",
                ["title"] = "Tequila Mockingbird",
                ["publication_date"] = new DateTime(1960, 7, 11, 0, 0, 0, DateTimeKind.Utc),
                ["genres"] = new[] { "Southern drama", "Courtroom drama", "Bildungsroman" }
            };
            db.Insert(book1);

            // Correct the typo in memory
            book1["title"] = "To Kill a Mockingbird";

            Entity book2 = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["author"] = "Charlotte Brontë",
                ["title"] = "Jane Eyre",
                ["publication_date"] = new DateTime(1847, 10, 16, 0, 0, 0, DateTimeKind.Utc),
                ["genres"] = new[] { "Gothic", "Romance", "Bildungsroman" }
            };

            // Update book1 and insert book2 into Datastore
            db.Upsert(book1, book2);
            // End snippet

            Assert.Equal("To Kill a Mockingbird", (string) db.Lookup(book1.Key)["title"]);
            Assert.Equal("Jane Eyre", (string) db.Lookup(book2.Key)["title"]);
        }

        // See-also: Upsert(*)
        // Member: Upsert(Entity, CallSettings)
        // Member: Upsert(IEnumerable<Entity>, *)
        // See [Upsert](ref) for an example using an alternative overload.
        // End see-also

        // See-also: Upsert(*)
        // Member: UpsertAsync(Entity, CallSettings)
        // Member: UpsertAsync(*)
        // Member: UpsertAsync(IEnumerable<Entity>, *)
        // See [Update](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DeleteEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Sample: DeleteEntity
            // Additional: Delete(Entity, *)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");
            Entity message = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["text"] = "Hello",
            };
            db.Insert(message);

            Entity fetchedBeforeDeletion = db.Lookup(message.Key);

            // Only the key from the entity is used to determine what to delete.
            // If you already have the key but not the entity, use Delete(Key, CallSettings) or
            // a similar overload.
            db.Delete(message);

            Entity fetchedAfterDeletion = db.Lookup(message.Key);

            Console.WriteLine($"Entity exists before deletion? {fetchedBeforeDeletion != null}");
            Console.WriteLine($"Entity exists after deletion? {fetchedAfterDeletion != null}");
            // End snippet

            Assert.NotNull(fetchedBeforeDeletion);
            Assert.Null(fetchedAfterDeletion);
        }

        // See-also: Delete(Entity, *)
        // Member: Delete(Entity[])
        // Member: Delete(IEnumerable<Entity>, *)
        // See [Delete](ref) for an example using an alternative overload.
        // End see-also

        // See-also: Delete(Entity, *)
        // Member: DeleteAsync(Entity, *)
        // Member: DeleteAsync(Entity[])
        // Member: DeleteAsync(IEnumerable<Entity>, *)
        // See [Delete](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DeleteKey()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Delete(Key, *)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");
            Entity message = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["text"] = "Hello",
            };
            Key key = db.Insert(message);

            Entity fetchedBeforeDeletion = db.Lookup(key);

            // Only the key is required to determine what to delete.
            // If you have an entity with the right key, you can use Delete(Entity, CallSettings)
            // or a similar overload for convenience.
            db.Delete(key);

            Entity fetchedAfterDeletion = db.Lookup(key);

            Console.WriteLine($"Entity exists before deletion? {fetchedBeforeDeletion != null}");
            Console.WriteLine($"Entity exists after deletion? {fetchedAfterDeletion != null}");
            // End snippet

            Assert.NotNull(fetchedBeforeDeletion);
            Assert.Null(fetchedAfterDeletion);
        }

        // See-also: Delete(Key, *)
        // Member: Delete(Key[])
        // Member: Delete(IEnumerable<Key>, *)
        // See [Delete](ref) for an example using an alternative overload.
        // End see-also

        // See-also: Delete(Key, *)
        // Member: DeleteAsync(Key, *)
        // Member: DeleteAsync(Key[])
        // Member: DeleteAsync(IEnumerable<Key>, *)
        // See [Delete](ref) for a synchronous example.
        // End see-also

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

        // See-also: AllocateIds(*)
        // Member: AllocateIds(*, *)
        // See [AllocateIds](ref) for an example using an alternative overload.
        // End see-also

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

        // See-also: AllocateIdsAsync(*)
        // Member: AllocateIdsAsync(*, *)
        // See [AllocateIdsAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void NamespaceQuery()
        {
            string projectId = _fixture.ProjectId;

            // Sample: NamespaceQuery
            DatastoreDb db = DatastoreDb.Create(projectId, "");
            Query query = new Query(DatastoreConstants.NamespaceKind);
            foreach (Entity entity in db.RunQueryLazily(query))
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
            foreach (Entity entity in db.RunQueryLazily(query))
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
            foreach (Entity entity in db.RunQueryLazily(query))
            {
                Console.WriteLine(entity.Key.Path.Last().Name);
            }
            // End sample
        }

        [Fact]
        public void InsertOverview()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            // Sample: InsertOverview
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);

            KeyFactory keyFactory = db.CreateKeyFactory("message");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["created"] = DateTime.UtcNow,
                ["text"] = "Text of the message",
                ["tags"] = new[] { "tag1", "tag2" }
            };
            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                transaction.Insert(entity);
                CommitResponse commitResponse = transaction.Commit();
                Key insertedKey = commitResponse.MutationResults[0].Key;
                Console.WriteLine($"Inserted key: {insertedKey}");
                // The key is also propagated to the entity
                Console.WriteLine($"Entity key: {entity.Key}");
            }
            // End sample
        }

        [Fact]
        public void QueryOverview()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;
            // Sample: QueryOverview
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);

            // Print the messages created in the last 5 minutes, most recent first
            DateTime cutoff = DateTime.UtcNow.AddMinutes(-5);
            Query query = new Query("message")
            {
                Filter = Filter.GreaterThanOrEqual("created", cutoff),
                Order = { { "created", Direction.Descending } }
            };
            foreach (Entity entity in db.RunQueryLazily(query))
            {
                DateTime created = (DateTime)entity["created"];
                string text = (string)entity["text"];
                Console.WriteLine($"{created:yyyy-MM-dd'T'HH:mm:ss}: {text}");
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
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("Task");
            Entity entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["category"] = "Personal",
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
                ["tags"] = new[] { "fun", "programming" },
                ["collaborators"] = new[] { "alice", "bob" }
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
            foreach (Entity entity in db.RunQueryLazily(query))
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
            foreach (Entity entity in db.RunQueryLazily(query))
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
                Projection = { "category", "priority" },
                DistinctOn = { "category" },
                Order =
                {
                    "category", // If only the name is specified, it's implicitly ascending
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

            DatastoreQueryResults results = db.RunQueryLazily(query, ReadConsistency.Eventual).GetAllResults();
            foreach (Entity entity in results.Entities)
            {
                // Do something with the task entity
            }
            if (results.MoreResults == MoreResultsType.MoreResultsAfterLimit)
            {
                ByteString nextPageCursor = results.EndCursor;
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
            // Additional: BeginTransaction(*)
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

        // See-also: BeginTransaction(*)
        // Member: BeginTransactionAsync(*)
        // See [BeginTransaction](ref) for an example of the synchronous equivalent of this method.
        // End see-also

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
