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
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Datastore.V1.Key.Types;

namespace Google.Cloud.Datastore.V1.IntegrationTests
{
    [Collection(nameof(DatastoreFixture))]
    public class DatastoreTransactionTest
    {
        private readonly DatastoreFixture _fixture;

        public DatastoreTransactionTest(DatastoreFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        private void SyncQueries_ImplicityUsePartition()
        {
            var db = DatastoreDb.Create(_fixture.ProjectId, _fixture.NamespaceId);
            var parentKey = PrepareQueryTest(db);
            using (var transaction = db.BeginTransaction())
            {
                var query = new Query("childKind") { Filter = Filter.HasAncestor(parentKey) };
                var gql = new GqlQuery
                {
                    QueryString = "SELECT * FROM childKind WHERE __key__ HAS ANCESTOR @1",
                    PositionalBindings = { parentKey }
                };
                var lazyResults = transaction.RunQueryLazily(query);
                Assert.Equal(1, lazyResults.Count());
                lazyResults = transaction.RunQueryLazily(gql);
                Assert.Equal(1, lazyResults.Count());

                var eagerResults = transaction.RunQuery(query);
                Assert.Equal(1, eagerResults.Entities.Count);
                eagerResults = transaction.RunQuery(gql);
                Assert.Equal(1, eagerResults.Entities.Count);
            }
        }

        [Fact]
        private async Task AsyncQueries_ImplicityUsePartition()
        {
            var db = DatastoreDb.Create(_fixture.ProjectId, _fixture.NamespaceId);
            var parentKey = PrepareQueryTest(db);
            using (var transaction = db.BeginTransaction())
            {
                var query = new Query("childKind") { Filter = Filter.HasAncestor(parentKey) };
                var gql = new GqlQuery
                {
                    QueryString = "SELECT * FROM childKind WHERE __key__ HAS ANCESTOR @1",
                    PositionalBindings = { parentKey }
                };
                var lazyResults = transaction.RunQueryLazilyAsync(query);
                Assert.Equal(1, await lazyResults.Count());
                lazyResults = transaction.RunQueryLazilyAsync(gql);
                Assert.Equal(1, await lazyResults.Count());

                var eagerResults = await transaction.RunQueryAsync(query);
                Assert.Equal(1, eagerResults.Entities.Count);
                eagerResults = await transaction.RunQueryAsync(gql);
                Assert.Equal(1, eagerResults.Entities.Count);
            }
        }

        private Key PrepareQueryTest(DatastoreDb db)
        {
            var keyFactory = db.CreateKeyFactory("parent");
            var parent = new Entity
            {
                Key = keyFactory.CreateIncompleteKey()
            };
            var parentKey = db.Insert(parent);

            var child = new Entity
            {
                Key = parentKey.WithElement(new PathElement { Kind = "childKind" })
            };
            db.Insert(child);
            return parentKey;
        }

        [Fact]
        public void Delete()
        {
            var db = DatastoreDb.Create(_fixture.ProjectId, _fixture.NamespaceId);
            var keyFactory = db.CreateKeyFactory("book");
            var entity = new Entity { Key = keyFactory.CreateIncompleteKey(), ["title"] = "Programming F#" };

            using (var transaction = db.BeginTransaction())
            {
                transaction.Insert(entity);
                transaction.Commit();
            }

            Assert.NotNull(db.Lookup(entity.Key));

            using (var transaction = db.BeginTransaction())
            {
                transaction.Delete(entity.Key);
                transaction.Commit();
            }

            Assert.Null(db.Lookup(entity.Key));
        }

        [Fact]
        public Task CommitPropagatesKeys() => CommitTest(t => Task.FromResult(t.Commit()));

        [Fact]
        public Task CommitAsyncPropagatesKeys() => CommitTest(t => t.CommitAsync());

        private async Task CommitTest(Func<DatastoreTransaction, Task<CommitResponse>> commitCall)
        {
            var db = DatastoreDb.Create(_fixture.ProjectId, _fixture.NamespaceId);
            var keyFactory = db.CreateKeyFactory("book");
            var updatedEntity = new Entity { Key = keyFactory.CreateIncompleteKey(), ["description"] = "Inserted before transaction" };
            db.Insert(updatedEntity);

            Entity insertedEntity = new Entity { Key = keyFactory.CreateIncompleteKey(), ["description"] = "Inserted in transaction" };
            Entity upsertedEntity = new Entity { Key = keyFactory.CreateIncompleteKey(), ["description"] = "Upserted in transaction" };
            using (var transaction = db.BeginTransaction())
            {
                transaction.Insert(insertedEntity);
                transaction.Upsert(upsertedEntity);
                updatedEntity["description"] = "Updated in transaction";
                transaction.Update(updatedEntity);
                await commitCall(transaction);
            }

            // Check we can fetch with the newly allocated keys
            var entities = db.Lookup(insertedEntity.Key, upsertedEntity.Key, updatedEntity.Key);
            var descriptions = entities.Select(e => (string) e["description"]);
            Assert.Equal(new[] { "Inserted in transaction", "Upserted in transaction", "Updated in transaction" }, descriptions);
        }
    }
}
