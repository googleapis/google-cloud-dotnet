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
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null);
            Catalog response = client.UpdateCatalog(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCatalogRequestObjectAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
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
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null);
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
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null);
            Catalog response = client.UpdateCatalog(request.Catalog, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCatalogAsync()
        {
            moq::Mock<CatalogService.CatalogServiceClient> mockGrpcClient = new moq::Mock<CatalogService.CatalogServiceClient>(moq::MockBehavior.Strict);
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
            CatalogServiceClient client = new CatalogServiceClientImpl(mockGrpcClient.Object, null);
            Catalog responseCallSettings = await client.UpdateCatalogAsync(request.Catalog, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Catalog responseCancellationToken = await client.UpdateCatalogAsync(request.Catalog, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
