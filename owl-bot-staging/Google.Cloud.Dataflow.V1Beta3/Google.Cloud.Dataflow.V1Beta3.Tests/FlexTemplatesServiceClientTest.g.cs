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

namespace Google.Cloud.Dataflow.V1Beta3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFlexTemplatesServiceClientTest
    {
        [xunit::FactAttribute]
        public void LaunchFlexTemplateRequestObject()
        {
            moq::Mock<FlexTemplatesService.FlexTemplatesServiceClient> mockGrpcClient = new moq::Mock<FlexTemplatesService.FlexTemplatesServiceClient>(moq::MockBehavior.Strict);
            LaunchFlexTemplateRequest request = new LaunchFlexTemplateRequest
            {
                ProjectId = "project_id43ad98b0",
                LaunchParameter = new LaunchFlexTemplateParameter(),
                Location = "locatione09d18d5",
                ValidateOnly = true,
            };
            LaunchFlexTemplateResponse expectedResponse = new LaunchFlexTemplateResponse { Job = new Job(), };
            mockGrpcClient.Setup(x => x.LaunchFlexTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlexTemplatesServiceClient client = new FlexTemplatesServiceClientImpl(mockGrpcClient.Object, null);
            LaunchFlexTemplateResponse response = client.LaunchFlexTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LaunchFlexTemplateRequestObjectAsync()
        {
            moq::Mock<FlexTemplatesService.FlexTemplatesServiceClient> mockGrpcClient = new moq::Mock<FlexTemplatesService.FlexTemplatesServiceClient>(moq::MockBehavior.Strict);
            LaunchFlexTemplateRequest request = new LaunchFlexTemplateRequest
            {
                ProjectId = "project_id43ad98b0",
                LaunchParameter = new LaunchFlexTemplateParameter(),
                Location = "locatione09d18d5",
                ValidateOnly = true,
            };
            LaunchFlexTemplateResponse expectedResponse = new LaunchFlexTemplateResponse { Job = new Job(), };
            mockGrpcClient.Setup(x => x.LaunchFlexTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LaunchFlexTemplateResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlexTemplatesServiceClient client = new FlexTemplatesServiceClientImpl(mockGrpcClient.Object, null);
            LaunchFlexTemplateResponse responseCallSettings = await client.LaunchFlexTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LaunchFlexTemplateResponse responseCancellationToken = await client.LaunchFlexTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
