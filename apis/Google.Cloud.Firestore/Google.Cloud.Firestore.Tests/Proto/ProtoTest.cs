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
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using static Google.Cloud.Firestore.Tests.Proto.Test;
using WKT = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Tests.Proto
{
    // Language-neutral tests expressed in protobuf form.
    public class ProtoTest
    {
        private const string ProjectId = "projectID";
        private const string DatabaseId = "(default)";

        private static readonly List<Test> s_allTests = ConformanceTestData.Load<TestFile>("firestore", "v1").MergedTests.Tests.ToList();
        private static IEnumerable<object[]> FindTests(TestOneofCase testCase) => s_allTests
            .Where(t => t.TestCase == testCase)
            .Select(t => new object[] { new SerializableTest(t) });

        public static IEnumerable<object[]> CreateTests => FindTests(TestOneofCase.Create);
        public static IEnumerable<object[]> DeleteTests => FindTests(TestOneofCase.Delete);
        public static IEnumerable<object[]> QueryTests => FindTests(TestOneofCase.Query);
        public static IEnumerable<object[]> SetTests => FindTests(TestOneofCase.Set);
        public static IEnumerable<object[]> UpdateTests => FindTests(TestOneofCase.Update);
        public static IEnumerable<object[]> UpdatePathsTests => FindTests(TestOneofCase.UpdatePaths);
        public static IEnumerable<object[]> ListenTests => FindTests(TestOneofCase.Listen);

        private static readonly IDictionary<string, Func<Query, Firestore.FieldPath, object, Query>> QueryOperators =
            new Dictionary<string, Func<Query, Firestore.FieldPath, object, Query>>
            {
                { "==", (query, path, value) => query.WhereEqualTo(path, value) },
                { "<", (query, path, value) => query.WhereLessThan(path, value) },
                { "<=", (query, path, value) => query.WhereLessThanOrEqualTo(path, value) },
                { ">", (query, path, value) => query.WhereGreaterThan(path, value) },
                { ">=", (query, path, value) => query.WhereGreaterThanOrEqualTo(path, value) },
            };

        [Fact]
        public void AllTestsKnown()
        {
            var testTypes = s_allTests.Select(t => t.TestCase)
                .Except(new[]
                {
                    // All the test types used above
                    TestOneofCase.Create,
                    TestOneofCase.Delete,
                    TestOneofCase.Set,
                    TestOneofCase.Query,
                    TestOneofCase.Update,
                    TestOneofCase.UpdatePaths,
                    TestOneofCase.Listen,
                    // We don't test Get as GetDocument is never used in this client.
                    TestOneofCase.Get
                });
            Assert.Empty(testTypes);
        }

        [Theory]
        [MemberData(nameof(CreateTests))]
        public void Create(SerializableTest wrapper)
        {
            CreateTest test = wrapper.Test.Create;
            Check(test.IsError, test.Request, batch =>
            {
                DocumentReference doc = GetDocumentReference(test.DocRefPath);
                object documentData = DeserializeJson(test.JsonData);
                batch.Create(doc, documentData);
            });
        }

        [Theory]
        [MemberData(nameof(DeleteTests))]
        public void Delete(SerializableTest wrapper)
        {
            DeleteTest test = wrapper.Test.Delete;
            Check(test.IsError, test.Request, batch =>
            {
                DocumentReference doc = GetDocumentReference(test.DocRefPath);
                var precondition = Precondition.FromProto(test.Precondition);
                batch.Delete(doc, precondition);
            });
        }

        [Theory]
        [MemberData(nameof(QueryTests))]
        public void Query(SerializableTest wrapper)
        {
            QueryTest test = wrapper.Test.Query;
            if (test.IsError)
            {
                var exception = Assert.ThrowsAny<Exception>(() => BuildQuery());
                Assert.True(exception is ArgumentException || exception is InvalidOperationException, $"Exception type: {exception.GetType()}");
            }
            else
            {
                var query = BuildQuery();
                Assert.Equal(test.Query, query.ToStructuredQuery());
            }

            Query BuildQuery()
            {
                Query query = GetCollectionReference(test.CollPath);
                foreach (var clause in test.Clauses)
                {
                    switch (clause.ClauseCase)
                    {
                        case Clause.ClauseOneofCase.EndAt:
                            query = query.EndAt(ConvertCursor(clause.EndAt));
                            break;
                        case Clause.ClauseOneofCase.EndBefore:
                            query = query.EndBefore(ConvertCursor(clause.EndBefore));
                            break;
                        case Clause.ClauseOneofCase.Limit:
                            query = query.Limit(clause.Limit);
                            break;
                        case Clause.ClauseOneofCase.Offset:
                            query = query.Offset(clause.Offset);
                            break;
                        case Clause.ClauseOneofCase.OrderBy:
                            var ordering = clause.OrderBy;
                            var path = ConvertFieldPath(ordering.Path);
                            query = ordering.Direction == "asc" ? query.OrderBy(path) : query.OrderByDescending(path);
                            break;
                        case Clause.ClauseOneofCase.Select:
                            query = query.Select(clause.Select.Fields.Select(ConvertFieldPath).ToArray());
                            break;
                        case Clause.ClauseOneofCase.StartAfter:
                            query = query.StartAfter(ConvertCursor(clause.StartAfter));
                            break;
                        case Clause.ClauseOneofCase.StartAt:
                            query = query.StartAt(ConvertCursor(clause.StartAt));
                            break;
                        case Clause.ClauseOneofCase.Where:
                            var filterPath = ConvertFieldPath(clause.Where.Path) ;
                            if (!QueryOperators.TryGetValue(clause.Where.Op, out var filterProvider))
                            {
                                throw new ArgumentException($"Invalid where operator: {clause.Where.Op}");
                            }
                            var value = DeserializeJson(clause.Where.JsonValue);
                            query = filterProvider(query, filterPath, value);
                            break;
                        default:
                            throw new InvalidOperationException($"Unexpected clause case: {clause.ClauseCase}");
                    }
                }
                return query;
            }

            // Note: dynamic to allow a DocumentSnapshot to be returned and used in overload resolution.
            dynamic ConvertCursor(Cursor cursor)
            {
                var docSnapshot = cursor.DocSnapshot;
                if (docSnapshot == null)
                {
                    return cursor.JsonValues.Select(DeserializeJson).ToArray();
                }
                var docRef = GetDocumentReference(docSnapshot.Path);
                return DocumentSnapshot.ForDocument(
                    docRef.Database,
                    new Document
                    {
                        Name = docRef.Path,
                        Fields = { ValueSerializer.SerializeMap(SerializationContext.Default, DeserializeJson(cursor.DocSnapshot.JsonData)) },
                        CreateTime = WKT::Timestamp.FromDateTimeOffset(DateTimeOffset.MinValue),
                        UpdateTime = WKT::Timestamp.FromDateTimeOffset(DateTimeOffset.MinValue),
                    },
                    Timestamp.FromDateTimeOffset(DateTimeOffset.MinValue));
            }
        }

        [Theory]
        [MemberData(nameof(SetTests))]
        public void Set(SerializableTest wrapper)
        {
            SetTest test = wrapper.Test.Set;
            Check(test.IsError, test.Request, batch =>
            {
                DocumentReference doc = GetDocumentReference(test.DocRefPath);
                object documentData = DeserializeJson(test.JsonData);
                var setOptions = test.Option == null ? null :
                    test.Option.All ? SetOptions.MergeAll :
                    SetOptions.MergeFields(test.Option.Fields.Select(ConvertFieldPath).ToArray());
                batch.Set(doc, documentData, setOptions);
            });
        }

        [Theory]
        [MemberData(nameof(UpdateTests))]
        public void Update(SerializableTest wrapper)
        {
            UpdateTest test = wrapper.Test.Update;
            Check(test.IsError, test.Request, batch =>
            {
                DocumentReference doc = GetDocumentReference(test.DocRefPath);
                var documentData = (Dictionary<string, object>) DeserializeJson(test.JsonData);
                var precondition = Precondition.FromProto(test.Precondition);
                var updates = documentData.ToDictionary(pair => Firestore.FieldPath.FromDotSeparatedString(pair.Key), pair => pair.Value);
                batch.Update(doc, updates, precondition);
            });
        }

        [Theory]
        [MemberData(nameof(UpdatePathsTests))]
        public void UpdatePaths(SerializableTest wrapper)
        {
            UpdatePathsTest test = wrapper.Test.UpdatePaths;
            Check(test.IsError, test.Request, batch =>
            {
                DocumentReference doc = GetDocumentReference(test.DocRefPath);
                Dictionary<Firestore.FieldPath, object> updates = test.FieldPaths
                    .Zip(test.JsonValues, (path, value) => (path, value))
                    .ToDictionary(tuple => ConvertFieldPath(tuple.path), tuple => (object) DeserializeJson(tuple.value));
                var precondition = Precondition.FromProto(test.Precondition);
                batch.Update(doc, updates, precondition);
            });
        }

        [Theory]
        [MemberData(nameof(ListenTests))]
        public async Task Listen(SerializableTest wrapper)
        {
            ListenTest test = wrapper.Test.Listen;
            var db = FirestoreDb.Create(ProjectId, DatabaseId, new FakeFirestoreClient());
            var query = db.Collection("C").OrderBy("a");

            Func<Task> action = async () =>
            {
                List<QuerySnapshot> snapshots = new List<QuerySnapshot>();
                var watchState = new WatchState(query, (snapshot, token) => { snapshots.Add(snapshot); return Task.FromResult(1); });
                watchState.OnStreamInitialization(StreamInitializationCause.WatchStarting);
                foreach (var response in test.Responses)
                {
                    // Fix up the test response to use our watch target ID.
                    ReplaceWatchTargetId(response.TargetChange?.TargetIds);
                    ReplaceWatchTargetId(response.DocumentChange?.TargetIds);
                    ReplaceWatchTargetId(response.DocumentChange?.RemovedTargetIds);
                    ReplaceWatchTargetId(response.DocumentDelete?.RemovedTargetIds);
                    ReplaceWatchTargetId(response.DocumentRemove?.RemovedTargetIds);

                    var result = await watchState.HandleResponseAsync(response, default);
                    if (result == WatchResponseResult.ResetStream)
                    {
                        watchState.OnStreamInitialization(StreamInitializationCause.ResetRequested);
                    }
                }
                var expectedSnapshots = test.Snapshots.Select(snapshot => ConvertSnapshot(snapshot)).ToList();
                Assert.Equal(expectedSnapshots, snapshots);
            };

            if (test.IsError)
            {
                // TODO: Should we actually check that it's only the last response that causes the exception?
                var exception = await Assert.ThrowsAnyAsync<Exception>(action);
                Assert.True(exception is ArgumentException || exception is InvalidOperationException,
                    $"Exception type: {exception.GetType()}");
            }
            else
            {
                await action();
            }

            // Different clients use different watch target IDs. The test data always uses 1
            // to mean "the target ID that the client uses".
            void ReplaceWatchTargetId(RepeatedField<int> ids)
            {
                if (ids == null)
                {
                    return;
                }
                for (int i = 0; i < ids.Count; i++)
                {
                    if (ids[i] == 1)
                    {
                        ids[i] = WatchStream.WatchTargetId;
                    }
                }
            }

            // Converts from a test proto snapshot to a QuerySnapshot
            QuerySnapshot ConvertSnapshot(Snapshot snapshot)
            {
                var readTime = Timestamp.FromProto(snapshot.ReadTime);
                var changes = snapshot.Changes.Select(change => ConvertChange(change, readTime)).ToList();
                var docs = snapshot.Docs.Select(doc => DocumentSnapshot.ForDocument(db, doc, readTime)).ToList();
                return QuerySnapshot.ForChanges(query, docs, changes, readTime);
            }

            DocumentChange ConvertChange(DocChange change, Timestamp readTime)
            {
                var snapshot = DocumentSnapshot.ForDocument(db, change.Doc, readTime);
                return new DocumentChange(snapshot, (DocumentChange.Type) change.Kind,
                    change.OldIndex == -1 ? default(int?) : change.OldIndex, change.NewIndex == - 1 ? default(int?) : change.NewIndex);
            }
        }

        private static Firestore.FieldPath ConvertFieldPath(FieldPath testFieldPath) =>
            new Firestore.FieldPath(testFieldPath.Field.ToArray());

        private static DocumentReference GetDocumentReference(string resourceName) =>
            FirestoreDb.Create(ProjectId, DatabaseId, new FakeFirestoreClient()).GetDocumentReferenceFromResourceName(resourceName);

        private static CollectionReference GetCollectionReference(string resourceName)
        {
            var db = FirestoreDb.Create(ProjectId, DatabaseId, new FakeFirestoreClient());
            Assert.StartsWith(db.DocumentsPath, resourceName);
            Assert.Equal('/', resourceName[db.DocumentsPath.Length]);
            string collectionPath = resourceName.Substring(db.DocumentsPath.Length + 1);
            return db.Collection(collectionPath);
        }

        private static void Check(bool expectedError, CommitRequest expectedRequest, Action<WriteBatch> action)
        {
            var mock = new MockCommitClient(expectedRequest);
            FirestoreDb db = FirestoreDb.Create(ProjectId, DatabaseId, mock);
            var batch = db.StartBatch();
            if (expectedError)
            {
                var exception = Assert.ThrowsAny<Exception>(() => action(batch));
                Assert.True(exception is ArgumentException || exception is InvalidOperationException, $"Exception type: {exception.GetType()}");
            }
            else
            {
                action(batch);
                batch.CommitAsync().Wait();
            }
            mock.Verify();
        }

        // Helper so that in failures, we get the description of the test rather than the whole proto.
        // In theory, this should allow all tests to be shown in VS too, but that doesn't appear to work right now.
        public class SerializableTest : IXunitSerializable
        {
            public Test Test { get; private set; }

            // Used in deserialization
            public SerializableTest() { }

            public SerializableTest(Test test) => Test = test;

            public void Deserialize(IXunitSerializationInfo info) =>
                Test = Test.Parser.ParseFrom(info.GetValue<byte[]>(nameof(Test)));

            public void Serialize(IXunitSerializationInfo info) =>
                info.AddValue(nameof(Test), Test.ToByteArray());

            public override string ToString() => Test?.Description ?? "(Unknown)";
        }

        private static object DeserializeJson(string json)
        {
            WKT::Value proto = WKT::Value.Parser.ParseJson(json);
            return ConvertValue(proto);
        }

        /// <summary>
        /// Converts a value from well-known type format to .NET CLR format (using dictionaries and lists).
        /// </summary>
        private static object ConvertValue(WKT::Value value)
        {
            switch (value.KindCase)
            {
                case WKT::Value.KindOneofCase.BoolValue:
                    return value.BoolValue;
                case WKT::Value.KindOneofCase.ListValue:
                    var values = value.ListValue.Values;
                    var first = values.FirstOrDefault();
                    if (first?.StringValue == "ArrayRemove")
                    {
                        return FieldValue.ArrayRemove(values.Skip(1).Select(ConvertValue).ToArray());
                    }
                    else if (first?.StringValue == "ArrayUnion")
                    {
                        return FieldValue.ArrayUnion(values.Skip(1).Select(ConvertValue).ToArray());
                    }
                    else
                    {
                        return values.Select(ConvertValue).ToArray();
                    }
                case WKT::Value.KindOneofCase.NullValue:
                    return null;
                case WKT::Value.KindOneofCase.NumberValue:
                    // Unfortunately we lose the "integer vs floating point" detail from the JSON.
                    // Let's assume that anything which rounds to itself is an integer.
                    var number = value.NumberValue;
                    return Math.Round(number) == number ? (object) (long) number : (object) number;
                case WKT::Value.KindOneofCase.StringValue:
                    return value.StringValue == "ServerTimestamp" ? FieldValue.ServerTimestamp
                        : value.StringValue == "Delete" ? FieldValue.Delete
                        : value.StringValue == "NaN" ? (object) double.NaN
                        : value.StringValue;
                case WKT::Value.KindOneofCase.StructValue:
                    return value.StructValue.Fields.ToDictionary(pair => pair.Key, pair => ConvertValue(pair.Value));
                default:
                    throw new ArgumentException($"Unknown value kind: {value.KindCase}");
            }
        }

        // Rather than using Moq to expect a commit, we just have a small recording client. This makes
        // it easier to get good diagnostics about what went wrong.
        private class MockCommitClient : FirestoreClient
        {
            private readonly CommitRequest _expectedRequest;
            private CommitRequest _actualRequest;

            public MockCommitClient(CommitRequest expectedRequest) => _expectedRequest = CanonicalizeRequest(expectedRequest);

            public override Task<CommitResponse> CommitAsync(CommitRequest request, CallSettings callSettings = null)
            {
                _actualRequest = CanonicalizeRequest(request);
                var response = new CommitResponse
                {
                    CommitTime = new WKT::Timestamp(),
                    WriteResults = { request.Writes.Select(_ => new V1.WriteResult()) }
                };
                return Task.FromResult(response);
            }

            public void Verify()
            {
                Assert.Equal(_expectedRequest, _actualRequest);
            }

            private static CommitRequest CanonicalizeRequest(CommitRequest input) =>
                input == null ? null : new CommitRequest
                {
                    Database = input.Database,
                    Transaction = input.Transaction,
                    Writes = { input.Writes.Select(WriteBatchTest.CanonicalizeWrite) }
                };
        }
    }
}
