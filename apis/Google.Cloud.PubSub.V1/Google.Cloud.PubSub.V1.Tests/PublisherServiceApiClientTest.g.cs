// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
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

namespace Google.Cloud.PubSub.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedPublisherServiceApiClientTest
    {
        [Fact]
        public void CreateTopicTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient> { DefaultValue = DefaultValue.Mock };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateTopic(It.IsAny<Topic>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName name = new TopicName("[PROJECT]", "[TOPIC]");
            Topic response = client.CreateTopic(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void PublishTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient> { DefaultValue = DefaultValue.Mock };
            PublishResponse expectedResponse = new PublishResponse
            {
                MessageIds = {
                                 "messageIdsElement-744837059",
                             },
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Publish(It.IsAny<PublishRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            IEnumerable<PubsubMessage> messages = new[]
            {
                new PubsubMessage
                {
                    Data = ByteString.CopyFromUtf8("-86"),
                },
            };
            PublishResponse response = client.Publish(topic, messages);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTopicTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient> { DefaultValue = DefaultValue.Mock };
            Topic expectedResponse = new Topic
            {
                TopicName = new TopicName("[PROJECT]", "[TOPIC]"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetTopic(It.IsAny<GetTopicRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            Topic response = client.GetTopic(topic);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTopicTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Publisher.PublisherClient> mockGrpcClient = new Mock<Publisher.PublisherClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteTopic(It.IsAny<DeleteTopicRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            PublisherServiceApiClient client = new PublisherServiceApiClientImpl(mockGrpcClient.Object, null);
            TopicName topic = new TopicName("[PROJECT]", "[TOPIC]");
            client.DeleteTopic(topic);
            mockGrpcClient.VerifyAll();
        }

    }
}
