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
    public sealed class GeneratedGlobalOrganizationOperationsClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            DeleteGlobalOrganizationOperationRequest request = new DeleteGlobalOrganizationOperationRequest
            {
                Operation = "operation615a23f7",
                ParentId = "parent_id8279e36b",
            };
            DeleteGlobalOrganizationOperationResponse expectedResponse = new DeleteGlobalOrganizationOperationResponse { };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            DeleteGlobalOrganizationOperationResponse response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            DeleteGlobalOrganizationOperationRequest request = new DeleteGlobalOrganizationOperationRequest
            {
                Operation = "operation615a23f7",
                ParentId = "parent_id8279e36b",
            };
            DeleteGlobalOrganizationOperationResponse expectedResponse = new DeleteGlobalOrganizationOperationResponse { };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeleteGlobalOrganizationOperationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            DeleteGlobalOrganizationOperationResponse responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeleteGlobalOrganizationOperationResponse responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            DeleteGlobalOrganizationOperationRequest request = new DeleteGlobalOrganizationOperationRequest
            {
                Operation = "operation615a23f7",
            };
            DeleteGlobalOrganizationOperationResponse expectedResponse = new DeleteGlobalOrganizationOperationResponse { };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            DeleteGlobalOrganizationOperationResponse response = client.Delete(request.Operation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            DeleteGlobalOrganizationOperationRequest request = new DeleteGlobalOrganizationOperationRequest
            {
                Operation = "operation615a23f7",
            };
            DeleteGlobalOrganizationOperationResponse expectedResponse = new DeleteGlobalOrganizationOperationResponse { };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeleteGlobalOrganizationOperationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            DeleteGlobalOrganizationOperationResponse responseCallSettings = await client.DeleteAsync(request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeleteGlobalOrganizationOperationResponse responseCancellationToken = await client.DeleteAsync(request.Operation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            GetGlobalOrganizationOperationRequest request = new GetGlobalOrganizationOperationRequest
            {
                Operation = "operation615a23f7",
                ParentId = "parent_id8279e36b",
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
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            GetGlobalOrganizationOperationRequest request = new GetGlobalOrganizationOperationRequest
            {
                Operation = "operation615a23f7",
                ParentId = "parent_id8279e36b",
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
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            GetGlobalOrganizationOperationRequest request = new GetGlobalOrganizationOperationRequest
            {
                Operation = "operation615a23f7",
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
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Get(request.Operation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            GetGlobalOrganizationOperationRequest request = new GetGlobalOrganizationOperationRequest
            {
                Operation = "operation615a23f7",
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
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.GetAsync(request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.GetAsync(request.Operation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            ListGlobalOrganizationOperationsRequest request = new ListGlobalOrganizationOperationsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Filter = "filtere47ac9b2",
                ParentId = "parent_id8279e36b",
                ReturnPartialSuccess = false,
            };
            OperationList expectedResponse = new OperationList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Operation(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            OperationList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            ListGlobalOrganizationOperationsRequest request = new ListGlobalOrganizationOperationsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Filter = "filtere47ac9b2",
                ParentId = "parent_id8279e36b",
                ReturnPartialSuccess = false,
            };
            OperationList expectedResponse = new OperationList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Operation(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OperationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            OperationList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OperationList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            ListGlobalOrganizationOperationsRequest request = new ListGlobalOrganizationOperationsRequest { };
            OperationList expectedResponse = new OperationList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Operation(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            OperationList response = client.List();
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient> mockGrpcClient = new moq::Mock<GlobalOrganizationOperations.GlobalOrganizationOperationsClient>(moq::MockBehavior.Strict);
            ListGlobalOrganizationOperationsRequest request = new ListGlobalOrganizationOperationsRequest { };
            OperationList expectedResponse = new OperationList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Operation(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OperationList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalOrganizationOperationsClient client = new GlobalOrganizationOperationsClientImpl(mockGrpcClient.Object, null);
            OperationList responseCallSettings = await client.ListAsync(gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OperationList responseCancellationToken = await client.ListAsync(st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
