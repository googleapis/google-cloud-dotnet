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
    public sealed class GeneratedBackendServicesClientTest
    {
        [xunit::FactAttribute]
        public void AddSignedUrlKeyRequestObject()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            AddSignedUrlKeyBackendServiceRequest request = new AddSignedUrlKeyBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                SignedUrlKeyResource = new SignedUrlKey(),
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
            mockGrpcClient.Setup(x => x.AddSignedUrlKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddSignedUrlKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddSignedUrlKeyRequestObjectAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            AddSignedUrlKeyBackendServiceRequest request = new AddSignedUrlKeyBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                SignedUrlKeyResource = new SignedUrlKey(),
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
            mockGrpcClient.Setup(x => x.AddSignedUrlKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddSignedUrlKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddSignedUrlKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddSignedUrlKey()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            AddSignedUrlKeyBackendServiceRequest request = new AddSignedUrlKeyBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                SignedUrlKeyResource = new SignedUrlKey(),
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
            mockGrpcClient.Setup(x => x.AddSignedUrlKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddSignedUrlKey(request.Project, request.BackendService, request.SignedUrlKeyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddSignedUrlKeyAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            AddSignedUrlKeyBackendServiceRequest request = new AddSignedUrlKeyBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                SignedUrlKeyResource = new SignedUrlKey(),
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
            mockGrpcClient.Setup(x => x.AddSignedUrlKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddSignedUrlKeyAsync(request.Project, request.BackendService, request.SignedUrlKeyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddSignedUrlKeyAsync(request.Project, request.BackendService, request.SignedUrlKeyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            AggregatedListBackendServicesRequest request = new AggregatedListBackendServicesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            BackendServiceAggregatedList expectedResponse = new BackendServiceAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new BackendServicesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            AggregatedListBackendServicesRequest request = new AggregatedListBackendServicesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            BackendServiceAggregatedList expectedResponse = new BackendServiceAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new BackendServicesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendServiceAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendServiceAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            AggregatedListBackendServicesRequest request = new AggregatedListBackendServicesRequest
            {
                Project = "projectaa6ff846",
            };
            BackendServiceAggregatedList expectedResponse = new BackendServiceAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new BackendServicesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            AggregatedListBackendServicesRequest request = new AggregatedListBackendServicesRequest
            {
                Project = "projectaa6ff846",
            };
            BackendServiceAggregatedList expectedResponse = new BackendServiceAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new BackendServicesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendServiceAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendServiceAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            DeleteBackendServiceRequest request = new DeleteBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            DeleteBackendServiceRequest request = new DeleteBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            DeleteBackendServiceRequest request = new DeleteBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.BackendService);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            DeleteBackendServiceRequest request = new DeleteBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.BackendService, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.BackendService, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSignedUrlKeyRequestObject()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            DeleteSignedUrlKeyBackendServiceRequest request = new DeleteSignedUrlKeyBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                KeyName = "key_namedf8f0795",
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
            mockGrpcClient.Setup(x => x.DeleteSignedUrlKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteSignedUrlKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSignedUrlKeyRequestObjectAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            DeleteSignedUrlKeyBackendServiceRequest request = new DeleteSignedUrlKeyBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                KeyName = "key_namedf8f0795",
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
            mockGrpcClient.Setup(x => x.DeleteSignedUrlKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteSignedUrlKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteSignedUrlKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSignedUrlKey()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            DeleteSignedUrlKeyBackendServiceRequest request = new DeleteSignedUrlKeyBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                KeyName = "key_namedf8f0795",
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
            mockGrpcClient.Setup(x => x.DeleteSignedUrlKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteSignedUrlKey(request.Project, request.BackendService, request.KeyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSignedUrlKeyAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            DeleteSignedUrlKeyBackendServiceRequest request = new DeleteSignedUrlKeyBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                KeyName = "key_namedf8f0795",
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
            mockGrpcClient.Setup(x => x.DeleteSignedUrlKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteSignedUrlKeyAsync(request.Project, request.BackendService, request.KeyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteSignedUrlKeyAsync(request.Project, request.BackendService, request.KeyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            GetBackendServiceRequest request = new GetBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = 11672635353343658936UL,
                Iap = new BackendServiceIAP(),
                ConsistentHash = new ConsistentHashLoadBalancerSettings(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Port = -78310000,
                CustomRequestHeaders =
                {
                    "custom_request_headers3532c035",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = BackendService.Types.Protocol.Udp,
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = BackendService.Types.LocalityLbPolicy.UndefinedLocalityLbPolicy,
                Region = "regionedb20d96",
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = BackendService.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                AffinityCookieTtlSec = -328985636,
                CustomResponseHeaders =
                {
                    "custom_response_headersda5d431e",
                },
                CircuitBreakers = new CircuitBreakers(),
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = BackendService.Types.SessionAffinity.GeneratedCookie,
                SecuritySettings = new SecuritySettings(),
                Backends = { new Backend(), },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendService response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            GetBackendServiceRequest request = new GetBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = 11672635353343658936UL,
                Iap = new BackendServiceIAP(),
                ConsistentHash = new ConsistentHashLoadBalancerSettings(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Port = -78310000,
                CustomRequestHeaders =
                {
                    "custom_request_headers3532c035",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = BackendService.Types.Protocol.Udp,
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = BackendService.Types.LocalityLbPolicy.UndefinedLocalityLbPolicy,
                Region = "regionedb20d96",
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = BackendService.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                AffinityCookieTtlSec = -328985636,
                CustomResponseHeaders =
                {
                    "custom_response_headersda5d431e",
                },
                CircuitBreakers = new CircuitBreakers(),
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = BackendService.Types.SessionAffinity.GeneratedCookie,
                SecuritySettings = new SecuritySettings(),
                Backends = { new Backend(), },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendService responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendService responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            GetBackendServiceRequest request = new GetBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = 11672635353343658936UL,
                Iap = new BackendServiceIAP(),
                ConsistentHash = new ConsistentHashLoadBalancerSettings(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Port = -78310000,
                CustomRequestHeaders =
                {
                    "custom_request_headers3532c035",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = BackendService.Types.Protocol.Udp,
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = BackendService.Types.LocalityLbPolicy.UndefinedLocalityLbPolicy,
                Region = "regionedb20d96",
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = BackendService.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                AffinityCookieTtlSec = -328985636,
                CustomResponseHeaders =
                {
                    "custom_response_headersda5d431e",
                },
                CircuitBreakers = new CircuitBreakers(),
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = BackendService.Types.SessionAffinity.GeneratedCookie,
                SecuritySettings = new SecuritySettings(),
                Backends = { new Backend(), },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendService response = client.Get(request.Project, request.BackendService);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            GetBackendServiceRequest request = new GetBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = 11672635353343658936UL,
                Iap = new BackendServiceIAP(),
                ConsistentHash = new ConsistentHashLoadBalancerSettings(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Port = -78310000,
                CustomRequestHeaders =
                {
                    "custom_request_headers3532c035",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = BackendService.Types.Protocol.Udp,
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = BackendService.Types.LocalityLbPolicy.UndefinedLocalityLbPolicy,
                Region = "regionedb20d96",
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = BackendService.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
                AffinityCookieTtlSec = -328985636,
                CustomResponseHeaders =
                {
                    "custom_response_headersda5d431e",
                },
                CircuitBreakers = new CircuitBreakers(),
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = BackendService.Types.SessionAffinity.GeneratedCookie,
                SecuritySettings = new SecuritySettings(),
                Backends = { new Backend(), },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendService responseCallSettings = await client.GetAsync(request.Project, request.BackendService, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendService responseCancellationToken = await client.GetAsync(request.Project, request.BackendService, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHealthRequestObject()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            GetHealthBackendServiceRequest request = new GetHealthBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendServiceGroupHealth expectedResponse = new BackendServiceGroupHealth
            {
                Kind = "kindf7aa39d9",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceGroupHealth response = client.GetHealth(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHealthRequestObjectAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            GetHealthBackendServiceRequest request = new GetHealthBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendServiceGroupHealth expectedResponse = new BackendServiceGroupHealth
            {
                Kind = "kindf7aa39d9",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendServiceGroupHealth>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceGroupHealth responseCallSettings = await client.GetHealthAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendServiceGroupHealth responseCancellationToken = await client.GetHealthAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHealth()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            GetHealthBackendServiceRequest request = new GetHealthBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendServiceGroupHealth expectedResponse = new BackendServiceGroupHealth
            {
                Kind = "kindf7aa39d9",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceGroupHealth response = client.GetHealth(request.Project, request.BackendService, request.ResourceGroupReferenceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHealthAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            GetHealthBackendServiceRequest request = new GetHealthBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendServiceGroupHealth expectedResponse = new BackendServiceGroupHealth
            {
                Kind = "kindf7aa39d9",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendServiceGroupHealth>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceGroupHealth responseCallSettings = await client.GetHealthAsync(request.Project, request.BackendService, request.ResourceGroupReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendServiceGroupHealth responseCancellationToken = await client.GetHealthAsync(request.Project, request.BackendService, request.ResourceGroupReferenceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            InsertBackendServiceRequest request = new InsertBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendServiceResource = new BackendService(),
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            InsertBackendServiceRequest request = new InsertBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendServiceResource = new BackendService(),
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            InsertBackendServiceRequest request = new InsertBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendServiceResource = new BackendService(),
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.BackendServiceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            InsertBackendServiceRequest request = new InsertBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendServiceResource = new BackendService(),
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.BackendServiceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.BackendServiceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            ListBackendServicesRequest request = new ListBackendServicesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            BackendServiceList expectedResponse = new BackendServiceList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new BackendService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            ListBackendServicesRequest request = new ListBackendServicesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            BackendServiceList expectedResponse = new BackendServiceList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new BackendService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendServiceList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendServiceList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            ListBackendServicesRequest request = new ListBackendServicesRequest
            {
                Project = "projectaa6ff846",
            };
            BackendServiceList expectedResponse = new BackendServiceList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new BackendService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            ListBackendServicesRequest request = new ListBackendServicesRequest
            {
                Project = "projectaa6ff846",
            };
            BackendServiceList expectedResponse = new BackendServiceList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new BackendService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendServiceList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendServiceList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            PatchBackendServiceRequest request = new PatchBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            PatchBackendServiceRequest request = new PatchBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            PatchBackendServiceRequest request = new PatchBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.BackendService, request.BackendServiceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            PatchBackendServiceRequest request = new PatchBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
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
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.BackendService, request.BackendServiceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.BackendService, request.BackendServiceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetSecurityPolicyRequestObject()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            SetSecurityPolicyBackendServiceRequest request = new SetSecurityPolicyBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
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
            mockGrpcClient.Setup(x => x.SetSecurityPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetSecurityPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetSecurityPolicyRequestObjectAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            SetSecurityPolicyBackendServiceRequest request = new SetSecurityPolicyBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
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
            mockGrpcClient.Setup(x => x.SetSecurityPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetSecurityPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetSecurityPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetSecurityPolicy()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            SetSecurityPolicyBackendServiceRequest request = new SetSecurityPolicyBackendServiceRequest
            {
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
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
            mockGrpcClient.Setup(x => x.SetSecurityPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetSecurityPolicy(request.Project, request.BackendService, request.SecurityPolicyReferenceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetSecurityPolicyAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            SetSecurityPolicyBackendServiceRequest request = new SetSecurityPolicyBackendServiceRequest
            {
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
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
            mockGrpcClient.Setup(x => x.SetSecurityPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetSecurityPolicyAsync(request.Project, request.BackendService, request.SecurityPolicyReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetSecurityPolicyAsync(request.Project, request.BackendService, request.SecurityPolicyReferenceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRequestObject()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            UpdateBackendServiceRequest request = new UpdateBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
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
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRequestObjectAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            UpdateBackendServiceRequest request = new UpdateBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
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
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Update()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            UpdateBackendServiceRequest request = new UpdateBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
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
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request.Project, request.BackendService, request.BackendServiceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAsync()
        {
            moq::Mock<BackendServices.BackendServicesClient> mockGrpcClient = new moq::Mock<BackendServices.BackendServicesClient>(moq::MockBehavior.Strict);
            UpdateBackendServiceRequest request = new UpdateBackendServiceRequest
            {
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
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
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BackendServicesClient client = new BackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request.Project, request.BackendService, request.BackendServiceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request.Project, request.BackendService, request.BackendServiceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
