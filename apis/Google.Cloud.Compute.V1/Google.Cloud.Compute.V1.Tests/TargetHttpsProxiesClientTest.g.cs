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
    public sealed class GeneratedTargetHttpsProxiesClientTest
    {
        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            AggregatedListTargetHttpsProxiesRequest request = new AggregatedListTargetHttpsProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            TargetHttpsProxyAggregatedList expectedResponse = new TargetHttpsProxyAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetHttpsProxiesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            AggregatedListTargetHttpsProxiesRequest request = new AggregatedListTargetHttpsProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            TargetHttpsProxyAggregatedList expectedResponse = new TargetHttpsProxyAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetHttpsProxiesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpsProxyAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpsProxyAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            AggregatedListTargetHttpsProxiesRequest request = new AggregatedListTargetHttpsProxiesRequest
            {
                Project = "projectaa6ff846",
            };
            TargetHttpsProxyAggregatedList expectedResponse = new TargetHttpsProxyAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetHttpsProxiesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            AggregatedListTargetHttpsProxiesRequest request = new AggregatedListTargetHttpsProxiesRequest
            {
                Project = "projectaa6ff846",
            };
            TargetHttpsProxyAggregatedList expectedResponse = new TargetHttpsProxyAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetHttpsProxiesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpsProxyAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpsProxyAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetHttpsProxyRequest request = new DeleteTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetHttpsProxyRequest request = new DeleteTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetHttpsProxyRequest request = new DeleteTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.TargetHttpsProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            DeleteTargetHttpsProxyRequest request = new DeleteTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.TargetHttpsProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.TargetHttpsProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            GetTargetHttpsProxyRequest request = new GetTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
            };
            TargetHttpsProxy expectedResponse = new TargetHttpsProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                AuthorizationPolicy = "authorization_policyb4cd090a",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                SslPolicy = "ssl_policybf005a65",
                ServerTlsPolicy = "server_tls_policyc2b4dc10",
                SslCertificates =
                {
                    "ssl_certificates50ceaff5",
                },
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                QuicOverride = TargetHttpsProxy.Types.QuicOverride.UndefinedQuicOverride,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            GetTargetHttpsProxyRequest request = new GetTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
            };
            TargetHttpsProxy expectedResponse = new TargetHttpsProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                AuthorizationPolicy = "authorization_policyb4cd090a",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                SslPolicy = "ssl_policybf005a65",
                ServerTlsPolicy = "server_tls_policyc2b4dc10",
                SslCertificates =
                {
                    "ssl_certificates50ceaff5",
                },
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                QuicOverride = TargetHttpsProxy.Types.QuicOverride.UndefinedQuicOverride,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpsProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxy responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpsProxy responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            GetTargetHttpsProxyRequest request = new GetTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
            };
            TargetHttpsProxy expectedResponse = new TargetHttpsProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                AuthorizationPolicy = "authorization_policyb4cd090a",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                SslPolicy = "ssl_policybf005a65",
                ServerTlsPolicy = "server_tls_policyc2b4dc10",
                SslCertificates =
                {
                    "ssl_certificates50ceaff5",
                },
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                QuicOverride = TargetHttpsProxy.Types.QuicOverride.UndefinedQuicOverride,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxy response = client.Get(request.Project, request.TargetHttpsProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            GetTargetHttpsProxyRequest request = new GetTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
            };
            TargetHttpsProxy expectedResponse = new TargetHttpsProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                AuthorizationPolicy = "authorization_policyb4cd090a",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                ProxyBind = false,
                SslPolicy = "ssl_policybf005a65",
                ServerTlsPolicy = "server_tls_policyc2b4dc10",
                SslCertificates =
                {
                    "ssl_certificates50ceaff5",
                },
                UrlMap = "url_map3ccdbf57",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                QuicOverride = TargetHttpsProxy.Types.QuicOverride.UndefinedQuicOverride,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpsProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxy responseCallSettings = await client.GetAsync(request.Project, request.TargetHttpsProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpsProxy responseCancellationToken = await client.GetAsync(request.Project, request.TargetHttpsProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetHttpsProxyRequest request = new InsertTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetHttpsProxyRequest request = new InsertTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetHttpsProxyRequest request = new InsertTargetHttpsProxyRequest
            {
                Project = "projectaa6ff846",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.TargetHttpsProxyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            InsertTargetHttpsProxyRequest request = new InsertTargetHttpsProxyRequest
            {
                Project = "projectaa6ff846",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.TargetHttpsProxyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.TargetHttpsProxyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            ListTargetHttpsProxiesRequest request = new ListTargetHttpsProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetHttpsProxyList expectedResponse = new TargetHttpsProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetHttpsProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            ListTargetHttpsProxiesRequest request = new ListTargetHttpsProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetHttpsProxyList expectedResponse = new TargetHttpsProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetHttpsProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpsProxyList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpsProxyList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            ListTargetHttpsProxiesRequest request = new ListTargetHttpsProxiesRequest
            {
                Project = "projectaa6ff846",
            };
            TargetHttpsProxyList expectedResponse = new TargetHttpsProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetHttpsProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            ListTargetHttpsProxiesRequest request = new ListTargetHttpsProxiesRequest
            {
                Project = "projectaa6ff846",
            };
            TargetHttpsProxyList expectedResponse = new TargetHttpsProxyList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetHttpsProxy(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpsProxyList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpsProxyList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            PatchTargetHttpsProxyRequest request = new PatchTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            PatchTargetHttpsProxyRequest request = new PatchTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            PatchTargetHttpsProxyRequest request = new PatchTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.TargetHttpsProxy, request.TargetHttpsProxyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            PatchTargetHttpsProxyRequest request = new PatchTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
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
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.TargetHttpsProxy, request.TargetHttpsProxyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.TargetHttpsProxy, request.TargetHttpsProxyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetQuicOverrideRequestObject()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetQuicOverrideTargetHttpsProxyRequest request = new SetQuicOverrideTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                TargetHttpsProxiesSetQuicOverrideRequestResource = new TargetHttpsProxiesSetQuicOverrideRequest(),
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
            mockGrpcClient.Setup(x => x.SetQuicOverride(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetQuicOverride(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetQuicOverrideRequestObjectAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetQuicOverrideTargetHttpsProxyRequest request = new SetQuicOverrideTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                TargetHttpsProxiesSetQuicOverrideRequestResource = new TargetHttpsProxiesSetQuicOverrideRequest(),
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
            mockGrpcClient.Setup(x => x.SetQuicOverrideAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetQuicOverrideAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetQuicOverrideAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetQuicOverride()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetQuicOverrideTargetHttpsProxyRequest request = new SetQuicOverrideTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                TargetHttpsProxiesSetQuicOverrideRequestResource = new TargetHttpsProxiesSetQuicOverrideRequest(),
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
            mockGrpcClient.Setup(x => x.SetQuicOverride(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetQuicOverride(request.Project, request.TargetHttpsProxy, request.TargetHttpsProxiesSetQuicOverrideRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetQuicOverrideAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetQuicOverrideTargetHttpsProxyRequest request = new SetQuicOverrideTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                TargetHttpsProxiesSetQuicOverrideRequestResource = new TargetHttpsProxiesSetQuicOverrideRequest(),
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
            mockGrpcClient.Setup(x => x.SetQuicOverrideAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetQuicOverrideAsync(request.Project, request.TargetHttpsProxy, request.TargetHttpsProxiesSetQuicOverrideRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetQuicOverrideAsync(request.Project, request.TargetHttpsProxy, request.TargetHttpsProxiesSetQuicOverrideRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetSslCertificatesRequestObject()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslCertificatesTargetHttpsProxyRequest request = new SetSslCertificatesTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                TargetHttpsProxiesSetSslCertificatesRequestResource = new TargetHttpsProxiesSetSslCertificatesRequest(),
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
            mockGrpcClient.Setup(x => x.SetSslCertificates(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetSslCertificates(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetSslCertificatesRequestObjectAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslCertificatesTargetHttpsProxyRequest request = new SetSslCertificatesTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                TargetHttpsProxiesSetSslCertificatesRequestResource = new TargetHttpsProxiesSetSslCertificatesRequest(),
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
            mockGrpcClient.Setup(x => x.SetSslCertificatesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetSslCertificatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetSslCertificatesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetSslCertificates()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslCertificatesTargetHttpsProxyRequest request = new SetSslCertificatesTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                TargetHttpsProxiesSetSslCertificatesRequestResource = new TargetHttpsProxiesSetSslCertificatesRequest(),
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
            mockGrpcClient.Setup(x => x.SetSslCertificates(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetSslCertificates(request.Project, request.TargetHttpsProxy, request.TargetHttpsProxiesSetSslCertificatesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetSslCertificatesAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslCertificatesTargetHttpsProxyRequest request = new SetSslCertificatesTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                TargetHttpsProxiesSetSslCertificatesRequestResource = new TargetHttpsProxiesSetSslCertificatesRequest(),
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
            mockGrpcClient.Setup(x => x.SetSslCertificatesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetSslCertificatesAsync(request.Project, request.TargetHttpsProxy, request.TargetHttpsProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetSslCertificatesAsync(request.Project, request.TargetHttpsProxy, request.TargetHttpsProxiesSetSslCertificatesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetSslPolicyRequestObject()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslPolicyTargetHttpsProxyRequest request = new SetSslPolicyTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                SslPolicyReferenceResource = new SslPolicyReference(),
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
            mockGrpcClient.Setup(x => x.SetSslPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetSslPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetSslPolicyRequestObjectAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslPolicyTargetHttpsProxyRequest request = new SetSslPolicyTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                SslPolicyReferenceResource = new SslPolicyReference(),
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
            mockGrpcClient.Setup(x => x.SetSslPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetSslPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetSslPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetSslPolicy()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslPolicyTargetHttpsProxyRequest request = new SetSslPolicyTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                SslPolicyReferenceResource = new SslPolicyReference(),
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
            mockGrpcClient.Setup(x => x.SetSslPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetSslPolicy(request.Project, request.TargetHttpsProxy, request.SslPolicyReferenceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetSslPolicyAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslPolicyTargetHttpsProxyRequest request = new SetSslPolicyTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                SslPolicyReferenceResource = new SslPolicyReference(),
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
            mockGrpcClient.Setup(x => x.SetSslPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetSslPolicyAsync(request.Project, request.TargetHttpsProxy, request.SslPolicyReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetSslPolicyAsync(request.Project, request.TargetHttpsProxy, request.SslPolicyReferenceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetUrlMapRequestObject()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapTargetHttpsProxyRequest request = new SetUrlMapTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                UrlMapReferenceResource = new UrlMapReference(),
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
            mockGrpcClient.Setup(x => x.SetUrlMap(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetUrlMap(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetUrlMapRequestObjectAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapTargetHttpsProxyRequest request = new SetUrlMapTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                UrlMapReferenceResource = new UrlMapReference(),
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
            mockGrpcClient.Setup(x => x.SetUrlMapAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetUrlMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetUrlMapAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetUrlMap()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapTargetHttpsProxyRequest request = new SetUrlMapTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                UrlMapReferenceResource = new UrlMapReference(),
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
            mockGrpcClient.Setup(x => x.SetUrlMap(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetUrlMap(request.Project, request.TargetHttpsProxy, request.UrlMapReferenceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetUrlMapAsync()
        {
            moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<TargetHttpsProxies.TargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapTargetHttpsProxyRequest request = new SetUrlMapTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Project = "projectaa6ff846",
                UrlMapReferenceResource = new UrlMapReference(),
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
            mockGrpcClient.Setup(x => x.SetUrlMapAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetHttpsProxiesClient client = new TargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetUrlMapAsync(request.Project, request.TargetHttpsProxy, request.UrlMapReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetUrlMapAsync(request.Project, request.TargetHttpsProxy, request.UrlMapReferenceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
