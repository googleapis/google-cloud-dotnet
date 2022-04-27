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

using ga = Google.Api;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.GkeConnect.Gateway.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGatewayServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetResourceRequestObject()
        {
            moq::Mock<GatewayService.GatewayServiceClient> mockGrpcClient = new moq::Mock<GatewayService.GatewayServiceClient>(moq::MockBehavior.Strict);
            ga::HttpBody request = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetResource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GatewayServiceClient client = new GatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.GetResource(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetResourceRequestObjectAsync()
        {
            moq::Mock<GatewayService.GatewayServiceClient> mockGrpcClient = new moq::Mock<GatewayService.GatewayServiceClient>(moq::MockBehavior.Strict);
            ga::HttpBody request = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetResourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GatewayServiceClient client = new GatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.GetResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.GetResourceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PostResourceRequestObject()
        {
            moq::Mock<GatewayService.GatewayServiceClient> mockGrpcClient = new moq::Mock<GatewayService.GatewayServiceClient>(moq::MockBehavior.Strict);
            ga::HttpBody request = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.PostResource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GatewayServiceClient client = new GatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.PostResource(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PostResourceRequestObjectAsync()
        {
            moq::Mock<GatewayService.GatewayServiceClient> mockGrpcClient = new moq::Mock<GatewayService.GatewayServiceClient>(moq::MockBehavior.Strict);
            ga::HttpBody request = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.PostResourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GatewayServiceClient client = new GatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.PostResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.PostResourceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteResourceRequestObject()
        {
            moq::Mock<GatewayService.GatewayServiceClient> mockGrpcClient = new moq::Mock<GatewayService.GatewayServiceClient>(moq::MockBehavior.Strict);
            ga::HttpBody request = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.DeleteResource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GatewayServiceClient client = new GatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.DeleteResource(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteResourceRequestObjectAsync()
        {
            moq::Mock<GatewayService.GatewayServiceClient> mockGrpcClient = new moq::Mock<GatewayService.GatewayServiceClient>(moq::MockBehavior.Strict);
            ga::HttpBody request = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.DeleteResourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GatewayServiceClient client = new GatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.DeleteResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.DeleteResourceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PutResourceRequestObject()
        {
            moq::Mock<GatewayService.GatewayServiceClient> mockGrpcClient = new moq::Mock<GatewayService.GatewayServiceClient>(moq::MockBehavior.Strict);
            ga::HttpBody request = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.PutResource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GatewayServiceClient client = new GatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.PutResource(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PutResourceRequestObjectAsync()
        {
            moq::Mock<GatewayService.GatewayServiceClient> mockGrpcClient = new moq::Mock<GatewayService.GatewayServiceClient>(moq::MockBehavior.Strict);
            ga::HttpBody request = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.PutResourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GatewayServiceClient client = new GatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.PutResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.PutResourceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchResourceRequestObject()
        {
            moq::Mock<GatewayService.GatewayServiceClient> mockGrpcClient = new moq::Mock<GatewayService.GatewayServiceClient>(moq::MockBehavior.Strict);
            ga::HttpBody request = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.PatchResource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GatewayServiceClient client = new GatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.PatchResource(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchResourceRequestObjectAsync()
        {
            moq::Mock<GatewayService.GatewayServiceClient> mockGrpcClient = new moq::Mock<GatewayService.GatewayServiceClient>(moq::MockBehavior.Strict);
            ga::HttpBody request = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.PatchResourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GatewayServiceClient client = new GatewayServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.PatchResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.PatchResourceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
