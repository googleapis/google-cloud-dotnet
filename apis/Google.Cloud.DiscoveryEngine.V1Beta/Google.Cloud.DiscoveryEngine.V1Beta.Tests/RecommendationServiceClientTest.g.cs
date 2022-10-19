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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DiscoveryEngine.V1Beta.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRecommendationServiceClientTest
    {
        [xunit::FactAttribute]
        public void RecommendRequestObject()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            RecommendRequest request = new RecommendRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
                UserEvent = new UserEvent(),
                PageSize = -226905851,
                Filter = "filtere47ac9b2",
                ValidateOnly = true,
                Params =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            RecommendResponse expectedResponse = new RecommendResponse
            {
                Results =
                {
                    new RecommendResponse.Types.RecommendationResult(),
                },
                AttributionToken = "attribution_token14371a88",
                MissingIds =
                {
                    "missing_ids9e3bd4de",
                },
                ValidateOnly = true,
            };
            mockGrpcClient.Setup(x => x.Recommend(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null, null);
            RecommendResponse response = client.Recommend(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RecommendRequestObjectAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            RecommendRequest request = new RecommendRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
                UserEvent = new UserEvent(),
                PageSize = -226905851,
                Filter = "filtere47ac9b2",
                ValidateOnly = true,
                Params =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            RecommendResponse expectedResponse = new RecommendResponse
            {
                Results =
                {
                    new RecommendResponse.Types.RecommendationResult(),
                },
                AttributionToken = "attribution_token14371a88",
                MissingIds =
                {
                    "missing_ids9e3bd4de",
                },
                ValidateOnly = true,
            };
            mockGrpcClient.Setup(x => x.RecommendAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecommendResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null, null);
            RecommendResponse responseCallSettings = await client.RecommendAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecommendResponse responseCancellationToken = await client.RecommendAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
