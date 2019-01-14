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

namespace Google.Cloud.Monitoring.V3.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Monitoring.V3;
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
    public class GeneratedAlertPolicyServiceClientTest
    {
        [Fact]
        public void GetAlertPolicy()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            GetAlertPolicyRequest expectedRequest = new GetAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicyName name = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]");
            AlertPolicy response = client.GetAlertPolicy(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetAlertPolicyAsync()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            GetAlertPolicyRequest expectedRequest = new GetAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AlertPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicyName name = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]");
            AlertPolicy response = await client.GetAlertPolicyAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetAlertPolicy2()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.GetAlertPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetAlertPolicyAsync2()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetAlertPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AlertPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = await client.GetAlertPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateAlertPolicy()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            CreateAlertPolicyRequest expectedRequest = new CreateAlertPolicyRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            AlertPolicy alertPolicy = new AlertPolicy();
            AlertPolicy response = client.CreateAlertPolicy(name, alertPolicy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateAlertPolicyAsync()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            CreateAlertPolicyRequest expectedRequest = new CreateAlertPolicyRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AlertPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            AlertPolicy alertPolicy = new AlertPolicy();
            AlertPolicy response = await client.CreateAlertPolicyAsync(name, alertPolicy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateAlertPolicy2()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.CreateAlertPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateAlertPolicyAsync2()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateAlertPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AlertPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = await client.CreateAlertPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteAlertPolicy()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            DeleteAlertPolicyRequest expectedRequest = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAlertPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicyName name = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]");
            client.DeleteAlertPolicy(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteAlertPolicyAsync()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            DeleteAlertPolicyRequest expectedRequest = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAlertPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicyName name = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]");
            await client.DeleteAlertPolicyAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteAlertPolicy2()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAlertPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAlertPolicy(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteAlertPolicyAsync2()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteAlertPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAlertPolicyAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateAlertPolicy()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            UpdateAlertPolicyRequest expectedRequest = new UpdateAlertPolicyRequest
            {
                UpdateMask = new FieldMask(),
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateAlertPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            FieldMask updateMask = new FieldMask();
            AlertPolicy alertPolicy = new AlertPolicy();
            AlertPolicy response = client.UpdateAlertPolicy(updateMask, alertPolicy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateAlertPolicyAsync()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            UpdateAlertPolicyRequest expectedRequest = new UpdateAlertPolicyRequest
            {
                UpdateMask = new FieldMask(),
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateAlertPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AlertPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            FieldMask updateMask = new FieldMask();
            AlertPolicy alertPolicy = new AlertPolicy();
            AlertPolicy response = await client.UpdateAlertPolicyAsync(updateMask, alertPolicy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateAlertPolicy2()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            UpdateAlertPolicyRequest request = new UpdateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateAlertPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = client.UpdateAlertPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateAlertPolicyAsync2()
        {
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient>(MockBehavior.Strict);
            UpdateAlertPolicyRequest request = new UpdateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
            };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateAlertPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AlertPolicy>(Task.FromResult(expectedResponse), null, null, null, null));
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicy response = await client.UpdateAlertPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
