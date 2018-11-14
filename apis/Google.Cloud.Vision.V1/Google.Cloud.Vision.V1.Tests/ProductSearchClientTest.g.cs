// Copyright 2018 Google LLC
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

namespace Google.Cloud.Vision.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Vision.V1;
    using Google.LongRunning;
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
    public class GeneratedProductSearchClientTest
    {
        [Fact]
        public void CreateProduct()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateProductRequest expectedRequest = new CreateProductRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
                ProductId = "productId1753008747",
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.CreateProduct(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            Product product = new Product();
            string productId = "productId1753008747";
            Product response = client.CreateProduct(parent, product, productId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateProductAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateProductRequest expectedRequest = new CreateProductRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
                ProductId = "productId1753008747",
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.CreateProductAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Product>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            Product product = new Product();
            string productId = "productId1753008747";
            Product response = await client.CreateProductAsync(parent, product, productId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateProduct2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.CreateProduct(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            Product response = client.CreateProduct(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateProductAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.CreateProductAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Product>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            Product response = await client.CreateProductAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetProduct()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetProductRequest expectedRequest = new GetProductRequest
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.GetProduct(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductName name = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            Product response = client.GetProduct(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetProductAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetProductRequest expectedRequest = new GetProductRequest
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.GetProductAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Product>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductName name = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            Product response = await client.GetProductAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetProduct2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.GetProduct(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            Product response = client.GetProduct(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetProductAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.GetProductAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Product>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            Product response = await client.GetProductAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateProduct()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateProductRequest expectedRequest = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new FieldMask(),
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.UpdateProduct(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            Product product = new Product();
            FieldMask updateMask = new FieldMask();
            Product response = client.UpdateProduct(product, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateProductAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateProductRequest expectedRequest = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new FieldMask(),
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.UpdateProductAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Product>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            Product product = new Product();
            FieldMask updateMask = new FieldMask();
            Product response = await client.UpdateProductAsync(product, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateProduct2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.UpdateProduct(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            Product response = client.UpdateProduct(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateProductAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
            };
            Product expectedResponse = new Product
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ProductCategory = "productCategory-1607451058",
            };
            mockGrpcClient.Setup(x => x.UpdateProductAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Product>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            Product response = await client.UpdateProductAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteProduct()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteProductRequest expectedRequest = new DeleteProductRequest
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProduct(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductName name = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            client.DeleteProduct(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteProductAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteProductRequest expectedRequest = new DeleteProductRequest
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProductAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductName name = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            await client.DeleteProductAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteProduct2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProduct(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            client.DeleteProduct(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteProductAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProductAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            await client.DeleteProductAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetReferenceImage()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetReferenceImageRequest expectedRequest = new GetReferenceImageRequest
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri116076",
            };
            mockGrpcClient.Setup(x => x.GetReferenceImage(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ReferenceImageName name = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]");
            ReferenceImage response = client.GetReferenceImage(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetReferenceImageAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetReferenceImageRequest expectedRequest = new GetReferenceImageRequest
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri116076",
            };
            mockGrpcClient.Setup(x => x.GetReferenceImageAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReferenceImage>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ReferenceImageName name = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]");
            ReferenceImage response = await client.GetReferenceImageAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetReferenceImage2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri116076",
            };
            mockGrpcClient.Setup(x => x.GetReferenceImage(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ReferenceImage response = client.GetReferenceImage(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetReferenceImageAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri116076",
            };
            mockGrpcClient.Setup(x => x.GetReferenceImageAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReferenceImage>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ReferenceImage response = await client.GetReferenceImageAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteReferenceImage()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteReferenceImageRequest expectedRequest = new DeleteReferenceImageRequest
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteReferenceImage(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ReferenceImageName name = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]");
            client.DeleteReferenceImage(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteReferenceImageAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteReferenceImageRequest expectedRequest = new DeleteReferenceImageRequest
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteReferenceImageAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ReferenceImageName name = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]");
            await client.DeleteReferenceImageAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteReferenceImage2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteReferenceImage(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            client.DeleteReferenceImage(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteReferenceImageAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteReferenceImageAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            await client.DeleteReferenceImageAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateReferenceImage()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateReferenceImageRequest expectedRequest = new CreateReferenceImageRequest
            {
                ParentAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
                ReferenceImageId = "referenceImageId1946713331",
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri116076",
            };
            mockGrpcClient.Setup(x => x.CreateReferenceImage(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductName parent = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            ReferenceImage referenceImage = new ReferenceImage();
            string referenceImageId = "referenceImageId1946713331";
            ReferenceImage response = client.CreateReferenceImage(parent, referenceImage, referenceImageId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateReferenceImageAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateReferenceImageRequest expectedRequest = new CreateReferenceImageRequest
            {
                ParentAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
                ReferenceImageId = "referenceImageId1946713331",
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri116076",
            };
            mockGrpcClient.Setup(x => x.CreateReferenceImageAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReferenceImage>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductName parent = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            ReferenceImage referenceImage = new ReferenceImage();
            string referenceImageId = "referenceImageId1946713331";
            ReferenceImage response = await client.CreateReferenceImageAsync(parent, referenceImage, referenceImageId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateReferenceImage2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                ParentAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri116076",
            };
            mockGrpcClient.Setup(x => x.CreateReferenceImage(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ReferenceImage response = client.CreateReferenceImage(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateReferenceImageAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                ParentAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = new ReferenceImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri116076",
            };
            mockGrpcClient.Setup(x => x.CreateReferenceImageAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReferenceImage>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ReferenceImage response = await client.CreateReferenceImageAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateProductSet()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateProductSetRequest expectedRequest = new CreateProductSetRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
                ProductSetId = "productSetId4216680",
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateProductSet(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            ProductSet productSet = new ProductSet();
            string productSetId = "productSetId4216680";
            ProductSet response = client.CreateProductSet(parent, productSet, productSetId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateProductSetAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateProductSetRequest expectedRequest = new CreateProductSetRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
                ProductSetId = "productSetId4216680",
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateProductSetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ProductSet>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            ProductSet productSet = new ProductSet();
            string productSetId = "productSetId4216680";
            ProductSet response = await client.CreateProductSetAsync(parent, productSet, productSetId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateProductSet2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateProductSet(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSet response = client.CreateProductSet(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateProductSetAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateProductSetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ProductSet>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSet response = await client.CreateProductSetAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetProductSet()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetProductSetRequest expectedRequest = new GetProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetProductSet(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSetName name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            ProductSet response = client.GetProductSet(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetProductSetAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetProductSetRequest expectedRequest = new GetProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetProductSetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ProductSet>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSetName name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            ProductSet response = await client.GetProductSetAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetProductSet2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetProductSetRequest request = new GetProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetProductSet(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSet response = client.GetProductSet(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetProductSetAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetProductSetRequest request = new GetProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetProductSetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ProductSet>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSet response = await client.GetProductSetAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateProductSet()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateProductSetRequest expectedRequest = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
                UpdateMask = new FieldMask(),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateProductSet(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSet productSet = new ProductSet();
            FieldMask updateMask = new FieldMask();
            ProductSet response = client.UpdateProductSet(productSet, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateProductSetAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateProductSetRequest expectedRequest = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
                UpdateMask = new FieldMask(),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateProductSetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ProductSet>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSet productSet = new ProductSet();
            FieldMask updateMask = new FieldMask();
            ProductSet response = await client.UpdateProductSetAsync(productSet, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateProductSet2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateProductSetRequest request = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateProductSet(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSet response = client.UpdateProductSet(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateProductSetAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateProductSetRequest request = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateProductSetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ProductSet>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSet response = await client.UpdateProductSetAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteProductSet()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteProductSetRequest expectedRequest = new DeleteProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProductSet(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSetName name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            client.DeleteProductSet(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteProductSetAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteProductSetRequest expectedRequest = new DeleteProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProductSetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSetName name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            await client.DeleteProductSetAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteProductSet2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProductSet(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            client.DeleteProductSet(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteProductSetAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProductSetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            await client.DeleteProductSetAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AddProductToProductSet()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddProductToProductSetRequest expectedRequest = new AddProductToProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.AddProductToProductSet(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSetName name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            ProductName product = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            client.AddProductToProductSet(name, product);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AddProductToProductSetAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddProductToProductSetRequest expectedRequest = new AddProductToProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.AddProductToProductSetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSetName name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            ProductName product = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            await client.AddProductToProductSetAsync(name, product);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AddProductToProductSet2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.AddProductToProductSet(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            client.AddProductToProductSet(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AddProductToProductSetAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.AddProductToProductSetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            await client.AddProductToProductSetAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RemoveProductFromProductSet()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            RemoveProductFromProductSetRequest expectedRequest = new RemoveProductFromProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.RemoveProductFromProductSet(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSetName name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            ProductName product = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            client.RemoveProductFromProductSet(name, product);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RemoveProductFromProductSetAsync()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            RemoveProductFromProductSetRequest expectedRequest = new RemoveProductFromProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.RemoveProductFromProductSetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            ProductSetName name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            ProductName product = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            await client.RemoveProductFromProductSetAsync(name, product);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RemoveProductFromProductSet2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.RemoveProductFromProductSet(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            client.RemoveProductFromProductSet(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RemoveProductFromProductSetAsync2()
        {
            Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new Mock<ProductSearch.ProductSearchClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                ProductSetName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.RemoveProductFromProductSetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null);
            await client.RemoveProductFromProductSetAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
