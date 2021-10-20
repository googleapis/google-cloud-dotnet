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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFeaturestoreOnlineServingServiceClientTest
    {
        [xunit::FactAttribute]
        public void ReadFeatureValuesRequestObject()
        {
            moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient>(moq::MockBehavior.Strict);
            ReadFeatureValuesRequest request = new ReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                EntityId = "entity_id1347fcdf",
                FeatureSelector = new FeatureSelector(),
            };
            ReadFeatureValuesResponse expectedResponse = new ReadFeatureValuesResponse
            {
                Header = new ReadFeatureValuesResponse.Types.Header(),
                EntityView = new ReadFeatureValuesResponse.Types.EntityView(),
            };
            mockGrpcClient.Setup(x => x.ReadFeatureValues(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreOnlineServingServiceClient client = new FeaturestoreOnlineServingServiceClientImpl(mockGrpcClient.Object, null);
            ReadFeatureValuesResponse response = client.ReadFeatureValues(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadFeatureValuesRequestObjectAsync()
        {
            moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient>(moq::MockBehavior.Strict);
            ReadFeatureValuesRequest request = new ReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                EntityId = "entity_id1347fcdf",
                FeatureSelector = new FeatureSelector(),
            };
            ReadFeatureValuesResponse expectedResponse = new ReadFeatureValuesResponse
            {
                Header = new ReadFeatureValuesResponse.Types.Header(),
                EntityView = new ReadFeatureValuesResponse.Types.EntityView(),
            };
            mockGrpcClient.Setup(x => x.ReadFeatureValuesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadFeatureValuesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreOnlineServingServiceClient client = new FeaturestoreOnlineServingServiceClientImpl(mockGrpcClient.Object, null);
            ReadFeatureValuesResponse responseCallSettings = await client.ReadFeatureValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadFeatureValuesResponse responseCancellationToken = await client.ReadFeatureValuesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadFeatureValues()
        {
            moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient>(moq::MockBehavior.Strict);
            ReadFeatureValuesRequest request = new ReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            ReadFeatureValuesResponse expectedResponse = new ReadFeatureValuesResponse
            {
                Header = new ReadFeatureValuesResponse.Types.Header(),
                EntityView = new ReadFeatureValuesResponse.Types.EntityView(),
            };
            mockGrpcClient.Setup(x => x.ReadFeatureValues(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreOnlineServingServiceClient client = new FeaturestoreOnlineServingServiceClientImpl(mockGrpcClient.Object, null);
            ReadFeatureValuesResponse response = client.ReadFeatureValues(request.EntityType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadFeatureValuesAsync()
        {
            moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient>(moq::MockBehavior.Strict);
            ReadFeatureValuesRequest request = new ReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            ReadFeatureValuesResponse expectedResponse = new ReadFeatureValuesResponse
            {
                Header = new ReadFeatureValuesResponse.Types.Header(),
                EntityView = new ReadFeatureValuesResponse.Types.EntityView(),
            };
            mockGrpcClient.Setup(x => x.ReadFeatureValuesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadFeatureValuesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreOnlineServingServiceClient client = new FeaturestoreOnlineServingServiceClientImpl(mockGrpcClient.Object, null);
            ReadFeatureValuesResponse responseCallSettings = await client.ReadFeatureValuesAsync(request.EntityType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadFeatureValuesResponse responseCancellationToken = await client.ReadFeatureValuesAsync(request.EntityType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadFeatureValuesResourceNames()
        {
            moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient>(moq::MockBehavior.Strict);
            ReadFeatureValuesRequest request = new ReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            ReadFeatureValuesResponse expectedResponse = new ReadFeatureValuesResponse
            {
                Header = new ReadFeatureValuesResponse.Types.Header(),
                EntityView = new ReadFeatureValuesResponse.Types.EntityView(),
            };
            mockGrpcClient.Setup(x => x.ReadFeatureValues(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeaturestoreOnlineServingServiceClient client = new FeaturestoreOnlineServingServiceClientImpl(mockGrpcClient.Object, null);
            ReadFeatureValuesResponse response = client.ReadFeatureValues(request.EntityTypeAsEntityTypeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadFeatureValuesResourceNamesAsync()
        {
            moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient> mockGrpcClient = new moq::Mock<FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient>(moq::MockBehavior.Strict);
            ReadFeatureValuesRequest request = new ReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            ReadFeatureValuesResponse expectedResponse = new ReadFeatureValuesResponse
            {
                Header = new ReadFeatureValuesResponse.Types.Header(),
                EntityView = new ReadFeatureValuesResponse.Types.EntityView(),
            };
            mockGrpcClient.Setup(x => x.ReadFeatureValuesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadFeatureValuesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeaturestoreOnlineServingServiceClient client = new FeaturestoreOnlineServingServiceClientImpl(mockGrpcClient.Object, null);
            ReadFeatureValuesResponse responseCallSettings = await client.ReadFeatureValuesAsync(request.EntityTypeAsEntityTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadFeatureValuesResponse responseCancellationToken = await client.ReadFeatureValuesAsync(request.EntityTypeAsEntityTypeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
