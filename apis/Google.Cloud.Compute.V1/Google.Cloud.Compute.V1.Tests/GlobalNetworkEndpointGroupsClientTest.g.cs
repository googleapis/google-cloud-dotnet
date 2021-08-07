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
    public sealed class GeneratedGlobalNetworkEndpointGroupsClientTest
    {
        [xunit::FactAttribute]
        public void AttachNetworkEndpointsRequestObject()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsAttachEndpointsRequestResource = new GlobalNetworkEndpointGroupsAttachEndpointsRequest(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            mockGrpcClient.Setup(x => x.AttachNetworkEndpoints(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AttachNetworkEndpoints(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AttachNetworkEndpointsRequestObjectAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsAttachEndpointsRequestResource = new GlobalNetworkEndpointGroupsAttachEndpointsRequest(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            mockGrpcClient.Setup(x => x.AttachNetworkEndpointsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AttachNetworkEndpointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AttachNetworkEndpointsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AttachNetworkEndpoints()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsAttachEndpointsRequestResource = new GlobalNetworkEndpointGroupsAttachEndpointsRequest(),
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            mockGrpcClient.Setup(x => x.AttachNetworkEndpoints(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AttachNetworkEndpoints(request.Project, request.NetworkEndpointGroup, request.GlobalNetworkEndpointGroupsAttachEndpointsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AttachNetworkEndpointsAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsAttachEndpointsRequestResource = new GlobalNetworkEndpointGroupsAttachEndpointsRequest(),
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            mockGrpcClient.Setup(x => x.AttachNetworkEndpointsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AttachNetworkEndpointsAsync(request.Project, request.NetworkEndpointGroup, request.GlobalNetworkEndpointGroupsAttachEndpointsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AttachNetworkEndpointsAsync(request.Project, request.NetworkEndpointGroup, request.GlobalNetworkEndpointGroupsAttachEndpointsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteGlobalNetworkEndpointGroupRequest request = new DeleteGlobalNetworkEndpointGroupRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteGlobalNetworkEndpointGroupRequest request = new DeleteGlobalNetworkEndpointGroupRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteGlobalNetworkEndpointGroupRequest request = new DeleteGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.NetworkEndpointGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteGlobalNetworkEndpointGroupRequest request = new DeleteGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.NetworkEndpointGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.NetworkEndpointGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetachNetworkEndpointsRequestObject()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsDetachEndpointsRequestResource = new GlobalNetworkEndpointGroupsDetachEndpointsRequest(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            mockGrpcClient.Setup(x => x.DetachNetworkEndpoints(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DetachNetworkEndpoints(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetachNetworkEndpointsRequestObjectAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsDetachEndpointsRequestResource = new GlobalNetworkEndpointGroupsDetachEndpointsRequest(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            mockGrpcClient.Setup(x => x.DetachNetworkEndpointsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DetachNetworkEndpointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DetachNetworkEndpointsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetachNetworkEndpoints()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsDetachEndpointsRequestResource = new GlobalNetworkEndpointGroupsDetachEndpointsRequest(),
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            mockGrpcClient.Setup(x => x.DetachNetworkEndpoints(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DetachNetworkEndpoints(request.Project, request.NetworkEndpointGroup, request.GlobalNetworkEndpointGroupsDetachEndpointsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetachNetworkEndpointsAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsDetachEndpointsRequestResource = new GlobalNetworkEndpointGroupsDetachEndpointsRequest(),
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            mockGrpcClient.Setup(x => x.DetachNetworkEndpointsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DetachNetworkEndpointsAsync(request.Project, request.NetworkEndpointGroup, request.GlobalNetworkEndpointGroupsDetachEndpointsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DetachNetworkEndpointsAsync(request.Project, request.NetworkEndpointGroup, request.GlobalNetworkEndpointGroupsDetachEndpointsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetGlobalNetworkEndpointGroupRequest request = new GetGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                CloudRun = new NetworkEndpointGroupCloudRun(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkEndpointType = NetworkEndpointGroup.Types.NetworkEndpointType.InternetFqdnPort,
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Subnetwork = "subnetworkf55bf572",
                AppEngine = new NetworkEndpointGroupAppEngine(),
                Description = "description2cf9da67",
                DefaultPort = 4850952,
                SelfLink = "self_link7e87f12d",
                CloudFunction = new NetworkEndpointGroupCloudFunction(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetGlobalNetworkEndpointGroupRequest request = new GetGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                CloudRun = new NetworkEndpointGroupCloudRun(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkEndpointType = NetworkEndpointGroup.Types.NetworkEndpointType.InternetFqdnPort,
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Subnetwork = "subnetworkf55bf572",
                AppEngine = new NetworkEndpointGroupAppEngine(),
                Description = "description2cf9da67",
                DefaultPort = 4850952,
                SelfLink = "self_link7e87f12d",
                CloudFunction = new NetworkEndpointGroupCloudFunction(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkEndpointGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroup responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetGlobalNetworkEndpointGroupRequest request = new GetGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                CloudRun = new NetworkEndpointGroupCloudRun(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkEndpointType = NetworkEndpointGroup.Types.NetworkEndpointType.InternetFqdnPort,
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Subnetwork = "subnetworkf55bf572",
                AppEngine = new NetworkEndpointGroupAppEngine(),
                Description = "description2cf9da67",
                DefaultPort = 4850952,
                SelfLink = "self_link7e87f12d",
                CloudFunction = new NetworkEndpointGroupCloudFunction(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup response = client.Get(request.Project, request.NetworkEndpointGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetGlobalNetworkEndpointGroupRequest request = new GetGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                CloudRun = new NetworkEndpointGroupCloudRun(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NetworkEndpointType = NetworkEndpointGroup.Types.NetworkEndpointType.InternetFqdnPort,
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Subnetwork = "subnetworkf55bf572",
                AppEngine = new NetworkEndpointGroupAppEngine(),
                Description = "description2cf9da67",
                DefaultPort = 4850952,
                SelfLink = "self_link7e87f12d",
                CloudFunction = new NetworkEndpointGroupCloudFunction(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkEndpointGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup responseCallSettings = await client.GetAsync(request.Project, request.NetworkEndpointGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroup responseCancellationToken = await client.GetAsync(request.Project, request.NetworkEndpointGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertGlobalNetworkEndpointGroupRequest request = new InsertGlobalNetworkEndpointGroupRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
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
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertGlobalNetworkEndpointGroupRequest request = new InsertGlobalNetworkEndpointGroupRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
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
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertGlobalNetworkEndpointGroupRequest request = new InsertGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
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
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.NetworkEndpointGroupResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<GlobalNetworkEndpointGroups.GlobalNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertGlobalNetworkEndpointGroupRequest request = new InsertGlobalNetworkEndpointGroupRequest
            {
                Project = "projectaa6ff846",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
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
            GlobalNetworkEndpointGroupsClient client = new GlobalNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.NetworkEndpointGroupResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.NetworkEndpointGroupResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
