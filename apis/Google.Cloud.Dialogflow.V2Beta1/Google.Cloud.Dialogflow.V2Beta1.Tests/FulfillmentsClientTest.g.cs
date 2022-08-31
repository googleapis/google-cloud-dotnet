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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFulfillmentsClientTest
    {
        [xunit::FactAttribute]
        public void GetFulfillmentRequestObject()
        {
            moq::Mock<Fulfillments.FulfillmentsClient> mockGrpcClient = new moq::Mock<Fulfillments.FulfillmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetFulfillmentRequest request = new GetFulfillmentRequest
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
            };
            Fulfillment expectedResponse = new Fulfillment
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Fulfillment.Types.GenericWebService(),
                Enabled = true,
                Features =
                {
                    new Fulfillment.Types.Feature(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFulfillment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FulfillmentsClient client = new FulfillmentsClientImpl(mockGrpcClient.Object, null, null);
            Fulfillment response = client.GetFulfillment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFulfillmentRequestObjectAsync()
        {
            moq::Mock<Fulfillments.FulfillmentsClient> mockGrpcClient = new moq::Mock<Fulfillments.FulfillmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetFulfillmentRequest request = new GetFulfillmentRequest
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
            };
            Fulfillment expectedResponse = new Fulfillment
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Fulfillment.Types.GenericWebService(),
                Enabled = true,
                Features =
                {
                    new Fulfillment.Types.Feature(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFulfillmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Fulfillment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FulfillmentsClient client = new FulfillmentsClientImpl(mockGrpcClient.Object, null, null);
            Fulfillment responseCallSettings = await client.GetFulfillmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Fulfillment responseCancellationToken = await client.GetFulfillmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFulfillment()
        {
            moq::Mock<Fulfillments.FulfillmentsClient> mockGrpcClient = new moq::Mock<Fulfillments.FulfillmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetFulfillmentRequest request = new GetFulfillmentRequest
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
            };
            Fulfillment expectedResponse = new Fulfillment
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Fulfillment.Types.GenericWebService(),
                Enabled = true,
                Features =
                {
                    new Fulfillment.Types.Feature(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFulfillment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FulfillmentsClient client = new FulfillmentsClientImpl(mockGrpcClient.Object, null, null);
            Fulfillment response = client.GetFulfillment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFulfillmentAsync()
        {
            moq::Mock<Fulfillments.FulfillmentsClient> mockGrpcClient = new moq::Mock<Fulfillments.FulfillmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetFulfillmentRequest request = new GetFulfillmentRequest
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
            };
            Fulfillment expectedResponse = new Fulfillment
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Fulfillment.Types.GenericWebService(),
                Enabled = true,
                Features =
                {
                    new Fulfillment.Types.Feature(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFulfillmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Fulfillment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FulfillmentsClient client = new FulfillmentsClientImpl(mockGrpcClient.Object, null, null);
            Fulfillment responseCallSettings = await client.GetFulfillmentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Fulfillment responseCancellationToken = await client.GetFulfillmentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFulfillmentResourceNames()
        {
            moq::Mock<Fulfillments.FulfillmentsClient> mockGrpcClient = new moq::Mock<Fulfillments.FulfillmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetFulfillmentRequest request = new GetFulfillmentRequest
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
            };
            Fulfillment expectedResponse = new Fulfillment
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Fulfillment.Types.GenericWebService(),
                Enabled = true,
                Features =
                {
                    new Fulfillment.Types.Feature(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFulfillment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FulfillmentsClient client = new FulfillmentsClientImpl(mockGrpcClient.Object, null, null);
            Fulfillment response = client.GetFulfillment(request.FulfillmentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFulfillmentResourceNamesAsync()
        {
            moq::Mock<Fulfillments.FulfillmentsClient> mockGrpcClient = new moq::Mock<Fulfillments.FulfillmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetFulfillmentRequest request = new GetFulfillmentRequest
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
            };
            Fulfillment expectedResponse = new Fulfillment
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Fulfillment.Types.GenericWebService(),
                Enabled = true,
                Features =
                {
                    new Fulfillment.Types.Feature(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFulfillmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Fulfillment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FulfillmentsClient client = new FulfillmentsClientImpl(mockGrpcClient.Object, null, null);
            Fulfillment responseCallSettings = await client.GetFulfillmentAsync(request.FulfillmentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Fulfillment responseCancellationToken = await client.GetFulfillmentAsync(request.FulfillmentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFulfillmentRequestObject()
        {
            moq::Mock<Fulfillments.FulfillmentsClient> mockGrpcClient = new moq::Mock<Fulfillments.FulfillmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateFulfillmentRequest request = new UpdateFulfillmentRequest
            {
                Fulfillment = new Fulfillment(),
                UpdateMask = new wkt::FieldMask(),
            };
            Fulfillment expectedResponse = new Fulfillment
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Fulfillment.Types.GenericWebService(),
                Enabled = true,
                Features =
                {
                    new Fulfillment.Types.Feature(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFulfillment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FulfillmentsClient client = new FulfillmentsClientImpl(mockGrpcClient.Object, null, null);
            Fulfillment response = client.UpdateFulfillment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFulfillmentRequestObjectAsync()
        {
            moq::Mock<Fulfillments.FulfillmentsClient> mockGrpcClient = new moq::Mock<Fulfillments.FulfillmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateFulfillmentRequest request = new UpdateFulfillmentRequest
            {
                Fulfillment = new Fulfillment(),
                UpdateMask = new wkt::FieldMask(),
            };
            Fulfillment expectedResponse = new Fulfillment
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Fulfillment.Types.GenericWebService(),
                Enabled = true,
                Features =
                {
                    new Fulfillment.Types.Feature(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFulfillmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Fulfillment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FulfillmentsClient client = new FulfillmentsClientImpl(mockGrpcClient.Object, null, null);
            Fulfillment responseCallSettings = await client.UpdateFulfillmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Fulfillment responseCancellationToken = await client.UpdateFulfillmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFulfillment()
        {
            moq::Mock<Fulfillments.FulfillmentsClient> mockGrpcClient = new moq::Mock<Fulfillments.FulfillmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateFulfillmentRequest request = new UpdateFulfillmentRequest
            {
                Fulfillment = new Fulfillment(),
                UpdateMask = new wkt::FieldMask(),
            };
            Fulfillment expectedResponse = new Fulfillment
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Fulfillment.Types.GenericWebService(),
                Enabled = true,
                Features =
                {
                    new Fulfillment.Types.Feature(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFulfillment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FulfillmentsClient client = new FulfillmentsClientImpl(mockGrpcClient.Object, null, null);
            Fulfillment response = client.UpdateFulfillment(request.Fulfillment, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFulfillmentAsync()
        {
            moq::Mock<Fulfillments.FulfillmentsClient> mockGrpcClient = new moq::Mock<Fulfillments.FulfillmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateFulfillmentRequest request = new UpdateFulfillmentRequest
            {
                Fulfillment = new Fulfillment(),
                UpdateMask = new wkt::FieldMask(),
            };
            Fulfillment expectedResponse = new Fulfillment
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Fulfillment.Types.GenericWebService(),
                Enabled = true,
                Features =
                {
                    new Fulfillment.Types.Feature(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFulfillmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Fulfillment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FulfillmentsClient client = new FulfillmentsClientImpl(mockGrpcClient.Object, null, null);
            Fulfillment responseCallSettings = await client.UpdateFulfillmentAsync(request.Fulfillment, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Fulfillment responseCancellationToken = await client.UpdateFulfillmentAsync(request.Fulfillment, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
