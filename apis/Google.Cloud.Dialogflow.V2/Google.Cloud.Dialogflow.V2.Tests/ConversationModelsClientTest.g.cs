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
    public sealed class GeneratedConversationModelsClientTest
    {
        [xunit::FactAttribute]
        public void GetConversationModelRequestObject()
        {
            moq::Mock<ConversationModels.ConversationModelsClient> mockGrpcClient = new moq::Mock<ConversationModels.ConversationModelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationModelRequest request = new GetConversationModelRequest
            {
                Name = "name1c9368b0",
            };
            ConversationModel expectedResponse = new ConversationModel
            {
                ConversationModelName = ConversationModelName.FromProjectLocationConversationModel("[PROJECT]", "[LOCATION]", "[CONVERSATION_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                Datasets = { new InputDataset(), },
                State = ConversationModel.Types.State.Deploying,
                ArticleSuggestionModelMetadata = new ArticleSuggestionModelMetadata(),
                SmartReplyModelMetadata = new SmartReplyModelMetadata(),
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.GetConversationModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationModelsClient client = new ConversationModelsClientImpl(mockGrpcClient.Object, null);
            ConversationModel response = client.GetConversationModel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationModelRequestObjectAsync()
        {
            moq::Mock<ConversationModels.ConversationModelsClient> mockGrpcClient = new moq::Mock<ConversationModels.ConversationModelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationModelRequest request = new GetConversationModelRequest
            {
                Name = "name1c9368b0",
            };
            ConversationModel expectedResponse = new ConversationModel
            {
                ConversationModelName = ConversationModelName.FromProjectLocationConversationModel("[PROJECT]", "[LOCATION]", "[CONVERSATION_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                Datasets = { new InputDataset(), },
                State = ConversationModel.Types.State.Deploying,
                ArticleSuggestionModelMetadata = new ArticleSuggestionModelMetadata(),
                SmartReplyModelMetadata = new SmartReplyModelMetadata(),
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.GetConversationModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationModel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationModelsClient client = new ConversationModelsClientImpl(mockGrpcClient.Object, null);
            ConversationModel responseCallSettings = await client.GetConversationModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationModel responseCancellationToken = await client.GetConversationModelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversationModel()
        {
            moq::Mock<ConversationModels.ConversationModelsClient> mockGrpcClient = new moq::Mock<ConversationModels.ConversationModelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationModelRequest request = new GetConversationModelRequest
            {
                Name = "name1c9368b0",
            };
            ConversationModel expectedResponse = new ConversationModel
            {
                ConversationModelName = ConversationModelName.FromProjectLocationConversationModel("[PROJECT]", "[LOCATION]", "[CONVERSATION_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                Datasets = { new InputDataset(), },
                State = ConversationModel.Types.State.Deploying,
                ArticleSuggestionModelMetadata = new ArticleSuggestionModelMetadata(),
                SmartReplyModelMetadata = new SmartReplyModelMetadata(),
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.GetConversationModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationModelsClient client = new ConversationModelsClientImpl(mockGrpcClient.Object, null);
            ConversationModel response = client.GetConversationModel(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationModelAsync()
        {
            moq::Mock<ConversationModels.ConversationModelsClient> mockGrpcClient = new moq::Mock<ConversationModels.ConversationModelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationModelRequest request = new GetConversationModelRequest
            {
                Name = "name1c9368b0",
            };
            ConversationModel expectedResponse = new ConversationModel
            {
                ConversationModelName = ConversationModelName.FromProjectLocationConversationModel("[PROJECT]", "[LOCATION]", "[CONVERSATION_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                Datasets = { new InputDataset(), },
                State = ConversationModel.Types.State.Deploying,
                ArticleSuggestionModelMetadata = new ArticleSuggestionModelMetadata(),
                SmartReplyModelMetadata = new SmartReplyModelMetadata(),
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.GetConversationModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationModel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationModelsClient client = new ConversationModelsClientImpl(mockGrpcClient.Object, null);
            ConversationModel responseCallSettings = await client.GetConversationModelAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationModel responseCancellationToken = await client.GetConversationModelAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversationModelEvaluationRequestObject()
        {
            moq::Mock<ConversationModels.ConversationModelsClient> mockGrpcClient = new moq::Mock<ConversationModels.ConversationModelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationModelEvaluationRequest request = new GetConversationModelEvaluationRequest
            {
                Name = "name1c9368b0",
            };
            ConversationModelEvaluation expectedResponse = new ConversationModelEvaluation
            {
                ConversationModelEvaluationName = ConversationModelEvaluationName.FromProjectConversationModelEvaluation("[PROJECT]", "[CONVERSATION_MODEL]", "[EVALUATION]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                SmartReplyMetrics = new SmartReplyMetrics(),
                EvaluationConfig = new EvaluationConfig(),
            };
            mockGrpcClient.Setup(x => x.GetConversationModelEvaluation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationModelsClient client = new ConversationModelsClientImpl(mockGrpcClient.Object, null);
            ConversationModelEvaluation response = client.GetConversationModelEvaluation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationModelEvaluationRequestObjectAsync()
        {
            moq::Mock<ConversationModels.ConversationModelsClient> mockGrpcClient = new moq::Mock<ConversationModels.ConversationModelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationModelEvaluationRequest request = new GetConversationModelEvaluationRequest
            {
                Name = "name1c9368b0",
            };
            ConversationModelEvaluation expectedResponse = new ConversationModelEvaluation
            {
                ConversationModelEvaluationName = ConversationModelEvaluationName.FromProjectConversationModelEvaluation("[PROJECT]", "[CONVERSATION_MODEL]", "[EVALUATION]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                SmartReplyMetrics = new SmartReplyMetrics(),
                EvaluationConfig = new EvaluationConfig(),
            };
            mockGrpcClient.Setup(x => x.GetConversationModelEvaluationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationModelEvaluation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationModelsClient client = new ConversationModelsClientImpl(mockGrpcClient.Object, null);
            ConversationModelEvaluation responseCallSettings = await client.GetConversationModelEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationModelEvaluation responseCancellationToken = await client.GetConversationModelEvaluationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversationModelEvaluation()
        {
            moq::Mock<ConversationModels.ConversationModelsClient> mockGrpcClient = new moq::Mock<ConversationModels.ConversationModelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationModelEvaluationRequest request = new GetConversationModelEvaluationRequest
            {
                Name = "name1c9368b0",
            };
            ConversationModelEvaluation expectedResponse = new ConversationModelEvaluation
            {
                ConversationModelEvaluationName = ConversationModelEvaluationName.FromProjectConversationModelEvaluation("[PROJECT]", "[CONVERSATION_MODEL]", "[EVALUATION]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                SmartReplyMetrics = new SmartReplyMetrics(),
                EvaluationConfig = new EvaluationConfig(),
            };
            mockGrpcClient.Setup(x => x.GetConversationModelEvaluation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationModelsClient client = new ConversationModelsClientImpl(mockGrpcClient.Object, null);
            ConversationModelEvaluation response = client.GetConversationModelEvaluation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationModelEvaluationAsync()
        {
            moq::Mock<ConversationModels.ConversationModelsClient> mockGrpcClient = new moq::Mock<ConversationModels.ConversationModelsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationModelEvaluationRequest request = new GetConversationModelEvaluationRequest
            {
                Name = "name1c9368b0",
            };
            ConversationModelEvaluation expectedResponse = new ConversationModelEvaluation
            {
                ConversationModelEvaluationName = ConversationModelEvaluationName.FromProjectConversationModelEvaluation("[PROJECT]", "[CONVERSATION_MODEL]", "[EVALUATION]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                SmartReplyMetrics = new SmartReplyMetrics(),
                EvaluationConfig = new EvaluationConfig(),
            };
            mockGrpcClient.Setup(x => x.GetConversationModelEvaluationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationModelEvaluation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationModelsClient client = new ConversationModelsClientImpl(mockGrpcClient.Object, null);
            ConversationModelEvaluation responseCallSettings = await client.GetConversationModelEvaluationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationModelEvaluation responseCancellationToken = await client.GetConversationModelEvaluationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
