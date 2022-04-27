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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedConversationDatasetsClientTest
    {
        [xunit::FactAttribute]
        public void GetConversationDatasetRequestObject()
        {
            moq::Mock<ConversationDatasets.ConversationDatasetsClient> mockGrpcClient = new moq::Mock<ConversationDatasets.ConversationDatasetsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationDatasetRequest request = new GetConversationDatasetRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
            };
            ConversationDataset expectedResponse = new ConversationDataset
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfig = new InputConfig(),
                ConversationInfo = new ConversationInfo(),
                ConversationCount = 5485630355032729838L,
            };
            mockGrpcClient.Setup(x => x.GetConversationDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationDatasetsClient client = new ConversationDatasetsClientImpl(mockGrpcClient.Object, null, null);
            ConversationDataset response = client.GetConversationDataset(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationDatasetRequestObjectAsync()
        {
            moq::Mock<ConversationDatasets.ConversationDatasetsClient> mockGrpcClient = new moq::Mock<ConversationDatasets.ConversationDatasetsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationDatasetRequest request = new GetConversationDatasetRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
            };
            ConversationDataset expectedResponse = new ConversationDataset
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfig = new InputConfig(),
                ConversationInfo = new ConversationInfo(),
                ConversationCount = 5485630355032729838L,
            };
            mockGrpcClient.Setup(x => x.GetConversationDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationDataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationDatasetsClient client = new ConversationDatasetsClientImpl(mockGrpcClient.Object, null, null);
            ConversationDataset responseCallSettings = await client.GetConversationDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationDataset responseCancellationToken = await client.GetConversationDatasetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversationDataset()
        {
            moq::Mock<ConversationDatasets.ConversationDatasetsClient> mockGrpcClient = new moq::Mock<ConversationDatasets.ConversationDatasetsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationDatasetRequest request = new GetConversationDatasetRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
            };
            ConversationDataset expectedResponse = new ConversationDataset
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfig = new InputConfig(),
                ConversationInfo = new ConversationInfo(),
                ConversationCount = 5485630355032729838L,
            };
            mockGrpcClient.Setup(x => x.GetConversationDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationDatasetsClient client = new ConversationDatasetsClientImpl(mockGrpcClient.Object, null, null);
            ConversationDataset response = client.GetConversationDataset(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationDatasetAsync()
        {
            moq::Mock<ConversationDatasets.ConversationDatasetsClient> mockGrpcClient = new moq::Mock<ConversationDatasets.ConversationDatasetsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationDatasetRequest request = new GetConversationDatasetRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
            };
            ConversationDataset expectedResponse = new ConversationDataset
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfig = new InputConfig(),
                ConversationInfo = new ConversationInfo(),
                ConversationCount = 5485630355032729838L,
            };
            mockGrpcClient.Setup(x => x.GetConversationDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationDataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationDatasetsClient client = new ConversationDatasetsClientImpl(mockGrpcClient.Object, null, null);
            ConversationDataset responseCallSettings = await client.GetConversationDatasetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationDataset responseCancellationToken = await client.GetConversationDatasetAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversationDatasetResourceNames()
        {
            moq::Mock<ConversationDatasets.ConversationDatasetsClient> mockGrpcClient = new moq::Mock<ConversationDatasets.ConversationDatasetsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationDatasetRequest request = new GetConversationDatasetRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
            };
            ConversationDataset expectedResponse = new ConversationDataset
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfig = new InputConfig(),
                ConversationInfo = new ConversationInfo(),
                ConversationCount = 5485630355032729838L,
            };
            mockGrpcClient.Setup(x => x.GetConversationDataset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationDatasetsClient client = new ConversationDatasetsClientImpl(mockGrpcClient.Object, null, null);
            ConversationDataset response = client.GetConversationDataset(request.ConversationDatasetName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationDatasetResourceNamesAsync()
        {
            moq::Mock<ConversationDatasets.ConversationDatasetsClient> mockGrpcClient = new moq::Mock<ConversationDatasets.ConversationDatasetsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationDatasetRequest request = new GetConversationDatasetRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
            };
            ConversationDataset expectedResponse = new ConversationDataset
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                InputConfig = new InputConfig(),
                ConversationInfo = new ConversationInfo(),
                ConversationCount = 5485630355032729838L,
            };
            mockGrpcClient.Setup(x => x.GetConversationDatasetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationDataset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationDatasetsClient client = new ConversationDatasetsClientImpl(mockGrpcClient.Object, null, null);
            ConversationDataset responseCallSettings = await client.GetConversationDatasetAsync(request.ConversationDatasetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationDataset responseCancellationToken = await client.GetConversationDatasetAsync(request.ConversationDatasetName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
