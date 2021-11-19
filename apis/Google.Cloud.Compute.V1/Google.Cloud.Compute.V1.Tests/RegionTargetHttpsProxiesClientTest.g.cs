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
    public sealed class GeneratedRegionTargetHttpsProxiesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient> mockGrpcClient = new moq::Mock<RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
                QuicOverride = "quic_override6404d0e0",
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
                QuicOverride = "quic_override6404d0e0",
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
                QuicOverride = "quic_override6404d0e0",
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
                QuicOverride = "quic_override6404d0e0",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetHttpsProxy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionTargetHttpsProxiesClient client = new RegionTargetHttpsProxiesClientImpl(mockGrpcClient.Object, null);
            TargetHttpsProxy responseCallSettings = await client.GetAsync(request.Project, request.Region, request.TargetHttpsProxy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetHttpsProxy responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.TargetHttpsProxy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
