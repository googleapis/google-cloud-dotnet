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
using gciv = Google.Cloud.Iam.V1;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.PubSub.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPublisherClientTest
    {
        [xunit::FactAttribute]
        public void CreateTopicRequestObject()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Topic request = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic response = client.CreateTopic(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTopicRequestObjectAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Topic request = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.CreateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.CreateTopicAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTopic()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Topic request = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic response = client.CreateTopic(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTopicAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Topic request = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.CreateTopicAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.CreateTopicAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTopicResourceNames()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Topic request = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic response = client.CreateTopic(request.TopicName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTopicResourceNamesAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            Topic request = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.CreateTopicAsync(request.TopicName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.CreateTopicAsync(request.TopicName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTopicRequestObject()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new wkt::FieldMask(),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic response = client.UpdateTopic(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTopicRequestObjectAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new wkt::FieldMask(),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.UpdateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.UpdateTopicAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PublishRequestObject()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage(),
                },
            };
            PublishResponse expectedResponse = new PublishResponse
            {
                MessageIds =
                {
                    "message_idsbfb136bc",
                },
            };
            mockGrpcClient.Setup(x => x.Publish(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            PublishResponse response = client.Publish(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PublishRequestObjectAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage(),
                },
            };
            PublishResponse expectedResponse = new PublishResponse
            {
                MessageIds =
                {
                    "message_idsbfb136bc",
                },
            };
            mockGrpcClient.Setup(x => x.PublishAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublishResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            PublishResponse responseCallSettings = await client.PublishAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublishResponse responseCancellationToken = await client.PublishAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Publish()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage(),
                },
            };
            PublishResponse expectedResponse = new PublishResponse
            {
                MessageIds =
                {
                    "message_idsbfb136bc",
                },
            };
            mockGrpcClient.Setup(x => x.Publish(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            PublishResponse response = client.Publish(request.Topic, request.Messages);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PublishAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage(),
                },
            };
            PublishResponse expectedResponse = new PublishResponse
            {
                MessageIds =
                {
                    "message_idsbfb136bc",
                },
            };
            mockGrpcClient.Setup(x => x.PublishAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublishResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            PublishResponse responseCallSettings = await client.PublishAsync(request.Topic, request.Messages, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublishResponse responseCancellationToken = await client.PublishAsync(request.Topic, request.Messages, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PublishResourceNames()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage(),
                },
            };
            PublishResponse expectedResponse = new PublishResponse
            {
                MessageIds =
                {
                    "message_idsbfb136bc",
                },
            };
            mockGrpcClient.Setup(x => x.Publish(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            PublishResponse response = client.Publish(request.TopicAsTopicName, request.Messages);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PublishResourceNamesAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Messages =
                {
                    new PubsubMessage(),
                },
            };
            PublishResponse expectedResponse = new PublishResponse
            {
                MessageIds =
                {
                    "message_idsbfb136bc",
                },
            };
            mockGrpcClient.Setup(x => x.PublishAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublishResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            PublishResponse responseCallSettings = await client.PublishAsync(request.TopicAsTopicName, request.Messages, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublishResponse responseCancellationToken = await client.PublishAsync(request.TopicAsTopicName, request.Messages, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTopicRequestObject()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic response = client.GetTopic(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTopicRequestObjectAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.GetTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.GetTopicAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTopic()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic response = client.GetTopic(request.Topic);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTopicAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.GetTopicAsync(request.Topic, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.GetTopicAsync(request.Topic, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTopicResourceNames()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic response = client.GetTopic(request.TopicAsTopicName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTopicResourceNamesAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            Topic expectedResponse = new Topic
            {
                TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                MessageStoragePolicy = new MessageStoragePolicy(),
                KmsKeyName = "kms_key_name06bd122b",
                SchemaSettings = new SchemaSettings(),
                SatisfiesPzs = false,
                MessageRetentionDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Topic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            Topic responseCallSettings = await client.GetTopicAsync(request.TopicAsTopicName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Topic responseCancellationToken = await client.GetTopicAsync(request.TopicAsTopicName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTopicRequestObject()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            client.DeleteTopic(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTopicRequestObjectAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTopicAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTopic()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            client.DeleteTopic(request.Topic);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTopicAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTopicAsync(request.Topic, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTopicAsync(request.Topic, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTopicResourceNames()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            client.DeleteTopic(request.TopicAsTopicName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTopicResourceNamesAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTopicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTopicAsync(request.TopicAsTopicName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTopicAsync(request.TopicAsTopicName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetachSubscriptionRequestObject()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DetachSubscriptionRequest request = new DetachSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            DetachSubscriptionResponse expectedResponse = new DetachSubscriptionResponse { };
            mockGrpcClient.Setup(x => x.DetachSubscription(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            DetachSubscriptionResponse response = client.DetachSubscription(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetachSubscriptionRequestObjectAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DetachSubscriptionRequest request = new DetachSubscriptionRequest
            {
                SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
            };
            DetachSubscriptionResponse expectedResponse = new DetachSubscriptionResponse { };
            mockGrpcClient.Setup(x => x.DetachSubscriptionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DetachSubscriptionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null);
            DetachSubscriptionResponse responseCallSettings = await client.DetachSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DetachSubscriptionResponse responseCancellationToken = await client.DetachSubscriptionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
