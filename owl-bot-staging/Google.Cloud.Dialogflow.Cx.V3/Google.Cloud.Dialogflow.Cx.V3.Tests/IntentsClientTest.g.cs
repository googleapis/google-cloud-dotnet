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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.Cx.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedIntentsClientTest
    {
        [xunit::FactAttribute]
        public void GetIntentRequestObject()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = client.GetIntent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIntentRequestObjectAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent responseCallSettings = await client.GetIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.GetIntentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIntent()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = client.GetIntent(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIntentAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent responseCallSettings = await client.GetIntentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.GetIntentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIntentResourceNames()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = client.GetIntent(request.IntentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIntentResourceNamesAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent responseCallSettings = await client.GetIntentAsync(request.IntentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.GetIntentAsync(request.IntentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateIntentRequestObject()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = client.CreateIntent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateIntentRequestObjectAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent responseCallSettings = await client.CreateIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.CreateIntentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateIntent()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = client.CreateIntent(request.Parent, request.Intent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateIntentAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent responseCallSettings = await client.CreateIntentAsync(request.Parent, request.Intent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.CreateIntentAsync(request.Parent, request.Intent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateIntentResourceNames()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = client.CreateIntent(request.ParentAsAgentName, request.Intent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateIntentResourceNamesAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.CreateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent responseCallSettings = await client.CreateIntentAsync(request.ParentAsAgentName, request.Intent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.CreateIntentAsync(request.ParentAsAgentName, request.Intent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIntentRequestObject()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = client.UpdateIntent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIntentRequestObjectAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent responseCallSettings = await client.UpdateIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.UpdateIntentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIntent()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                UpdateMask = new wkt::FieldMask(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = client.UpdateIntent(request.Intent, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIntentAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                UpdateMask = new wkt::FieldMask(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Priority = 1546225849,
                IsFallback = true,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.UpdateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent responseCallSettings = await client.UpdateIntentAsync(request.Intent, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.UpdateIntentAsync(request.Intent, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIntentRequestObject()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            client.DeleteIntent(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIntentRequestObjectAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIntentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIntent()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            client.DeleteIntent(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIntentAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIntentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIntentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIntentResourceNames()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            client.DeleteIntent(request.IntentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIntentResourceNamesAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIntentAsync(request.IntentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIntentAsync(request.IntentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
