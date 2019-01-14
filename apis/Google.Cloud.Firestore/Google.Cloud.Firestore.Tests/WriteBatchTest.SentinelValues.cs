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

using Google.Cloud.Firestore.V1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;
using static Google.Cloud.Firestore.V1.DocumentTransform.Types;

namespace Google.Cloud.Firestore.Tests
{
    // Just tests for the handling of sentinel values. These use
    // WriteBatch.Set as it lets us check the update mask handling too.
    public partial class WriteBatchTest
    {
        public static TheoryData<object> SentinelValuesInArraysData { get; } = new TheoryData<object>
        {
            // Single check that ServerTimestamp counts as a sentinel value. For the rest of the
            // test data, we'll just use Delete
            new { Values = new[] { FieldValue.ServerTimestamp } },

            // Directly in an array
            new { Values = new[] { FieldValue.Delete } },

            // In a field in an array
            new { Values = new[] { new { DeleteMe = FieldValue.Delete } } },

            // In a nested array
            new { Values = new[] { new { DeleteMe = new[] { FieldValue.Delete } } } },

            // An array within a map
            new { Foo = new { Score = 10, Values = new[] { FieldValue.Delete } } }
        };

        public static TheoryData<object> NoSentinelValuesInArraysData { get; } = new TheoryData<object>
        {
            // Each object has a sentinel value in a valid position.
            new { Values = new[] { 1, 2 }, DeleteMe = FieldValue.Delete },
            new { Values = new[] { new { Fields = new { NestedArray = new[] { 1, 2 }, Text = "Foo" } } }, DeleteMe = FieldValue.Delete }
        };

        /// <summary>
        /// Array values cannot contain sentinel values (delete/server-timestamp) anywhere,
        /// including via recursion.
        /// </summary>
        [Theory]
        [MemberData(nameof(SentinelValuesInArraysData))]
        public void SentinelValuesInArrays(object documentData)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            Assert.Throws<ArgumentException>(() => batch.Set(doc, documentData, SetOptions.MergeAll));
        }

        [Theory]
        [MemberData(nameof(NoSentinelValuesInArraysData))]
        public void NoSentinelValuesInArrays(object documentData)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            // Don't check the result, just that it doesn't throw.
            batch.Set(doc, documentData, SetOptions.MergeAll);
        }

        [Fact]
        public void SentinelValues_Simple()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            var data = new { Name = "Test", DeleteMe = FieldValue.Delete, Timestamp = FieldValue.ServerTimestamp };
            batch.Set(doc, data, SetOptions.MergeAll);

            var expectedUpdate = new Write
            {
                Update = new Document
                {
                    Name = doc.Path,
                    Fields = { { "Name", CreateValue("Test") } }
                },
                UpdateMask = new DocumentMask { FieldPaths = { "Name", "DeleteMe" } }
            };
            var expectedTransform = new Write
            {
                Transform = new DocumentTransform
                {
                    Document = doc.Path,
                    FieldTransforms = { ServerTimestampTransform("Timestamp") }
                }
            };
            AssertWrites(batch, (expectedUpdate, true), (expectedTransform, false));
        }

        [Fact]
        public void SentinelValues_NestedSentinels()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            var data = new
            {
                ValueA = new { Name = "Test", TimestampA = FieldValue.ServerTimestamp, DeleteMeA = FieldValue.Delete },
                ValueB = new { TimestampB = FieldValue.ServerTimestamp, DeleteMeB = FieldValue.Delete },
            };
            batch.Set(doc, data, SetOptions.MergeAll);

            var expectedUpdate = new Write
            {
                Update = new Document
                {
                    Name = doc.Path,
                    Fields =
                    {
                        { "ValueA", CreateMap(("Name", CreateValue("Test"))) },
                    }
                },
                UpdateMask = new DocumentMask { FieldPaths = { "ValueA.Name", "ValueA.DeleteMeA", "ValueB.DeleteMeB" } }
            };
            var expectedTransform = new Write
            {
                Transform = new DocumentTransform
                {
                    Document = doc.Path,
                    FieldTransforms = { ServerTimestampTransform("ValueA.TimestampA"), ServerTimestampTransform("ValueB.TimestampB") }
                }
            };
            AssertWrites(batch, (expectedUpdate, true), (expectedTransform, false));
        }

        [Fact]
        public void SentinelValues_OnlyTransform()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            var data = new { Timestamp = FieldValue.ServerTimestamp };
            batch.Set(doc, data, SetOptions.MergeAll);
            // No Update.
            var expectedTransform = new Write
            {
                Transform = new DocumentTransform
                {
                    Document = doc.Path,
                    FieldTransforms = { ServerTimestampTransform("Timestamp") }
                }
            };
            AssertWrites(batch, (expectedTransform, true));
        }

        private static FieldTransform ServerTimestampTransform(string fieldPath) =>
            new FieldTransform { FieldPath = fieldPath, SetToServerValue = FieldTransform.Types.ServerValue.RequestTime };
    }
}