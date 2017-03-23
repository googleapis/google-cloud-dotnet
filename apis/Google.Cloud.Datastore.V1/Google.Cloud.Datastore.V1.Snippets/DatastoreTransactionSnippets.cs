// Copyright 2017 Google Inc. All Rights Reserved.
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
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Datastore.V1.Key.Types;

namespace Google.Cloud.Datastore.V1.Snippets
{
    [Collection(nameof(DatastoreSnippetFixture))]
    public class DatastoreTransactionSnippets
    {
        private readonly DatastoreSnippetFixture _fixture;

        public DatastoreTransactionSnippets(DatastoreSnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Commit()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Commit
            // Additional: Insert(Entity[])
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");
            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                Entity entity = new Entity
                {
                    Key = keyFactory.CreateIncompleteKey(),
                    ["message"] = "Hello"
                };
                // This adds the entity to a collection in memory: nothing
                // is sent to the server.
                transaction.Insert(entity);
                // Without the Commit call, the transaction will automatically
                // be rolled back. The Commit call performs all the mutations
                // within the transaction.
                transaction.Commit();
            }
            // End snippet
        }

        // See-also: Commit(*)
        // Member: CommitAsync(*)
        // See [Commit](ref) for a synchronous example.
        // End see-also

        // See-also: Insert(Entity[])
        // Member: Insert(IEnumerable<Entity>)
        // See [Insert](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void Update()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Update(Entity[])
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

            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                // Correct the typo in memory
                book["title"] = "To Kill a Mockingbird";
                // This adds the entity to a collection of mutations in memory: nothing
                // is sent to the server.
                transaction.Update(book);
                // Without the Commit call, the transaction will automatically
                // be rolled back. The Commit call performs all the mutations
                // within the transaction.
                transaction.Commit();
            }
            // End snippet

            var fetched = db.Lookup(book.Key);
            Assert.Equal("To Kill a Mockingbird", (string)fetched["title"]);
        }

        // See-also: Update(Entity[])
        // Member: Update(IEnumerable<Entity>)
        // See [Update](ref) for an example using an alternative overload.
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

            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
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

                // This adds the entities to a collection of mutations in memory: nothing
                // is sent to the server.
                transaction.Upsert(book1, book2);
                // Without the Commit call, the transaction will automatically
                // be rolled back. The Commit call performs all the mutations
                // within the transaction.
                transaction.Commit();
            }
            // End snippet
        }

        // See-also: Upsert(Entity[])
        // Member: Upsert(IEnumerable<Entity>)
        // See [Upsert](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void DeleteEntity()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Delete(Entity[])
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");
            Entity message = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["text"] = "Hello",
            };
            db.Insert(message);

            Entity fetchedBeforeDeletion = db.Lookup(message.Key);

            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                // This adds the entity key to a collection of mutations in memory: nothing
                // is sent to the server. Only the key from the entity is used to determine what to delete.
                // If you already have the key but not the entity, use Delete(Key[]) or
                // a similar overload.
                transaction.Delete(message);
                // Without the Commit call, the transaction will automatically
                // be rolled back. The Commit call performs all the mutations
                // within the transaction.
                transaction.Commit();
            }

            Entity fetchedAfterDeletion = db.Lookup(message.Key);

            Console.WriteLine($"Entity exists before deletion? {fetchedBeforeDeletion != null}");
            Console.WriteLine($"Entity exists after deletion? {fetchedAfterDeletion != null}");
            // End snippet

            Assert.NotNull(fetchedBeforeDeletion);
            Assert.Null(fetchedAfterDeletion);
        }

        // See-also: Delete(Entity[])
        // Member: Delete(IEnumerable<Entity>)
        // See [Delete](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void DeleteKey()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Delete(Key[])
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");
            Entity message = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["text"] = "Hello",
            };
            Key key = db.Insert(message);

            Entity fetchedBeforeDeletion = db.Lookup(key);

            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                // This adds the key to a collection of mutations in memory: nothing
                // is sent to the server. Only the key is required to determine what to delete.
                // If you have an entity with the right key, you can use Delete(Entity[])
                // or a similar overload for convenience.
                transaction.Delete(key);
                // Without the Commit call, the transaction will automatically
                // be rolled back. The Commit call performs all the mutations
                // within the transaction.
                transaction.Commit();
            }

            Entity fetchedAfterDeletion = db.Lookup(key);

            Console.WriteLine($"Entity exists before deletion? {fetchedBeforeDeletion != null}");
            Console.WriteLine($"Entity exists after deletion? {fetchedAfterDeletion != null}");
            // End snippet

            Assert.NotNull(fetchedBeforeDeletion);
            Assert.Null(fetchedAfterDeletion);
        }

        // See-also: Delete(Entity[])
        // Member: Delete(IEnumerable<Key>)
        // See [Delete](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void LazyGqlQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQueryLazily(GqlQuery,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("player");

            // Prepare the data: a player with two game child entities
            Entity player = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["name"] = "Sophie"
            };
            Key playerKey = db.Insert(player);
            Entity game1 = new Entity
            {
                Key = playerKey.WithElement(new PathElement { Kind = "game" }),
                ["score"] = 10,
                ["timestamp"] = new DateTime(2017, 2, 16, 8, 35, 0, DateTimeKind.Utc)
            };
            Entity game2 = new Entity
            {
                Key = playerKey.WithElement(new PathElement { Kind = "game" }),
                ["score"] = 25,
                ["timestamp"] = new DateTime(2017, 3, 15, 10, 35, 0, DateTimeKind.Utc)
            };
            db.Insert(game1, game2);

            // Perform a query within a transaction
            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                // Any query executed in a transaction must at least have an ancestor filter.
                GqlQuery query = new GqlQuery
                {
                    QueryString = "SELECT * FROM game WHERE __key__ HAS ANCESTOR @player",
                    NamedBindings = { { "player", playerKey } }
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
            }
            // End snippet
        }

        // See-also: RunQueryLazily(GqlQuery,*)
        // Member: RunQueryLazilyAsync(GqlQuery,*)
        // See [RunQueryLazily](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void EagerGqlQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQuery(GqlQuery,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("player");

            // Prepare the data: a player with two game child entities
            Entity player = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["name"] = "Sophie"
            };
            Key playerKey = db.Insert(player);
            Entity game1 = new Entity
            {
                Key = playerKey.WithElement(new PathElement { Kind = "game" }),
                ["score"] = 10,
                ["timestamp"] = new DateTime(2017, 2, 16, 8, 35, 0, DateTimeKind.Utc)
            };
            Entity game2 = new Entity
            {
                Key = playerKey.WithElement(new PathElement { Kind = "game" }),
                ["score"] = 25,
                ["timestamp"] = new DateTime(2017, 3, 15, 10, 35, 0, DateTimeKind.Utc)
            };
            db.Insert(game1, game2);

            // Perform a query within a transaction
            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                // Any query executed in a transaction must at least have an ancestor filter.
                GqlQuery query = new GqlQuery
                {
                    QueryString = "SELECT * FROM game WHERE __key__ HAS ANCESTOR @player LIMIT @limit",
                    NamedBindings = {
                        { "player", playerKey },
                        { "limit", 10 }
                    }
                };
                DatastoreQueryResults results = db.RunQuery(query);
                // RunQuery fetches all the results into memory in a single call.
                // Constrast this with RunQueryLazily, which merely prepares an enumerable
                // query. Always specify a limit when you use RunQuery, to avoid running
                // out of memory.
                foreach (Entity entity in results.Entities)
                {
                    Console.WriteLine(entity);
                }
            }
            // End snippet
        }

        // See-also: RunQuery(GqlQuery,*)
        // Member: RunQueryAsync(GqlQuery,*)
        // See [RunQuery](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void LazyStructuredQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQueryLazily(Query,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("player");

            // Prepare the data: a player with two game child entities
            Entity player = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["name"] = "Sophie"
            };
            Key playerKey = db.Insert(player);
            Entity game1 = new Entity
            {
                Key = playerKey.WithElement(new PathElement { Kind = "game" }),
                ["score"] = 10,
                ["timestamp"] = new DateTime(2017, 2, 16, 8, 35, 0, DateTimeKind.Utc)
            };
            Entity game2 = new Entity
            {
                Key = playerKey.WithElement(new PathElement { Kind = "game" }),
                ["score"] = 25,
                ["timestamp"] = new DateTime(2017, 3, 15, 10, 35, 0, DateTimeKind.Utc)
            };
            db.Insert(game1, game2);

            // Perform a query within a transaction
            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                // Any query executed in a transaction must at least have an ancestor filter.
                Query query = new Query("game")
                {
                    Filter = Filter.HasAncestor(playerKey)
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
            }
            // End snippet
        }

        // See-also: RunQueryLazily(Query,*)
        // Member: RunQueryLazilyAsync(Query,*)
        // See [RunQueryLazily](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void EagerStructuredQuery()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RunQuery(Query,*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("player");

            // Prepare the data: a player with two game child entities
            Entity player = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["name"] = "Sophie"
            };
            Key playerKey = db.Insert(player);
            Entity game1 = new Entity
            {
                Key = playerKey.WithElement(new PathElement { Kind = "game" }),
                ["score"] = 10,
                ["timestamp"] = new DateTime(2017, 2, 16, 8, 35, 0, DateTimeKind.Utc)
            };
            Entity game2 = new Entity
            {
                Key = playerKey.WithElement(new PathElement { Kind = "game" }),
                ["score"] = 25,
                ["timestamp"] = new DateTime(2017, 3, 15, 10, 35, 0, DateTimeKind.Utc)
            };
            db.Insert(game1, game2);

            // Perform a query within a transaction
            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                // Any query executed in a transaction must at least have an ancestor filter.
                Query query = new Query("game")
                {
                    Filter = Filter.HasAncestor(playerKey),
                    Limit = 10
                };
                DatastoreQueryResults results = db.RunQuery(query);
                // RunQuery fetches all the results into memory in a single call.
                // Constrast this with RunQueryLazily, which merely prepares an enumerable
                // query. Always specify a limit when you use RunQuery, to avoid running
                // out of memory.
                foreach (Entity entity in results.Entities)
                {
                    Console.WriteLine(entity);
                }
            }
            // End snippet
        }

        // See-also: RunQuery(Query,*)
        // Member: RunQueryAsync(Query,*)
        // See [RunQueryLazily](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void Lookup()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: Lookup(Key[])
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");
            Entity message = new Entity { Key = keyFactory.CreateIncompleteKey(), ["text"] = "Original" };
            db.Insert(message);

            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                // Look the message up at the start of the transaction
                Entity fetched1 = transaction.Lookup(message.Key);
                Console.WriteLine((string) fetched1["text"]); // "Original"

                // Update the message outside the transaction
                message["text"] = "Updated";
                db.Update(message);

                // Look up the message up again. We are guaranteed not to see the
                // update because it occurred after the start of the transaction.
                Entity fetched2 = transaction.Lookup(message.Key);
                Console.WriteLine((string) fetched2["text"]); // Still "Original"
            }
            // End snippet
        }

        // See-also: Lookup(Key[])
        // Member: Lookup(Key, CallSettings)
        // Member: Lookup(IEnumerable<Key>, CallSettings)
        // See [Lookup](ref) for an example using an alternative overload.
        // End see-also

        // See-also: Lookup(Key[])
        // Member: LookupAsync(Key[])
        // Member: LookupAsync(Key, CallSettings)
        // Member: LookupAsync(IEnumerable<Key>, CallSettings)
        // See [Lookup](ref) for a synchronous example.
        // End see-also

        [Fact]
        public async Task RollbackAsync()
        {
            string projectId = _fixture.ProjectId;
            string namespaceId = _fixture.NamespaceId;

            // Snippet: RollbackAsync(*)
            DatastoreDb db = DatastoreDb.Create(projectId, namespaceId);
            KeyFactory keyFactory = db.CreateKeyFactory("message");

            // Dispose automatically rolls back an uncommitted transaction synchronously.
            // To roll back asynchronously, 
            bool committed = false;
            DatastoreTransaction transaction = await db.BeginTransactionAsync();
            try
            {
                Entity message = new Entity
                {
                    Key = keyFactory.CreateIncompleteKey(),
                    ["text"] = "Hello",
                };
                // This adds the entity to a collection in memory: nothing
                // is sent to the server.
                db.Insert(message);

                // Attempt to commit the transaction asynchronously.
                await transaction.CommitAsync();
                committed = true;
            }
            finally
            {
                if (!committed)
                {
                    // Roll back asynchronously if anything failed.
                    await transaction.RollbackAsync();
                }
            }
            // End snippet
        }

        // See-also: RollbackAsync(*)
        // Member: Rollback(*)
        // See [RollbackAsync] for an asynchronous example.
        // End see-also
    }
}
