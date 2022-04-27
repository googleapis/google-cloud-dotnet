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
    public sealed class GeneratedRoutersClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
            Router response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
            Router response = client.Get(request.Project, request.Region, request.Router);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
            RouterStatusResponse response = client.GetRouterStatus(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRouterStatusRequestObjectAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
            RouterStatusResponse response = client.GetRouterStatus(request.Project, request.Region, request.Router);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRouterStatusAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
            RouterStatusResponse responseCallSettings = await client.GetRouterStatusAsync(request.Project, request.Region, request.Router, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RouterStatusResponse responseCancellationToken = await client.GetRouterStatusAsync(request.Project, request.Region, request.Router, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PreviewRequestObject()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
            RoutersPreviewResponse response = client.Preview(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PreviewRequestObjectAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
            RoutersPreviewResponse response = client.Preview(request.Project, request.Region, request.Router, request.RouterResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PreviewAsync()
        {
            moq::Mock<Routers.RoutersClient> mockGrpcClient = new moq::Mock<Routers.RoutersClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            RoutersClient client = new RoutersClientImpl(mockGrpcClient.Object, null, null);
            RoutersPreviewResponse responseCallSettings = await client.PreviewAsync(request.Project, request.Region, request.Router, request.RouterResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RoutersPreviewResponse responseCancellationToken = await client.PreviewAsync(request.Project, request.Region, request.Router, request.RouterResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
