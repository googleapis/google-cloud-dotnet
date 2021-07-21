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
    public sealed class GeneratedTargetPoolsClientTest
    {
        [xunit::FactAttribute]
        public void AddHealthCheckRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AddHealthCheckTargetPoolRequest request = new AddHealthCheckTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest(),
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
            mockGrpcClient.Setup(x => x.AddHealthCheck(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddHealthCheck(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddHealthCheckRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AddHealthCheckTargetPoolRequest request = new AddHealthCheckTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest(),
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
            mockGrpcClient.Setup(x => x.AddHealthCheckAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddHealthCheckAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddHealthCheckAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddHealthCheck()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AddHealthCheckTargetPoolRequest request = new AddHealthCheckTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest(),
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
            mockGrpcClient.Setup(x => x.AddHealthCheck(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddHealthCheck(request.Project, request.Region, request.TargetPool, request.TargetPoolsAddHealthCheckRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddHealthCheckAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AddHealthCheckTargetPoolRequest request = new AddHealthCheckTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest(),
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
            mockGrpcClient.Setup(x => x.AddHealthCheckAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddHealthCheckAsync(request.Project, request.Region, request.TargetPool, request.TargetPoolsAddHealthCheckRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddHealthCheckAsync(request.Project, request.Region, request.TargetPool, request.TargetPoolsAddHealthCheckRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddInstanceRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AddInstanceTargetPoolRequest request = new AddInstanceTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest(),
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
            mockGrpcClient.Setup(x => x.AddInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddInstanceRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AddInstanceTargetPoolRequest request = new AddInstanceTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest(),
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
            mockGrpcClient.Setup(x => x.AddInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddInstance()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AddInstanceTargetPoolRequest request = new AddInstanceTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest(),
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
            mockGrpcClient.Setup(x => x.AddInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddInstance(request.Project, request.Region, request.TargetPool, request.TargetPoolsAddInstanceRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddInstanceAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AddInstanceTargetPoolRequest request = new AddInstanceTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest(),
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
            mockGrpcClient.Setup(x => x.AddInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddInstanceAsync(request.Project, request.Region, request.TargetPool, request.TargetPoolsAddInstanceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddInstanceAsync(request.Project, request.Region, request.TargetPool, request.TargetPoolsAddInstanceRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AggregatedListTargetPoolsRequest request = new AggregatedListTargetPoolsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            TargetPoolAggregatedList expectedResponse = new TargetPoolAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetPoolsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AggregatedListTargetPoolsRequest request = new AggregatedListTargetPoolsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            TargetPoolAggregatedList expectedResponse = new TargetPoolAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetPoolsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPoolAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPoolAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AggregatedListTargetPoolsRequest request = new AggregatedListTargetPoolsRequest
            {
                Project = "projectaa6ff846",
            };
            TargetPoolAggregatedList expectedResponse = new TargetPoolAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetPoolsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            AggregatedListTargetPoolsRequest request = new AggregatedListTargetPoolsRequest
            {
                Project = "projectaa6ff846",
            };
            TargetPoolAggregatedList expectedResponse = new TargetPoolAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetPoolsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPoolAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPoolAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            DeleteTargetPoolRequest request = new DeleteTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
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
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            DeleteTargetPoolRequest request = new DeleteTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
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
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            DeleteTargetPoolRequest request = new DeleteTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
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
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.TargetPool);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            DeleteTargetPoolRequest request = new DeleteTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
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
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.TargetPool, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.TargetPool, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetPool expectedResponse = new TargetPool
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Instances =
                {
                    "instances5432a96f",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                BackupPool = "backup_pool2446601c",
                Region = "regionedb20d96",
                FailoverRatio = -7.1869584E+17F,
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                SessionAffinity = TargetPool.Types.SessionAffinity.GeneratedCookie,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPool response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetPool expectedResponse = new TargetPool
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Instances =
                {
                    "instances5432a96f",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                BackupPool = "backup_pool2446601c",
                Region = "regionedb20d96",
                FailoverRatio = -7.1869584E+17F,
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                SessionAffinity = TargetPool.Types.SessionAffinity.GeneratedCookie,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPool responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPool responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetPool expectedResponse = new TargetPool
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Instances =
                {
                    "instances5432a96f",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                BackupPool = "backup_pool2446601c",
                Region = "regionedb20d96",
                FailoverRatio = -7.1869584E+17F,
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                SessionAffinity = TargetPool.Types.SessionAffinity.GeneratedCookie,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPool response = client.Get(request.Project, request.Region, request.TargetPool);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetPool expectedResponse = new TargetPool
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Instances =
                {
                    "instances5432a96f",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                BackupPool = "backup_pool2446601c",
                Region = "regionedb20d96",
                FailoverRatio = -7.1869584E+17F,
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                SessionAffinity = TargetPool.Types.SessionAffinity.GeneratedCookie,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPool responseCallSettings = await client.GetAsync(request.Project, request.Region, request.TargetPool, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPool responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.TargetPool, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHealthRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceReferenceResource = new InstanceReference(),
            };
            TargetPoolInstanceHealth expectedResponse = new TargetPoolInstanceHealth
            {
                Kind = "kindf7aa39d9",
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolInstanceHealth response = client.GetHealth(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHealthRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceReferenceResource = new InstanceReference(),
            };
            TargetPoolInstanceHealth expectedResponse = new TargetPoolInstanceHealth
            {
                Kind = "kindf7aa39d9",
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPoolInstanceHealth>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolInstanceHealth responseCallSettings = await client.GetHealthAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPoolInstanceHealth responseCancellationToken = await client.GetHealthAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHealth()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceReferenceResource = new InstanceReference(),
            };
            TargetPoolInstanceHealth expectedResponse = new TargetPoolInstanceHealth
            {
                Kind = "kindf7aa39d9",
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolInstanceHealth response = client.GetHealth(request.Project, request.Region, request.TargetPool, request.InstanceReferenceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHealthAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceReferenceResource = new InstanceReference(),
            };
            TargetPoolInstanceHealth expectedResponse = new TargetPoolInstanceHealth
            {
                Kind = "kindf7aa39d9",
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPoolInstanceHealth>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolInstanceHealth responseCallSettings = await client.GetHealthAsync(request.Project, request.Region, request.TargetPool, request.InstanceReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPoolInstanceHealth responseCancellationToken = await client.GetHealthAsync(request.Project, request.Region, request.TargetPool, request.InstanceReferenceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            InsertTargetPoolRequest request = new InsertTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPoolResource = new TargetPool(),
                Region = "regionedb20d96",
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
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            InsertTargetPoolRequest request = new InsertTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPoolResource = new TargetPool(),
                Region = "regionedb20d96",
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
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            InsertTargetPoolRequest request = new InsertTargetPoolRequest
            {
                TargetPoolResource = new TargetPool(),
                Region = "regionedb20d96",
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
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.TargetPoolResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            InsertTargetPoolRequest request = new InsertTargetPoolRequest
            {
                TargetPoolResource = new TargetPool(),
                Region = "regionedb20d96",
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
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.TargetPoolResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.TargetPoolResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            ListTargetPoolsRequest request = new ListTargetPoolsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetPoolList expectedResponse = new TargetPoolList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new TargetPool(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            ListTargetPoolsRequest request = new ListTargetPoolsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetPoolList expectedResponse = new TargetPoolList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new TargetPool(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPoolList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPoolList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            ListTargetPoolsRequest request = new ListTargetPoolsRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetPoolList expectedResponse = new TargetPoolList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new TargetPool(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            ListTargetPoolsRequest request = new ListTargetPoolsRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetPoolList expectedResponse = new TargetPoolList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new TargetPool(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPoolList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPoolList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveHealthCheckRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            RemoveHealthCheckTargetPoolRequest request = new RemoveHealthCheckTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest(),
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
            mockGrpcClient.Setup(x => x.RemoveHealthCheck(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveHealthCheck(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveHealthCheckRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            RemoveHealthCheckTargetPoolRequest request = new RemoveHealthCheckTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest(),
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
            mockGrpcClient.Setup(x => x.RemoveHealthCheckAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveHealthCheckAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveHealthCheckAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveHealthCheck()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            RemoveHealthCheckTargetPoolRequest request = new RemoveHealthCheckTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest(),
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
            mockGrpcClient.Setup(x => x.RemoveHealthCheck(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveHealthCheck(request.Project, request.Region, request.TargetPool, request.TargetPoolsRemoveHealthCheckRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveHealthCheckAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            RemoveHealthCheckTargetPoolRequest request = new RemoveHealthCheckTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest(),
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
            mockGrpcClient.Setup(x => x.RemoveHealthCheckAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveHealthCheckAsync(request.Project, request.Region, request.TargetPool, request.TargetPoolsRemoveHealthCheckRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveHealthCheckAsync(request.Project, request.Region, request.TargetPool, request.TargetPoolsRemoveHealthCheckRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveInstanceRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            RemoveInstanceTargetPoolRequest request = new RemoveInstanceTargetPoolRequest
            {
                TargetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest(),
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
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
            mockGrpcClient.Setup(x => x.RemoveInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveInstanceRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            RemoveInstanceTargetPoolRequest request = new RemoveInstanceTargetPoolRequest
            {
                TargetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest(),
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
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
            mockGrpcClient.Setup(x => x.RemoveInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveInstance()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            RemoveInstanceTargetPoolRequest request = new RemoveInstanceTargetPoolRequest
            {
                TargetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest(),
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
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
            mockGrpcClient.Setup(x => x.RemoveInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveInstance(request.Project, request.Region, request.TargetPool, request.TargetPoolsRemoveInstanceRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveInstanceAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            RemoveInstanceTargetPoolRequest request = new RemoveInstanceTargetPoolRequest
            {
                TargetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest(),
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
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
            mockGrpcClient.Setup(x => x.RemoveInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveInstanceAsync(request.Project, request.Region, request.TargetPool, request.TargetPoolsRemoveInstanceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveInstanceAsync(request.Project, request.Region, request.TargetPool, request.TargetPoolsRemoveInstanceRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetBackupRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            SetBackupTargetPoolRequest request = new SetBackupTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                FailoverRatio = -7.1869584E+17F,
                Project = "projectaa6ff846",
                TargetReferenceResource = new TargetReference(),
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
            mockGrpcClient.Setup(x => x.SetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetBackup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetBackupRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            SetBackupTargetPoolRequest request = new SetBackupTargetPoolRequest
            {
                RequestId = "request_id362c8df6",
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                FailoverRatio = -7.1869584E+17F,
                Project = "projectaa6ff846",
                TargetReferenceResource = new TargetReference(),
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
            mockGrpcClient.Setup(x => x.SetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetBackupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetBackup()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            SetBackupTargetPoolRequest request = new SetBackupTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetReferenceResource = new TargetReference(),
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
            mockGrpcClient.Setup(x => x.SetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetBackup(request.Project, request.Region, request.TargetPool, request.TargetReferenceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetBackupAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            SetBackupTargetPoolRequest request = new SetBackupTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetReferenceResource = new TargetReference(),
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
            mockGrpcClient.Setup(x => x.SetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetBackupAsync(request.Project, request.Region, request.TargetPool, request.TargetReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetBackupAsync(request.Project, request.Region, request.TargetPool, request.TargetReferenceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
