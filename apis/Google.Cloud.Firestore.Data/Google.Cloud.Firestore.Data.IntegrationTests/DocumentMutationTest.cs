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

using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.Data.IntegrationTests
{
    [Collection(nameof(FirestoreFixture))]
    public class DocumentMutationTest
    {
        private readonly FirestoreFixture _fixture;

        public DocumentMutationTest(FirestoreFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task Update()
        {
            var doc = await _fixture.NonQueryCollection.AddAsync(new { Name = "Original" });
            // Add a field
            await doc.UpdateAsync(new Dictionary<FieldPath, object> { { new FieldPath("Score"), 20 } });
            var snapshot = await doc.SnapshotAsync();
            AssertSerialized(snapshot, new { Name = "Original", Score = 20 });

            // Update a field
            await doc.UpdateAsync(new Dictionary<FieldPath, object> { { new FieldPath("Name"), "Changed"} });
            snapshot = await doc.SnapshotAsync();
            AssertSerialized(snapshot, new { Name = "Changed", Score = 20 });

            // Update a field to a map
            // Note: deliberately to microsecond precision only, as that's what's supported for user-specified timestamps.
            Timestamp timestamp = new Timestamp(1, 123456000);
            await doc.UpdateAsync(new Dictionary<FieldPath, object> { { new FieldPath("Score"), new { CustomTime = timestamp, Value = 10 } } });
            snapshot = await doc.SnapshotAsync();
            AssertSerialized(snapshot, new { Name = "Changed", Score = new { CustomTime = timestamp, Value = 10 } });

            // Update one field in a map
            await doc.UpdateAsync(new Dictionary<FieldPath, object> { { new FieldPath("Score", "Value"), 30 } });
            snapshot = await doc.SnapshotAsync();
            AssertSerialized(snapshot, new { Name = "Changed", Score = new { CustomTime = timestamp, Value = 30 } });

            // Update two fields, add another

            await doc.UpdateAsync(new Dictionary<FieldPath, object>
            {
                { new FieldPath("Name"), "Changed again" },
                { new FieldPath("Score", "Value"), 40 },
                { new FieldPath("Level"), 2 }
            });
            snapshot = await doc.SnapshotAsync();
            AssertSerialized(snapshot, new { Name = "Changed again", Level = 2, Score = new { CustomTime = timestamp, Value = 40 } });
        }

        /// <summary>
        /// Asserts that the document in snapshot is the serialized form of the expected value.
        /// </summary>
        private void AssertSerialized(DocumentSnapshot snapshot, object expectedValue)
        {
            var serialized = ValueSerializer.SerializeMap(expectedValue);
            Assert.Equal(serialized, snapshot.Document.Fields);
        }
    }
}
