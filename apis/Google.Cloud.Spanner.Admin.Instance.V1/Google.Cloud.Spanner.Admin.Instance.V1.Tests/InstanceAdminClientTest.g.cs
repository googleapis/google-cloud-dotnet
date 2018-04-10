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

namespace Google.Cloud.Spanner.Admin.Instance.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using apis = Google.Cloud.Spanner.Admin.Instance.V1;
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

    /// <summary>Generated unit tests</summary>
    public class GeneratedInstanceAdminClientTest
    {
        [Fact]
        public void GetInstanceConfig()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceConfigRequest expectedRequest = new GetInstanceConfigRequest
            {
                InstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            InstanceConfig expectedResponse = new InstanceConfig
            {
                InstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetInstanceConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceConfigName name = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]");
            InstanceConfig response = client.GetInstanceConfig(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetInstanceConfigAsync()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceConfigRequest expectedRequest = new GetInstanceConfigRequest
            {
                InstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            InstanceConfig expectedResponse = new InstanceConfig
            {
                InstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetInstanceConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<InstanceConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceConfigName name = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]");
            InstanceConfig response = await client.GetInstanceConfigAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetInstanceConfig2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            InstanceConfig expectedResponse = new InstanceConfig
            {
                InstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetInstanceConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceConfig response = client.GetInstanceConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetInstanceConfigAsync2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            InstanceConfig expectedResponse = new InstanceConfig
            {
                InstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetInstanceConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<InstanceConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceConfig response = await client.GetInstanceConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetInstance()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest expectedRequest = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                ConfigAsInstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "displayName1615086568",
                NodeCount = 1539922066,
            };
            mockGrpcClient.Setup(x => x.GetInstance(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            Instance response = client.GetInstance(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetInstanceAsync()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest expectedRequest = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                ConfigAsInstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "displayName1615086568",
                NodeCount = 1539922066,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Instance>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            Instance response = await client.GetInstanceAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetInstance2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                ConfigAsInstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "displayName1615086568",
                NodeCount = 1539922066,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetInstanceAsync2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                ConfigAsInstanceConfigName = new InstanceConfigName("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "displayName1615086568",
                NodeCount = 1539922066,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Instance>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance response = await client.GetInstanceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteInstance()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteInstanceRequest expectedRequest = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteInstance(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            client.DeleteInstance(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteInstanceAsync()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteInstanceRequest expectedRequest = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteInstanceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            await client.DeleteInstanceAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteInstance2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteInstance(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteInstance(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteInstanceAsync2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteInstanceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInstanceAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy policy = new Policy();
            Policy response = client.SetIamPolicy(formattedResource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy policy = new Policy();
            Policy response = await client.SetIamPolicyAsync(formattedResource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.SetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy response = client.GetIamPolicy(formattedResource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy response = await client.GetIamPolicyAsync(formattedResource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.GetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = client.TestIamPermissions(formattedResource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(formattedResource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = client.TestIamPermissions(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync2()
        {
            Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new Mock<InstanceAdmin.InstanceAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
