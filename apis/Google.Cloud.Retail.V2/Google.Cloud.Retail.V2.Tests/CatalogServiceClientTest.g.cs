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
    public sealed class GeneratedCatalogServiceClientTest
    {
        [xunit::FactAttribute]
        public void UpdateCatalogRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateCatalogRequest request = new UpdateCatalogRequest
            {
                Catalog = new Catalog(),
                UpdateMask = new wkt::FieldMask(),
            };
            Catalog expectedResponse = new Catalog
            {
                CatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                DisplayName = "display_name137f65c2",
                ProductLevelConfig = new ProductLevelConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateCatalog(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            Catalog response = client.UpdateCatalog(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCatalogRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateCatalogRequest request = new UpdateCatalogRequest
            {
                Catalog = new Catalog(),
                UpdateMask = new wkt::FieldMask(),
            };
            Catalog expectedResponse = new Catalog
            {
                CatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                DisplayName = "display_name137f65c2",
                ProductLevelConfig = new ProductLevelConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateCatalogAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Catalog>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            Catalog responseCallSettings = await client.UpdateCatalogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Catalog responseCancellationToken = await client.UpdateCatalogAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCatalog()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateCatalogRequest request = new UpdateCatalogRequest
            {
                Catalog = new Catalog(),
                UpdateMask = new wkt::FieldMask(),
            };
            Catalog expectedResponse = new Catalog
            {
                CatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                DisplayName = "display_name137f65c2",
                ProductLevelConfig = new ProductLevelConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateCatalog(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            Catalog response = client.UpdateCatalog(request.Catalog, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCatalogAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateCatalogRequest request = new UpdateCatalogRequest
            {
                Catalog = new Catalog(),
                UpdateMask = new wkt::FieldMask(),
            };
            Catalog expectedResponse = new Catalog
            {
                CatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                DisplayName = "display_name137f65c2",
                ProductLevelConfig = new ProductLevelConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateCatalogAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Catalog>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            Catalog responseCallSettings = await client.UpdateCatalogAsync(request.Catalog, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Catalog responseCancellationToken = await client.UpdateCatalogAsync(request.Catalog, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetDefaultBranchRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            SetDefaultBranchRequest request = new SetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                BranchIdAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Note = "noteca53d6aa",
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SetDefaultBranch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            client.SetDefaultBranch(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetDefaultBranchRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            SetDefaultBranchRequest request = new SetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                BranchIdAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Note = "noteca53d6aa",
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SetDefaultBranchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.SetDefaultBranchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.SetDefaultBranchAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetDefaultBranch()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            SetDefaultBranchRequest request = new SetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SetDefaultBranch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            client.SetDefaultBranch(request.Catalog);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetDefaultBranchAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            SetDefaultBranchRequest request = new SetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SetDefaultBranchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.SetDefaultBranchAsync(request.Catalog, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.SetDefaultBranchAsync(request.Catalog, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetDefaultBranchResourceNames()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            SetDefaultBranchRequest request = new SetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SetDefaultBranch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            client.SetDefaultBranch(request.CatalogAsCatalogName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetDefaultBranchResourceNamesAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            SetDefaultBranchRequest request = new SetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SetDefaultBranchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.SetDefaultBranchAsync(request.CatalogAsCatalogName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.SetDefaultBranchAsync(request.CatalogAsCatalogName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDefaultBranchRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDefaultBranchRequest request = new GetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            GetDefaultBranchResponse expectedResponse = new GetDefaultBranchResponse
            {
                BranchAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                SetTime = new wkt::Timestamp(),
                Note = "noteca53d6aa",
            };
            mockGrpcClient.Setup(x => x.GetDefaultBranch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            GetDefaultBranchResponse response = client.GetDefaultBranch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDefaultBranchRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDefaultBranchRequest request = new GetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            GetDefaultBranchResponse expectedResponse = new GetDefaultBranchResponse
            {
                BranchAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                SetTime = new wkt::Timestamp(),
                Note = "noteca53d6aa",
            };
            mockGrpcClient.Setup(x => x.GetDefaultBranchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetDefaultBranchResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            GetDefaultBranchResponse responseCallSettings = await client.GetDefaultBranchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetDefaultBranchResponse responseCancellationToken = await client.GetDefaultBranchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDefaultBranch()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDefaultBranchRequest request = new GetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            GetDefaultBranchResponse expectedResponse = new GetDefaultBranchResponse
            {
                BranchAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                SetTime = new wkt::Timestamp(),
                Note = "noteca53d6aa",
            };
            mockGrpcClient.Setup(x => x.GetDefaultBranch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            GetDefaultBranchResponse response = client.GetDefaultBranch(request.Catalog);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDefaultBranchAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDefaultBranchRequest request = new GetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            GetDefaultBranchResponse expectedResponse = new GetDefaultBranchResponse
            {
                BranchAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                SetTime = new wkt::Timestamp(),
                Note = "noteca53d6aa",
            };
            mockGrpcClient.Setup(x => x.GetDefaultBranchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetDefaultBranchResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            GetDefaultBranchResponse responseCallSettings = await client.GetDefaultBranchAsync(request.Catalog, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetDefaultBranchResponse responseCancellationToken = await client.GetDefaultBranchAsync(request.Catalog, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDefaultBranchResourceNames()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDefaultBranchRequest request = new GetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            GetDefaultBranchResponse expectedResponse = new GetDefaultBranchResponse
            {
                BranchAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                SetTime = new wkt::Timestamp(),
                Note = "noteca53d6aa",
            };
            mockGrpcClient.Setup(x => x.GetDefaultBranch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            GetDefaultBranchResponse response = client.GetDefaultBranch(request.CatalogAsCatalogName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDefaultBranchResourceNamesAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDefaultBranchRequest request = new GetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            GetDefaultBranchResponse expectedResponse = new GetDefaultBranchResponse
            {
                BranchAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                SetTime = new wkt::Timestamp(),
                Note = "noteca53d6aa",
            };
            mockGrpcClient.Setup(x => x.GetDefaultBranchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetDefaultBranchResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            GetDefaultBranchResponse responseCallSettings = await client.GetDefaultBranchAsync(request.CatalogAsCatalogName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetDefaultBranchResponse responseCancellationToken = await client.GetDefaultBranchAsync(request.CatalogAsCatalogName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
