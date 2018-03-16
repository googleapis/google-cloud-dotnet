// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Iam.V1;
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Admin.Database.V1.Tests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedDatabaseAdminClientTest
    {
        [Fact]
        public void GetDatabase()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatabaseRequest expectedRequest = new GetDatabaseRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetDatabase(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName name = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            Database response = client.GetDatabase(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDatabaseAsync()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatabaseRequest expectedRequest = new GetDatabaseRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetDatabaseAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Database>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName name = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            Database response = await client.GetDatabaseAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetDatabase2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetDatabase(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            Database response = client.GetDatabase(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDatabaseAsync2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetDatabaseAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Database>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            Database response = await client.GetDatabaseAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DropDatabase()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DropDatabaseRequest expectedRequest = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DropDatabase(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            client.DropDatabase(database);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DropDatabaseAsync()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DropDatabaseRequest expectedRequest = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DropDatabaseAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            await client.DropDatabaseAsync(database);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DropDatabase2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DropDatabase(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            client.DropDatabase(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DropDatabaseAsync2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DropDatabaseAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            await client.DropDatabaseAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetDatabaseDdl()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest expectedRequest = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse();
            mockGrpcClient.Setup(x => x.GetDatabaseDdl(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            GetDatabaseDdlResponse response = client.GetDatabaseDdl(database);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDatabaseDdlAsync()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest expectedRequest = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse();
            mockGrpcClient.Setup(x => x.GetDatabaseDdlAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GetDatabaseDdlResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            GetDatabaseDdlResponse response = await client.GetDatabaseDdlAsync(database);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetDatabaseDdl2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse();
            mockGrpcClient.Setup(x => x.GetDatabaseDdl(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            GetDatabaseDdlResponse response = client.GetDatabaseDdl(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDatabaseDdlAsync2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse();
            mockGrpcClient.Setup(x => x.GetDatabaseDdlAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GetDatabaseDdlResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            GetDatabaseDdlResponse response = await client.GetDatabaseDdlAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            Policy policy = new Policy();
            Policy response = client.SetIamPolicy(formattedResource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            Policy policy = new Policy();
            Policy response = await client.SetIamPolicyAsync(formattedResource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.SetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            Policy response = client.GetIamPolicy(formattedResource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            Policy response = await client.GetIamPolicyAsync(formattedResource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.GetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = client.TestIamPermissions(formattedResource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(formattedResource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = client.TestIamPermissions(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync2()
        {
            Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new Mock<DatabaseAdmin.DatabaseAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
