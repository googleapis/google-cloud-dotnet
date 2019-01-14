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

using Google.Api.Gax.Grpc;
using Google.Cloud.Firestore.V1;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    public partial class WriteBatchTest
    {
        [Fact]
        public void Create()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            batch.Create(doc, new { Name = "Test", Score = 20 });

            var expectedWrite = new Write
            {
                CurrentDocument = new V1.Precondition { Exists = false },
                Update = new Document
                {
                    Name = doc.Path,
                    Fields =
                    {
                        { "Name", CreateValue("Test") },
                        { "Score", CreateValue(20) }
                    }
                }
            };
            AssertWrites(batch, (expectedWrite, true));
        }

        [Fact]
        public void Delete_NoPrecondition()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            batch.Delete(doc);

            var expectedWrite = new Write { Delete = doc.Path };
            AssertWrites(batch, (expectedWrite, true));
        }

        [Fact]
        public void Delete_WithPrecondition()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            batch.Delete(doc, Precondition.LastUpdated(new Timestamp(1 ,2)));

            var expectedWrite = new Write
            {
                Delete = doc.Path,
                CurrentDocument = new V1.Precondition { UpdateTime = CreateProtoTimestamp(1, 2) }
            };
            AssertWrites(batch, (expectedWrite, true));
        }

        [Fact]
        public void Update()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            var updates = new Dictionary<FieldPath, object>
            {
                { new FieldPath("a.b", "f.g"), 7 },
                { FieldPath.FromDotSeparatedString("h.m"), new Dictionary<string, object> { { "n.o", 7 } } }
            };

            batch.Update(doc, updates);

            var expectedWrite = new Write
            {
                CurrentDocument = new V1.Precondition { Exists = true },
                Update = new Document
                {
                    Name = doc.Path,
                    Fields =
                    {
                        { "a.b", CreateMap("f.g", CreateValue(7)) },
                        { "h", CreateMap("m", CreateMap("n.o", CreateValue(7))) }
                    }
                },
                UpdateMask = new DocumentMask { FieldPaths = { "`a.b`.`f.g`", "h.m" } }
            };
            AssertWrites(batch, (expectedWrite, true));
        }

        [Fact]
        public void Update_WithPrecondition()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            var updates = new Dictionary<FieldPath, object>
            {
                { new FieldPath("x"), "y" }
            };

            batch.Update(doc, updates, Precondition.LastUpdated(new Timestamp(1, 2)));

            var expectedWrite = new Write
            {
                CurrentDocument = new V1.Precondition { UpdateTime = CreateProtoTimestamp(1, 2) },
                Update = new Document
                {
                    Name = doc.Path,
                    Fields = { { "x", CreateValue("y") } }
                },
                UpdateMask = new DocumentMask { FieldPaths = { "x" } }
            };
            AssertWrites(batch, (expectedWrite, true));
        }

        [Fact]
        public void Update_WithPreconditionNone()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            var updates = new Dictionary<FieldPath, object>
            {
                { new FieldPath("x"), "y" }
            };

            batch.Update(doc, updates, Precondition.None);

            var expectedWrite = new Write
            {
                Update = new Document
                {
                    Name = doc.Path,
                    Fields = { { "x", CreateValue("y") } }
                },
                UpdateMask = new DocumentMask { FieldPaths = { "x" } }
            };
            AssertWrites(batch, (expectedWrite, true));
        }

        [Fact]
        public void Update_StringKeyedDictionary_WithPrecondition()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            var updates = new Dictionary<string, object>
            {
                { "x", "y" }
            };

            batch.Update(doc, updates, Precondition.LastUpdated(new Timestamp(1, 2)));

            var expectedWrite = new Write
            {
                CurrentDocument = new V1.Precondition { UpdateTime = CreateProtoTimestamp(1, 2) },
                Update = new Document
                {
                    Name = doc.Path,
                    Fields = { { "x", CreateValue("y") } }
                },
                UpdateMask = new DocumentMask { FieldPaths = { "x" } }
            };
            AssertWrites(batch, (expectedWrite, true));
        }

        [Fact]
        public void Update_Single_Field_WithPrecondition()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            batch.Update(doc, "x", "y", Precondition.LastUpdated(new Timestamp(1, 2)));

            var expectedWrite = new Write
            {
                CurrentDocument = new V1.Precondition { UpdateTime = CreateProtoTimestamp(1, 2) },
                Update = new Document
                {
                    Name = doc.Path,
                    Fields = { { "x", CreateValue("y") } }
                },
                UpdateMask = new DocumentMask { FieldPaths = { "x" } }
            };
            AssertWrites(batch, (expectedWrite, true));
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Set_Overwrite(bool explicitOptions)
        {
            var options = explicitOptions ? SetOptions.Overwrite : null;
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            var data = new { Name = "Test", Nested = new { Value1 = 10, Value2 = 20 }, Score = 30 };
            batch.Set(doc, data, options);

            var expectedWrite = new Write
            {
                Update = new Document
                {
                    Name = doc.Path,
                    Fields =
                    {
                        { "Name", CreateValue("Test") },
                        { "Nested", CreateMap(("Value1", CreateValue(10)), ("Value2", CreateValue(20))) },
                        { "Score", CreateValue(30) }
                    }
                }
                // No UpdateMask
            };
            AssertWrites(batch, (expectedWrite, true));
        }

        [Fact]
        public void Set_MergeAll()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            var data = new { Name = "Test", Nested = new { Value1 = 10, Value2 = 20 }, Score = 30 };
            batch.Set(doc, data, SetOptions.MergeAll);

            var expectedWrite = new Write
            {
                Update = new Document
                {
                    Name = doc.Path,
                    Fields =
                    {
                        { "Name", CreateValue("Test") },
                        { "Nested", CreateMap(("Value1", CreateValue(10)), ("Value2", CreateValue(20))) },
                        { "Score", CreateValue(30) }
                    }
                },
                UpdateMask = new DocumentMask { FieldPaths = { "Name", "Nested.Value1", "Nested.Value2", "Score" } }
            };
            AssertWrites(batch, (expectedWrite, true));
        }

        [Fact]
        public void Set_MergeFields()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            var doc = db.Document("col/doc");
            var data = new { Name = "Test", Nested = new { Value1 = 10, Value2 = 20 }, Score = 30 };
            batch.Set(doc, data, SetOptions.MergeFields("Name", "Nested.Value2"));

            var expectedWrite = new Write
            {
                Update = new Document
                {
                    Name = doc.Path,
                    // Only specified fields are included
                    Fields =
                    {
                        { "Name", CreateValue("Test") },
                        { "Nested", CreateMap("Value2", CreateValue(20)) }
                    }
                },
                UpdateMask = new DocumentMask { FieldPaths = { "Name", "Nested.Value2" } }
            };
            AssertWrites(batch, (expectedWrite, true));
        }

        [Fact]
        public async Task CommitAsync()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var write1 = new Write { Update = new Document { Name = "irrelevant1" } };
            var write2 = new Write { Update = new Document { Name = "irrelevant2" } };
            var write3 = new Write { Transform = new DocumentTransform { Document = "irrelevant3" } };
            var write4 = new Write { Transform = new DocumentTransform { Document = "irrelevant4" } };
            var write5 = new Write { Update = new Document { Name = "irrelevant5" } };
            var request = new CommitRequest
            {
                Database = "projects/proj/databases/db",
                Writes = { write1, write2, write3, write4, write5 }
            };
            var response = new CommitResponse
            {
                CommitTime = CreateProtoTimestamp(10, 500),
                WriteResults =
                {
                    new V1.WriteResult { UpdateTime = CreateProtoTimestamp(10, 0) },
                    // Deliberately no UpdateTime; result should default to CommitTime
                    new V1.WriteResult {  },
                    // Returned even though it's a transform (added with addResultIndex = true)
                    new V1.WriteResult { UpdateTime = CreateProtoTimestamp(100, 0) },
                    // Not returned (added with addResultIndex = false)
                    new V1.WriteResult { UpdateTime = CreateProtoTimestamp(125, 0) },
                    // Returned as the fourth result
                    new V1.WriteResult { UpdateTime = CreateProtoTimestamp(150, 0) },
                }
            };

            mock.Setup(c => c.CommitAsync(request, It.IsAny<CallSettings>())).ReturnsAsync(response);
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var reference = db.Document("col/doc");
            var batch = db.StartBatch();
            batch.Elements.AddRange(new[]
            {
                new WriteBatch.BatchElement(write1, true),
                new WriteBatch.BatchElement(write2, true),
                new WriteBatch.BatchElement(write3, true),
                new WriteBatch.BatchElement(write4, false),
                new WriteBatch.BatchElement(write5, true)
            });
            var actualTimestamps = (await batch.CommitAsync()).Select(x => x.UpdateTime);
            var expectedTimestamps = new[] { new Timestamp(10, 0), new Timestamp(10, 500), new Timestamp(100, 0), new Timestamp(150, 0) };
            Assert.Equal(expectedTimestamps, actualTimestamps);
            mock.VerifyAll();
        }

        [Fact]
        public void IsEmpty()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.StartBatch();
            Assert.True(batch.IsEmpty);
            batch.Create(db.Document("col/doc"), new { Name = "Test" });
            Assert.False(batch.IsEmpty);
        }

        private static void AssertWrites(WriteBatch batch, params (Write write, bool includeInWriteResults)[] elements)
        {
            // The ToList calls aren't strictly necessary, but make the failure output easier to read.
            var expectedWrites = elements.Select(e => CanonicalizeWrite(e.write)).ToList();
            var actualWrites = batch.Elements.Select(e => CanonicalizeWrite(e.Write)).ToList();
            Assert.Equal(expectedWrites, actualWrites);
            var expectedInclusions = elements.Select(e => e.includeInWriteResults).ToList();
            var actualInclusions = batch.Elements.Select(e => e.IncludeInWriteResults).ToList();
            Assert.Equal(expectedInclusions, actualInclusions);
        }

        /// <summary>
        /// Creates a canonical representation of a Write just by ordering lists predictably.
        /// </summary>
        internal static Write CanonicalizeWrite(Write input)
        {
            var clone = input.Clone();
            if (clone.UpdateMask != null)
            {
                clone.UpdateMask.FieldPaths.Clear();
                clone.UpdateMask.FieldPaths.AddRange(input.UpdateMask.FieldPaths.OrderBy(x => x, StringComparer.Ordinal));
            }
            if (clone.Transform != null)
            {
                clone.Transform.FieldTransforms.Clear();
                clone.Transform.FieldTransforms.AddRange(input.Transform.FieldTransforms.OrderBy(ft => ft.FieldPath, StringComparer.Ordinal));
            }
            return clone;
        }
    }
}
