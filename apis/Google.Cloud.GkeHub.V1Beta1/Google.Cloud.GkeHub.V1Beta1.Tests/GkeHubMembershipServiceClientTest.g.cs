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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.GkeHub.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGkeHubMembershipServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetMembershipRequestObject()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Authority = new Authority(),
                ExternalId = "external_id9442680e",
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembership(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            Membership response = client.GetMembership(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMembershipRequestObjectAsync()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Authority = new Authority(),
                ExternalId = "external_id9442680e",
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembershipAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Membership>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            Membership responseCallSettings = await client.GetMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Membership responseCancellationToken = await client.GetMembershipAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMembership()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Authority = new Authority(),
                ExternalId = "external_id9442680e",
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembership(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            Membership response = client.GetMembership(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMembershipAsync()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Authority = new Authority(),
                ExternalId = "external_id9442680e",
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembershipAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Membership>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            Membership responseCallSettings = await client.GetMembershipAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Membership responseCancellationToken = await client.GetMembershipAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMembershipResourceNames()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Authority = new Authority(),
                ExternalId = "external_id9442680e",
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembership(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            Membership response = client.GetMembership(request.MembershipName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMembershipResourceNamesAsync()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            Membership expectedResponse = new Membership
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Endpoint = new MembershipEndpoint(),
                State = new MembershipState(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Authority = new Authority(),
                ExternalId = "external_id9442680e",
                LastConnectionTime = new wkt::Timestamp(),
                UniqueId = "unique_idee0c0869",
                InfrastructureType = Membership.Types.InfrastructureType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetMembershipAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Membership>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            Membership responseCallSettings = await client.GetMembershipAsync(request.MembershipName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Membership responseCancellationToken = await client.GetMembershipAsync(request.MembershipName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateConnectManifestRequestObject()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GenerateConnectManifestRequest request = new GenerateConnectManifestRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                ConnectAgent = new ConnectAgent(),
                Version = "version102ff72a",
                IsUpgrade = false,
                Registry = "registrycf5d20a9",
                ImagePullSecretContent = proto::ByteString.CopyFromUtf8("image_pull_secret_content89fc8e49"),
            };
            GenerateConnectManifestResponse expectedResponse = new GenerateConnectManifestResponse
            {
                Manifest =
                {
                    new ConnectAgentResource(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateConnectManifest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            GenerateConnectManifestResponse response = client.GenerateConnectManifest(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateConnectManifestRequestObjectAsync()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GenerateConnectManifestRequest request = new GenerateConnectManifestRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                ConnectAgent = new ConnectAgent(),
                Version = "version102ff72a",
                IsUpgrade = false,
                Registry = "registrycf5d20a9",
                ImagePullSecretContent = proto::ByteString.CopyFromUtf8("image_pull_secret_content89fc8e49"),
            };
            GenerateConnectManifestResponse expectedResponse = new GenerateConnectManifestResponse
            {
                Manifest =
                {
                    new ConnectAgentResource(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateConnectManifestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateConnectManifestResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            GenerateConnectManifestResponse responseCallSettings = await client.GenerateConnectManifestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateConnectManifestResponse responseCancellationToken = await client.GenerateConnectManifestAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ValidateExclusivityRequestObject()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ValidateExclusivityRequest request = new ValidateExclusivityRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CrManifest = "cr_manifestdf1378ad",
                IntendedMembership = "intended_membership4a00bbcb",
            };
            ValidateExclusivityResponse expectedResponse = new ValidateExclusivityResponse
            {
                Status = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ValidateExclusivity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            ValidateExclusivityResponse response = client.ValidateExclusivity(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateExclusivityRequestObjectAsync()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ValidateExclusivityRequest request = new ValidateExclusivityRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CrManifest = "cr_manifestdf1378ad",
                IntendedMembership = "intended_membership4a00bbcb",
            };
            ValidateExclusivityResponse expectedResponse = new ValidateExclusivityResponse
            {
                Status = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ValidateExclusivityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ValidateExclusivityResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            ValidateExclusivityResponse responseCallSettings = await client.ValidateExclusivityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ValidateExclusivityResponse responseCancellationToken = await client.ValidateExclusivityAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateExclusivityManifestRequestObject()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GenerateExclusivityManifestRequest request = new GenerateExclusivityManifestRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                CrdManifest = "crd_manifest09dc10bb",
                CrManifest = "cr_manifestdf1378ad",
            };
            GenerateExclusivityManifestResponse expectedResponse = new GenerateExclusivityManifestResponse
            {
                CrdManifest = "crd_manifest09dc10bb",
                CrManifest = "cr_manifestdf1378ad",
            };
            mockGrpcClient.Setup(x => x.GenerateExclusivityManifest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            GenerateExclusivityManifestResponse response = client.GenerateExclusivityManifest(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateExclusivityManifestRequestObjectAsync()
        {
            moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient> mockGrpcClient = new moq::Mock<GkeHubMembershipService.GkeHubMembershipServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GenerateExclusivityManifestRequest request = new GenerateExclusivityManifestRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                CrdManifest = "crd_manifest09dc10bb",
                CrManifest = "cr_manifestdf1378ad",
            };
            GenerateExclusivityManifestResponse expectedResponse = new GenerateExclusivityManifestResponse
            {
                CrdManifest = "crd_manifest09dc10bb",
                CrManifest = "cr_manifestdf1378ad",
            };
            mockGrpcClient.Setup(x => x.GenerateExclusivityManifestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateExclusivityManifestResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GkeHubMembershipServiceClient client = new GkeHubMembershipServiceClientImpl(mockGrpcClient.Object, null);
            GenerateExclusivityManifestResponse responseCallSettings = await client.GenerateExclusivityManifestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateExclusivityManifestResponse responseCancellationToken = await client.GenerateExclusivityManifestAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
