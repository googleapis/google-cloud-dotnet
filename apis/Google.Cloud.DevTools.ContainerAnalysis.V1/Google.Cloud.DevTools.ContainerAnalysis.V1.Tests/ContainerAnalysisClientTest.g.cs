// Copyright 2019 Google LLC
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

namespace Google.Cloud.DevTools.ContainerAnalysis.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.DevTools.ContainerAnalysis.V1;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grafeas.V1;
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
    public class GeneratedContainerAnalysisClientTest
    {
        [Fact]
        public void SetIamPolicy()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy policy = new Policy();
            Policy response = client.SetIamPolicy(resource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy policy = new Policy();
            Policy response = await client.SetIamPolicyAsync(resource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy2()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync2()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.SetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy response = client.GetIamPolicy(resource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy response = await client.GetIamPolicyAsync(resource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy2()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync2()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.GetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = client.TestIamPermissions(resource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(resource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions2()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = client.TestIamPermissions(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync2()
        {
            Mock<ContainerAnalysis.ContainerAnalysisClient> mockGrpcClient = new Mock<ContainerAnalysis.ContainerAnalysisClient>(MockBehavior.Strict);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisClient client = new ContainerAnalysisClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
