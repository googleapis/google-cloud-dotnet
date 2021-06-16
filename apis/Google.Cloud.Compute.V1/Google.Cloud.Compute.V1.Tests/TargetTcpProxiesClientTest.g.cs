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
    public sealed class GeneratedTargetTcpProxiesClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetTcpProxyRequest request = new DeleteTargetTcpProxyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetTcpProxyRequest request = new DeleteTargetTcpProxyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetTcpProxyRequest request = new DeleteTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.TargetTcpProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetTcpProxyRequest request = new DeleteTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.TargetTcpProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.TargetTcpProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            GetTargetTcpProxyRequest request = new GetTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
            };
            TargetTcpProxy expectedResponse = new TargetTcpProxy
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = TargetTcpProxy.Types.ProxyHeader.UndefinedProxyHeader,
                ProxyBind = false,
                Service = "serviced3f0abaa",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetTcpProxy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            GetTargetTcpProxyRequest request = new GetTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
            };
            TargetTcpProxy expectedResponse = new TargetTcpProxy
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = TargetTcpProxy.Types.ProxyHeader.UndefinedProxyHeader,
                ProxyBind = false,
                Service = "serviced3f0abaa",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetTcpProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetTcpProxy responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetTcpProxy responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            GetTargetTcpProxyRequest request = new GetTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
            };
            TargetTcpProxy expectedResponse = new TargetTcpProxy
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = TargetTcpProxy.Types.ProxyHeader.UndefinedProxyHeader,
                ProxyBind = false,
                Service = "serviced3f0abaa",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetTcpProxy response = client.Get(request.Project, request.TargetTcpProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            GetTargetTcpProxyRequest request = new GetTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
            };
            TargetTcpProxy expectedResponse = new TargetTcpProxy
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = TargetTcpProxy.Types.ProxyHeader.UndefinedProxyHeader,
                ProxyBind = false,
                Service = "serviced3f0abaa",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetTcpProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetTcpProxy responseCallSettings = await client.GetAsync(request.Project, request.TargetTcpProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetTcpProxy responseCancellationToken = await client.GetAsync(request.Project, request.TargetTcpProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetTcpProxyRequest request = new InsertTargetTcpProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetTcpProxyResource = new TargetTcpProxy(),
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
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetTcpProxyRequest request = new InsertTargetTcpProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetTcpProxyResource = new TargetTcpProxy(),
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
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetTcpProxyRequest request = new InsertTargetTcpProxyRequest
            {
                TargetTcpProxyResource = new TargetTcpProxy(),
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
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.TargetTcpProxyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetTcpProxyRequest request = new InsertTargetTcpProxyRequest
            {
                TargetTcpProxyResource = new TargetTcpProxy(),
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
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.TargetTcpProxyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.TargetTcpProxyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            ListTargetTcpProxiesRequest request = new ListTargetTcpProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetTcpProxyList expectedResponse = new TargetTcpProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetTcpProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetTcpProxyList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            ListTargetTcpProxiesRequest request = new ListTargetTcpProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetTcpProxyList expectedResponse = new TargetTcpProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetTcpProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetTcpProxyList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetTcpProxyList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetTcpProxyList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            ListTargetTcpProxiesRequest request = new ListTargetTcpProxiesRequest
            {
                Project = "projectaa6ff846",
            };
            TargetTcpProxyList expectedResponse = new TargetTcpProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetTcpProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetTcpProxyList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            ListTargetTcpProxiesRequest request = new ListTargetTcpProxiesRequest
            {
                Project = "projectaa6ff846",
            };
            TargetTcpProxyList expectedResponse = new TargetTcpProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetTcpProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetTcpProxyList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetTcpProxyList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetTcpProxyList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetBackendServiceRequestObject()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            SetBackendServiceTargetTcpProxyRequest request = new SetBackendServiceTargetTcpProxyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetTcpProxiesSetBackendServiceRequestResource = new TargetTcpProxiesSetBackendServiceRequest(),
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            mockGrpcClient.Setup(x => x.SetBackendService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetBackendService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetBackendServiceRequestObjectAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            SetBackendServiceTargetTcpProxyRequest request = new SetBackendServiceTargetTcpProxyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetTcpProxiesSetBackendServiceRequestResource = new TargetTcpProxiesSetBackendServiceRequest(),
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            mockGrpcClient.Setup(x => x.SetBackendServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetBackendServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetBackendServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetBackendService()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            SetBackendServiceTargetTcpProxyRequest request = new SetBackendServiceTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxiesSetBackendServiceRequestResource = new TargetTcpProxiesSetBackendServiceRequest(),
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            mockGrpcClient.Setup(x => x.SetBackendService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetBackendService(request.Project, request.TargetTcpProxy, request.TargetTcpProxiesSetBackendServiceRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetBackendServiceAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            SetBackendServiceTargetTcpProxyRequest request = new SetBackendServiceTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxiesSetBackendServiceRequestResource = new TargetTcpProxiesSetBackendServiceRequest(),
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            mockGrpcClient.Setup(x => x.SetBackendServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetBackendServiceAsync(request.Project, request.TargetTcpProxy, request.TargetTcpProxiesSetBackendServiceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetBackendServiceAsync(request.Project, request.TargetTcpProxy, request.TargetTcpProxiesSetBackendServiceRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetProxyHeaderRequestObject()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            SetProxyHeaderTargetTcpProxyRequest request = new SetProxyHeaderTargetTcpProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetTcpProxiesSetProxyHeaderRequestResource = new TargetTcpProxiesSetProxyHeaderRequest(),
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            mockGrpcClient.Setup(x => x.SetProxyHeader(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetProxyHeader(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetProxyHeaderRequestObjectAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            SetProxyHeaderTargetTcpProxyRequest request = new SetProxyHeaderTargetTcpProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetTcpProxiesSetProxyHeaderRequestResource = new TargetTcpProxiesSetProxyHeaderRequest(),
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            mockGrpcClient.Setup(x => x.SetProxyHeaderAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetProxyHeaderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetProxyHeaderAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetProxyHeader()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            SetProxyHeaderTargetTcpProxyRequest request = new SetProxyHeaderTargetTcpProxyRequest
            {
                TargetTcpProxiesSetProxyHeaderRequestResource = new TargetTcpProxiesSetProxyHeaderRequest(),
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            mockGrpcClient.Setup(x => x.SetProxyHeader(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetProxyHeader(request.Project, request.TargetTcpProxy, request.TargetTcpProxiesSetProxyHeaderRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetProxyHeaderAsync()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            SetProxyHeaderTargetTcpProxyRequest request = new SetProxyHeaderTargetTcpProxyRequest
            {
                TargetTcpProxiesSetProxyHeaderRequestResource = new TargetTcpProxiesSetProxyHeaderRequest(),
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
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
            mockGrpcClient.Setup(x => x.SetProxyHeaderAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetTcpProxiesClient client = new TargetTcpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetProxyHeaderAsync(request.Project, request.TargetTcpProxy, request.TargetTcpProxiesSetProxyHeaderRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetProxyHeaderAsync(request.Project, request.TargetTcpProxy, request.TargetTcpProxiesSetProxyHeaderRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
