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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AppEngine.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFirewallClientTest
    {
        [xunit::FactAttribute]
        public void BatchUpdateIngressRulesRequestObject()
        {
            moq::Mock<Firewall.FirewallClient> mockGrpcClient = new moq::Mock<Firewall.FirewallClient>(moq::MockBehavior.Strict);
            BatchUpdateIngressRulesRequest request = new BatchUpdateIngressRulesRequest
            {
                Name = "name1c9368b0",
                IngressRules = { new FirewallRule(), },
            };
            BatchUpdateIngressRulesResponse expectedResponse = new BatchUpdateIngressRulesResponse
            {
                IngressRules = { new FirewallRule(), },
            };
            mockGrpcClient.Setup(x => x.BatchUpdateIngressRules(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallClient client = new FirewallClientImpl(mockGrpcClient.Object, null);
            BatchUpdateIngressRulesResponse response = client.BatchUpdateIngressRules(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchUpdateIngressRulesRequestObjectAsync()
        {
            moq::Mock<Firewall.FirewallClient> mockGrpcClient = new moq::Mock<Firewall.FirewallClient>(moq::MockBehavior.Strict);
            BatchUpdateIngressRulesRequest request = new BatchUpdateIngressRulesRequest
            {
                Name = "name1c9368b0",
                IngressRules = { new FirewallRule(), },
            };
            BatchUpdateIngressRulesResponse expectedResponse = new BatchUpdateIngressRulesResponse
            {
                IngressRules = { new FirewallRule(), },
            };
            mockGrpcClient.Setup(x => x.BatchUpdateIngressRulesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchUpdateIngressRulesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallClient client = new FirewallClientImpl(mockGrpcClient.Object, null);
            BatchUpdateIngressRulesResponse responseCallSettings = await client.BatchUpdateIngressRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchUpdateIngressRulesResponse responseCancellationToken = await client.BatchUpdateIngressRulesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateIngressRuleRequestObject()
        {
            moq::Mock<Firewall.FirewallClient> mockGrpcClient = new moq::Mock<Firewall.FirewallClient>(moq::MockBehavior.Strict);
            CreateIngressRuleRequest request = new CreateIngressRuleRequest
            {
                Parent = "parent7858e4d0",
                Rule = new FirewallRule(),
            };
            FirewallRule expectedResponse = new FirewallRule
            {
                Priority = 1546225849,
                Action = FirewallRule.Types.Action.Deny,
                SourceRange = "source_range8d355d94",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateIngressRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallClient client = new FirewallClientImpl(mockGrpcClient.Object, null);
            FirewallRule response = client.CreateIngressRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateIngressRuleRequestObjectAsync()
        {
            moq::Mock<Firewall.FirewallClient> mockGrpcClient = new moq::Mock<Firewall.FirewallClient>(moq::MockBehavior.Strict);
            CreateIngressRuleRequest request = new CreateIngressRuleRequest
            {
                Parent = "parent7858e4d0",
                Rule = new FirewallRule(),
            };
            FirewallRule expectedResponse = new FirewallRule
            {
                Priority = 1546225849,
                Action = FirewallRule.Types.Action.Deny,
                SourceRange = "source_range8d355d94",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateIngressRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallClient client = new FirewallClientImpl(mockGrpcClient.Object, null);
            FirewallRule responseCallSettings = await client.CreateIngressRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallRule responseCancellationToken = await client.CreateIngressRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIngressRuleRequestObject()
        {
            moq::Mock<Firewall.FirewallClient> mockGrpcClient = new moq::Mock<Firewall.FirewallClient>(moq::MockBehavior.Strict);
            GetIngressRuleRequest request = new GetIngressRuleRequest
            {
                Name = "name1c9368b0",
            };
            FirewallRule expectedResponse = new FirewallRule
            {
                Priority = 1546225849,
                Action = FirewallRule.Types.Action.Deny,
                SourceRange = "source_range8d355d94",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetIngressRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallClient client = new FirewallClientImpl(mockGrpcClient.Object, null);
            FirewallRule response = client.GetIngressRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIngressRuleRequestObjectAsync()
        {
            moq::Mock<Firewall.FirewallClient> mockGrpcClient = new moq::Mock<Firewall.FirewallClient>(moq::MockBehavior.Strict);
            GetIngressRuleRequest request = new GetIngressRuleRequest
            {
                Name = "name1c9368b0",
            };
            FirewallRule expectedResponse = new FirewallRule
            {
                Priority = 1546225849,
                Action = FirewallRule.Types.Action.Deny,
                SourceRange = "source_range8d355d94",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetIngressRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallClient client = new FirewallClientImpl(mockGrpcClient.Object, null);
            FirewallRule responseCallSettings = await client.GetIngressRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallRule responseCancellationToken = await client.GetIngressRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIngressRuleRequestObject()
        {
            moq::Mock<Firewall.FirewallClient> mockGrpcClient = new moq::Mock<Firewall.FirewallClient>(moq::MockBehavior.Strict);
            UpdateIngressRuleRequest request = new UpdateIngressRuleRequest
            {
                Name = "name1c9368b0",
                Rule = new FirewallRule(),
                UpdateMask = new wkt::FieldMask(),
            };
            FirewallRule expectedResponse = new FirewallRule
            {
                Priority = 1546225849,
                Action = FirewallRule.Types.Action.Deny,
                SourceRange = "source_range8d355d94",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateIngressRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallClient client = new FirewallClientImpl(mockGrpcClient.Object, null);
            FirewallRule response = client.UpdateIngressRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIngressRuleRequestObjectAsync()
        {
            moq::Mock<Firewall.FirewallClient> mockGrpcClient = new moq::Mock<Firewall.FirewallClient>(moq::MockBehavior.Strict);
            UpdateIngressRuleRequest request = new UpdateIngressRuleRequest
            {
                Name = "name1c9368b0",
                Rule = new FirewallRule(),
                UpdateMask = new wkt::FieldMask(),
            };
            FirewallRule expectedResponse = new FirewallRule
            {
                Priority = 1546225849,
                Action = FirewallRule.Types.Action.Deny,
                SourceRange = "source_range8d355d94",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateIngressRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallClient client = new FirewallClientImpl(mockGrpcClient.Object, null);
            FirewallRule responseCallSettings = await client.UpdateIngressRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallRule responseCancellationToken = await client.UpdateIngressRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIngressRuleRequestObject()
        {
            moq::Mock<Firewall.FirewallClient> mockGrpcClient = new moq::Mock<Firewall.FirewallClient>(moq::MockBehavior.Strict);
            DeleteIngressRuleRequest request = new DeleteIngressRuleRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIngressRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallClient client = new FirewallClientImpl(mockGrpcClient.Object, null);
            client.DeleteIngressRule(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIngressRuleRequestObjectAsync()
        {
            moq::Mock<Firewall.FirewallClient> mockGrpcClient = new moq::Mock<Firewall.FirewallClient>(moq::MockBehavior.Strict);
            DeleteIngressRuleRequest request = new DeleteIngressRuleRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIngressRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallClient client = new FirewallClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIngressRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIngressRuleAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
