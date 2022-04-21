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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedNodeGroupsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeGroupRequest request = new GetNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                NodeGroup = "node_groupa42a295a",
            };
            NodeGroup expectedResponse = new NodeGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Status = "status5444cb9a",
                MaintenanceWindow = new NodeGroupMaintenanceWindow(),
                AutoscalingPolicy = new NodeGroupAutoscalingPolicy(),
                Fingerprint = "fingerprint009e6052",
                NodeTemplate = "node_template118e38ae",
                LocationHint = "location_hint666f366c",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                MaintenancePolicy = "maintenance_policy80cc92a6",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            NodeGroup response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeGroupRequest request = new GetNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                NodeGroup = "node_groupa42a295a",
            };
            NodeGroup expectedResponse = new NodeGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Status = "status5444cb9a",
                MaintenanceWindow = new NodeGroupMaintenanceWindow(),
                AutoscalingPolicy = new NodeGroupAutoscalingPolicy(),
                Fingerprint = "fingerprint009e6052",
                NodeTemplate = "node_template118e38ae",
                LocationHint = "location_hint666f366c",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                MaintenancePolicy = "maintenance_policy80cc92a6",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NodeGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            NodeGroup responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NodeGroup responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeGroupRequest request = new GetNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                NodeGroup = "node_groupa42a295a",
            };
            NodeGroup expectedResponse = new NodeGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Status = "status5444cb9a",
                MaintenanceWindow = new NodeGroupMaintenanceWindow(),
                AutoscalingPolicy = new NodeGroupAutoscalingPolicy(),
                Fingerprint = "fingerprint009e6052",
                NodeTemplate = "node_template118e38ae",
                LocationHint = "location_hint666f366c",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                MaintenancePolicy = "maintenance_policy80cc92a6",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            NodeGroup response = client.Get(request.Project, request.Zone, request.NodeGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeGroupRequest request = new GetNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                NodeGroup = "node_groupa42a295a",
            };
            NodeGroup expectedResponse = new NodeGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Status = "status5444cb9a",
                MaintenanceWindow = new NodeGroupMaintenanceWindow(),
                AutoscalingPolicy = new NodeGroupAutoscalingPolicy(),
                Fingerprint = "fingerprint009e6052",
                NodeTemplate = "node_template118e38ae",
                LocationHint = "location_hint666f366c",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                MaintenancePolicy = "maintenance_policy80cc92a6",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NodeGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            NodeGroup responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.NodeGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NodeGroup responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.NodeGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyNodeGroupRequest request = new GetIamPolicyNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                OptionsRequestedPolicyVersion = -1471234741,
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyNodeGroupRequest request = new GetIamPolicyNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                OptionsRequestedPolicyVersion = -1471234741,
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyNodeGroupRequest request = new GetIamPolicyNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            Policy response = client.GetIamPolicy(request.Project, request.Zone, request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyNodeGroupRequest request = new GetIamPolicyNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request.Project, request.Zone, request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Project, request.Zone, request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyNodeGroupRequest request = new SetIamPolicyNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyNodeGroupRequest request = new SetIamPolicyNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyNodeGroupRequest request = new SetIamPolicyNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            Policy response = client.SetIamPolicy(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyNodeGroupRequest request = new SetIamPolicyNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsNodeGroupRequest request = new TestIamPermissionsNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsNodeGroupRequest request = new TestIamPermissionsNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsNodeGroupRequest request = new TestIamPermissionsNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<NodeGroups.NodeGroupsClient> mockGrpcClient = new moq::Mock<NodeGroups.NodeGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsNodeGroupRequest request = new TestIamPermissionsNodeGroupRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeGroupsClient client = new NodeGroupsClientImpl(mockGrpcClient.Object, null, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
