// Copyright 2022 Google LLC
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
    public sealed class GeneratedTargetTcpProxiesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<TargetTcpProxies.TargetTcpProxiesClient> mockGrpcClient = new moq::Mock<TargetTcpProxies.TargetTcpProxiesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetTcpProxyRequest request = new GetTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
            };
            TargetTcpProxy expectedResponse = new TargetTcpProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = "proxy_headercff40018",
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetTcpProxyRequest request = new GetTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
            };
            TargetTcpProxy expectedResponse = new TargetTcpProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = "proxy_headercff40018",
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetTcpProxyRequest request = new GetTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
            };
            TargetTcpProxy expectedResponse = new TargetTcpProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = "proxy_headercff40018",
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetTcpProxyRequest request = new GetTargetTcpProxyRequest
            {
                Project = "projectaa6ff846",
                TargetTcpProxy = "target_tcp_proxy074a59b9",
            };
            TargetTcpProxy expectedResponse = new TargetTcpProxy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                ProxyHeader = "proxy_headercff40018",
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
    }
}
