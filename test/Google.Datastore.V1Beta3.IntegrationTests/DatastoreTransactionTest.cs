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

namespace Google.Datastore.V1Beta3.IntegrationTests
{
    [Collection(nameof(DatastoreFixture))]
    public class DatastoreTransactionTest
    {
        private readonly DatastoreFixture _fixture;

        public DatastoreTransactionTest(DatastoreFixture fixture)
        {
            _fixture = fixture;
        }

        public void Query_ImplicitlyUsesPartition()
        {
            var db = DatastoreDb.Create(_fixture.ProjectId, _fixture.NamespaceId);
            var keyFactory = db.CreateKeyFactory("test");
            var entity = new Entity
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["foo"] = Guid.NewGuid().ToString()
            };
            var insertedKey = db.Insert(entity);
            using (var transaction = db.BeginTransaction())
            {
                var query = new Query("test") { Filter = Filter.Equal("foo", entity["foo"]) };
                var results = transaction.RunQuery(query);
                Assert.Equal(1, results.Count());
            }
        }
    }
}
