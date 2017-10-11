// Copyright 2017, Google Inc. All rights reserved.
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

using Grpc.Core;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.Data.IntegrationTests
{
    [Collection(nameof(FirestoreFixture))]
    public class CollectionListingTest
    {
        private readonly FirestoreFixture _fixture;

        public CollectionListingTest(FirestoreFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task ListRootCollectionsAsync()
        {
            var db = _fixture.FirestoreDb;

            // Create documents in two collections to make sure they exist.
            var collection1 = _fixture.CreateUniqueCollection();
            var collection2 = _fixture.CreateUniqueCollection();
            var batch = db.CreateWriteBatch();
            batch.Create(collection1.Document(null), new { Name = "doc1" });
            batch.Create(collection2.Document(null), new { Name = "doc2" });
            await batch.CommitAsync();

            var rootCollections = await db.ListRootCollectionsAsync().ToList();
            Assert.Contains(collection1, rootCollections);
            Assert.Contains(collection2, rootCollections);
        }

        [Fact]
        public async Task ListCollectionsAsync()
        {
            var doc = _fixture.NonQueryCollection.Document(null);
            var col1 = doc.Collection("col1");
            var col2 = doc.Collection("col2");
            // Put documents in the collections to force them to exist.
            await col1.AddAsync(new { Name = "doc1" });
            await col2.AddAsync(new { Name = "doc2" });

            var collections = await doc.ListCollectionsAsync().ToList();
            Assert.Equal(new[] { col1, col2 }, collections.OrderBy(c => c.Path));
        }
    }
}
