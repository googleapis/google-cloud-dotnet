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
    public sealed class GeneratedRegionNetworkFirewallPoliciesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionNetworkFirewallPolicyRequest request = new GetRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicy expectedResponse = new FirewallPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                Parent = "parent7858e4d0",
                Rules =
                {
                    new FirewallPolicyRule(),
                },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                RuleTupleCount = -1393850828,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ShortName = "short_namec7ba9846",
                Associations =
                {
                    new FirewallPolicyAssociation(),
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionNetworkFirewallPolicyRequest request = new GetRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicy expectedResponse = new FirewallPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                Parent = "parent7858e4d0",
                Rules =
                {
                    new FirewallPolicyRule(),
                },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                RuleTupleCount = -1393850828,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ShortName = "short_namec7ba9846",
                Associations =
                {
                    new FirewallPolicyAssociation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicy responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicy responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionNetworkFirewallPolicyRequest request = new GetRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicy expectedResponse = new FirewallPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                Parent = "parent7858e4d0",
                Rules =
                {
                    new FirewallPolicyRule(),
                },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                RuleTupleCount = -1393850828,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ShortName = "short_namec7ba9846",
                Associations =
                {
                    new FirewallPolicyAssociation(),
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicy response = client.Get(request.Project, request.Region, request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionNetworkFirewallPolicyRequest request = new GetRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicy expectedResponse = new FirewallPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                Parent = "parent7858e4d0",
                Rules =
                {
                    new FirewallPolicyRule(),
                },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                RuleTupleCount = -1393850828,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ShortName = "short_namec7ba9846",
                Associations =
                {
                    new FirewallPolicyAssociation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicy responseCallSettings = await client.GetAsync(request.Project, request.Region, request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicy responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAssociationRequestObject()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssociationRegionNetworkFirewallPolicyRequest request = new GetAssociationRegionNetworkFirewallPolicyRequest
            {
                Name = "name1c9368b0",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyAssociation expectedResponse = new FirewallPolicyAssociation
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                AttachmentTarget = "attachment_targetf83a4ab8",
                FirewallPolicyId = "firewall_policy_id306dc2cb",
                ShortName = "short_namec7ba9846",
            };
            mockGrpcClient.Setup(x => x.GetAssociation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyAssociation response = client.GetAssociation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAssociationRequestObjectAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssociationRegionNetworkFirewallPolicyRequest request = new GetAssociationRegionNetworkFirewallPolicyRequest
            {
                Name = "name1c9368b0",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyAssociation expectedResponse = new FirewallPolicyAssociation
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                AttachmentTarget = "attachment_targetf83a4ab8",
                FirewallPolicyId = "firewall_policy_id306dc2cb",
                ShortName = "short_namec7ba9846",
            };
            mockGrpcClient.Setup(x => x.GetAssociationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallPolicyAssociation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyAssociation responseCallSettings = await client.GetAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicyAssociation responseCancellationToken = await client.GetAssociationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAssociation()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssociationRegionNetworkFirewallPolicyRequest request = new GetAssociationRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyAssociation expectedResponse = new FirewallPolicyAssociation
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                AttachmentTarget = "attachment_targetf83a4ab8",
                FirewallPolicyId = "firewall_policy_id306dc2cb",
                ShortName = "short_namec7ba9846",
            };
            mockGrpcClient.Setup(x => x.GetAssociation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyAssociation response = client.GetAssociation(request.Project, request.Region, request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAssociationAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssociationRegionNetworkFirewallPolicyRequest request = new GetAssociationRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyAssociation expectedResponse = new FirewallPolicyAssociation
            {
                Name = "name1c9368b0",
                DisplayName = "display_name137f65c2",
                AttachmentTarget = "attachment_targetf83a4ab8",
                FirewallPolicyId = "firewall_policy_id306dc2cb",
                ShortName = "short_namec7ba9846",
            };
            mockGrpcClient.Setup(x => x.GetAssociationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallPolicyAssociation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyAssociation responseCallSettings = await client.GetAssociationAsync(request.Project, request.Region, request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicyAssociation responseCancellationToken = await client.GetAssociationAsync(request.Project, request.Region, request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectiveFirewallsRequestObject()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest request = new GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse expectedResponse = new RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewalls(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse response = client.GetEffectiveFirewalls(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectiveFirewallsRequestObjectAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest request = new GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse expectedResponse = new RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewallsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse responseCallSettings = await client.GetEffectiveFirewallsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse responseCancellationToken = await client.GetEffectiveFirewallsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectiveFirewalls()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest request = new GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse expectedResponse = new RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewalls(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse response = client.GetEffectiveFirewalls(request.Project, request.Region, request.Network);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectiveFirewallsAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest request = new GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse expectedResponse = new RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewallsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse responseCallSettings = await client.GetEffectiveFirewallsAsync(request.Project, request.Region, request.Network, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse responseCancellationToken = await client.GetEffectiveFirewallsAsync(request.Project, request.Region, request.Network, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyRegionNetworkFirewallPolicyRequest request = new GetIamPolicyRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyRegionNetworkFirewallPolicyRequest request = new GetIamPolicyRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyRegionNetworkFirewallPolicyRequest request = new GetIamPolicyRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request.Project, request.Region, request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyRegionNetworkFirewallPolicyRequest request = new GetIamPolicyRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request.Project, request.Region, request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Project, request.Region, request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRuleRequestObject()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleRegionNetworkFirewallPolicyRequest request = new GetRuleRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Priority = 1546225849,
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyRule expectedResponse = new FirewallPolicyRule
            {
                Kind = "kindf7aa39d9",
                RuleName = "rule_namea38fc8f6",
                Match = new FirewallPolicyRuleMatcher(),
                Direction = "direction7bc372ef",
                Action = "action09558c41",
                Disabled = false,
                EnableLogging = false,
                RuleTupleCount = -1393850828,
                Description = "description2cf9da67",
                Priority = 1546225849,
                TargetServiceAccounts =
                {
                    "target_service_accounts61bf1663",
                },
                TargetSecureTags =
                {
                    new FirewallPolicyRuleSecureTag(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
            };
            mockGrpcClient.Setup(x => x.GetRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyRule response = client.GetRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuleRequestObjectAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleRegionNetworkFirewallPolicyRequest request = new GetRuleRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Priority = 1546225849,
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyRule expectedResponse = new FirewallPolicyRule
            {
                Kind = "kindf7aa39d9",
                RuleName = "rule_namea38fc8f6",
                Match = new FirewallPolicyRuleMatcher(),
                Direction = "direction7bc372ef",
                Action = "action09558c41",
                Disabled = false,
                EnableLogging = false,
                RuleTupleCount = -1393850828,
                Description = "description2cf9da67",
                Priority = 1546225849,
                TargetServiceAccounts =
                {
                    "target_service_accounts61bf1663",
                },
                TargetSecureTags =
                {
                    new FirewallPolicyRuleSecureTag(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
            };
            mockGrpcClient.Setup(x => x.GetRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallPolicyRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyRule responseCallSettings = await client.GetRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicyRule responseCancellationToken = await client.GetRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRule()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleRegionNetworkFirewallPolicyRequest request = new GetRuleRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyRule expectedResponse = new FirewallPolicyRule
            {
                Kind = "kindf7aa39d9",
                RuleName = "rule_namea38fc8f6",
                Match = new FirewallPolicyRuleMatcher(),
                Direction = "direction7bc372ef",
                Action = "action09558c41",
                Disabled = false,
                EnableLogging = false,
                RuleTupleCount = -1393850828,
                Description = "description2cf9da67",
                Priority = 1546225849,
                TargetServiceAccounts =
                {
                    "target_service_accounts61bf1663",
                },
                TargetSecureTags =
                {
                    new FirewallPolicyRuleSecureTag(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
            };
            mockGrpcClient.Setup(x => x.GetRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyRule response = client.GetRule(request.Project, request.Region, request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuleAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleRegionNetworkFirewallPolicyRequest request = new GetRuleRegionNetworkFirewallPolicyRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyRule expectedResponse = new FirewallPolicyRule
            {
                Kind = "kindf7aa39d9",
                RuleName = "rule_namea38fc8f6",
                Match = new FirewallPolicyRuleMatcher(),
                Direction = "direction7bc372ef",
                Action = "action09558c41",
                Disabled = false,
                EnableLogging = false,
                RuleTupleCount = -1393850828,
                Description = "description2cf9da67",
                Priority = 1546225849,
                TargetServiceAccounts =
                {
                    "target_service_accounts61bf1663",
                },
                TargetSecureTags =
                {
                    new FirewallPolicyRuleSecureTag(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
            };
            mockGrpcClient.Setup(x => x.GetRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallPolicyRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyRule responseCallSettings = await client.GetRuleAsync(request.Project, request.Region, request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicyRule responseCancellationToken = await client.GetRuleAsync(request.Project, request.Region, request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyRegionNetworkFirewallPolicyRequest request = new SetIamPolicyRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyRegionNetworkFirewallPolicyRequest request = new SetIamPolicyRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyRegionNetworkFirewallPolicyRequest request = new SetIamPolicyRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyRegionNetworkFirewallPolicyRequest request = new SetIamPolicyRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsRegionNetworkFirewallPolicyRequest request = new TestIamPermissionsRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsRegionNetworkFirewallPolicyRequest request = new TestIamPermissionsRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsRegionNetworkFirewallPolicyRequest request = new TestIamPermissionsRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient> mockGrpcClient = new moq::Mock<RegionNetworkFirewallPolicies.RegionNetworkFirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsRegionNetworkFirewallPolicyRequest request = new TestIamPermissionsRegionNetworkFirewallPolicyRequest
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
            RegionNetworkFirewallPoliciesClient client = new RegionNetworkFirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
