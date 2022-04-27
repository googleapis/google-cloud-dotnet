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

namespace Google.Cloud.Vision.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedImageAnnotatorClientTest
    {
        [xunit::FactAttribute]
        public void BatchAnnotateImagesRequestObject()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest(),
                },
                Parent = "parent7858e4d0",
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse
            {
                Responses =
                {
                    new AnnotateImageResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateImages(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null, null);
            BatchAnnotateImagesResponse response = client.BatchAnnotateImages(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchAnnotateImagesRequestObjectAsync()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest(),
                },
                Parent = "parent7858e4d0",
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse
            {
                Responses =
                {
                    new AnnotateImageResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateImagesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchAnnotateImagesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null, null);
            BatchAnnotateImagesResponse responseCallSettings = await client.BatchAnnotateImagesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchAnnotateImagesResponse responseCancellationToken = await client.BatchAnnotateImagesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchAnnotateImages()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest(),
                },
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse
            {
                Responses =
                {
                    new AnnotateImageResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateImages(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null, null);
            BatchAnnotateImagesResponse response = client.BatchAnnotateImages(request.Requests);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchAnnotateImagesAsync()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest(),
                },
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse
            {
                Responses =
                {
                    new AnnotateImageResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateImagesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchAnnotateImagesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null, null);
            BatchAnnotateImagesResponse responseCallSettings = await client.BatchAnnotateImagesAsync(request.Requests, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchAnnotateImagesResponse responseCancellationToken = await client.BatchAnnotateImagesAsync(request.Requests, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchAnnotateFilesRequestObject()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateFilesRequest request = new BatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AnnotateFileRequest(),
                },
                Parent = "parent7858e4d0",
            };
            BatchAnnotateFilesResponse expectedResponse = new BatchAnnotateFilesResponse
            {
                Responses =
                {
                    new AnnotateFileResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateFiles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null, null);
            BatchAnnotateFilesResponse response = client.BatchAnnotateFiles(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchAnnotateFilesRequestObjectAsync()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateFilesRequest request = new BatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AnnotateFileRequest(),
                },
                Parent = "parent7858e4d0",
            };
            BatchAnnotateFilesResponse expectedResponse = new BatchAnnotateFilesResponse
            {
                Responses =
                {
                    new AnnotateFileResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateFilesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchAnnotateFilesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null, null);
            BatchAnnotateFilesResponse responseCallSettings = await client.BatchAnnotateFilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchAnnotateFilesResponse responseCancellationToken = await client.BatchAnnotateFilesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchAnnotateFiles()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateFilesRequest request = new BatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AnnotateFileRequest(),
                },
            };
            BatchAnnotateFilesResponse expectedResponse = new BatchAnnotateFilesResponse
            {
                Responses =
                {
                    new AnnotateFileResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateFiles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null, null);
            BatchAnnotateFilesResponse response = client.BatchAnnotateFiles(request.Requests);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchAnnotateFilesAsync()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateFilesRequest request = new BatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AnnotateFileRequest(),
                },
            };
            BatchAnnotateFilesResponse expectedResponse = new BatchAnnotateFilesResponse
            {
                Responses =
                {
                    new AnnotateFileResponse(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateFilesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchAnnotateFilesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null, null);
            BatchAnnotateFilesResponse responseCallSettings = await client.BatchAnnotateFilesAsync(request.Requests, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchAnnotateFilesResponse responseCancellationToken = await client.BatchAnnotateFilesAsync(request.Requests, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
