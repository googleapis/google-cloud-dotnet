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

namespace Google.Cloud.AppEngine.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAuthorizedCertificatesClientTest
    {
        [xunit::FactAttribute]
        public void GetAuthorizedCertificateRequestObject()
        {
            moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient> mockGrpcClient = new moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient>(moq::MockBehavior.Strict);
            GetAuthorizedCertificateRequest request = new GetAuthorizedCertificateRequest
            {
                Name = "name1c9368b0",
                View = AuthorizedCertificateView.FullCertificate,
            };
            AuthorizedCertificate expectedResponse = new AuthorizedCertificate
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                DisplayName = "display_name137f65c2",
                DomainNames =
                {
                    "domain_names58aa2a78",
                },
                ExpireTime = new wkt::Timestamp(),
                CertificateRawData = new CertificateRawData(),
                ManagedCertificate = new ManagedCertificate(),
                VisibleDomainMappings =
                {
                    "visible_domain_mappings231706d8",
                },
                DomainMappingsCount = 1489673528,
            };
            mockGrpcClient.Setup(x => x.GetAuthorizedCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AuthorizedCertificatesClient client = new AuthorizedCertificatesClientImpl(mockGrpcClient.Object, null, null);
            AuthorizedCertificate response = client.GetAuthorizedCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAuthorizedCertificateRequestObjectAsync()
        {
            moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient> mockGrpcClient = new moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient>(moq::MockBehavior.Strict);
            GetAuthorizedCertificateRequest request = new GetAuthorizedCertificateRequest
            {
                Name = "name1c9368b0",
                View = AuthorizedCertificateView.FullCertificate,
            };
            AuthorizedCertificate expectedResponse = new AuthorizedCertificate
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                DisplayName = "display_name137f65c2",
                DomainNames =
                {
                    "domain_names58aa2a78",
                },
                ExpireTime = new wkt::Timestamp(),
                CertificateRawData = new CertificateRawData(),
                ManagedCertificate = new ManagedCertificate(),
                VisibleDomainMappings =
                {
                    "visible_domain_mappings231706d8",
                },
                DomainMappingsCount = 1489673528,
            };
            mockGrpcClient.Setup(x => x.GetAuthorizedCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizedCertificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AuthorizedCertificatesClient client = new AuthorizedCertificatesClientImpl(mockGrpcClient.Object, null, null);
            AuthorizedCertificate responseCallSettings = await client.GetAuthorizedCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizedCertificate responseCancellationToken = await client.GetAuthorizedCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAuthorizedCertificateRequestObject()
        {
            moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient> mockGrpcClient = new moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient>(moq::MockBehavior.Strict);
            CreateAuthorizedCertificateRequest request = new CreateAuthorizedCertificateRequest
            {
                Parent = "parent7858e4d0",
                Certificate = new AuthorizedCertificate(),
            };
            AuthorizedCertificate expectedResponse = new AuthorizedCertificate
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                DisplayName = "display_name137f65c2",
                DomainNames =
                {
                    "domain_names58aa2a78",
                },
                ExpireTime = new wkt::Timestamp(),
                CertificateRawData = new CertificateRawData(),
                ManagedCertificate = new ManagedCertificate(),
                VisibleDomainMappings =
                {
                    "visible_domain_mappings231706d8",
                },
                DomainMappingsCount = 1489673528,
            };
            mockGrpcClient.Setup(x => x.CreateAuthorizedCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AuthorizedCertificatesClient client = new AuthorizedCertificatesClientImpl(mockGrpcClient.Object, null, null);
            AuthorizedCertificate response = client.CreateAuthorizedCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAuthorizedCertificateRequestObjectAsync()
        {
            moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient> mockGrpcClient = new moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient>(moq::MockBehavior.Strict);
            CreateAuthorizedCertificateRequest request = new CreateAuthorizedCertificateRequest
            {
                Parent = "parent7858e4d0",
                Certificate = new AuthorizedCertificate(),
            };
            AuthorizedCertificate expectedResponse = new AuthorizedCertificate
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                DisplayName = "display_name137f65c2",
                DomainNames =
                {
                    "domain_names58aa2a78",
                },
                ExpireTime = new wkt::Timestamp(),
                CertificateRawData = new CertificateRawData(),
                ManagedCertificate = new ManagedCertificate(),
                VisibleDomainMappings =
                {
                    "visible_domain_mappings231706d8",
                },
                DomainMappingsCount = 1489673528,
            };
            mockGrpcClient.Setup(x => x.CreateAuthorizedCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizedCertificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AuthorizedCertificatesClient client = new AuthorizedCertificatesClientImpl(mockGrpcClient.Object, null, null);
            AuthorizedCertificate responseCallSettings = await client.CreateAuthorizedCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizedCertificate responseCancellationToken = await client.CreateAuthorizedCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAuthorizedCertificateRequestObject()
        {
            moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient> mockGrpcClient = new moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient>(moq::MockBehavior.Strict);
            UpdateAuthorizedCertificateRequest request = new UpdateAuthorizedCertificateRequest
            {
                Name = "name1c9368b0",
                Certificate = new AuthorizedCertificate(),
                UpdateMask = new wkt::FieldMask(),
            };
            AuthorizedCertificate expectedResponse = new AuthorizedCertificate
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                DisplayName = "display_name137f65c2",
                DomainNames =
                {
                    "domain_names58aa2a78",
                },
                ExpireTime = new wkt::Timestamp(),
                CertificateRawData = new CertificateRawData(),
                ManagedCertificate = new ManagedCertificate(),
                VisibleDomainMappings =
                {
                    "visible_domain_mappings231706d8",
                },
                DomainMappingsCount = 1489673528,
            };
            mockGrpcClient.Setup(x => x.UpdateAuthorizedCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AuthorizedCertificatesClient client = new AuthorizedCertificatesClientImpl(mockGrpcClient.Object, null, null);
            AuthorizedCertificate response = client.UpdateAuthorizedCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAuthorizedCertificateRequestObjectAsync()
        {
            moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient> mockGrpcClient = new moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient>(moq::MockBehavior.Strict);
            UpdateAuthorizedCertificateRequest request = new UpdateAuthorizedCertificateRequest
            {
                Name = "name1c9368b0",
                Certificate = new AuthorizedCertificate(),
                UpdateMask = new wkt::FieldMask(),
            };
            AuthorizedCertificate expectedResponse = new AuthorizedCertificate
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                DisplayName = "display_name137f65c2",
                DomainNames =
                {
                    "domain_names58aa2a78",
                },
                ExpireTime = new wkt::Timestamp(),
                CertificateRawData = new CertificateRawData(),
                ManagedCertificate = new ManagedCertificate(),
                VisibleDomainMappings =
                {
                    "visible_domain_mappings231706d8",
                },
                DomainMappingsCount = 1489673528,
            };
            mockGrpcClient.Setup(x => x.UpdateAuthorizedCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizedCertificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AuthorizedCertificatesClient client = new AuthorizedCertificatesClientImpl(mockGrpcClient.Object, null, null);
            AuthorizedCertificate responseCallSettings = await client.UpdateAuthorizedCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizedCertificate responseCancellationToken = await client.UpdateAuthorizedCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAuthorizedCertificateRequestObject()
        {
            moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient> mockGrpcClient = new moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient>(moq::MockBehavior.Strict);
            DeleteAuthorizedCertificateRequest request = new DeleteAuthorizedCertificateRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAuthorizedCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AuthorizedCertificatesClient client = new AuthorizedCertificatesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAuthorizedCertificate(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAuthorizedCertificateRequestObjectAsync()
        {
            moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient> mockGrpcClient = new moq::Mock<AuthorizedCertificates.AuthorizedCertificatesClient>(moq::MockBehavior.Strict);
            DeleteAuthorizedCertificateRequest request = new DeleteAuthorizedCertificateRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAuthorizedCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AuthorizedCertificatesClient client = new AuthorizedCertificatesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAuthorizedCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAuthorizedCertificateAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
