// Copyright 2019 Google LLC
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

namespace Google.Cloud.Dialogflow.V2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedIntentsClientTest
    {
        [Fact]
        public void GetIntent()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIntentRequest expectedRequest = new GetIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.GetIntent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            Intent response = client.GetIntent(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIntentAsync()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIntentRequest expectedRequest = new GetIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.GetIntentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Intent>(Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            Intent response = await client.GetIntentAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIntent2()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIntentRequest expectedRequest = new GetIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                LanguageCode = "languageCode-412800396",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.GetIntent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            string languageCode = "languageCode-412800396";
            Intent response = client.GetIntent(name, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIntentAsync2()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIntentRequest expectedRequest = new GetIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                LanguageCode = "languageCode-412800396",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.GetIntentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Intent>(Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            string languageCode = "languageCode-412800396";
            Intent response = await client.GetIntentAsync(name, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIntent3()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.GetIntent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = client.GetIntent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIntentAsync3()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIntentRequest request = new GetIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.GetIntentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Intent>(Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = await client.GetIntentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateIntent()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateIntentRequest expectedRequest = new CreateIntentRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.CreateIntent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            Intent intent = new Intent();
            Intent response = client.CreateIntent(parent, intent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateIntentAsync()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateIntentRequest expectedRequest = new CreateIntentRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.CreateIntentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Intent>(Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            Intent intent = new Intent();
            Intent response = await client.CreateIntentAsync(parent, intent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateIntent2()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateIntentRequest expectedRequest = new CreateIntentRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                Intent = new Intent(),
                LanguageCode = "languageCode-412800396",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.CreateIntent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            Intent intent = new Intent();
            string languageCode = "languageCode-412800396";
            Intent response = client.CreateIntent(parent, intent, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateIntentAsync2()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateIntentRequest expectedRequest = new CreateIntentRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                Intent = new Intent(),
                LanguageCode = "languageCode-412800396",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.CreateIntentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Intent>(Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            Intent intent = new Intent();
            string languageCode = "languageCode-412800396";
            Intent response = await client.CreateIntentAsync(parent, intent, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateIntent3()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.CreateIntent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = client.CreateIntent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateIntentAsync3()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateIntentRequest request = new CreateIntentRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                Intent = new Intent(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.CreateIntentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Intent>(Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = await client.CreateIntentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateIntent()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateIntentRequest expectedRequest = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "languageCode-412800396",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.UpdateIntent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent intent = new Intent();
            string languageCode = "languageCode-412800396";
            Intent response = client.UpdateIntent(intent, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateIntentAsync()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateIntentRequest expectedRequest = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "languageCode-412800396",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.UpdateIntentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Intent>(Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent intent = new Intent();
            string languageCode = "languageCode-412800396";
            Intent response = await client.UpdateIntentAsync(intent, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateIntent2()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateIntentRequest expectedRequest = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "languageCode-412800396",
                UpdateMask = new FieldMask(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.UpdateIntent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent intent = new Intent();
            string languageCode = "languageCode-412800396";
            FieldMask updateMask = new FieldMask();
            Intent response = client.UpdateIntent(intent, languageCode, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateIntentAsync2()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateIntentRequest expectedRequest = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "languageCode-412800396",
                UpdateMask = new FieldMask(),
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.UpdateIntentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Intent>(Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent intent = new Intent();
            string languageCode = "languageCode-412800396";
            FieldMask updateMask = new FieldMask();
            Intent response = await client.UpdateIntentAsync(intent, languageCode, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateIntent3()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "languageCode-412800396",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.UpdateIntent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = client.UpdateIntent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateIntentAsync3()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateIntentRequest request = new UpdateIntentRequest
            {
                Intent = new Intent(),
                LanguageCode = "languageCode-412800396",
            };
            Intent expectedResponse = new Intent
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
                DisplayName = "displayName1615086568",
                Priority = 1165461084,
                IsFallback = false,
                MlDisabled = true,
                Action = "action-1422950858",
                ResetContexts = true,
                RootFollowupIntentName = "rootFollowupIntentName402253784",
                ParentFollowupIntentName = "parentFollowupIntentName-1131901680",
            };
            mockGrpcClient.Setup(x => x.UpdateIntentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Intent>(Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            Intent response = await client.UpdateIntentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteIntent()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteIntentRequest expectedRequest = new DeleteIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIntent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            client.DeleteIntent(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteIntentAsync()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteIntentRequest expectedRequest = new DeleteIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIntentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            IntentName name = new IntentName("[PROJECT]", "[INTENT]");
            await client.DeleteIntentAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteIntent2()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIntent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            client.DeleteIntent(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteIntentAsync2()
        {
            Mock<Intents.IntentsClient> mockGrpcClient = new Mock<Intents.IntentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteIntentRequest request = new DeleteIntentRequest
            {
                IntentName = new IntentName("[PROJECT]", "[INTENT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIntentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IntentsClient client = new IntentsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIntentAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
