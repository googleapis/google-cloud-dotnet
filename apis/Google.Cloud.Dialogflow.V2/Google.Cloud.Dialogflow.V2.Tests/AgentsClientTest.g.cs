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
    using Google.Api.Gax.ResourceNames;
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
    public class GeneratedAgentsClientTest
    {
        [Fact]
        public void GetAgent()
        {
            Mock<Agents.AgentsClient> mockGrpcClient = new Mock<Agents.AgentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAgentRequest expectedRequest = new GetAgentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                Parent = "parent21175163357",
                DisplayName = "displayName1615086568",
                DefaultLanguageCode = "defaultLanguageCode856575222",
                TimeZone = "timeZone36848094",
                Description = "description-1724546052",
                AvatarUri = "avatarUri-402824826",
                EnableLogging = false,
                ClassificationThreshold = 1.11581064E8f,
            };
            mockGrpcClient.Setup(x => x.GetAgent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Agent response = client.GetAgent(parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetAgentAsync()
        {
            Mock<Agents.AgentsClient> mockGrpcClient = new Mock<Agents.AgentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAgentRequest expectedRequest = new GetAgentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                Parent = "parent21175163357",
                DisplayName = "displayName1615086568",
                DefaultLanguageCode = "defaultLanguageCode856575222",
                TimeZone = "timeZone36848094",
                Description = "description-1724546052",
                AvatarUri = "avatarUri-402824826",
                EnableLogging = false,
                ClassificationThreshold = 1.11581064E8f,
            };
            mockGrpcClient.Setup(x => x.GetAgentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Agent>(Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Agent response = await client.GetAgentAsync(parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetAgent2()
        {
            Mock<Agents.AgentsClient> mockGrpcClient = new Mock<Agents.AgentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                Parent = "parent21175163357",
                DisplayName = "displayName1615086568",
                DefaultLanguageCode = "defaultLanguageCode856575222",
                TimeZone = "timeZone36848094",
                Description = "description-1724546052",
                AvatarUri = "avatarUri-402824826",
                EnableLogging = false,
                ClassificationThreshold = 1.11581064E8f,
            };
            mockGrpcClient.Setup(x => x.GetAgent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null);
            Agent response = client.GetAgent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetAgentAsync2()
        {
            Mock<Agents.AgentsClient> mockGrpcClient = new Mock<Agents.AgentsClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                Parent = "parent21175163357",
                DisplayName = "displayName1615086568",
                DefaultLanguageCode = "defaultLanguageCode856575222",
                TimeZone = "timeZone36848094",
                Description = "description-1724546052",
                AvatarUri = "avatarUri-402824826",
                EnableLogging = false,
                ClassificationThreshold = 1.11581064E8f,
            };
            mockGrpcClient.Setup(x => x.GetAgentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Agent>(Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null);
            Agent response = await client.GetAgentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
