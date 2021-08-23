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
    public sealed class GeneratedRoutersClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            DeleteRouterRequest request = new DeleteRouterRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            DeleteRouterRequest request = new DeleteRouterRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            DeleteRouterRequest request = new DeleteRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.Router);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            DeleteRouterRequest request = new DeleteRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.Router, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.Router, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            GetRouterRequest request = new GetRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Project = "projectaa6ff846",
            };
            Router expectedResponse = new Router
            {
                Id = 11672635353343658936UL,
                Bgp = new RouterBgp(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Nats = { new RouterNat(), },
                Interfaces =
                {
                    new RouterInterface(),
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                EncryptedInterconnectRouter = false,
                Description = "description2cf9da67",
                BgpPeers =
                {
                    new RouterBgpPeer(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Router response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            GetRouterRequest request = new GetRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Project = "projectaa6ff846",
            };
            Router expectedResponse = new Router
            {
                Id = 11672635353343658936UL,
                Bgp = new RouterBgp(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Nats = { new RouterNat(), },
                Interfaces =
                {
                    new RouterInterface(),
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                EncryptedInterconnectRouter = false,
                Description = "description2cf9da67",
                BgpPeers =
                {
                    new RouterBgpPeer(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Router>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Router responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Router responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            GetRouterRequest request = new GetRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Project = "projectaa6ff846",
            };
            Router expectedResponse = new Router
            {
                Id = 11672635353343658936UL,
                Bgp = new RouterBgp(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Nats = { new RouterNat(), },
                Interfaces =
                {
                    new RouterInterface(),
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                EncryptedInterconnectRouter = false,
                Description = "description2cf9da67",
                BgpPeers =
                {
                    new RouterBgpPeer(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Router response = client.Get(request.Project, request.Region, request.Router);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            GetRouterRequest request = new GetRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Project = "projectaa6ff846",
            };
            Router expectedResponse = new Router
            {
                Id = 11672635353343658936UL,
                Bgp = new RouterBgp(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Nats = { new RouterNat(), },
                Interfaces =
                {
                    new RouterInterface(),
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                EncryptedInterconnectRouter = false,
                Description = "description2cf9da67",
                BgpPeers =
                {
                    new RouterBgpPeer(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Router>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Router responseCallSettings = await client.GetAsync(request.Project, request.Region, request.Router, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Router responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.Router, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRouterStatusRequestObject()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            GetRouterStatusRouterRequest request = new GetRouterStatusRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Project = "projectaa6ff846",
            };
            RouterStatusResponse expectedResponse = new RouterStatusResponse
            {
                Kind = "kindf7aa39d9",
                Result = new RouterStatus(),
            };
            mockGrpcClient.Setup(x => x.GetRouterStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            RouterStatusResponse response = client.GetRouterStatus(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRouterStatusRequestObjectAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            GetRouterStatusRouterRequest request = new GetRouterStatusRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Project = "projectaa6ff846",
            };
            RouterStatusResponse expectedResponse = new RouterStatusResponse
            {
                Kind = "kindf7aa39d9",
                Result = new RouterStatus(),
            };
            mockGrpcClient.Setup(x => x.GetRouterStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RouterStatusResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            RouterStatusResponse responseCallSettings = await client.GetRouterStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RouterStatusResponse responseCancellationToken = await client.GetRouterStatusAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRouterStatus()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            GetRouterStatusRouterRequest request = new GetRouterStatusRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Project = "projectaa6ff846",
            };
            RouterStatusResponse expectedResponse = new RouterStatusResponse
            {
                Kind = "kindf7aa39d9",
                Result = new RouterStatus(),
            };
            mockGrpcClient.Setup(x => x.GetRouterStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            RouterStatusResponse response = client.GetRouterStatus(request.Project, request.Region, request.Router);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRouterStatusAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            GetRouterStatusRouterRequest request = new GetRouterStatusRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Project = "projectaa6ff846",
            };
            RouterStatusResponse expectedResponse = new RouterStatusResponse
            {
                Kind = "kindf7aa39d9",
                Result = new RouterStatus(),
            };
            mockGrpcClient.Setup(x => x.GetRouterStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RouterStatusResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            RouterStatusResponse responseCallSettings = await client.GetRouterStatusAsync(request.Project, request.Region, request.Router, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RouterStatusResponse responseCancellationToken = await client.GetRouterStatusAsync(request.Project, request.Region, request.Router, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            InsertRouterRequest request = new InsertRouterRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                RouterResource = new Router(),
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            InsertRouterRequest request = new InsertRouterRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                RouterResource = new Router(),
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            InsertRouterRequest request = new InsertRouterRequest
            {
                Region = "regionedb20d96",
                RouterResource = new Router(),
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.RouterResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            InsertRouterRequest request = new InsertRouterRequest
            {
                Region = "regionedb20d96",
                RouterResource = new Router(),
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.RouterResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.RouterResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            PatchRouterRequest request = new PatchRouterRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
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
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            PatchRouterRequest request = new PatchRouterRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
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
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            PatchRouterRequest request = new PatchRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
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
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.Region, request.Router, request.RouterResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            PatchRouterRequest request = new PatchRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
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
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.Region, request.Router, request.RouterResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.Region, request.Router, request.RouterResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PreviewRequestObject()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            PreviewRouterRequest request = new PreviewRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
                Project = "projectaa6ff846",
            };
            RoutersPreviewResponse expectedResponse = new RoutersPreviewResponse
            {
                Resource = new Router(),
            };
            mockGrpcClient.Setup(x => x.Preview(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            RoutersPreviewResponse response = client.Preview(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PreviewRequestObjectAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            PreviewRouterRequest request = new PreviewRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
                Project = "projectaa6ff846",
            };
            RoutersPreviewResponse expectedResponse = new RoutersPreviewResponse
            {
                Resource = new Router(),
            };
            mockGrpcClient.Setup(x => x.PreviewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RoutersPreviewResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            RoutersPreviewResponse responseCallSettings = await client.PreviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RoutersPreviewResponse responseCancellationToken = await client.PreviewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Preview()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            PreviewRouterRequest request = new PreviewRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
                Project = "projectaa6ff846",
            };
            RoutersPreviewResponse expectedResponse = new RoutersPreviewResponse
            {
                Resource = new Router(),
            };
            mockGrpcClient.Setup(x => x.Preview(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            RoutersPreviewResponse response = client.Preview(request.Project, request.Region, request.Router, request.RouterResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PreviewAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            PreviewRouterRequest request = new PreviewRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
                Project = "projectaa6ff846",
            };
            RoutersPreviewResponse expectedResponse = new RoutersPreviewResponse
            {
                Resource = new Router(),
            };
            mockGrpcClient.Setup(x => x.PreviewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RoutersPreviewResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            RoutersPreviewResponse responseCallSettings = await client.PreviewAsync(request.Project, request.Region, request.Router, request.RouterResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RoutersPreviewResponse responseCancellationToken = await client.PreviewAsync(request.Project, request.Region, request.Router, request.RouterResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRequestObject()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            UpdateRouterRequest request = new UpdateRouterRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
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
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRequestObjectAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            UpdateRouterRequest request = new UpdateRouterRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
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
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Update()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            UpdateRouterRequest request = new UpdateRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
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
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request.Project, request.Region, request.Router, request.RouterResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            UpdateRouterRequest request = new UpdateRouterRequest
            {
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                RouterResource = new Router(),
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
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request.Project, request.Region, request.Router, request.RouterResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request.Project, request.Region, request.Router, request.RouterResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
