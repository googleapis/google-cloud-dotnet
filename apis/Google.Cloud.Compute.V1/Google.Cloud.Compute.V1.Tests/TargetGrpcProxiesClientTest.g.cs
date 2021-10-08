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
    public sealed class GeneratedTargetGrpcProxiesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient> mockGrpcClient = new moq::Mock<TargetGrpcProxies.TargetGrpcProxiesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
    }
}
