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
    public sealed class GeneratedTargetGrpcProxiesClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetGrpcProxyRequest request = new DeleteTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
                RequestId = "request_id362c8df6",
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetGrpcProxyRequest request = new DeleteTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
                RequestId = "request_id362c8df6",
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetGrpcProxyRequest request = new DeleteTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.TargetGrpcProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetGrpcProxyRequest request = new DeleteTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.TargetGrpcProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.TargetGrpcProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            GetTargetGrpcProxyRequest request = new GetTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
                Project = "projectaa6ff846",
            };
            TargetGrpcProxy expectedResponse = new TargetGrpcProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                ValidateForProxyless = true,
                Fingerprint = "fingerprint009e6052",
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            TargetGrpcProxy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            GetTargetGrpcProxyRequest request = new GetTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
                Project = "projectaa6ff846",
            };
            TargetGrpcProxy expectedResponse = new TargetGrpcProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                ValidateForProxyless = true,
                Fingerprint = "fingerprint009e6052",
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetGrpcProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            TargetGrpcProxy responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetGrpcProxy responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            GetTargetGrpcProxyRequest request = new GetTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
                Project = "projectaa6ff846",
            };
            TargetGrpcProxy expectedResponse = new TargetGrpcProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                ValidateForProxyless = true,
                Fingerprint = "fingerprint009e6052",
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            TargetGrpcProxy response = client.Get(request.Project, request.TargetGrpcProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            GetTargetGrpcProxyRequest request = new GetTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
                Project = "projectaa6ff846",
            };
            TargetGrpcProxy expectedResponse = new TargetGrpcProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SelfLinkWithId = "self_link_with_id6d1e3896",
                ValidateForProxyless = true,
                Fingerprint = "fingerprint009e6052",
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetGrpcProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            TargetGrpcProxy responseCallSettings = await client.GetAsync(request.Project, request.TargetGrpcProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetGrpcProxy responseCancellationToken = await client.GetAsync(request.Project, request.TargetGrpcProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetGrpcProxyRequest request = new InsertTargetGrpcProxyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetGrpcProxyRequest request = new InsertTargetGrpcProxyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetGrpcProxyRequest request = new InsertTargetGrpcProxyRequest
            {
                Project = "projectaa6ff846",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.TargetGrpcProxyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetGrpcProxyRequest request = new InsertTargetGrpcProxyRequest
            {
                Project = "projectaa6ff846",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.TargetGrpcProxyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.TargetGrpcProxyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            ListTargetGrpcProxiesRequest request = new ListTargetGrpcProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetGrpcProxyList expectedResponse = new TargetGrpcProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetGrpcProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            TargetGrpcProxyList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            ListTargetGrpcProxiesRequest request = new ListTargetGrpcProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetGrpcProxyList expectedResponse = new TargetGrpcProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetGrpcProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetGrpcProxyList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            TargetGrpcProxyList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetGrpcProxyList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            ListTargetGrpcProxiesRequest request = new ListTargetGrpcProxiesRequest
            {
                Project = "projectaa6ff846",
            };
            TargetGrpcProxyList expectedResponse = new TargetGrpcProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetGrpcProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            TargetGrpcProxyList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            ListTargetGrpcProxiesRequest request = new ListTargetGrpcProxiesRequest
            {
                Project = "projectaa6ff846",
            };
            TargetGrpcProxyList expectedResponse = new TargetGrpcProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetGrpcProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetGrpcProxyList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            TargetGrpcProxyList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetGrpcProxyList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            PatchTargetGrpcProxyRequest request = new PatchTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            PatchTargetGrpcProxyRequest request = new PatchTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            PatchTargetGrpcProxyRequest request = new PatchTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
                Project = "projectaa6ff846",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.TargetGrpcProxy, request.TargetGrpcProxyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            PatchTargetGrpcProxyRequest request = new PatchTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "target_grpc_proxy51252bbb",
                Project = "projectaa6ff846",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
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
            TargetGrpcProxiesClient client = new TargetGrpcProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.TargetGrpcProxy, request.TargetGrpcProxyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.TargetGrpcProxy, request.TargetGrpcProxyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
