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

namespace Google.Cloud.Spanner.Admin.Database.V1.Tests
{
    public class ResourcePrefixHeaderTest
    {
        private const string ResourcePrefixHeader = "google-cloud-resource-prefix";
        private const string SampleInstanceName = "projects/proj/instances/inst";
        private const string SampleDatabaseName = "projects/proj/instances/inst/databases/db";
        private const string SampleBackupName = "projects/proj/instances/inst/backups/backup";

        [Fact]
        public void NoHeaderOnCreateDatabaseIfEmptyInstanceName()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.CreateDatabase(new CreateDatabaseRequest());
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnCreateDatabaseIfInvalidInstanceName()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.CreateDatabase(new CreateDatabaseRequest { Parent = "projects/instances" });
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnGetDatabaseIfEmptyDatabaseName()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetDatabase(new GetDatabaseRequest());
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnGetDatabaseIfInvalidDatabaseName()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetDatabase(new GetDatabaseRequest { Name = "projects/proj/instances/inst/databases" });
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnGetBackupIfEmptyBackupName()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetBackup(new GetBackupRequest());
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnGetBackupIfInvalidBackupName()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetBackup(new GetBackupRequest { Name = "projects/proj/instances/inst/backups" });
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void SetsHeaderOnListDatabases()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.ListDatabases(new ListDatabasesRequest { Parent = SampleInstanceName }).AsRawResponses().First();
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnCreateDatabase()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.CreateDatabase(new CreateDatabaseRequest { Parent = SampleInstanceName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnGetDatabase()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetDatabase(new GetDatabaseRequest { Name = SampleDatabaseName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnUpdateDatabaseDdl()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.UpdateDatabaseDdl(new UpdateDatabaseDdlRequest { Database = SampleDatabaseName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnDropDatabase()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.DropDatabase(new DropDatabaseRequest { Database = SampleDatabaseName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnGetDatabaseDdl()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetDatabaseDdl(new GetDatabaseDdlRequest { Database = SampleDatabaseName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleDatabaseName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnCreateBackup()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.CreateBackup(new CreateBackupRequest { Parent = SampleInstanceName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnGetBackup()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetBackup(new GetBackupRequest { Name = SampleBackupName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnUpdateBackup()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.UpdateBackup(new UpdateBackupRequest
            {
                Backup = new Backup { Name = SampleBackupName }
            });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnDeleteBackup()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.DeleteBackup(new DeleteBackupRequest { Name = SampleBackupName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnListBackups()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.ListBackups(new ListBackupsRequest { Parent = SampleInstanceName }).AsRawResponses().First();
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnRestoreDatabase()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.RestoreDatabase(new RestoreDatabaseRequest { Parent = SampleInstanceName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnListDatabaseOperations()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.ListDatabaseOperations(new ListDatabaseOperationsRequest { Parent = SampleInstanceName }).AsRawResponses().First();
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnListBackupOperations()
        {
            var invoker = new FakeCallInvoker();
            var client = new DatabaseAdminClientBuilder { CallInvoker = invoker }.Build();
            client.ListBackupOperations(new ListBackupOperationsRequest { Parent = SampleInstanceName }).AsRawResponses().First();
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
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
