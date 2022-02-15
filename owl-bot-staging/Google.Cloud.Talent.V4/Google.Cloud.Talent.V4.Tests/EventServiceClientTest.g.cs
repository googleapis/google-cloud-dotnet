// Copyright 2022 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Talent.V4.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedEventServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateClientEventRequestObject()
        {
            moq::Mock<EventService.EventServiceClient> mockGrpcClient = new moq::Mock<EventService.EventServiceClient>(moq::MockBehavior.Strict);
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ClientEvent = new ClientEvent(),
            };
            ClientEvent expectedResponse = new ClientEvent
            {
                RequestId = "request_id362c8df6",
                EventId = "event_idaccf3744",
                CreateTime = new wkt::Timestamp(),
                JobEvent = new JobEvent(),
                EventNotes = "event_notes102ba330",
            };
            mockGrpcClient.Setup(x => x.CreateClientEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EventServiceClient client = new EventServiceClientImpl(mockGrpcClient.Object, null);
            ClientEvent response = client.CreateClientEvent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateClientEventRequestObjectAsync()
        {
            moq::Mock<EventService.EventServiceClient> mockGrpcClient = new moq::Mock<EventService.EventServiceClient>(moq::MockBehavior.Strict);
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ClientEvent = new ClientEvent(),
            };
            ClientEvent expectedResponse = new ClientEvent
            {
                RequestId = "request_id362c8df6",
                EventId = "event_idaccf3744",
                CreateTime = new wkt::Timestamp(),
                JobEvent = new JobEvent(),
                EventNotes = "event_notes102ba330",
            };
            mockGrpcClient.Setup(x => x.CreateClientEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EventServiceClient client = new EventServiceClientImpl(mockGrpcClient.Object, null);
            ClientEvent responseCallSettings = await client.CreateClientEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientEvent responseCancellationToken = await client.CreateClientEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateClientEvent()
        {
            moq::Mock<EventService.EventServiceClient> mockGrpcClient = new moq::Mock<EventService.EventServiceClient>(moq::MockBehavior.Strict);
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ClientEvent = new ClientEvent(),
            };
            ClientEvent expectedResponse = new ClientEvent
            {
                RequestId = "request_id362c8df6",
                EventId = "event_idaccf3744",
                CreateTime = new wkt::Timestamp(),
                JobEvent = new JobEvent(),
                EventNotes = "event_notes102ba330",
            };
            mockGrpcClient.Setup(x => x.CreateClientEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EventServiceClient client = new EventServiceClientImpl(mockGrpcClient.Object, null);
            ClientEvent response = client.CreateClientEvent(request.Parent, request.ClientEvent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateClientEventAsync()
        {
            moq::Mock<EventService.EventServiceClient> mockGrpcClient = new moq::Mock<EventService.EventServiceClient>(moq::MockBehavior.Strict);
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ClientEvent = new ClientEvent(),
            };
            ClientEvent expectedResponse = new ClientEvent
            {
                RequestId = "request_id362c8df6",
                EventId = "event_idaccf3744",
                CreateTime = new wkt::Timestamp(),
                JobEvent = new JobEvent(),
                EventNotes = "event_notes102ba330",
            };
            mockGrpcClient.Setup(x => x.CreateClientEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EventServiceClient client = new EventServiceClientImpl(mockGrpcClient.Object, null);
            ClientEvent responseCallSettings = await client.CreateClientEventAsync(request.Parent, request.ClientEvent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientEvent responseCancellationToken = await client.CreateClientEventAsync(request.Parent, request.ClientEvent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateClientEventResourceNames()
        {
            moq::Mock<EventService.EventServiceClient> mockGrpcClient = new moq::Mock<EventService.EventServiceClient>(moq::MockBehavior.Strict);
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ClientEvent = new ClientEvent(),
            };
            ClientEvent expectedResponse = new ClientEvent
            {
                RequestId = "request_id362c8df6",
                EventId = "event_idaccf3744",
                CreateTime = new wkt::Timestamp(),
                JobEvent = new JobEvent(),
                EventNotes = "event_notes102ba330",
            };
            mockGrpcClient.Setup(x => x.CreateClientEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EventServiceClient client = new EventServiceClientImpl(mockGrpcClient.Object, null);
            ClientEvent response = client.CreateClientEvent(request.ParentAsTenantName, request.ClientEvent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateClientEventResourceNamesAsync()
        {
            moq::Mock<EventService.EventServiceClient> mockGrpcClient = new moq::Mock<EventService.EventServiceClient>(moq::MockBehavior.Strict);
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ClientEvent = new ClientEvent(),
            };
            ClientEvent expectedResponse = new ClientEvent
            {
                RequestId = "request_id362c8df6",
                EventId = "event_idaccf3744",
                CreateTime = new wkt::Timestamp(),
                JobEvent = new JobEvent(),
                EventNotes = "event_notes102ba330",
            };
            mockGrpcClient.Setup(x => x.CreateClientEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClientEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EventServiceClient client = new EventServiceClientImpl(mockGrpcClient.Object, null);
            ClientEvent responseCallSettings = await client.CreateClientEventAsync(request.ParentAsTenantName, request.ClientEvent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClientEvent responseCancellationToken = await client.CreateClientEventAsync(request.ParentAsTenantName, request.ClientEvent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
