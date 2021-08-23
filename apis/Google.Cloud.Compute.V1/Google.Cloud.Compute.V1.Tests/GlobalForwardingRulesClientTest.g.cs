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
        public void DeleteRequestObject()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            DeleteGlobalForwardingRuleRequest request = new DeleteGlobalForwardingRuleRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            DeleteGlobalForwardingRuleRequest request = new DeleteGlobalForwardingRuleRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            DeleteGlobalForwardingRuleRequest request = new DeleteGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.ForwardingRule);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            DeleteGlobalForwardingRuleRequest request = new DeleteGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.ForwardingRule, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.ForwardingRule, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
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
                Target = "targetaefbae42",
                PortRange = "port_ranged4420f7d",
                ServiceDirectoryRegistrations =
                {
                    new ForwardingRuleServiceDirectoryRegistration(),
                },
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                PscConnectionId = 1768355415909345202UL,
                IpVersion = ForwardingRule.Types.IpVersion.UndefinedIpVersion,
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = ForwardingRule.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                IPProtocol = ForwardingRule.Types.IPProtocol.Udp,
                AllowGlobalAccess = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkTier = ForwardingRule.Types.NetworkTier.Standard,
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
                Target = "targetaefbae42",
                PortRange = "port_ranged4420f7d",
                ServiceDirectoryRegistrations =
                {
                    new ForwardingRuleServiceDirectoryRegistration(),
                },
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                PscConnectionId = 1768355415909345202UL,
                IpVersion = ForwardingRule.Types.IpVersion.UndefinedIpVersion,
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = ForwardingRule.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                IPProtocol = ForwardingRule.Types.IPProtocol.Udp,
                AllowGlobalAccess = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkTier = ForwardingRule.Types.NetworkTier.Standard,
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
                Target = "targetaefbae42",
                PortRange = "port_ranged4420f7d",
                ServiceDirectoryRegistrations =
                {
                    new ForwardingRuleServiceDirectoryRegistration(),
                },
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                PscConnectionId = 1768355415909345202UL,
                IpVersion = ForwardingRule.Types.IpVersion.UndefinedIpVersion,
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = ForwardingRule.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                IPProtocol = ForwardingRule.Types.IPProtocol.Udp,
                AllowGlobalAccess = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkTier = ForwardingRule.Types.NetworkTier.Standard,
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
                Target = "targetaefbae42",
                PortRange = "port_ranged4420f7d",
                ServiceDirectoryRegistrations =
                {
                    new ForwardingRuleServiceDirectoryRegistration(),
                },
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                PscConnectionId = 1768355415909345202UL,
                IpVersion = ForwardingRule.Types.IpVersion.UndefinedIpVersion,
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = ForwardingRule.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                IPProtocol = ForwardingRule.Types.IPProtocol.Udp,
                AllowGlobalAccess = false,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkTier = ForwardingRule.Types.NetworkTier.Standard,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ForwardingRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            ForwardingRule responseCallSettings = await client.GetAsync(request.Project, request.ForwardingRule, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ForwardingRule responseCancellationToken = await client.GetAsync(request.Project, request.ForwardingRule, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            InsertGlobalForwardingRuleRequest request = new InsertGlobalForwardingRuleRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ForwardingRuleResource = new ForwardingRule(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            InsertGlobalForwardingRuleRequest request = new InsertGlobalForwardingRuleRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ForwardingRuleResource = new ForwardingRule(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            InsertGlobalForwardingRuleRequest request = new InsertGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRuleResource = new ForwardingRule(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.ForwardingRuleResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            InsertGlobalForwardingRuleRequest request = new InsertGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRuleResource = new ForwardingRule(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.ForwardingRuleResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.ForwardingRuleResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            PatchGlobalForwardingRuleRequest request = new PatchGlobalForwardingRuleRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
                ForwardingRuleResource = new ForwardingRule(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            PatchGlobalForwardingRuleRequest request = new PatchGlobalForwardingRuleRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
                ForwardingRuleResource = new ForwardingRule(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            PatchGlobalForwardingRuleRequest request = new PatchGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
                ForwardingRuleResource = new ForwardingRule(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.ForwardingRule, request.ForwardingRuleResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            PatchGlobalForwardingRuleRequest request = new PatchGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
                ForwardingRuleResource = new ForwardingRule(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.ForwardingRule, request.ForwardingRuleResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.ForwardingRule, request.ForwardingRuleResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLabelsRequestObject()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            SetLabelsGlobalForwardingRuleRequest request = new SetLabelsGlobalForwardingRuleRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLabels(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLabelsRequestObjectAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            SetLabelsGlobalForwardingRuleRequest request = new SetLabelsGlobalForwardingRuleRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLabelsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLabels()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            SetLabelsGlobalForwardingRuleRequest request = new SetLabelsGlobalForwardingRuleRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLabels(request.Project, request.Resource, request.GlobalSetLabelsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLabelsAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            SetLabelsGlobalForwardingRuleRequest request = new SetLabelsGlobalForwardingRuleRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLabelsAsync(request.Project, request.Resource, request.GlobalSetLabelsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLabelsAsync(request.Project, request.Resource, request.GlobalSetLabelsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetTargetRequestObject()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            SetTargetGlobalForwardingRuleRequest request = new SetTargetGlobalForwardingRuleRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
                TargetReferenceResource = new TargetReference(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetTarget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetTarget(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetTargetRequestObjectAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            SetTargetGlobalForwardingRuleRequest request = new SetTargetGlobalForwardingRuleRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
                TargetReferenceResource = new TargetReference(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetTargetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetTargetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetTargetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetTarget()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            SetTargetGlobalForwardingRuleRequest request = new SetTargetGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
                TargetReferenceResource = new TargetReference(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetTarget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetTarget(request.Project, request.ForwardingRule, request.TargetReferenceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetTargetAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            SetTargetGlobalForwardingRuleRequest request = new SetTargetGlobalForwardingRuleRequest
            {
                Project = "projectaa6ff846",
                ForwardingRule = "forwarding_rule51d5478e",
                TargetReferenceResource = new TargetReference(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetTargetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetTargetAsync(request.Project, request.ForwardingRule, request.TargetReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetTargetAsync(request.Project, request.ForwardingRule, request.TargetReferenceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
