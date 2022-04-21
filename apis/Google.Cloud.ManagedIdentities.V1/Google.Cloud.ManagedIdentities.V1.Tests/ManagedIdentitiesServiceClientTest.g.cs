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

namespace Google.Cloud.ManagedIdentities.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedManagedIdentitiesServiceClientTest
    {
        [xunit::FactAttribute]
        public void ResetAdminPasswordRequestObject()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAdminPasswordRequest request = new ResetAdminPasswordRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            ResetAdminPasswordResponse expectedResponse = new ResetAdminPasswordResponse
            {
                Password = "password3bcc4d5f",
            };
            mockGrpcClient.Setup(x => x.ResetAdminPassword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            ResetAdminPasswordResponse response = client.ResetAdminPassword(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetAdminPasswordRequestObjectAsync()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAdminPasswordRequest request = new ResetAdminPasswordRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            ResetAdminPasswordResponse expectedResponse = new ResetAdminPasswordResponse
            {
                Password = "password3bcc4d5f",
            };
            mockGrpcClient.Setup(x => x.ResetAdminPasswordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ResetAdminPasswordResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            ResetAdminPasswordResponse responseCallSettings = await client.ResetAdminPasswordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ResetAdminPasswordResponse responseCancellationToken = await client.ResetAdminPasswordAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResetAdminPassword()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAdminPasswordRequest request = new ResetAdminPasswordRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            ResetAdminPasswordResponse expectedResponse = new ResetAdminPasswordResponse
            {
                Password = "password3bcc4d5f",
            };
            mockGrpcClient.Setup(x => x.ResetAdminPassword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            ResetAdminPasswordResponse response = client.ResetAdminPassword(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetAdminPasswordAsync()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAdminPasswordRequest request = new ResetAdminPasswordRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            ResetAdminPasswordResponse expectedResponse = new ResetAdminPasswordResponse
            {
                Password = "password3bcc4d5f",
            };
            mockGrpcClient.Setup(x => x.ResetAdminPasswordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ResetAdminPasswordResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            ResetAdminPasswordResponse responseCallSettings = await client.ResetAdminPasswordAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ResetAdminPasswordResponse responseCancellationToken = await client.ResetAdminPasswordAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResetAdminPasswordResourceNames()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAdminPasswordRequest request = new ResetAdminPasswordRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            ResetAdminPasswordResponse expectedResponse = new ResetAdminPasswordResponse
            {
                Password = "password3bcc4d5f",
            };
            mockGrpcClient.Setup(x => x.ResetAdminPassword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            ResetAdminPasswordResponse response = client.ResetAdminPassword(request.DomainName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetAdminPasswordResourceNamesAsync()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAdminPasswordRequest request = new ResetAdminPasswordRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            ResetAdminPasswordResponse expectedResponse = new ResetAdminPasswordResponse
            {
                Password = "password3bcc4d5f",
            };
            mockGrpcClient.Setup(x => x.ResetAdminPasswordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ResetAdminPasswordResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            ResetAdminPasswordResponse responseCallSettings = await client.ResetAdminPasswordAsync(request.DomainName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ResetAdminPasswordResponse responseCancellationToken = await client.ResetAdminPasswordAsync(request.DomainName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDomainRequestObject()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDomainRequest request = new GetDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            Domain expectedResponse = new Domain
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetworks =
                {
                    "authorized_networksfe43416a",
                },
                ReservedIpRange = "reserved_ip_range779ab299",
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                Admin = "admin292f2321",
                Fqdn = "fqdnc75d2ea0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Domain.Types.State.PerformingMaintenance,
                StatusMessage = "status_message2c618f86",
                Trusts = { new Trust(), },
            };
            mockGrpcClient.Setup(x => x.GetDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            Domain response = client.GetDomain(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDomainRequestObjectAsync()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDomainRequest request = new GetDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            Domain expectedResponse = new Domain
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetworks =
                {
                    "authorized_networksfe43416a",
                },
                ReservedIpRange = "reserved_ip_range779ab299",
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                Admin = "admin292f2321",
                Fqdn = "fqdnc75d2ea0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Domain.Types.State.PerformingMaintenance,
                StatusMessage = "status_message2c618f86",
                Trusts = { new Trust(), },
            };
            mockGrpcClient.Setup(x => x.GetDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Domain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            Domain responseCallSettings = await client.GetDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Domain responseCancellationToken = await client.GetDomainAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDomain()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDomainRequest request = new GetDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            Domain expectedResponse = new Domain
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetworks =
                {
                    "authorized_networksfe43416a",
                },
                ReservedIpRange = "reserved_ip_range779ab299",
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                Admin = "admin292f2321",
                Fqdn = "fqdnc75d2ea0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Domain.Types.State.PerformingMaintenance,
                StatusMessage = "status_message2c618f86",
                Trusts = { new Trust(), },
            };
            mockGrpcClient.Setup(x => x.GetDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            Domain response = client.GetDomain(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDomainAsync()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDomainRequest request = new GetDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            Domain expectedResponse = new Domain
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetworks =
                {
                    "authorized_networksfe43416a",
                },
                ReservedIpRange = "reserved_ip_range779ab299",
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                Admin = "admin292f2321",
                Fqdn = "fqdnc75d2ea0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Domain.Types.State.PerformingMaintenance,
                StatusMessage = "status_message2c618f86",
                Trusts = { new Trust(), },
            };
            mockGrpcClient.Setup(x => x.GetDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Domain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            Domain responseCallSettings = await client.GetDomainAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Domain responseCancellationToken = await client.GetDomainAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDomainResourceNames()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDomainRequest request = new GetDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            Domain expectedResponse = new Domain
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetworks =
                {
                    "authorized_networksfe43416a",
                },
                ReservedIpRange = "reserved_ip_range779ab299",
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                Admin = "admin292f2321",
                Fqdn = "fqdnc75d2ea0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Domain.Types.State.PerformingMaintenance,
                StatusMessage = "status_message2c618f86",
                Trusts = { new Trust(), },
            };
            mockGrpcClient.Setup(x => x.GetDomain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            Domain response = client.GetDomain(request.DomainName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDomainResourceNamesAsync()
        {
            moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient> mockGrpcClient = new moq::Mock<ManagedIdentitiesService.ManagedIdentitiesServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDomainRequest request = new GetDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            Domain expectedResponse = new Domain
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AuthorizedNetworks =
                {
                    "authorized_networksfe43416a",
                },
                ReservedIpRange = "reserved_ip_range779ab299",
                Locations =
                {
                    "locationsc7b6c0b4",
                },
                Admin = "admin292f2321",
                Fqdn = "fqdnc75d2ea0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = Domain.Types.State.PerformingMaintenance,
                StatusMessage = "status_message2c618f86",
                Trusts = { new Trust(), },
            };
            mockGrpcClient.Setup(x => x.GetDomainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Domain>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedIdentitiesServiceClient client = new ManagedIdentitiesServiceClientImpl(mockGrpcClient.Object, null, null);
            Domain responseCallSettings = await client.GetDomainAsync(request.DomainName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Domain responseCancellationToken = await client.GetDomainAsync(request.DomainName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
