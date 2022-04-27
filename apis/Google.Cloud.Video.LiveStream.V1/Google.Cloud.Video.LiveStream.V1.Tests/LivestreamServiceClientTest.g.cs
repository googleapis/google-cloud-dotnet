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
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Video.LiveStream.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedLivestreamServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetChannelRequestObject()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetChannelRequest request = new GetChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
            };
            Channel expectedResponse = new Channel
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ActiveInput = "active_inputeb927702",
                Output = new Channel.Types.Output(),
                ElementaryStreams =
                {
                    new ElementaryStream(),
                },
                MuxStreams = { new MuxStream(), },
                Manifests = { new Manifest(), },
                SpriteSheets = { new SpriteSheet(), },
                StreamingState = Channel.Types.StreamingState.Stopped,
                InputAttachments =
                {
                    new InputAttachment(),
                },
                StreamingError = new gr::Status(),
                LogConfig = new LogConfig(),
            };
            mockGrpcClient.Setup(x => x.GetChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Channel response = client.GetChannel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetChannelRequestObjectAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetChannelRequest request = new GetChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
            };
            Channel expectedResponse = new Channel
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ActiveInput = "active_inputeb927702",
                Output = new Channel.Types.Output(),
                ElementaryStreams =
                {
                    new ElementaryStream(),
                },
                MuxStreams = { new MuxStream(), },
                Manifests = { new Manifest(), },
                SpriteSheets = { new SpriteSheet(), },
                StreamingState = Channel.Types.StreamingState.Stopped,
                InputAttachments =
                {
                    new InputAttachment(),
                },
                StreamingError = new gr::Status(),
                LogConfig = new LogConfig(),
            };
            mockGrpcClient.Setup(x => x.GetChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Channel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Channel responseCallSettings = await client.GetChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Channel responseCancellationToken = await client.GetChannelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetChannel()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetChannelRequest request = new GetChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
            };
            Channel expectedResponse = new Channel
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ActiveInput = "active_inputeb927702",
                Output = new Channel.Types.Output(),
                ElementaryStreams =
                {
                    new ElementaryStream(),
                },
                MuxStreams = { new MuxStream(), },
                Manifests = { new Manifest(), },
                SpriteSheets = { new SpriteSheet(), },
                StreamingState = Channel.Types.StreamingState.Stopped,
                InputAttachments =
                {
                    new InputAttachment(),
                },
                StreamingError = new gr::Status(),
                LogConfig = new LogConfig(),
            };
            mockGrpcClient.Setup(x => x.GetChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Channel response = client.GetChannel(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetChannelAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetChannelRequest request = new GetChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
            };
            Channel expectedResponse = new Channel
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ActiveInput = "active_inputeb927702",
                Output = new Channel.Types.Output(),
                ElementaryStreams =
                {
                    new ElementaryStream(),
                },
                MuxStreams = { new MuxStream(), },
                Manifests = { new Manifest(), },
                SpriteSheets = { new SpriteSheet(), },
                StreamingState = Channel.Types.StreamingState.Stopped,
                InputAttachments =
                {
                    new InputAttachment(),
                },
                StreamingError = new gr::Status(),
                LogConfig = new LogConfig(),
            };
            mockGrpcClient.Setup(x => x.GetChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Channel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Channel responseCallSettings = await client.GetChannelAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Channel responseCancellationToken = await client.GetChannelAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetChannelResourceNames()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetChannelRequest request = new GetChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
            };
            Channel expectedResponse = new Channel
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ActiveInput = "active_inputeb927702",
                Output = new Channel.Types.Output(),
                ElementaryStreams =
                {
                    new ElementaryStream(),
                },
                MuxStreams = { new MuxStream(), },
                Manifests = { new Manifest(), },
                SpriteSheets = { new SpriteSheet(), },
                StreamingState = Channel.Types.StreamingState.Stopped,
                InputAttachments =
                {
                    new InputAttachment(),
                },
                StreamingError = new gr::Status(),
                LogConfig = new LogConfig(),
            };
            mockGrpcClient.Setup(x => x.GetChannel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Channel response = client.GetChannel(request.ChannelName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetChannelResourceNamesAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetChannelRequest request = new GetChannelRequest
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
            };
            Channel expectedResponse = new Channel
            {
                ChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ActiveInput = "active_inputeb927702",
                Output = new Channel.Types.Output(),
                ElementaryStreams =
                {
                    new ElementaryStream(),
                },
                MuxStreams = { new MuxStream(), },
                Manifests = { new Manifest(), },
                SpriteSheets = { new SpriteSheet(), },
                StreamingState = Channel.Types.StreamingState.Stopped,
                InputAttachments =
                {
                    new InputAttachment(),
                },
                StreamingError = new gr::Status(),
                LogConfig = new LogConfig(),
            };
            mockGrpcClient.Setup(x => x.GetChannelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Channel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Channel responseCallSettings = await client.GetChannelAsync(request.ChannelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Channel responseCancellationToken = await client.GetChannelAsync(request.ChannelName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInputRequestObject()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInputRequest request = new GetInputRequest
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
            };
            Input expectedResponse = new Input
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = Input.Types.Type.Unspecified,
                Uri = "uri3db70593",
                PreprocessingConfig = new PreprocessingConfig(),
                SecurityRules = new Input.Types.SecurityRule(),
                Tier = Input.Types.Tier.Sd,
                InputStreamProperty = new InputStreamProperty(),
            };
            mockGrpcClient.Setup(x => x.GetInput(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Input response = client.GetInput(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInputRequestObjectAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInputRequest request = new GetInputRequest
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
            };
            Input expectedResponse = new Input
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = Input.Types.Type.Unspecified,
                Uri = "uri3db70593",
                PreprocessingConfig = new PreprocessingConfig(),
                SecurityRules = new Input.Types.SecurityRule(),
                Tier = Input.Types.Tier.Sd,
                InputStreamProperty = new InputStreamProperty(),
            };
            mockGrpcClient.Setup(x => x.GetInputAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Input>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Input responseCallSettings = await client.GetInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Input responseCancellationToken = await client.GetInputAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInput()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInputRequest request = new GetInputRequest
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
            };
            Input expectedResponse = new Input
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = Input.Types.Type.Unspecified,
                Uri = "uri3db70593",
                PreprocessingConfig = new PreprocessingConfig(),
                SecurityRules = new Input.Types.SecurityRule(),
                Tier = Input.Types.Tier.Sd,
                InputStreamProperty = new InputStreamProperty(),
            };
            mockGrpcClient.Setup(x => x.GetInput(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Input response = client.GetInput(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInputAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInputRequest request = new GetInputRequest
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
            };
            Input expectedResponse = new Input
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = Input.Types.Type.Unspecified,
                Uri = "uri3db70593",
                PreprocessingConfig = new PreprocessingConfig(),
                SecurityRules = new Input.Types.SecurityRule(),
                Tier = Input.Types.Tier.Sd,
                InputStreamProperty = new InputStreamProperty(),
            };
            mockGrpcClient.Setup(x => x.GetInputAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Input>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Input responseCallSettings = await client.GetInputAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Input responseCancellationToken = await client.GetInputAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInputResourceNames()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInputRequest request = new GetInputRequest
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
            };
            Input expectedResponse = new Input
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = Input.Types.Type.Unspecified,
                Uri = "uri3db70593",
                PreprocessingConfig = new PreprocessingConfig(),
                SecurityRules = new Input.Types.SecurityRule(),
                Tier = Input.Types.Tier.Sd,
                InputStreamProperty = new InputStreamProperty(),
            };
            mockGrpcClient.Setup(x => x.GetInput(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Input response = client.GetInput(request.InputName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInputResourceNamesAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInputRequest request = new GetInputRequest
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
            };
            Input expectedResponse = new Input
            {
                InputName = InputName.FromProjectLocationInput("[PROJECT]", "[LOCATION]", "[INPUT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Type = Input.Types.Type.Unspecified,
                Uri = "uri3db70593",
                PreprocessingConfig = new PreprocessingConfig(),
                SecurityRules = new Input.Types.SecurityRule(),
                Tier = Input.Types.Tier.Sd,
                InputStreamProperty = new InputStreamProperty(),
            };
            mockGrpcClient.Setup(x => x.GetInputAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Input>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Input responseCallSettings = await client.GetInputAsync(request.InputName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Input responseCancellationToken = await client.GetInputAsync(request.InputName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEventRequestObject()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEventRequest request = new CreateEventRequest
            {
                ParentAsChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                Event = new Event(),
                EventId = "event_idaccf3744",
                RequestId = "request_id362c8df6",
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event response = client.CreateEvent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEventRequestObjectAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEventRequest request = new CreateEventRequest
            {
                ParentAsChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                Event = new Event(),
                EventId = "event_idaccf3744",
                RequestId = "request_id362c8df6",
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Event>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event responseCallSettings = await client.CreateEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Event responseCancellationToken = await client.CreateEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEvent()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEventRequest request = new CreateEventRequest
            {
                ParentAsChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                Event = new Event(),
                EventId = "event_idaccf3744",
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event response = client.CreateEvent(request.Parent, request.Event, request.EventId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEventAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEventRequest request = new CreateEventRequest
            {
                ParentAsChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                Event = new Event(),
                EventId = "event_idaccf3744",
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Event>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event responseCallSettings = await client.CreateEventAsync(request.Parent, request.Event, request.EventId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Event responseCancellationToken = await client.CreateEventAsync(request.Parent, request.Event, request.EventId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEventResourceNames()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEventRequest request = new CreateEventRequest
            {
                ParentAsChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                Event = new Event(),
                EventId = "event_idaccf3744",
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event response = client.CreateEvent(request.ParentAsChannelName, request.Event, request.EventId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEventResourceNamesAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateEventRequest request = new CreateEventRequest
            {
                ParentAsChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                Event = new Event(),
                EventId = "event_idaccf3744",
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.CreateEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Event>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event responseCallSettings = await client.CreateEventAsync(request.ParentAsChannelName, request.Event, request.EventId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Event responseCancellationToken = await client.CreateEventAsync(request.ParentAsChannelName, request.Event, request.EventId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEventRequestObject()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event response = client.GetEvent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEventRequestObjectAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Event>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event responseCallSettings = await client.GetEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Event responseCancellationToken = await client.GetEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEvent()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event response = client.GetEvent(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEventAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Event>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event responseCallSettings = await client.GetEventAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Event responseCancellationToken = await client.GetEventAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEventResourceNames()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event response = client.GetEvent(request.EventName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEventResourceNamesAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            Event expectedResponse = new Event
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AdBreak = new Event.Types.AdBreakTask(),
                ExecuteNow = true,
                ExecutionTime = new wkt::Timestamp(),
                State = Event.Types.State.Stopped,
                Error = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.GetEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Event>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            Event responseCallSettings = await client.GetEventAsync(request.EventName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Event responseCancellationToken = await client.GetEventAsync(request.EventName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEventRequestObject()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEventRequest request = new DeleteEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                RequestId = "request_id362c8df6",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEvent(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEventRequestObjectAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEventRequest request = new DeleteEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
                RequestId = "request_id362c8df6",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEventAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEvent()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEventRequest request = new DeleteEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEvent(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEventAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEventRequest request = new DeleteEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEventAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEventAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEventResourceNames()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEventRequest request = new DeleteEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEvent(request.EventName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEventResourceNamesAsync()
        {
            moq::Mock<LivestreamService.LivestreamServiceClient> mockGrpcClient = new moq::Mock<LivestreamService.LivestreamServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteEventRequest request = new DeleteEventRequest
            {
                EventName = EventName.FromProjectLocationChannelEvent("[PROJECT]", "[LOCATION]", "[CHANNEL]", "[EVENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LivestreamServiceClient client = new LivestreamServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEventAsync(request.EventName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEventAsync(request.EventName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
