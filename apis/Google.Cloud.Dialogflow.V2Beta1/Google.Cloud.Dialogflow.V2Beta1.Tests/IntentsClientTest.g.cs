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
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedIntentsClientTest
    {
        [xunit::FactAttribute]
        public void GetIntentRequestObject()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                LanguageCode = "language_code2f6c7160",
                IntentView = IntentView.Unspecified,
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.GetIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.GetIntent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIntentRequestObjectAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                LanguageCode = "language_code2f6c7160",
                IntentView = IntentView.Unspecified,
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.GetIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.GetIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.GetIntentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIntent1()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.GetIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.GetIntent(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIntent1Async()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.GetIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.GetIntentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.GetIntentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIntent1ResourceNames()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.GetIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.GetIntent(request.IntentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIntent1ResourceNamesAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.GetIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.GetIntentAsync(request.IntentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.GetIntentAsync(request.IntentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIntent2()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.GetIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.GetIntent(request.Name, request.LanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIntent2Async()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.GetIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.GetIntentAsync(request.Name, request.LanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.GetIntentAsync(request.Name, request.LanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIntent2ResourceNames()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.GetIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.GetIntent(request.IntentName, request.LanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIntent2ResourceNamesAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.GetIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.GetIntentAsync(request.IntentName, request.LanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.GetIntentAsync(request.IntentName, request.LanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateIntentRequestObject()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
                IntentView = IntentView.Unspecified,
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.CreateIntent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateIntentRequestObjectAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
                IntentView = IntentView.Unspecified,
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.CreateIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.CreateIntentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateIntent1()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.CreateIntent(request.Parent, request.Intent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateIntent1Async()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.CreateIntentAsync(request.Parent, request.Intent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.CreateIntentAsync(request.Parent, request.Intent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateIntent1ResourceNames()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.CreateIntent(request.ParentAsAgentName, request.Intent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateIntent1ResourceNamesAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.CreateIntentAsync(request.ParentAsAgentName, request.Intent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.CreateIntentAsync(request.ParentAsAgentName, request.Intent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateIntent2()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.CreateIntent(request.Parent, request.Intent, request.LanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateIntent2Async()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.CreateIntentAsync(request.Parent, request.Intent, request.LanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.CreateIntentAsync(request.Parent, request.Intent, request.LanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateIntent2ResourceNames()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.CreateIntent(request.ParentAsAgentName, request.Intent, request.LanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateIntent2ResourceNamesAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.CreateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.CreateIntentAsync(request.ParentAsAgentName, request.Intent, request.LanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.CreateIntentAsync(request.ParentAsAgentName, request.Intent, request.LanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIntentRequestObject()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
                IntentView = IntentView.Unspecified,
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.UpdateIntent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIntentRequestObjectAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
                IntentView = IntentView.Unspecified,
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.UpdateIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.UpdateIntentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIntent1()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                UpdateMask = new wkt::FieldMask(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.UpdateIntent(request.Intent, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIntent1Async()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                UpdateMask = new wkt::FieldMask(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.UpdateIntentAsync(request.Intent, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.UpdateIntentAsync(request.Intent, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIntent2()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.UpdateIntent(request.Intent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIntent2Async()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.UpdateIntentAsync(request.Intent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.UpdateIntentAsync(request.Intent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIntent3()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.UpdateIntent(request.Intent, request.LanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIntent3Async()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.UpdateIntentAsync(request.Intent, request.LanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.UpdateIntentAsync(request.Intent, request.LanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIntent4()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent response = client.UpdateIntent(request.Intent, request.LanguageCode, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIntent4Async()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
                DisplayName = "display_name137f65c2",
                Priority = 1546225849,
                IsFallback = true,
#pragma warning disable CS0612
                MlEnabled = true,
#pragma warning restore CS0612
                WebhookState = Intent.Types.WebhookState.Enabled,
                InputContextNames =
                {
                    "input_context_names366dbc09",
                },
                Events = { "events068b9016", },
                TrainingPhrases =
                {
                    new Intent.Types.TrainingPhrase(),
                },
                Action = "action09558c41",
                OutputContexts = { new Context(), },
                ResetContexts = true,
                Parameters =
                {
                    new Intent.Types.Parameter(),
                },
                Messages =
                {
                    new Intent.Types.Message(),
                },
                DefaultResponsePlatforms =
                {
                    Intent.Types.Message.Types.Platform.Kik,
                },
                RootFollowupIntentName = "root_followup_intent_namecebbe1b5",
                ParentFollowupIntentName = "parent_followup_intent_namee3186654",
                FollowupIntentInfo =
                {
                    new Intent.Types.FollowupIntentInfo(),
                },
                MlDisabled = false,
                LiveAgentHandoff = false,
                EndInteraction = false,
            };
            mockGrpcClient.Setup(x => x.UpdateIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Intent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            Intent responseCallSettings = await client.UpdateIntentAsync(request.Intent, request.LanguageCode, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Intent responseCancellationToken = await client.UpdateIntentAsync(request.Intent, request.LanguageCode, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIntentRequestObject()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteIntent(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIntentRequestObjectAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIntentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIntent()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteIntent(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIntentAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteIntentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIntentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIntentResourceNames()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteIntent(request.IntentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIntentResourceNamesAsync()
        {
            moq::Mock<Intents.IntentsClient> mockGrpcClient = new moq::Mock<Intents.IntentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = IntentName.FromProjectIntent("[PROJECT]", "[INTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteIntentAsync(request.IntentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIntentAsync(request.IntentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
