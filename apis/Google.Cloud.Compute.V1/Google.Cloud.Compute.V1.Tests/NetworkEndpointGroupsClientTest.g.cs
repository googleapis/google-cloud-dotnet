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
    public sealed class GeneratedNetworkEndpointGroupsClientTest
    {
        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AggregatedListNetworkEndpointGroupsRequest request = new AggregatedListNetworkEndpointGroupsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            NetworkEndpointGroupAggregatedList expectedResponse = new NetworkEndpointGroupAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new NetworkEndpointGroupsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AggregatedListNetworkEndpointGroupsRequest request = new AggregatedListNetworkEndpointGroupsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            NetworkEndpointGroupAggregatedList expectedResponse = new NetworkEndpointGroupAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new NetworkEndpointGroupsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkEndpointGroupAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroupAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AggregatedListNetworkEndpointGroupsRequest request = new AggregatedListNetworkEndpointGroupsRequest
            {
                Project = "projectaa6ff846",
            };
            NetworkEndpointGroupAggregatedList expectedResponse = new NetworkEndpointGroupAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new NetworkEndpointGroupsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AggregatedListNetworkEndpointGroupsRequest request = new AggregatedListNetworkEndpointGroupsRequest
            {
                Project = "projectaa6ff846",
            };
            NetworkEndpointGroupAggregatedList expectedResponse = new NetworkEndpointGroupAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new NetworkEndpointGroupsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkEndpointGroupAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroupAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AttachNetworkEndpointsRequestObject()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AttachNetworkEndpointsNetworkEndpointGroupRequest request = new AttachNetworkEndpointsNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest(),
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AttachNetworkEndpoints(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AttachNetworkEndpointsRequestObjectAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AttachNetworkEndpointsNetworkEndpointGroupRequest request = new AttachNetworkEndpointsNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest(),
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AttachNetworkEndpointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AttachNetworkEndpointsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AttachNetworkEndpoints()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AttachNetworkEndpointsNetworkEndpointGroupRequest request = new AttachNetworkEndpointsNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest(),
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AttachNetworkEndpoints(request.Project, request.Zone, request.NetworkEndpointGroup, request.NetworkEndpointGroupsAttachEndpointsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AttachNetworkEndpointsAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            AttachNetworkEndpointsNetworkEndpointGroupRequest request = new AttachNetworkEndpointsNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest(),
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AttachNetworkEndpointsAsync(request.Project, request.Zone, request.NetworkEndpointGroup, request.NetworkEndpointGroupsAttachEndpointsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AttachNetworkEndpointsAsync(request.Project, request.Zone, request.NetworkEndpointGroup, request.NetworkEndpointGroupsAttachEndpointsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteNetworkEndpointGroupRequest request = new DeleteNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteNetworkEndpointGroupRequest request = new DeleteNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteNetworkEndpointGroupRequest request = new DeleteNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Zone, request.NetworkEndpointGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteNetworkEndpointGroupRequest request = new DeleteNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Zone, request.NetworkEndpointGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Zone, request.NetworkEndpointGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetachNetworkEndpointsRequestObject()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DetachNetworkEndpointsNetworkEndpointGroupRequest request = new DetachNetworkEndpointsNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
                NetworkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest(),
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DetachNetworkEndpoints(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetachNetworkEndpointsRequestObjectAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DetachNetworkEndpointsNetworkEndpointGroupRequest request = new DetachNetworkEndpointsNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
                NetworkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest(),
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DetachNetworkEndpointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DetachNetworkEndpointsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetachNetworkEndpoints()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DetachNetworkEndpointsNetworkEndpointGroupRequest request = new DetachNetworkEndpointsNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
                NetworkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest(),
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DetachNetworkEndpoints(request.Project, request.Zone, request.NetworkEndpointGroup, request.NetworkEndpointGroupsDetachEndpointsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetachNetworkEndpointsAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DetachNetworkEndpointsNetworkEndpointGroupRequest request = new DetachNetworkEndpointsNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
                NetworkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest(),
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DetachNetworkEndpointsAsync(request.Project, request.Zone, request.NetworkEndpointGroup, request.NetworkEndpointGroupsDetachEndpointsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DetachNetworkEndpointsAsync(request.Project, request.Zone, request.NetworkEndpointGroup, request.NetworkEndpointGroupsDetachEndpointsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetNetworkEndpointGroupRequest request = new GetNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetNetworkEndpointGroupRequest request = new GetNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroup responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetNetworkEndpointGroupRequest request = new GetNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup response = client.Get(request.Project, request.Zone, request.NetworkEndpointGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetNetworkEndpointGroupRequest request = new GetNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.NetworkEndpointGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroup responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.NetworkEndpointGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertNetworkEndpointGroupRequest request = new InsertNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertNetworkEndpointGroupRequest request = new InsertNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertNetworkEndpointGroupRequest request = new InsertNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Zone, request.NetworkEndpointGroupResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertNetworkEndpointGroupRequest request = new InsertNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Zone, request.NetworkEndpointGroupResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Zone, request.NetworkEndpointGroupResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListNetworkEndpointGroupsRequest request = new ListNetworkEndpointGroupsRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            NetworkEndpointGroupList expectedResponse = new NetworkEndpointGroupList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new NetworkEndpointGroup(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListNetworkEndpointGroupsRequest request = new ListNetworkEndpointGroupsRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            NetworkEndpointGroupList expectedResponse = new NetworkEndpointGroupList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new NetworkEndpointGroup(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkEndpointGroupList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroupList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListNetworkEndpointGroupsRequest request = new ListNetworkEndpointGroupsRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            NetworkEndpointGroupList expectedResponse = new NetworkEndpointGroupList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new NetworkEndpointGroup(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupList response = client.List(request.Project, request.Zone);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListNetworkEndpointGroupsRequest request = new ListNetworkEndpointGroupsRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            NetworkEndpointGroupList expectedResponse = new NetworkEndpointGroupList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new NetworkEndpointGroup(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkEndpointGroupList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupList responseCallSettings = await client.ListAsync(request.Project, request.Zone, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroupList responseCancellationToken = await client.ListAsync(request.Project, request.Zone, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListNetworkEndpointsRequestObject()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListNetworkEndpointsNetworkEndpointGroupsRequest request = new ListNetworkEndpointsNetworkEndpointGroupsRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                NetworkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest(),
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
                ReturnPartialSuccess = false,
            };
            NetworkEndpointGroupsListNetworkEndpoints expectedResponse = new NetworkEndpointGroupsListNetworkEndpoints
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new NetworkEndpointWithHealthStatus(),
                },
            };
            mockGrpcClient.Setup(x => x.ListNetworkEndpoints(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupsListNetworkEndpoints response = client.ListNetworkEndpoints(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListNetworkEndpointsRequestObjectAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListNetworkEndpointsNetworkEndpointGroupsRequest request = new ListNetworkEndpointsNetworkEndpointGroupsRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                NetworkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest(),
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
                ReturnPartialSuccess = false,
            };
            NetworkEndpointGroupsListNetworkEndpoints expectedResponse = new NetworkEndpointGroupsListNetworkEndpoints
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new NetworkEndpointWithHealthStatus(),
                },
            };
            mockGrpcClient.Setup(x => x.ListNetworkEndpointsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkEndpointGroupsListNetworkEndpoints>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupsListNetworkEndpoints responseCallSettings = await client.ListNetworkEndpointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroupsListNetworkEndpoints responseCancellationToken = await client.ListNetworkEndpointsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListNetworkEndpoints()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListNetworkEndpointsNetworkEndpointGroupsRequest request = new ListNetworkEndpointsNetworkEndpointGroupsRequest
            {
                Zone = "zone255f4ea8",
                NetworkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest(),
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroupsListNetworkEndpoints expectedResponse = new NetworkEndpointGroupsListNetworkEndpoints
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new NetworkEndpointWithHealthStatus(),
                },
            };
            mockGrpcClient.Setup(x => x.ListNetworkEndpoints(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupsListNetworkEndpoints response = client.ListNetworkEndpoints(request.Project, request.Zone, request.NetworkEndpointGroup, request.NetworkEndpointGroupsListEndpointsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListNetworkEndpointsAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListNetworkEndpointsNetworkEndpointGroupsRequest request = new ListNetworkEndpointsNetworkEndpointGroupsRequest
            {
                Zone = "zone255f4ea8",
                NetworkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest(),
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroupsListNetworkEndpoints expectedResponse = new NetworkEndpointGroupsListNetworkEndpoints
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new NetworkEndpointWithHealthStatus(),
                },
            };
            mockGrpcClient.Setup(x => x.ListNetworkEndpointsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkEndpointGroupsListNetworkEndpoints>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupsListNetworkEndpoints responseCallSettings = await client.ListNetworkEndpointsAsync(request.Project, request.Zone, request.NetworkEndpointGroup, request.NetworkEndpointGroupsListEndpointsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroupsListNetworkEndpoints responseCancellationToken = await client.ListNetworkEndpointsAsync(request.Project, request.Zone, request.NetworkEndpointGroup, request.NetworkEndpointGroupsListEndpointsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsNetworkEndpointGroupRequest request = new TestIamPermissionsNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsNetworkEndpointGroupRequest request = new TestIamPermissionsNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsNetworkEndpointGroupRequest request = new TestIamPermissionsNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<NetworkEndpointGroups.NetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsNetworkEndpointGroupRequest request = new TestIamPermissionsNetworkEndpointGroupRequest
            {
                Zone = "zone255f4ea8",
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
            NetworkEndpointGroupsClient client = new NetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
