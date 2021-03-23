// Copyright 2021 Google LLC
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

using ga = Google.Api;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Monitoring.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedNotificationChannelServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetNotificationChannelDescriptorRequestObject()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
#pragma warning disable CS0612
                SupportedTiers =
#pragma warning restore CS0612
                {
                    ServiceTier.Premium,
                },
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptor response = client.GetNotificationChannelDescriptor(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelDescriptorRequestObjectAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
#pragma warning disable CS0612
                SupportedTiers =
#pragma warning restore CS0612
                {
                    ServiceTier.Premium,
                },
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannelDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptor responseCallSettings = await client.GetNotificationChannelDescriptorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannelDescriptor responseCancellationToken = await client.GetNotificationChannelDescriptorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationChannelDescriptor()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
#pragma warning disable CS0612
                SupportedTiers =
#pragma warning restore CS0612
                {
                    ServiceTier.Premium,
                },
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptor response = client.GetNotificationChannelDescriptor(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelDescriptorAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
#pragma warning disable CS0612
                SupportedTiers =
#pragma warning restore CS0612
                {
                    ServiceTier.Premium,
                },
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannelDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptor responseCallSettings = await client.GetNotificationChannelDescriptorAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannelDescriptor responseCancellationToken = await client.GetNotificationChannelDescriptorAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationChannelDescriptorResourceNames1()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
#pragma warning disable CS0612
                SupportedTiers =
#pragma warning restore CS0612
                {
                    ServiceTier.Premium,
                },
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptor response = client.GetNotificationChannelDescriptor(request.NotificationChannelDescriptorName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelDescriptorResourceNames1Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
#pragma warning disable CS0612
                SupportedTiers =
#pragma warning restore CS0612
                {
                    ServiceTier.Premium,
                },
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannelDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptor responseCallSettings = await client.GetNotificationChannelDescriptorAsync(request.NotificationChannelDescriptorName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannelDescriptor responseCancellationToken = await client.GetNotificationChannelDescriptorAsync(request.NotificationChannelDescriptorName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationChannelDescriptorResourceNames2()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
#pragma warning disable CS0612
                SupportedTiers =
#pragma warning restore CS0612
                {
                    ServiceTier.Premium,
                },
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptor(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptor response = client.GetNotificationChannelDescriptor(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelDescriptorResourceNames2Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelDescriptorRequest request = new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
            };
            NotificationChannelDescriptor expectedResponse = new NotificationChannelDescriptor
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    new ga::LabelDescriptor(),
                },
#pragma warning disable CS0612
                SupportedTiers =
#pragma warning restore CS0612
                {
                    ServiceTier.Premium,
                },
                NotificationChannelDescriptorName = NotificationChannelDescriptorName.FromProjectChannelDescriptor("[PROJECT]", "[CHANNEL_DESCRIPTOR]"),
                LaunchStage = ga::LaunchStage.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelDescriptorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannelDescriptor>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannelDescriptor responseCallSettings = await client.GetNotificationChannelDescriptorAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannelDescriptor responseCancellationToken = await client.GetNotificationChannelDescriptorAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationChannelRequestObject()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.GetNotificationChannel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelRequestObjectAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.GetNotificationChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.GetNotificationChannelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationChannel()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.GetNotificationChannel(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.GetNotificationChannelAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.GetNotificationChannelAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationChannelResourceNames1()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.GetNotificationChannel(request.NotificationChannelName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelResourceNames1Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.GetNotificationChannelAsync(request.NotificationChannelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.GetNotificationChannelAsync(request.NotificationChannelName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationChannelResourceNames2()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.GetNotificationChannel(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelResourceNames2Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelRequest request = new GetNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.GetNotificationChannelAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.GetNotificationChannelAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNotificationChannelRequestObject()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.CreateNotificationChannel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNotificationChannelRequestObjectAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.CreateNotificationChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.CreateNotificationChannelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNotificationChannel()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.CreateNotificationChannel(request.Name, request.NotificationChannel);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNotificationChannelAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.CreateNotificationChannelAsync(request.Name, request.NotificationChannel, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.CreateNotificationChannelAsync(request.Name, request.NotificationChannel, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNotificationChannelResourceNames1()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.CreateNotificationChannel(request.ProjectName, request.NotificationChannel);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNotificationChannelResourceNames1Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.CreateNotificationChannelAsync(request.ProjectName, request.NotificationChannel, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.CreateNotificationChannelAsync(request.ProjectName, request.NotificationChannel, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNotificationChannelResourceNames2()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.CreateNotificationChannel(request.OrganizationName, request.NotificationChannel);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNotificationChannelResourceNames2Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.CreateNotificationChannelAsync(request.OrganizationName, request.NotificationChannel, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.CreateNotificationChannelAsync(request.OrganizationName, request.NotificationChannel, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNotificationChannelResourceNames3()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.CreateNotificationChannel(request.FolderName, request.NotificationChannel);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNotificationChannelResourceNames3Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.CreateNotificationChannelAsync(request.FolderName, request.NotificationChannel, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.CreateNotificationChannelAsync(request.FolderName, request.NotificationChannel, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateNotificationChannelResourceNames4()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.CreateNotificationChannel(request.ResourceName, request.NotificationChannel);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateNotificationChannelResourceNames4Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            CreateNotificationChannelRequest request = new CreateNotificationChannelRequest
            {
                NotificationChannel = new NotificationChannel(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.CreateNotificationChannelAsync(request.ResourceName, request.NotificationChannel, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.CreateNotificationChannelAsync(request.ResourceName, request.NotificationChannel, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNotificationChannelRequestObject()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            UpdateNotificationChannelRequest request = new UpdateNotificationChannelRequest
            {
                UpdateMask = new wkt::FieldMask(),
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.UpdateNotificationChannel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNotificationChannelRequestObjectAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            UpdateNotificationChannelRequest request = new UpdateNotificationChannelRequest
            {
                UpdateMask = new wkt::FieldMask(),
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.UpdateNotificationChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.UpdateNotificationChannelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNotificationChannel()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            UpdateNotificationChannelRequest request = new UpdateNotificationChannelRequest
            {
                UpdateMask = new wkt::FieldMask(),
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.UpdateNotificationChannel(request.UpdateMask, request.NotificationChannel);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNotificationChannelAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            UpdateNotificationChannelRequest request = new UpdateNotificationChannelRequest
            {
                UpdateMask = new wkt::FieldMask(),
                NotificationChannel = new NotificationChannel(),
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.UpdateNotificationChannelAsync(request.UpdateMask, request.NotificationChannel, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.UpdateNotificationChannelAsync(request.UpdateMask, request.NotificationChannel, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNotificationChannelRequestObject()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteNotificationChannel(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNotificationChannelRequestObjectAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNotificationChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNotificationChannelAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNotificationChannel()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteNotificationChannel(request.Name, request.Force);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNotificationChannelAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNotificationChannelAsync(request.Name, request.Force, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNotificationChannelAsync(request.Name, request.Force, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNotificationChannelResourceNames1()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteNotificationChannel(request.NotificationChannelName, request.Force);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNotificationChannelResourceNames1Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNotificationChannelAsync(request.NotificationChannelName, request.Force, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNotificationChannelAsync(request.NotificationChannelName, request.Force, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteNotificationChannelResourceNames2()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteNotificationChannel(request.ResourceName, request.Force);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteNotificationChannelResourceNames2Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            DeleteNotificationChannelRequest request = new DeleteNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNotificationChannelAsync(request.ResourceName, request.Force, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteNotificationChannelAsync(request.ResourceName, request.Force, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendNotificationChannelVerificationCodeRequestObject()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.SendNotificationChannelVerificationCode(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendNotificationChannelVerificationCodeRequestObjectAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.SendNotificationChannelVerificationCodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.SendNotificationChannelVerificationCodeAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendNotificationChannelVerificationCode()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.SendNotificationChannelVerificationCode(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendNotificationChannelVerificationCodeAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.SendNotificationChannelVerificationCodeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.SendNotificationChannelVerificationCodeAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendNotificationChannelVerificationCodeResourceNames1()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.SendNotificationChannelVerificationCode(request.NotificationChannelName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendNotificationChannelVerificationCodeResourceNames1Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.SendNotificationChannelVerificationCodeAsync(request.NotificationChannelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.SendNotificationChannelVerificationCodeAsync(request.NotificationChannelName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendNotificationChannelVerificationCodeResourceNames2()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.SendNotificationChannelVerificationCode(request.ResourceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendNotificationChannelVerificationCodeResourceNames2Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SendNotificationChannelVerificationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.SendNotificationChannelVerificationCodeAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.SendNotificationChannelVerificationCodeAsync(request.ResourceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationChannelVerificationCodeRequestObject()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                ExpireTime = new wkt::Timestamp(),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code946733c1",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            GetNotificationChannelVerificationCodeResponse response = client.GetNotificationChannelVerificationCode(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelVerificationCodeRequestObjectAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                ExpireTime = new wkt::Timestamp(),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code946733c1",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetNotificationChannelVerificationCodeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            GetNotificationChannelVerificationCodeResponse responseCallSettings = await client.GetNotificationChannelVerificationCodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetNotificationChannelVerificationCodeResponse responseCancellationToken = await client.GetNotificationChannelVerificationCodeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationChannelVerificationCode()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code946733c1",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            GetNotificationChannelVerificationCodeResponse response = client.GetNotificationChannelVerificationCode(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelVerificationCodeAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code946733c1",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetNotificationChannelVerificationCodeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            GetNotificationChannelVerificationCodeResponse responseCallSettings = await client.GetNotificationChannelVerificationCodeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetNotificationChannelVerificationCodeResponse responseCancellationToken = await client.GetNotificationChannelVerificationCodeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationChannelVerificationCodeResourceNames1()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code946733c1",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            GetNotificationChannelVerificationCodeResponse response = client.GetNotificationChannelVerificationCode(request.NotificationChannelName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelVerificationCodeResourceNames1Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code946733c1",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetNotificationChannelVerificationCodeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            GetNotificationChannelVerificationCodeResponse responseCallSettings = await client.GetNotificationChannelVerificationCodeAsync(request.NotificationChannelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetNotificationChannelVerificationCodeResponse responseCancellationToken = await client.GetNotificationChannelVerificationCodeAsync(request.NotificationChannelName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNotificationChannelVerificationCodeResourceNames2()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code946733c1",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            GetNotificationChannelVerificationCodeResponse response = client.GetNotificationChannelVerificationCode(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNotificationChannelVerificationCodeResourceNames2Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            GetNotificationChannelVerificationCodeRequest request = new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            GetNotificationChannelVerificationCodeResponse expectedResponse = new GetNotificationChannelVerificationCodeResponse
            {
                Code = "code946733c1",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetNotificationChannelVerificationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetNotificationChannelVerificationCodeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            GetNotificationChannelVerificationCodeResponse responseCallSettings = await client.GetNotificationChannelVerificationCodeAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetNotificationChannelVerificationCodeResponse responseCancellationToken = await client.GetNotificationChannelVerificationCodeAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void VerifyNotificationChannelRequestObject()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code946733c1",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.VerifyNotificationChannel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task VerifyNotificationChannelRequestObjectAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code946733c1",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.VerifyNotificationChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.VerifyNotificationChannelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void VerifyNotificationChannel()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code946733c1",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.VerifyNotificationChannel(request.Name, request.Code);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task VerifyNotificationChannelAsync()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code946733c1",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.VerifyNotificationChannelAsync(request.Name, request.Code, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.VerifyNotificationChannelAsync(request.Name, request.Code, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void VerifyNotificationChannelResourceNames1()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code946733c1",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.VerifyNotificationChannel(request.NotificationChannelName, request.Code);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task VerifyNotificationChannelResourceNames1Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code946733c1",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.VerifyNotificationChannelAsync(request.NotificationChannelName, request.Code, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.VerifyNotificationChannelAsync(request.NotificationChannelName, request.Code, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void VerifyNotificationChannelResourceNames2()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code946733c1",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel response = client.VerifyNotificationChannel(request.ResourceName, request.Code);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task VerifyNotificationChannelResourceNames2Async()
        {
            moq::Mock<NotificationChannelService.NotificationChannelServiceClient> mockGrpcClient = new moq::Mock<NotificationChannelService.NotificationChannelServiceClient>(moq::MockBehavior.Strict);
            VerifyNotificationChannelRequest request = new VerifyNotificationChannelRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                Code = "code946733c1",
            };
            NotificationChannel expectedResponse = new NotificationChannel
            {
                Type = "typee2cc9d59",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VerificationStatus = NotificationChannel.Types.VerificationStatus.Unspecified,
                Enabled = true,
                CreationRecord = new MutationRecord(),
                MutationRecords =
                {
                    new MutationRecord(),
                },
            };
            mockGrpcClient.Setup(x => x.VerifyNotificationChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationChannel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NotificationChannelServiceClient client = new NotificationChannelServiceClientImpl(mockGrpcClient.Object, null);
            NotificationChannel responseCallSettings = await client.VerifyNotificationChannelAsync(request.ResourceName, request.Code, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationChannel responseCancellationToken = await client.VerifyNotificationChannelAsync(request.ResourceName, request.Code, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
