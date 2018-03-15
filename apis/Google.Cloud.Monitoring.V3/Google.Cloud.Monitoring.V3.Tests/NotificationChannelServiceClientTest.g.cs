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

namespace Google.Cloud.Monitoring.V3.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedNotificationChannelServiceClientTest
    {
        [Fact]
        public void GetNotificationChannelDescriptorTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient> { DefaultValue = DefaultValue.Mock };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Name = "name2-1052831874",
                Type = "type3575610",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptor(It.IsAny<GetNotificationChannelDescriptorRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptorName name = new NotificationChannelDescriptorName("[PROJECT]", "[CHANNEL_DESCRIPTOR]");
            NotificationChannelDescriptor response = client.GetNotificationChannelDescriptor(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetNotificationChannelTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient> { DefaultValue = DefaultValue.Mock };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetNotificationChannel(It.IsAny<GetNotificationChannelRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            NotificationChannel response = client.GetNotificationChannel(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateNotificationChannelTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient> { DefaultValue = DefaultValue.Mock };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateNotificationChannel(It.IsAny<CreateNotificationChannelRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            NotificationChannel notificationChannel = new NotificationChannel();
            NotificationChannel response = client.CreateNotificationChannel(name, notificationChannel);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateNotificationChannelTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient> { DefaultValue = DefaultValue.Mock };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "type3575610",
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateNotificationChannel(It.IsAny<UpdateNotificationChannelRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            FieldMask updateMask = new FieldMask();
            NotificationChannel notificationChannel = new NotificationChannel();
            NotificationChannel response = client.UpdateNotificationChannel(updateMask, notificationChannel);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteNotificationChannelTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new Mock<NotificationChannelService.NotificationChannelServiceClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteNotificationChannel(It.IsAny<DeleteNotificationChannelRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelName name = new NotificationChannelName("[PROJECT]", "[NOTIFICATION_CHANNEL]");
            bool force = false;
            client.DeleteNotificationChannel(name, force);
            mockGrpcClient.VerifyAll();
        }

    }
}
