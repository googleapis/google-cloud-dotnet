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
    public sealed class GeneratedServingConfigServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateServingConfigRequestObject()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateServingConfigRequest request = new CreateServingConfigRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                ServingConfig = new ServingConfig(),
                ServingConfigId = "serving_config_idaecf1126",
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateServingConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.CreateServingConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServingConfigRequestObjectAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateServingConfigRequest request = new CreateServingConfigRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                ServingConfig = new ServingConfig(),
                ServingConfigId = "serving_config_idaecf1126",
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateServingConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.CreateServingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.CreateServingConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServingConfig()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateServingConfigRequest request = new CreateServingConfigRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                ServingConfig = new ServingConfig(),
                ServingConfigId = "serving_config_idaecf1126",
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateServingConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.CreateServingConfig(request.Parent, request.ServingConfig, request.ServingConfigId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServingConfigAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateServingConfigRequest request = new CreateServingConfigRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                ServingConfig = new ServingConfig(),
                ServingConfigId = "serving_config_idaecf1126",
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateServingConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.CreateServingConfigAsync(request.Parent, request.ServingConfig, request.ServingConfigId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.CreateServingConfigAsync(request.Parent, request.ServingConfig, request.ServingConfigId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServingConfigResourceNames()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateServingConfigRequest request = new CreateServingConfigRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                ServingConfig = new ServingConfig(),
                ServingConfigId = "serving_config_idaecf1126",
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateServingConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.CreateServingConfig(request.ParentAsCatalogName, request.ServingConfig, request.ServingConfigId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServingConfigResourceNamesAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateServingConfigRequest request = new CreateServingConfigRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                ServingConfig = new ServingConfig(),
                ServingConfigId = "serving_config_idaecf1126",
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.CreateServingConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.CreateServingConfigAsync(request.ParentAsCatalogName, request.ServingConfig, request.ServingConfigId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.CreateServingConfigAsync(request.ParentAsCatalogName, request.ServingConfig, request.ServingConfigId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServingConfigRequestObject()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteServingConfigRequest request = new DeleteServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServingConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteServingConfig(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServingConfigRequestObjectAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteServingConfigRequest request = new DeleteServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServingConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteServingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServingConfigAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServingConfig()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteServingConfigRequest request = new DeleteServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServingConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteServingConfig(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServingConfigAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteServingConfigRequest request = new DeleteServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServingConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteServingConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServingConfigAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServingConfigResourceNames()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteServingConfigRequest request = new DeleteServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServingConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteServingConfig(request.ServingConfigName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServingConfigResourceNamesAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteServingConfigRequest request = new DeleteServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServingConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteServingConfigAsync(request.ServingConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServingConfigAsync(request.ServingConfigName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateServingConfigRequestObject()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateServingConfigRequest request = new UpdateServingConfigRequest
            {
                ServingConfig = new ServingConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.UpdateServingConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.UpdateServingConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateServingConfigRequestObjectAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateServingConfigRequest request = new UpdateServingConfigRequest
            {
                ServingConfig = new ServingConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.UpdateServingConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.UpdateServingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.UpdateServingConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateServingConfig()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateServingConfigRequest request = new UpdateServingConfigRequest
            {
                ServingConfig = new ServingConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.UpdateServingConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.UpdateServingConfig(request.ServingConfig, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateServingConfigAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateServingConfigRequest request = new UpdateServingConfigRequest
            {
                ServingConfig = new ServingConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.UpdateServingConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.UpdateServingConfigAsync(request.ServingConfig, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.UpdateServingConfigAsync(request.ServingConfig, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServingConfigRequestObject()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetServingConfigRequest request = new GetServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.GetServingConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.GetServingConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServingConfigRequestObjectAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetServingConfigRequest request = new GetServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.GetServingConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.GetServingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.GetServingConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServingConfig()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetServingConfigRequest request = new GetServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.GetServingConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.GetServingConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServingConfigAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetServingConfigRequest request = new GetServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.GetServingConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.GetServingConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.GetServingConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServingConfigResourceNames()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetServingConfigRequest request = new GetServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.GetServingConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.GetServingConfig(request.ServingConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServingConfigResourceNamesAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetServingConfigRequest request = new GetServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.GetServingConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.GetServingConfigAsync(request.ServingConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.GetServingConfigAsync(request.ServingConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddControlRequestObject()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            AddControlRequest request = new AddControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                ControlId = "control_idf8204794",
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.AddControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.AddControl(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddControlRequestObjectAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            AddControlRequest request = new AddControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                ControlId = "control_idf8204794",
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.AddControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.AddControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.AddControlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddControl()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            AddControlRequest request = new AddControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.AddControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.AddControl(request.ServingConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddControlAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            AddControlRequest request = new AddControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.AddControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.AddControlAsync(request.ServingConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.AddControlAsync(request.ServingConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddControlResourceNames()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            AddControlRequest request = new AddControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.AddControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.AddControl(request.ServingConfigAsServingConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddControlResourceNamesAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            AddControlRequest request = new AddControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.AddControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.AddControlAsync(request.ServingConfigAsServingConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.AddControlAsync(request.ServingConfigAsServingConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveControlRequestObject()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            RemoveControlRequest request = new RemoveControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                ControlId = "control_idf8204794",
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.RemoveControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.RemoveControl(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveControlRequestObjectAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            RemoveControlRequest request = new RemoveControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                ControlId = "control_idf8204794",
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.RemoveControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.RemoveControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.RemoveControlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveControl()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            RemoveControlRequest request = new RemoveControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.RemoveControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.RemoveControl(request.ServingConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveControlAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            RemoveControlRequest request = new RemoveControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.RemoveControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.RemoveControlAsync(request.ServingConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.RemoveControlAsync(request.ServingConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveControlResourceNames()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            RemoveControlRequest request = new RemoveControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.RemoveControl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig response = client.RemoveControl(request.ServingConfigAsServingConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveControlResourceNamesAsync()
        {
            moq::Mock<ServingConfigService.ServingConfigServiceClient> mockGrpcClient = new moq::Mock<ServingConfigService.ServingConfigServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            RemoveControlRequest request = new RemoveControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            ServingConfig expectedResponse = new ServingConfig
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                DisplayName = "display_name137f65c2",
                ModelId = "model_id8abf7c47",
                PriceRerankingLevel = "price_reranking_level4f3d56be",
                FacetControlIds =
                {
                    "facet_control_ids14ad7d48",
                },
                DynamicFacetSpec = new SearchRequest.Types.DynamicFacetSpec(),
                BoostControlIds =
                {
                    "boost_control_ids2d8a035e",
                },
                DiversityLevel = "diversity_levelbe151879",
                FilterControlIds =
                {
                    "filter_control_idsc2ab4290",
                },
                RedirectControlIds =
                {
                    "redirect_control_ids49c2dc8e",
                },
                OnewaySynonymsControlIds =
                {
                    "oneway_synonyms_control_ids542ae6af",
                },
                DoNotAssociateControlIds =
                {
                    "do_not_associate_control_ids5f195019",
                },
                ReplacementControlIds =
                {
                    "replacement_control_ids00a409c5",
                },
                IgnoreControlIds =
                {
                    "ignore_control_ids633cf274",
                },
                EnableCategoryFilterLevel = "enable_category_filter_level87ffccf5",
                TwowaySynonymsControlIds =
                {
                    "twoway_synonyms_control_ids6642fff6",
                },
                SolutionTypes =
                {
                    SolutionType.Recommendation,
                },
                PersonalizationSpec = new SearchRequest.Types.PersonalizationSpec(),
            };
            mockGrpcClient.Setup(x => x.RemoveControlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServingConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServingConfigServiceClient client = new ServingConfigServiceClientImpl(mockGrpcClient.Object, null, null);
            ServingConfig responseCallSettings = await client.RemoveControlAsync(request.ServingConfigAsServingConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServingConfig responseCancellationToken = await client.RemoveControlAsync(request.ServingConfigAsServingConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
