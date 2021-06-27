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
    public sealed class GeneratedSubnetworksClientTest
    {
        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            AggregatedListSubnetworksRequest request = new AggregatedListSubnetworksRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            SubnetworkAggregatedList expectedResponse = new SubnetworkAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new SubnetworksScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            SubnetworkAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            AggregatedListSubnetworksRequest request = new AggregatedListSubnetworksRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            SubnetworkAggregatedList expectedResponse = new SubnetworkAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new SubnetworksScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SubnetworkAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            SubnetworkAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SubnetworkAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            AggregatedListSubnetworksRequest request = new AggregatedListSubnetworksRequest
            {
                Project = "projectaa6ff846",
            };
            SubnetworkAggregatedList expectedResponse = new SubnetworkAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new SubnetworksScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            SubnetworkAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            AggregatedListSubnetworksRequest request = new AggregatedListSubnetworksRequest
            {
                Project = "projectaa6ff846",
            };
            SubnetworkAggregatedList expectedResponse = new SubnetworkAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new SubnetworksScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SubnetworkAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            SubnetworkAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SubnetworkAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            DeleteSubnetworkRequest request = new DeleteSubnetworkRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            DeleteSubnetworkRequest request = new DeleteSubnetworkRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            DeleteSubnetworkRequest request = new DeleteSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.Subnetwork);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            DeleteSubnetworkRequest request = new DeleteSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.Subnetwork, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.Subnetwork, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ExpandIpCidrRangeRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ExpandIpCidrRangeSubnetworkRequest request = new ExpandIpCidrRangeSubnetworkRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
                SubnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest(),
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
            mockGrpcClient.Setup(x => x.ExpandIpCidrRange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.ExpandIpCidrRange(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExpandIpCidrRangeRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ExpandIpCidrRangeSubnetworkRequest request = new ExpandIpCidrRangeSubnetworkRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
                SubnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest(),
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
            mockGrpcClient.Setup(x => x.ExpandIpCidrRangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ExpandIpCidrRangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ExpandIpCidrRangeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ExpandIpCidrRange()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ExpandIpCidrRangeSubnetworkRequest request = new ExpandIpCidrRangeSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
                SubnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest(),
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
            mockGrpcClient.Setup(x => x.ExpandIpCidrRange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.ExpandIpCidrRange(request.Project, request.Region, request.Subnetwork, request.SubnetworksExpandIpCidrRangeRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExpandIpCidrRangeAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ExpandIpCidrRangeSubnetworkRequest request = new ExpandIpCidrRangeSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
                SubnetworksExpandIpCidrRangeRequestResource = new SubnetworksExpandIpCidrRangeRequest(),
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
            mockGrpcClient.Setup(x => x.ExpandIpCidrRangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ExpandIpCidrRangeAsync(request.Project, request.Region, request.Subnetwork, request.SubnetworksExpandIpCidrRangeRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ExpandIpCidrRangeAsync(request.Project, request.Region, request.Subnetwork, request.SubnetworksExpandIpCidrRangeRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
            };
            Subnetwork expectedResponse = new Subnetwork
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Role = Subnetwork.Types.Role.Active,
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = Subnetwork.Types.PrivateIpv6GoogleAccess.EnableOutboundVmAccessToGoogle,
                IpCidrRange = "ip_cidr_range745a04d3",
                State = Subnetwork.Types.State.UndefinedState,
                SecondaryIpRanges =
                {
                    new SubnetworkSecondaryRange(),
                },
                Region = "regionedb20d96",
                EnableFlowLogs = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Ipv6CidrRange = "ipv6_cidr_range0b2dc35f",
                Purpose = Subnetwork.Types.Purpose.PrivateRfc1918,
                LogConfig = new SubnetworkLogConfig(),
                PrivateIpGoogleAccess = false,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                GatewayAddress = "gateway_address39dbeaef",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Subnetwork response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
            };
            Subnetwork expectedResponse = new Subnetwork
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Role = Subnetwork.Types.Role.Active,
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = Subnetwork.Types.PrivateIpv6GoogleAccess.EnableOutboundVmAccessToGoogle,
                IpCidrRange = "ip_cidr_range745a04d3",
                State = Subnetwork.Types.State.UndefinedState,
                SecondaryIpRanges =
                {
                    new SubnetworkSecondaryRange(),
                },
                Region = "regionedb20d96",
                EnableFlowLogs = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Ipv6CidrRange = "ipv6_cidr_range0b2dc35f",
                Purpose = Subnetwork.Types.Purpose.PrivateRfc1918,
                LogConfig = new SubnetworkLogConfig(),
                PrivateIpGoogleAccess = false,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                GatewayAddress = "gateway_address39dbeaef",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subnetwork>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Subnetwork responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subnetwork responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
            };
            Subnetwork expectedResponse = new Subnetwork
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Role = Subnetwork.Types.Role.Active,
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = Subnetwork.Types.PrivateIpv6GoogleAccess.EnableOutboundVmAccessToGoogle,
                IpCidrRange = "ip_cidr_range745a04d3",
                State = Subnetwork.Types.State.UndefinedState,
                SecondaryIpRanges =
                {
                    new SubnetworkSecondaryRange(),
                },
                Region = "regionedb20d96",
                EnableFlowLogs = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Ipv6CidrRange = "ipv6_cidr_range0b2dc35f",
                Purpose = Subnetwork.Types.Purpose.PrivateRfc1918,
                LogConfig = new SubnetworkLogConfig(),
                PrivateIpGoogleAccess = false,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                GatewayAddress = "gateway_address39dbeaef",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Subnetwork response = client.Get(request.Project, request.Region, request.Subnetwork);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            GetSubnetworkRequest request = new GetSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
            };
            Subnetwork expectedResponse = new Subnetwork
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Role = Subnetwork.Types.Role.Active,
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = Subnetwork.Types.PrivateIpv6GoogleAccess.EnableOutboundVmAccessToGoogle,
                IpCidrRange = "ip_cidr_range745a04d3",
                State = Subnetwork.Types.State.UndefinedState,
                SecondaryIpRanges =
                {
                    new SubnetworkSecondaryRange(),
                },
                Region = "regionedb20d96",
                EnableFlowLogs = false,
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Ipv6CidrRange = "ipv6_cidr_range0b2dc35f",
                Purpose = Subnetwork.Types.Purpose.PrivateRfc1918,
                LogConfig = new SubnetworkLogConfig(),
                PrivateIpGoogleAccess = false,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                GatewayAddress = "gateway_address39dbeaef",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Subnetwork>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Subnetwork responseCallSettings = await client.GetAsync(request.Project, request.Region, request.Subnetwork, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Subnetwork responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.Subnetwork, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request.Project, request.Region, request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            GetIamPolicySubnetworkRequest request = new GetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request.Project, request.Region, request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Project, request.Region, request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            InsertSubnetworkRequest request = new InsertSubnetworkRequest
            {
                RequestId = "request_id362c8df6",
                SubnetworkResource = new Subnetwork(),
                Region = "regionedb20d96",
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
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            InsertSubnetworkRequest request = new InsertSubnetworkRequest
            {
                RequestId = "request_id362c8df6",
                SubnetworkResource = new Subnetwork(),
                Region = "regionedb20d96",
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
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            InsertSubnetworkRequest request = new InsertSubnetworkRequest
            {
                SubnetworkResource = new Subnetwork(),
                Region = "regionedb20d96",
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
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.SubnetworkResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            InsertSubnetworkRequest request = new InsertSubnetworkRequest
            {
                SubnetworkResource = new Subnetwork(),
                Region = "regionedb20d96",
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
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.SubnetworkResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.SubnetworkResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ListSubnetworksRequest request = new ListSubnetworksRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            SubnetworkList expectedResponse = new SubnetworkList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Subnetwork(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            SubnetworkList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ListSubnetworksRequest request = new ListSubnetworksRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            SubnetworkList expectedResponse = new SubnetworkList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Subnetwork(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SubnetworkList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            SubnetworkList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SubnetworkList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ListSubnetworksRequest request = new ListSubnetworksRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            SubnetworkList expectedResponse = new SubnetworkList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Subnetwork(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            SubnetworkList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ListSubnetworksRequest request = new ListSubnetworksRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            SubnetworkList expectedResponse = new SubnetworkList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Subnetwork(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SubnetworkList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            SubnetworkList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SubnetworkList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListUsableRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            UsableSubnetworksAggregatedList expectedResponse = new UsableSubnetworksAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new UsableSubnetwork(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListUsable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            UsableSubnetworksAggregatedList response = client.ListUsable(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListUsableRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            UsableSubnetworksAggregatedList expectedResponse = new UsableSubnetworksAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new UsableSubnetwork(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListUsableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UsableSubnetworksAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            UsableSubnetworksAggregatedList responseCallSettings = await client.ListUsableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UsableSubnetworksAggregatedList responseCancellationToken = await client.ListUsableAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListUsable()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                Project = "projectaa6ff846",
            };
            UsableSubnetworksAggregatedList expectedResponse = new UsableSubnetworksAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new UsableSubnetwork(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListUsable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            UsableSubnetworksAggregatedList response = client.ListUsable(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListUsableAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            ListUsableSubnetworksRequest request = new ListUsableSubnetworksRequest
            {
                Project = "projectaa6ff846",
            };
            UsableSubnetworksAggregatedList expectedResponse = new UsableSubnetworksAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new UsableSubnetwork(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListUsableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UsableSubnetworksAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            UsableSubnetworksAggregatedList responseCallSettings = await client.ListUsableAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UsableSubnetworksAggregatedList responseCancellationToken = await client.ListUsableAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            PatchSubnetworkRequest request = new PatchSubnetworkRequest
            {
                RequestId = "request_id362c8df6",
                SubnetworkResource = new Subnetwork(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
                DrainTimeoutSeconds = -72030427,
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            PatchSubnetworkRequest request = new PatchSubnetworkRequest
            {
                RequestId = "request_id362c8df6",
                SubnetworkResource = new Subnetwork(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
                DrainTimeoutSeconds = -72030427,
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            PatchSubnetworkRequest request = new PatchSubnetworkRequest
            {
                SubnetworkResource = new Subnetwork(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.Region, request.Subnetwork, request.SubnetworkResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            PatchSubnetworkRequest request = new PatchSubnetworkRequest
            {
                SubnetworkResource = new Subnetwork(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Subnetwork = "subnetworkf55bf572",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.Region, request.Subnetwork, request.SubnetworkResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.Region, request.Subnetwork, request.SubnetworkResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            SetIamPolicySubnetworkRequest request = new SetIamPolicySubnetworkRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetPrivateIpGoogleAccessRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            SetPrivateIpGoogleAccessSubnetworkRequest request = new SetPrivateIpGoogleAccessSubnetworkRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                SubnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest(),
                Subnetwork = "subnetworkf55bf572",
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
            mockGrpcClient.Setup(x => x.SetPrivateIpGoogleAccess(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetPrivateIpGoogleAccess(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetPrivateIpGoogleAccessRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            SetPrivateIpGoogleAccessSubnetworkRequest request = new SetPrivateIpGoogleAccessSubnetworkRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                SubnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest(),
                Subnetwork = "subnetworkf55bf572",
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
            mockGrpcClient.Setup(x => x.SetPrivateIpGoogleAccessAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetPrivateIpGoogleAccessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetPrivateIpGoogleAccessAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetPrivateIpGoogleAccess()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            SetPrivateIpGoogleAccessSubnetworkRequest request = new SetPrivateIpGoogleAccessSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                SubnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest(),
                Subnetwork = "subnetworkf55bf572",
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
            mockGrpcClient.Setup(x => x.SetPrivateIpGoogleAccess(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetPrivateIpGoogleAccess(request.Project, request.Region, request.Subnetwork, request.SubnetworksSetPrivateIpGoogleAccessRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetPrivateIpGoogleAccessAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            SetPrivateIpGoogleAccessSubnetworkRequest request = new SetPrivateIpGoogleAccessSubnetworkRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                SubnetworksSetPrivateIpGoogleAccessRequestResource = new SubnetworksSetPrivateIpGoogleAccessRequest(),
                Subnetwork = "subnetworkf55bf572",
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
            mockGrpcClient.Setup(x => x.SetPrivateIpGoogleAccessAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetPrivateIpGoogleAccessAsync(request.Project, request.Region, request.Subnetwork, request.SubnetworksSetPrivateIpGoogleAccessRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetPrivateIpGoogleAccessAsync(request.Project, request.Region, request.Subnetwork, request.SubnetworksSetPrivateIpGoogleAccessRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<Subnetworks.SubnetworksClient> mockGrpcClient = new moq::Mock<Subnetworks.SubnetworksClient>(moq::MockBehavior.Strict);
            TestIamPermissionsSubnetworkRequest request = new TestIamPermissionsSubnetworkRequest
            {
                Region = "regionedb20d96",
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
            SubnetworksClient client = new SubnetworksClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
