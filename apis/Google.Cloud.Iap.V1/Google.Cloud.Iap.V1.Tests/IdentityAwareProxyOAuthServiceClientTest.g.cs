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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Iap.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedIdentityAwareProxyOAuthServiceClientTest
    {
        [xunit::FactAttribute]
        public void ListBrandsRequestObject()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            ListBrandsRequest request = new ListBrandsRequest
            {
                Parent = "parent7858e4d0",
            };
            ListBrandsResponse expectedResponse = new ListBrandsResponse
            {
                Brands = { new Brand(), },
            };
            mockGrpcClient.Setup(x => x.ListBrands(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            ListBrandsResponse response = client.ListBrands(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListBrandsRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            ListBrandsRequest request = new ListBrandsRequest
            {
                Parent = "parent7858e4d0",
            };
            ListBrandsResponse expectedResponse = new ListBrandsResponse
            {
                Brands = { new Brand(), },
            };
            mockGrpcClient.Setup(x => x.ListBrandsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListBrandsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            ListBrandsResponse responseCallSettings = await client.ListBrandsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListBrandsResponse responseCancellationToken = await client.ListBrandsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBrandRequestObject()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            CreateBrandRequest request = new CreateBrandRequest
            {
                Parent = "parent7858e4d0",
                Brand = new Brand(),
            };
            Brand expectedResponse = new Brand
            {
                Name = "name1c9368b0",
                SupportEmail = "support_email60b1be92",
                ApplicationTitle = "application_title59ccbd06",
                OrgInternalOnly = false,
            };
            mockGrpcClient.Setup(x => x.CreateBrand(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            Brand response = client.CreateBrand(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBrandRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            CreateBrandRequest request = new CreateBrandRequest
            {
                Parent = "parent7858e4d0",
                Brand = new Brand(),
            };
            Brand expectedResponse = new Brand
            {
                Name = "name1c9368b0",
                SupportEmail = "support_email60b1be92",
                ApplicationTitle = "application_title59ccbd06",
                OrgInternalOnly = false,
            };
            mockGrpcClient.Setup(x => x.CreateBrandAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Brand>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            Brand responseCallSettings = await client.CreateBrandAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Brand responseCancellationToken = await client.CreateBrandAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBrandRequestObject()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            GetBrandRequest request = new GetBrandRequest
            {
                Name = "name1c9368b0",
            };
            Brand expectedResponse = new Brand
            {
                Name = "name1c9368b0",
                SupportEmail = "support_email60b1be92",
                ApplicationTitle = "application_title59ccbd06",
                OrgInternalOnly = false,
            };
            mockGrpcClient.Setup(x => x.GetBrand(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            Brand response = client.GetBrand(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBrandRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            GetBrandRequest request = new GetBrandRequest
            {
                Name = "name1c9368b0",
            };
            Brand expectedResponse = new Brand
            {
                Name = "name1c9368b0",
                SupportEmail = "support_email60b1be92",
                ApplicationTitle = "application_title59ccbd06",
                OrgInternalOnly = false,
            };
            mockGrpcClient.Setup(x => x.GetBrandAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Brand>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            Brand responseCallSettings = await client.GetBrandAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Brand responseCancellationToken = await client.GetBrandAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateIdentityAwareProxyClientRequestObject()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            CreateIdentityAwareProxyClientRequest request = new CreateIdentityAwareProxyClientRequest
            {
                Parent = "parent7858e4d0",
                IdentityAwareProxyClient = new IdentityAwareProxyClient(),
            };
            IdentityAwareProxyClient expectedResponse = new IdentityAwareProxyClient
            {
                Name = "name1c9368b0",
                Secret = "secret9422be5e",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateIdentityAwareProxyClient(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            IdentityAwareProxyClient response = client.CreateIdentityAwareProxyClient(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateIdentityAwareProxyClientRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            CreateIdentityAwareProxyClientRequest request = new CreateIdentityAwareProxyClientRequest
            {
                Parent = "parent7858e4d0",
                IdentityAwareProxyClient = new IdentityAwareProxyClient(),
            };
            IdentityAwareProxyClient expectedResponse = new IdentityAwareProxyClient
            {
                Name = "name1c9368b0",
                Secret = "secret9422be5e",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateIdentityAwareProxyClientAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IdentityAwareProxyClient>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            IdentityAwareProxyClient responseCallSettings = await client.CreateIdentityAwareProxyClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IdentityAwareProxyClient responseCancellationToken = await client.CreateIdentityAwareProxyClientAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIdentityAwareProxyClientRequestObject()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            GetIdentityAwareProxyClientRequest request = new GetIdentityAwareProxyClientRequest
            {
                Name = "name1c9368b0",
            };
            IdentityAwareProxyClient expectedResponse = new IdentityAwareProxyClient
            {
                Name = "name1c9368b0",
                Secret = "secret9422be5e",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetIdentityAwareProxyClient(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            IdentityAwareProxyClient response = client.GetIdentityAwareProxyClient(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIdentityAwareProxyClientRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            GetIdentityAwareProxyClientRequest request = new GetIdentityAwareProxyClientRequest
            {
                Name = "name1c9368b0",
            };
            IdentityAwareProxyClient expectedResponse = new IdentityAwareProxyClient
            {
                Name = "name1c9368b0",
                Secret = "secret9422be5e",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetIdentityAwareProxyClientAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IdentityAwareProxyClient>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            IdentityAwareProxyClient responseCallSettings = await client.GetIdentityAwareProxyClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IdentityAwareProxyClient responseCancellationToken = await client.GetIdentityAwareProxyClientAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResetIdentityAwareProxyClientSecretRequestObject()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            ResetIdentityAwareProxyClientSecretRequest request = new ResetIdentityAwareProxyClientSecretRequest
            {
                Name = "name1c9368b0",
            };
            IdentityAwareProxyClient expectedResponse = new IdentityAwareProxyClient
            {
                Name = "name1c9368b0",
                Secret = "secret9422be5e",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.ResetIdentityAwareProxyClientSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            IdentityAwareProxyClient response = client.ResetIdentityAwareProxyClientSecret(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetIdentityAwareProxyClientSecretRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            ResetIdentityAwareProxyClientSecretRequest request = new ResetIdentityAwareProxyClientSecretRequest
            {
                Name = "name1c9368b0",
            };
            IdentityAwareProxyClient expectedResponse = new IdentityAwareProxyClient
            {
                Name = "name1c9368b0",
                Secret = "secret9422be5e",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.ResetIdentityAwareProxyClientSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IdentityAwareProxyClient>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            IdentityAwareProxyClient responseCallSettings = await client.ResetIdentityAwareProxyClientSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IdentityAwareProxyClient responseCancellationToken = await client.ResetIdentityAwareProxyClientSecretAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIdentityAwareProxyClientRequestObject()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            DeleteIdentityAwareProxyClientRequest request = new DeleteIdentityAwareProxyClientRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIdentityAwareProxyClient(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteIdentityAwareProxyClient(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIdentityAwareProxyClientRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient>(moq::MockBehavior.Strict);
            DeleteIdentityAwareProxyClientRequest request = new DeleteIdentityAwareProxyClientRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIdentityAwareProxyClientAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyOAuthServiceClient client = new IdentityAwareProxyOAuthServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIdentityAwareProxyClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIdentityAwareProxyClientAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
