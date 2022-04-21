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

using ga = Google.Api;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Run.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedServicesClientTest
    {
        [xunit::FactAttribute]
        public void GetServiceRequestObject()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Description = "description2cf9da67",
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastModifier = "last_modifier593fa784",
                Client = "client088e6062",
                ClientVersion = "client_version92be8ead",
                Ingress = IngressTraffic.All,
                LaunchStage = ga::LaunchStage.Unspecified,
                BinaryAuthorization = new BinaryAuthorization(),
                Template = new RevisionTemplate(),
                Traffic =
                {
                    new TrafficTarget(),
                },
                ObservedGeneration = -4521268473882310455L,
                TerminalCondition = new Condition(),
                Conditions = { new Condition(), },
                LatestReadyRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                LatestCreatedRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                TrafficStatuses =
                {
                    new TrafficTargetStatus(),
                },
                Uri = "uri3db70593",
                Reconciling = false,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            Service response = client.GetService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceRequestObjectAsync()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Description = "description2cf9da67",
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastModifier = "last_modifier593fa784",
                Client = "client088e6062",
                ClientVersion = "client_version92be8ead",
                Ingress = IngressTraffic.All,
                LaunchStage = ga::LaunchStage.Unspecified,
                BinaryAuthorization = new BinaryAuthorization(),
                Template = new RevisionTemplate(),
                Traffic =
                {
                    new TrafficTarget(),
                },
                ObservedGeneration = -4521268473882310455L,
                TerminalCondition = new Condition(),
                Conditions = { new Condition(), },
                LatestReadyRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                LatestCreatedRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                TrafficStatuses =
                {
                    new TrafficTargetStatus(),
                },
                Uri = "uri3db70593",
                Reconciling = false,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            Service responseCallSettings = await client.GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetService()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Description = "description2cf9da67",
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastModifier = "last_modifier593fa784",
                Client = "client088e6062",
                ClientVersion = "client_version92be8ead",
                Ingress = IngressTraffic.All,
                LaunchStage = ga::LaunchStage.Unspecified,
                BinaryAuthorization = new BinaryAuthorization(),
                Template = new RevisionTemplate(),
                Traffic =
                {
                    new TrafficTarget(),
                },
                ObservedGeneration = -4521268473882310455L,
                TerminalCondition = new Condition(),
                Conditions = { new Condition(), },
                LatestReadyRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                LatestCreatedRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                TrafficStatuses =
                {
                    new TrafficTargetStatus(),
                },
                Uri = "uri3db70593",
                Reconciling = false,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            Service response = client.GetService(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAsync()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Description = "description2cf9da67",
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastModifier = "last_modifier593fa784",
                Client = "client088e6062",
                ClientVersion = "client_version92be8ead",
                Ingress = IngressTraffic.All,
                LaunchStage = ga::LaunchStage.Unspecified,
                BinaryAuthorization = new BinaryAuthorization(),
                Template = new RevisionTemplate(),
                Traffic =
                {
                    new TrafficTarget(),
                },
                ObservedGeneration = -4521268473882310455L,
                TerminalCondition = new Condition(),
                Conditions = { new Condition(), },
                LatestReadyRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                LatestCreatedRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                TrafficStatuses =
                {
                    new TrafficTargetStatus(),
                },
                Uri = "uri3db70593",
                Reconciling = false,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            Service responseCallSettings = await client.GetServiceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceResourceNames()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Description = "description2cf9da67",
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastModifier = "last_modifier593fa784",
                Client = "client088e6062",
                ClientVersion = "client_version92be8ead",
                Ingress = IngressTraffic.All,
                LaunchStage = ga::LaunchStage.Unspecified,
                BinaryAuthorization = new BinaryAuthorization(),
                Template = new RevisionTemplate(),
                Traffic =
                {
                    new TrafficTarget(),
                },
                ObservedGeneration = -4521268473882310455L,
                TerminalCondition = new Condition(),
                Conditions = { new Condition(), },
                LatestReadyRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                LatestCreatedRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                TrafficStatuses =
                {
                    new TrafficTargetStatus(),
                },
                Uri = "uri3db70593",
                Reconciling = false,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            Service response = client.GetService(request.ServiceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceResourceNamesAsync()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Description = "description2cf9da67",
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastModifier = "last_modifier593fa784",
                Client = "client088e6062",
                ClientVersion = "client_version92be8ead",
                Ingress = IngressTraffic.All,
                LaunchStage = ga::LaunchStage.Unspecified,
                BinaryAuthorization = new BinaryAuthorization(),
                Template = new RevisionTemplate(),
                Traffic =
                {
                    new TrafficTarget(),
                },
                ObservedGeneration = -4521268473882310455L,
                TerminalCondition = new Condition(),
                Conditions = { new Condition(), },
                LatestReadyRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                LatestCreatedRevisionAsRevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                TrafficStatuses =
                {
                    new TrafficTargetStatus(),
                },
                Uri = "uri3db70593",
                Reconciling = false,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            Service responseCallSettings = await client.GetServiceAsync(request.ServiceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request.ServiceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<Services.ServicesClient> mockGrpcClient = new moq::Mock<Services.ServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServicesClient client = new ServicesClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
