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
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSubnetworksClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
            };
            Subnetwork expectedResponse = new Subnetwork
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Role = "role64e9a729",
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = "private_ipv6_google_access0dc5c953",
                IpCidrRange = "ip_cidr_range745a04d3",
                State = "state2e9ed39e",
                SecondaryIpRanges =
                {
                    new SubnetworkSecondaryRange(),
                },
                Region = "regionedb20d96",
                ExternalIpv6Prefix = "external_ipv6_prefix2d3e744d",
                EnableFlowLogs = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Ipv6CidrRange = "ipv6_cidr_range0b2dc35f",
                Purpose = "purposebb6b064d",
                LogConfig = new SubnetworkLogConfig(),
                PrivateIpGoogleAccess = false,
                Description = "description2cf9da67",
                StackType = "stack_type3a495e39",
                SelfLink = "self_link7e87f12d",
                GatewayAddress = "gateway_address39dbeaef",
                Ipv6AccessType = "ipv6_access_type7faa3985",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Subnetwork response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
            };
            Subnetwork expectedResponse = new Subnetwork
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Role = "role64e9a729",
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = "private_ipv6_google_access0dc5c953",
                IpCidrRange = "ip_cidr_range745a04d3",
                State = "state2e9ed39e",
                SecondaryIpRanges =
                {
                    new SubnetworkSecondaryRange(),
                },
                Region = "regionedb20d96",
                ExternalIpv6Prefix = "external_ipv6_prefix2d3e744d",
                EnableFlowLogs = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Ipv6CidrRange = "ipv6_cidr_range0b2dc35f",
                Purpose = "purposebb6b064d",
                LogConfig = new SubnetworkLogConfig(),
                PrivateIpGoogleAccess = false,
                Description = "description2cf9da67",
                StackType = "stack_type3a495e39",
                SelfLink = "self_link7e87f12d",
                GatewayAddress = "gateway_address39dbeaef",
                Ipv6AccessType = "ipv6_access_type7faa3985",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subnetwork>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Subnetwork responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subnetwork responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
            };
            Subnetwork expectedResponse = new Subnetwork
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Role = "role64e9a729",
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = "private_ipv6_google_access0dc5c953",
                IpCidrRange = "ip_cidr_range745a04d3",
                State = "state2e9ed39e",
                SecondaryIpRanges =
                {
                    new SubnetworkSecondaryRange(),
                },
                Region = "regionedb20d96",
                ExternalIpv6Prefix = "external_ipv6_prefix2d3e744d",
                EnableFlowLogs = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Ipv6CidrRange = "ipv6_cidr_range0b2dc35f",
                Purpose = "purposebb6b064d",
                LogConfig = new SubnetworkLogConfig(),
                PrivateIpGoogleAccess = false,
                Description = "description2cf9da67",
                StackType = "stack_type3a495e39",
                SelfLink = "self_link7e87f12d",
                GatewayAddress = "gateway_address39dbeaef",
                Ipv6AccessType = "ipv6_access_type7faa3985",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Subnetwork response = client.Get(request.Project, request.Region, request.Subnetwork);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
            };
            Subnetwork expectedResponse = new Subnetwork
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Role = "role64e9a729",
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = "private_ipv6_google_access0dc5c953",
                IpCidrRange = "ip_cidr_range745a04d3",
                State = "state2e9ed39e",
                SecondaryIpRanges =
                {
                    new SubnetworkSecondaryRange(),
                },
                Region = "regionedb20d96",
                ExternalIpv6Prefix = "external_ipv6_prefix2d3e744d",
                EnableFlowLogs = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Ipv6CidrRange = "ipv6_cidr_range0b2dc35f",
                Purpose = "purposebb6b064d",
                LogConfig = new SubnetworkLogConfig(),
                PrivateIpGoogleAccess = false,
                Description = "description2cf9da67",
                StackType = "stack_type3a495e39",
                SelfLink = "self_link7e87f12d",
                GatewayAddress = "gateway_address39dbeaef",
                Ipv6AccessType = "ipv6_access_type7faa3985",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subnetwork>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Subnetwork responseCallSettings = await client.GetAsync(request.Project, request.Region, request.Subnetwork, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subnetwork responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.Subnetwork, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request.Project, request.Region, request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request.Project, request.Region, request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Project, request.Region, request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
