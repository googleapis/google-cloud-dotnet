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

// Do not warn when using obsolete members
#pragma warning disable CS0612

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
    public class GeneratedUptimeCheckServiceClientTest
    {
        [Fact]
        public void GetUptimeCheckConfig()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            GetUptimeCheckConfigRequest expectedRequest = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfigName name = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            UptimeCheckConfig response = client.GetUptimeCheckConfig(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetUptimeCheckConfigAsync()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            GetUptimeCheckConfigRequest expectedRequest = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UptimeCheckConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfigName name = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            UptimeCheckConfig response = await client.GetUptimeCheckConfigAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetUptimeCheckConfig2()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.GetUptimeCheckConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetUptimeCheckConfigAsync2()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UptimeCheckConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = await client.GetUptimeCheckConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateUptimeCheckConfig()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            CreateUptimeCheckConfigRequest expectedRequest = new CreateUptimeCheckConfigRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            UptimeCheckConfig response = client.CreateUptimeCheckConfig(formattedParent, uptimeCheckConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateUptimeCheckConfigAsync()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            CreateUptimeCheckConfigRequest expectedRequest = new CreateUptimeCheckConfigRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UptimeCheckConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            UptimeCheckConfig response = await client.CreateUptimeCheckConfigAsync(formattedParent, uptimeCheckConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateUptimeCheckConfig2()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.CreateUptimeCheckConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateUptimeCheckConfigAsync2()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UptimeCheckConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = await client.CreateUptimeCheckConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateUptimeCheckConfig()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            UpdateUptimeCheckConfigRequest expectedRequest = new UpdateUptimeCheckConfigRequest
            {
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.UpdateUptimeCheckConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            UptimeCheckConfig response = client.UpdateUptimeCheckConfig(uptimeCheckConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateUptimeCheckConfigAsync()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            UpdateUptimeCheckConfigRequest expectedRequest = new UpdateUptimeCheckConfigRequest
            {
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.UpdateUptimeCheckConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UptimeCheckConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            UptimeCheckConfig response = await client.UpdateUptimeCheckConfigAsync(uptimeCheckConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateUptimeCheckConfig2()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            UpdateUptimeCheckConfigRequest request = new UpdateUptimeCheckConfigRequest
            {
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.UpdateUptimeCheckConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = client.UpdateUptimeCheckConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateUptimeCheckConfigAsync2()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            UpdateUptimeCheckConfigRequest request = new UpdateUptimeCheckConfigRequest
            {
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                IsInternal = true,
            };
            mockGrpcClient.Setup(x => x.UpdateUptimeCheckConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UptimeCheckConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig response = await client.UpdateUptimeCheckConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteUptimeCheckConfig()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest expectedRequest = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfigName name = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            client.DeleteUptimeCheckConfig(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteUptimeCheckConfigAsync()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest expectedRequest = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfigName name = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            await client.DeleteUptimeCheckConfigAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteUptimeCheckConfig2()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteUptimeCheckConfig(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteUptimeCheckConfigAsync2()
        {
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient>(MockBehavior.Strict);
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteUptimeCheckConfigAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
