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
    public sealed class GeneratedSecurityPoliciesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSecurityPolicyRequest request = new GetSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
            };
            SecurityPolicy expectedResponse = new SecurityPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                Rules =
                {
                    new SecurityPolicyRule(),
                },
                AdaptiveProtectionConfig = new SecurityPolicyAdaptiveProtectionConfig(),
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                AdvancedOptionsConfig = new SecurityPolicyAdvancedOptionsConfig(),
                SelfLink = "self_link7e87f12d",
                RecaptchaOptionsConfig = new SecurityPolicyRecaptchaOptionsConfig(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSecurityPolicyRequest request = new GetSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
            };
            SecurityPolicy expectedResponse = new SecurityPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                Rules =
                {
                    new SecurityPolicyRule(),
                },
                AdaptiveProtectionConfig = new SecurityPolicyAdaptiveProtectionConfig(),
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                AdvancedOptionsConfig = new SecurityPolicyAdvancedOptionsConfig(),
                SelfLink = "self_link7e87f12d",
                RecaptchaOptionsConfig = new SecurityPolicyRecaptchaOptionsConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecurityPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicy responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecurityPolicy responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSecurityPolicyRequest request = new GetSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
            };
            SecurityPolicy expectedResponse = new SecurityPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                Rules =
                {
                    new SecurityPolicyRule(),
                },
                AdaptiveProtectionConfig = new SecurityPolicyAdaptiveProtectionConfig(),
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                AdvancedOptionsConfig = new SecurityPolicyAdvancedOptionsConfig(),
                SelfLink = "self_link7e87f12d",
                RecaptchaOptionsConfig = new SecurityPolicyRecaptchaOptionsConfig(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicy response = client.Get(request.Project, request.SecurityPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSecurityPolicyRequest request = new GetSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
            };
            SecurityPolicy expectedResponse = new SecurityPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                CreationTimestamp = "creation_timestamp235e59a1",
                Rules =
                {
                    new SecurityPolicyRule(),
                },
                AdaptiveProtectionConfig = new SecurityPolicyAdaptiveProtectionConfig(),
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                AdvancedOptionsConfig = new SecurityPolicyAdvancedOptionsConfig(),
                SelfLink = "self_link7e87f12d",
                RecaptchaOptionsConfig = new SecurityPolicyRecaptchaOptionsConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecurityPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicy responseCallSettings = await client.GetAsync(request.Project, request.SecurityPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecurityPolicy responseCancellationToken = await client.GetAsync(request.Project, request.SecurityPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRuleRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleSecurityPolicyRequest request = new GetRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                Priority = 1546225849,
            };
            SecurityPolicyRule expectedResponse = new SecurityPolicyRule
            {
                Kind = "kindf7aa39d9",
                RateLimitOptions = new SecurityPolicyRuleRateLimitOptions(),
                Match = new SecurityPolicyRuleMatcher(),
                RedirectOptions = new SecurityPolicyRuleRedirectOptions(),
                Action = "action09558c41",
                Preview = true,
                HeaderAction = new SecurityPolicyRuleHttpHeaderAction(),
                Description = "description2cf9da67",
                Priority = 1546225849,
            };
            mockGrpcClient.Setup(x => x.GetRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicyRule response = client.GetRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuleRequestObjectAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleSecurityPolicyRequest request = new GetRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                Priority = 1546225849,
            };
            SecurityPolicyRule expectedResponse = new SecurityPolicyRule
            {
                Kind = "kindf7aa39d9",
                RateLimitOptions = new SecurityPolicyRuleRateLimitOptions(),
                Match = new SecurityPolicyRuleMatcher(),
                RedirectOptions = new SecurityPolicyRuleRedirectOptions(),
                Action = "action09558c41",
                Preview = true,
                HeaderAction = new SecurityPolicyRuleHttpHeaderAction(),
                Description = "description2cf9da67",
                Priority = 1546225849,
            };
            mockGrpcClient.Setup(x => x.GetRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecurityPolicyRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicyRule responseCallSettings = await client.GetRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecurityPolicyRule responseCancellationToken = await client.GetRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRule()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleSecurityPolicyRequest request = new GetRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
            };
            SecurityPolicyRule expectedResponse = new SecurityPolicyRule
            {
                Kind = "kindf7aa39d9",
                RateLimitOptions = new SecurityPolicyRuleRateLimitOptions(),
                Match = new SecurityPolicyRuleMatcher(),
                RedirectOptions = new SecurityPolicyRuleRedirectOptions(),
                Action = "action09558c41",
                Preview = true,
                HeaderAction = new SecurityPolicyRuleHttpHeaderAction(),
                Description = "description2cf9da67",
                Priority = 1546225849,
            };
            mockGrpcClient.Setup(x => x.GetRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicyRule response = client.GetRule(request.Project, request.SecurityPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuleAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRuleSecurityPolicyRequest request = new GetRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
            };
            SecurityPolicyRule expectedResponse = new SecurityPolicyRule
            {
                Kind = "kindf7aa39d9",
                RateLimitOptions = new SecurityPolicyRuleRateLimitOptions(),
                Match = new SecurityPolicyRuleMatcher(),
                RedirectOptions = new SecurityPolicyRuleRedirectOptions(),
                Action = "action09558c41",
                Preview = true,
                HeaderAction = new SecurityPolicyRuleHttpHeaderAction(),
                Description = "description2cf9da67",
                Priority = 1546225849,
            };
            mockGrpcClient.Setup(x => x.GetRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecurityPolicyRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicyRule responseCallSettings = await client.GetRuleAsync(request.Project, request.SecurityPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecurityPolicyRule responseCancellationToken = await client.GetRuleAsync(request.Project, request.SecurityPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListPreconfiguredExpressionSetsRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListPreconfiguredExpressionSetsSecurityPoliciesRequest request = new ListPreconfiguredExpressionSetsSecurityPoliciesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            SecurityPoliciesListPreconfiguredExpressionSetsResponse expectedResponse = new SecurityPoliciesListPreconfiguredExpressionSetsResponse
            {
                PreconfiguredExpressionSets = new SecurityPoliciesWafConfig(),
            };
            mockGrpcClient.Setup(x => x.ListPreconfiguredExpressionSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPoliciesListPreconfiguredExpressionSetsResponse response = client.ListPreconfiguredExpressionSets(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListPreconfiguredExpressionSetsRequestObjectAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListPreconfiguredExpressionSetsSecurityPoliciesRequest request = new ListPreconfiguredExpressionSetsSecurityPoliciesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            SecurityPoliciesListPreconfiguredExpressionSetsResponse expectedResponse = new SecurityPoliciesListPreconfiguredExpressionSetsResponse
            {
                PreconfiguredExpressionSets = new SecurityPoliciesWafConfig(),
            };
            mockGrpcClient.Setup(x => x.ListPreconfiguredExpressionSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecurityPoliciesListPreconfiguredExpressionSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPoliciesListPreconfiguredExpressionSetsResponse responseCallSettings = await client.ListPreconfiguredExpressionSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecurityPoliciesListPreconfiguredExpressionSetsResponse responseCancellationToken = await client.ListPreconfiguredExpressionSetsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListPreconfiguredExpressionSets()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListPreconfiguredExpressionSetsSecurityPoliciesRequest request = new ListPreconfiguredExpressionSetsSecurityPoliciesRequest
            {
                Project = "projectaa6ff846",
            };
            SecurityPoliciesListPreconfiguredExpressionSetsResponse expectedResponse = new SecurityPoliciesListPreconfiguredExpressionSetsResponse
            {
                PreconfiguredExpressionSets = new SecurityPoliciesWafConfig(),
            };
            mockGrpcClient.Setup(x => x.ListPreconfiguredExpressionSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPoliciesListPreconfiguredExpressionSetsResponse response = client.ListPreconfiguredExpressionSets(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListPreconfiguredExpressionSetsAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListPreconfiguredExpressionSetsSecurityPoliciesRequest request = new ListPreconfiguredExpressionSetsSecurityPoliciesRequest
            {
                Project = "projectaa6ff846",
            };
            SecurityPoliciesListPreconfiguredExpressionSetsResponse expectedResponse = new SecurityPoliciesListPreconfiguredExpressionSetsResponse
            {
                PreconfiguredExpressionSets = new SecurityPoliciesWafConfig(),
            };
            mockGrpcClient.Setup(x => x.ListPreconfiguredExpressionSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecurityPoliciesListPreconfiguredExpressionSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPoliciesListPreconfiguredExpressionSetsResponse responseCallSettings = await client.ListPreconfiguredExpressionSetsAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecurityPoliciesListPreconfiguredExpressionSetsResponse responseCancellationToken = await client.ListPreconfiguredExpressionSetsAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
