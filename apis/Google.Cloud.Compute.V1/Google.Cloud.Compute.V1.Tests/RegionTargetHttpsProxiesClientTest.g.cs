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
    public sealed class GeneratedRegionTargetHttpsProxiesClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            DeleteRegionTargetHttpsProxyRequest request = new DeleteRegionTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            DeleteRegionTargetHttpsProxyRequest request = new DeleteRegionTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            DeleteRegionTargetHttpsProxyRequest request = new DeleteRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.TargetHttpsProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            DeleteRegionTargetHttpsProxyRequest request = new DeleteRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.TargetHttpsProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.TargetHttpsProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            GetRegionTargetHttpsProxyRequest request = new GetRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            GetRegionTargetHttpsProxyRequest request = new GetRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxy responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpsProxy responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            GetRegionTargetHttpsProxyRequest request = new GetRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxy response = client.Get(request.Project, request.Region, request.TargetHttpsProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            GetRegionTargetHttpsProxyRequest request = new GetRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxy responseCallSettings = await client.GetAsync(request.Project, request.Region, request.TargetHttpsProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpsProxy responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.TargetHttpsProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            InsertRegionTargetHttpsProxyRequest request = new InsertRegionTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            InsertRegionTargetHttpsProxyRequest request = new InsertRegionTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            InsertRegionTargetHttpsProxyRequest request = new InsertRegionTargetHttpsProxyRequest
            {
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.TargetHttpsProxyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            InsertRegionTargetHttpsProxyRequest request = new InsertRegionTargetHttpsProxyRequest
            {
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.TargetHttpsProxyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.TargetHttpsProxyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            ListRegionTargetHttpsProxiesRequest request = new ListRegionTargetHttpsProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            ListRegionTargetHttpsProxiesRequest request = new ListRegionTargetHttpsProxiesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpsProxyList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            ListRegionTargetHttpsProxiesRequest request = new ListRegionTargetHttpsProxiesRequest
            {
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            ListRegionTargetHttpsProxiesRequest request = new ListRegionTargetHttpsProxiesRequest
            {
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxyList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpsProxyList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetSslCertificatesRequestObject()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslCertificatesRegionTargetHttpsProxyRequest request = new SetSslCertificatesRegionTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                RegionTargetHttpsProxiesSetSslCertificatesRequestResource = new RegionTargetHttpsProxiesSetSslCertificatesRequest(),
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetSslCertificates(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetSslCertificatesRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslCertificatesRegionTargetHttpsProxyRequest request = new SetSslCertificatesRegionTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                RegionTargetHttpsProxiesSetSslCertificatesRequestResource = new RegionTargetHttpsProxiesSetSslCertificatesRequest(),
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetSslCertificatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetSslCertificatesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetSslCertificates()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslCertificatesRegionTargetHttpsProxyRequest request = new SetSslCertificatesRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                RegionTargetHttpsProxiesSetSslCertificatesRequestResource = new RegionTargetHttpsProxiesSetSslCertificatesRequest(),
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetSslCertificates(request.Project, request.Region, request.TargetHttpsProxy, request.RegionTargetHttpsProxiesSetSslCertificatesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetSslCertificatesAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetSslCertificatesRegionTargetHttpsProxyRequest request = new SetSslCertificatesRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                RegionTargetHttpsProxiesSetSslCertificatesRequestResource = new RegionTargetHttpsProxiesSetSslCertificatesRequest(),
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetSslCertificatesAsync(request.Project, request.Region, request.TargetHttpsProxy, request.RegionTargetHttpsProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetSslCertificatesAsync(request.Project, request.Region, request.TargetHttpsProxy, request.RegionTargetHttpsProxiesSetSslCertificatesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetUrlMapRequestObject()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapRegionTargetHttpsProxyRequest request = new SetUrlMapRegionTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetUrlMap(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetUrlMapRequestObjectAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapRegionTargetHttpsProxyRequest request = new SetUrlMapRegionTargetHttpsProxyRequest
            {
                RequestId = "request_id362c8df6",
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetUrlMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetUrlMapAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetUrlMap()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapRegionTargetHttpsProxyRequest request = new SetUrlMapRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetUrlMap(request.Project, request.Region, request.TargetHttpsProxy, request.UrlMapReferenceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetUrlMapAsync()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            SetUrlMapRegionTargetHttpsProxyRequest request = new SetUrlMapRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "target_https_proxycf436352",
                Region = "regionedb20d96",
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
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetUrlMapAsync(request.Project, request.Region, request.TargetHttpsProxy, request.UrlMapReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetUrlMapAsync(request.Project, request.Region, request.TargetHttpsProxy, request.UrlMapReferenceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
