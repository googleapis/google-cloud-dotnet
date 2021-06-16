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
    public sealed class GeneratedRegionNetworkEndpointGroupsClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteRegionNetworkEndpointGroupRequest request = new DeleteRegionNetworkEndpointGroupRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteRegionNetworkEndpointGroupRequest request = new DeleteRegionNetworkEndpointGroupRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteRegionNetworkEndpointGroupRequest request = new DeleteRegionNetworkEndpointGroupRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.NetworkEndpointGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            DeleteRegionNetworkEndpointGroupRequest request = new DeleteRegionNetworkEndpointGroupRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.NetworkEndpointGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.NetworkEndpointGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetRegionNetworkEndpointGroupRequest request = new GetRegionNetworkEndpointGroupRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = "id74b70bb8",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetRegionNetworkEndpointGroupRequest request = new GetRegionNetworkEndpointGroupRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = "id74b70bb8",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroup responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetRegionNetworkEndpointGroupRequest request = new GetRegionNetworkEndpointGroupRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = "id74b70bb8",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup response = client.Get(request.Project, request.Region, request.NetworkEndpointGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            GetRegionNetworkEndpointGroupRequest request = new GetRegionNetworkEndpointGroupRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroup = "network_endpoint_groupdf1fb34e",
            };
            NetworkEndpointGroup expectedResponse = new NetworkEndpointGroup
            {
                Id = "id74b70bb8",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroup responseCallSettings = await client.GetAsync(request.Project, request.Region, request.NetworkEndpointGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroup responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.NetworkEndpointGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertRegionNetworkEndpointGroupRequest request = new InsertRegionNetworkEndpointGroupRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertRegionNetworkEndpointGroupRequest request = new InsertRegionNetworkEndpointGroupRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertRegionNetworkEndpointGroupRequest request = new InsertRegionNetworkEndpointGroupRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.NetworkEndpointGroupResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            InsertRegionNetworkEndpointGroupRequest request = new InsertRegionNetworkEndpointGroupRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.NetworkEndpointGroupResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.NetworkEndpointGroupResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListRegionNetworkEndpointGroupsRequest request = new ListRegionNetworkEndpointGroupsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListRegionNetworkEndpointGroupsRequest request = new ListRegionNetworkEndpointGroupsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroupList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListRegionNetworkEndpointGroupsRequest request = new ListRegionNetworkEndpointGroupsRequest
            {
                Region = "regionedb20d96",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient> mockGrpcClient = new moq::Mock<RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient>(moq::MockBehavior.Strict);
            ListRegionNetworkEndpointGroupsRequest request = new ListRegionNetworkEndpointGroupsRequest
            {
                Region = "regionedb20d96",
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
            RegionNetworkEndpointGroupsClient client = new RegionNetworkEndpointGroupsClientImpl(mockGrpcClient.Object, null);
            NetworkEndpointGroupList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkEndpointGroupList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
