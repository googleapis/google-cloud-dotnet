// Copyright 2019 Google LLC
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

namespace Google.Cloud.Vision.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Vision.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedImageAnnotatorClientTest
    {
        [Fact]
        public void BatchAnnotateImages()
        {
            Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new Mock<ImageAnnotator.ImageAnnotatorClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest expectedRequest = new BatchAnnotateImagesRequest
            {
                Requests = { },
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse();
            mockGrpcClient.Setup(x => x.BatchAnnotateImages(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            IEnumerable<AnnotateImageRequest> requests = new List<AnnotateImageRequest>();
            BatchAnnotateImagesResponse response = client.BatchAnnotateImages(requests);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchAnnotateImagesAsync()
        {
            Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new Mock<ImageAnnotator.ImageAnnotatorClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest expectedRequest = new BatchAnnotateImagesRequest
            {
                Requests = { },
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse();
            mockGrpcClient.Setup(x => x.BatchAnnotateImagesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BatchAnnotateImagesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            IEnumerable<AnnotateImageRequest> requests = new List<AnnotateImageRequest>();
            BatchAnnotateImagesResponse response = await client.BatchAnnotateImagesAsync(requests);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BatchAnnotateImages2()
        {
            Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new Mock<ImageAnnotator.ImageAnnotatorClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests = { },
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse();
            mockGrpcClient.Setup(x => x.BatchAnnotateImages(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            BatchAnnotateImagesResponse response = client.BatchAnnotateImages(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchAnnotateImagesAsync2()
        {
            Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new Mock<ImageAnnotator.ImageAnnotatorClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests = { },
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse();
            mockGrpcClient.Setup(x => x.BatchAnnotateImagesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BatchAnnotateImagesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            BatchAnnotateImagesResponse response = await client.BatchAnnotateImagesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
