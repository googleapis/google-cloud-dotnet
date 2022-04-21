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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DataQnA.V1Alpha.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedQuestionServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetQuestionRequestObject()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetQuestionRequest request = new GetQuestionRequest
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                ReadMask = new wkt::FieldMask(),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.GetQuestion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question response = client.GetQuestion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetQuestionRequestObjectAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetQuestionRequest request = new GetQuestionRequest
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                ReadMask = new wkt::FieldMask(),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.GetQuestionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Question>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question responseCallSettings = await client.GetQuestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Question responseCancellationToken = await client.GetQuestionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetQuestion()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetQuestionRequest request = new GetQuestionRequest
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.GetQuestion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question response = client.GetQuestion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetQuestionAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetQuestionRequest request = new GetQuestionRequest
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.GetQuestionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Question>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question responseCallSettings = await client.GetQuestionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Question responseCancellationToken = await client.GetQuestionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetQuestionResourceNames()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetQuestionRequest request = new GetQuestionRequest
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.GetQuestion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question response = client.GetQuestion(request.QuestionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetQuestionResourceNamesAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetQuestionRequest request = new GetQuestionRequest
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.GetQuestionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Question>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question responseCallSettings = await client.GetQuestionAsync(request.QuestionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Question responseCancellationToken = await client.GetQuestionAsync(request.QuestionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateQuestionRequestObject()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            CreateQuestionRequest request = new CreateQuestionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Question = new Question(),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.CreateQuestion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question response = client.CreateQuestion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateQuestionRequestObjectAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            CreateQuestionRequest request = new CreateQuestionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Question = new Question(),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.CreateQuestionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Question>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question responseCallSettings = await client.CreateQuestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Question responseCancellationToken = await client.CreateQuestionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateQuestion()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            CreateQuestionRequest request = new CreateQuestionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Question = new Question(),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.CreateQuestion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question response = client.CreateQuestion(request.Parent, request.Question);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateQuestionAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            CreateQuestionRequest request = new CreateQuestionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Question = new Question(),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.CreateQuestionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Question>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question responseCallSettings = await client.CreateQuestionAsync(request.Parent, request.Question, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Question responseCancellationToken = await client.CreateQuestionAsync(request.Parent, request.Question, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateQuestionResourceNames()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            CreateQuestionRequest request = new CreateQuestionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Question = new Question(),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.CreateQuestion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question response = client.CreateQuestion(request.ParentAsLocationName, request.Question);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateQuestionResourceNamesAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            CreateQuestionRequest request = new CreateQuestionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Question = new Question(),
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.CreateQuestionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Question>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question responseCallSettings = await client.CreateQuestionAsync(request.ParentAsLocationName, request.Question, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Question responseCancellationToken = await client.CreateQuestionAsync(request.ParentAsLocationName, request.Question, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ExecuteQuestionRequestObject()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            ExecuteQuestionRequest request = new ExecuteQuestionRequest
            {
                Name = "name1c9368b0",
                InterpretationIndex = -988014087,
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.ExecuteQuestion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question response = client.ExecuteQuestion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExecuteQuestionRequestObjectAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            ExecuteQuestionRequest request = new ExecuteQuestionRequest
            {
                Name = "name1c9368b0",
                InterpretationIndex = -988014087,
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.ExecuteQuestionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Question>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question responseCallSettings = await client.ExecuteQuestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Question responseCancellationToken = await client.ExecuteQuestionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ExecuteQuestion()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            ExecuteQuestionRequest request = new ExecuteQuestionRequest
            {
                Name = "name1c9368b0",
                InterpretationIndex = -988014087,
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.ExecuteQuestion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question response = client.ExecuteQuestion(request.Name, request.InterpretationIndex);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExecuteQuestionAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            ExecuteQuestionRequest request = new ExecuteQuestionRequest
            {
                Name = "name1c9368b0",
                InterpretationIndex = -988014087,
            };
            Question expectedResponse = new Question
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                DataSourceAnnotations =
                {
                    "data_source_annotationscbcadb22",
                },
                InterpretError = new InterpretError(),
                Interpretations =
                {
                    new Interpretation(),
                },
                CreateTime = new wkt::Timestamp(),
                UserEmail = "user_emaildc7bc240",
                DebugFlags = new DebugFlags(),
                DebugInfo = new wkt::Any(),
            };
            mockGrpcClient.Setup(x => x.ExecuteQuestionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Question>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            Question responseCallSettings = await client.ExecuteQuestionAsync(request.Name, request.InterpretationIndex, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Question responseCancellationToken = await client.ExecuteQuestionAsync(request.Name, request.InterpretationIndex, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUserFeedbackRequestObject()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetUserFeedbackRequest request = new GetUserFeedbackRequest
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            UserFeedback expectedResponse = new UserFeedback
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                FreeFormFeedback = "free_form_feedbackab42f4bb",
                Rating = UserFeedback.Types.UserFeedbackRating.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetUserFeedback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            UserFeedback response = client.GetUserFeedback(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUserFeedbackRequestObjectAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetUserFeedbackRequest request = new GetUserFeedbackRequest
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            UserFeedback expectedResponse = new UserFeedback
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                FreeFormFeedback = "free_form_feedbackab42f4bb",
                Rating = UserFeedback.Types.UserFeedbackRating.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetUserFeedbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserFeedback>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            UserFeedback responseCallSettings = await client.GetUserFeedbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserFeedback responseCancellationToken = await client.GetUserFeedbackAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUserFeedback()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetUserFeedbackRequest request = new GetUserFeedbackRequest
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            UserFeedback expectedResponse = new UserFeedback
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                FreeFormFeedback = "free_form_feedbackab42f4bb",
                Rating = UserFeedback.Types.UserFeedbackRating.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetUserFeedback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            UserFeedback response = client.GetUserFeedback(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUserFeedbackAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetUserFeedbackRequest request = new GetUserFeedbackRequest
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            UserFeedback expectedResponse = new UserFeedback
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                FreeFormFeedback = "free_form_feedbackab42f4bb",
                Rating = UserFeedback.Types.UserFeedbackRating.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetUserFeedbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserFeedback>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            UserFeedback responseCallSettings = await client.GetUserFeedbackAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserFeedback responseCancellationToken = await client.GetUserFeedbackAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUserFeedbackResourceNames()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetUserFeedbackRequest request = new GetUserFeedbackRequest
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            UserFeedback expectedResponse = new UserFeedback
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                FreeFormFeedback = "free_form_feedbackab42f4bb",
                Rating = UserFeedback.Types.UserFeedbackRating.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetUserFeedback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            UserFeedback response = client.GetUserFeedback(request.UserFeedbackName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUserFeedbackResourceNamesAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            GetUserFeedbackRequest request = new GetUserFeedbackRequest
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            UserFeedback expectedResponse = new UserFeedback
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                FreeFormFeedback = "free_form_feedbackab42f4bb",
                Rating = UserFeedback.Types.UserFeedbackRating.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetUserFeedbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserFeedback>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            UserFeedback responseCallSettings = await client.GetUserFeedbackAsync(request.UserFeedbackName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserFeedback responseCancellationToken = await client.GetUserFeedbackAsync(request.UserFeedbackName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateUserFeedbackRequestObject()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            UpdateUserFeedbackRequest request = new UpdateUserFeedbackRequest
            {
                UserFeedback = new UserFeedback(),
                UpdateMask = new wkt::FieldMask(),
            };
            UserFeedback expectedResponse = new UserFeedback
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                FreeFormFeedback = "free_form_feedbackab42f4bb",
                Rating = UserFeedback.Types.UserFeedbackRating.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdateUserFeedback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            UserFeedback response = client.UpdateUserFeedback(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateUserFeedbackRequestObjectAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            UpdateUserFeedbackRequest request = new UpdateUserFeedbackRequest
            {
                UserFeedback = new UserFeedback(),
                UpdateMask = new wkt::FieldMask(),
            };
            UserFeedback expectedResponse = new UserFeedback
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                FreeFormFeedback = "free_form_feedbackab42f4bb",
                Rating = UserFeedback.Types.UserFeedbackRating.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdateUserFeedbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserFeedback>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            UserFeedback responseCallSettings = await client.UpdateUserFeedbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserFeedback responseCancellationToken = await client.UpdateUserFeedbackAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateUserFeedback()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            UpdateUserFeedbackRequest request = new UpdateUserFeedbackRequest
            {
                UserFeedback = new UserFeedback(),
                UpdateMask = new wkt::FieldMask(),
            };
            UserFeedback expectedResponse = new UserFeedback
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                FreeFormFeedback = "free_form_feedbackab42f4bb",
                Rating = UserFeedback.Types.UserFeedbackRating.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdateUserFeedback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            UserFeedback response = client.UpdateUserFeedback(request.UserFeedback, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateUserFeedbackAsync()
        {
            moq::Mock<QuestionService.QuestionServiceClient> mockGrpcClient = new moq::Mock<QuestionService.QuestionServiceClient>(moq::MockBehavior.Strict);
            UpdateUserFeedbackRequest request = new UpdateUserFeedbackRequest
            {
                UserFeedback = new UserFeedback(),
                UpdateMask = new wkt::FieldMask(),
            };
            UserFeedback expectedResponse = new UserFeedback
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                FreeFormFeedback = "free_form_feedbackab42f4bb",
                Rating = UserFeedback.Types.UserFeedbackRating.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdateUserFeedbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserFeedback>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuestionServiceClient client = new QuestionServiceClientImpl(mockGrpcClient.Object, null, null);
            UserFeedback responseCallSettings = await client.UpdateUserFeedbackAsync(request.UserFeedback, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserFeedback responseCancellationToken = await client.UpdateUserFeedbackAsync(request.UserFeedback, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
