// Copyright 2020, Google Inc. All rights reserved.
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

using Grpc.Core;
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class ResourcePrefixHeaderTest
    {
        private const string ResourcePrefixHeader = "google-cloud-resource-prefix";
        private const string SampleDatabaseName = "projects/proj/instances/inst/databases/db";
        private const string SampleSessionName = "projects/proj/instances/inst/databases/db/sessions/sess";

        [Fact]
        public void NoHeaderOnCreateSessionIfEmptyDatabaseName()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.CreateSession(new CreateSessionRequest());
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnCreateSessionIfInvalidDatabaseName()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.CreateSession(new CreateSessionRequest { Database = "projects/proj/instances/databases" });
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnGetSessionIfEmptySessionName()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.GetSession(new GetSessionRequest());
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnGetSessionIfInvalidSessionName()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.GetSession(new GetSessionRequest { Name = "projects/proj/instances/inst/databases/sessions" });
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void SetsHeaderOnCreateSession()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.CreateSession(new CreateSessionRequest { Database = SampleDatabaseName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnBatchCreateSessions()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.BatchCreateSessions(new BatchCreateSessionsRequest { Database = SampleDatabaseName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnGetSession()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.GetSession(new GetSessionRequest { Name = SampleSessionName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnListSessions()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.ListSessions(new ListSessionsRequest { Database = SampleDatabaseName }).AsRawResponses().First();
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnDeleteSession()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.DeleteSession(new DeleteSessionRequest { Name = SampleSessionName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnExecuteSql()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.ExecuteSql(new ExecuteSqlRequest { Session = SampleSessionName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnExecuteBatchDml()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.ExecuteBatchDml(new ExecuteBatchDmlRequest { Session = SampleSessionName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnRead()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.Read(new ReadRequest { Session = SampleSessionName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnBeginTransaction()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.BeginTransaction(new BeginTransactionRequest { Session = SampleSessionName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnCommit()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.Commit(new CommitRequest { Session = SampleSessionName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnRollback()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.Rollback(new RollbackRequest { Session = SampleSessionName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnPartitionQuery()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.PartitionQuery(new PartitionQueryRequest { Session = SampleSessionName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnPartitionRead()
        {
            var invoker = new FakeCallInvoker();
            var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
            client.PartitionRead(new PartitionReadRequest { Session = SampleSessionName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        private class FakeCallInvoker : CallInvoker
        {
            public Metadata Metadata { get; private set; }

            public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
                throw new NotImplementedException();

            public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
                throw new NotImplementedException();

            public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
                throw new NotImplementedException();

            public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
                throw new NotImplementedException();

            public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
            {
                Metadata = options.Headers;
                return (TResponse) Activator.CreateInstance(typeof(TResponse));
            }
        }
    }
}
