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
    public sealed class GeneratedGlobalForwardingRulesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalForwardingRuleRequest request = new GetGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
            };
            ForwardingRule expectedResponse = new ForwardingRule
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IPAddress = "I_p_addressf1537179",
                Ports = { "ports9860f047", },
                IsMirroringCollector = false,
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                PscConnectionStatus = "psc_connection_status437a3762",
                Target = "targetaefbae42",
                PortRange = "port_ranged4420f7d",
                ServiceDirectoryRegistrations =
                {
                    new ForwardingRuleServiceDirectoryRegistration(),
                },
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                PscConnectionId = 1768355415909345202UL,
                IpVersion = "ip_versionde91b460",
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = "load_balancing_scheme21346104",
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                IPProtocol = "I_p_protocold854c15f",
                AllowGlobalAccess = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkTier = "network_tiere6fea951",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            ForwardingRule response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalForwardingRuleRequest request = new GetGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
            };
            ForwardingRule expectedResponse = new ForwardingRule
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IPAddress = "I_p_addressf1537179",
                Ports = { "ports9860f047", },
                IsMirroringCollector = false,
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                PscConnectionStatus = "psc_connection_status437a3762",
                Target = "targetaefbae42",
                PortRange = "port_ranged4420f7d",
                ServiceDirectoryRegistrations =
                {
                    new ForwardingRuleServiceDirectoryRegistration(),
                },
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                PscConnectionId = 1768355415909345202UL,
                IpVersion = "ip_versionde91b460",
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = "load_balancing_scheme21346104",
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                IPProtocol = "I_p_protocold854c15f",
                AllowGlobalAccess = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkTier = "network_tiere6fea951",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ForwardingRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            ForwardingRule responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ForwardingRule responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalForwardingRuleRequest request = new GetGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
            };
            ForwardingRule expectedResponse = new ForwardingRule
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IPAddress = "I_p_addressf1537179",
                Ports = { "ports9860f047", },
                IsMirroringCollector = false,
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                PscConnectionStatus = "psc_connection_status437a3762",
                Target = "targetaefbae42",
                PortRange = "port_ranged4420f7d",
                ServiceDirectoryRegistrations =
                {
                    new ForwardingRuleServiceDirectoryRegistration(),
                },
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                PscConnectionId = 1768355415909345202UL,
                IpVersion = "ip_versionde91b460",
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = "load_balancing_scheme21346104",
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                IPProtocol = "I_p_protocold854c15f",
                AllowGlobalAccess = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkTier = "network_tiere6fea951",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            ForwardingRule response = client.Get(request.Project, request.ForwardingRule);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalForwardingRuleRequest request = new GetGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
            };
            ForwardingRule expectedResponse = new ForwardingRule
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IPAddress = "I_p_addressf1537179",
                Ports = { "ports9860f047", },
                IsMirroringCollector = false,
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                PscConnectionStatus = "psc_connection_status437a3762",
                Target = "targetaefbae42",
                PortRange = "port_ranged4420f7d",
                ServiceDirectoryRegistrations =
                {
                    new ForwardingRuleServiceDirectoryRegistration(),
                },
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                PscConnectionId = 1768355415909345202UL,
                IpVersion = "ip_versionde91b460",
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = "load_balancing_scheme21346104",
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                IPProtocol = "I_p_protocold854c15f",
                AllowGlobalAccess = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkTier = "network_tiere6fea951",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ForwardingRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            ForwardingRule responseCallSettings = await client.GetAsync(request.Project, request.ForwardingRule, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ForwardingRule responseCancellationToken = await client.GetAsync(request.Project, request.ForwardingRule, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
