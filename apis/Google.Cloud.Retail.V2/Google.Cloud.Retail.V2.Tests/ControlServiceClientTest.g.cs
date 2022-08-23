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

namespace Google.Cloud.Retail.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedControlServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateControlRequestObject()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateControlRequest request = new CreateControlRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Control = new Control(),
                ControlId = "control_idf8204794",
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.CreateControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control response = client.CreateControl(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateControlRequestObjectAsync()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateControlRequest request = new CreateControlRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Control = new Control(),
                ControlId = "control_idf8204794",
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.CreateControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Control>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control responseCallSettings = await client.CreateControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Control responseCancellationToken = await client.CreateControlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateControl()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateControlRequest request = new CreateControlRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Control = new Control(),
                ControlId = "control_idf8204794",
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.CreateControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control response = client.CreateControl(request.Parent, request.Control, request.ControlId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateControlAsync()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateControlRequest request = new CreateControlRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Control = new Control(),
                ControlId = "control_idf8204794",
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.CreateControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Control>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control responseCallSettings = await client.CreateControlAsync(request.Parent, request.Control, request.ControlId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Control responseCancellationToken = await client.CreateControlAsync(request.Parent, request.Control, request.ControlId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateControlResourceNames()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateControlRequest request = new CreateControlRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Control = new Control(),
                ControlId = "control_idf8204794",
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.CreateControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control response = client.CreateControl(request.ParentAsCatalogName, request.Control, request.ControlId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateControlResourceNamesAsync()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateControlRequest request = new CreateControlRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Control = new Control(),
                ControlId = "control_idf8204794",
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.CreateControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Control>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control responseCallSettings = await client.CreateControlAsync(request.ParentAsCatalogName, request.Control, request.ControlId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Control responseCancellationToken = await client.CreateControlAsync(request.ParentAsCatalogName, request.Control, request.ControlId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteControlRequestObject()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteControlRequest request = new DeleteControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteControl(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteControlRequestObjectAsync()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteControlRequest request = new DeleteControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteControlAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteControl()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteControlRequest request = new DeleteControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteControl(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteControlAsync()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteControlRequest request = new DeleteControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteControlAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteControlAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteControlResourceNames()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteControlRequest request = new DeleteControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteControl(request.ControlName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteControlResourceNamesAsync()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteControlRequest request = new DeleteControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteControlAsync(request.ControlName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteControlAsync(request.ControlName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateControlRequestObject()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateControlRequest request = new UpdateControlRequest
            {
                Control = new Control(),
                UpdateMask = new wkt::FieldMask(),
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control response = client.UpdateControl(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateControlRequestObjectAsync()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateControlRequest request = new UpdateControlRequest
            {
                Control = new Control(),
                UpdateMask = new wkt::FieldMask(),
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Control>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control responseCallSettings = await client.UpdateControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Control responseCancellationToken = await client.UpdateControlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateControl()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateControlRequest request = new UpdateControlRequest
            {
                Control = new Control(),
                UpdateMask = new wkt::FieldMask(),
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control response = client.UpdateControl(request.Control, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateControlAsync()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateControlRequest request = new UpdateControlRequest
            {
                Control = new Control(),
                UpdateMask = new wkt::FieldMask(),
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Control>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control responseCallSettings = await client.UpdateControlAsync(request.Control, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Control responseCancellationToken = await client.UpdateControlAsync(request.Control, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetControlRequestObject()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetControlRequest request = new GetControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.GetControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control response = client.GetControl(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetControlRequestObjectAsync()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetControlRequest request = new GetControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.GetControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Control>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control responseCallSettings = await client.GetControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Control responseCancellationToken = await client.GetControlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetControl()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetControlRequest request = new GetControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.GetControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control response = client.GetControl(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetControlAsync()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetControlRequest request = new GetControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.GetControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Control>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control responseCallSettings = await client.GetControlAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Control responseCancellationToken = await client.GetControlAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetControlResourceNames()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetControlRequest request = new GetControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.GetControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control response = client.GetControl(request.ControlName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetControlResourceNamesAsync()
        {
            moq::Mock<ControlService.ControlServiceClient> mockGrpcClient = new moq::Mock<ControlService.ControlServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetControlRequest request = new GetControlRequest
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
            };
            Control expectedResponse = new Control
            {
                ControlName = ControlName.FromProjectLocationCatalogControl("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CONTROL]"),
                DisplayName = "display_name137f65c2",
                Rule = new Rule(),
                AssociatedServingConfigIds =
                {
                    "associated_serving_config_ids14142c72",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                SearchSolutionUseCase =
                {
                    SearchSolutionUseCase.Search,
                },
            };
            mockGrpcClient.Setup(x => x.GetControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Control>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ControlServiceClient client = new ControlServiceClientImpl(mockGrpcClient.Object, null, null);
            Control responseCallSettings = await client.GetControlAsync(request.ControlName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Control responseCancellationToken = await client.GetControlAsync(request.ControlName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
