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
    public sealed class GeneratedInstanceGroupsClientTest
    {
        [xunit::FactAttribute]
        public void AddInstancesRequestObject()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            AddInstancesInstanceGroupRequest request = new AddInstancesInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AddInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddInstancesRequestObjectAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            AddInstancesInstanceGroupRequest request = new AddInstancesInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AddInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddInstances()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            AddInstancesInstanceGroupRequest request = new AddInstancesInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AddInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddInstances(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsAddInstancesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddInstancesAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            AddInstancesInstanceGroupRequest request = new AddInstancesInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.AddInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddInstancesAsync(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsAddInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddInstancesAsync(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsAddInstancesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            AggregatedListInstanceGroupsRequest request = new AggregatedListInstanceGroupsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            InstanceGroupAggregatedList expectedResponse = new InstanceGroupAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InstanceGroupsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            AggregatedListInstanceGroupsRequest request = new AggregatedListInstanceGroupsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            InstanceGroupAggregatedList expectedResponse = new InstanceGroupAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InstanceGroupsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            AggregatedListInstanceGroupsRequest request = new AggregatedListInstanceGroupsRequest
            {
                Project = "projectaa6ff846",
            };
            InstanceGroupAggregatedList expectedResponse = new InstanceGroupAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InstanceGroupsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            AggregatedListInstanceGroupsRequest request = new AggregatedListInstanceGroupsRequest
            {
                Project = "projectaa6ff846",
            };
            InstanceGroupAggregatedList expectedResponse = new InstanceGroupAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InstanceGroupsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            DeleteInstanceGroupRequest request = new DeleteInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroup = "instance_group6bf5a5ef",
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
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            DeleteInstanceGroupRequest request = new DeleteInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroup = "instance_group6bf5a5ef",
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
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            DeleteInstanceGroupRequest request = new DeleteInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
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
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Zone, request.InstanceGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            DeleteInstanceGroupRequest request = new DeleteInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
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
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Zone, request.InstanceGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Zone, request.InstanceGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
            };
            InstanceGroup expectedResponse = new InstanceGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Subnetwork = "subnetworkf55bf572",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroup response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
            };
            InstanceGroup expectedResponse = new InstanceGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Subnetwork = "subnetworkf55bf572",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroup responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroup responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
            };
            InstanceGroup expectedResponse = new InstanceGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Subnetwork = "subnetworkf55bf572",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroup response = client.Get(request.Project, request.Zone, request.InstanceGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
            };
            InstanceGroup expectedResponse = new InstanceGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Subnetwork = "subnetworkf55bf572",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroup responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.InstanceGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroup responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.InstanceGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            InsertInstanceGroupRequest request = new InsertInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupResource = new InstanceGroup(),
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
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            InsertInstanceGroupRequest request = new InsertInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstanceGroupResource = new InstanceGroup(),
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
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            InsertInstanceGroupRequest request = new InsertInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupResource = new InstanceGroup(),
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
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Zone, request.InstanceGroupResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            InsertInstanceGroupRequest request = new InsertInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                InstanceGroupResource = new InstanceGroup(),
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
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Zone, request.InstanceGroupResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Zone, request.InstanceGroupResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            ListInstanceGroupsRequest request = new ListInstanceGroupsRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InstanceGroupList expectedResponse = new InstanceGroupList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceGroup(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            ListInstanceGroupsRequest request = new ListInstanceGroupsRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InstanceGroupList expectedResponse = new InstanceGroupList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceGroup(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            ListInstanceGroupsRequest request = new ListInstanceGroupsRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            InstanceGroupList expectedResponse = new InstanceGroupList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceGroup(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupList response = client.List(request.Project, request.Zone);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            ListInstanceGroupsRequest request = new ListInstanceGroupsRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            InstanceGroupList expectedResponse = new InstanceGroupList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceGroup(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupList responseCallSettings = await client.ListAsync(request.Project, request.Zone, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupList responseCancellationToken = await client.ListAsync(request.Project, request.Zone, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListInstancesRequestObject()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            ListInstancesInstanceGroupsRequest request = new ListInstancesInstanceGroupsRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                InstanceGroup = "instance_group6bf5a5ef",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                InstanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest(),
                ReturnPartialSuccess = false,
            };
            InstanceGroupsListInstances expectedResponse = new InstanceGroupsListInstances
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceWithNamedPorts(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupsListInstances response = client.ListInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListInstancesRequestObjectAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            ListInstancesInstanceGroupsRequest request = new ListInstancesInstanceGroupsRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                InstanceGroup = "instance_group6bf5a5ef",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                InstanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest(),
                ReturnPartialSuccess = false,
            };
            InstanceGroupsListInstances expectedResponse = new InstanceGroupsListInstances
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceWithNamedPorts(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupsListInstances>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupsListInstances responseCallSettings = await client.ListInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupsListInstances responseCancellationToken = await client.ListInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListInstances()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            ListInstancesInstanceGroupsRequest request = new ListInstancesInstanceGroupsRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest(),
            };
            InstanceGroupsListInstances expectedResponse = new InstanceGroupsListInstances
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceWithNamedPorts(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupsListInstances response = client.ListInstances(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsListInstancesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListInstancesAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            ListInstancesInstanceGroupsRequest request = new ListInstancesInstanceGroupsRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest(),
            };
            InstanceGroupsListInstances expectedResponse = new InstanceGroupsListInstances
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InstanceWithNamedPorts(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroupsListInstances>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            InstanceGroupsListInstances responseCallSettings = await client.ListInstancesAsync(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsListInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroupsListInstances responseCancellationToken = await client.ListInstancesAsync(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsListInstancesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveInstancesRequestObject()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            RemoveInstancesInstanceGroupRequest request = new RemoveInstancesInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.RemoveInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveInstancesRequestObjectAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            RemoveInstancesInstanceGroupRequest request = new RemoveInstancesInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.RemoveInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveInstances()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            RemoveInstancesInstanceGroupRequest request = new RemoveInstancesInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.RemoveInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveInstances(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsRemoveInstancesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveInstancesAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            RemoveInstancesInstanceGroupRequest request = new RemoveInstancesInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest(),
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
            mockGrpcClient.Setup(x => x.RemoveInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveInstancesAsync(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsRemoveInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveInstancesAsync(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsRemoveInstancesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetNamedPortsRequestObject()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            SetNamedPortsInstanceGroupRequest request = new SetNamedPortsInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest(),
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
            mockGrpcClient.Setup(x => x.SetNamedPorts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetNamedPorts(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetNamedPortsRequestObjectAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            SetNamedPortsInstanceGroupRequest request = new SetNamedPortsInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest(),
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
            mockGrpcClient.Setup(x => x.SetNamedPortsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetNamedPortsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetNamedPortsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetNamedPorts()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            SetNamedPortsInstanceGroupRequest request = new SetNamedPortsInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest(),
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
            mockGrpcClient.Setup(x => x.SetNamedPorts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetNamedPorts(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsSetNamedPortsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetNamedPortsAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            SetNamedPortsInstanceGroupRequest request = new SetNamedPortsInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
                InstanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest(),
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
            mockGrpcClient.Setup(x => x.SetNamedPortsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetNamedPortsAsync(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsSetNamedPortsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetNamedPortsAsync(request.Project, request.Zone, request.InstanceGroup, request.InstanceGroupsSetNamedPortsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
