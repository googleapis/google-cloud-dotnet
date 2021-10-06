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
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTargetSslProxiesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<TargetSslProxies.TargetSslProxiesClient> mockGrpcClient = new moq::Mock<TargetSslProxies.TargetSslProxiesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetSslProxyRequest request = new GetTargetSslProxyRequest
            {
                Project = "projectaa6ff846",
                TargetSslProxy = "target_ssl_proxy8c6691c6",
            };
            TargetSslProxy expectedResponse = new TargetSslProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = TargetSslProxy.Types.ProxyHeader.UndefinedProxyHeader,
                SslPolicy = "ssl_policybf005a65",
                SslCertificates =
                {
                    "ssl_certificates50ceaff5",
                },
                Service = "serviced3f0abaa",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetSslProxiesClient client = new TargetSslProxiesClientImpl(mockGrpcClient.Object, null);
            TargetSslProxy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<TargetSslProxies.TargetSslProxiesClient> mockGrpcClient = new moq::Mock<TargetSslProxies.TargetSslProxiesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetSslProxyRequest request = new GetTargetSslProxyRequest
            {
                Project = "projectaa6ff846",
                TargetSslProxy = "target_ssl_proxy8c6691c6",
            };
            TargetSslProxy expectedResponse = new TargetSslProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = TargetSslProxy.Types.ProxyHeader.UndefinedProxyHeader,
                SslPolicy = "ssl_policybf005a65",
                SslCertificates =
                {
                    "ssl_certificates50ceaff5",
                },
                Service = "serviced3f0abaa",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetSslProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetSslProxiesClient client = new TargetSslProxiesClientImpl(mockGrpcClient.Object, null);
            TargetSslProxy responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetSslProxy responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<TargetSslProxies.TargetSslProxiesClient> mockGrpcClient = new moq::Mock<TargetSslProxies.TargetSslProxiesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetSslProxyRequest request = new GetTargetSslProxyRequest
            {
                Project = "projectaa6ff846",
                TargetSslProxy = "target_ssl_proxy8c6691c6",
            };
            TargetSslProxy expectedResponse = new TargetSslProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = TargetSslProxy.Types.ProxyHeader.UndefinedProxyHeader,
                SslPolicy = "ssl_policybf005a65",
                SslCertificates =
                {
                    "ssl_certificates50ceaff5",
                },
                Service = "serviced3f0abaa",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetSslProxiesClient client = new TargetSslProxiesClientImpl(mockGrpcClient.Object, null);
            TargetSslProxy response = client.Get(request.Project, request.TargetSslProxy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<TargetSslProxies.TargetSslProxiesClient> mockGrpcClient = new moq::Mock<TargetSslProxies.TargetSslProxiesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetSslProxyRequest request = new GetTargetSslProxyRequest
            {
                Project = "projectaa6ff846",
                TargetSslProxy = "target_ssl_proxy8c6691c6",
            };
            TargetSslProxy expectedResponse = new TargetSslProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = TargetSslProxy.Types.ProxyHeader.UndefinedProxyHeader,
                SslPolicy = "ssl_policybf005a65",
                SslCertificates =
                {
                    "ssl_certificates50ceaff5",
                },
                Service = "serviced3f0abaa",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetSslProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetSslProxiesClient client = new TargetSslProxiesClientImpl(mockGrpcClient.Object, null);
            TargetSslProxy responseCallSettings = await client.GetAsync(request.Project, request.TargetSslProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetSslProxy responseCancellationToken = await client.GetAsync(request.Project, request.TargetSslProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
