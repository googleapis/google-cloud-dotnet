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

using System.Linq;
using Xunit;
using static Google.Datastore.V1.QueryResultBatch.Types;

namespace Google.Datastore.V1.IntegrationTests
{
    [Collection(nameof(DatastoreFixture))]
    public class DatastoreDbTest
    {
        private readonly DatastoreFixture _fixture;

        public DatastoreDbTest(DatastoreFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Lookup_FullPartition()
        {
            var db = DatastoreDb.Create(_fixture.ProjectId, _fixture.NamespaceId);
            var keyFactory = db.CreateKeyFactory("test");
            var entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["foo"] = "bar"
            };
            var key = db.Insert(entity);

            var result = db.Lookup(key);
            Assert.NotNull(result);
            Assert.Equal("bar", (string)entity["foo"]);
        }

        [Fact]
        public void Lookup_NamespaceOnly()
        {
            var db = DatastoreDb.Create(_fixture.ProjectId, _fixture.NamespaceId);
            var keyFactory = db.CreateKeyFactory("test");
            var entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["foo"] = "bar"
            };
            var insertedKey = db.Insert(entity);

            var lookupKey = new Key { PartitionId = new PartitionId { NamespaceId = _fixture.NamespaceId }, Path = { insertedKey.Path } };
            var result = db.Lookup(lookupKey);
            Assert.NotNull(result);
            Assert.Equal("bar", (string)entity["foo"]);
        }

        [Fact]
        public void Lookup_NoPartition()
        {
            // Deliberately in the empty namespace, which won't be cleaned up automatically - hence the db.Delete call later.
            var db = DatastoreDb.Create(_fixture.ProjectId);
            var keyFactory = db.CreateKeyFactory("test");
            var entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["foo"] = "bar"
            };
            var insertedKey = db.Insert(entity);
            try
            {
                var lookupKey = new Key { Path = { insertedKey.Path } };
                var result = db.Lookup(lookupKey);
                Assert.NotNull(result);
                Assert.Equal("bar", (string)entity["foo"]);
            }
            finally
            {
                db.Delete(insertedKey);
            }
        }

        [Fact]
        public void RunQuery_NoResults()
        {
            var db = DatastoreDb.Create(_fixture.ProjectId, _fixture.NamespaceId);
            var query = db.RunQueryLazily(new Query("absent"));
            // Each of the checks below will run the query again, as the query is only lazily
            // evaluated.
            Assert.Equal(0, query.Count());
            var singleResponse = query.AsResponses().Single();
            Assert.Equal(MoreResultsType.NoMoreResults, singleResponse.Batch.MoreResults);
        }

        [Fact]
        public void Insert_ResultKeys()
        {
            var db = DatastoreDb.Create(_fixture.ProjectId, _fixture.NamespaceId);
            var keyFactory = db.CreateKeyFactory("insert_test");
            var keys = db.Insert(
                new Entity { Key = keyFactory.CreateKey("x"), ["description"] = "predefined_key" },
            new Entity { Key = keyFactory.CreateIncompleteKey(), ["description"] = "incomplete_key" });

            Assert.Null(keys[0]); // Insert with predefined key 
            Assert.NotNull(keys[1]); // Insert with incomplete key

            var fetchedEntity = db.Lookup(keys[1]);
            Assert.Equal("incomplete_key", fetchedEntity["description"]);
        }

        [Fact]
        public void Upsert_ResultKeys()
        {
            var db = DatastoreDb.Create(_fixture.ProjectId, _fixture.NamespaceId);
            var keyFactory = db.CreateKeyFactory("upsert_test");
            var insertedKey = db.Insert(new Entity { Key = keyFactory.CreateIncompleteKey(), ["description"] = "original" });

            var revisedEntity = new Entity { Key = insertedKey, ["description"] = "changed" };
            var newEntity1 = new Entity { Key = keyFactory.CreateKey("x"), ["description"] = "predefined_key" };
            var newEntity2 = new Entity { Key = keyFactory.CreateIncompleteKey(), ["description"] = "incomplete_key" };

            var keys = db.Upsert(revisedEntity, newEntity1, newEntity2);
            Assert.Null(keys[0]); // Update
            Assert.Null(keys[1]); // Insert with predefined key 
            Assert.NotNull(keys[2]); // Insert with incomplete key

            var fetchedEntity = db.Lookup(keys[2]);
            Assert.Equal("incomplete_key", fetchedEntity["description"]);
        }
    }
}
