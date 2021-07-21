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
    public sealed class GeneratedSecurityPoliciesClientTest
    {
        [xunit::FactAttribute]
        public void AddRuleRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            AddRuleSecurityPolicyRequest request = new AddRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddRuleRequestObjectAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            AddRuleSecurityPolicyRequest request = new AddRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddRule()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            AddRuleSecurityPolicyRequest request = new AddRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddRule(request.Project, request.SecurityPolicy, request.SecurityPolicyRuleResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddRuleAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            AddRuleSecurityPolicyRequest request = new AddRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddRuleAsync(request.Project, request.SecurityPolicy, request.SecurityPolicyRuleResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddRuleAsync(request.Project, request.SecurityPolicy, request.SecurityPolicyRuleResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            DeleteSecurityPolicyRequest request = new DeleteSecurityPolicyRequest
            {
                RequestId = "request_id362c8df6",
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            DeleteSecurityPolicyRequest request = new DeleteSecurityPolicyRequest
            {
                RequestId = "request_id362c8df6",
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            DeleteSecurityPolicyRequest request = new DeleteSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.SecurityPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            DeleteSecurityPolicyRequest request = new DeleteSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.SecurityPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.SecurityPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
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
                CreationTimestamp = "creation_timestamp235e59a1",
                Rules =
                {
                    new SecurityPolicyRule(),
                },
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
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
                CreationTimestamp = "creation_timestamp235e59a1",
                Rules =
                {
                    new SecurityPolicyRule(),
                },
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
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
                CreationTimestamp = "creation_timestamp235e59a1",
                Rules =
                {
                    new SecurityPolicyRule(),
                },
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
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
                CreationTimestamp = "creation_timestamp235e59a1",
                Rules =
                {
                    new SecurityPolicyRule(),
                },
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
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
            GetRuleSecurityPolicyRequest request = new GetRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                Priority = 1546225849,
            };
            SecurityPolicyRule expectedResponse = new SecurityPolicyRule
            {
                Kind = "kindf7aa39d9",
                Match = new SecurityPolicyRuleMatcher(),
                Action = "action09558c41",
                Preview = true,
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
            GetRuleSecurityPolicyRequest request = new GetRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                Priority = 1546225849,
            };
            SecurityPolicyRule expectedResponse = new SecurityPolicyRule
            {
                Kind = "kindf7aa39d9",
                Match = new SecurityPolicyRuleMatcher(),
                Action = "action09558c41",
                Preview = true,
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
            GetRuleSecurityPolicyRequest request = new GetRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
            };
            SecurityPolicyRule expectedResponse = new SecurityPolicyRule
            {
                Kind = "kindf7aa39d9",
                Match = new SecurityPolicyRuleMatcher(),
                Action = "action09558c41",
                Preview = true,
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
            GetRuleSecurityPolicyRequest request = new GetRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
            };
            SecurityPolicyRule expectedResponse = new SecurityPolicyRule
            {
                Kind = "kindf7aa39d9",
                Match = new SecurityPolicyRuleMatcher(),
                Action = "action09558c41",
                Preview = true,
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
        public void InsertRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            InsertSecurityPolicyRequest request = new InsertSecurityPolicyRequest
            {
                RequestId = "request_id362c8df6",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            InsertSecurityPolicyRequest request = new InsertSecurityPolicyRequest
            {
                RequestId = "request_id362c8df6",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            InsertSecurityPolicyRequest request = new InsertSecurityPolicyRequest
            {
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.SecurityPolicyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            InsertSecurityPolicyRequest request = new InsertSecurityPolicyRequest
            {
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.SecurityPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.SecurityPolicyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            ListSecurityPoliciesRequest request = new ListSecurityPoliciesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            SecurityPolicyList expectedResponse = new SecurityPolicyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new SecurityPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicyList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            ListSecurityPoliciesRequest request = new ListSecurityPoliciesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            SecurityPolicyList expectedResponse = new SecurityPolicyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new SecurityPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecurityPolicyList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicyList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecurityPolicyList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            ListSecurityPoliciesRequest request = new ListSecurityPoliciesRequest
            {
                Project = "projectaa6ff846",
            };
            SecurityPolicyList expectedResponse = new SecurityPolicyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new SecurityPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicyList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            ListSecurityPoliciesRequest request = new ListSecurityPoliciesRequest
            {
                Project = "projectaa6ff846",
            };
            SecurityPolicyList expectedResponse = new SecurityPolicyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new SecurityPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SecurityPolicyList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            SecurityPolicyList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SecurityPolicyList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListPreconfiguredExpressionSetsRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
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

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            PatchSecurityPolicyRequest request = new PatchSecurityPolicyRequest
            {
                RequestId = "request_id362c8df6",
                SecurityPolicy = "security_policy76596315",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            PatchSecurityPolicyRequest request = new PatchSecurityPolicyRequest
            {
                RequestId = "request_id362c8df6",
                SecurityPolicy = "security_policy76596315",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            PatchSecurityPolicyRequest request = new PatchSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.SecurityPolicy, request.SecurityPolicyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            PatchSecurityPolicyRequest request = new PatchSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                SecurityPolicyResource = new SecurityPolicy(),
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.SecurityPolicy, request.SecurityPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.SecurityPolicy, request.SecurityPolicyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRuleRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            PatchRuleSecurityPolicyRequest request = new PatchRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
                Priority = 1546225849,
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.PatchRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRuleRequestObjectAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            PatchRuleSecurityPolicyRequest request = new PatchRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
                Priority = 1546225849,
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRule()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            PatchRuleSecurityPolicyRequest request = new PatchRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.PatchRule(request.Project, request.SecurityPolicy, request.SecurityPolicyRuleResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRuleAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            PatchRuleSecurityPolicyRequest request = new PatchRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchRuleAsync(request.Project, request.SecurityPolicy, request.SecurityPolicyRuleResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchRuleAsync(request.Project, request.SecurityPolicy, request.SecurityPolicyRuleResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveRuleRequestObject()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            RemoveRuleSecurityPolicyRequest request = new RemoveRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                Priority = 1546225849,
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveRule(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveRuleRequestObjectAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            RemoveRuleSecurityPolicyRequest request = new RemoveRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
                Priority = 1546225849,
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveRuleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveRule()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            RemoveRuleSecurityPolicyRequest request = new RemoveRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveRule(request.Project, request.SecurityPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveRuleAsync()
        {
            moq::Mock<SecurityPolicies.SecurityPoliciesClient> mockGrpcClient = new moq::Mock<SecurityPolicies.SecurityPoliciesClient>(moq::MockBehavior.Strict);
            RemoveRuleSecurityPolicyRequest request = new RemoveRuleSecurityPolicyRequest
            {
                SecurityPolicy = "security_policy76596315",
                Project = "projectaa6ff846",
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
            SecurityPoliciesClient client = new SecurityPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveRuleAsync(request.Project, request.SecurityPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveRuleAsync(request.Project, request.SecurityPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
