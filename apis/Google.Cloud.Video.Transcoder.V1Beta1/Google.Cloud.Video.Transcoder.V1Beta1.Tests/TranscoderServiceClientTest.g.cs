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

using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Video.Transcoder.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTranscoderServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateJobRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                    InputUri = "input_uriec9462a7",
                    OutputUri = "output_urice759a4d",
                    TemplateId = "template_id6435f574",
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Priority = 1546225849,
                    OriginUri = new Job.Types.OriginUri
                    {
                        Hls = "hls417d516b",
                        Dash = "dashc3a799b9",
                    },
                    State = Job.Types.ProcessingState.Succeeded,
                    Progress = new Progress
                    {
                        Analyzed = -40208054787815450,
                        Encoded = -2.5369225662121213E+17,
                        Uploaded = 6.7157903366413E+17,
                        Notified = 1.0199682236791959E+18,
                    },
                    FailureReason = "failure_reasonb933af24",
                    FailureDetails =
                    {
                        new FailureDetail
                        {
                            Description = "description2cf9da67",
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                    InputUri = "input_uriec9462a7",
                    OutputUri = "output_urice759a4d",
                    TemplateId = "template_id6435f574",
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Priority = 1546225849,
                    OriginUri = new Job.Types.OriginUri
                    {
                        Hls = "hls417d516b",
                        Dash = "dashc3a799b9",
                    },
                    State = Job.Types.ProcessingState.Succeeded,
                    Progress = new Progress
                    {
                        Analyzed = -40208054787815450,
                        Encoded = -2.5369225662121213E+17,
                        Uploaded = 6.7157903366413E+17,
                        Notified = 1.0199682236791959E+18,
                    },
                    FailureReason = "failure_reasonb933af24",
                    FailureDetails =
                    {
                        new FailureDetail
                        {
                            Description = "description2cf9da67",
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJob()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                    InputUri = "input_uriec9462a7",
                    OutputUri = "output_urice759a4d",
                    TemplateId = "template_id6435f574",
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Priority = 1546225849,
                    OriginUri = new Job.Types.OriginUri
                    {
                        Hls = "hls417d516b",
                        Dash = "dashc3a799b9",
                    },
                    State = Job.Types.ProcessingState.Succeeded,
                    Progress = new Progress
                    {
                        Analyzed = -40208054787815450,
                        Encoded = -2.5369225662121213E+17,
                        Uploaded = 6.7157903366413E+17,
                        Notified = 1.0199682236791959E+18,
                    },
                    FailureReason = "failure_reasonb933af24",
                    FailureDetails =
                    {
                        new FailureDetail
                        {
                            Description = "description2cf9da67",
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.Parent, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                    InputUri = "input_uriec9462a7",
                    OutputUri = "output_urice759a4d",
                    TemplateId = "template_id6435f574",
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Priority = 1546225849,
                    OriginUri = new Job.Types.OriginUri
                    {
                        Hls = "hls417d516b",
                        Dash = "dashc3a799b9",
                    },
                    State = Job.Types.ProcessingState.Succeeded,
                    Progress = new Progress
                    {
                        Analyzed = -40208054787815450,
                        Encoded = -2.5369225662121213E+17,
                        Uploaded = 6.7157903366413E+17,
                        Notified = 1.0199682236791959E+18,
                    },
                    FailureReason = "failure_reasonb933af24",
                    FailureDetails =
                    {
                        new FailureDetail
                        {
                            Description = "description2cf9da67",
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.Parent, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.Parent, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                    InputUri = "input_uriec9462a7",
                    OutputUri = "output_urice759a4d",
                    TemplateId = "template_id6435f574",
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Priority = 1546225849,
                    OriginUri = new Job.Types.OriginUri
                    {
                        Hls = "hls417d516b",
                        Dash = "dashc3a799b9",
                    },
                    State = Job.Types.ProcessingState.Succeeded,
                    Progress = new Progress
                    {
                        Analyzed = -40208054787815450,
                        Encoded = -2.5369225662121213E+17,
                        Uploaded = 6.7157903366413E+17,
                        Notified = 1.0199682236791959E+18,
                    },
                    FailureReason = "failure_reasonb933af24",
                    FailureDetails =
                    {
                        new FailureDetail
                        {
                            Description = "description2cf9da67",
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.ParentAsLocationName, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                    InputUri = "input_uriec9462a7",
                    OutputUri = "output_urice759a4d",
                    TemplateId = "template_id6435f574",
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                    Priority = 1546225849,
                    OriginUri = new Job.Types.OriginUri
                    {
                        Hls = "hls417d516b",
                        Dash = "dashc3a799b9",
                    },
                    State = Job.Types.ProcessingState.Succeeded,
                    Progress = new Progress
                    {
                        Analyzed = -40208054787815450,
                        Encoded = -2.5369225662121213E+17,
                        Uploaded = 6.7157903366413E+17,
                        Notified = 1.0199682236791959E+18,
                    },
                    FailureReason = "failure_reasonb933af24",
                    FailureDetails =
                    {
                        new FailureDetail
                        {
                            Description = "description2cf9da67",
                        },
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.ParentAsLocationName, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.ParentAsLocationName, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJob()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request.JobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                InputUri = "input_uriec9462a7",
                OutputUri = "output_urice759a4d",
                TemplateId = "template_id6435f574",
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                Priority = 1546225849,
                OriginUri = new Job.Types.OriginUri
                {
                    Hls = "hls417d516b",
                    Dash = "dashc3a799b9",
                },
                State = Job.Types.ProcessingState.Succeeded,
                Progress = new Progress
                {
                    Analyzed = -40208054787815450,
                    Encoded = -2.5369225662121213E+17,
                    Uploaded = 6.7157903366413E+17,
                    Notified = 1.0199682236791959E+18,
                },
                FailureReason = "failure_reasonb933af24",
                FailureDetails =
                {
                    new FailureDetail
                    {
                        Description = "description2cf9da67",
                    },
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.JobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJob()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request.JobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request.JobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobTemplateRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate
                {
                    JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.CreateJobTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobTemplateRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate
                {
                    JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.CreateJobTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.CreateJobTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobTemplate()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate
                {
                    JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.CreateJobTemplate(request.Parent, request.JobTemplate, request.JobTemplateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobTemplateAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate
                {
                    JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.CreateJobTemplateAsync(request.Parent, request.JobTemplate, request.JobTemplateId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.CreateJobTemplateAsync(request.Parent, request.JobTemplate, request.JobTemplateId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobTemplateResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate
                {
                    JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.CreateJobTemplate(request.ParentAsLocationName, request.JobTemplate, request.JobTemplateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobTemplateResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate
                {
                    JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                    Config = new JobConfig
                    {
                        Inputs =
                        {
                            new Input
                            {
                                Key = "key8a0b6e3c",
                                Uri = "uri3db70593",
                                PreprocessingConfig = new PreprocessingConfig
                                {
                                    Color = new PreprocessingConfig.Types.Color
                                    {
                                        Saturation = 1.0610209803855252E+18,
                                        Contrast = -3.1572143051787475E+17,
                                        Brightness = 3.444089950256697E+17,
                                    },
                                    Denoise = new PreprocessingConfig.Types.Denoise
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Tune = "tune9468e17c",
                                    },
                                    Deblock = new PreprocessingConfig.Types.Deblock
                                    {
                                        Strength = -7.831029901542566E+17,
                                        Enabled = true,
                                    },
                                    Audio = new PreprocessingConfig.Types.Audio
                                    {
                                        Lufs = -9.460867282568658E+17,
                                        HighBoost = true,
                                        LowBoost = false,
                                    },
                                },
                            },
                        },
                        EditList =
                        {
                            new EditAtom
                            {
                                Key = "key8a0b6e3c",
                                Inputs = { "inputs67f9afa8", },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        ElementaryStreams =
                        {
                            new ElementaryStream
                            {
                                VideoStream = new VideoStream
                                {
                                    Codec = "codec64cb0d6f",
                                    Profile = "profile1b48977d",
                                    Tune = "tune9468e17c",
                                    Preset = "presetb3d35dd1",
                                    HeightPixels = 1227270303,
                                    WidthPixels = 654228257,
                                    PixelFormat = "pixel_format4cc45806",
                                    BitrateBps = -1023292117,
                                    RateControlMode = "rate_control_modef775cd90",
                                    EnableTwoPass = false,
                                    CrfLevel = -1080275429,
                                    VbvSizeBits = -722075892,
                                    VbvFullnessBits = 769124432,
                                    AllowOpenGop = false,
                                    GopFrameCount = 625883926,
                                    GopDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    EntropyCoder = "entropy_coder596b357b",
                                    BPyramid = true,
                                    BFrameCount = -1119033066,
                                    FrameRate = 2.559168479117898E+17,
                                    AqStrength = -2.9559583429686483E+17,
                                },
                                AudioStream = new AudioStream
                                {
                                    Codec = "codec64cb0d6f",
                                    BitrateBps = -1023292117,
                                    ChannelCount = 613767397,
                                    ChannelLayout =
                                    {
                                        "channel_layout9f5b73bc",
                                    },
                                    Mapping =
                                    {
                                        new AudioStream.Types.AudioAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Channels =
                                            {
                                                new AudioStream.Types.AudioAtom.Types.AudioChannel
                                                {
                                                    Inputs =
                                                    {
                                                        new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                        {
                                                            Key = "key8a0b6e3c",
                                                            Track = -1312322506,
                                                            Channel = -304970300,
                                                            GainDb = 7.377894204596698E+17,
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                    SampleRateHertz = -1305662007,
                                },
                                TextStream = new TextStream
                                {
                                    Codec = "codec64cb0d6f",
                                    LanguageCode = "language_code2f6c7160",
                                    Mapping =
                                    {
                                        new TextStream.Types.TextAtom
                                        {
                                            Key = "key8a0b6e3c",
                                            Inputs =
                                            {
                                                new TextStream.Types.TextAtom.Types.TextInput
                                                {
                                                    Key = "key8a0b6e3c",
                                                    Track = -1312322506,
                                                },
                                            },
                                        },
                                    },
                                },
                                Key = "key8a0b6e3c",
                            },
                        },
                        MuxStreams =
                        {
                            new MuxStream
                            {
                                Key = "key8a0b6e3c",
                                FileName = "file_name88ad9030",
                                Container = "containerbc6e0b5f",
                                ElementaryStreams =
                                {
                                    "elementary_streams43f4aff8",
                                },
                                SegmentSettings = new SegmentSettings
                                {
                                    SegmentDuration = new wkt::Duration
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    IndividualSegments = true,
                                },
                                Encryption = new Encryption
                                {
                                    Key = "key8a0b6e3c",
                                    Iv = "iv2d3bb5f0",
                                    Aes128 = new Encryption.Types.Aes128Encryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    SampleAes = new Encryption.Types.SampleAesEncryption
                                    {
                                        KeyUri = "key_uribcabf666",
                                    },
                                    MpegCenc = new Encryption.Types.MpegCommonEncryption
                                    {
                                        KeyId = "key_id2691f630",
                                        Scheme = "scheme17393241",
                                    },
                                },
                            },
                        },
                        Manifests =
                        {
                            new Manifest
                            {
                                FileName = "file_name88ad9030",
                                Type = Manifest.Types.ManifestType.Unspecified,
                                MuxStreams =
                                {
                                    "mux_streams70055637",
                                },
                            },
                        },
                        Output = new Output { Uri = "uri3db70593", },
                        AdBreaks =
                        {
                            new AdBreak
                            {
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        PubsubDestination = new PubsubDestination
                        {
                            Topic = "topicac689b9d",
                        },
                        SpriteSheets =
                        {
                            new SpriteSheet
                            {
                                Format = "format2ab9dc1d",
                                FilePrefix = "file_prefix2c4935ea",
                                SpriteWidthPixels = -1630794554,
                                SpriteHeightPixels = 201588428,
                                ColumnCount = -1836018183,
                                RowCount = 743251772,
                                StartTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EndTimeOffset = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                TotalCount = 52314676,
                                Interval = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                            },
                        },
                        Overlays =
                        {
                            new Overlay
                            {
                                Image = new Overlay.Types.Image
                                {
                                    Uri = "uri3db70593",
                                    Resolution = new Overlay.Types.NormalizedCoordinate
                                    {
                                        X = 4.728972229337811E+17,
                                        Y = 1.285841168201181E+17,
                                    },
                                    Alpha = -5.821187609512911E+17,
                                },
                                Animations =
                                {
                                    new Overlay.Types.Animation
                                    {
                                        AnimationStatic = new Overlay.Types.AnimationStatic
                                        {
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationFade = new Overlay.Types.AnimationFade
                                        {
                                            FadeType = Overlay.Types.FadeType.FadeIn,
                                            Xy = new Overlay.Types.NormalizedCoordinate
                                            {
                                                X = 4.728972229337811E+17,
                                                Y = 1.285841168201181E+17,
                                            },
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                            EndTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        AnimationEnd = new Overlay.Types.AnimationEnd
                                        {
                                            StartTimeOffset = new wkt::Duration
                                            {
                                                Seconds = -2106654494186127752L,
                                                Nanos = 985689544,
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                JobTemplateId = "job_template_id7acfca7e",
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.CreateJobTemplateAsync(request.ParentAsLocationName, request.JobTemplate, request.JobTemplateId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.CreateJobTemplateAsync(request.ParentAsLocationName, request.JobTemplate, request.JobTemplateId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobTemplateRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.GetJobTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobTemplateRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.GetJobTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.GetJobTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobTemplate()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.GetJobTemplate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobTemplateAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.GetJobTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.GetJobTemplateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobTemplateResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate response = client.GetJobTemplate(request.JobTemplateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobTemplateResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            JobTemplate expectedResponse = new JobTemplate
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                Config = new JobConfig
                {
                    Inputs =
                    {
                        new Input
                        {
                            Key = "key8a0b6e3c",
                            Uri = "uri3db70593",
                            PreprocessingConfig = new PreprocessingConfig
                            {
                                Color = new PreprocessingConfig.Types.Color
                                {
                                    Saturation = 1.0610209803855252E+18,
                                    Contrast = -3.1572143051787475E+17,
                                    Brightness = 3.444089950256697E+17,
                                },
                                Denoise = new PreprocessingConfig.Types.Denoise
                                {
                                    Strength = -7.831029901542566E+17,
                                    Tune = "tune9468e17c",
                                },
                                Deblock = new PreprocessingConfig.Types.Deblock
                                {
                                    Strength = -7.831029901542566E+17,
                                    Enabled = true,
                                },
                                Audio = new PreprocessingConfig.Types.Audio
                                {
                                    Lufs = -9.460867282568658E+17,
                                    HighBoost = true,
                                    LowBoost = false,
                                },
                            },
                        },
                    },
                    EditList =
                    {
                        new EditAtom
                        {
                            Key = "key8a0b6e3c",
                            Inputs = { "inputs67f9afa8", },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    ElementaryStreams =
                    {
                        new ElementaryStream
                        {
                            VideoStream = new VideoStream
                            {
                                Codec = "codec64cb0d6f",
                                Profile = "profile1b48977d",
                                Tune = "tune9468e17c",
                                Preset = "presetb3d35dd1",
                                HeightPixels = 1227270303,
                                WidthPixels = 654228257,
                                PixelFormat = "pixel_format4cc45806",
                                BitrateBps = -1023292117,
                                RateControlMode = "rate_control_modef775cd90",
                                EnableTwoPass = false,
                                CrfLevel = -1080275429,
                                VbvSizeBits = -722075892,
                                VbvFullnessBits = 769124432,
                                AllowOpenGop = false,
                                GopFrameCount = 625883926,
                                GopDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                EntropyCoder = "entropy_coder596b357b",
                                BPyramid = true,
                                BFrameCount = -1119033066,
                                FrameRate = 2.559168479117898E+17,
                                AqStrength = -2.9559583429686483E+17,
                            },
                            AudioStream = new AudioStream
                            {
                                Codec = "codec64cb0d6f",
                                BitrateBps = -1023292117,
                                ChannelCount = 613767397,
                                ChannelLayout =
                                {
                                    "channel_layout9f5b73bc",
                                },
                                Mapping =
                                {
                                    new AudioStream.Types.AudioAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Channels =
                                        {
                                            new AudioStream.Types.AudioAtom.Types.AudioChannel
                                            {
                                                Inputs =
                                                {
                                                    new AudioStream.Types.AudioAtom.Types.AudioChannel.Types.AudioChannelInput
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Track = -1312322506,
                                                        Channel = -304970300,
                                                        GainDb = 7.377894204596698E+17,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                SampleRateHertz = -1305662007,
                            },
                            TextStream = new TextStream
                            {
                                Codec = "codec64cb0d6f",
                                LanguageCode = "language_code2f6c7160",
                                Mapping =
                                {
                                    new TextStream.Types.TextAtom
                                    {
                                        Key = "key8a0b6e3c",
                                        Inputs =
                                        {
                                            new TextStream.Types.TextAtom.Types.TextInput
                                            {
                                                Key = "key8a0b6e3c",
                                                Track = -1312322506,
                                            },
                                        },
                                    },
                                },
                            },
                            Key = "key8a0b6e3c",
                        },
                    },
                    MuxStreams =
                    {
                        new MuxStream
                        {
                            Key = "key8a0b6e3c",
                            FileName = "file_name88ad9030",
                            Container = "containerbc6e0b5f",
                            ElementaryStreams =
                            {
                                "elementary_streams43f4aff8",
                            },
                            SegmentSettings = new SegmentSettings
                            {
                                SegmentDuration = new wkt::Duration
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                IndividualSegments = true,
                            },
                            Encryption = new Encryption
                            {
                                Key = "key8a0b6e3c",
                                Iv = "iv2d3bb5f0",
                                Aes128 = new Encryption.Types.Aes128Encryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                SampleAes = new Encryption.Types.SampleAesEncryption
                                {
                                    KeyUri = "key_uribcabf666",
                                },
                                MpegCenc = new Encryption.Types.MpegCommonEncryption
                                {
                                    KeyId = "key_id2691f630",
                                    Scheme = "scheme17393241",
                                },
                            },
                        },
                    },
                    Manifests =
                    {
                        new Manifest
                        {
                            FileName = "file_name88ad9030",
                            Type = Manifest.Types.ManifestType.Unspecified,
                            MuxStreams =
                            {
                                "mux_streams70055637",
                            },
                        },
                    },
                    Output = new Output { Uri = "uri3db70593", },
                    AdBreaks =
                    {
                        new AdBreak
                        {
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    PubsubDestination = new PubsubDestination
                    {
                        Topic = "topicac689b9d",
                    },
                    SpriteSheets =
                    {
                        new SpriteSheet
                        {
                            Format = "format2ab9dc1d",
                            FilePrefix = "file_prefix2c4935ea",
                            SpriteWidthPixels = -1630794554,
                            SpriteHeightPixels = 201588428,
                            ColumnCount = -1836018183,
                            RowCount = 743251772,
                            StartTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            EndTimeOffset = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            TotalCount = 52314676,
                            Interval = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    Overlays =
                    {
                        new Overlay
                        {
                            Image = new Overlay.Types.Image
                            {
                                Uri = "uri3db70593",
                                Resolution = new Overlay.Types.NormalizedCoordinate
                                {
                                    X = 4.728972229337811E+17,
                                    Y = 1.285841168201181E+17,
                                },
                                Alpha = -5.821187609512911E+17,
                            },
                            Animations =
                            {
                                new Overlay.Types.Animation
                                {
                                    AnimationStatic = new Overlay.Types.AnimationStatic
                                    {
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationFade = new Overlay.Types.AnimationFade
                                    {
                                        FadeType = Overlay.Types.FadeType.FadeIn,
                                        Xy = new Overlay.Types.NormalizedCoordinate
                                        {
                                            X = 4.728972229337811E+17,
                                            Y = 1.285841168201181E+17,
                                        },
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                    AnimationEnd = new Overlay.Types.AnimationEnd
                                    {
                                        StartTimeOffset = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobTemplate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            JobTemplate responseCallSettings = await client.GetJobTemplateAsync(request.JobTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobTemplate responseCancellationToken = await client.GetJobTemplateAsync(request.JobTemplateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobTemplateRequestObject()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJobTemplate(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobTemplateRequestObjectAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobTemplateAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobTemplate()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJobTemplate(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobTemplateAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobTemplateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobTemplateAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobTemplateResourceNames()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJobTemplate(request.JobTemplateName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobTemplateResourceNamesAsync()
        {
            moq::Mock<TranscoderService.TranscoderServiceClient> mockGrpcClient = new moq::Mock<TranscoderService.TranscoderServiceClient>(moq::MockBehavior.Strict);
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranscoderServiceClient client = new TranscoderServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobTemplateAsync(request.JobTemplateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobTemplateAsync(request.JobTemplateName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
