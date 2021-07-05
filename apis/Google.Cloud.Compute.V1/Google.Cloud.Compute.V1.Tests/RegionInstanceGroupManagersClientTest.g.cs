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
    public sealed class GeneratedRegionInstanceGroupManagersClientTest
    {
        [xunit::FactAttribute]
        public void AbandonInstancesRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AbandonInstancesRegionInstanceGroupManagerRequest request = new AbandonInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AbandonInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AbandonInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AbandonInstancesRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AbandonInstancesRegionInstanceGroupManagerRequest request = new AbandonInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AbandonInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AbandonInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AbandonInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AbandonInstances()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AbandonInstancesRegionInstanceGroupManagerRequest request = new AbandonInstancesRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AbandonInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AbandonInstances(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersAbandonInstancesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AbandonInstancesAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AbandonInstancesRegionInstanceGroupManagerRequest request = new AbandonInstancesRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AbandonInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AbandonInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersAbandonInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AbandonInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersAbandonInstancesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ApplyUpdatesToInstancesRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.ApplyUpdatesToInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.ApplyUpdatesToInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ApplyUpdatesToInstancesRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.ApplyUpdatesToInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ApplyUpdatesToInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ApplyUpdatesToInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ApplyUpdatesToInstances()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.ApplyUpdatesToInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.ApplyUpdatesToInstances(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersApplyUpdatesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ApplyUpdatesToInstancesAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.ApplyUpdatesToInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ApplyUpdatesToInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersApplyUpdatesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ApplyUpdatesToInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersApplyUpdatesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateInstancesRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            CreateInstancesRegionInstanceGroupManagerRequest request = new CreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.CreateInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CreateInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateInstancesRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            CreateInstancesRegionInstanceGroupManagerRequest request = new CreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.CreateInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CreateInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CreateInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateInstances()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            CreateInstancesRegionInstanceGroupManagerRequest request = new CreateInstancesRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.CreateInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CreateInstances(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersCreateInstancesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateInstancesAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            CreateInstancesRegionInstanceGroupManagerRequest request = new CreateInstancesRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.CreateInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CreateInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersCreateInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CreateInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersCreateInstancesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteRegionInstanceGroupManagerRequest request = new DeleteRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteRegionInstanceGroupManagerRequest request = new DeleteRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteRegionInstanceGroupManagerRequest request = new DeleteRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.InstanceGroupManager);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteRegionInstanceGroupManagerRequest request = new DeleteRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.InstanceGroupManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.InstanceGroupManager, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstancesRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstancesRegionInstanceGroupManagerRequest request = new DeleteInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.DeleteInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstancesRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstancesRegionInstanceGroupManagerRequest request = new DeleteInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.DeleteInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstances()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstancesRegionInstanceGroupManagerRequest request = new DeleteInstancesRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.DeleteInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteInstances(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersDeleteInstancesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstancesAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstancesRegionInstanceGroupManagerRequest request = new DeleteInstancesRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                RegionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.DeleteInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersDeleteInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersDeleteInstancesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePerInstanceConfigsRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeletePerInstanceConfigsRegionInstanceGroupManagerRequest request = new DeletePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.DeletePerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeletePerInstanceConfigs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePerInstanceConfigsRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeletePerInstanceConfigsRegionInstanceGroupManagerRequest request = new DeletePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.DeletePerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeletePerInstanceConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeletePerInstanceConfigsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePerInstanceConfigs()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeletePerInstanceConfigsRegionInstanceGroupManagerRequest request = new DeletePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.DeletePerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeletePerInstanceConfigs(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagerDeleteInstanceConfigReqResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePerInstanceConfigsAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeletePerInstanceConfigsRegionInstanceGroupManagerRequest request = new DeletePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.DeletePerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeletePerInstanceConfigsAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagerDeleteInstanceConfigReqResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeletePerInstanceConfigsAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagerDeleteInstanceConfigReqResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StatefulPolicy = new StatefulPolicy(),
                TargetSize = -93132225,
                InstanceGroup = "instance_group6bf5a5ef",
                Region = "regionedb20d96",
                Versions =
                {
                    new InstanceGroupManagerVersion(),
                },
                CurrentActions = new InstanceGroupManagerActionsSummary(),
                UpdatePolicy = new InstanceGroupManagerUpdatePolicy(),
                Status = new InstanceGroupManagerStatus(),
                Fingerprint = "fingerprint009e6052",
                InstanceTemplate = "instance_template6cae3083",
                TargetPools =
                {
                    "target_pools6fc69e1f",
                },
                BaseInstanceName = "base_instance_name7c1f304c",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
                AutoHealingPolicies =
                {
                    new InstanceGroupManagerAutoHealingPolicy(),
                },
                DistributionPolicy = new DistributionPolicy(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StatefulPolicy = new StatefulPolicy(),
                TargetSize = -93132225,
                InstanceGroup = "instance_group6bf5a5ef",
                Region = "regionedb20d96",
                Versions =
                {
                    new InstanceGroupManagerVersion(),
                },
                CurrentActions = new InstanceGroupManagerActionsSummary(),
                UpdatePolicy = new InstanceGroupManagerUpdatePolicy(),
                Status = new InstanceGroupManagerStatus(),
                Fingerprint = "fingerprint009e6052",
                InstanceTemplate = "instance_template6cae3083",
                TargetPools =
                {
                    "target_pools6fc69e1f",
                },
                BaseInstanceName = "base_instance_name7c1f304c",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
                AutoHealingPolicies =
                {
                    new InstanceGroupManagerAutoHealingPolicy(),
                },
                DistributionPolicy = new DistributionPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManager>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManager responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StatefulPolicy = new StatefulPolicy(),
                TargetSize = -93132225,
                InstanceGroup = "instance_group6bf5a5ef",
                Region = "regionedb20d96",
                Versions =
                {
                    new InstanceGroupManagerVersion(),
                },
                CurrentActions = new InstanceGroupManagerActionsSummary(),
                UpdatePolicy = new InstanceGroupManagerUpdatePolicy(),
                Status = new InstanceGroupManagerStatus(),
                Fingerprint = "fingerprint009e6052",
                InstanceTemplate = "instance_template6cae3083",
                TargetPools =
                {
                    "target_pools6fc69e1f",
                },
                BaseInstanceName = "base_instance_name7c1f304c",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
                AutoHealingPolicies =
                {
                    new InstanceGroupManagerAutoHealingPolicy(),
                },
                DistributionPolicy = new DistributionPolicy(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager response = client.Get(request.Project, request.Region, request.InstanceGroupManager);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StatefulPolicy = new StatefulPolicy(),
                TargetSize = -93132225,
                InstanceGroup = "instance_group6bf5a5ef",
                Region = "regionedb20d96",
                Versions =
                {
                    new InstanceGroupManagerVersion(),
                },
                CurrentActions = new InstanceGroupManagerActionsSummary(),
                UpdatePolicy = new InstanceGroupManagerUpdatePolicy(),
                Status = new InstanceGroupManagerStatus(),
                Fingerprint = "fingerprint009e6052",
                InstanceTemplate = "instance_template6cae3083",
                TargetPools =
                {
                    "target_pools6fc69e1f",
                },
                BaseInstanceName = "base_instance_name7c1f304c",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
                AutoHealingPolicies =
                {
                    new InstanceGroupManagerAutoHealingPolicy(),
                },
                DistributionPolicy = new DistributionPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManager>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager responseCallSettings = await client.GetAsync(request.Project, request.Region, request.InstanceGroupManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManager responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.InstanceGroupManager, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            InsertRegionInstanceGroupManagerRequest request = new InsertRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            InsertRegionInstanceGroupManagerRequest request = new InsertRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            InsertRegionInstanceGroupManagerRequest request = new InsertRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.InstanceGroupManagerResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            InsertRegionInstanceGroupManagerRequest request = new InsertRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.InstanceGroupManagerResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.InstanceGroupManagerResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListRegionInstanceGroupManagersRequest request = new ListRegionInstanceGroupManagersRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            RegionInstanceGroupManagerList expectedResponse = new RegionInstanceGroupManagerList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceGroupManager(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagerList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListRegionInstanceGroupManagersRequest request = new ListRegionInstanceGroupManagersRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            RegionInstanceGroupManagerList expectedResponse = new RegionInstanceGroupManagerList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceGroupManager(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionInstanceGroupManagerList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagerList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionInstanceGroupManagerList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListRegionInstanceGroupManagersRequest request = new ListRegionInstanceGroupManagersRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            RegionInstanceGroupManagerList expectedResponse = new RegionInstanceGroupManagerList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceGroupManager(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagerList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListRegionInstanceGroupManagersRequest request = new ListRegionInstanceGroupManagersRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            RegionInstanceGroupManagerList expectedResponse = new RegionInstanceGroupManagerList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceGroupManager(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionInstanceGroupManagerList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagerList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionInstanceGroupManagerList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListErrorsRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListErrorsRegionInstanceGroupManagersRequest request = new ListErrorsRegionInstanceGroupManagersRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            RegionInstanceGroupManagersListErrorsResponse expectedResponse = new RegionInstanceGroupManagersListErrorsResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceManagedByIgmError(),
                },
            };
            mockGrpcClient.Setup(x => x.ListErrors(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListErrorsResponse response = client.ListErrors(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListErrorsRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListErrorsRegionInstanceGroupManagersRequest request = new ListErrorsRegionInstanceGroupManagersRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            RegionInstanceGroupManagersListErrorsResponse expectedResponse = new RegionInstanceGroupManagersListErrorsResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceManagedByIgmError(),
                },
            };
            mockGrpcClient.Setup(x => x.ListErrorsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionInstanceGroupManagersListErrorsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListErrorsResponse responseCallSettings = await client.ListErrorsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionInstanceGroupManagersListErrorsResponse responseCancellationToken = await client.ListErrorsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListErrors()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListErrorsRegionInstanceGroupManagersRequest request = new ListErrorsRegionInstanceGroupManagersRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            RegionInstanceGroupManagersListErrorsResponse expectedResponse = new RegionInstanceGroupManagersListErrorsResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceManagedByIgmError(),
                },
            };
            mockGrpcClient.Setup(x => x.ListErrors(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListErrorsResponse response = client.ListErrors(request.Project, request.Region, request.InstanceGroupManager);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListErrorsAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListErrorsRegionInstanceGroupManagersRequest request = new ListErrorsRegionInstanceGroupManagersRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            RegionInstanceGroupManagersListErrorsResponse expectedResponse = new RegionInstanceGroupManagersListErrorsResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceManagedByIgmError(),
                },
            };
            mockGrpcClient.Setup(x => x.ListErrorsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionInstanceGroupManagersListErrorsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListErrorsResponse responseCallSettings = await client.ListErrorsAsync(request.Project, request.Region, request.InstanceGroupManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionInstanceGroupManagersListErrorsResponse responseCancellationToken = await client.ListErrorsAsync(request.Project, request.Region, request.InstanceGroupManager, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListManagedInstancesRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListManagedInstancesRegionInstanceGroupManagersRequest request = new ListManagedInstancesRegionInstanceGroupManagersRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            RegionInstanceGroupManagersListInstancesResponse expectedResponse = new RegionInstanceGroupManagersListInstancesResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                ManagedInstances =
                {
                    new ManagedInstance(),
                },
            };
            mockGrpcClient.Setup(x => x.ListManagedInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListInstancesResponse response = client.ListManagedInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListManagedInstancesRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListManagedInstancesRegionInstanceGroupManagersRequest request = new ListManagedInstancesRegionInstanceGroupManagersRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            RegionInstanceGroupManagersListInstancesResponse expectedResponse = new RegionInstanceGroupManagersListInstancesResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                ManagedInstances =
                {
                    new ManagedInstance(),
                },
            };
            mockGrpcClient.Setup(x => x.ListManagedInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionInstanceGroupManagersListInstancesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListInstancesResponse responseCallSettings = await client.ListManagedInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionInstanceGroupManagersListInstancesResponse responseCancellationToken = await client.ListManagedInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListManagedInstances()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListManagedInstancesRegionInstanceGroupManagersRequest request = new ListManagedInstancesRegionInstanceGroupManagersRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            RegionInstanceGroupManagersListInstancesResponse expectedResponse = new RegionInstanceGroupManagersListInstancesResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                ManagedInstances =
                {
                    new ManagedInstance(),
                },
            };
            mockGrpcClient.Setup(x => x.ListManagedInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListInstancesResponse response = client.ListManagedInstances(request.Project, request.Region, request.InstanceGroupManager);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListManagedInstancesAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListManagedInstancesRegionInstanceGroupManagersRequest request = new ListManagedInstancesRegionInstanceGroupManagersRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            RegionInstanceGroupManagersListInstancesResponse expectedResponse = new RegionInstanceGroupManagersListInstancesResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                ManagedInstances =
                {
                    new ManagedInstance(),
                },
            };
            mockGrpcClient.Setup(x => x.ListManagedInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionInstanceGroupManagersListInstancesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListInstancesResponse responseCallSettings = await client.ListManagedInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionInstanceGroupManagersListInstancesResponse responseCancellationToken = await client.ListManagedInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListPerInstanceConfigsRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListPerInstanceConfigsRegionInstanceGroupManagersRequest request = new ListPerInstanceConfigsRegionInstanceGroupManagersRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            RegionInstanceGroupManagersListInstanceConfigsResp expectedResponse = new RegionInstanceGroupManagersListInstanceConfigsResp
            {
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PerInstanceConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListInstanceConfigsResp response = client.ListPerInstanceConfigs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListPerInstanceConfigsRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListPerInstanceConfigsRegionInstanceGroupManagersRequest request = new ListPerInstanceConfigsRegionInstanceGroupManagersRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            RegionInstanceGroupManagersListInstanceConfigsResp expectedResponse = new RegionInstanceGroupManagersListInstanceConfigsResp
            {
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PerInstanceConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionInstanceGroupManagersListInstanceConfigsResp>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListInstanceConfigsResp responseCallSettings = await client.ListPerInstanceConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionInstanceGroupManagersListInstanceConfigsResp responseCancellationToken = await client.ListPerInstanceConfigsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListPerInstanceConfigs()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListPerInstanceConfigsRegionInstanceGroupManagersRequest request = new ListPerInstanceConfigsRegionInstanceGroupManagersRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            RegionInstanceGroupManagersListInstanceConfigsResp expectedResponse = new RegionInstanceGroupManagersListInstanceConfigsResp
            {
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PerInstanceConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListInstanceConfigsResp response = client.ListPerInstanceConfigs(request.Project, request.Region, request.InstanceGroupManager);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListPerInstanceConfigsAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListPerInstanceConfigsRegionInstanceGroupManagersRequest request = new ListPerInstanceConfigsRegionInstanceGroupManagersRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            RegionInstanceGroupManagersListInstanceConfigsResp expectedResponse = new RegionInstanceGroupManagersListInstanceConfigsResp
            {
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PerInstanceConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionInstanceGroupManagersListInstanceConfigsResp>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            RegionInstanceGroupManagersListInstanceConfigsResp responseCallSettings = await client.ListPerInstanceConfigsAsync(request.Project, request.Region, request.InstanceGroupManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionInstanceGroupManagersListInstanceConfigsResp responseCancellationToken = await client.ListPerInstanceConfigsAsync(request.Project, request.Region, request.InstanceGroupManager, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchRegionInstanceGroupManagerRequest request = new PatchRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchRegionInstanceGroupManagerRequest request = new PatchRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchRegionInstanceGroupManagerRequest request = new PatchRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.Region, request.InstanceGroupManager, request.InstanceGroupManagerResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchRegionInstanceGroupManagerRequest request = new PatchRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.Region, request.InstanceGroupManager, request.InstanceGroupManagerResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.Region, request.InstanceGroupManager, request.InstanceGroupManagerResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchPerInstanceConfigsRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchPerInstanceConfigsRegionInstanceGroupManagerRequest request = new PatchPerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                RegionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.PatchPerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.PatchPerInstanceConfigs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchPerInstanceConfigsRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchPerInstanceConfigsRegionInstanceGroupManagerRequest request = new PatchPerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                RegionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.PatchPerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchPerInstanceConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchPerInstanceConfigsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchPerInstanceConfigs()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchPerInstanceConfigsRegionInstanceGroupManagerRequest request = new PatchPerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                RegionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.PatchPerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.PatchPerInstanceConfigs(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagerPatchInstanceConfigReqResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchPerInstanceConfigsAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchPerInstanceConfigsRegionInstanceGroupManagerRequest request = new PatchPerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                RegionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.PatchPerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchPerInstanceConfigsAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagerPatchInstanceConfigReqResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchPerInstanceConfigsAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagerPatchInstanceConfigReqResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RecreateInstancesRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            RecreateInstancesRegionInstanceGroupManagerRequest request = new RecreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                RegionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.RecreateInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RecreateInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RecreateInstancesRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            RecreateInstancesRegionInstanceGroupManagerRequest request = new RecreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                RegionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.RecreateInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RecreateInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RecreateInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RecreateInstances()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            RecreateInstancesRegionInstanceGroupManagerRequest request = new RecreateInstancesRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                RegionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.RecreateInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RecreateInstances(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersRecreateRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RecreateInstancesAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            RecreateInstancesRegionInstanceGroupManagerRequest request = new RecreateInstancesRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                RegionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.RecreateInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RecreateInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersRecreateRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RecreateInstancesAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersRecreateRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResizeRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ResizeRegionInstanceGroupManagerRequest request = new ResizeRegionInstanceGroupManagerRequest
            {
                Size = -1218396681,
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.Resize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Resize(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResizeRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ResizeRegionInstanceGroupManagerRequest request = new ResizeRegionInstanceGroupManagerRequest
            {
                Size = -1218396681,
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.ResizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ResizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ResizeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Resize()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ResizeRegionInstanceGroupManagerRequest request = new ResizeRegionInstanceGroupManagerRequest
            {
                Size = -1218396681,
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.Resize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Resize(request.Project, request.Region, request.InstanceGroupManager, request.Size);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResizeAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ResizeRegionInstanceGroupManagerRequest request = new ResizeRegionInstanceGroupManagerRequest
            {
                Size = -1218396681,
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.ResizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ResizeAsync(request.Project, request.Region, request.InstanceGroupManager, request.Size, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ResizeAsync(request.Project, request.Region, request.InstanceGroupManager, request.Size, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetInstanceTemplateRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetInstanceTemplateRegionInstanceGroupManagerRequest request = new SetInstanceTemplateRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                RegionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetInstanceTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetInstanceTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetInstanceTemplateRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetInstanceTemplateRegionInstanceGroupManagerRequest request = new SetInstanceTemplateRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                RegionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetInstanceTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetInstanceTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetInstanceTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetInstanceTemplate()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetInstanceTemplateRegionInstanceGroupManagerRequest request = new SetInstanceTemplateRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                RegionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetInstanceTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetInstanceTemplate(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersSetTemplateRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetInstanceTemplateAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetInstanceTemplateRegionInstanceGroupManagerRequest request = new SetInstanceTemplateRegionInstanceGroupManagerRequest
            {
                Region = "regionedb20d96",
                RegionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetInstanceTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetInstanceTemplateAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersSetTemplateRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetInstanceTemplateAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersSetTemplateRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetTargetPoolsRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetTargetPoolsRegionInstanceGroupManagerRequest request = new SetTargetPoolsRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                RegionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetTargetPools(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetTargetPools(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetTargetPoolsRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetTargetPoolsRegionInstanceGroupManagerRequest request = new SetTargetPoolsRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                RegionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetTargetPoolsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetTargetPoolsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetTargetPoolsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetTargetPools()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetTargetPoolsRegionInstanceGroupManagerRequest request = new SetTargetPoolsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetTargetPools(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetTargetPools(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersSetTargetPoolsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetTargetPoolsAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetTargetPoolsRegionInstanceGroupManagerRequest request = new SetTargetPoolsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetTargetPoolsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetTargetPoolsAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersSetTargetPoolsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetTargetPoolsAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagersSetTargetPoolsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePerInstanceConfigsRequestObject()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                RegionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.UpdatePerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdatePerInstanceConfigs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePerInstanceConfigsRequestObjectAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "request_id362c8df6",
                RegionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.UpdatePerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdatePerInstanceConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdatePerInstanceConfigsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePerInstanceConfigs()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.UpdatePerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdatePerInstanceConfigs(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagerUpdateInstanceConfigReqResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePerInstanceConfigsAsync()
        {
            moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient> mockGrpcClient = new moq::Mock<RegionInstanceGroupManagers.RegionInstanceGroupManagersClient>(moq::MockBehavior.Strict);
            UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.UpdatePerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionInstanceGroupManagersClient client = new RegionInstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdatePerInstanceConfigsAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagerUpdateInstanceConfigReqResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdatePerInstanceConfigsAsync(request.Project, request.Region, request.InstanceGroupManager, request.RegionInstanceGroupManagerUpdateInstanceConfigReqResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
