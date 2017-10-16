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
using System.Linq;
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

        [Fact]
        public async Task Set()
        {
            var doc = await _fixture.NonQueryCollection.AddAsync(new { Name = "Original" });
            // Add a field
            await doc.SetAsync(new { Score = 20 }, SetOptions.MergeAll);
            var snapshot = await doc.SnapshotAsync();
            AssertSerialized(snapshot, new { Name = "Original", Score = 20 });

            // Update one field with "MergeAll"
            await doc.SetAsync(new { Score = 30 }, SetOptions.MergeAll);
            snapshot = await doc.SnapshotAsync();
            AssertSerialized(snapshot, new { Name = "Original", Score = 30 });

            // Update one field with "MergeFields"
            await doc.SetAsync(new { Name = "Ignored", Score = 30 }, SetOptions.MergeFields("Score"));
            snapshot = await doc.SnapshotAsync();
            AssertSerialized(snapshot, new { Name = "Original", Score = 30 });

            // Overwrite
            await doc.SetAsync(new { Text = "Different" });
            snapshot = await doc.SnapshotAsync();
            AssertSerialized(snapshot, new { Text = "Different" });
        }

        /// <summary>
        /// Execute a sequence of operations as per the specification, validating the result at each step.
        /// </summary>
        [Fact]
        public async Task SpecSequence()
        {
            var collection = _fixture.NonQueryCollection;
            var docRef = collection.Document(null);

            // Step 1: Create
            await docRef.CreateAsync(Map(("a.b", Map("c.d", 1)), ("e", 1)));
            var snapshot = await docRef.SnapshotAsync();
            AssertSerialized(snapshot, Map(("a.b", Map("c.d", 1L)), ("e", 1L)));

            // Step 2: Set (overwrite)
            await docRef.SetAsync(Map(("a.b", Map("f.g", 2)), ("h", Map("g", 2))));
            snapshot = await docRef.SnapshotAsync();
            AssertSerialized(snapshot, Map(("a.b", Map("f.g", 2L)), ("h", Map("g", 2L))));

            // Step 3: Set (merge)
            await docRef.SetAsync(Map("h", Map(("g", 3), ("f", 3))), SetOptions.MergeAll);
            snapshot = await docRef.SnapshotAsync();
            AssertSerialized(snapshot, Map(("a.b", Map("f.g", 2L)), ("h", Map(("g", 3L), ("f", 3L)))));

            // Step 4: Set (update path specified; only h.g is updated, not h.f)
            await docRef.SetAsync(Map("h", Map(("g", 4), ("f", 4))), SetOptions.MergeFields("h.g"));
            snapshot = await docRef.SnapshotAsync();
            AssertSerialized(snapshot, Map(("a.b", Map("f.g", 2L)), ("h", Map(("g", 4L), ("f", 3L)))));

            // Step 5: Set (update path specified; all of h is overwritten)
            await docRef.SetAsync(Map("h", Map(("g", 5), ("f", 5))), SetOptions.MergeFields("h"));
            snapshot = await docRef.SnapshotAsync();
            AssertSerialized(snapshot, Map(("a.b", Map("f.g", 2L)), ("h", Map(("g", 5L), ("f", 5L)))));

            // Step 6: Update
            await docRef.UpdateAsync(new Dictionary<FieldPath, object>
            {
                { new FieldPath("h", "g"), Map("j.k", 6) },
            });
            snapshot = await docRef.SnapshotAsync();
            AssertSerialized(snapshot, Map(("a.b", Map("f.g", 2L)), ("h", Map(("g", Map("j.k", 6L)), ("f", 5L)))));

            // Step 7: Update (varargs in Java)
            await docRef.UpdateAsync(new Dictionary<FieldPath, object>
            {
                { new FieldPath("a.b", "f.g"), 7 },
                { new FieldPath("h", "m"), Map("n.o", 7) }
            });
            snapshot = await docRef.SnapshotAsync();
            AssertSerialized(snapshot, Map(("a.b", Map("f.g", 7L)), ("h", Map(("g", Map("j.k", 6L)), ("f", 5L), ("m", Map("n.o", 7L))))));

            // Step 8: Update (varargs in Java)
            await docRef.UpdateAsync(new Dictionary<FieldPath, object>
            {
                { new FieldPath("a.b"), 8 },
                { new FieldPath("h"), 8 },
            });
            snapshot = await docRef.SnapshotAsync();
            AssertSerialized(snapshot, Map(("a.b", 8L), ("h", 8L)));

            // Step 9: Delete
            await docRef.DeleteAsync();
            var doc = await docRef.SnapshotAsync();
            Assert.False(doc.Exists);
        }

        // Helpers to avoid "new Dictionary<string, object>" everywhere...
        private Dictionary<string, object> Map(string name, object value) => new Dictionary<string, object> { { name, value } };
        private Dictionary<string, object> Map(params (string name, object value)[] fields) =>
            fields.ToDictionary(field => field.name, field => field.value);

        /// <summary>
        /// Asserts that the document in snapshot is the serialized form of the expected value.
        /// Note that the actual snapshot is the first parameter, somewhat unconventionally, as the expected value
        /// is usually wordier in code, and works better as the final argument.
        /// </summary>
        private void AssertSerialized(DocumentSnapshot snapshot, object expectedValue)
        {
            var serialized = ValueSerializer.SerializeMap(expectedValue);
            Assert.Equal(serialized, snapshot.Document.Fields);
        }
    }
}
