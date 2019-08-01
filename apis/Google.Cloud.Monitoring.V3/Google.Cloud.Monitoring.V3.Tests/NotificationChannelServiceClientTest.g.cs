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
    public class GeneratedNotificationChannelServiceClientTest
    {
        [Fact]
        public void GetNotificationChannelDescriptor()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest expectedRequest = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = new NotificationChannelDescriptorName("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptor(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptorName name = new NotificationChannelDescriptorName("[PROJECT]", "[CHANNEL_DESCRIPTOR]");
            NotificationChannelDescriptor response = client.GetNotificationChannelDescriptor(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetNotificationChannelDescriptorAsync()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest expectedRequest = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = new NotificationChannelDescriptorName("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptorAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NotificationChannelDescriptor>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptorName name = new NotificationChannelDescriptorName("[PROJECT]", "[CHANNEL_DESCRIPTOR]");
            NotificationChannelDescriptor response = await client.GetNotificationChannelDescriptorAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetNotificationChannelDescriptor2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = new NotificationChannelDescriptorName("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptor(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptor response = client.GetNotificationChannelDescriptor(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetNotificationChannelDescriptorAsync2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = new NotificationChannelDescriptorName("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptorAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NotificationChannelDescriptor>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptor response = await client.GetNotificationChannelDescriptorAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetNotificationChannel()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelRequest expectedRequest = new GetNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            NotificationChannel response = client.GetNotificationChannel(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetNotificationChannelAsync()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelRequest expectedRequest = new GetNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NotificationChannel>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            NotificationChannel response = await client.GetNotificationChannelAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetNotificationChannel2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.GetNotificationChannel(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetNotificationChannelAsync2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NotificationChannel>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = await client.GetNotificationChannelAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateNotificationChannel()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            CreateNotificationChannelRequest expectedRequest = new CreateNotificationChannelRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            NotificationChannel notificationChannel = new NotificationChannel();
            NotificationChannel response = client.CreateNotificationChannel(name, notificationChannel);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateNotificationChannelAsync()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            CreateNotificationChannelRequest expectedRequest = new CreateNotificationChannelRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NotificationChannel>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            NotificationChannel notificationChannel = new NotificationChannel();
            NotificationChannel response = await client.CreateNotificationChannelAsync(name, notificationChannel);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateNotificationChannel2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.CreateNotificationChannel(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateNotificationChannelAsync2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NotificationChannel>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = await client.CreateNotificationChannelAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateNotificationChannel()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            UpdateNotificationChannelRequest expectedRequest = new UpdateNotificationChannelRequest
            {
                UpdateMask = new FieldMask(),
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationChannel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            FieldMask updateMask = new FieldMask();
            NotificationChannel notificationChannel = new NotificationChannel();
            NotificationChannel response = client.UpdateNotificationChannel(updateMask, notificationChannel);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateNotificationChannelAsync()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            UpdateNotificationChannelRequest expectedRequest = new UpdateNotificationChannelRequest
            {
                UpdateMask = new FieldMask(),
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationChannelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NotificationChannel>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            FieldMask updateMask = new FieldMask();
            NotificationChannel notificationChannel = new NotificationChannel();
            NotificationChannel response = await client.UpdateNotificationChannelAsync(updateMask, notificationChannel);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateNotificationChannel2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            UpdateNotificationChannelRequest request = new UpdateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationChannel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.UpdateNotificationChannel(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateNotificationChannelAsync2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            UpdateNotificationChannelRequest request = new UpdateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationChannelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NotificationChannel>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = await client.UpdateNotificationChannelAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteNotificationChannel()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            DeleteNotificationChannelRequest expectedRequest = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = false,
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteNotificationChannel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            bool force = false;
            client.DeleteNotificationChannel(name, force);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteNotificationChannelAsync()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            DeleteNotificationChannelRequest expectedRequest = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = false,
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteNotificationChannelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            bool force = false;
            await client.DeleteNotificationChannelAsync(name, force);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteNotificationChannel2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteNotificationChannel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteNotificationChannel(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteNotificationChannelAsync2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteNotificationChannelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNotificationChannelAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SendNotificationChannelVerificationCode()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest expectedRequest = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCode(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            client.SendNotificationChannelVerificationCode(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SendNotificationChannelVerificationCodeAsync()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest expectedRequest = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCodeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            await client.SendNotificationChannelVerificationCodeAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SendNotificationChannelVerificationCode2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCode(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.SendNotificationChannelVerificationCode(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SendNotificationChannelVerificationCodeAsync2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCodeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.SendNotificationChannelVerificationCodeAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetNotificationChannelVerificationCode()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest expectedRequest = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code3059181",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCode(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            GetNotificationChannelVerificationCodeResponse response = client.GetNotificationChannelVerificationCode(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetNotificationChannelVerificationCodeAsync()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest expectedRequest = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code3059181",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCodeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GetNotificationChannelVerificationCodeResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            GetNotificationChannelVerificationCodeResponse response = await client.GetNotificationChannelVerificationCodeAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetNotificationChannelVerificationCode2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code3059181",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCode(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            GetNotificationChannelVerificationCodeResponse response = client.GetNotificationChannelVerificationCode(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetNotificationChannelVerificationCodeAsync2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code3059181",
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCodeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GetNotificationChannelVerificationCodeResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            GetNotificationChannelVerificationCodeResponse response = await client.GetNotificationChannelVerificationCodeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void VerifyNotificationChannel()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            VerifyNotificationChannelRequest expectedRequest = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code3059181",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            string code = "code3059181";
            NotificationChannel response = client.VerifyNotificationChannel(name, code);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task VerifyNotificationChannelAsync()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            VerifyNotificationChannelRequest expectedRequest = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code3059181",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NotificationChannel>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            string code = "code3059181";
            NotificationChannel response = await client.VerifyNotificationChannelAsync(name, code);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void VerifyNotificationChannel2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code3059181",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.VerifyNotificationChannel(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task VerifyNotificationChannelAsync2()
        {
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient>(MockBehavior.Strict);
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code3059181",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NotificationChannel>(Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = await client.VerifyNotificationChannelAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
