// Copyright 2019, Google Inc. All rights reserved.
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
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.V1.Tests
{
    public class FirestoreClientImplTest
    {
        private const string SampleDatabase = "projects/proj/databases/database";
        private const string SampleDocuments = "projects/proj/databases/database/documents";
        private const string SampleDocument = "projects/proj/databases/database/documents/col1/doc";
        private static readonly ByteString s_sampleTransaction = ByteString.CopyFromUtf8("tx1");

        [Theory]
        [InlineData("projects/proj/databases/database", "projects/proj/databases/database")]
        [InlineData("projects/proj/databases/database/", "projects/proj/databases/database")]
        [InlineData("projects/proj/databases/database/documents", "projects/proj/databases/database")]
        [InlineData("projects/proj/databases/database/documents/col1/doc", "projects/proj/databases/database")]
        [InlineData("projects/proj_id/databases/(default)/foo", "projects/proj_id/databases/(default)")]
        public void GetDatabaseResourceName_Valid(string resourceName, string expectedDatabaseName)
        {
            Assert.Equal(expectedDatabaseName, FirestoreClientImpl.GetDatabaseResourceName(resourceName));
        }

        [Theory]
        [InlineData("")]
        [InlineData("projects//databases/(default)/foo")]
        [InlineData("not_projects/project/databases/(default)/foo")]
        [InlineData("projects/proj/not_databases/database")]
        [InlineData("projects/")]
        [InlineData("projects/proj/")]
        [InlineData("projects/proj/databases")]
        [InlineData("projects/proj/databases/")]
        [InlineData("projects/proj/databases//other")]
        public void GetDatabaseResourceName_Invalid(string resourceName)
        {
            Assert.Throws<ArgumentException>(() => FirestoreClientImpl.GetDatabaseResourceName(resourceName));
        }

        [Theory]
        [InlineData(true, "true")]
        [InlineData(false, "false")]
        public void ApplyTransactionHeader(bool isTransaction, string expectedHeaderValue)
        {
            CallSettings settings = null;
            FirestoreClientImpl.ApplyTransactionHeader(ref settings, isTransaction);
            var metadata = new Metadata();
            settings.HeaderMutation?.Invoke(metadata);
            var entry = Assert.Single(metadata, e => e.Key == FirestoreClientImpl.TransactionHeader);
            Assert.Equal(expectedHeaderValue, entry.Value);
        }

        [Theory]
        [MemberData(nameof(AlwaysTransactionalTestData))]
        public void TransactionHeader_AlwaysTransactionalRpcs(Action<FirestoreClientImpl> rpcAction)
        {
            var invoker = new HeaderCapturingCallInvoker();
            var client = new FirestoreClientImpl(new Firestore.FirestoreClient(invoker), null, null);

            rpcAction(client);

            invoker.AssertTransactionHeader("true");
        }

        public static TheoryData<Action<FirestoreClientImpl>> AlwaysTransactionalTestData =>
            new TheoryData<Action<FirestoreClientImpl>>
            {
                client => client.BeginTransaction(new BeginTransactionRequest { Database = SampleDatabase }),
                client => client.Rollback(new RollbackRequest { Database = SampleDatabase, Transaction = s_sampleTransaction }),
            };

        [Theory]
        [MemberData(nameof(ConditionallyTransactionalTestData))]
        public void TransactionHeader_ConditionallyTransactionalRpcs(Action<FirestoreClientImpl> rpcAction, string expectedHeader)
        {
            var invoker = new HeaderCapturingCallInvoker();
            var client = new FirestoreClientImpl(new Firestore.FirestoreClient(invoker), null, null);

            rpcAction(client);

            invoker.AssertTransactionHeader(expectedHeader);
        }

        public static TheoryData<Action<FirestoreClientImpl>, string> ConditionallyTransactionalTestData =>
            new TheoryData<Action<FirestoreClientImpl>, string>
            {
                // Commit
                { client => client.Commit(new CommitRequest { Database = SampleDatabase }), "false" },
                { client => client.Commit(new CommitRequest { Database = SampleDatabase, Transaction = s_sampleTransaction }), "true" },

                // BatchGetDocuments
                { client => client.BatchGetDocuments(new BatchGetDocumentsRequest { Database = SampleDatabase }), "false" },
                { client => client.BatchGetDocuments(new BatchGetDocumentsRequest { Database = SampleDatabase, Transaction = s_sampleTransaction }), "true" },
                { client => client.BatchGetDocuments(new BatchGetDocumentsRequest { Database = SampleDatabase, NewTransaction = new TransactionOptions() }), "true" },

                // RunQuery
                { client => client.RunQuery(new RunQueryRequest { Parent = SampleDocuments }), "false" },
                { client => client.RunQuery(new RunQueryRequest { Parent = SampleDocuments, Transaction = s_sampleTransaction }), "true" },
                { client => client.RunQuery(new RunQueryRequest { Parent = SampleDocuments, NewTransaction = new TransactionOptions() }), "true" },

                // RunAggregationQuery
                { client => client.RunAggregationQuery(new RunAggregationQueryRequest { Parent = SampleDocuments }), "false" },
                { client => client.RunAggregationQuery(new RunAggregationQueryRequest { Parent = SampleDocuments, Transaction = s_sampleTransaction }), "true" },
                { client => client.RunAggregationQuery(new RunAggregationQueryRequest { Parent = SampleDocuments, NewTransaction = new TransactionOptions() }), "true" },

                // ExecutePipeline
                { client => client.ExecutePipeline(new ExecutePipelineRequest { Database = SampleDatabase }), "false" },
                { client => client.ExecutePipeline(new ExecutePipelineRequest { Database = SampleDatabase, Transaction = s_sampleTransaction }), "true" },
                { client => client.ExecutePipeline(new ExecutePipelineRequest { Database = SampleDatabase, NewTransaction = new TransactionOptions() }), "true" },

                // GetDocument
                { client => client.GetDocument(new GetDocumentRequest { Name = SampleDocument }), "false" },
                { client => client.GetDocument(new GetDocumentRequest { Name = SampleDocument, Transaction = s_sampleTransaction }), "true" },

                // ListDocuments
                { client => client.ListDocuments(new ListDocumentsRequest { Parent = SampleDocuments, CollectionId = "col1" }).ReadPage(10), "false" },
                { client => client.ListDocuments(new ListDocumentsRequest { Parent = SampleDocuments, CollectionId = "col1", Transaction = s_sampleTransaction }).ReadPage(10), "true" },
            };

        [Theory]
        [MemberData(nameof(NonTransactionalTestData))]
        public void TransactionHeader_NonTransactionalRpcs(Action<FirestoreClientImpl> rpcAction)
        {
            var invoker = new HeaderCapturingCallInvoker();
            var client = new FirestoreClientImpl(new Firestore.FirestoreClient(invoker), null, null);

            rpcAction(client);

            invoker.AssertTransactionHeader("false");
        }

        public static TheoryData<Action<FirestoreClientImpl>> NonTransactionalTestData =>
            new TheoryData<Action<FirestoreClientImpl>>
            {
                client => client.CreateDocument(new CreateDocumentRequest { Parent = SampleDocuments, CollectionId = "col1" }),
                client => client.UpdateDocument(new UpdateDocumentRequest { Document = new Document { Name = SampleDocument } }),
                client => client.DeleteDocument(new DeleteDocumentRequest { Name = SampleDocument }),
                client => client.ListCollectionIds(new ListCollectionIdsRequest { Parent = SampleDocuments }).ReadPage(10),
                client => client.PartitionQuery(new PartitionQueryRequest { Parent = SampleDocuments }).ReadPage(10),
                client => client.BatchWrite(new BatchWriteRequest { Database = SampleDatabase }),
                client => client.Write(),
                client => client.Listen(),
            };

        private class HeaderCapturingCallInvoker : CallInvoker
        {
            public Metadata LastHeaders { get; private set; }

            public void AssertTransactionHeader(string expectedValue)
            {
                Assert.NotNull(LastHeaders);
                var entry = Assert.Single(LastHeaders, e => e.Key == FirestoreClientImpl.TransactionHeader);
                Assert.Equal(expectedValue, entry.Value);
                LastHeaders = null;
            }

            public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options)
            {
                LastHeaders = options.Headers;
                return new AsyncClientStreamingCall<TRequest, TResponse>(new FakeClientStreamWriter<TRequest>(), null, null, null, null, () => { });
            }

            public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options)
            {
                LastHeaders = options.Headers;
                return new AsyncDuplexStreamingCall<TRequest, TResponse>(new FakeClientStreamWriter<TRequest>(), null, null, null, null, () => { });
            }

            public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
            {
                LastHeaders = options.Headers;
                return new AsyncServerStreamingCall<TResponse>(null, null, null, null, () => { });
            }

            public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
            {
                LastHeaders = options.Headers;
                return new AsyncUnaryCall<TResponse>(Task.FromResult(Activator.CreateInstance<TResponse>()), null, null, null, () => { });
            }

            public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
            {
                LastHeaders = options.Headers;
                return Activator.CreateInstance<TResponse>();
            }

            private class FakeClientStreamWriter<T> : IClientStreamWriter<T>
            {
                public WriteOptions WriteOptions { get; set; }
                public Task CompleteAsync() => Task.CompletedTask;
                public Task WriteAsync(T message) => Task.CompletedTask;
            }
        }
    }
}
