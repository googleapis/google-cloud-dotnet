// Copyright 2020 Google LLC
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

namespace Google.Cloud.Dataproc.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dataproc.V1;
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
    public class GeneratedAutoscalingPolicyServiceClientTest
    {
        [Fact]
        public void CreateAutoscalingPolicy()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            CreateAutoscalingPolicyRequest expectedRequest = new CreateAutoscalingPolicyRequest
            {
                Parent = new RegionName("[PROJECT]", "[REGION]").ToString(),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new RegionName("[PROJECT]", "[REGION]").ToString();
            AutoscalingPolicy policy = new AutoscalingPolicy();
            AutoscalingPolicy response = client.CreateAutoscalingPolicy(formattedParent, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateAutoscalingPolicyAsync()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            CreateAutoscalingPolicyRequest expectedRequest = new CreateAutoscalingPolicyRequest
            {
                Parent = new RegionName("[PROJECT]", "[REGION]").ToString(),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AutoscalingPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new RegionName("[PROJECT]", "[REGION]").ToString();
            AutoscalingPolicy policy = new AutoscalingPolicy();
            AutoscalingPolicy response = await client.CreateAutoscalingPolicyAsync(formattedParent, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateAutoscalingPolicy2()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                Parent = new RegionName("[PROJECT]", "[REGION]").ToString(),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AutoscalingPolicy response = client.CreateAutoscalingPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateAutoscalingPolicyAsync2()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                Parent = new RegionName("[PROJECT]", "[REGION]").ToString(),
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateAutoscalingPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AutoscalingPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AutoscalingPolicy response = await client.CreateAutoscalingPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateAutoscalingPolicy()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            UpdateAutoscalingPolicyRequest expectedRequest = new UpdateAutoscalingPolicyRequest
            {
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateAutoscalingPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AutoscalingPolicy policy = new AutoscalingPolicy();
            AutoscalingPolicy response = client.UpdateAutoscalingPolicy(policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateAutoscalingPolicyAsync()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            UpdateAutoscalingPolicyRequest expectedRequest = new UpdateAutoscalingPolicyRequest
            {
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateAutoscalingPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AutoscalingPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AutoscalingPolicy policy = new AutoscalingPolicy();
            AutoscalingPolicy response = await client.UpdateAutoscalingPolicyAsync(policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateAutoscalingPolicy2()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            UpdateAutoscalingPolicyRequest request = new UpdateAutoscalingPolicyRequest
            {
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateAutoscalingPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AutoscalingPolicy response = client.UpdateAutoscalingPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateAutoscalingPolicyAsync2()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            UpdateAutoscalingPolicyRequest request = new UpdateAutoscalingPolicyRequest
            {
                Policy = new AutoscalingPolicy(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateAutoscalingPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AutoscalingPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AutoscalingPolicy response = await client.UpdateAutoscalingPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetAutoscalingPolicy()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            GetAutoscalingPolicyRequest expectedRequest = new GetAutoscalingPolicyRequest
            {
                Name = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetAutoscalingPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString();
            AutoscalingPolicy response = client.GetAutoscalingPolicy(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetAutoscalingPolicyAsync()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            GetAutoscalingPolicyRequest expectedRequest = new GetAutoscalingPolicyRequest
            {
                Name = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetAutoscalingPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AutoscalingPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString();
            AutoscalingPolicy response = await client.GetAutoscalingPolicyAsync(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetAutoscalingPolicy2()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            GetAutoscalingPolicyRequest request = new GetAutoscalingPolicyRequest
            {
                Name = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetAutoscalingPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AutoscalingPolicy response = client.GetAutoscalingPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetAutoscalingPolicyAsync2()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            GetAutoscalingPolicyRequest request = new GetAutoscalingPolicyRequest
            {
                Name = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString(),
            };
            AutoscalingPolicy expectedResponse = new AutoscalingPolicy
            {
                Id = "id3355",
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetAutoscalingPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AutoscalingPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AutoscalingPolicy response = await client.GetAutoscalingPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteAutoscalingPolicy()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            DeleteAutoscalingPolicyRequest expectedRequest = new DeleteAutoscalingPolicyRequest
            {
                Name = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAutoscalingPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString();
            client.DeleteAutoscalingPolicy(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteAutoscalingPolicyAsync()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            DeleteAutoscalingPolicyRequest expectedRequest = new DeleteAutoscalingPolicyRequest
            {
                Name = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAutoscalingPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString();
            await client.DeleteAutoscalingPolicyAsync(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteAutoscalingPolicy2()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            DeleteAutoscalingPolicyRequest request = new DeleteAutoscalingPolicyRequest
            {
                Name = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAutoscalingPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAutoscalingPolicy(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteAutoscalingPolicyAsync2()
        {
            Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient> mockGrpcClient = new Mock<AutoscalingPolicyService.AutoscalingPolicyServiceClient>(MockBehavior.Strict);
            DeleteAutoscalingPolicyRequest request = new DeleteAutoscalingPolicyRequest
            {
                Name = new AutoscalingPolicyName("[PROJECT]", "[REGION]", "[AUTOSCALING_POLICY]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAutoscalingPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            AutoscalingPolicyServiceClient client = new AutoscalingPolicyServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAutoscalingPolicyAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
