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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedImageFamilyViewsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<ImageFamilyViews.ImageFamilyViewsClient> mockGrpcClient = new moq::Mock<ImageFamilyViews.ImageFamilyViewsClient>(moq::MockBehavior.Strict);
            GetImageFamilyViewRequest request = new GetImageFamilyViewRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                Family = "family0bda3f0d",
            };
            ImageFamilyView expectedResponse = new ImageFamilyView { Image = new Image(), };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImageFamilyViewsClient client = new ImageFamilyViewsClientImpl(mockGrpcClient.Object, null);
            ImageFamilyView response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<ImageFamilyViews.ImageFamilyViewsClient> mockGrpcClient = new moq::Mock<ImageFamilyViews.ImageFamilyViewsClient>(moq::MockBehavior.Strict);
            GetImageFamilyViewRequest request = new GetImageFamilyViewRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                Family = "family0bda3f0d",
            };
            ImageFamilyView expectedResponse = new ImageFamilyView { Image = new Image(), };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImageFamilyView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImageFamilyViewsClient client = new ImageFamilyViewsClientImpl(mockGrpcClient.Object, null);
            ImageFamilyView responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImageFamilyView responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<ImageFamilyViews.ImageFamilyViewsClient> mockGrpcClient = new moq::Mock<ImageFamilyViews.ImageFamilyViewsClient>(moq::MockBehavior.Strict);
            GetImageFamilyViewRequest request = new GetImageFamilyViewRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                Family = "family0bda3f0d",
            };
            ImageFamilyView expectedResponse = new ImageFamilyView { Image = new Image(), };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImageFamilyViewsClient client = new ImageFamilyViewsClientImpl(mockGrpcClient.Object, null);
            ImageFamilyView response = client.Get(request.Project, request.Zone, request.Family);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<ImageFamilyViews.ImageFamilyViewsClient> mockGrpcClient = new moq::Mock<ImageFamilyViews.ImageFamilyViewsClient>(moq::MockBehavior.Strict);
            GetImageFamilyViewRequest request = new GetImageFamilyViewRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                Family = "family0bda3f0d",
            };
            ImageFamilyView expectedResponse = new ImageFamilyView { Image = new Image(), };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImageFamilyView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImageFamilyViewsClient client = new ImageFamilyViewsClientImpl(mockGrpcClient.Object, null);
            ImageFamilyView responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.Family, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImageFamilyView responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.Family, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
