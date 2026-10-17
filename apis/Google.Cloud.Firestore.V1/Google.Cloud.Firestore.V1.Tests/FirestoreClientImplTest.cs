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

        [Fact]
        public void TransactionHeader_AlwaysTransactionalRpcs()
        {
            var invoker = new HeaderCapturingCallInvoker();
            var client = new FirestoreClientImpl(new Firestore.FirestoreClient(invoker), null, null);

            client.BeginTransaction(new BeginTransactionRequest { Database = SampleDatabase });
            invoker.AssertTransactionHeader("true");

            client.Rollback(new RollbackRequest { Database = SampleDatabase, Transaction = s_sampleTransaction });
            invoker.AssertTransactionHeader("true");
        }

        [Fact]
        public void TransactionHeader_ConditionallyTransactionalRpcs()
        {
            var invoker = new HeaderCapturingCallInvoker();
            var client = new FirestoreClientImpl(new Firestore.FirestoreClient(invoker), null, null);

            // Commit
            client.Commit(new CommitRequest { Database = SampleDatabase });
            invoker.AssertTransactionHeader("false");
            client.Commit(new CommitRequest { Database = SampleDatabase, Transaction = s_sampleTransaction });
            invoker.AssertTransactionHeader("true");

            // BatchGetDocuments
            client.BatchGetDocuments(new BatchGetDocumentsRequest { Database = SampleDatabase });
            invoker.AssertTransactionHeader("false");
            client.BatchGetDocuments(new BatchGetDocumentsRequest { Database = SampleDatabase, Transaction = s_sampleTransaction });
            invoker.AssertTransactionHeader("true");
            client.BatchGetDocuments(new BatchGetDocumentsRequest { Database = SampleDatabase, NewTransaction = new TransactionOptions() });
            invoker.AssertTransactionHeader("true");

            // RunQuery
            client.RunQuery(new RunQueryRequest { Parent = SampleDocuments });
            invoker.AssertTransactionHeader("false");
            client.RunQuery(new RunQueryRequest { Parent = SampleDocuments, Transaction = s_sampleTransaction });
            invoker.AssertTransactionHeader("true");
            client.RunQuery(new RunQueryRequest { Parent = SampleDocuments, NewTransaction = new TransactionOptions() });
            invoker.AssertTransactionHeader("true");

            // RunAggregationQuery
            client.RunAggregationQuery(new RunAggregationQueryRequest { Parent = SampleDocuments });
            invoker.AssertTransactionHeader("false");
            client.RunAggregationQuery(new RunAggregationQueryRequest { Parent = SampleDocuments, Transaction = s_sampleTransaction });
            invoker.AssertTransactionHeader("true");
            client.RunAggregationQuery(new RunAggregationQueryRequest { Parent = SampleDocuments, NewTransaction = new TransactionOptions() });
            invoker.AssertTransactionHeader("true");

            // ExecutePipeline
            client.ExecutePipeline(new ExecutePipelineRequest { Database = SampleDatabase });
            invoker.AssertTransactionHeader("false");
            client.ExecutePipeline(new ExecutePipelineRequest { Database = SampleDatabase, Transaction = s_sampleTransaction });
            invoker.AssertTransactionHeader("true");
            client.ExecutePipeline(new ExecutePipelineRequest { Database = SampleDatabase, NewTransaction = new TransactionOptions() });
            invoker.AssertTransactionHeader("true");

            // GetDocument
            client.GetDocument(new GetDocumentRequest { Name = SampleDocument });
            invoker.AssertTransactionHeader("false");
            client.GetDocument(new GetDocumentRequest { Name = SampleDocument, Transaction = s_sampleTransaction });
            invoker.AssertTransactionHeader("true");

            // ListDocuments
            client.ListDocuments(new ListDocumentsRequest { Parent = SampleDocuments, CollectionId = "col1" }).ReadPage(10);
            invoker.AssertTransactionHeader("false");
            client.ListDocuments(new ListDocumentsRequest { Parent = SampleDocuments, CollectionId = "col1", Transaction = s_sampleTransaction }).ReadPage(10);
            invoker.AssertTransactionHeader("true");
        }

        [Fact]
        public void TransactionHeader_NonTransactionalRpcs()
        {
            var invoker = new HeaderCapturingCallInvoker();
            var client = new FirestoreClientImpl(new Firestore.FirestoreClient(invoker), null, null);

            client.CreateDocument(new CreateDocumentRequest { Parent = SampleDocuments, CollectionId = "col1" });
            invoker.AssertTransactionHeader("false");

            client.UpdateDocument(new UpdateDocumentRequest { Document = new Document { Name = SampleDocument } });
            invoker.AssertTransactionHeader("false");

            client.DeleteDocument(new DeleteDocumentRequest { Name = SampleDocument });
            invoker.AssertTransactionHeader("false");

            client.ListCollectionIds(new ListCollectionIdsRequest { Parent = SampleDocuments }).ReadPage(10);
            invoker.AssertTransactionHeader("false");

            client.PartitionQuery(new PartitionQueryRequest { Parent = SampleDocuments }).ReadPage(10);
            invoker.AssertTransactionHeader("false");

            client.BatchWrite(new BatchWriteRequest { Database = SampleDatabase });
            invoker.AssertTransactionHeader("false");

            client.Write();
            invoker.AssertTransactionHeader("false");

            client.Listen();
            invoker.AssertTransactionHeader("false");
        }

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
                return new AsyncClientStreamingCall<TRequest, TResponse>(null, null, null, null, null, () => { });
            }

            public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options)
            {
                LastHeaders = options.Headers;
                return new AsyncDuplexStreamingCall<TRequest, TResponse>(null, null, null, null, null, () => { });
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
        }
    }
}
