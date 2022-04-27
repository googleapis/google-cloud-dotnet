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
    public sealed class GeneratedFirewallPoliciesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFirewallPolicyRequest request = new GetFirewallPolicyRequest
            {
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFirewallPolicyRequest request = new GetFirewallPolicyRequest
            {
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicy responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicy responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFirewallPolicyRequest request = new GetFirewallPolicyRequest
            {
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicy response = client.Get(request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFirewallPolicyRequest request = new GetFirewallPolicyRequest
            {
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicy responseCallSettings = await client.GetAsync(request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicy responseCancellationToken = await client.GetAsync(request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAssociationRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssociationFirewallPolicyRequest request = new GetAssociationFirewallPolicyRequest
            {
                Name = "name1c9368b0",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicyAssociation response = client.GetAssociation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAssociationRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssociationFirewallPolicyRequest request = new GetAssociationFirewallPolicyRequest
            {
                Name = "name1c9368b0",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicyAssociation responseCallSettings = await client.GetAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicyAssociation responseCancellationToken = await client.GetAssociationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAssociation()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssociationFirewallPolicyRequest request = new GetAssociationFirewallPolicyRequest
            {
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicyAssociation response = client.GetAssociation(request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAssociationAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAssociationFirewallPolicyRequest request = new GetAssociationFirewallPolicyRequest
            {
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicyAssociation responseCallSettings = await client.GetAssociationAsync(request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicyAssociation responseCancellationToken = await client.GetAssociationAsync(request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyFirewallPolicyRequest request = new GetIamPolicyFirewallPolicyRequest
            {
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyFirewallPolicyRequest request = new GetIamPolicyFirewallPolicyRequest
            {
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyFirewallPolicyRequest request = new GetIamPolicyFirewallPolicyRequest
            {
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyFirewallPolicyRequest request = new GetIamPolicyFirewallPolicyRequest
            {
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRuleRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleFirewallPolicyRequest request = new GetRuleFirewallPolicyRequest
            {
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicyRule response = client.GetRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuleRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleFirewallPolicyRequest request = new GetRuleFirewallPolicyRequest
            {
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicyRule responseCallSettings = await client.GetRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicyRule responseCancellationToken = await client.GetRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRule()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleFirewallPolicyRequest request = new GetRuleFirewallPolicyRequest
            {
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicyRule response = client.GetRule(request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuleAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleFirewallPolicyRequest request = new GetRuleFirewallPolicyRequest
            {
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPolicyRule responseCallSettings = await client.GetRuleAsync(request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicyRule responseCancellationToken = await client.GetRuleAsync(request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListAssociationsRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListAssociationsFirewallPolicyRequest request = new ListAssociationsFirewallPolicyRequest
            {
                TargetResource = "target_resource7041731f",
            };
            FirewallPoliciesListAssociationsResponse expectedResponse = new FirewallPoliciesListAssociationsResponse
            {
                Kind = "kindf7aa39d9",
                Associations =
                {
                    new FirewallPolicyAssociation(),
                },
            };
            mockGrpcClient.Setup(x => x.ListAssociations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPoliciesListAssociationsResponse response = client.ListAssociations(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAssociationsRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListAssociationsFirewallPolicyRequest request = new ListAssociationsFirewallPolicyRequest
            {
                TargetResource = "target_resource7041731f",
            };
            FirewallPoliciesListAssociationsResponse expectedResponse = new FirewallPoliciesListAssociationsResponse
            {
                Kind = "kindf7aa39d9",
                Associations =
                {
                    new FirewallPolicyAssociation(),
                },
            };
            mockGrpcClient.Setup(x => x.ListAssociationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallPoliciesListAssociationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPoliciesListAssociationsResponse responseCallSettings = await client.ListAssociationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPoliciesListAssociationsResponse responseCancellationToken = await client.ListAssociationsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListAssociations()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListAssociationsFirewallPolicyRequest request = new ListAssociationsFirewallPolicyRequest { };
            FirewallPoliciesListAssociationsResponse expectedResponse = new FirewallPoliciesListAssociationsResponse
            {
                Kind = "kindf7aa39d9",
                Associations =
                {
                    new FirewallPolicyAssociation(),
                },
            };
            mockGrpcClient.Setup(x => x.ListAssociations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPoliciesListAssociationsResponse response = client.ListAssociations();
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAssociationsAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListAssociationsFirewallPolicyRequest request = new ListAssociationsFirewallPolicyRequest { };
            FirewallPoliciesListAssociationsResponse expectedResponse = new FirewallPoliciesListAssociationsResponse
            {
                Kind = "kindf7aa39d9",
                Associations =
                {
                    new FirewallPolicyAssociation(),
                },
            };
            mockGrpcClient.Setup(x => x.ListAssociationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallPoliciesListAssociationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            FirewallPoliciesListAssociationsResponse responseCallSettings = await client.ListAssociationsAsync(gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPoliciesListAssociationsResponse responseCancellationToken = await client.ListAssociationsAsync(st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyFirewallPolicyRequest request = new SetIamPolicyFirewallPolicyRequest
            {
                GlobalOrganizationSetPolicyRequestResource = new GlobalOrganizationSetPolicyRequest(),
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyFirewallPolicyRequest request = new SetIamPolicyFirewallPolicyRequest
            {
                GlobalOrganizationSetPolicyRequestResource = new GlobalOrganizationSetPolicyRequest(),
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyFirewallPolicyRequest request = new SetIamPolicyFirewallPolicyRequest
            {
                GlobalOrganizationSetPolicyRequestResource = new GlobalOrganizationSetPolicyRequest(),
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy response = client.SetIamPolicy(request.Resource, request.GlobalOrganizationSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyFirewallPolicyRequest request = new SetIamPolicyFirewallPolicyRequest
            {
                GlobalOrganizationSetPolicyRequestResource = new GlobalOrganizationSetPolicyRequest(),
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.GlobalOrganizationSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.GlobalOrganizationSetPolicyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsFirewallPolicyRequest request = new TestIamPermissionsFirewallPolicyRequest
            {
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsFirewallPolicyRequest request = new TestIamPermissionsFirewallPolicyRequest
            {
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsFirewallPolicyRequest request = new TestIamPermissionsFirewallPolicyRequest
            {
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOrganizationOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsFirewallPolicyRequest request = new TestIamPermissionsFirewallPolicyRequest
            {
                Resource = "resource164eab96",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
