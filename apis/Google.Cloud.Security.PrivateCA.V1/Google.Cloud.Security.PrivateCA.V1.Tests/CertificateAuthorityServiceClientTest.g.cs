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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Security.PrivateCA.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCertificateAuthorityServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateCertificateRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
                RequestId = "request_id362c8df6",
                ValidateOnly = true,
                IssuingCertificateAuthorityId = "issuing_certificate_authority_id23892330",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.CreateCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
                RequestId = "request_id362c8df6",
                ValidateOnly = true,
                IssuingCertificateAuthorityId = "issuing_certificate_authority_id23892330",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.CreateCertificate(request.Parent, request.Certificate, request.CertificateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.CreateCertificate(request.ParentAsCaPoolName, request.Certificate, request.CertificateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCertificateResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                CertificateId = "certificate_id007930d5",
                Certificate = new Certificate(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate responseCallSettings = await client.CreateCertificateAsync(request.ParentAsCaPoolName, request.Certificate, request.CertificateId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.CreateCertificateAsync(request.ParentAsCaPoolName, request.Certificate, request.CertificateId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.GetCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.GetCertificate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.GetCertificate(request.CertificateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                Reason = RevocationReason.Superseded,
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.RevokeCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RevokeCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                Reason = RevocationReason.Superseded,
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.RevokeCertificate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RevokeCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.RevokeCertificate(request.CertificateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RevokeCertificateResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new wkt::FieldMask(),
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.UpdateCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new wkt::FieldMask(),
                RequestId = "request_id362c8df6",
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new wkt::FieldMask(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.UpdateCertificate(request.Certificate, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCertificateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new wkt::FieldMask(),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                PemCsr = "pem_csr6e61aeb4",
                Config = new CertificateConfig(),
                IssuerCertificateAuthorityAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Lifetime = new wkt::Duration(),
                CertificateTemplateAsCertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                SubjectMode = SubjectRequestMode.Default,
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
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsr(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchCertificateAuthorityCsrResponse response = client.FetchCertificateAuthorityCsr(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCertificateAuthorityCsrRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsrAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCertificateAuthorityCsrResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsr(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchCertificateAuthorityCsrResponse response = client.FetchCertificateAuthorityCsr(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCertificateAuthorityCsrAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsrAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCertificateAuthorityCsrResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsr(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchCertificateAuthorityCsrResponse response = client.FetchCertificateAuthorityCsr(request.CertificateAuthorityName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCertificateAuthorityCsrResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            FetchCertificateAuthorityCsrResponse expectedResponse = new FetchCertificateAuthorityCsrResponse
            {
                PemCsr = "pem_csr6e61aeb4",
            };
            mockGrpcClient.Setup(x => x.FetchCertificateAuthorityCsrAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCertificateAuthorityCsrResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                SubordinateConfig = new SubordinateConfig(),
                Tier = CaPool.Types.Tier.Enterprise,
                State = CertificateAuthority.Types.State.Unspecified,
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthority(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateAuthority response = client.GetCertificateAuthority(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAuthorityRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                SubordinateConfig = new SubordinateConfig(),
                Tier = CaPool.Types.Tier.Enterprise,
                State = CertificateAuthority.Types.State.Unspecified,
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthorityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateAuthority>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                SubordinateConfig = new SubordinateConfig(),
                Tier = CaPool.Types.Tier.Enterprise,
                State = CertificateAuthority.Types.State.Unspecified,
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthority(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateAuthority response = client.GetCertificateAuthority(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAuthorityAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                SubordinateConfig = new SubordinateConfig(),
                Tier = CaPool.Types.Tier.Enterprise,
                State = CertificateAuthority.Types.State.Unspecified,
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthorityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateAuthority>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                SubordinateConfig = new SubordinateConfig(),
                Tier = CaPool.Types.Tier.Enterprise,
                State = CertificateAuthority.Types.State.Unspecified,
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthority(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateAuthority response = client.GetCertificateAuthority(request.CertificateAuthorityName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAuthorityResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            CertificateAuthority expectedResponse = new CertificateAuthority
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Type = CertificateAuthority.Types.Type.Unspecified,
                Config = new CertificateConfig(),
                Lifetime = new wkt::Duration(),
                KeySpec = new CertificateAuthority.Types.KeyVersionSpec(),
                SubordinateConfig = new SubordinateConfig(),
                Tier = CaPool.Types.Tier.Enterprise,
                State = CertificateAuthority.Types.State.Unspecified,
                PemCaCertificates =
                {
                    "pem_ca_certificatese5e19b71",
                },
                CaCertificateDescriptions =
                {
                    new CertificateDescription(),
                },
                GcsBucket = "gcs_bucket69bbfa63",
                AccessUrls = new CertificateAuthority.Types.AccessUrls(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateAuthorityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateAuthority>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateAuthority responseCallSettings = await client.GetCertificateAuthorityAsync(request.CertificateAuthorityName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateAuthority responseCancellationToken = await client.GetCertificateAuthorityAsync(request.CertificateAuthorityName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCaPoolRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCaPoolRequest request = new GetCaPoolRequest
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            CaPool expectedResponse = new CaPool
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                Tier = CaPool.Types.Tier.Enterprise,
                IssuancePolicy = new CaPool.Types.IssuancePolicy(),
                PublishingOptions = new CaPool.Types.PublishingOptions(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCaPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CaPool response = client.GetCaPool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCaPoolRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCaPoolRequest request = new GetCaPoolRequest
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            CaPool expectedResponse = new CaPool
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                Tier = CaPool.Types.Tier.Enterprise,
                IssuancePolicy = new CaPool.Types.IssuancePolicy(),
                PublishingOptions = new CaPool.Types.PublishingOptions(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCaPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CaPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CaPool responseCallSettings = await client.GetCaPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CaPool responseCancellationToken = await client.GetCaPoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCaPool()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCaPoolRequest request = new GetCaPoolRequest
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            CaPool expectedResponse = new CaPool
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                Tier = CaPool.Types.Tier.Enterprise,
                IssuancePolicy = new CaPool.Types.IssuancePolicy(),
                PublishingOptions = new CaPool.Types.PublishingOptions(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCaPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CaPool response = client.GetCaPool(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCaPoolAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCaPoolRequest request = new GetCaPoolRequest
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            CaPool expectedResponse = new CaPool
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                Tier = CaPool.Types.Tier.Enterprise,
                IssuancePolicy = new CaPool.Types.IssuancePolicy(),
                PublishingOptions = new CaPool.Types.PublishingOptions(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCaPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CaPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CaPool responseCallSettings = await client.GetCaPoolAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CaPool responseCancellationToken = await client.GetCaPoolAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCaPoolResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCaPoolRequest request = new GetCaPoolRequest
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            CaPool expectedResponse = new CaPool
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                Tier = CaPool.Types.Tier.Enterprise,
                IssuancePolicy = new CaPool.Types.IssuancePolicy(),
                PublishingOptions = new CaPool.Types.PublishingOptions(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCaPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CaPool response = client.GetCaPool(request.CaPoolName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCaPoolResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCaPoolRequest request = new GetCaPoolRequest
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            CaPool expectedResponse = new CaPool
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                Tier = CaPool.Types.Tier.Enterprise,
                IssuancePolicy = new CaPool.Types.IssuancePolicy(),
                PublishingOptions = new CaPool.Types.PublishingOptions(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCaPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CaPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CaPool responseCallSettings = await client.GetCaPoolAsync(request.CaPoolName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CaPool responseCancellationToken = await client.GetCaPoolAsync(request.CaPoolName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchCaCertsRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCaCertsRequest request = new FetchCaCertsRequest
            {
                CaPoolAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                RequestId = "request_id362c8df6",
            };
            FetchCaCertsResponse expectedResponse = new FetchCaCertsResponse
            {
                CaCerts =
                {
                    new FetchCaCertsResponse.Types.CertChain(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchCaCerts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchCaCertsResponse response = client.FetchCaCerts(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCaCertsRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCaCertsRequest request = new FetchCaCertsRequest
            {
                CaPoolAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                RequestId = "request_id362c8df6",
            };
            FetchCaCertsResponse expectedResponse = new FetchCaCertsResponse
            {
                CaCerts =
                {
                    new FetchCaCertsResponse.Types.CertChain(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchCaCertsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCaCertsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchCaCertsResponse responseCallSettings = await client.FetchCaCertsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchCaCertsResponse responseCancellationToken = await client.FetchCaCertsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchCaCerts()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCaCertsRequest request = new FetchCaCertsRequest
            {
                CaPoolAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            FetchCaCertsResponse expectedResponse = new FetchCaCertsResponse
            {
                CaCerts =
                {
                    new FetchCaCertsResponse.Types.CertChain(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchCaCerts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchCaCertsResponse response = client.FetchCaCerts(request.CaPool);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCaCertsAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCaCertsRequest request = new FetchCaCertsRequest
            {
                CaPoolAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            FetchCaCertsResponse expectedResponse = new FetchCaCertsResponse
            {
                CaCerts =
                {
                    new FetchCaCertsResponse.Types.CertChain(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchCaCertsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCaCertsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchCaCertsResponse responseCallSettings = await client.FetchCaCertsAsync(request.CaPool, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchCaCertsResponse responseCancellationToken = await client.FetchCaCertsAsync(request.CaPool, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchCaCertsResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCaCertsRequest request = new FetchCaCertsRequest
            {
                CaPoolAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            FetchCaCertsResponse expectedResponse = new FetchCaCertsResponse
            {
                CaCerts =
                {
                    new FetchCaCertsResponse.Types.CertChain(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchCaCerts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchCaCertsResponse response = client.FetchCaCerts(request.CaPoolAsCaPoolName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchCaCertsResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            FetchCaCertsRequest request = new FetchCaCertsRequest
            {
                CaPoolAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            FetchCaCertsResponse expectedResponse = new FetchCaCertsResponse
            {
                CaCerts =
                {
                    new FetchCaCertsResponse.Types.CertChain(),
                },
            };
            mockGrpcClient.Setup(x => x.FetchCaCertsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchCaCertsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            FetchCaCertsResponse responseCallSettings = await client.FetchCaCertsAsync(request.CaPoolAsCaPoolName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchCaCertsResponse responseCancellationToken = await client.FetchCaCertsAsync(request.CaPoolAsCaPoolName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateRevocationListRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
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
                RevisionId = "revision_id8d9ae05d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateRevocationList response = client.GetCertificateRevocationList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRevocationListRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
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
                RevisionId = "revision_id8d9ae05d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateRevocationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
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
                RevisionId = "revision_id8d9ae05d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateRevocationList response = client.GetCertificateRevocationList(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRevocationListAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
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
                RevisionId = "revision_id8d9ae05d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateRevocationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
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
                RevisionId = "revision_id8d9ae05d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateRevocationList response = client.GetCertificateRevocationList(request.CertificateRevocationListName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRevocationListResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            CertificateRevocationList expectedResponse = new CertificateRevocationList
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
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
                RevisionId = "revision_id8d9ae05d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetCertificateRevocationListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateRevocationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateRevocationList responseCallSettings = await client.GetCertificateRevocationListAsync(request.CertificateRevocationListName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateRevocationList responseCancellationToken = await client.GetCertificateRevocationListAsync(request.CertificateRevocationListName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateTemplateRequestObject()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateTemplateRequest request = new GetCertificateTemplateRequest
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
            };
            CertificateTemplate expectedResponse = new CertificateTemplate
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                PredefinedValues = new X509Parameters(),
                IdentityConstraints = new CertificateIdentityConstraints(),
                PassthroughExtensions = new CertificateExtensionConstraints(),
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
            mockGrpcClient.Setup(x => x.GetCertificateTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateTemplate response = client.GetCertificateTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateTemplateRequestObjectAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateTemplateRequest request = new GetCertificateTemplateRequest
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
            };
            CertificateTemplate expectedResponse = new CertificateTemplate
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                PredefinedValues = new X509Parameters(),
                IdentityConstraints = new CertificateIdentityConstraints(),
                PassthroughExtensions = new CertificateExtensionConstraints(),
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
            mockGrpcClient.Setup(x => x.GetCertificateTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateTemplate responseCallSettings = await client.GetCertificateTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateTemplate responseCancellationToken = await client.GetCertificateTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateTemplate()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateTemplateRequest request = new GetCertificateTemplateRequest
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
            };
            CertificateTemplate expectedResponse = new CertificateTemplate
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                PredefinedValues = new X509Parameters(),
                IdentityConstraints = new CertificateIdentityConstraints(),
                PassthroughExtensions = new CertificateExtensionConstraints(),
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
            mockGrpcClient.Setup(x => x.GetCertificateTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateTemplate response = client.GetCertificateTemplate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateTemplateAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateTemplateRequest request = new GetCertificateTemplateRequest
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
            };
            CertificateTemplate expectedResponse = new CertificateTemplate
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                PredefinedValues = new X509Parameters(),
                IdentityConstraints = new CertificateIdentityConstraints(),
                PassthroughExtensions = new CertificateExtensionConstraints(),
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
            mockGrpcClient.Setup(x => x.GetCertificateTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateTemplate responseCallSettings = await client.GetCertificateTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateTemplate responseCancellationToken = await client.GetCertificateTemplateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateTemplateResourceNames()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateTemplateRequest request = new GetCertificateTemplateRequest
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
            };
            CertificateTemplate expectedResponse = new CertificateTemplate
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                PredefinedValues = new X509Parameters(),
                IdentityConstraints = new CertificateIdentityConstraints(),
                PassthroughExtensions = new CertificateExtensionConstraints(),
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
            mockGrpcClient.Setup(x => x.GetCertificateTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateTemplate response = client.GetCertificateTemplate(request.CertificateTemplateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateTemplateResourceNamesAsync()
        {
            moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<CertificateAuthorityService.CertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetCertificateTemplateRequest request = new GetCertificateTemplateRequest
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
            };
            CertificateTemplate expectedResponse = new CertificateTemplate
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                PredefinedValues = new X509Parameters(),
                IdentityConstraints = new CertificateIdentityConstraints(),
                PassthroughExtensions = new CertificateExtensionConstraints(),
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
            mockGrpcClient.Setup(x => x.GetCertificateTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateAuthorityServiceClient client = new CertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            CertificateTemplate responseCallSettings = await client.GetCertificateTemplateAsync(request.CertificateTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateTemplate responseCancellationToken = await client.GetCertificateTemplateAsync(request.CertificateTemplateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
