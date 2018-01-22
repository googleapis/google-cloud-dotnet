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
using Google.Cloud.Firestore.V1Beta1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using static Google.Cloud.Firestore.Tests.Proto.Test;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Tests.Proto
{
    // Language-neutral tests expressed in protobuf form.
    public class ProtoTest
    {
        private const string ProjectId = "projectID";
        private const string DatabaseId = "(default)";

        private static IEnumerable<Test> LoadTests()
        {
            Assembly asm = typeof(ProtoTest).GetTypeInfo().Assembly;
            using (Stream stream = asm.GetManifestResourceStream(typeof(ProtoTest).GetTypeInfo().Namespace + ".test-suite.binproto"))
            {
                var suite = TestSuite.Parser.ParseFrom(stream);
                return suite.Tests.ToList();
            }
        }

        private static readonly List<Test> s_allTests = LoadTests().ToList();
        private static IEnumerable<object[]> FindTests(TestOneofCase testCase) => s_allTests
            .Where(t => t.TestCase == testCase)
            .Select(t => new object[] { new SerializableTest(t) });

        // Note: we don't use Get as GetDocument is never used in this client.
        public static IEnumerable<object[]> CreateTests => FindTests(TestOneofCase.Create);
        public static IEnumerable<object[]> DeleteTests => FindTests(TestOneofCase.Delete);
        public static IEnumerable<object[]> SetTests => FindTests(TestOneofCase.Set);
        public static IEnumerable<object[]> UpdateTests => FindTests(TestOneofCase.Update);
        public static IEnumerable<object[]> UpdatePathsTests => FindTests(TestOneofCase.UpdatePaths);

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
        
        private static Firestore.FieldPath ConvertFieldPath(FieldPath testFieldPath) =>
            new Firestore.FieldPath(testFieldPath.Field.ToArray());

        private static DocumentReference GetDocumentReference(string resourceName) =>
            FirestoreDb.Create(ProjectId, DatabaseId, new FakeFirestoreClient()).GetDocumentReferenceFromResourceName(resourceName);

        private static void Check(bool expectedError, CommitRequest expectedRequest, Action<WriteBatch> action)
        {
            var mock = new MockCommitClient(expectedRequest);
            FirestoreDb db = FirestoreDb.Create(ProjectId, DatabaseId, mock);
            var batch = db.CreateWriteBatch();
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
            wkt::Value proto = wkt::Value.Parser.ParseJson(json);
            return ConvertValue(proto);
        }

        /// <summary>
        /// Converts a value from well-known type format to .NET CLR format (using dictionaries and lists).
        /// </summary>
        private static object ConvertValue(wkt::Value value)
        {
            switch (value.KindCase)
            {
                case wkt::Value.KindOneofCase.BoolValue:
                    return value.BoolValue;
                case wkt::Value.KindOneofCase.ListValue:
                    return value.ListValue.Values.Select(ConvertValue).ToArray();
                case wkt::Value.KindOneofCase.NullValue:
                    return null;
                case wkt::Value.KindOneofCase.NumberValue:
                    // Unfortunately we lose the "integer vs floating point" detail from the JSON.
                    // Let's assume that anything which rounds to itself is an integer.
                    var number = value.NumberValue;
                    return Math.Round(number) == number ? (object) (long) number : (object) number;
                case wkt::Value.KindOneofCase.StringValue:
                    return value.StringValue == "ServerTimestamp" ? (object) SentinelValue.ServerTimestamp
                        : value.StringValue == "Delete" ? (object) SentinelValue.Delete
                        : (object) value.StringValue;
                case wkt::Value.KindOneofCase.StructValue:
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
                    CommitTime = new wkt::Timestamp(),
                    WriteResults = { request.Writes.Select(_ => new V1Beta1.WriteResult()) }
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
