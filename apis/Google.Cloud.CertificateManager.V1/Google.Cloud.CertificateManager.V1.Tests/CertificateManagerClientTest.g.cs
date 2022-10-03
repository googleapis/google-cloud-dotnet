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

namespace Google.Cloud.CertificateManager.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCertificateManagerClientTest
    {
        [xunit::FactAttribute]
        public void GetCertificateRequestObject()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SelfManaged = new Certificate.Types.SelfManagedCertificate(),
                SanDnsnames =
                {
                    "san_dnsnames13887a1b",
                },
                ExpireTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                PemCertificate = "pem_certificate5c1b61ff",
                Managed = new Certificate.Types.ManagedCertificate(),
                Scope = Certificate.Types.Scope.EdgeCache,
            };
            mockGrpcClient.Setup(x => x.GetCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.GetCertificate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateRequestObjectAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SelfManaged = new Certificate.Types.SelfManagedCertificate(),
                SanDnsnames =
                {
                    "san_dnsnames13887a1b",
                },
                ExpireTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                PemCertificate = "pem_certificate5c1b61ff",
                Managed = new Certificate.Types.ManagedCertificate(),
                Scope = Certificate.Types.Scope.EdgeCache,
            };
            mockGrpcClient.Setup(x => x.GetCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            Certificate responseCallSettings = await client.GetCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.GetCertificateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificate()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SelfManaged = new Certificate.Types.SelfManagedCertificate(),
                SanDnsnames =
                {
                    "san_dnsnames13887a1b",
                },
                ExpireTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                PemCertificate = "pem_certificate5c1b61ff",
                Managed = new Certificate.Types.ManagedCertificate(),
                Scope = Certificate.Types.Scope.EdgeCache,
            };
            mockGrpcClient.Setup(x => x.GetCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.GetCertificate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SelfManaged = new Certificate.Types.SelfManagedCertificate(),
                SanDnsnames =
                {
                    "san_dnsnames13887a1b",
                },
                ExpireTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                PemCertificate = "pem_certificate5c1b61ff",
                Managed = new Certificate.Types.ManagedCertificate(),
                Scope = Certificate.Types.Scope.EdgeCache,
            };
            mockGrpcClient.Setup(x => x.GetCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            Certificate responseCallSettings = await client.GetCertificateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.GetCertificateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateResourceNames()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SelfManaged = new Certificate.Types.SelfManagedCertificate(),
                SanDnsnames =
                {
                    "san_dnsnames13887a1b",
                },
                ExpireTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                PemCertificate = "pem_certificate5c1b61ff",
                Managed = new Certificate.Types.ManagedCertificate(),
                Scope = Certificate.Types.Scope.EdgeCache,
            };
            mockGrpcClient.Setup(x => x.GetCertificate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            Certificate response = client.GetCertificate(request.CertificateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateResourceNamesAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
            };
            Certificate expectedResponse = new Certificate
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SelfManaged = new Certificate.Types.SelfManagedCertificate(),
                SanDnsnames =
                {
                    "san_dnsnames13887a1b",
                },
                ExpireTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                PemCertificate = "pem_certificate5c1b61ff",
                Managed = new Certificate.Types.ManagedCertificate(),
                Scope = Certificate.Types.Scope.EdgeCache,
            };
            mockGrpcClient.Setup(x => x.GetCertificateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Certificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            Certificate responseCallSettings = await client.GetCertificateAsync(request.CertificateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Certificate responseCancellationToken = await client.GetCertificateAsync(request.CertificateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateMapRequestObject()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapRequest request = new GetCertificateMapRequest
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
            };
            CertificateMap expectedResponse = new CertificateMap
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GclbTargets =
                {
                    new CertificateMap.Types.GclbTarget(),
                },
                Description = "description2cf9da67",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateMap(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMap response = client.GetCertificateMap(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateMapRequestObjectAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapRequest request = new GetCertificateMapRequest
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
            };
            CertificateMap expectedResponse = new CertificateMap
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GclbTargets =
                {
                    new CertificateMap.Types.GclbTarget(),
                },
                Description = "description2cf9da67",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateMapAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateMap>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMap responseCallSettings = await client.GetCertificateMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateMap responseCancellationToken = await client.GetCertificateMapAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateMap()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapRequest request = new GetCertificateMapRequest
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
            };
            CertificateMap expectedResponse = new CertificateMap
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GclbTargets =
                {
                    new CertificateMap.Types.GclbTarget(),
                },
                Description = "description2cf9da67",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateMap(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMap response = client.GetCertificateMap(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateMapAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapRequest request = new GetCertificateMapRequest
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
            };
            CertificateMap expectedResponse = new CertificateMap
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GclbTargets =
                {
                    new CertificateMap.Types.GclbTarget(),
                },
                Description = "description2cf9da67",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateMapAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateMap>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMap responseCallSettings = await client.GetCertificateMapAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateMap responseCancellationToken = await client.GetCertificateMapAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateMapResourceNames()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapRequest request = new GetCertificateMapRequest
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
            };
            CertificateMap expectedResponse = new CertificateMap
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GclbTargets =
                {
                    new CertificateMap.Types.GclbTarget(),
                },
                Description = "description2cf9da67",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateMap(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMap response = client.GetCertificateMap(request.CertificateMapName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateMapResourceNamesAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapRequest request = new GetCertificateMapRequest
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
            };
            CertificateMap expectedResponse = new CertificateMap
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
                CreateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                GclbTargets =
                {
                    new CertificateMap.Types.GclbTarget(),
                },
                Description = "description2cf9da67",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetCertificateMapAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateMap>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMap responseCallSettings = await client.GetCertificateMapAsync(request.CertificateMapName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateMap responseCancellationToken = await client.GetCertificateMapAsync(request.CertificateMapName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateMapEntryRequestObject()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapEntryRequest request = new GetCertificateMapEntryRequest
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
            };
            CertificateMapEntry expectedResponse = new CertificateMapEntry
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Hostname = "hostnamef4ac9708",
                CertificatesAsCertificateNames =
                {
                    CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                },
                State = ServingState.Unspecified,
                Description = "description2cf9da67",
                Matcher = CertificateMapEntry.Types.Matcher.Primary,
            };
            mockGrpcClient.Setup(x => x.GetCertificateMapEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMapEntry response = client.GetCertificateMapEntry(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateMapEntryRequestObjectAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapEntryRequest request = new GetCertificateMapEntryRequest
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
            };
            CertificateMapEntry expectedResponse = new CertificateMapEntry
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Hostname = "hostnamef4ac9708",
                CertificatesAsCertificateNames =
                {
                    CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                },
                State = ServingState.Unspecified,
                Description = "description2cf9da67",
                Matcher = CertificateMapEntry.Types.Matcher.Primary,
            };
            mockGrpcClient.Setup(x => x.GetCertificateMapEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateMapEntry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMapEntry responseCallSettings = await client.GetCertificateMapEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateMapEntry responseCancellationToken = await client.GetCertificateMapEntryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateMapEntry()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapEntryRequest request = new GetCertificateMapEntryRequest
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
            };
            CertificateMapEntry expectedResponse = new CertificateMapEntry
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Hostname = "hostnamef4ac9708",
                CertificatesAsCertificateNames =
                {
                    CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                },
                State = ServingState.Unspecified,
                Description = "description2cf9da67",
                Matcher = CertificateMapEntry.Types.Matcher.Primary,
            };
            mockGrpcClient.Setup(x => x.GetCertificateMapEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMapEntry response = client.GetCertificateMapEntry(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateMapEntryAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapEntryRequest request = new GetCertificateMapEntryRequest
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
            };
            CertificateMapEntry expectedResponse = new CertificateMapEntry
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Hostname = "hostnamef4ac9708",
                CertificatesAsCertificateNames =
                {
                    CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                },
                State = ServingState.Unspecified,
                Description = "description2cf9da67",
                Matcher = CertificateMapEntry.Types.Matcher.Primary,
            };
            mockGrpcClient.Setup(x => x.GetCertificateMapEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateMapEntry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMapEntry responseCallSettings = await client.GetCertificateMapEntryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateMapEntry responseCancellationToken = await client.GetCertificateMapEntryAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateMapEntryResourceNames()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapEntryRequest request = new GetCertificateMapEntryRequest
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
            };
            CertificateMapEntry expectedResponse = new CertificateMapEntry
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Hostname = "hostnamef4ac9708",
                CertificatesAsCertificateNames =
                {
                    CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                },
                State = ServingState.Unspecified,
                Description = "description2cf9da67",
                Matcher = CertificateMapEntry.Types.Matcher.Primary,
            };
            mockGrpcClient.Setup(x => x.GetCertificateMapEntry(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMapEntry response = client.GetCertificateMapEntry(request.CertificateMapEntryName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateMapEntryResourceNamesAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateMapEntryRequest request = new GetCertificateMapEntryRequest
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
            };
            CertificateMapEntry expectedResponse = new CertificateMapEntry
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Hostname = "hostnamef4ac9708",
                CertificatesAsCertificateNames =
                {
                    CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
                },
                State = ServingState.Unspecified,
                Description = "description2cf9da67",
                Matcher = CertificateMapEntry.Types.Matcher.Primary,
            };
            mockGrpcClient.Setup(x => x.GetCertificateMapEntryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateMapEntry>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateMapEntry responseCallSettings = await client.GetCertificateMapEntryAsync(request.CertificateMapEntryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateMapEntry responseCancellationToken = await client.GetCertificateMapEntryAsync(request.CertificateMapEntryName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDnsAuthorizationRequestObject()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDnsAuthorizationRequest request = new GetDnsAuthorizationRequest
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
            };
            DnsAuthorization expectedResponse = new DnsAuthorization
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Domain = "domaine8825fad",
                DnsResourceRecord = new DnsAuthorization.Types.DnsResourceRecord(),
            };
            mockGrpcClient.Setup(x => x.GetDnsAuthorization(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            DnsAuthorization response = client.GetDnsAuthorization(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDnsAuthorizationRequestObjectAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDnsAuthorizationRequest request = new GetDnsAuthorizationRequest
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
            };
            DnsAuthorization expectedResponse = new DnsAuthorization
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Domain = "domaine8825fad",
                DnsResourceRecord = new DnsAuthorization.Types.DnsResourceRecord(),
            };
            mockGrpcClient.Setup(x => x.GetDnsAuthorizationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DnsAuthorization>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            DnsAuthorization responseCallSettings = await client.GetDnsAuthorizationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DnsAuthorization responseCancellationToken = await client.GetDnsAuthorizationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDnsAuthorization()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDnsAuthorizationRequest request = new GetDnsAuthorizationRequest
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
            };
            DnsAuthorization expectedResponse = new DnsAuthorization
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Domain = "domaine8825fad",
                DnsResourceRecord = new DnsAuthorization.Types.DnsResourceRecord(),
            };
            mockGrpcClient.Setup(x => x.GetDnsAuthorization(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            DnsAuthorization response = client.GetDnsAuthorization(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDnsAuthorizationAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDnsAuthorizationRequest request = new GetDnsAuthorizationRequest
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
            };
            DnsAuthorization expectedResponse = new DnsAuthorization
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Domain = "domaine8825fad",
                DnsResourceRecord = new DnsAuthorization.Types.DnsResourceRecord(),
            };
            mockGrpcClient.Setup(x => x.GetDnsAuthorizationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DnsAuthorization>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            DnsAuthorization responseCallSettings = await client.GetDnsAuthorizationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DnsAuthorization responseCancellationToken = await client.GetDnsAuthorizationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDnsAuthorizationResourceNames()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDnsAuthorizationRequest request = new GetDnsAuthorizationRequest
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
            };
            DnsAuthorization expectedResponse = new DnsAuthorization
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Domain = "domaine8825fad",
                DnsResourceRecord = new DnsAuthorization.Types.DnsResourceRecord(),
            };
            mockGrpcClient.Setup(x => x.GetDnsAuthorization(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            DnsAuthorization response = client.GetDnsAuthorization(request.DnsAuthorizationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDnsAuthorizationResourceNamesAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDnsAuthorizationRequest request = new GetDnsAuthorizationRequest
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
            };
            DnsAuthorization expectedResponse = new DnsAuthorization
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Domain = "domaine8825fad",
                DnsResourceRecord = new DnsAuthorization.Types.DnsResourceRecord(),
            };
            mockGrpcClient.Setup(x => x.GetDnsAuthorizationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DnsAuthorization>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            DnsAuthorization responseCallSettings = await client.GetDnsAuthorizationAsync(request.DnsAuthorizationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DnsAuthorization responseCancellationToken = await client.GetDnsAuthorizationAsync(request.DnsAuthorizationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateIssuanceConfigRequestObject()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateIssuanceConfigRequest request = new GetCertificateIssuanceConfigRequest
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
            };
            CertificateIssuanceConfig expectedResponse = new CertificateIssuanceConfig
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                CertificateAuthorityConfig = new CertificateIssuanceConfig.Types.CertificateAuthorityConfig(),
                Lifetime = new wkt::Duration(),
                RotationWindowPercentage = 1868544779,
                KeyAlgorithm = CertificateIssuanceConfig.Types.KeyAlgorithm.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCertificateIssuanceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateIssuanceConfig response = client.GetCertificateIssuanceConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateIssuanceConfigRequestObjectAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateIssuanceConfigRequest request = new GetCertificateIssuanceConfigRequest
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
            };
            CertificateIssuanceConfig expectedResponse = new CertificateIssuanceConfig
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                CertificateAuthorityConfig = new CertificateIssuanceConfig.Types.CertificateAuthorityConfig(),
                Lifetime = new wkt::Duration(),
                RotationWindowPercentage = 1868544779,
                KeyAlgorithm = CertificateIssuanceConfig.Types.KeyAlgorithm.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCertificateIssuanceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateIssuanceConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateIssuanceConfig responseCallSettings = await client.GetCertificateIssuanceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateIssuanceConfig responseCancellationToken = await client.GetCertificateIssuanceConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateIssuanceConfig()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateIssuanceConfigRequest request = new GetCertificateIssuanceConfigRequest
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
            };
            CertificateIssuanceConfig expectedResponse = new CertificateIssuanceConfig
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                CertificateAuthorityConfig = new CertificateIssuanceConfig.Types.CertificateAuthorityConfig(),
                Lifetime = new wkt::Duration(),
                RotationWindowPercentage = 1868544779,
                KeyAlgorithm = CertificateIssuanceConfig.Types.KeyAlgorithm.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCertificateIssuanceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateIssuanceConfig response = client.GetCertificateIssuanceConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateIssuanceConfigAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateIssuanceConfigRequest request = new GetCertificateIssuanceConfigRequest
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
            };
            CertificateIssuanceConfig expectedResponse = new CertificateIssuanceConfig
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                CertificateAuthorityConfig = new CertificateIssuanceConfig.Types.CertificateAuthorityConfig(),
                Lifetime = new wkt::Duration(),
                RotationWindowPercentage = 1868544779,
                KeyAlgorithm = CertificateIssuanceConfig.Types.KeyAlgorithm.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCertificateIssuanceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateIssuanceConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateIssuanceConfig responseCallSettings = await client.GetCertificateIssuanceConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateIssuanceConfig responseCancellationToken = await client.GetCertificateIssuanceConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCertificateIssuanceConfigResourceNames()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateIssuanceConfigRequest request = new GetCertificateIssuanceConfigRequest
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
            };
            CertificateIssuanceConfig expectedResponse = new CertificateIssuanceConfig
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                CertificateAuthorityConfig = new CertificateIssuanceConfig.Types.CertificateAuthorityConfig(),
                Lifetime = new wkt::Duration(),
                RotationWindowPercentage = 1868544779,
                KeyAlgorithm = CertificateIssuanceConfig.Types.KeyAlgorithm.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCertificateIssuanceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateIssuanceConfig response = client.GetCertificateIssuanceConfig(request.CertificateIssuanceConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCertificateIssuanceConfigResourceNamesAsync()
        {
            moq::Mock<CertificateManager.CertificateManagerClient> mockGrpcClient = new moq::Mock<CertificateManager.CertificateManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetCertificateIssuanceConfigRequest request = new GetCertificateIssuanceConfigRequest
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
            };
            CertificateIssuanceConfig expectedResponse = new CertificateIssuanceConfig
            {
                CertificateIssuanceConfigName = CertificateIssuanceConfigName.FromProjectLocationCertificateIssuanceConfig("[PROJECT]", "[LOCATION]", "[CERTIFICATE_ISSUANCE_CONFIG]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                CertificateAuthorityConfig = new CertificateIssuanceConfig.Types.CertificateAuthorityConfig(),
                Lifetime = new wkt::Duration(),
                RotationWindowPercentage = 1868544779,
                KeyAlgorithm = CertificateIssuanceConfig.Types.KeyAlgorithm.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCertificateIssuanceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CertificateIssuanceConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CertificateManagerClient client = new CertificateManagerClientImpl(mockGrpcClient.Object, null, null);
            CertificateIssuanceConfig responseCallSettings = await client.GetCertificateIssuanceConfigAsync(request.CertificateIssuanceConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CertificateIssuanceConfig responseCancellationToken = await client.GetCertificateIssuanceConfigAsync(request.CertificateIssuanceConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
