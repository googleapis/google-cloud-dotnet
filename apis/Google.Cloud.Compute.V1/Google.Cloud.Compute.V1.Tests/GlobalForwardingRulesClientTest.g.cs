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
                ForwardingRule = "forwarding_rule51d5478e",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRule = "forwarding_rule51d5478e",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRule = "forwarding_rule51d5478e",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRule = "forwarding_rule51d5478e",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRule = "forwarding_rule51d5478e",
                Project = "projectaa6ff846",
            };
            ForwardingRule expectedResponse = new ForwardingRule
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                IpVersion = ForwardingRule.Types.IpVersion.UndefinedIpVersion,
                CreationTimestamp = "creation_timestamp235e59a1",
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                IPProtocol = ForwardingRule.Types.IPProtocol.Ah,
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = ForwardingRule.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                Ports = { "ports9860f047", },
                IsMirroringCollector = false,
                Region = "regionedb20d96",
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                Target = "targetaefbae42",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                PortRange = "port_ranged4420f7d",
                AllowGlobalAccess = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                NetworkTier = ForwardingRule.Types.NetworkTier.Standard,
                IPAddress = "i_p_addresse3ccbaf7",
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
                ForwardingRule = "forwarding_rule51d5478e",
                Project = "projectaa6ff846",
            };
            ForwardingRule expectedResponse = new ForwardingRule
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                IpVersion = ForwardingRule.Types.IpVersion.UndefinedIpVersion,
                CreationTimestamp = "creation_timestamp235e59a1",
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                IPProtocol = ForwardingRule.Types.IPProtocol.Ah,
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = ForwardingRule.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                Ports = { "ports9860f047", },
                IsMirroringCollector = false,
                Region = "regionedb20d96",
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                Target = "targetaefbae42",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                PortRange = "port_ranged4420f7d",
                AllowGlobalAccess = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                NetworkTier = ForwardingRule.Types.NetworkTier.Standard,
                IPAddress = "i_p_addresse3ccbaf7",
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
                ForwardingRule = "forwarding_rule51d5478e",
                Project = "projectaa6ff846",
            };
            ForwardingRule expectedResponse = new ForwardingRule
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                IpVersion = ForwardingRule.Types.IpVersion.UndefinedIpVersion,
                CreationTimestamp = "creation_timestamp235e59a1",
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                IPProtocol = ForwardingRule.Types.IPProtocol.Ah,
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = ForwardingRule.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                Ports = { "ports9860f047", },
                IsMirroringCollector = false,
                Region = "regionedb20d96",
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                Target = "targetaefbae42",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                PortRange = "port_ranged4420f7d",
                AllowGlobalAccess = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                NetworkTier = ForwardingRule.Types.NetworkTier.Standard,
                IPAddress = "i_p_addresse3ccbaf7",
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
                ForwardingRule = "forwarding_rule51d5478e",
                Project = "projectaa6ff846",
            };
            ForwardingRule expectedResponse = new ForwardingRule
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                IpVersion = ForwardingRule.Types.IpVersion.UndefinedIpVersion,
                CreationTimestamp = "creation_timestamp235e59a1",
                BackendService = "backend_serviceed490d45",
                Subnetwork = "subnetworkf55bf572",
                IPProtocol = ForwardingRule.Types.IPProtocol.Ah,
                ServiceName = "service_named5df05d5",
                LoadBalancingScheme = ForwardingRule.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                Ports = { "ports9860f047", },
                IsMirroringCollector = false,
                Region = "regionedb20d96",
                ServiceLabel = "service_label5f95d0c0",
                Description = "description2cf9da67",
                AllPorts = false,
                SelfLink = "self_link7e87f12d",
                Target = "targetaefbae42",
                MetadataFilters =
                {
                    new MetadataFilter(),
                },
                PortRange = "port_ranged4420f7d",
                AllowGlobalAccess = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                NetworkTier = ForwardingRule.Types.NetworkTier.Standard,
                IPAddress = "i_p_addresse3ccbaf7",
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
                ForwardingRuleResource = new ForwardingRule(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRuleResource = new ForwardingRule(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRuleResource = new ForwardingRule(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRuleResource = new ForwardingRule(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
        public void ListRequestObject()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            ListGlobalForwardingRulesRequest request = new ListGlobalForwardingRulesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Filter = "filtere47ac9b2",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                ReturnPartialSuccess = false,
            };
            ForwardingRuleList expectedResponse = new ForwardingRuleList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ForwardingRule(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            ForwardingRuleList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            ListGlobalForwardingRulesRequest request = new ListGlobalForwardingRulesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Filter = "filtere47ac9b2",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                ReturnPartialSuccess = false,
            };
            ForwardingRuleList expectedResponse = new ForwardingRuleList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ForwardingRule(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ForwardingRuleList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            ForwardingRuleList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ForwardingRuleList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            ListGlobalForwardingRulesRequest request = new ListGlobalForwardingRulesRequest
            {
                Project = "projectaa6ff846",
            };
            ForwardingRuleList expectedResponse = new ForwardingRuleList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ForwardingRule(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            ForwardingRuleList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            ListGlobalForwardingRulesRequest request = new ListGlobalForwardingRulesRequest
            {
                Project = "projectaa6ff846",
            };
            ForwardingRuleList expectedResponse = new ForwardingRuleList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ForwardingRule(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ForwardingRuleList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalForwardingRulesClient client = new GlobalForwardingRulesClientImpl(mockGrpcClient.Object, null);
            ForwardingRuleList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ForwardingRuleList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            PatchGlobalForwardingRuleRequest request = new PatchGlobalForwardingRuleRequest
            {
                ForwardingRule = "forwarding_rule51d5478e",
                ForwardingRuleResource = new ForwardingRule(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRule = "forwarding_rule51d5478e",
                ForwardingRuleResource = new ForwardingRule(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRule = "forwarding_rule51d5478e",
                ForwardingRuleResource = new ForwardingRule(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRule = "forwarding_rule51d5478e",
                ForwardingRuleResource = new ForwardingRule(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
        public void SetTargetRequestObject()
        {
            moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient> mockGrpcClient = new moq::Mock<GlobalForwardingRules.GlobalForwardingRulesClient>(moq::MockBehavior.Strict);
            SetTargetGlobalForwardingRuleRequest request = new SetTargetGlobalForwardingRuleRequest
            {
                ForwardingRule = "forwarding_rule51d5478e",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetReferenceResource = new TargetReference(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRule = "forwarding_rule51d5478e",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetReferenceResource = new TargetReference(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRule = "forwarding_rule51d5478e",
                Project = "projectaa6ff846",
                TargetReferenceResource = new TargetReference(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
                ForwardingRule = "forwarding_rule51d5478e",
                Project = "projectaa6ff846",
                TargetReferenceResource = new TargetReference(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                HttpErrorStatusCode = 1766362655,
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                SelfLink = "self_link7e87f12d",
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                Warnings = { new Warnings(), },
                TargetId = "target_id16dfe255",
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
