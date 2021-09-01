// Copyright 2021 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.BigQuery.Reservation.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedReservationServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateReservationRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReservationId = "reservation_id4ff109fe",
                Reservation = new Reservation(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.CreateReservation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReservationRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReservationId = "reservation_id4ff109fe",
                Reservation = new Reservation(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.CreateReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.CreateReservationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReservation()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReservationId = "reservation_id4ff109fe",
                Reservation = new Reservation(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.CreateReservation(request.Parent, request.Reservation, request.ReservationId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReservationAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReservationId = "reservation_id4ff109fe",
                Reservation = new Reservation(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.CreateReservationAsync(request.Parent, request.Reservation, request.ReservationId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.CreateReservationAsync(request.Parent, request.Reservation, request.ReservationId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReservationResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReservationId = "reservation_id4ff109fe",
                Reservation = new Reservation(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.CreateReservation(request.ParentAsLocationName, request.Reservation, request.ReservationId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReservationResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReservationId = "reservation_id4ff109fe",
                Reservation = new Reservation(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.CreateReservationAsync(request.ParentAsLocationName, request.Reservation, request.ReservationId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.CreateReservationAsync(request.ParentAsLocationName, request.Reservation, request.ReservationId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReservationRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.GetReservation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReservationRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.GetReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.GetReservationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReservation()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.GetReservation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReservationAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.GetReservationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.GetReservationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReservationResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.GetReservation(request.ReservationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReservationResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.GetReservationAsync(request.ReservationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.GetReservationAsync(request.ReservationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteReservationRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteReservation(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteReservationRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteReservationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteReservation()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteReservation(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteReservationAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteReservationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteReservationAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteReservationResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteReservation(request.ReservationName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteReservationResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteReservationAsync(request.ReservationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteReservationAsync(request.ReservationName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateReservationRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.UpdateReservation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateReservationRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.UpdateReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.UpdateReservationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateReservation()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation response = client.UpdateReservation(request.Reservation, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateReservationAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Reservation expectedResponse = new Reservation
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                SlotCapacity = 6702076284109415515L,
                IgnoreIdleSlots = true,
                CreationTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Reservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Reservation responseCallSettings = await client.UpdateReservationAsync(request.Reservation, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Reservation responseCancellationToken = await client.UpdateReservationAsync(request.Reservation, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCapacityCommitmentRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateCapacityCommitmentRequest request = new CreateCapacityCommitmentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitment = new CapacityCommitment(),
                EnforceSingleAdminProjectPerOrg = false,
                CapacityCommitmentId = "capacity_commitment_idb92d5c34",
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment response = client.CreateCapacityCommitment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCapacityCommitmentRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateCapacityCommitmentRequest request = new CreateCapacityCommitmentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitment = new CapacityCommitment(),
                EnforceSingleAdminProjectPerOrg = false,
                CapacityCommitmentId = "capacity_commitment_idb92d5c34",
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CapacityCommitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment responseCallSettings = await client.CreateCapacityCommitmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CapacityCommitment responseCancellationToken = await client.CreateCapacityCommitmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCapacityCommitment()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateCapacityCommitmentRequest request = new CreateCapacityCommitmentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitment = new CapacityCommitment(),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment response = client.CreateCapacityCommitment(request.Parent, request.CapacityCommitment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCapacityCommitmentAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateCapacityCommitmentRequest request = new CreateCapacityCommitmentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitment = new CapacityCommitment(),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CapacityCommitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment responseCallSettings = await client.CreateCapacityCommitmentAsync(request.Parent, request.CapacityCommitment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CapacityCommitment responseCancellationToken = await client.CreateCapacityCommitmentAsync(request.Parent, request.CapacityCommitment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCapacityCommitmentResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateCapacityCommitmentRequest request = new CreateCapacityCommitmentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitment = new CapacityCommitment(),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment response = client.CreateCapacityCommitment(request.ParentAsLocationName, request.CapacityCommitment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCapacityCommitmentResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateCapacityCommitmentRequest request = new CreateCapacityCommitmentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitment = new CapacityCommitment(),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CapacityCommitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment responseCallSettings = await client.CreateCapacityCommitmentAsync(request.ParentAsLocationName, request.CapacityCommitment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CapacityCommitment responseCancellationToken = await client.CreateCapacityCommitmentAsync(request.ParentAsLocationName, request.CapacityCommitment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCapacityCommitmentRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetCapacityCommitmentRequest request = new GetCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment response = client.GetCapacityCommitment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCapacityCommitmentRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetCapacityCommitmentRequest request = new GetCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CapacityCommitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment responseCallSettings = await client.GetCapacityCommitmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CapacityCommitment responseCancellationToken = await client.GetCapacityCommitmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCapacityCommitment()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetCapacityCommitmentRequest request = new GetCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment response = client.GetCapacityCommitment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCapacityCommitmentAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetCapacityCommitmentRequest request = new GetCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CapacityCommitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment responseCallSettings = await client.GetCapacityCommitmentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CapacityCommitment responseCancellationToken = await client.GetCapacityCommitmentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCapacityCommitmentResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetCapacityCommitmentRequest request = new GetCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment response = client.GetCapacityCommitment(request.CapacityCommitmentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCapacityCommitmentResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetCapacityCommitmentRequest request = new GetCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CapacityCommitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment responseCallSettings = await client.GetCapacityCommitmentAsync(request.CapacityCommitmentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CapacityCommitment responseCancellationToken = await client.GetCapacityCommitmentAsync(request.CapacityCommitmentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCapacityCommitmentRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteCapacityCommitmentRequest request = new DeleteCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCapacityCommitment(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCapacityCommitmentRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteCapacityCommitmentRequest request = new DeleteCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCapacityCommitmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCapacityCommitmentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCapacityCommitment()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteCapacityCommitmentRequest request = new DeleteCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCapacityCommitment(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCapacityCommitmentAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteCapacityCommitmentRequest request = new DeleteCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCapacityCommitmentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCapacityCommitmentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCapacityCommitmentResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteCapacityCommitmentRequest request = new DeleteCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCapacityCommitment(request.CapacityCommitmentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCapacityCommitmentResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteCapacityCommitmentRequest request = new DeleteCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCapacityCommitmentAsync(request.CapacityCommitmentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCapacityCommitmentAsync(request.CapacityCommitmentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCapacityCommitmentRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateCapacityCommitmentRequest request = new UpdateCapacityCommitmentRequest
            {
                CapacityCommitment = new CapacityCommitment(),
                UpdateMask = new wkt::FieldMask(),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment response = client.UpdateCapacityCommitment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCapacityCommitmentRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateCapacityCommitmentRequest request = new UpdateCapacityCommitmentRequest
            {
                CapacityCommitment = new CapacityCommitment(),
                UpdateMask = new wkt::FieldMask(),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CapacityCommitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment responseCallSettings = await client.UpdateCapacityCommitmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CapacityCommitment responseCancellationToken = await client.UpdateCapacityCommitmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCapacityCommitment()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateCapacityCommitmentRequest request = new UpdateCapacityCommitmentRequest
            {
                CapacityCommitment = new CapacityCommitment(),
                UpdateMask = new wkt::FieldMask(),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment response = client.UpdateCapacityCommitment(request.CapacityCommitment, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCapacityCommitmentAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateCapacityCommitmentRequest request = new UpdateCapacityCommitmentRequest
            {
                CapacityCommitment = new CapacityCommitment(),
                UpdateMask = new wkt::FieldMask(),
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CapacityCommitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment responseCallSettings = await client.UpdateCapacityCommitmentAsync(request.CapacityCommitment, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CapacityCommitment responseCancellationToken = await client.UpdateCapacityCommitmentAsync(request.CapacityCommitment, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SplitCapacityCommitmentRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            SplitCapacityCommitmentRequest request = new SplitCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
            };
            SplitCapacityCommitmentResponse expectedResponse = new SplitCapacityCommitmentResponse
            {
                First = new CapacityCommitment(),
                Second = new CapacityCommitment(),
            };
            mockGrpcClient.Setup(x => x.SplitCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            SplitCapacityCommitmentResponse response = client.SplitCapacityCommitment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SplitCapacityCommitmentRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            SplitCapacityCommitmentRequest request = new SplitCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
            };
            SplitCapacityCommitmentResponse expectedResponse = new SplitCapacityCommitmentResponse
            {
                First = new CapacityCommitment(),
                Second = new CapacityCommitment(),
            };
            mockGrpcClient.Setup(x => x.SplitCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SplitCapacityCommitmentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            SplitCapacityCommitmentResponse responseCallSettings = await client.SplitCapacityCommitmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SplitCapacityCommitmentResponse responseCancellationToken = await client.SplitCapacityCommitmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SplitCapacityCommitment()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            SplitCapacityCommitmentRequest request = new SplitCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
            };
            SplitCapacityCommitmentResponse expectedResponse = new SplitCapacityCommitmentResponse
            {
                First = new CapacityCommitment(),
                Second = new CapacityCommitment(),
            };
            mockGrpcClient.Setup(x => x.SplitCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            SplitCapacityCommitmentResponse response = client.SplitCapacityCommitment(request.Name, request.SlotCount);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SplitCapacityCommitmentAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            SplitCapacityCommitmentRequest request = new SplitCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
            };
            SplitCapacityCommitmentResponse expectedResponse = new SplitCapacityCommitmentResponse
            {
                First = new CapacityCommitment(),
                Second = new CapacityCommitment(),
            };
            mockGrpcClient.Setup(x => x.SplitCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SplitCapacityCommitmentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            SplitCapacityCommitmentResponse responseCallSettings = await client.SplitCapacityCommitmentAsync(request.Name, request.SlotCount, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SplitCapacityCommitmentResponse responseCancellationToken = await client.SplitCapacityCommitmentAsync(request.Name, request.SlotCount, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SplitCapacityCommitmentResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            SplitCapacityCommitmentRequest request = new SplitCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
            };
            SplitCapacityCommitmentResponse expectedResponse = new SplitCapacityCommitmentResponse
            {
                First = new CapacityCommitment(),
                Second = new CapacityCommitment(),
            };
            mockGrpcClient.Setup(x => x.SplitCapacityCommitment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            SplitCapacityCommitmentResponse response = client.SplitCapacityCommitment(request.CapacityCommitmentName, request.SlotCount);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SplitCapacityCommitmentResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            SplitCapacityCommitmentRequest request = new SplitCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
            };
            SplitCapacityCommitmentResponse expectedResponse = new SplitCapacityCommitmentResponse
            {
                First = new CapacityCommitment(),
                Second = new CapacityCommitment(),
            };
            mockGrpcClient.Setup(x => x.SplitCapacityCommitmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SplitCapacityCommitmentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            SplitCapacityCommitmentResponse responseCallSettings = await client.SplitCapacityCommitmentAsync(request.CapacityCommitmentName, request.SlotCount, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SplitCapacityCommitmentResponse responseCancellationToken = await client.SplitCapacityCommitmentAsync(request.CapacityCommitmentName, request.SlotCount, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MergeCapacityCommitmentsRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MergeCapacityCommitmentsRequest request = new MergeCapacityCommitmentsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitmentIds =
                {
                    "capacity_commitment_idsf9524d89",
                },
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.MergeCapacityCommitments(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment response = client.MergeCapacityCommitments(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MergeCapacityCommitmentsRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MergeCapacityCommitmentsRequest request = new MergeCapacityCommitmentsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitmentIds =
                {
                    "capacity_commitment_idsf9524d89",
                },
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.MergeCapacityCommitmentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CapacityCommitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment responseCallSettings = await client.MergeCapacityCommitmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CapacityCommitment responseCancellationToken = await client.MergeCapacityCommitmentsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MergeCapacityCommitments()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MergeCapacityCommitmentsRequest request = new MergeCapacityCommitmentsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitmentIds =
                {
                    "capacity_commitment_idsf9524d89",
                },
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.MergeCapacityCommitments(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment response = client.MergeCapacityCommitments(request.Parent, request.CapacityCommitmentIds);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MergeCapacityCommitmentsAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MergeCapacityCommitmentsRequest request = new MergeCapacityCommitmentsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitmentIds =
                {
                    "capacity_commitment_idsf9524d89",
                },
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.MergeCapacityCommitmentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CapacityCommitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment responseCallSettings = await client.MergeCapacityCommitmentsAsync(request.Parent, request.CapacityCommitmentIds, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CapacityCommitment responseCancellationToken = await client.MergeCapacityCommitmentsAsync(request.Parent, request.CapacityCommitmentIds, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MergeCapacityCommitmentsResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MergeCapacityCommitmentsRequest request = new MergeCapacityCommitmentsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitmentIds =
                {
                    "capacity_commitment_idsf9524d89",
                },
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.MergeCapacityCommitments(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment response = client.MergeCapacityCommitments(request.ParentAsLocationName, request.CapacityCommitmentIds);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MergeCapacityCommitmentsResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MergeCapacityCommitmentsRequest request = new MergeCapacityCommitmentsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitmentIds =
                {
                    "capacity_commitment_idsf9524d89",
                },
            };
            CapacityCommitment expectedResponse = new CapacityCommitment
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = -8848908602751739335L,
                Plan = CapacityCommitment.Types.CommitmentPlan.Trial,
                State = CapacityCommitment.Types.State.Active,
                CommitmentEndTime = new wkt::Timestamp(),
                FailureStatus = new gr::Status(),
                RenewalPlan = CapacityCommitment.Types.CommitmentPlan.Trial,
                CommitmentStartTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.MergeCapacityCommitmentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CapacityCommitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            CapacityCommitment responseCallSettings = await client.MergeCapacityCommitmentsAsync(request.ParentAsLocationName, request.CapacityCommitmentIds, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CapacityCommitment responseCancellationToken = await client.MergeCapacityCommitmentsAsync(request.ParentAsLocationName, request.CapacityCommitmentIds, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAssignmentRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateAssignmentRequest request = new CreateAssignmentRequest
            {
                ParentAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                Assignment = new Assignment(),
                AssignmentId = "assignment_id9b89c493",
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment response = client.CreateAssignment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAssignmentRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateAssignmentRequest request = new CreateAssignmentRequest
            {
                ParentAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                Assignment = new Assignment(),
                AssignmentId = "assignment_id9b89c493",
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assignment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment responseCallSettings = await client.CreateAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assignment responseCancellationToken = await client.CreateAssignmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAssignment()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateAssignmentRequest request = new CreateAssignmentRequest
            {
                ParentAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                Assignment = new Assignment(),
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment response = client.CreateAssignment(request.Parent, request.Assignment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAssignmentAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateAssignmentRequest request = new CreateAssignmentRequest
            {
                ParentAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                Assignment = new Assignment(),
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assignment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment responseCallSettings = await client.CreateAssignmentAsync(request.Parent, request.Assignment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assignment responseCancellationToken = await client.CreateAssignmentAsync(request.Parent, request.Assignment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAssignmentResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateAssignmentRequest request = new CreateAssignmentRequest
            {
                ParentAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                Assignment = new Assignment(),
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment response = client.CreateAssignment(request.ParentAsReservationName, request.Assignment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAssignmentResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            CreateAssignmentRequest request = new CreateAssignmentRequest
            {
                ParentAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                Assignment = new Assignment(),
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.CreateAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assignment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment responseCallSettings = await client.CreateAssignmentAsync(request.ParentAsReservationName, request.Assignment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assignment responseCancellationToken = await client.CreateAssignmentAsync(request.ParentAsReservationName, request.Assignment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAssignmentRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteAssignmentRequest request = new DeleteAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAssignment(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAssignmentRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteAssignmentRequest request = new DeleteAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAssignmentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAssignment()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteAssignmentRequest request = new DeleteAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAssignment(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAssignmentAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteAssignmentRequest request = new DeleteAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAssignmentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAssignmentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAssignmentResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteAssignmentRequest request = new DeleteAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAssignment(request.AssignmentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAssignmentResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            DeleteAssignmentRequest request = new DeleteAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAssignmentAsync(request.AssignmentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAssignmentAsync(request.AssignmentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MoveAssignmentRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MoveAssignmentRequest request = new MoveAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                DestinationIdAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.MoveAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment response = client.MoveAssignment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MoveAssignmentRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MoveAssignmentRequest request = new MoveAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                DestinationIdAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.MoveAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assignment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment responseCallSettings = await client.MoveAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assignment responseCancellationToken = await client.MoveAssignmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MoveAssignment()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MoveAssignmentRequest request = new MoveAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                DestinationIdAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.MoveAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment response = client.MoveAssignment(request.Name, request.DestinationId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MoveAssignmentAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MoveAssignmentRequest request = new MoveAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                DestinationIdAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.MoveAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assignment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment responseCallSettings = await client.MoveAssignmentAsync(request.Name, request.DestinationId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assignment responseCancellationToken = await client.MoveAssignmentAsync(request.Name, request.DestinationId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MoveAssignmentResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MoveAssignmentRequest request = new MoveAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                DestinationIdAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.MoveAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment response = client.MoveAssignment(request.AssignmentName, request.DestinationIdAsReservationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MoveAssignmentResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            MoveAssignmentRequest request = new MoveAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                DestinationIdAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            Assignment expectedResponse = new Assignment
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                JobType = Assignment.Types.JobType.Pipeline,
                Assignee = "assignee3de7fd68",
                State = Assignment.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.MoveAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Assignment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            Assignment responseCallSettings = await client.MoveAssignmentAsync(request.AssignmentName, request.DestinationIdAsReservationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Assignment responseCancellationToken = await client.MoveAssignmentAsync(request.AssignmentName, request.DestinationIdAsReservationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBiReservationRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetBiReservationRequest request = new GetBiReservationRequest
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            BiReservation expectedResponse = new BiReservation
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UpdateTime = new wkt::Timestamp(),
                Size = -7217254403942597129L,
            };
            mockGrpcClient.Setup(x => x.GetBiReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            BiReservation response = client.GetBiReservation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBiReservationRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetBiReservationRequest request = new GetBiReservationRequest
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            BiReservation expectedResponse = new BiReservation
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UpdateTime = new wkt::Timestamp(),
                Size = -7217254403942597129L,
            };
            mockGrpcClient.Setup(x => x.GetBiReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BiReservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            BiReservation responseCallSettings = await client.GetBiReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BiReservation responseCancellationToken = await client.GetBiReservationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBiReservation()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetBiReservationRequest request = new GetBiReservationRequest
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            BiReservation expectedResponse = new BiReservation
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UpdateTime = new wkt::Timestamp(),
                Size = -7217254403942597129L,
            };
            mockGrpcClient.Setup(x => x.GetBiReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            BiReservation response = client.GetBiReservation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBiReservationAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetBiReservationRequest request = new GetBiReservationRequest
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            BiReservation expectedResponse = new BiReservation
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UpdateTime = new wkt::Timestamp(),
                Size = -7217254403942597129L,
            };
            mockGrpcClient.Setup(x => x.GetBiReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BiReservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            BiReservation responseCallSettings = await client.GetBiReservationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BiReservation responseCancellationToken = await client.GetBiReservationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBiReservationResourceNames()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetBiReservationRequest request = new GetBiReservationRequest
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            BiReservation expectedResponse = new BiReservation
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UpdateTime = new wkt::Timestamp(),
                Size = -7217254403942597129L,
            };
            mockGrpcClient.Setup(x => x.GetBiReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            BiReservation response = client.GetBiReservation(request.BiReservationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBiReservationResourceNamesAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            GetBiReservationRequest request = new GetBiReservationRequest
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            BiReservation expectedResponse = new BiReservation
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UpdateTime = new wkt::Timestamp(),
                Size = -7217254403942597129L,
            };
            mockGrpcClient.Setup(x => x.GetBiReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BiReservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            BiReservation responseCallSettings = await client.GetBiReservationAsync(request.BiReservationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BiReservation responseCancellationToken = await client.GetBiReservationAsync(request.BiReservationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBiReservationRequestObject()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateBiReservationRequest request = new UpdateBiReservationRequest
            {
                BiReservation = new BiReservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            BiReservation expectedResponse = new BiReservation
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UpdateTime = new wkt::Timestamp(),
                Size = -7217254403942597129L,
            };
            mockGrpcClient.Setup(x => x.UpdateBiReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            BiReservation response = client.UpdateBiReservation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBiReservationRequestObjectAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateBiReservationRequest request = new UpdateBiReservationRequest
            {
                BiReservation = new BiReservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            BiReservation expectedResponse = new BiReservation
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UpdateTime = new wkt::Timestamp(),
                Size = -7217254403942597129L,
            };
            mockGrpcClient.Setup(x => x.UpdateBiReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BiReservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            BiReservation responseCallSettings = await client.UpdateBiReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BiReservation responseCancellationToken = await client.UpdateBiReservationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBiReservation()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateBiReservationRequest request = new UpdateBiReservationRequest
            {
                BiReservation = new BiReservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            BiReservation expectedResponse = new BiReservation
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UpdateTime = new wkt::Timestamp(),
                Size = -7217254403942597129L,
            };
            mockGrpcClient.Setup(x => x.UpdateBiReservation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            BiReservation response = client.UpdateBiReservation(request.BiReservation, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBiReservationAsync()
        {
            moq::Mock<ReservationService.ReservationServiceClient> mockGrpcClient = new moq::Mock<ReservationService.ReservationServiceClient>(moq::MockBehavior.Strict);
            UpdateBiReservationRequest request = new UpdateBiReservationRequest
            {
                BiReservation = new BiReservation(),
                UpdateMask = new wkt::FieldMask(),
            };
            BiReservation expectedResponse = new BiReservation
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                UpdateTime = new wkt::Timestamp(),
                Size = -7217254403942597129L,
            };
            mockGrpcClient.Setup(x => x.UpdateBiReservationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BiReservation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReservationServiceClient client = new ReservationServiceClientImpl(mockGrpcClient.Object, null);
            BiReservation responseCallSettings = await client.UpdateBiReservationAsync(request.BiReservation, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BiReservation responseCancellationToken = await client.UpdateBiReservationAsync(request.BiReservation, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
