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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Retail.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedProductServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateProductRequestObject()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.CreateProduct(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProductRequestObjectAsync()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.CreateProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.CreateProductAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProduct()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.CreateProduct(request.Parent, request.Product, request.ProductId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProductAsync()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.CreateProductAsync(request.Parent, request.Product, request.ProductId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.CreateProductAsync(request.Parent, request.Product, request.ProductId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProductResourceNames()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.CreateProduct(request.ParentAsBranchName, request.Product, request.ProductId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProductResourceNamesAsync()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.CreateProductAsync(request.ParentAsBranchName, request.Product, request.ProductId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.CreateProductAsync(request.ParentAsBranchName, request.Product, request.ProductId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProductRequestObject()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.GetProduct(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProductRequestObjectAsync()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.GetProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.GetProductAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProduct()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.GetProduct(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProductAsync()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.GetProductAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.GetProductAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProductResourceNames()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.GetProduct(request.ProductName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProductResourceNamesAsync()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.GetProductAsync(request.ProductName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.GetProductAsync(request.ProductName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProductRequestObject()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.UpdateProduct(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateProductRequestObjectAsync()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.UpdateProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.UpdateProductAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProduct()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new wkt::FieldMask(),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.UpdateProduct(request.Product, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateProductAsync()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new wkt::FieldMask(),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Id = "id74b70bb8",
                Type = Product.Types.Type.Collection,
                PrimaryProductId = "primary_product_id96202300",
                CollectionMemberIds =
                {
                    "collection_member_ids3c9b26a9",
                },
                Gtin = "gtin79aaf991",
                Categories =
                {
                    "categoriesb4ccb5b0",
                },
                Title = "title17dbd3d5",
                Brands = { "brandsd5b53f63", },
                Description = "description2cf9da67",
                LanguageCode = "language_code2f6c7160",
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                Tags = { "tags52c47ad5", },
                PriceInfo = new PriceInfo(),
                Rating = new Rating(),
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                AvailableTime = new wkt::Timestamp(),
                Availability = Product.Types.Availability.InStock,
                AvailableQuantity = 719656040,
                FulfillmentInfo =
                {
                    new FulfillmentInfo(),
                },
                Uri = "uri3db70593",
                Images = { new Image(), },
                Audience = new Audience(),
                ColorInfo = new ColorInfo(),
                Sizes = { "sizes8e1627b0", },
                Materials =
                {
                    "materials38c02a2d",
                },
                Patterns =
                {
                    "patternsb451ea9d",
                },
                Conditions =
                {
                    "conditionsec99b3b5",
                },
                RetrievableFields = new wkt::FieldMask(),
                Variants = { new Product(), },
                PublishTime = new wkt::Timestamp(),
                Promotions = { new Promotion(), },
                LocalInventories =
                {
                    new LocalInventory(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.UpdateProductAsync(request.Product, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.UpdateProductAsync(request.Product, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProductRequestObject()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteProduct(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProductRequestObjectAsync()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProductAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProduct()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteProduct(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProductAsync()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteProductAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProductAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProductResourceNames()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteProduct(request.ProductName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProductResourceNamesAsync()
        {
            moq::Mock<ProductService.ProductServiceClient> mockGrpcClient = new moq::Mock<ProductService.ProductServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductServiceClient client = new ProductServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteProductAsync(request.ProductName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProductAsync(request.ProductName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
