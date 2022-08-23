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

        [xunit::FactAttribute]
        public void GetCompletionConfigRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCompletionConfigRequest request = new GetCompletionConfigRequest
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            CompletionConfig expectedResponse = new CompletionConfig
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                MatchingOrder = "matching_order5de6c173",
                MaxSuggestions = -1310933316,
                MinPrefixLength = 847347054,
                SuggestionsInputConfig = new CompletionDataInputConfig(),
                LastSuggestionsImportOperation = "last_suggestions_import_operationdd0a9ee0",
                DenylistInputConfig = new CompletionDataInputConfig(),
                LastDenylistImportOperation = "last_denylist_import_operation799a2156",
                AllowlistInputConfig = new CompletionDataInputConfig(),
                LastAllowlistImportOperation = "last_allowlist_import_operation4fb9ccd1",
                AutoLearning = false,
            };
            mockGrpcClient.Setup(x => x.GetCompletionConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CompletionConfig response = client.GetCompletionConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCompletionConfigRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCompletionConfigRequest request = new GetCompletionConfigRequest
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            CompletionConfig expectedResponse = new CompletionConfig
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                MatchingOrder = "matching_order5de6c173",
                MaxSuggestions = -1310933316,
                MinPrefixLength = 847347054,
                SuggestionsInputConfig = new CompletionDataInputConfig(),
                LastSuggestionsImportOperation = "last_suggestions_import_operationdd0a9ee0",
                DenylistInputConfig = new CompletionDataInputConfig(),
                LastDenylistImportOperation = "last_denylist_import_operation799a2156",
                AllowlistInputConfig = new CompletionDataInputConfig(),
                LastAllowlistImportOperation = "last_allowlist_import_operation4fb9ccd1",
                AutoLearning = false,
            };
            mockGrpcClient.Setup(x => x.GetCompletionConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompletionConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CompletionConfig responseCallSettings = await client.GetCompletionConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompletionConfig responseCancellationToken = await client.GetCompletionConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCompletionConfig()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCompletionConfigRequest request = new GetCompletionConfigRequest
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            CompletionConfig expectedResponse = new CompletionConfig
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                MatchingOrder = "matching_order5de6c173",
                MaxSuggestions = -1310933316,
                MinPrefixLength = 847347054,
                SuggestionsInputConfig = new CompletionDataInputConfig(),
                LastSuggestionsImportOperation = "last_suggestions_import_operationdd0a9ee0",
                DenylistInputConfig = new CompletionDataInputConfig(),
                LastDenylistImportOperation = "last_denylist_import_operation799a2156",
                AllowlistInputConfig = new CompletionDataInputConfig(),
                LastAllowlistImportOperation = "last_allowlist_import_operation4fb9ccd1",
                AutoLearning = false,
            };
            mockGrpcClient.Setup(x => x.GetCompletionConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CompletionConfig response = client.GetCompletionConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCompletionConfigAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCompletionConfigRequest request = new GetCompletionConfigRequest
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            CompletionConfig expectedResponse = new CompletionConfig
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                MatchingOrder = "matching_order5de6c173",
                MaxSuggestions = -1310933316,
                MinPrefixLength = 847347054,
                SuggestionsInputConfig = new CompletionDataInputConfig(),
                LastSuggestionsImportOperation = "last_suggestions_import_operationdd0a9ee0",
                DenylistInputConfig = new CompletionDataInputConfig(),
                LastDenylistImportOperation = "last_denylist_import_operation799a2156",
                AllowlistInputConfig = new CompletionDataInputConfig(),
                LastAllowlistImportOperation = "last_allowlist_import_operation4fb9ccd1",
                AutoLearning = false,
            };
            mockGrpcClient.Setup(x => x.GetCompletionConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompletionConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CompletionConfig responseCallSettings = await client.GetCompletionConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompletionConfig responseCancellationToken = await client.GetCompletionConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCompletionConfigResourceNames()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCompletionConfigRequest request = new GetCompletionConfigRequest
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            CompletionConfig expectedResponse = new CompletionConfig
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                MatchingOrder = "matching_order5de6c173",
                MaxSuggestions = -1310933316,
                MinPrefixLength = 847347054,
                SuggestionsInputConfig = new CompletionDataInputConfig(),
                LastSuggestionsImportOperation = "last_suggestions_import_operationdd0a9ee0",
                DenylistInputConfig = new CompletionDataInputConfig(),
                LastDenylistImportOperation = "last_denylist_import_operation799a2156",
                AllowlistInputConfig = new CompletionDataInputConfig(),
                LastAllowlistImportOperation = "last_allowlist_import_operation4fb9ccd1",
                AutoLearning = false,
            };
            mockGrpcClient.Setup(x => x.GetCompletionConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CompletionConfig response = client.GetCompletionConfig(request.CompletionConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCompletionConfigResourceNamesAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCompletionConfigRequest request = new GetCompletionConfigRequest
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            CompletionConfig expectedResponse = new CompletionConfig
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                MatchingOrder = "matching_order5de6c173",
                MaxSuggestions = -1310933316,
                MinPrefixLength = 847347054,
                SuggestionsInputConfig = new CompletionDataInputConfig(),
                LastSuggestionsImportOperation = "last_suggestions_import_operationdd0a9ee0",
                DenylistInputConfig = new CompletionDataInputConfig(),
                LastDenylistImportOperation = "last_denylist_import_operation799a2156",
                AllowlistInputConfig = new CompletionDataInputConfig(),
                LastAllowlistImportOperation = "last_allowlist_import_operation4fb9ccd1",
                AutoLearning = false,
            };
            mockGrpcClient.Setup(x => x.GetCompletionConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompletionConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CompletionConfig responseCallSettings = await client.GetCompletionConfigAsync(request.CompletionConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompletionConfig responseCancellationToken = await client.GetCompletionConfigAsync(request.CompletionConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCompletionConfigRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateCompletionConfigRequest request = new UpdateCompletionConfigRequest
            {
                CompletionConfig = new CompletionConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            CompletionConfig expectedResponse = new CompletionConfig
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                MatchingOrder = "matching_order5de6c173",
                MaxSuggestions = -1310933316,
                MinPrefixLength = 847347054,
                SuggestionsInputConfig = new CompletionDataInputConfig(),
                LastSuggestionsImportOperation = "last_suggestions_import_operationdd0a9ee0",
                DenylistInputConfig = new CompletionDataInputConfig(),
                LastDenylistImportOperation = "last_denylist_import_operation799a2156",
                AllowlistInputConfig = new CompletionDataInputConfig(),
                LastAllowlistImportOperation = "last_allowlist_import_operation4fb9ccd1",
                AutoLearning = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCompletionConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CompletionConfig response = client.UpdateCompletionConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCompletionConfigRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateCompletionConfigRequest request = new UpdateCompletionConfigRequest
            {
                CompletionConfig = new CompletionConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            CompletionConfig expectedResponse = new CompletionConfig
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                MatchingOrder = "matching_order5de6c173",
                MaxSuggestions = -1310933316,
                MinPrefixLength = 847347054,
                SuggestionsInputConfig = new CompletionDataInputConfig(),
                LastSuggestionsImportOperation = "last_suggestions_import_operationdd0a9ee0",
                DenylistInputConfig = new CompletionDataInputConfig(),
                LastDenylistImportOperation = "last_denylist_import_operation799a2156",
                AllowlistInputConfig = new CompletionDataInputConfig(),
                LastAllowlistImportOperation = "last_allowlist_import_operation4fb9ccd1",
                AutoLearning = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCompletionConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompletionConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CompletionConfig responseCallSettings = await client.UpdateCompletionConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompletionConfig responseCancellationToken = await client.UpdateCompletionConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCompletionConfig()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateCompletionConfigRequest request = new UpdateCompletionConfigRequest
            {
                CompletionConfig = new CompletionConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            CompletionConfig expectedResponse = new CompletionConfig
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                MatchingOrder = "matching_order5de6c173",
                MaxSuggestions = -1310933316,
                MinPrefixLength = 847347054,
                SuggestionsInputConfig = new CompletionDataInputConfig(),
                LastSuggestionsImportOperation = "last_suggestions_import_operationdd0a9ee0",
                DenylistInputConfig = new CompletionDataInputConfig(),
                LastDenylistImportOperation = "last_denylist_import_operation799a2156",
                AllowlistInputConfig = new CompletionDataInputConfig(),
                LastAllowlistImportOperation = "last_allowlist_import_operation4fb9ccd1",
                AutoLearning = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCompletionConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CompletionConfig response = client.UpdateCompletionConfig(request.CompletionConfig, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCompletionConfigAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateCompletionConfigRequest request = new UpdateCompletionConfigRequest
            {
                CompletionConfig = new CompletionConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            CompletionConfig expectedResponse = new CompletionConfig
            {
                CompletionConfigName = CompletionConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                MatchingOrder = "matching_order5de6c173",
                MaxSuggestions = -1310933316,
                MinPrefixLength = 847347054,
                SuggestionsInputConfig = new CompletionDataInputConfig(),
                LastSuggestionsImportOperation = "last_suggestions_import_operationdd0a9ee0",
                DenylistInputConfig = new CompletionDataInputConfig(),
                LastDenylistImportOperation = "last_denylist_import_operation799a2156",
                AllowlistInputConfig = new CompletionDataInputConfig(),
                LastAllowlistImportOperation = "last_allowlist_import_operation4fb9ccd1",
                AutoLearning = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCompletionConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompletionConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CompletionConfig responseCallSettings = await client.UpdateCompletionConfigAsync(request.CompletionConfig, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompletionConfig responseCancellationToken = await client.UpdateCompletionConfigAsync(request.CompletionConfig, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAttributesConfigRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAttributesConfigRequest request = new GetAttributesConfigRequest
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.GetAttributesConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig response = client.GetAttributesConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAttributesConfigRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAttributesConfigRequest request = new GetAttributesConfigRequest
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.GetAttributesConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AttributesConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig responseCallSettings = await client.GetAttributesConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AttributesConfig responseCancellationToken = await client.GetAttributesConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAttributesConfig()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAttributesConfigRequest request = new GetAttributesConfigRequest
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.GetAttributesConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig response = client.GetAttributesConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAttributesConfigAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAttributesConfigRequest request = new GetAttributesConfigRequest
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.GetAttributesConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AttributesConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig responseCallSettings = await client.GetAttributesConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AttributesConfig responseCancellationToken = await client.GetAttributesConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAttributesConfigResourceNames()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAttributesConfigRequest request = new GetAttributesConfigRequest
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.GetAttributesConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig response = client.GetAttributesConfig(request.AttributesConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAttributesConfigResourceNamesAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAttributesConfigRequest request = new GetAttributesConfigRequest
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.GetAttributesConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AttributesConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig responseCallSettings = await client.GetAttributesConfigAsync(request.AttributesConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AttributesConfig responseCancellationToken = await client.GetAttributesConfigAsync(request.AttributesConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAttributesConfigRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateAttributesConfigRequest request = new UpdateAttributesConfigRequest
            {
                AttributesConfig = new AttributesConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.UpdateAttributesConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig response = client.UpdateAttributesConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAttributesConfigRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateAttributesConfigRequest request = new UpdateAttributesConfigRequest
            {
                AttributesConfig = new AttributesConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.UpdateAttributesConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AttributesConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig responseCallSettings = await client.UpdateAttributesConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AttributesConfig responseCancellationToken = await client.UpdateAttributesConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAttributesConfig()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateAttributesConfigRequest request = new UpdateAttributesConfigRequest
            {
                AttributesConfig = new AttributesConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.UpdateAttributesConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig response = client.UpdateAttributesConfig(request.AttributesConfig, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAttributesConfigAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateAttributesConfigRequest request = new UpdateAttributesConfigRequest
            {
                AttributesConfig = new AttributesConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.UpdateAttributesConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AttributesConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig responseCallSettings = await client.UpdateAttributesConfigAsync(request.AttributesConfig, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AttributesConfig responseCancellationToken = await client.UpdateAttributesConfigAsync(request.AttributesConfig, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddCatalogAttributeRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            AddCatalogAttributeRequest request = new AddCatalogAttributeRequest
            {
                AttributesConfigAsAttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttribute = new CatalogAttribute(),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.AddCatalogAttribute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig response = client.AddCatalogAttribute(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddCatalogAttributeRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            AddCatalogAttributeRequest request = new AddCatalogAttributeRequest
            {
                AttributesConfigAsAttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttribute = new CatalogAttribute(),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.AddCatalogAttributeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AttributesConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig responseCallSettings = await client.AddCatalogAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AttributesConfig responseCancellationToken = await client.AddCatalogAttributeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveCatalogAttributeRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            RemoveCatalogAttributeRequest request = new RemoveCatalogAttributeRequest
            {
                AttributesConfigAsAttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Key = "key8a0b6e3c",
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.RemoveCatalogAttribute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig response = client.RemoveCatalogAttribute(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveCatalogAttributeRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            RemoveCatalogAttributeRequest request = new RemoveCatalogAttributeRequest
            {
                AttributesConfigAsAttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Key = "key8a0b6e3c",
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.RemoveCatalogAttributeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AttributesConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig responseCallSettings = await client.RemoveCatalogAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AttributesConfig responseCancellationToken = await client.RemoveCatalogAttributeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReplaceCatalogAttributeRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            ReplaceCatalogAttributeRequest request = new ReplaceCatalogAttributeRequest
            {
                AttributesConfigAsAttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttribute = new CatalogAttribute(),
                UpdateMask = new wkt::FieldMask(),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.ReplaceCatalogAttribute(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig response = client.ReplaceCatalogAttribute(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReplaceCatalogAttributeRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            ReplaceCatalogAttributeRequest request = new ReplaceCatalogAttributeRequest
            {
                AttributesConfigAsAttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttribute = new CatalogAttribute(),
                UpdateMask = new wkt::FieldMask(),
            };
            AttributesConfig expectedResponse = new AttributesConfig
            {
                AttributesConfigName = AttributesConfigName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CatalogAttribute()
                    },
                },
                AttributeConfigLevel = AttributeConfigLevel.ProductLevelAttributeConfig,
            };
            mockGrpcClient.Setup(x => x.ReplaceCatalogAttributeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AttributesConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            AttributesConfig responseCallSettings = await client.ReplaceCatalogAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AttributesConfig responseCancellationToken = await client.ReplaceCatalogAttributeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
