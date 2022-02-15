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

namespace Google.Cloud.Security.PrivateCA.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCertificateAuthorityServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateCertificateRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.CreateCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.CreateCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.CreateCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCertificate()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.CreateCertificate(request.Parent, request.Certificate, request.CertificateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.CreateCertificateAsync(request.Parent, request.Certificate, request.CertificateId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.CreateCertificateAsync(request.Parent, request.Certificate, request.CertificateId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCertificateResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.CreateCertificate(request.ParentAsCertificateAuthorityName, request.Certificate, request.CertificateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCertificateResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.CreateCertificateAsync(request.ParentAsCertificateAuthorityName, request.Certificate, request.CertificateId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.CreateCertificateAsync(request.ParentAsCertificateAuthorityName, request.Certificate, request.CertificateId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.GetCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.GetCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.GetCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificate()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.GetCertificate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.GetCertificateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.GetCertificateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.GetCertificate(request.CertificateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.GetCertificateAsync(request.CertificateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.GetCertificateAsync(request.CertificateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RevokeCertificateRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                Reason = RevocationReason.Superseded,
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.RevokeCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RevokeCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                Reason = RevocationReason.Superseded,
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.RevokeCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.RevokeCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RevokeCertificate()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.RevokeCertificate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RevokeCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.RevokeCertificateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.RevokeCertificateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RevokeCertificateResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.RevokeCertificate(request.CertificateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RevokeCertificateResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RevokeCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.RevokeCertificateAsync(request.CertificateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.RevokeCertificateAsync(request.CertificateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCertificateRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new wkt::FieldMask(),
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.UpdateCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new wkt::FieldMask(),
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.UpdateCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.UpdateCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCertificate()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new wkt::FieldMask(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate response = client.UpdateCertificate(request.Certificate, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new wkt::FieldMask(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                RevocationDetails = new Certificate.Types.RevocationDetails(),
                PemCertificate = "pem_certificate5c1b61ff",
                CertificateDescription = new CertificateDescription(),
                PemCertificateChain =
                {
                    "pem_certificate_chain1eff25c5",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            Certificate responseCallSettings = await client.UpdateCertificateAsync(request.Certificate, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.UpdateCertificateAsync(request.Certificate, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchCertificateAuthorityCsrRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsr(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse response = client.FetchCertificateAuthorityCsr(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCertificateAuthorityCsrRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsrAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCertificateAuthorityCsrResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse responseCallSettings = await client.FetchCertificateAuthorityCsrAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchCertificateAuthorityCsrResponse responseCancellationToken = await client.FetchCertificateAuthorityCsrAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchCertificateAuthorityCsr()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsr(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse response = client.FetchCertificateAuthorityCsr(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCertificateAuthorityCsrAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsrAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCertificateAuthorityCsrResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse responseCallSettings = await client.FetchCertificateAuthorityCsrAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchCertificateAuthorityCsrResponse responseCancellationToken = await client.FetchCertificateAuthorityCsrAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchCertificateAuthorityCsrResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsr(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse response = client.FetchCertificateAuthorityCsr(request.CertificateAuthorityName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCertificateAuthorityCsrResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsrAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCertificateAuthorityCsrResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            FetchCertificateAuthorityCsrResponse responseCallSettings = await client.FetchCertificateAuthorityCsrAsync(request.CertificateAuthorityName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchCertificateAuthorityCsrResponse responseCancellationToken = await client.FetchCertificateAuthorityCsrAsync(request.CertificateAuthorityName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateAuthorityRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy(),
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions(),
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthority(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority response = client.GetCertificateAuthority(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAuthorityRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy(),
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions(),
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthorityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateAuthority>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority responseCallSettings = await client.GetCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateAuthority responseCancellationToken = await client.GetCertificateAuthorityAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateAuthority()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy(),
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions(),
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthority(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority response = client.GetCertificateAuthority(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAuthorityAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy(),
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions(),
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthorityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateAuthority>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority responseCallSettings = await client.GetCertificateAuthorityAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateAuthority responseCancellationToken = await client.GetCertificateAuthorityAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateAuthorityResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy(),
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions(),
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthority(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority response = client.GetCertificateAuthority(request.CertificateAuthorityName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAuthorityResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Tier = CertificateAuthority.Types.Tier.Enterprise,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                CertificatePolicy = new CertificateAuthority.Types.CertificateAuthorityPolicy(),
                IssuingOptions = new CertificateAuthority.Types.IssuingOptions(),
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                State = CertificateAuthority.Types.State.PendingActivation,
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SubordinateConfig = new SubordinateConfig(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthorityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateAuthority>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateAuthority responseCallSettings = await client.GetCertificateAuthorityAsync(request.CertificateAuthorityName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateAuthority responseCancellationToken = await client.GetCertificateAuthorityAsync(request.CertificateAuthorityName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateRevocationListRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate(),
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList response = client.GetCertificateRevocationList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRevocationListRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate(),
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateRevocationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList responseCallSettings = await client.GetCertificateRevocationListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateRevocationList responseCancellationToken = await client.GetCertificateRevocationListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateRevocationList()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate(),
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList response = client.GetCertificateRevocationList(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRevocationListAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate(),
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateRevocationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList responseCallSettings = await client.GetCertificateRevocationListAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateRevocationList responseCancellationToken = await client.GetCertificateRevocationListAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateRevocationListResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate(),
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList response = client.GetCertificateRevocationList(request.CertificateRevocationListName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRevocationListResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
                SequenceNumber = 785044825799214282L,
                RevokedCertificates =
                {
                    new CertificateRevocationList.Types.RevokedCertificate(),
                },
                PemCrl = "pem_crle4a1db0f",
                AccessUrl = "access_url8b12f83f",
                State = CertificateRevocationList.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateRevocationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            CertificateRevocationList responseCallSettings = await client.GetCertificateRevocationListAsync(request.CertificateRevocationListName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateRevocationList responseCancellationToken = await client.GetCertificateRevocationListAsync(request.CertificateRevocationListName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReusableConfigRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues(),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig response = client.GetReusableConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReusableConfigRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues(),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReusableConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig responseCallSettings = await client.GetReusableConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReusableConfig responseCancellationToken = await client.GetReusableConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReusableConfig()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues(),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig response = client.GetReusableConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReusableConfigAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues(),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReusableConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig responseCallSettings = await client.GetReusableConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReusableConfig responseCancellationToken = await client.GetReusableConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReusableConfigResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues(),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig response = client.GetReusableConfig(request.ReusableConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReusableConfigResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            ReusableConfig expectedResponse = new ReusableConfig
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
                Values = new ReusableConfigValues(),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReusableConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReusableConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null);
            ReusableConfig responseCallSettings = await client.GetReusableConfigAsync(request.ReusableConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReusableConfig responseCancellationToken = await client.GetReusableConfigAsync(request.ReusableConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
