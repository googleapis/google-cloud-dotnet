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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.RecommendationEngine.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCatalogServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateCatalogItemRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCatalogItemRequest request = new CreateCatalogItemRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogItem = new CatalogItem(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.CreateCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem response = client.CreateCatalogItem(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCatalogItemRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCatalogItemRequest request = new CreateCatalogItemRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogItem = new CatalogItem(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.CreateCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CatalogItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem responseCallSettings = await client.CreateCatalogItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CatalogItem responseCancellationToken = await client.CreateCatalogItemAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCatalogItem()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCatalogItemRequest request = new CreateCatalogItemRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogItem = new CatalogItem(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.CreateCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem response = client.CreateCatalogItem(request.Parent, request.CatalogItem);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCatalogItemAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCatalogItemRequest request = new CreateCatalogItemRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogItem = new CatalogItem(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.CreateCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CatalogItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem responseCallSettings = await client.CreateCatalogItemAsync(request.Parent, request.CatalogItem, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CatalogItem responseCancellationToken = await client.CreateCatalogItemAsync(request.Parent, request.CatalogItem, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCatalogItemResourceNames()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCatalogItemRequest request = new CreateCatalogItemRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogItem = new CatalogItem(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.CreateCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem response = client.CreateCatalogItem(request.ParentAsCatalogName, request.CatalogItem);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCatalogItemResourceNamesAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCatalogItemRequest request = new CreateCatalogItemRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogItem = new CatalogItem(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.CreateCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CatalogItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem responseCallSettings = await client.CreateCatalogItemAsync(request.ParentAsCatalogName, request.CatalogItem, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CatalogItem responseCancellationToken = await client.CreateCatalogItemAsync(request.ParentAsCatalogName, request.CatalogItem, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCatalogItemRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCatalogItemRequest request = new GetCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.GetCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem response = client.GetCatalogItem(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCatalogItemRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCatalogItemRequest request = new GetCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.GetCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CatalogItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem responseCallSettings = await client.GetCatalogItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CatalogItem responseCancellationToken = await client.GetCatalogItemAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCatalogItem()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCatalogItemRequest request = new GetCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.GetCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem response = client.GetCatalogItem(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCatalogItemAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCatalogItemRequest request = new GetCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.GetCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CatalogItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem responseCallSettings = await client.GetCatalogItemAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CatalogItem responseCancellationToken = await client.GetCatalogItemAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCatalogItemResourceNames()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCatalogItemRequest request = new GetCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.GetCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem response = client.GetCatalogItem(request.CatalogItemPathName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCatalogItemResourceNamesAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCatalogItemRequest request = new GetCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.GetCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CatalogItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem responseCallSettings = await client.GetCatalogItemAsync(request.CatalogItemPathName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CatalogItem responseCancellationToken = await client.GetCatalogItemAsync(request.CatalogItemPathName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCatalogItemRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCatalogItemRequest request = new UpdateCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
                CatalogItem = new CatalogItem(),
                UpdateMask = new wkt::FieldMask(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.UpdateCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem response = client.UpdateCatalogItem(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCatalogItemRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCatalogItemRequest request = new UpdateCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
                CatalogItem = new CatalogItem(),
                UpdateMask = new wkt::FieldMask(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.UpdateCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CatalogItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem responseCallSettings = await client.UpdateCatalogItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CatalogItem responseCancellationToken = await client.UpdateCatalogItemAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCatalogItem()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCatalogItemRequest request = new UpdateCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
                CatalogItem = new CatalogItem(),
                UpdateMask = new wkt::FieldMask(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.UpdateCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem response = client.UpdateCatalogItem(request.Name, request.CatalogItem, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCatalogItemAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCatalogItemRequest request = new UpdateCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
                CatalogItem = new CatalogItem(),
                UpdateMask = new wkt::FieldMask(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.UpdateCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CatalogItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem responseCallSettings = await client.UpdateCatalogItemAsync(request.Name, request.CatalogItem, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CatalogItem responseCancellationToken = await client.UpdateCatalogItemAsync(request.Name, request.CatalogItem, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCatalogItemResourceNames()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCatalogItemRequest request = new UpdateCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
                CatalogItem = new CatalogItem(),
                UpdateMask = new wkt::FieldMask(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.UpdateCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem response = client.UpdateCatalogItem(request.CatalogItemPathName, request.CatalogItem, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCatalogItemResourceNamesAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCatalogItemRequest request = new UpdateCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
                CatalogItem = new CatalogItem(),
                UpdateMask = new wkt::FieldMask(),
            };
            CatalogItem expectedResponse = new CatalogItem
            {
                Id = "id74b70bb8",
                CategoryHierarchies =
                {
                    new CatalogItem.Types.CategoryHierarchy(),
                },
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                ItemAttributes = new FeatureMap(),
                LanguageCode = "language_code2f6c7160",
                Tags = { "tags52c47ad5", },
                ItemGroupId = "item_group_id08a4c0f5",
                ProductMetadata = new ProductCatalogItem(),
            };
            mockGrpcClient.Setup(x => x.UpdateCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CatalogItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            CatalogItem responseCallSettings = await client.UpdateCatalogItemAsync(request.CatalogItemPathName, request.CatalogItem, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CatalogItem responseCancellationToken = await client.UpdateCatalogItemAsync(request.CatalogItemPathName, request.CatalogItem, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCatalogItemRequestObject()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCatalogItemRequest request = new DeleteCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteCatalogItem(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCatalogItemRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCatalogItemRequest request = new DeleteCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteCatalogItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCatalogItemAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCatalogItem()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCatalogItemRequest request = new DeleteCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteCatalogItem(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCatalogItemAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCatalogItemRequest request = new DeleteCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteCatalogItemAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCatalogItemAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCatalogItemResourceNames()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCatalogItemRequest request = new DeleteCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCatalogItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteCatalogItem(request.CatalogItemPathName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCatalogItemResourceNamesAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCatalogItemRequest request = new DeleteCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCatalogItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteCatalogItemAsync(request.CatalogItemPathName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCatalogItemAsync(request.CatalogItemPathName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
