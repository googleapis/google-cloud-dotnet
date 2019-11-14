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

using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.IntegrationTests
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
            var batch = db.StartBatch();
            batch.Create(collection1.Document(), new { Name = "doc1" });
            batch.Create(collection2.Document(), new { Name = "doc2" });
            await batch.CommitAsync();

            var rootCollections = await db.ListRootCollectionsAsync().ToListAsync();
            Assert.Contains(collection1, rootCollections);
            Assert.Contains(collection2, rootCollections);
        }

        [Fact]
        public async Task ListCollectionsAsync()
        {
            var doc = _fixture.NonQueryCollection.Document();
            var col1 = doc.Collection("col1");
            var col2 = doc.Collection("col2");
            // Put documents in the collections to force them to exist.
            await col1.AddAsync(new { Name = "doc1" });
            await col2.AddAsync(new { Name = "doc2" });

            var collections = await doc.ListCollectionsAsync().ToListAsync();
            Assert.Equal(new[] { col1, col2 }, collections.OrderBy(c => c.Path));
        }

        [Fact]
        public async Task ListDocuments_IncludesMissingDocuments()
        {
            var db = _fixture.FirestoreDb;

            // Create two documents:
            // random-col/missing-outer/inner/present-inner
            // random-col/present-outer

            // When we list "random-col", we should get both random-col/missing-outer
            // and random-col/present-outer, 
            var outerCol = _fixture.CreateUniqueCollection();
            var missingOuterDoc = outerCol.Document("missing-outer"); // This document is never created
            var presentOuterDoc = outerCol.Document("present-outer");
            var innerCol = missingOuterDoc.Collection("inner");
            var innerDoc = innerCol.Document("present-inner");

            await presentOuterDoc.CreateAsync(new { Value = 5 });
            await innerDoc.CreateAsync(new { Value = 10 });

            var docs = await outerCol.ListDocumentsAsync().ToListAsync();
            Assert.Equal(new[] { missingOuterDoc, presentOuterDoc }, docs);

            // Check that the missing document really doesn't exist
            var missingSnapshot = await missingOuterDoc.GetSnapshotAsync();
            Assert.False(missingSnapshot.Exists);

            // We should be able to find the nested collection within it...
            var nestedCollections = await missingOuterDoc.ListCollectionsAsync().ToListAsync();
            Assert.Equal(new[] { innerCol }, nestedCollections);

            // And the nested *existing* document within that.
            var nestedDocuments = await innerCol.ListDocumentsAsync().ToListAsync();
            Assert.Equal(new[] { innerDoc }, nestedDocuments);
        }

    }
}
