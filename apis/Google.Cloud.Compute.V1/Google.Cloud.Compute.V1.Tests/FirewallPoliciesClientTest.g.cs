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
    public sealed class GeneratedFirewallPoliciesClientTest
    {
        [xunit::FactAttribute]
        public void AddAssociationRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            AddAssociationFirewallPolicyRequest request = new AddAssociationFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                ReplaceExistingAssociation = true,
                FirewallPolicyAssociationResource = new FirewallPolicyAssociation(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.AddAssociation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddAssociation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddAssociationRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            AddAssociationFirewallPolicyRequest request = new AddAssociationFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                ReplaceExistingAssociation = true,
                FirewallPolicyAssociationResource = new FirewallPolicyAssociation(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.AddAssociationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddAssociationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddAssociation()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            AddAssociationFirewallPolicyRequest request = new AddAssociationFirewallPolicyRequest
            {
                FirewallPolicyAssociationResource = new FirewallPolicyAssociation(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.AddAssociation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddAssociation(request.FirewallPolicy, request.FirewallPolicyAssociationResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddAssociationAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            AddAssociationFirewallPolicyRequest request = new AddAssociationFirewallPolicyRequest
            {
                FirewallPolicyAssociationResource = new FirewallPolicyAssociation(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.AddAssociationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddAssociationAsync(request.FirewallPolicy, request.FirewallPolicyAssociationResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddAssociationAsync(request.FirewallPolicy, request.FirewallPolicyAssociationResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddRuleRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            AddRuleFirewallPolicyRequest request = new AddRuleFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.AddRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddRuleRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            AddRuleFirewallPolicyRequest request = new AddRuleFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.AddRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddRule()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            AddRuleFirewallPolicyRequest request = new AddRuleFirewallPolicyRequest
            {
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.AddRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddRule(request.FirewallPolicy, request.FirewallPolicyRuleResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddRuleAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            AddRuleFirewallPolicyRequest request = new AddRuleFirewallPolicyRequest
            {
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.AddRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddRuleAsync(request.FirewallPolicy, request.FirewallPolicyRuleResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddRuleAsync(request.FirewallPolicy, request.FirewallPolicyRuleResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CloneRulesRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            CloneRulesFirewallPolicyRequest request = new CloneRulesFirewallPolicyRequest
            {
                SourceFirewallPolicy = "source_firewall_policy9e4c1490",
                RequestId = "request_id362c8df6",
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.CloneRules(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CloneRules(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CloneRulesRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            CloneRulesFirewallPolicyRequest request = new CloneRulesFirewallPolicyRequest
            {
                SourceFirewallPolicy = "source_firewall_policy9e4c1490",
                RequestId = "request_id362c8df6",
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.CloneRulesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CloneRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CloneRulesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CloneRules()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            CloneRulesFirewallPolicyRequest request = new CloneRulesFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.CloneRules(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CloneRules(request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CloneRulesAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            CloneRulesFirewallPolicyRequest request = new CloneRulesFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.CloneRulesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CloneRulesAsync(request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CloneRulesAsync(request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            DeleteFirewallPolicyRequest request = new DeleteFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                FirewallPolicy = "firewall_policy1f9c9144",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            DeleteFirewallPolicyRequest request = new DeleteFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                FirewallPolicy = "firewall_policy1f9c9144",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            DeleteFirewallPolicyRequest request = new DeleteFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            DeleteFirewallPolicyRequest request = new DeleteFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicy response = client.Get(request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyAssociation response = client.GetAssociation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAssociationRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyAssociation response = client.GetAssociation(request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAssociationAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
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
            GetRuleFirewallPolicyRequest request = new GetRuleFirewallPolicyRequest
            {
                Priority = 1546225849,
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyRule expectedResponse = new FirewallPolicyRule
            {
                Kind = "kindf7aa39d9",
                Match = new FirewallPolicyRuleMatcher(),
                Direction = FirewallPolicyRule.Types.Direction.Ingress,
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
                TargetResources =
                {
                    "target_resources1e810c06",
                },
            };
            mockGrpcClient.Setup(x => x.GetRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyRule response = client.GetRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuleRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            GetRuleFirewallPolicyRequest request = new GetRuleFirewallPolicyRequest
            {
                Priority = 1546225849,
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyRule expectedResponse = new FirewallPolicyRule
            {
                Kind = "kindf7aa39d9",
                Match = new FirewallPolicyRuleMatcher(),
                Direction = FirewallPolicyRule.Types.Direction.Ingress,
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
                TargetResources =
                {
                    "target_resources1e810c06",
                },
            };
            mockGrpcClient.Setup(x => x.GetRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallPolicyRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
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
            GetRuleFirewallPolicyRequest request = new GetRuleFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyRule expectedResponse = new FirewallPolicyRule
            {
                Kind = "kindf7aa39d9",
                Match = new FirewallPolicyRuleMatcher(),
                Direction = FirewallPolicyRule.Types.Direction.Ingress,
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
                TargetResources =
                {
                    "target_resources1e810c06",
                },
            };
            mockGrpcClient.Setup(x => x.GetRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyRule response = client.GetRule(request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRuleAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            GetRuleFirewallPolicyRequest request = new GetRuleFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
            };
            FirewallPolicyRule expectedResponse = new FirewallPolicyRule
            {
                Kind = "kindf7aa39d9",
                Match = new FirewallPolicyRuleMatcher(),
                Direction = FirewallPolicyRule.Types.Direction.Ingress,
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
                TargetResources =
                {
                    "target_resources1e810c06",
                },
            };
            mockGrpcClient.Setup(x => x.GetRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirewallPolicyRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPolicyRule responseCallSettings = await client.GetRuleAsync(request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPolicyRule responseCancellationToken = await client.GetRuleAsync(request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            InsertFirewallPolicyRequest request = new InsertFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                ParentId = "parent_id8279e36b",
                FirewallPolicyResource = new FirewallPolicy(),
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            InsertFirewallPolicyRequest request = new InsertFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                ParentId = "parent_id8279e36b",
                FirewallPolicyResource = new FirewallPolicy(),
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            InsertFirewallPolicyRequest request = new InsertFirewallPolicyRequest
            {
                FirewallPolicyResource = new FirewallPolicy(),
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.FirewallPolicyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            InsertFirewallPolicyRequest request = new InsertFirewallPolicyRequest
            {
                FirewallPolicyResource = new FirewallPolicy(),
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.FirewallPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.FirewallPolicyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListAssociationsRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPoliciesListAssociationsResponse response = client.ListAssociations(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAssociationsRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPoliciesListAssociationsResponse response = client.ListAssociations();
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAssociationsAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            FirewallPoliciesListAssociationsResponse responseCallSettings = await client.ListAssociationsAsync(gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirewallPoliciesListAssociationsResponse responseCancellationToken = await client.ListAssociationsAsync(st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MoveRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            MoveFirewallPolicyRequest request = new MoveFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                ParentId = "parent_id8279e36b",
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.Move(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Move(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MoveRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            MoveFirewallPolicyRequest request = new MoveFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                ParentId = "parent_id8279e36b",
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.MoveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.MoveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.MoveAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Move()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            MoveFirewallPolicyRequest request = new MoveFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.Move(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Move(request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MoveAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            MoveFirewallPolicyRequest request = new MoveFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.MoveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.MoveAsync(request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.MoveAsync(request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            PatchFirewallPolicyRequest request = new PatchFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                FirewallPolicyResource = new FirewallPolicy(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            PatchFirewallPolicyRequest request = new PatchFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                FirewallPolicyResource = new FirewallPolicy(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            PatchFirewallPolicyRequest request = new PatchFirewallPolicyRequest
            {
                FirewallPolicyResource = new FirewallPolicy(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.FirewallPolicy, request.FirewallPolicyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            PatchFirewallPolicyRequest request = new PatchFirewallPolicyRequest
            {
                FirewallPolicyResource = new FirewallPolicy(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.FirewallPolicy, request.FirewallPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.FirewallPolicy, request.FirewallPolicyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRuleRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            PatchRuleFirewallPolicyRequest request = new PatchRuleFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                Priority = 1546225849,
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.PatchRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.PatchRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRuleRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            PatchRuleFirewallPolicyRequest request = new PatchRuleFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                Priority = 1546225849,
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.PatchRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRule()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            PatchRuleFirewallPolicyRequest request = new PatchRuleFirewallPolicyRequest
            {
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.PatchRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.PatchRule(request.FirewallPolicy, request.FirewallPolicyRuleResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRuleAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            PatchRuleFirewallPolicyRequest request = new PatchRuleFirewallPolicyRequest
            {
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.PatchRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchRuleAsync(request.FirewallPolicy, request.FirewallPolicyRuleResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchRuleAsync(request.FirewallPolicy, request.FirewallPolicyRuleResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveAssociationRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            RemoveAssociationFirewallPolicyRequest request = new RemoveAssociationFirewallPolicyRequest
            {
                Name = "name1c9368b0",
                RequestId = "request_id362c8df6",
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.RemoveAssociation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveAssociation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveAssociationRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            RemoveAssociationFirewallPolicyRequest request = new RemoveAssociationFirewallPolicyRequest
            {
                Name = "name1c9368b0",
                RequestId = "request_id362c8df6",
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.RemoveAssociationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveAssociationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveAssociation()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            RemoveAssociationFirewallPolicyRequest request = new RemoveAssociationFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.RemoveAssociation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveAssociation(request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveAssociationAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            RemoveAssociationFirewallPolicyRequest request = new RemoveAssociationFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.RemoveAssociationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveAssociationAsync(request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveAssociationAsync(request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveRuleRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            RemoveRuleFirewallPolicyRequest request = new RemoveRuleFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                Priority = 1546225849,
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.RemoveRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveRuleRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            RemoveRuleFirewallPolicyRequest request = new RemoveRuleFirewallPolicyRequest
            {
                RequestId = "request_id362c8df6",
                Priority = 1546225849,
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.RemoveRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveRule()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            RemoveRuleFirewallPolicyRequest request = new RemoveRuleFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.RemoveRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveRule(request.FirewallPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveRuleAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
            RemoveRuleFirewallPolicyRequest request = new RemoveRuleFirewallPolicyRequest
            {
                FirewallPolicy = "firewall_policy1f9c9144",
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
            mockGrpcClient.Setup(x => x.RemoveRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveRuleAsync(request.FirewallPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveRuleAsync(request.FirewallPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request.Resource, request.GlobalOrganizationSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<FirewallPolicies.FirewallPoliciesClient> mockGrpcClient = new moq::Mock<FirewallPolicies.FirewallPoliciesClient>(moq::MockBehavior.Strict);
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
            FirewallPoliciesClient client = new FirewallPoliciesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
