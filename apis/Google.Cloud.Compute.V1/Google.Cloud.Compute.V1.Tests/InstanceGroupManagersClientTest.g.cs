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
    public sealed class GeneratedInstanceGroupManagersClientTest
    {
        [xunit::FactAttribute]
        public void AbandonInstancesRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AbandonInstancesInstanceGroupManagerRequest request = new AbandonInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AbandonInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AbandonInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AbandonInstancesRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AbandonInstancesInstanceGroupManagerRequest request = new AbandonInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AbandonInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AbandonInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AbandonInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AbandonInstances()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AbandonInstancesInstanceGroupManagerRequest request = new AbandonInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AbandonInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AbandonInstances(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersAbandonInstancesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AbandonInstancesAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AbandonInstancesInstanceGroupManagerRequest request = new AbandonInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AbandonInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AbandonInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersAbandonInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AbandonInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersAbandonInstancesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AggregatedListInstanceGroupManagersRequest request = new AggregatedListInstanceGroupManagersRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            InstanceGroupManagerAggregatedList expectedResponse = new InstanceGroupManagerAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InstanceGroupManagersScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagerAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AggregatedListInstanceGroupManagersRequest request = new AggregatedListInstanceGroupManagersRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            InstanceGroupManagerAggregatedList expectedResponse = new InstanceGroupManagerAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InstanceGroupManagersScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManagerAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagerAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManagerAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AggregatedListInstanceGroupManagersRequest request = new AggregatedListInstanceGroupManagersRequest
            {
                Project = "projectaa6ff846",
            };
            InstanceGroupManagerAggregatedList expectedResponse = new InstanceGroupManagerAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InstanceGroupManagersScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagerAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            AggregatedListInstanceGroupManagersRequest request = new AggregatedListInstanceGroupManagersRequest
            {
                Project = "projectaa6ff846",
            };
            InstanceGroupManagerAggregatedList expectedResponse = new InstanceGroupManagerAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InstanceGroupManagersScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManagerAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagerAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManagerAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ApplyUpdatesToInstancesRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ApplyUpdatesToInstancesInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest(),
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
            mockGrpcClient.Setup(x => x.ApplyUpdatesToInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.ApplyUpdatesToInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ApplyUpdatesToInstancesRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ApplyUpdatesToInstancesInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest(),
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
            mockGrpcClient.Setup(x => x.ApplyUpdatesToInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ApplyUpdatesToInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ApplyUpdatesToInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ApplyUpdatesToInstances()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ApplyUpdatesToInstancesInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest(),
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
            mockGrpcClient.Setup(x => x.ApplyUpdatesToInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.ApplyUpdatesToInstances(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersApplyUpdatesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ApplyUpdatesToInstancesAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ApplyUpdatesToInstancesInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest(),
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
            mockGrpcClient.Setup(x => x.ApplyUpdatesToInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ApplyUpdatesToInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersApplyUpdatesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ApplyUpdatesToInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersApplyUpdatesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateInstancesRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            CreateInstancesInstanceGroupManagerRequest request = new CreateInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.CreateInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CreateInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateInstancesRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            CreateInstancesInstanceGroupManagerRequest request = new CreateInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.CreateInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CreateInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CreateInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateInstances()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            CreateInstancesInstanceGroupManagerRequest request = new CreateInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.CreateInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CreateInstances(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersCreateInstancesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateInstancesAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            CreateInstancesInstanceGroupManagerRequest request = new CreateInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.CreateInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.CreateInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersCreateInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.CreateInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersCreateInstancesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstanceGroupManagerRequest request = new DeleteInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstanceGroupManagerRequest request = new DeleteInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstanceGroupManagerRequest request = new DeleteInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Zone, request.InstanceGroupManager);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstanceGroupManagerRequest request = new DeleteInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Zone, request.InstanceGroupManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Zone, request.InstanceGroupManager, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstancesRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstancesInstanceGroupManagerRequest request = new DeleteInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.DeleteInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstancesRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstancesInstanceGroupManagerRequest request = new DeleteInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.DeleteInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstances()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstancesInstanceGroupManagerRequest request = new DeleteInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.DeleteInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteInstances(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersDeleteInstancesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstancesAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeleteInstancesInstanceGroupManagerRequest request = new DeleteInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.DeleteInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersDeleteInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersDeleteInstancesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePerInstanceConfigsRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeletePerInstanceConfigsInstanceGroupManagerRequest request = new DeletePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq(),
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
            mockGrpcClient.Setup(x => x.DeletePerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeletePerInstanceConfigs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePerInstanceConfigsRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeletePerInstanceConfigsInstanceGroupManagerRequest request = new DeletePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq(),
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
            mockGrpcClient.Setup(x => x.DeletePerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeletePerInstanceConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeletePerInstanceConfigsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePerInstanceConfigs()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeletePerInstanceConfigsInstanceGroupManagerRequest request = new DeletePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq(),
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
            mockGrpcClient.Setup(x => x.DeletePerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeletePerInstanceConfigs(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersDeletePerInstanceConfigsReqResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePerInstanceConfigsAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            DeletePerInstanceConfigsInstanceGroupManagerRequest request = new DeletePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq(),
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
            mockGrpcClient.Setup(x => x.DeletePerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeletePerInstanceConfigsAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersDeletePerInstanceConfigsReqResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeletePerInstanceConfigsAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersDeletePerInstanceConfigsReqResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            GetInstanceGroupManagerRequest request = new GetInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = "id74b70bb8",
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            GetInstanceGroupManagerRequest request = new GetInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = "id74b70bb8",
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManager responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            GetInstanceGroupManagerRequest request = new GetInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = "id74b70bb8",
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager response = client.Get(request.Project, request.Zone, request.InstanceGroupManager);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            GetInstanceGroupManagerRequest request = new GetInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManager expectedResponse = new InstanceGroupManager
            {
                Id = "id74b70bb8",
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManager responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.InstanceGroupManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManager responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.InstanceGroupManager, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            InsertInstanceGroupManagerRequest request = new InsertInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            InsertInstanceGroupManagerRequest request = new InsertInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            InsertInstanceGroupManagerRequest request = new InsertInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Zone, request.InstanceGroupManagerResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            InsertInstanceGroupManagerRequest request = new InsertInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Zone, request.InstanceGroupManagerResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Zone, request.InstanceGroupManagerResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListInstanceGroupManagersRequest request = new ListInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InstanceGroupManagerList expectedResponse = new InstanceGroupManagerList
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagerList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListInstanceGroupManagersRequest request = new ListInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InstanceGroupManagerList expectedResponse = new InstanceGroupManagerList
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
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManagerList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagerList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManagerList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListInstanceGroupManagersRequest request = new ListInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            InstanceGroupManagerList expectedResponse = new InstanceGroupManagerList
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
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagerList response = client.List(request.Project, request.Zone);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListInstanceGroupManagersRequest request = new ListInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            InstanceGroupManagerList expectedResponse = new InstanceGroupManagerList
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
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManagerList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagerList responseCallSettings = await client.ListAsync(request.Project, request.Zone, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManagerList responseCancellationToken = await client.ListAsync(request.Project, request.Zone, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListErrorsRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListErrorsInstanceGroupManagersRequest request = new ListErrorsInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InstanceGroupManagersListErrorsResponse expectedResponse = new InstanceGroupManagersListErrorsResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceManagedByIgmError(),
                },
            };
            mockGrpcClient.Setup(x => x.ListErrors(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListErrorsResponse response = client.ListErrors(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListErrorsRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListErrorsInstanceGroupManagersRequest request = new ListErrorsInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InstanceGroupManagersListErrorsResponse expectedResponse = new InstanceGroupManagersListErrorsResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceManagedByIgmError(),
                },
            };
            mockGrpcClient.Setup(x => x.ListErrorsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManagersListErrorsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListErrorsResponse responseCallSettings = await client.ListErrorsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManagersListErrorsResponse responseCancellationToken = await client.ListErrorsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListErrors()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListErrorsInstanceGroupManagersRequest request = new ListErrorsInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManagersListErrorsResponse expectedResponse = new InstanceGroupManagersListErrorsResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceManagedByIgmError(),
                },
            };
            mockGrpcClient.Setup(x => x.ListErrors(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListErrorsResponse response = client.ListErrors(request.Project, request.Zone, request.InstanceGroupManager);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListErrorsAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListErrorsInstanceGroupManagersRequest request = new ListErrorsInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManagersListErrorsResponse expectedResponse = new InstanceGroupManagersListErrorsResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceManagedByIgmError(),
                },
            };
            mockGrpcClient.Setup(x => x.ListErrorsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManagersListErrorsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListErrorsResponse responseCallSettings = await client.ListErrorsAsync(request.Project, request.Zone, request.InstanceGroupManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManagersListErrorsResponse responseCancellationToken = await client.ListErrorsAsync(request.Project, request.Zone, request.InstanceGroupManager, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListManagedInstancesRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListManagedInstancesInstanceGroupManagersRequest request = new ListManagedInstancesInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InstanceGroupManagersListManagedInstancesResponse expectedResponse = new InstanceGroupManagersListManagedInstancesResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                ManagedInstances =
                {
                    new ManagedInstance(),
                },
            };
            mockGrpcClient.Setup(x => x.ListManagedInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListManagedInstancesResponse response = client.ListManagedInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListManagedInstancesRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListManagedInstancesInstanceGroupManagersRequest request = new ListManagedInstancesInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InstanceGroupManagersListManagedInstancesResponse expectedResponse = new InstanceGroupManagersListManagedInstancesResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                ManagedInstances =
                {
                    new ManagedInstance(),
                },
            };
            mockGrpcClient.Setup(x => x.ListManagedInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManagersListManagedInstancesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListManagedInstancesResponse responseCallSettings = await client.ListManagedInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManagersListManagedInstancesResponse responseCancellationToken = await client.ListManagedInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListManagedInstances()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListManagedInstancesInstanceGroupManagersRequest request = new ListManagedInstancesInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManagersListManagedInstancesResponse expectedResponse = new InstanceGroupManagersListManagedInstancesResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                ManagedInstances =
                {
                    new ManagedInstance(),
                },
            };
            mockGrpcClient.Setup(x => x.ListManagedInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListManagedInstancesResponse response = client.ListManagedInstances(request.Project, request.Zone, request.InstanceGroupManager);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListManagedInstancesAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListManagedInstancesInstanceGroupManagersRequest request = new ListManagedInstancesInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManagersListManagedInstancesResponse expectedResponse = new InstanceGroupManagersListManagedInstancesResponse
            {
                NextPageToken = "next_page_tokendbee0940",
                ManagedInstances =
                {
                    new ManagedInstance(),
                },
            };
            mockGrpcClient.Setup(x => x.ListManagedInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManagersListManagedInstancesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListManagedInstancesResponse responseCallSettings = await client.ListManagedInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManagersListManagedInstancesResponse responseCancellationToken = await client.ListManagedInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListPerInstanceConfigsRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListPerInstanceConfigsInstanceGroupManagersRequest request = new ListPerInstanceConfigsInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InstanceGroupManagersListPerInstanceConfigsResp expectedResponse = new InstanceGroupManagersListPerInstanceConfigsResp
            {
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PerInstanceConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListPerInstanceConfigsResp response = client.ListPerInstanceConfigs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListPerInstanceConfigsRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListPerInstanceConfigsInstanceGroupManagersRequest request = new ListPerInstanceConfigsInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InstanceGroupManagersListPerInstanceConfigsResp expectedResponse = new InstanceGroupManagersListPerInstanceConfigsResp
            {
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PerInstanceConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManagersListPerInstanceConfigsResp>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListPerInstanceConfigsResp responseCallSettings = await client.ListPerInstanceConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManagersListPerInstanceConfigsResp responseCancellationToken = await client.ListPerInstanceConfigsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListPerInstanceConfigs()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListPerInstanceConfigsInstanceGroupManagersRequest request = new ListPerInstanceConfigsInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManagersListPerInstanceConfigsResp expectedResponse = new InstanceGroupManagersListPerInstanceConfigsResp
            {
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PerInstanceConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListPerInstanceConfigsResp response = client.ListPerInstanceConfigs(request.Project, request.Zone, request.InstanceGroupManager);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListPerInstanceConfigsAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ListPerInstanceConfigsInstanceGroupManagersRequest request = new ListPerInstanceConfigsInstanceGroupManagersRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
            };
            InstanceGroupManagersListPerInstanceConfigsResp expectedResponse = new InstanceGroupManagersListPerInstanceConfigsResp
            {
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PerInstanceConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupManagersListPerInstanceConfigsResp>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            InstanceGroupManagersListPerInstanceConfigsResp responseCallSettings = await client.ListPerInstanceConfigsAsync(request.Project, request.Zone, request.InstanceGroupManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupManagersListPerInstanceConfigsResp responseCancellationToken = await client.ListPerInstanceConfigsAsync(request.Project, request.Zone, request.InstanceGroupManager, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchInstanceGroupManagerRequest request = new PatchInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchInstanceGroupManagerRequest request = new PatchInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchInstanceGroupManagerRequest request = new PatchInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagerResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchInstanceGroupManagerRequest request = new PatchInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagerResource = new InstanceGroupManager(),
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
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagerResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagerResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchPerInstanceConfigsRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchPerInstanceConfigsInstanceGroupManagerRequest request = new PatchPerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq(),
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
            mockGrpcClient.Setup(x => x.PatchPerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.PatchPerInstanceConfigs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchPerInstanceConfigsRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchPerInstanceConfigsInstanceGroupManagerRequest request = new PatchPerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq(),
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
            mockGrpcClient.Setup(x => x.PatchPerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchPerInstanceConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchPerInstanceConfigsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchPerInstanceConfigs()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchPerInstanceConfigsInstanceGroupManagerRequest request = new PatchPerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq(),
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
            mockGrpcClient.Setup(x => x.PatchPerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.PatchPerInstanceConfigs(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersPatchPerInstanceConfigsReqResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchPerInstanceConfigsAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            PatchPerInstanceConfigsInstanceGroupManagerRequest request = new PatchPerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq(),
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
            mockGrpcClient.Setup(x => x.PatchPerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchPerInstanceConfigsAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersPatchPerInstanceConfigsReqResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchPerInstanceConfigsAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersPatchPerInstanceConfigsReqResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RecreateInstancesRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            RecreateInstancesInstanceGroupManagerRequest request = new RecreateInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.RecreateInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RecreateInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RecreateInstancesRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            RecreateInstancesInstanceGroupManagerRequest request = new RecreateInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.RecreateInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RecreateInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RecreateInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RecreateInstances()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            RecreateInstancesInstanceGroupManagerRequest request = new RecreateInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.RecreateInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RecreateInstances(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersRecreateInstancesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RecreateInstancesAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            RecreateInstancesInstanceGroupManagerRequest request = new RecreateInstancesInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.RecreateInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RecreateInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersRecreateInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RecreateInstancesAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersRecreateInstancesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResizeRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ResizeInstanceGroupManagerRequest request = new ResizeInstanceGroupManagerRequest
            {
                Size = -1218396681,
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.Resize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Resize(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResizeRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ResizeInstanceGroupManagerRequest request = new ResizeInstanceGroupManagerRequest
            {
                Size = -1218396681,
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.ResizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ResizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ResizeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Resize()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ResizeInstanceGroupManagerRequest request = new ResizeInstanceGroupManagerRequest
            {
                Size = -1218396681,
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.Resize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Resize(request.Project, request.Zone, request.InstanceGroupManager, request.Size);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResizeAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            ResizeInstanceGroupManagerRequest request = new ResizeInstanceGroupManagerRequest
            {
                Size = -1218396681,
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.ResizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ResizeAsync(request.Project, request.Zone, request.InstanceGroupManager, request.Size, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ResizeAsync(request.Project, request.Zone, request.InstanceGroupManager, request.Size, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetInstanceTemplateRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetInstanceTemplateInstanceGroupManagerRequest request = new SetInstanceTemplateInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetInstanceTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetInstanceTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetInstanceTemplateRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetInstanceTemplateInstanceGroupManagerRequest request = new SetInstanceTemplateInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest(),
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetInstanceTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetInstanceTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetInstanceTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetInstanceTemplate()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetInstanceTemplateInstanceGroupManagerRequest request = new SetInstanceTemplateInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetInstanceTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetInstanceTemplate(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersSetInstanceTemplateRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetInstanceTemplateAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetInstanceTemplateInstanceGroupManagerRequest request = new SetInstanceTemplateInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.SetInstanceTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetInstanceTemplateAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersSetInstanceTemplateRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetInstanceTemplateAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersSetInstanceTemplateRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetTargetPoolsRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetTargetPoolsInstanceGroupManagerRequest request = new SetTargetPoolsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest(),
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
            mockGrpcClient.Setup(x => x.SetTargetPools(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetTargetPools(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetTargetPoolsRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetTargetPoolsInstanceGroupManagerRequest request = new SetTargetPoolsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest(),
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
            mockGrpcClient.Setup(x => x.SetTargetPoolsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetTargetPoolsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetTargetPoolsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetTargetPools()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetTargetPoolsInstanceGroupManagerRequest request = new SetTargetPoolsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest(),
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
            mockGrpcClient.Setup(x => x.SetTargetPools(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetTargetPools(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersSetTargetPoolsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetTargetPoolsAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            SetTargetPoolsInstanceGroupManagerRequest request = new SetTargetPoolsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
                InstanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest(),
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
            mockGrpcClient.Setup(x => x.SetTargetPoolsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetTargetPoolsAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersSetTargetPoolsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetTargetPoolsAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersSetTargetPoolsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePerInstanceConfigsRequestObject()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            UpdatePerInstanceConfigsInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.UpdatePerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdatePerInstanceConfigs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePerInstanceConfigsRequestObjectAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            UpdatePerInstanceConfigsInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.UpdatePerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdatePerInstanceConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdatePerInstanceConfigsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePerInstanceConfigs()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            UpdatePerInstanceConfigsInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.UpdatePerInstanceConfigs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdatePerInstanceConfigs(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersUpdatePerInstanceConfigsReqResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePerInstanceConfigsAsync()
        {
            moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient> mockGrpcClient = new moq::Mock<InstanceGroupManagers.InstanceGroupManagersClient>(moq::MockBehavior.Strict);
            UpdatePerInstanceConfigsInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq(),
                Project = "projectaa6ff846",
                InstanceGroupManager = "instance_group_manager71b45dfc",
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
            mockGrpcClient.Setup(x => x.UpdatePerInstanceConfigsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupManagersClient client = new InstanceGroupManagersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdatePerInstanceConfigsAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersUpdatePerInstanceConfigsReqResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdatePerInstanceConfigsAsync(request.Project, request.Zone, request.InstanceGroupManager, request.InstanceGroupManagersUpdatePerInstanceConfigsReqResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
