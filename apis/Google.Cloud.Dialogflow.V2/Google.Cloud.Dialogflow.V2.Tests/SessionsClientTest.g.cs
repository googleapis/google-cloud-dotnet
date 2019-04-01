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
    using Google.Protobuf;
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
    public class GeneratedSessionsClientTest
    {
        [Fact]
        public void DetectIntent()
        {
            Mock<Sessions.SessionsClient> mockGrpcClient = new Mock<Sessions.SessionsClient>(MockBehavior.Strict);
            DetectIntentRequest expectedRequest = new DetectIntentRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                QueryInput = new QueryInput(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "responseId1847552473",
                OutputAudio = ByteString.CopyFromUtf8("24"),
            };
            mockGrpcClient.Setup(x => x.DetectIntent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[SESSION]");
            QueryInput queryInput = new QueryInput();
            DetectIntentResponse response = client.DetectIntent(session, queryInput);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DetectIntentAsync()
        {
            Mock<Sessions.SessionsClient> mockGrpcClient = new Mock<Sessions.SessionsClient>(MockBehavior.Strict);
            DetectIntentRequest expectedRequest = new DetectIntentRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                QueryInput = new QueryInput(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "responseId1847552473",
                OutputAudio = ByteString.CopyFromUtf8("24"),
            };
            mockGrpcClient.Setup(x => x.DetectIntentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DetectIntentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[SESSION]");
            QueryInput queryInput = new QueryInput();
            DetectIntentResponse response = await client.DetectIntentAsync(session, queryInput);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DetectIntent2()
        {
            Mock<Sessions.SessionsClient> mockGrpcClient = new Mock<Sessions.SessionsClient>(MockBehavior.Strict);
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                QueryInput = new QueryInput(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "responseId1847552473",
                OutputAudio = ByteString.CopyFromUtf8("24"),
            };
            mockGrpcClient.Setup(x => x.DetectIntent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null);
            DetectIntentResponse response = client.DetectIntent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DetectIntentAsync2()
        {
            Mock<Sessions.SessionsClient> mockGrpcClient = new Mock<Sessions.SessionsClient>(MockBehavior.Strict);
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                QueryInput = new QueryInput(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "responseId1847552473",
                OutputAudio = ByteString.CopyFromUtf8("24"),
            };
            mockGrpcClient.Setup(x => x.DetectIntentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DetectIntentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null);
            DetectIntentResponse response = await client.DetectIntentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
