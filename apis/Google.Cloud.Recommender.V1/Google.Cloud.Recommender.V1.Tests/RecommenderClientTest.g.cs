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

namespace Google.Cloud.Recommender.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRecommenderClientTest
    {
        [xunit::FactAttribute]
        public void GetInsightRequestObject()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightRequest request = new GetInsightRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.GetInsight(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight response = client.GetInsight(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInsightRequestObjectAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightRequest request = new GetInsightRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.GetInsightAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Insight>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight responseCallSettings = await client.GetInsightAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Insight responseCancellationToken = await client.GetInsightAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInsight()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightRequest request = new GetInsightRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.GetInsight(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight response = client.GetInsight(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInsightAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightRequest request = new GetInsightRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.GetInsightAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Insight>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight responseCallSettings = await client.GetInsightAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Insight responseCancellationToken = await client.GetInsightAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInsightResourceNames()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightRequest request = new GetInsightRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.GetInsight(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight response = client.GetInsight(request.InsightName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInsightResourceNamesAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightRequest request = new GetInsightRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.GetInsightAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Insight>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight responseCallSettings = await client.GetInsightAsync(request.InsightName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Insight responseCancellationToken = await client.GetInsightAsync(request.InsightName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkInsightAcceptedRequestObject()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkInsightAcceptedRequest request = new MarkInsightAcceptedRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.MarkInsightAccepted(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight response = client.MarkInsightAccepted(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkInsightAcceptedRequestObjectAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkInsightAcceptedRequest request = new MarkInsightAcceptedRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.MarkInsightAcceptedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Insight>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight responseCallSettings = await client.MarkInsightAcceptedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Insight responseCancellationToken = await client.MarkInsightAcceptedAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkInsightAccepted()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkInsightAcceptedRequest request = new MarkInsightAcceptedRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.MarkInsightAccepted(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight response = client.MarkInsightAccepted(request.Name, request.StateMetadata, request.Etag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkInsightAcceptedAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkInsightAcceptedRequest request = new MarkInsightAcceptedRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.MarkInsightAcceptedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Insight>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight responseCallSettings = await client.MarkInsightAcceptedAsync(request.Name, request.StateMetadata, request.Etag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Insight responseCancellationToken = await client.MarkInsightAcceptedAsync(request.Name, request.StateMetadata, request.Etag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkInsightAcceptedResourceNames()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkInsightAcceptedRequest request = new MarkInsightAcceptedRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.MarkInsightAccepted(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight response = client.MarkInsightAccepted(request.InsightName, request.StateMetadata, request.Etag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkInsightAcceptedResourceNamesAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkInsightAcceptedRequest request = new MarkInsightAcceptedRequest
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Insight expectedResponse = new Insight
            {
                InsightName = InsightName.FromProjectLocationInsightTypeInsight("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]", "[INSIGHT]"),
                Description = "description2cf9da67",
                Content = new wkt::Struct(),
                LastRefreshTime = new wkt::Timestamp(),
                ObservationPeriod = new wkt::Duration(),
                StateInfo = new InsightStateInfo(),
                Category = Insight.Types.Category.Unspecified,
                AssociatedRecommendations =
                {
                    new Insight.Types.RecommendationReference(),
                },
                TargetResources =
                {
                    "target_resources1e810c06",
                },
                InsightSubtype = "insight_subtype87faa4e7",
                Etag = "etage8ad7218",
                Severity = Insight.Types.Severity.High,
            };
            mockGrpcClient.Setup(x => x.MarkInsightAcceptedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Insight>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Insight responseCallSettings = await client.MarkInsightAcceptedAsync(request.InsightName, request.StateMetadata, request.Etag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Insight responseCancellationToken = await client.MarkInsightAcceptedAsync(request.InsightName, request.StateMetadata, request.Etag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRecommendationRequestObject()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.GetRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.GetRecommendation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecommendationRequestObjectAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.GetRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.GetRecommendationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.GetRecommendationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRecommendation()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.GetRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.GetRecommendation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecommendationAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.GetRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.GetRecommendationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.GetRecommendationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRecommendationResourceNames()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.GetRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.GetRecommendation(request.RecommendationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecommendationResourceNamesAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.GetRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.GetRecommendationAsync(request.RecommendationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.GetRecommendationAsync(request.RecommendationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkRecommendationClaimedRequestObject()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationClaimedRequest request = new MarkRecommendationClaimedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationClaimed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.MarkRecommendationClaimed(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkRecommendationClaimedRequestObjectAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationClaimedRequest request = new MarkRecommendationClaimedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationClaimedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.MarkRecommendationClaimedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.MarkRecommendationClaimedAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkRecommendationClaimed()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationClaimedRequest request = new MarkRecommendationClaimedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationClaimed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.MarkRecommendationClaimed(request.Name, request.StateMetadata, request.Etag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkRecommendationClaimedAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationClaimedRequest request = new MarkRecommendationClaimedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationClaimedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.MarkRecommendationClaimedAsync(request.Name, request.StateMetadata, request.Etag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.MarkRecommendationClaimedAsync(request.Name, request.StateMetadata, request.Etag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkRecommendationClaimedResourceNames()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationClaimedRequest request = new MarkRecommendationClaimedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationClaimed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.MarkRecommendationClaimed(request.RecommendationName, request.StateMetadata, request.Etag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkRecommendationClaimedResourceNamesAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationClaimedRequest request = new MarkRecommendationClaimedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationClaimedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.MarkRecommendationClaimedAsync(request.RecommendationName, request.StateMetadata, request.Etag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.MarkRecommendationClaimedAsync(request.RecommendationName, request.StateMetadata, request.Etag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkRecommendationSucceededRequestObject()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationSucceededRequest request = new MarkRecommendationSucceededRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationSucceeded(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.MarkRecommendationSucceeded(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkRecommendationSucceededRequestObjectAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationSucceededRequest request = new MarkRecommendationSucceededRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationSucceededAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.MarkRecommendationSucceededAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.MarkRecommendationSucceededAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkRecommendationSucceeded()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationSucceededRequest request = new MarkRecommendationSucceededRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationSucceeded(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.MarkRecommendationSucceeded(request.Name, request.StateMetadata, request.Etag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkRecommendationSucceededAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationSucceededRequest request = new MarkRecommendationSucceededRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationSucceededAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.MarkRecommendationSucceededAsync(request.Name, request.StateMetadata, request.Etag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.MarkRecommendationSucceededAsync(request.Name, request.StateMetadata, request.Etag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkRecommendationSucceededResourceNames()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationSucceededRequest request = new MarkRecommendationSucceededRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationSucceeded(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.MarkRecommendationSucceeded(request.RecommendationName, request.StateMetadata, request.Etag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkRecommendationSucceededResourceNamesAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationSucceededRequest request = new MarkRecommendationSucceededRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationSucceededAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.MarkRecommendationSucceededAsync(request.RecommendationName, request.StateMetadata, request.Etag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.MarkRecommendationSucceededAsync(request.RecommendationName, request.StateMetadata, request.Etag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkRecommendationFailedRequestObject()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationFailedRequest request = new MarkRecommendationFailedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationFailed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.MarkRecommendationFailed(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkRecommendationFailedRequestObjectAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationFailedRequest request = new MarkRecommendationFailedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationFailedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.MarkRecommendationFailedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.MarkRecommendationFailedAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkRecommendationFailed()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationFailedRequest request = new MarkRecommendationFailedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationFailed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.MarkRecommendationFailed(request.Name, request.StateMetadata, request.Etag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkRecommendationFailedAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationFailedRequest request = new MarkRecommendationFailedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationFailedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.MarkRecommendationFailedAsync(request.Name, request.StateMetadata, request.Etag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.MarkRecommendationFailedAsync(request.Name, request.StateMetadata, request.Etag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MarkRecommendationFailedResourceNames()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationFailedRequest request = new MarkRecommendationFailedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationFailed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation response = client.MarkRecommendationFailed(request.RecommendationName, request.StateMetadata, request.Etag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MarkRecommendationFailedResourceNamesAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            MarkRecommendationFailedRequest request = new MarkRecommendationFailedRequest
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                StateMetadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            Recommendation expectedResponse = new Recommendation
            {
                RecommendationName = RecommendationName.FromProjectLocationRecommenderRecommendation("[PROJECT]", "[LOCATION]", "[RECOMMENDER]", "[RECOMMENDATION]"),
                Description = "description2cf9da67",
                LastRefreshTime = new wkt::Timestamp(),
                PrimaryImpact = new Impact(),
                AdditionalImpact = { new Impact(), },
                Content = new RecommendationContent(),
                StateInfo = new RecommendationStateInfo(),
                Etag = "etage8ad7218",
                RecommenderSubtype = "recommender_subtype6a5b10f9",
                AssociatedInsights =
                {
                    new Recommendation.Types.InsightReference(),
                },
                Priority = Recommendation.Types.Priority.P1,
                XorGroupId = "xor_group_id40c40796",
            };
            mockGrpcClient.Setup(x => x.MarkRecommendationFailedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            Recommendation responseCallSettings = await client.MarkRecommendationFailedAsync(request.RecommendationName, request.StateMetadata, request.Etag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recommendation responseCancellationToken = await client.MarkRecommendationFailedAsync(request.RecommendationName, request.StateMetadata, request.Etag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRecommenderConfigRequestObject()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommenderConfigRequest request = new GetRecommenderConfigRequest
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
            };
            RecommenderConfig expectedResponse = new RecommenderConfig
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
                RecommenderGenerationConfig = new RecommenderGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetRecommenderConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            RecommenderConfig response = client.GetRecommenderConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecommenderConfigRequestObjectAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommenderConfigRequest request = new GetRecommenderConfigRequest
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
            };
            RecommenderConfig expectedResponse = new RecommenderConfig
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
                RecommenderGenerationConfig = new RecommenderGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetRecommenderConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecommenderConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            RecommenderConfig responseCallSettings = await client.GetRecommenderConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecommenderConfig responseCancellationToken = await client.GetRecommenderConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRecommenderConfig()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommenderConfigRequest request = new GetRecommenderConfigRequest
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
            };
            RecommenderConfig expectedResponse = new RecommenderConfig
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
                RecommenderGenerationConfig = new RecommenderGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetRecommenderConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            RecommenderConfig response = client.GetRecommenderConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecommenderConfigAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommenderConfigRequest request = new GetRecommenderConfigRequest
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
            };
            RecommenderConfig expectedResponse = new RecommenderConfig
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
                RecommenderGenerationConfig = new RecommenderGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetRecommenderConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecommenderConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            RecommenderConfig responseCallSettings = await client.GetRecommenderConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecommenderConfig responseCancellationToken = await client.GetRecommenderConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRecommenderConfigResourceNames()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommenderConfigRequest request = new GetRecommenderConfigRequest
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
            };
            RecommenderConfig expectedResponse = new RecommenderConfig
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
                RecommenderGenerationConfig = new RecommenderGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetRecommenderConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            RecommenderConfig response = client.GetRecommenderConfig(request.RecommenderConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecommenderConfigResourceNamesAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetRecommenderConfigRequest request = new GetRecommenderConfigRequest
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
            };
            RecommenderConfig expectedResponse = new RecommenderConfig
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
                RecommenderGenerationConfig = new RecommenderGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetRecommenderConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecommenderConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            RecommenderConfig responseCallSettings = await client.GetRecommenderConfigAsync(request.RecommenderConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecommenderConfig responseCancellationToken = await client.GetRecommenderConfigAsync(request.RecommenderConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRecommenderConfigRequestObject()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            UpdateRecommenderConfigRequest request = new UpdateRecommenderConfigRequest
            {
                RecommenderConfig = new RecommenderConfig(),
                UpdateMask = new wkt::FieldMask(),
                ValidateOnly = true,
            };
            RecommenderConfig expectedResponse = new RecommenderConfig
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
                RecommenderGenerationConfig = new RecommenderGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateRecommenderConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            RecommenderConfig response = client.UpdateRecommenderConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRecommenderConfigRequestObjectAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            UpdateRecommenderConfigRequest request = new UpdateRecommenderConfigRequest
            {
                RecommenderConfig = new RecommenderConfig(),
                UpdateMask = new wkt::FieldMask(),
                ValidateOnly = true,
            };
            RecommenderConfig expectedResponse = new RecommenderConfig
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
                RecommenderGenerationConfig = new RecommenderGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateRecommenderConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecommenderConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            RecommenderConfig responseCallSettings = await client.UpdateRecommenderConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecommenderConfig responseCancellationToken = await client.UpdateRecommenderConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRecommenderConfig()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            UpdateRecommenderConfigRequest request = new UpdateRecommenderConfigRequest
            {
                RecommenderConfig = new RecommenderConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            RecommenderConfig expectedResponse = new RecommenderConfig
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
                RecommenderGenerationConfig = new RecommenderGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateRecommenderConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            RecommenderConfig response = client.UpdateRecommenderConfig(request.RecommenderConfig, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRecommenderConfigAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            UpdateRecommenderConfigRequest request = new UpdateRecommenderConfigRequest
            {
                RecommenderConfig = new RecommenderConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            RecommenderConfig expectedResponse = new RecommenderConfig
            {
                RecommenderConfigName = RecommenderConfigName.FromProjectLocationRecommender("[PROJECT]", "[LOCATION]", "[RECOMMENDER]"),
                RecommenderGenerationConfig = new RecommenderGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateRecommenderConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecommenderConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            RecommenderConfig responseCallSettings = await client.UpdateRecommenderConfigAsync(request.RecommenderConfig, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecommenderConfig responseCancellationToken = await client.UpdateRecommenderConfigAsync(request.RecommenderConfig, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInsightTypeConfigRequestObject()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightTypeConfigRequest request = new GetInsightTypeConfigRequest
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
            };
            InsightTypeConfig expectedResponse = new InsightTypeConfig
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
                InsightTypeGenerationConfig = new InsightTypeGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetInsightTypeConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            InsightTypeConfig response = client.GetInsightTypeConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInsightTypeConfigRequestObjectAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightTypeConfigRequest request = new GetInsightTypeConfigRequest
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
            };
            InsightTypeConfig expectedResponse = new InsightTypeConfig
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
                InsightTypeGenerationConfig = new InsightTypeGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetInsightTypeConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InsightTypeConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            InsightTypeConfig responseCallSettings = await client.GetInsightTypeConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InsightTypeConfig responseCancellationToken = await client.GetInsightTypeConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInsightTypeConfig()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightTypeConfigRequest request = new GetInsightTypeConfigRequest
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
            };
            InsightTypeConfig expectedResponse = new InsightTypeConfig
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
                InsightTypeGenerationConfig = new InsightTypeGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetInsightTypeConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            InsightTypeConfig response = client.GetInsightTypeConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInsightTypeConfigAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightTypeConfigRequest request = new GetInsightTypeConfigRequest
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
            };
            InsightTypeConfig expectedResponse = new InsightTypeConfig
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
                InsightTypeGenerationConfig = new InsightTypeGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetInsightTypeConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InsightTypeConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            InsightTypeConfig responseCallSettings = await client.GetInsightTypeConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InsightTypeConfig responseCancellationToken = await client.GetInsightTypeConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInsightTypeConfigResourceNames()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightTypeConfigRequest request = new GetInsightTypeConfigRequest
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
            };
            InsightTypeConfig expectedResponse = new InsightTypeConfig
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
                InsightTypeGenerationConfig = new InsightTypeGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetInsightTypeConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            InsightTypeConfig response = client.GetInsightTypeConfig(request.InsightTypeConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInsightTypeConfigResourceNamesAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            GetInsightTypeConfigRequest request = new GetInsightTypeConfigRequest
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
            };
            InsightTypeConfig expectedResponse = new InsightTypeConfig
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
                InsightTypeGenerationConfig = new InsightTypeGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetInsightTypeConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InsightTypeConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            InsightTypeConfig responseCallSettings = await client.GetInsightTypeConfigAsync(request.InsightTypeConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InsightTypeConfig responseCancellationToken = await client.GetInsightTypeConfigAsync(request.InsightTypeConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateInsightTypeConfigRequestObject()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            UpdateInsightTypeConfigRequest request = new UpdateInsightTypeConfigRequest
            {
                InsightTypeConfig = new InsightTypeConfig(),
                UpdateMask = new wkt::FieldMask(),
                ValidateOnly = true,
            };
            InsightTypeConfig expectedResponse = new InsightTypeConfig
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
                InsightTypeGenerationConfig = new InsightTypeGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateInsightTypeConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            InsightTypeConfig response = client.UpdateInsightTypeConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateInsightTypeConfigRequestObjectAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            UpdateInsightTypeConfigRequest request = new UpdateInsightTypeConfigRequest
            {
                InsightTypeConfig = new InsightTypeConfig(),
                UpdateMask = new wkt::FieldMask(),
                ValidateOnly = true,
            };
            InsightTypeConfig expectedResponse = new InsightTypeConfig
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
                InsightTypeGenerationConfig = new InsightTypeGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateInsightTypeConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InsightTypeConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            InsightTypeConfig responseCallSettings = await client.UpdateInsightTypeConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InsightTypeConfig responseCancellationToken = await client.UpdateInsightTypeConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateInsightTypeConfig()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            UpdateInsightTypeConfigRequest request = new UpdateInsightTypeConfigRequest
            {
                InsightTypeConfig = new InsightTypeConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            InsightTypeConfig expectedResponse = new InsightTypeConfig
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
                InsightTypeGenerationConfig = new InsightTypeGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateInsightTypeConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            InsightTypeConfig response = client.UpdateInsightTypeConfig(request.InsightTypeConfig, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateInsightTypeConfigAsync()
        {
            moq::Mock<Recommender.RecommenderClient> mockGrpcClient = new moq::Mock<Recommender.RecommenderClient>(moq::MockBehavior.Strict);
            UpdateInsightTypeConfigRequest request = new UpdateInsightTypeConfigRequest
            {
                InsightTypeConfig = new InsightTypeConfig(),
                UpdateMask = new wkt::FieldMask(),
            };
            InsightTypeConfig expectedResponse = new InsightTypeConfig
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
                InsightTypeGenerationConfig = new InsightTypeGenerationConfig(),
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                RevisionId = "revision_id8d9ae05d",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateInsightTypeConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InsightTypeConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommenderClient client = new RecommenderClientImpl(mockGrpcClient.Object, null, null);
            InsightTypeConfig responseCallSettings = await client.UpdateInsightTypeConfigAsync(request.InsightTypeConfig, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InsightTypeConfig responseCancellationToken = await client.UpdateInsightTypeConfigAsync(request.InsightTypeConfig, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
