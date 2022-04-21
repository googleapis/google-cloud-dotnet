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
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Vision.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedProductSearchClientTest
    {
        [xunit::FactAttribute]
        public void CreateProductSetRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
                ProductSetId = "product_set_idc0ec7b3e",
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet response = client.CreateProductSet(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProductSetRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
                ProductSetId = "product_set_idc0ec7b3e",
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProductSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet responseCallSettings = await client.CreateProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProductSet responseCancellationToken = await client.CreateProductSetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProductSet()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
                ProductSetId = "product_set_idc0ec7b3e",
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet response = client.CreateProductSet(request.Parent, request.ProductSet, request.ProductSetId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProductSetAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
                ProductSetId = "product_set_idc0ec7b3e",
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProductSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet responseCallSettings = await client.CreateProductSetAsync(request.Parent, request.ProductSet, request.ProductSetId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProductSet responseCancellationToken = await client.CreateProductSetAsync(request.Parent, request.ProductSet, request.ProductSetId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProductSetResourceNames()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
                ProductSetId = "product_set_idc0ec7b3e",
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet response = client.CreateProductSet(request.ParentAsLocationName, request.ProductSet, request.ProductSetId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProductSetResourceNamesAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
                ProductSetId = "product_set_idc0ec7b3e",
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProductSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet responseCallSettings = await client.CreateProductSetAsync(request.ParentAsLocationName, request.ProductSet, request.ProductSetId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProductSet responseCancellationToken = await client.CreateProductSetAsync(request.ParentAsLocationName, request.ProductSet, request.ProductSetId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProductSetRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductSetRequest request = new GetProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet response = client.GetProductSet(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProductSetRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductSetRequest request = new GetProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProductSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet responseCallSettings = await client.GetProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProductSet responseCancellationToken = await client.GetProductSetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProductSet()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductSetRequest request = new GetProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet response = client.GetProductSet(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProductSetAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductSetRequest request = new GetProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProductSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet responseCallSettings = await client.GetProductSetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProductSet responseCancellationToken = await client.GetProductSetAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProductSetResourceNames()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductSetRequest request = new GetProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet response = client.GetProductSet(request.ProductSetName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProductSetResourceNamesAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductSetRequest request = new GetProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProductSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet responseCallSettings = await client.GetProductSetAsync(request.ProductSetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProductSet responseCancellationToken = await client.GetProductSetAsync(request.ProductSetName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProductSetRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateProductSetRequest request = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
                UpdateMask = new wkt::FieldMask(),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.UpdateProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet response = client.UpdateProductSet(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateProductSetRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateProductSetRequest request = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
                UpdateMask = new wkt::FieldMask(),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.UpdateProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProductSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet responseCallSettings = await client.UpdateProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProductSet responseCancellationToken = await client.UpdateProductSetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProductSet()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateProductSetRequest request = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
                UpdateMask = new wkt::FieldMask(),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.UpdateProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet response = client.UpdateProductSet(request.ProductSet, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateProductSetAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateProductSetRequest request = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
                UpdateMask = new wkt::FieldMask(),
            };
            ProductSet expectedResponse = new ProductSet
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                DisplayName = "display_name137f65c2",
                IndexTime = new wkt::Timestamp(),
                IndexError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.UpdateProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProductSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ProductSet responseCallSettings = await client.UpdateProductSetAsync(request.ProductSet, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProductSet responseCancellationToken = await client.UpdateProductSetAsync(request.ProductSet, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProductSetRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteProductSet(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProductSetRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProductSetAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProductSet()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteProductSet(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProductSetAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteProductSetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProductSetAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProductSetResourceNames()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteProductSet(request.ProductSetName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProductSetResourceNamesAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteProductSetAsync(request.ProductSetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProductSetAsync(request.ProductSetName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProductRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.CreateProduct(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProductRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.CreateProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.CreateProductAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProduct()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.CreateProduct(request.Parent, request.Product, request.ProductId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProductAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.CreateProductAsync(request.Parent, request.Product, request.ProductId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.CreateProductAsync(request.Parent, request.Product, request.ProductId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProductResourceNames()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.CreateProduct(request.ParentAsLocationName, request.Product, request.ProductId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProductResourceNamesAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
                ProductId = "product_idde82ea9b",
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.CreateProductAsync(request.ParentAsLocationName, request.Product, request.ProductId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.CreateProductAsync(request.ParentAsLocationName, request.Product, request.ProductId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProductRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.GetProduct(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProductRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.GetProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.GetProductAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProduct()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.GetProduct(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProductAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.GetProductAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.GetProductAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProductResourceNames()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.GetProduct(request.ProductName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProductResourceNamesAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.GetProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.GetProductAsync(request.ProductName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.GetProductAsync(request.ProductName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProductRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new wkt::FieldMask(),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.UpdateProduct(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateProductRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new wkt::FieldMask(),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.UpdateProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.UpdateProductAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProduct()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new wkt::FieldMask(),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product response = client.UpdateProduct(request.Product, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateProductAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new wkt::FieldMask(),
            };
            Product expectedResponse = new Product
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ProductCategory = "product_category7fba5b40",
                ProductLabels =
                {
                    new Product.Types.KeyValue(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Product>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            Product responseCallSettings = await client.UpdateProductAsync(request.Product, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Product responseCancellationToken = await client.UpdateProductAsync(request.Product, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProductRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteProduct(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProductRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProductAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProduct()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteProduct(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProductAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteProductAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProductAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProductResourceNames()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProduct(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteProduct(request.ProductName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProductResourceNamesAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProductAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteProductAsync(request.ProductName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProductAsync(request.ProductName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReferenceImageRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                ParentAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
                ReferenceImageId = "reference_image_idda348389",
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.CreateReferenceImage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage response = client.CreateReferenceImage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReferenceImageRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                ParentAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
                ReferenceImageId = "reference_image_idda348389",
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.CreateReferenceImageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReferenceImage>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage responseCallSettings = await client.CreateReferenceImageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReferenceImage responseCancellationToken = await client.CreateReferenceImageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReferenceImage()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                ParentAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
                ReferenceImageId = "reference_image_idda348389",
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.CreateReferenceImage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage response = client.CreateReferenceImage(request.Parent, request.ReferenceImage, request.ReferenceImageId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReferenceImageAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                ParentAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
                ReferenceImageId = "reference_image_idda348389",
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.CreateReferenceImageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReferenceImage>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage responseCallSettings = await client.CreateReferenceImageAsync(request.Parent, request.ReferenceImage, request.ReferenceImageId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReferenceImage responseCancellationToken = await client.CreateReferenceImageAsync(request.Parent, request.ReferenceImage, request.ReferenceImageId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateReferenceImageResourceNames()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                ParentAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
                ReferenceImageId = "reference_image_idda348389",
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.CreateReferenceImage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage response = client.CreateReferenceImage(request.ParentAsProductName, request.ReferenceImage, request.ReferenceImageId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateReferenceImageResourceNamesAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                ParentAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
                ReferenceImageId = "reference_image_idda348389",
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.CreateReferenceImageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReferenceImage>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage responseCallSettings = await client.CreateReferenceImageAsync(request.ParentAsProductName, request.ReferenceImage, request.ReferenceImageId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReferenceImage responseCancellationToken = await client.CreateReferenceImageAsync(request.ParentAsProductName, request.ReferenceImage, request.ReferenceImageId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteReferenceImageRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReferenceImage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteReferenceImage(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteReferenceImageRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReferenceImageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteReferenceImageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteReferenceImageAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteReferenceImage()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReferenceImage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteReferenceImage(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteReferenceImageAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReferenceImageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteReferenceImageAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteReferenceImageAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteReferenceImageResourceNames()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReferenceImage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteReferenceImage(request.ReferenceImageName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteReferenceImageResourceNamesAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteReferenceImageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteReferenceImageAsync(request.ReferenceImageName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteReferenceImageAsync(request.ReferenceImageName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReferenceImageRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.GetReferenceImage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage response = client.GetReferenceImage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReferenceImageRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.GetReferenceImageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReferenceImage>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage responseCallSettings = await client.GetReferenceImageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReferenceImage responseCancellationToken = await client.GetReferenceImageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReferenceImage()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.GetReferenceImage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage response = client.GetReferenceImage(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReferenceImageAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.GetReferenceImageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReferenceImage>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage responseCallSettings = await client.GetReferenceImageAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReferenceImage responseCancellationToken = await client.GetReferenceImageAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReferenceImageResourceNames()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.GetReferenceImage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage response = client.GetReferenceImage(request.ReferenceImageName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReferenceImageResourceNamesAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            ReferenceImage expectedResponse = new ReferenceImage
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
                Uri = "uri3db70593",
                BoundingPolys = { new BoundingPoly(), },
            };
            mockGrpcClient.Setup(x => x.GetReferenceImageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReferenceImage>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            ReferenceImage responseCallSettings = await client.GetReferenceImageAsync(request.ReferenceImageName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReferenceImage responseCancellationToken = await client.GetReferenceImageAsync(request.ReferenceImageName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddProductToProductSetRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.AddProductToProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.AddProductToProductSet(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddProductToProductSetRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.AddProductToProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.AddProductToProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.AddProductToProductSetAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddProductToProductSet()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.AddProductToProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.AddProductToProductSet(request.Name, request.Product);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddProductToProductSetAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.AddProductToProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.AddProductToProductSetAsync(request.Name, request.Product, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.AddProductToProductSetAsync(request.Name, request.Product, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddProductToProductSetResourceNames()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.AddProductToProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.AddProductToProductSet(request.ProductSetName, request.ProductAsProductName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddProductToProductSetResourceNamesAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.AddProductToProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.AddProductToProductSetAsync(request.ProductSetName, request.ProductAsProductName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.AddProductToProductSetAsync(request.ProductSetName, request.ProductAsProductName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveProductFromProductSetRequestObject()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RemoveProductFromProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.RemoveProductFromProductSet(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveProductFromProductSetRequestObjectAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RemoveProductFromProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.RemoveProductFromProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.RemoveProductFromProductSetAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveProductFromProductSet()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RemoveProductFromProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.RemoveProductFromProductSet(request.Name, request.Product);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveProductFromProductSetAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RemoveProductFromProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.RemoveProductFromProductSetAsync(request.Name, request.Product, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.RemoveProductFromProductSetAsync(request.Name, request.Product, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveProductFromProductSetResourceNames()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RemoveProductFromProductSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            client.RemoveProductFromProductSet(request.ProductSetName, request.ProductAsProductName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveProductFromProductSetResourceNamesAsync()
        {
            moq::Mock<ProductSearch.ProductSearchClient> mockGrpcClient = new moq::Mock<ProductSearch.ProductSearchClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RemoveProductFromProductSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductSearchClient client = new ProductSearchClientImpl(mockGrpcClient.Object, null, null);
            await client.RemoveProductFromProductSetAsync(request.ProductSetName, request.ProductAsProductName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.RemoveProductFromProductSetAsync(request.ProductSetName, request.ProductAsProductName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
