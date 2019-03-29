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

namespace Google.Cloud.Talent.V4Beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Talent.V4Beta1;
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
    public class GeneratedEventServiceClientTest
    {
        [Fact]
        public void CreateClientEvent()
        {
            Mock<EventService.EventServiceClient> mockGrpcClient = new Mock<EventService.EventServiceClient>(MockBehavior.Strict);
            CreateClientEventRequest expectedRequest = new CreateClientEventRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                ClientEvent = new ClientEvent(),
            };
            ClientEvent expectedResponse = new ClientEvent
            {
                RequestId = "requestId37109963",
                EventId = "eventId278118624",
                EventNotes = "eventNotes445073628",
            };
            mockGrpcClient.Setup(x => x.CreateClientEvent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EventServiceClient client = new EventServiceClientImpl(mockGrpcClient.Object, null);
            TenantOrProjectNameOneof parent = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]"));
            ClientEvent clientEvent = new ClientEvent();
            ClientEvent response = client.CreateClientEvent(parent, clientEvent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateClientEventAsync()
        {
            Mock<EventService.EventServiceClient> mockGrpcClient = new Mock<EventService.EventServiceClient>(MockBehavior.Strict);
            CreateClientEventRequest expectedRequest = new CreateClientEventRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                ClientEvent = new ClientEvent(),
            };
            ClientEvent expectedResponse = new ClientEvent
            {
                RequestId = "requestId37109963",
                EventId = "eventId278118624",
                EventNotes = "eventNotes445073628",
            };
            mockGrpcClient.Setup(x => x.CreateClientEventAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ClientEvent>(Task.FromResult(expectedResponse), null, null, null, null));
            EventServiceClient client = new EventServiceClientImpl(mockGrpcClient.Object, null);
            TenantOrProjectNameOneof parent = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]"));
            ClientEvent clientEvent = new ClientEvent();
            ClientEvent response = await client.CreateClientEventAsync(parent, clientEvent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateClientEvent2()
        {
            Mock<EventService.EventServiceClient> mockGrpcClient = new Mock<EventService.EventServiceClient>(MockBehavior.Strict);
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                ClientEvent = new ClientEvent(),
            };
            ClientEvent expectedResponse = new ClientEvent
            {
                RequestId = "requestId37109963",
                EventId = "eventId278118624",
                EventNotes = "eventNotes445073628",
            };
            mockGrpcClient.Setup(x => x.CreateClientEvent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            EventServiceClient client = new EventServiceClientImpl(mockGrpcClient.Object, null);
            ClientEvent response = client.CreateClientEvent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateClientEventAsync2()
        {
            Mock<EventService.EventServiceClient> mockGrpcClient = new Mock<EventService.EventServiceClient>(MockBehavior.Strict);
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                ClientEvent = new ClientEvent(),
            };
            ClientEvent expectedResponse = new ClientEvent
            {
                RequestId = "requestId37109963",
                EventId = "eventId278118624",
                EventNotes = "eventNotes445073628",
            };
            mockGrpcClient.Setup(x => x.CreateClientEventAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ClientEvent>(Task.FromResult(expectedResponse), null, null, null, null));
            EventServiceClient client = new EventServiceClientImpl(mockGrpcClient.Object, null);
            ClientEvent response = await client.CreateClientEventAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
