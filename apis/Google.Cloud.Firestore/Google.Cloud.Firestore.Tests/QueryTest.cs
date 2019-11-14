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
using Google.Cloud.ClientTesting;
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace Google.Cloud.Firestore.Tests
{
    public partial class QueryTest
    {
        private static readonly FirestoreDb s_db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());

        private static Query GetEmptyQuery() => s_db.Collection("col");

        [Fact]
        public void Select()
        {
            var query = GetEmptyQuery().Select("a.b", "c");
            var expected = new StructuredQuery
            {
                Select = new Projection { Fields = { Field("a.b"), Field("c") } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        // Individual filter methods, for coverage and to guard against copy/paste errors

        [Fact]
        public void Where_EqualTo_String()
        {
            var query = GetEmptyQuery().WhereEqualTo("a.b", "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_EqualTo_FieldPath()
        {
            var query = GetEmptyQuery().WhereEqualTo(new FieldPath("a", "b"), "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_LessThan_String()
        {
            var query = GetEmptyQuery().WhereLessThan("a.b", "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.LessThan, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_LessThan_FieldPath()
        {
            var query = GetEmptyQuery().WhereLessThan(new FieldPath("a", "b"), "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.LessThan, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_LessThanOrEqualTo_String()
        {
            var query = GetEmptyQuery().WhereLessThanOrEqualTo("a.b", "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.LessThanOrEqual, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_LessThanOrEqualTo_FieldPath()
        {
            var query = GetEmptyQuery().WhereLessThanOrEqualTo(new FieldPath("a", "b"), "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.LessThanOrEqual, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_ArrayContains_String()
        {
            var query = GetEmptyQuery().WhereArrayContains("a.b", "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.ArrayContains, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_ArrayContains_FieldPath()
        {
            var query = GetEmptyQuery().WhereArrayContains(new FieldPath("a", "b"), "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.ArrayContains, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_GreaterThan_String()
        {
            var query = GetEmptyQuery().WhereGreaterThan("a.b", "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.GreaterThan, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_GreaterThan_FieldPath()
        {
            var query = GetEmptyQuery().WhereGreaterThan(new FieldPath("a", "b"), "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.GreaterThan, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_GreaterThanOrEqualTo_String()
        {
            var query = GetEmptyQuery().WhereGreaterThanOrEqualTo("a.b", "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.GreaterThanOrEqual, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_GreaterThanOrEqualTo_FieldPath()
        {
            var query = GetEmptyQuery().WhereGreaterThanOrEqualTo(new FieldPath("a", "b"), "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.GreaterThanOrEqual, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Theory]
        [InlineData(double.NaN)]
        [InlineData(float.NaN)]
        public void Where_SingleNaNFilter(object value)
        {
            var query = GetEmptyQuery().WhereEqualTo("a.b", value);
            var expected = new StructuredQuery
            {
                Where = Filter(new UnaryFilter { Field = Field("a.b"), Op = UnaryFilter.Types.Operator.IsNan }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_SingleNullFilter()
        {
            var query = GetEmptyQuery().WhereEqualTo("a.b", null);
            var expected = new StructuredQuery
            {
                Where = Filter(new UnaryFilter { Field = Field("a.b"), Op = UnaryFilter.Types.Operator.IsNull }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void Where_CompositeFilter()
        {
            var query = GetEmptyQuery()
                .WhereGreaterThanOrEqualTo("a", "x")
                .WhereEqualTo("b", "y")
                .WhereEqualTo("c", "z");
            var expected = new StructuredQuery
            {
                Where = CompositeFilter(
                    Filter(new FieldFilter { Field = Field("a"), Op = FieldFilter.Types.Operator.GreaterThanOrEqual, Value = CreateValue("x") }),
                    Filter(new FieldFilter { Field = Field("b"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("y") }),
                    Filter(new FieldFilter { Field = Field("c"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("z") })
                ),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }        

        // Test for methods which replace previous values
        [Fact]
        public void ReplacementCalls()
        {
            var query = GetEmptyQuery()
                .Select("ignored")
                .Select("x")
                .OrderBy("foo") // Required for start/end
                .StartAt("ignored")
                .StartAfter("a")
                .EndAt("ignored")
                .EndBefore("b")
                .Offset(100)
                .Offset(5)
                .Limit(100)
                .Limit(10);
            var expected = new StructuredQuery
            {
                Select = new Projection { Fields = { Field("x") } },
                OrderBy = { new Order { Field = Field("foo"), Direction = Direction.Ascending } },
                StartAt = new Cursor { Before = false, Values = { CreateValue("a") } },
                EndAt = new Cursor { Before = true, Values = { CreateValue("b") } },
                Offset = 5,
                Limit = 10,
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void OrderBy_String()
        {
            var query = GetEmptyQuery().OrderBy("foo");
            var expected = new StructuredQuery
            {
                OrderBy = { new Order { Field = Field("foo"), Direction = Direction.Ascending } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void OrderBy_FieldPath()
        {
            var query = GetEmptyQuery().OrderBy(new FieldPath("foo"));
            var expected = new StructuredQuery
            {
                OrderBy = { new Order { Field = Field("foo"), Direction = Direction.Ascending } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void OrderByDescending_String()
        {
            var query = GetEmptyQuery().OrderByDescending("foo");
            var expected = new StructuredQuery
            {
                OrderBy = { new Order { Field = Field("foo"), Direction = Direction.Descending } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void OrderByDescending_FieldPath()
        {
            var query = GetEmptyQuery().OrderByDescending(new FieldPath("foo"));
            var expected = new StructuredQuery
            {
                OrderBy = { new Order { Field = Field("foo"), Direction = Direction.Descending } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void OrderAfterCursor()
        {
            var query = GetEmptyQuery().OrderBy("foo").StartAt("x");
            Assert.Throws<InvalidOperationException>(() => query.OrderBy("bar"));
            Assert.Throws<InvalidOperationException>(() => query.OrderByDescending("bar"));
            Assert.Throws<InvalidOperationException>(() => query.OrderBy(new FieldPath("bar")));
            Assert.Throws<InvalidOperationException>(() => query.OrderByDescending(new FieldPath("bar")));
        }

        [Fact]
        public void StartAt()
        {
            var query = GetEmptyQuery().OrderBy("foo").OrderBy("bar").OrderBy("baz").StartAt(1, "x");
            var expected = new StructuredQuery
            {
                OrderBy =
                {
                    new Order { Field = Field("foo"), Direction = Direction.Ascending },
                    new Order { Field = Field("bar"), Direction = Direction.Ascending },
                    new Order { Field = Field("baz"), Direction = Direction.Ascending },
                },
                StartAt = new Cursor { Before = true, Values = { CreateValue(1), CreateValue("x") } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void StartAt_EmptyValue()
        {
            var query = GetEmptyQuery().OrderBy("foo").StartAt(new List<object>());
            var expected = new StructuredQuery
            {
                OrderBy =
                {
                    new Order { Field = Field("foo"), Direction = Direction.Ascending }
                },
                StartAt = new Cursor { Before = true, Values = { CreateArray() } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void StartAfter()
        {
            var query = GetEmptyQuery().OrderBy("foo").OrderBy("bar").OrderBy("baz").StartAfter(1, "x");
            var expected = new StructuredQuery
            {
                OrderBy =
                {
                    new Order { Field = Field("foo"), Direction = Direction.Ascending },
                    new Order { Field = Field("bar"), Direction = Direction.Ascending },
                    new Order { Field = Field("baz"), Direction = Direction.Ascending },
                },
                StartAt = new Cursor { Before = false, Values = { CreateValue(1), CreateValue("x") } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }
        
        [Fact]
        public void EndAt()
        {
            var query = GetEmptyQuery().OrderBy("foo").OrderBy("bar").OrderBy("baz").EndAt(1, "x");
            var expected = new StructuredQuery
            {
                OrderBy =
                {
                    new Order { Field = Field("foo"), Direction = Direction.Ascending },
                    new Order { Field = Field("bar"), Direction = Direction.Ascending },
                    new Order { Field = Field("baz"), Direction = Direction.Ascending },
                },
                EndAt = new Cursor { Before = false, Values = { CreateValue(1), CreateValue("x") } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void EndBefore()
        {
            var query = GetEmptyQuery().OrderBy("foo").OrderBy("bar").OrderBy("baz").EndBefore(1, "x");
            var expected = new StructuredQuery
            {
                OrderBy =
                {
                    new Order { Field = Field("foo"), Direction = Direction.Ascending },
                    new Order { Field = Field("bar"), Direction = Direction.Ascending },
                    new Order { Field = Field("baz"), Direction = Direction.Ascending },
                },
                EndAt = new Cursor { Before = true, Values = { CreateValue(1), CreateValue("x") } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Theory]
        [InlineData("x", "y")]
        public void InvalidCursor(params object[] values)
        {
            var query = GetEmptyQuery().OrderBy("foo");

            Assert.Throws<ArgumentException>(() => query.StartAt(values));
            Assert.Throws<ArgumentException>(() => query.StartAfter(values));
            Assert.Throws<ArgumentException>(() => query.EndAt(values));
            Assert.Throws<ArgumentException>(() => query.EndBefore(values));
        }

        public static TheoryData<object> InvalidDocumentIdCursorValues { get; } = new TheoryData<object>
        {
            // Incorrect types
            10,
            1.5,
            DateTime.UtcNow,
            // Relative paths that aren't to a document
            "",
            "doc2/col2",
            "doc2/",
            "doc2//",
            // Relative path to a grandchild document
            "doc2/col2/doc3",
            // DocumentReference not in this collection
            s_db.Document("othercol/doc"),
            // DocumentReference which isn't a direct chid
            "col/doc/col2/doc2"
        };

        [Theory]
        [MemberData(nameof(InvalidDocumentIdCursorValues))]
        public void DocumentIdCursor_Invalid(object value)
        {
            var query = GetEmptyQuery().OrderBy(FieldPath.DocumentId);
            Assert.Throws<ArgumentException>(() => query.StartAt(value));
        }

        [Fact]
        public void DocumentIdCursor_ValidRelativePath()
        {
            var query = GetEmptyQuery().OrderBy(FieldPath.DocumentId).StartAt("foo");
            var expected = new Value { ReferenceValue = s_db.Document("col/foo").Path };
            var actual = query.ToStructuredQuery().StartAt.Values.Single();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("col/foo")]
        public void DocumentIdCursor_ValidDocumentReference(string path)
        {
            var doc = s_db.Document(path);
            var query = GetEmptyQuery().OrderBy(FieldPath.DocumentId).StartAt(doc);
            var expected = new Value { ReferenceValue = doc.Path };
            var actual = query.ToStructuredQuery().StartAt.Values.Single();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LimitValidation()
        {
            var query = GetEmptyQuery();
            query.Limit(0);
            Assert.Throws<ArgumentOutOfRangeException>(() => query.Limit(-1));
        }

        [Fact]
        public void InvalidOffset()
        {
            var query = GetEmptyQuery();
            query.Offset(0);
            Assert.Throws<ArgumentOutOfRangeException>(() => query.Offset(-1));
        }

        [Fact]
        public void KitchenSink()
        {
            var query = GetEmptyQuery()
                .Select("a.b", "c.d")
                .WhereEqualTo("a", null)
                .WhereGreaterThan("b", 10)
                .OrderBy("foo")
                .OrderByDescending("bar")
                .StartAt("x", 10)
                .EndAt("y")
                .Offset(3)
                .Limit(2);

            var expected = new StructuredQuery
            {
                Select = new Projection { Fields = { Field("a.b"), Field("c.d") } },
                Where = CompositeFilter(
                    Filter(new UnaryFilter { Field = Field("a"), Op = UnaryFilter.Types.Operator.IsNull }),
                    Filter(new FieldFilter { Field = Field("b"), Op = FieldFilter.Types.Operator.GreaterThan, Value = CreateValue(10) })
                ),
                OrderBy =
                {
                    new Order { Field = Field("foo"), Direction = Direction.Ascending },
                    new Order { Field = Field("bar"), Direction = Direction.Descending }
                },
                StartAt = new Cursor { Before = true, Values = { CreateValue("x"), CreateValue(10) } },
                EndAt = new Cursor { Before = false, Values = { CreateValue("y") } },
                Offset = 3,
                Limit = 2,
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public async Task GetSnapshotAsync_NoDocuments()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var request = new RunQueryRequest
            {
                Parent = "projects/proj/databases/db/documents",
                StructuredQuery = new StructuredQuery
                {
                    Select = new Projection { Fields = { Field("Name") } },
                    From = { new CollectionSelector { CollectionId = "col" } }
                }
            };
            var responses = new[]
            {
                new RunQueryResponse { ReadTime = CreateProtoTimestamp(1, 2) }
            };
            mock.Setup(c => c.RunQuery(request, It.IsAny<CallSettings>())).Returns(new FakeQueryStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var query = db.Collection("col").Select("Name");
            var snapshot = await query.GetSnapshotAsync();
            Assert.Empty(snapshot.Documents);
            Assert.Same(query, snapshot.Query);
            Assert.Equal(new Timestamp(1, 2), snapshot.ReadTime);

            mock.VerifyAll();
        }

        [Fact]
        public async Task GetSnapshotAsync_WithDocuments()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var request = new RunQueryRequest
            {
                Parent = "projects/proj/databases/db/documents",
                StructuredQuery = new StructuredQuery
                {
                    Select = new Projection { Fields = { Field("Name") } },
                    From = { new CollectionSelector { CollectionId = "col" } },
                    Offset = 3
                }
            };
            var responses = new[]
            {
                new RunQueryResponse { SkippedResults = 3 },
                new RunQueryResponse
                {
                    ReadTime = CreateProtoTimestamp(1, 2),
                    Document = new Document
                    {
                        CreateTime = CreateProtoTimestamp(0, 1),
                        UpdateTime = CreateProtoTimestamp(0, 2),
                        Name = "projects/proj/databases/db/documents/col/doc1",
                        Fields = { { "Name", CreateValue("x") } }
                    }
                },
                new RunQueryResponse
                {
                    ReadTime = CreateProtoTimestamp(1, 3),
                    Document = new Document
                    {
                        CreateTime = CreateProtoTimestamp(0, 3),
                        UpdateTime = CreateProtoTimestamp(0, 4),
                        Name = "projects/proj/databases/db/documents/col/doc2",
                        Fields = { { "Name", CreateValue("y") } }
                    }
                }
            };
            mock.Setup(c => c.RunQuery(request, It.IsAny<CallSettings>())).Returns(new FakeQueryStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var query = db.Collection("col").Select("Name").Offset(3);
            var snapshot = await query.GetSnapshotAsync();
            Assert.Equal(2, snapshot.Documents.Count);
            Assert.Same(query, snapshot.Query);
            Assert.Equal(new Timestamp(1, 2), snapshot.ReadTime); // From first document

            var doc1 = snapshot.Documents[0];
            Assert.Equal(db.Document("col/doc1"), doc1.Reference);
            Assert.Equal(new Timestamp(1, 2), doc1.ReadTime);
            Assert.Equal(new Timestamp(0, 1), doc1.CreateTime);
            Assert.Equal(new Timestamp(0, 2), doc1.UpdateTime);
            Assert.Equal("x", doc1.GetValue<string>("Name"));

            var doc2 = snapshot.Documents[1];
            Assert.Equal(db.Document("col/doc2"), doc2.Reference);
            Assert.Equal(new Timestamp(1, 3), doc2.ReadTime);
            Assert.Equal(new Timestamp(0, 3), doc2.CreateTime);
            Assert.Equal(new Timestamp(0, 4), doc2.UpdateTime);
            Assert.Equal("x", doc1.GetValue<string>("Name"));
            mock.VerifyAll();
        }

        [Fact]
        public async Task GetSnapshotAsync_NoResponses()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var request = new RunQueryRequest
            {
                Parent = "projects/proj/databases/db/documents",
                StructuredQuery = new StructuredQuery
                {
                    Select = new Projection { Fields = { Field("Name") } },
                    From = { new CollectionSelector { CollectionId = "col" } }
                }
            };
            var responses = new RunQueryResponse[0];
            mock.Setup(c => c.RunQuery(request, It.IsAny<CallSettings>())).Returns(new FakeQueryStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var query = db.Collection("col").Select("Name");
            // This shouldn't happen, of course - but let's check that we do what we expect.
            await Assert.ThrowsAsync<InvalidOperationException>(() => query.GetSnapshotAsync());
            mock.VerifyAll();
        }

        [Fact]
        public async Task StreamAsync_WithDocuments()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var request = new RunQueryRequest
            {
                Parent = "projects/proj/databases/db/documents",
                StructuredQuery = new StructuredQuery
                {
                    Select = new Projection { Fields = { Field("Name") } },
                    From = { new CollectionSelector { CollectionId = "col" } },
                    Offset = 3
                },
                Transaction = ByteString.CopyFrom(1, 2, 3, 4)
            };
            var responses = new[]
            {
                new RunQueryResponse { SkippedResults = 3 },
                new RunQueryResponse
                {
                    ReadTime = CreateProtoTimestamp(1, 2),
                    Document = new Document
                    {
                        CreateTime = CreateProtoTimestamp(0, 1),
                        UpdateTime = CreateProtoTimestamp(0, 2),
                        Name = "projects/proj/databases/db/documents/col/doc1",
                        Fields = { { "Name", CreateValue("x") } }
                    }
                },
                new RunQueryResponse
                {
                    ReadTime = CreateProtoTimestamp(1, 3),
                    Document = new Document
                    {
                        CreateTime = CreateProtoTimestamp(0, 3),
                        UpdateTime = CreateProtoTimestamp(0, 4),
                        Name = "projects/proj/databases/db/documents/col/doc2",
                        Fields = { { "Name", CreateValue("y") } }
                    }
                }
            };
            mock.Setup(c => c.RunQuery(request, It.IsAny<CallSettings>())).Returns(new FakeQueryStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var query = db.Collection("col").Select("Name").Offset(3);
            // Just for variety, we'll provide a transaction ID this time...
            var documents = await query.StreamAsync(ByteString.CopyFrom(1, 2, 3, 4)).ToListAsync();
            Assert.Equal(2, documents.Count);

            var doc1 = documents[0];
            Assert.Equal(db.Document("col/doc1"), doc1.Reference);
            Assert.Equal(new Timestamp(1, 2), doc1.ReadTime);
            Assert.Equal(new Timestamp(0, 1), doc1.CreateTime);
            Assert.Equal(new Timestamp(0, 2), doc1.UpdateTime);
            Assert.Equal("x", doc1.GetValue<string>("Name"));

            var doc2 = documents[1];
            Assert.Equal(db.Document("col/doc2"), doc2.Reference);
            Assert.Equal(new Timestamp(1, 3), doc2.ReadTime);
            Assert.Equal(new Timestamp(0, 3), doc2.CreateTime);
            Assert.Equal(new Timestamp(0, 4), doc2.UpdateTime);
            Assert.Equal("x", doc1.GetValue<string>("Name"));
            mock.VerifyAll();
        }

        [Fact]
        public async Task StreamAsync_NoResponses()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var request = new RunQueryRequest
            {
                Parent = "projects/proj/databases/db/documents",
                StructuredQuery = new StructuredQuery
                {
                    Select = new Projection { Fields = { Field("Name") } },
                    From = { new CollectionSelector { CollectionId = "col" } }
                }
            };
            var responses = new RunQueryResponse[0];
            mock.Setup(c => c.RunQuery(request, It.IsAny<CallSettings>())).Returns(new FakeQueryStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var query = db.Collection("col").Select("Name");
            var documents = await query.StreamAsync().ToListAsync();
            Assert.Empty(documents);
            mock.VerifyAll();
        }

        [Fact]
        public void Equality_CollectionRefNotEqualToQuery()
        {
            var col1 = s_db.Collection("col1");
            var col2 = s_db.Collection("col2");

            // Collection and "a Query isn't equal to a CollectionReference"
            var query = col1.Offset(0);
            EqualityTester.AssertEqual(query, equal: new[] { col1.Offset(0), query.Offset(0) }, unequal: new[] { col1, col2.Offset(0) });
        }

        [Fact]
        public void Equality_Offset()
        {
            var col = s_db.Collection("col");
            var query = col.Offset(1);
            EqualityTester.AssertEqual(query,
                equal: new[] { col.Offset(1), query.Offset(1) },
                unequal: new[] { col.Offset(2), query.Offset(2) });
        }

        [Fact]
        public void Equality_Limit()
        {
            var col = s_db.Collection("col");
            var query = col.Limit(10);
            EqualityTester.AssertEqual(query,
                equal: new[] { col.Limit(10), query.Limit(10) },
                unequal: new[] { col.Limit(2), query.Limit(2) });
        }

        [Fact]
        public void Equality_Where()
        {
            var col = s_db.Collection("col");
            var query = col.WhereEqualTo("field", 10);
            EqualityTester.AssertEqual(query,
                equal: new[] {
                    col.WhereEqualTo("field", 10), // Same value
                    col.WhereEqualTo("field", 10L), // Same value after serialization
                    col.WhereEqualTo(new FieldPath("field"), 10), // FieldPath instead of Field
                },
                unequal: new[] {
                    query.WhereEqualTo("field", 10), // Repeated filter doesn't replace (at the moment, anyway)
                    col.WhereEqualTo("otherfield", 10), // Different field
                    col.WhereLessThan("field",  10), // Different operator
                    col.WhereEqualTo("field", 20), // Different value
                }
            );

            query = col.WhereEqualTo("first", "foo").WhereEqualTo("second", "bar");
            EqualityTester.AssertEqual(query,
                equal: new[] {
                    col.WhereEqualTo("first", "foo").WhereEqualTo("second", "bar")
                },
                unequal: new[] {
                    // Ordering of filters matters
                    col.WhereEqualTo("second", "bar").WhereEqualTo("first", "foo"),
                    // It's not just a replacement
                    col.WhereEqualTo("first", "foo")
                }
            );
        }

        [Fact]
        public void Equality_Select()
        {
            var col = s_db.Collection("col");
            // Each call to Select replaces previous ones
            var query = col.Select("a", "b");
            EqualityTester.AssertEqual(query,
                equal: new[] {
                    col.Select("a", "b"),
                    query.Select("a", "b"),
                    col.Select("x").Select("a", "b"),
                },
                unequal: new[] {
                    col.Select("b").Select("a"), // Order matters
                    query.Select("a"), // Projecting again adds another projection
                }
            );
        }

        [Fact]
        public void Equality_OrderBy()
        {
            var col = s_db.Collection("col");
            var query = col.OrderBy("foo").OrderByDescending("bar");
            EqualityTester.AssertEqual(query,
                equal: new[] {
                    col.OrderBy("foo").OrderByDescending("bar")
                },
                unequal: new[] {
                    query.OrderBy("foo"),
                    col.OrderBy("foo"),
                    col.OrderByDescending("foo").OrderByDescending("bar"),
                    col.OrderBy("bar").OrderByDescending("foo"),
                }
            );
        }

        [Fact]
        public void Equality_Start()
        {
            var col = s_db.Collection("col");
            var query = col.OrderBy("foo").StartAt(10);
            EqualityTester.AssertEqual(query,
                equal: new[] {
                        col.OrderBy("foo").StartAt(10L),
                },
                unequal: new[] {
                        col.OrderBy("foo"),
                        col.OrderBy("foo").StartAt(20),
                        col.OrderBy("foo").StartAfter(10)
                }
            );
        }

        [Fact]
        public void Equality_End()
        {
            var col = s_db.Collection("col");
            var query = col.OrderBy("foo").EndAt(10);
            EqualityTester.AssertEqual(query,
                equal: new[] {
                    col.OrderBy("foo").EndAt(10L)
                },
                unequal: new[] {
                    col.OrderBy("foo"),
                    col.OrderBy("foo").EndAt(20),
                    col.OrderBy("foo").EndBefore(10)
                }
            );
        }

        [Fact]
        public void Equality_Complex()
        {
            // It doesn't matter what order the query calls are made in, other than for ordering + start etc.
            var col = s_db.Collection("col");
            var query = col
                .OrderBy("foo")
                .StartAfter(20)
                .EndBefore(30)
                .Select("foo")
                .WhereGreaterThan("bar", 20)
                .Limit(20)
                .Offset(3);
            EqualityTester.AssertEqual(query,
                equal: new[] {
                    col.WhereGreaterThan("bar", 20)
                        .Select("foo")
                        .Offset(3)
                        .OrderBy("foo")
                        .EndBefore(30)
                        .Limit(20)
                        .StartAfter(20)
                },
                unequal: new[] {
                    // Just one change here - the EndBefore argument
                    col.WhereGreaterThan("bar", 20)
                        .Select("foo")
                        .Offset(3)
                        .OrderBy("foo")
                        .EndBefore(40)
                        .Limit(20)
                        .StartAfter(20)
                }
            );
        }

        [Fact]
        public void Equality_CollectionGroup()
        {
            EqualityTester.AssertEqual(s_db.CollectionGroup("col"),
                equal: new[] { s_db.CollectionGroup("col") },
                unequal: new[] { s_db.Collection("col") }
            );
        }

        [Fact]
        public void ArrayContainsIsEquality()
        {
            var collection = s_db.Collection("col");
            var document = new Document
            {
                CreateTime = CreateProtoTimestamp(0, 0),
                UpdateTime = CreateProtoTimestamp(0, 0),
                Name = collection.Document("doc").Path,
                Fields = { { "field", CreateArray(CreateValue(1), CreateValue(2)) } }
            };
            var snapshot = DocumentSnapshot.ForDocument(s_db, document, Timestamp.FromProto(document.CreateTime));
            // An inequality filter would create an implicit ordering here, but "array contains"
            // is effectively an equality filter, so we should end up with document ID ordering instead.
            var query = s_db.Collection("col").WhereArrayContains("field", 1).StartAt(snapshot);
            var structured = query.ToStructuredQuery();
            var documentIdOrder = new Order { Direction = Direction.Ascending, Field = FieldPath.DocumentId.ToFieldReference() };
            Assert.Equal(new[] { documentIdOrder }, structured.OrderBy);
        }

        // TODO: Proto-based conformance tests for these
        [Fact]
        public void Filter_SentinelsProhibited_InArray()
        {
            var collection = s_db.Collection("col");
            Assert.Throws<ArgumentException>(() => collection.WhereEqualTo("field", new[] { FieldValue.Delete }));
        }

        [Fact]
        public void Filter_SentinelsProhibited_InMap()
        {
            var collection = s_db.Collection("col");
            Assert.Throws<ArgumentException>(() => collection.WhereEqualTo("field", new { Nested = FieldValue.Delete }));
        }

        [Fact]
        public void Cursor_SentinelsProhibited_InArray()
        {
            var collection = s_db.Collection("col");
            Assert.Throws<ArgumentException>(() => collection.OrderBy("field").StartAt(new[] { new[] { FieldValue.Delete } }));
        }

        [Fact]
        public void Cursor_SentinelsProhibited_InMap()
        {
            var collection = s_db.Collection("col");
            Assert.Throws<ArgumentException>(() => collection.OrderBy("field").StartAt(new[] { new { Nested = FieldValue.Delete } }));
        }

        [Fact]
        public void CollectionGroup()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var query = db.CollectionGroup("col").WhereEqualTo("field", "value");
            var expected = new StructuredQuery
            {
                From = { new CollectionSelector { AllDescendants = true, CollectionId = "col" } },
                Where = Filter(new FieldFilter { Field = Field("field"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("value") }),
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        [Fact]
        public void CollectionGroup_CursorForPath()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var query = db.CollectionGroup("col").OrderBy(FieldPath.DocumentId).StartAfter("a/b");
            var expected = new StructuredQuery
            {
                From = { new CollectionSelector { AllDescendants = true, CollectionId = "col" } },
                OrderBy = { new Order { Field = Field("__name__"), Direction = Direction.Ascending } },
                StartAt = new Cursor { Values = { CreateValue(db.Document("a/b")) } }
            };
            Assert.Equal(expected, query.ToStructuredQuery());
        }

        private static FieldReference Field(string path) => new FieldReference { FieldPath = path };
        private static Filter Filter(UnaryFilter filter) => new Filter { UnaryFilter = filter };
        private static Filter Filter(FieldFilter filter) => new Filter { FieldFilter = filter };
        private static Filter CompositeFilter(params Filter[] filters) =>
            new Filter { CompositeFilter = new CompositeFilter { Op = StructuredQuery.Types.CompositeFilter.Types.Operator.And, Filters = { filters } } };
    }
}
