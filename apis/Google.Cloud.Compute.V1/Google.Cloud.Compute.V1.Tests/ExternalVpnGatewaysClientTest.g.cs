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
    public sealed class GeneratedExternalVpnGatewaysClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteExternalVpnGatewayRequest request = new DeleteExternalVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                ExternalVpnGateway = "external_vpn_gatewaycc117eb0",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteExternalVpnGatewayRequest request = new DeleteExternalVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                ExternalVpnGateway = "external_vpn_gatewaycc117eb0",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteExternalVpnGatewayRequest request = new DeleteExternalVpnGatewayRequest
            {
                ExternalVpnGateway = "external_vpn_gatewaycc117eb0",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.ExternalVpnGateway);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteExternalVpnGatewayRequest request = new DeleteExternalVpnGatewayRequest
            {
                ExternalVpnGateway = "external_vpn_gatewaycc117eb0",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.ExternalVpnGateway, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.ExternalVpnGateway, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            GetExternalVpnGatewayRequest request = new GetExternalVpnGatewayRequest
            {
                ExternalVpnGateway = "external_vpn_gatewaycc117eb0",
                Project = "projectaa6ff846",
            };
            ExternalVpnGateway expectedResponse = new ExternalVpnGateway
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Interfaces =
                {
                    new ExternalVpnGatewayInterface(),
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                RedundancyType = ExternalVpnGateway.Types.RedundancyType.UndefinedRedundancyType,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            ExternalVpnGateway response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            GetExternalVpnGatewayRequest request = new GetExternalVpnGatewayRequest
            {
                ExternalVpnGateway = "external_vpn_gatewaycc117eb0",
                Project = "projectaa6ff846",
            };
            ExternalVpnGateway expectedResponse = new ExternalVpnGateway
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Interfaces =
                {
                    new ExternalVpnGatewayInterface(),
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                RedundancyType = ExternalVpnGateway.Types.RedundancyType.UndefinedRedundancyType,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExternalVpnGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            ExternalVpnGateway responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExternalVpnGateway responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            GetExternalVpnGatewayRequest request = new GetExternalVpnGatewayRequest
            {
                ExternalVpnGateway = "external_vpn_gatewaycc117eb0",
                Project = "projectaa6ff846",
            };
            ExternalVpnGateway expectedResponse = new ExternalVpnGateway
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Interfaces =
                {
                    new ExternalVpnGatewayInterface(),
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                RedundancyType = ExternalVpnGateway.Types.RedundancyType.UndefinedRedundancyType,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            ExternalVpnGateway response = client.Get(request.Project, request.ExternalVpnGateway);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            GetExternalVpnGatewayRequest request = new GetExternalVpnGatewayRequest
            {
                ExternalVpnGateway = "external_vpn_gatewaycc117eb0",
                Project = "projectaa6ff846",
            };
            ExternalVpnGateway expectedResponse = new ExternalVpnGateway
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Interfaces =
                {
                    new ExternalVpnGatewayInterface(),
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                LabelFingerprint = "label_fingerprint06ccff3a",
                RedundancyType = ExternalVpnGateway.Types.RedundancyType.UndefinedRedundancyType,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExternalVpnGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            ExternalVpnGateway responseCallSettings = await client.GetAsync(request.Project, request.ExternalVpnGateway, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExternalVpnGateway responseCancellationToken = await client.GetAsync(request.Project, request.ExternalVpnGateway, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertExternalVpnGatewayRequest request = new InsertExternalVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ExternalVpnGatewayResource = new ExternalVpnGateway(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertExternalVpnGatewayRequest request = new InsertExternalVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ExternalVpnGatewayResource = new ExternalVpnGateway(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertExternalVpnGatewayRequest request = new InsertExternalVpnGatewayRequest
            {
                Project = "projectaa6ff846",
                ExternalVpnGatewayResource = new ExternalVpnGateway(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.ExternalVpnGatewayResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertExternalVpnGatewayRequest request = new InsertExternalVpnGatewayRequest
            {
                Project = "projectaa6ff846",
                ExternalVpnGatewayResource = new ExternalVpnGateway(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.ExternalVpnGatewayResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.ExternalVpnGatewayResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            ListExternalVpnGatewaysRequest request = new ListExternalVpnGatewaysRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            ExternalVpnGatewayList expectedResponse = new ExternalVpnGatewayList
            {
                Id = "id74b70bb8",
                Etag = "etage8ad7218",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ExternalVpnGateway(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            ExternalVpnGatewayList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            ListExternalVpnGatewaysRequest request = new ListExternalVpnGatewaysRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            ExternalVpnGatewayList expectedResponse = new ExternalVpnGatewayList
            {
                Id = "id74b70bb8",
                Etag = "etage8ad7218",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ExternalVpnGateway(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExternalVpnGatewayList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            ExternalVpnGatewayList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExternalVpnGatewayList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            ListExternalVpnGatewaysRequest request = new ListExternalVpnGatewaysRequest
            {
                Project = "projectaa6ff846",
            };
            ExternalVpnGatewayList expectedResponse = new ExternalVpnGatewayList
            {
                Id = "id74b70bb8",
                Etag = "etage8ad7218",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ExternalVpnGateway(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            ExternalVpnGatewayList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            ListExternalVpnGatewaysRequest request = new ListExternalVpnGatewaysRequest
            {
                Project = "projectaa6ff846",
            };
            ExternalVpnGatewayList expectedResponse = new ExternalVpnGatewayList
            {
                Id = "id74b70bb8",
                Etag = "etage8ad7218",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ExternalVpnGateway(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExternalVpnGatewayList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            ExternalVpnGatewayList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExternalVpnGatewayList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLabelsRequestObject()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            SetLabelsExternalVpnGatewayRequest request = new SetLabelsExternalVpnGatewayRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLabels(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLabelsRequestObjectAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            SetLabelsExternalVpnGatewayRequest request = new SetLabelsExternalVpnGatewayRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLabelsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLabels()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            SetLabelsExternalVpnGatewayRequest request = new SetLabelsExternalVpnGatewayRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLabels(request.Project, request.Resource, request.GlobalSetLabelsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLabelsAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            SetLabelsExternalVpnGatewayRequest request = new SetLabelsExternalVpnGatewayRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLabelsAsync(request.Project, request.Resource, request.GlobalSetLabelsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLabelsAsync(request.Project, request.Resource, request.GlobalSetLabelsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            TestIamPermissionsExternalVpnGatewayRequest request = new TestIamPermissionsExternalVpnGatewayRequest
            {
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
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            TestIamPermissionsExternalVpnGatewayRequest request = new TestIamPermissionsExternalVpnGatewayRequest
            {
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
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            TestIamPermissionsExternalVpnGatewayRequest request = new TestIamPermissionsExternalVpnGatewayRequest
            {
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
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient> mockGrpcClient = new moq::Mock<ExternalVpnGateways.ExternalVpnGatewaysClient>(moq::MockBehavior.Strict);
            TestIamPermissionsExternalVpnGatewayRequest request = new TestIamPermissionsExternalVpnGatewayRequest
            {
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
            ExternalVpnGatewaysClient client = new ExternalVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
