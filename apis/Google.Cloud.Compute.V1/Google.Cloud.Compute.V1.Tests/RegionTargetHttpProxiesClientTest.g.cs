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
    public sealed class GeneratedRegionTargetHttpProxiesClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            DeleteRegionTargetHttpProxyRequest request = new DeleteRegionTargetHttpProxyRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
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
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            DeleteRegionTargetHttpProxyRequest request = new DeleteRegionTargetHttpProxyRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
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
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            DeleteRegionTargetHttpProxyRequest request = new DeleteRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
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
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.TargetHttpProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            DeleteRegionTargetHttpProxyRequest request = new DeleteRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
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
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.TargetHttpProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.TargetHttpProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
            };
            TargetHttpProxy expectedResponse = new TargetHttpProxy
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
            };
            TargetHttpProxy expectedResponse = new TargetHttpProxy
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxy responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpProxy responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
            };
            TargetHttpProxy expectedResponse = new TargetHttpProxy
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxy response = client.Get(request.Project, request.Region, request.TargetHttpProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
            };
            TargetHttpProxy expectedResponse = new TargetHttpProxy
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxy responseCallSettings = await client.GetAsync(request.Project, request.Region, request.TargetHttpProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpProxy responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.TargetHttpProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            InsertRegionTargetHttpProxyRequest request = new InsertRegionTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
                RequestId = "request_id362c8df6",
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
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            InsertRegionTargetHttpProxyRequest request = new InsertRegionTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
                RequestId = "request_id362c8df6",
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
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            InsertRegionTargetHttpProxyRequest request = new InsertRegionTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
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
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.TargetHttpProxyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            InsertRegionTargetHttpProxyRequest request = new InsertRegionTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
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
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.TargetHttpProxyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.TargetHttpProxyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            ListRegionTargetHttpProxiesRequest request = new ListRegionTargetHttpProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetHttpProxyList expectedResponse = new TargetHttpProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetHttpProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxyList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            ListRegionTargetHttpProxiesRequest request = new ListRegionTargetHttpProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetHttpProxyList expectedResponse = new TargetHttpProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetHttpProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpProxyList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxyList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpProxyList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            ListRegionTargetHttpProxiesRequest request = new ListRegionTargetHttpProxiesRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetHttpProxyList expectedResponse = new TargetHttpProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetHttpProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxyList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            ListRegionTargetHttpProxiesRequest request = new ListRegionTargetHttpProxiesRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetHttpProxyList expectedResponse = new TargetHttpProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetHttpProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpProxyList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpProxyList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpProxyList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetUrlMapRequestObject()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapRegionTargetHttpProxyRequest request = new SetUrlMapRegionTargetHttpProxyRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
                UrlMapReferenceResource = new UrlMapReference(),
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
            mockGrpcClient.Setup(x => x.SetUrlMap(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetUrlMap(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetUrlMapRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapRegionTargetHttpProxyRequest request = new SetUrlMapRegionTargetHttpProxyRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
                UrlMapReferenceResource = new UrlMapReference(),
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
            mockGrpcClient.Setup(x => x.SetUrlMapAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetUrlMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetUrlMapAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetUrlMap()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapRegionTargetHttpProxyRequest request = new SetUrlMapRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
                UrlMapReferenceResource = new UrlMapReference(),
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
            mockGrpcClient.Setup(x => x.SetUrlMap(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetUrlMap(request.Project, request.Region, request.TargetHttpProxy, request.UrlMapReferenceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetUrlMapAsync()
        {
            moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpProxies.RegionTargetHttpProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapRegionTargetHttpProxyRequest request = new SetUrlMapRegionTargetHttpProxyRequest
            {
                Region = "regionedb20d96",
                TargetHttpProxy = "target_http_proxy02d2fd7b",
                Project = "projectaa6ff846",
                UrlMapReferenceResource = new UrlMapReference(),
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
            mockGrpcClient.Setup(x => x.SetUrlMapAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionTargetHttpProxiesClient client = new RegionTargetHttpProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetUrlMapAsync(request.Project, request.Region, request.TargetHttpProxy, request.UrlMapReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetUrlMapAsync(request.Project, request.Region, request.TargetHttpProxy, request.UrlMapReferenceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
