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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Speech.V1P1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSpeechClientTest
    {
        [xunit::FactAttribute]
        public void RecognizeRequestObject()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Amr,
                    SampleRateHertz = -1305662007,
                    LanguageCode = "language_code2f6c7160",
                    MaxAlternatives = 723301600,
                    ProfanityFilter = true,
                    SpeechContexts =
                    {
                        new SpeechContext
                        {
                            Phrases = { "phrases5169195a", },
                            Boost = 7.584708E+17F,
                        },
                    },
                    AudioChannelCount = -1085150807,
                    EnableWordTimeOffsets = false,
                    Metadata = new RecognitionMetadata
                    {
                        InteractionType = RecognitionMetadata.Types.InteractionType.PhoneCall,
                        IndustryNaicsCodeOfAudio = 69741601U,
                        MicrophoneDistance = RecognitionMetadata.Types.MicrophoneDistance.Farfield,
                        OriginalMediaType = RecognitionMetadata.Types.OriginalMediaType.Unspecified,
                        RecordingDeviceType = RecognitionMetadata.Types.RecordingDeviceType.Vehicle,
                        RecordingDeviceName = "recording_device_name4458bc28",
                        OriginalMimeType = "original_mime_type7e1c606e",
#pragma warning disable CS0612
                        ObfuscatedId = -6237003036250521508L,
#pragma warning restore CS0612
                        AudioTopic = "audio_topica78ea2ec",
                    },
                    EnableAutomaticPunctuation = true,
                    EnableSeparateRecognitionPerChannel = false,
                    Model = "model635ef320",
                    UseEnhanced = false,
                    EnableWordConfidence = false,
#pragma warning disable CS0612
                    EnableSpeakerDiarization = true,
                    DiarizationSpeakerCount = -901346833,
#pragma warning restore CS0612
                    AlternativeLanguageCodes =
                    {
                        "alternative_language_codesc303bdc8",
                    },
                    DiarizationConfig = new SpeakerDiarizationConfig
                    {
                        EnableSpeakerDiarization = true,
                        MinSpeakerCount = -1536699080,
                        MaxSpeakerCount = -353144096,
#pragma warning disable CS0612
                        SpeakerTag = 1615278445,
#pragma warning restore CS0612
                    },
                    Adaptation = new SpeechAdaptation
                    {
                        PhraseSets =
                        {
                            new PhraseSet
                            {
                                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                                Phrases =
                                {
                                    new PhraseSet.Types.Phrase
                                    {
                                        Value = "value60c16320",
                                        Boost = 7.584708E+17F,
                                    },
                                },
                                Boost = 7.584708E+17F,
                            },
                        },
                        PhraseSetReferences =
                        {
                            "phrase_set_references7ba122d6",
                        },
                        CustomClasses =
                        {
                            new CustomClass
                            {
                                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                                CustomClassId = "custom_class_idb1fbae50",
                                Items =
                                {
                                    new CustomClass.Types.ClassItem
                                    {
                                        Value = "value60c16320",
                                    },
                                },
                            },
                        },
                    },
                },
                Audio = new RecognitionAudio
                {
                    Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                    Uri = "uri3db70593",
                },
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Results =
                {
                    new SpeechRecognitionResult
                    {
                        Alternatives =
                        {
                            new SpeechRecognitionAlternative
                            {
                                Transcript = "transcript20c5b28b",
                                Confidence = 8.101506E+17F,
                                Words =
                                {
                                    new WordInfo
                                    {
                                        StartTime = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTime = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        Word = "word70187dc4",
                                        Confidence = 8.101506E+17F,
                                        SpeakerTag = 1615278445,
                                    },
                                },
                            },
                        },
                        ChannelTag = 1588685770,
                        LanguageCode = "language_code2f6c7160",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Recognize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognizeResponse response = client.Recognize(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RecognizeRequestObjectAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Amr,
                    SampleRateHertz = -1305662007,
                    LanguageCode = "language_code2f6c7160",
                    MaxAlternatives = 723301600,
                    ProfanityFilter = true,
                    SpeechContexts =
                    {
                        new SpeechContext
                        {
                            Phrases = { "phrases5169195a", },
                            Boost = 7.584708E+17F,
                        },
                    },
                    AudioChannelCount = -1085150807,
                    EnableWordTimeOffsets = false,
                    Metadata = new RecognitionMetadata
                    {
                        InteractionType = RecognitionMetadata.Types.InteractionType.PhoneCall,
                        IndustryNaicsCodeOfAudio = 69741601U,
                        MicrophoneDistance = RecognitionMetadata.Types.MicrophoneDistance.Farfield,
                        OriginalMediaType = RecognitionMetadata.Types.OriginalMediaType.Unspecified,
                        RecordingDeviceType = RecognitionMetadata.Types.RecordingDeviceType.Vehicle,
                        RecordingDeviceName = "recording_device_name4458bc28",
                        OriginalMimeType = "original_mime_type7e1c606e",
#pragma warning disable CS0612
                        ObfuscatedId = -6237003036250521508L,
#pragma warning restore CS0612
                        AudioTopic = "audio_topica78ea2ec",
                    },
                    EnableAutomaticPunctuation = true,
                    EnableSeparateRecognitionPerChannel = false,
                    Model = "model635ef320",
                    UseEnhanced = false,
                    EnableWordConfidence = false,
#pragma warning disable CS0612
                    EnableSpeakerDiarization = true,
                    DiarizationSpeakerCount = -901346833,
#pragma warning restore CS0612
                    AlternativeLanguageCodes =
                    {
                        "alternative_language_codesc303bdc8",
                    },
                    DiarizationConfig = new SpeakerDiarizationConfig
                    {
                        EnableSpeakerDiarization = true,
                        MinSpeakerCount = -1536699080,
                        MaxSpeakerCount = -353144096,
#pragma warning disable CS0612
                        SpeakerTag = 1615278445,
#pragma warning restore CS0612
                    },
                    Adaptation = new SpeechAdaptation
                    {
                        PhraseSets =
                        {
                            new PhraseSet
                            {
                                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                                Phrases =
                                {
                                    new PhraseSet.Types.Phrase
                                    {
                                        Value = "value60c16320",
                                        Boost = 7.584708E+17F,
                                    },
                                },
                                Boost = 7.584708E+17F,
                            },
                        },
                        PhraseSetReferences =
                        {
                            "phrase_set_references7ba122d6",
                        },
                        CustomClasses =
                        {
                            new CustomClass
                            {
                                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                                CustomClassId = "custom_class_idb1fbae50",
                                Items =
                                {
                                    new CustomClass.Types.ClassItem
                                    {
                                        Value = "value60c16320",
                                    },
                                },
                            },
                        },
                    },
                },
                Audio = new RecognitionAudio
                {
                    Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                    Uri = "uri3db70593",
                },
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Results =
                {
                    new SpeechRecognitionResult
                    {
                        Alternatives =
                        {
                            new SpeechRecognitionAlternative
                            {
                                Transcript = "transcript20c5b28b",
                                Confidence = 8.101506E+17F,
                                Words =
                                {
                                    new WordInfo
                                    {
                                        StartTime = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTime = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        Word = "word70187dc4",
                                        Confidence = 8.101506E+17F,
                                        SpeakerTag = 1615278445,
                                    },
                                },
                            },
                        },
                        ChannelTag = 1588685770,
                        LanguageCode = "language_code2f6c7160",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RecognizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecognizeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognizeResponse responseCallSettings = await client.RecognizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecognizeResponse responseCancellationToken = await client.RecognizeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Recognize()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Amr,
                    SampleRateHertz = -1305662007,
                    LanguageCode = "language_code2f6c7160",
                    MaxAlternatives = 723301600,
                    ProfanityFilter = true,
                    SpeechContexts =
                    {
                        new SpeechContext
                        {
                            Phrases = { "phrases5169195a", },
                            Boost = 7.584708E+17F,
                        },
                    },
                    AudioChannelCount = -1085150807,
                    EnableWordTimeOffsets = false,
                    Metadata = new RecognitionMetadata
                    {
                        InteractionType = RecognitionMetadata.Types.InteractionType.PhoneCall,
                        IndustryNaicsCodeOfAudio = 69741601U,
                        MicrophoneDistance = RecognitionMetadata.Types.MicrophoneDistance.Farfield,
                        OriginalMediaType = RecognitionMetadata.Types.OriginalMediaType.Unspecified,
                        RecordingDeviceType = RecognitionMetadata.Types.RecordingDeviceType.Vehicle,
                        RecordingDeviceName = "recording_device_name4458bc28",
                        OriginalMimeType = "original_mime_type7e1c606e",
#pragma warning disable CS0612
                        ObfuscatedId = -6237003036250521508L,
#pragma warning restore CS0612
                        AudioTopic = "audio_topica78ea2ec",
                    },
                    EnableAutomaticPunctuation = true,
                    EnableSeparateRecognitionPerChannel = false,
                    Model = "model635ef320",
                    UseEnhanced = false,
                    EnableWordConfidence = false,
#pragma warning disable CS0612
                    EnableSpeakerDiarization = true,
                    DiarizationSpeakerCount = -901346833,
#pragma warning restore CS0612
                    AlternativeLanguageCodes =
                    {
                        "alternative_language_codesc303bdc8",
                    },
                    DiarizationConfig = new SpeakerDiarizationConfig
                    {
                        EnableSpeakerDiarization = true,
                        MinSpeakerCount = -1536699080,
                        MaxSpeakerCount = -353144096,
#pragma warning disable CS0612
                        SpeakerTag = 1615278445,
#pragma warning restore CS0612
                    },
                    Adaptation = new SpeechAdaptation
                    {
                        PhraseSets =
                        {
                            new PhraseSet
                            {
                                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                                Phrases =
                                {
                                    new PhraseSet.Types.Phrase
                                    {
                                        Value = "value60c16320",
                                        Boost = 7.584708E+17F,
                                    },
                                },
                                Boost = 7.584708E+17F,
                            },
                        },
                        PhraseSetReferences =
                        {
                            "phrase_set_references7ba122d6",
                        },
                        CustomClasses =
                        {
                            new CustomClass
                            {
                                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                                CustomClassId = "custom_class_idb1fbae50",
                                Items =
                                {
                                    new CustomClass.Types.ClassItem
                                    {
                                        Value = "value60c16320",
                                    },
                                },
                            },
                        },
                    },
                },
                Audio = new RecognitionAudio
                {
                    Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                    Uri = "uri3db70593",
                },
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Results =
                {
                    new SpeechRecognitionResult
                    {
                        Alternatives =
                        {
                            new SpeechRecognitionAlternative
                            {
                                Transcript = "transcript20c5b28b",
                                Confidence = 8.101506E+17F,
                                Words =
                                {
                                    new WordInfo
                                    {
                                        StartTime = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTime = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        Word = "word70187dc4",
                                        Confidence = 8.101506E+17F,
                                        SpeakerTag = 1615278445,
                                    },
                                },
                            },
                        },
                        ChannelTag = 1588685770,
                        LanguageCode = "language_code2f6c7160",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Recognize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognizeResponse response = client.Recognize(request.Config, request.Audio);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RecognizeAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Amr,
                    SampleRateHertz = -1305662007,
                    LanguageCode = "language_code2f6c7160",
                    MaxAlternatives = 723301600,
                    ProfanityFilter = true,
                    SpeechContexts =
                    {
                        new SpeechContext
                        {
                            Phrases = { "phrases5169195a", },
                            Boost = 7.584708E+17F,
                        },
                    },
                    AudioChannelCount = -1085150807,
                    EnableWordTimeOffsets = false,
                    Metadata = new RecognitionMetadata
                    {
                        InteractionType = RecognitionMetadata.Types.InteractionType.PhoneCall,
                        IndustryNaicsCodeOfAudio = 69741601U,
                        MicrophoneDistance = RecognitionMetadata.Types.MicrophoneDistance.Farfield,
                        OriginalMediaType = RecognitionMetadata.Types.OriginalMediaType.Unspecified,
                        RecordingDeviceType = RecognitionMetadata.Types.RecordingDeviceType.Vehicle,
                        RecordingDeviceName = "recording_device_name4458bc28",
                        OriginalMimeType = "original_mime_type7e1c606e",
#pragma warning disable CS0612
                        ObfuscatedId = -6237003036250521508L,
#pragma warning restore CS0612
                        AudioTopic = "audio_topica78ea2ec",
                    },
                    EnableAutomaticPunctuation = true,
                    EnableSeparateRecognitionPerChannel = false,
                    Model = "model635ef320",
                    UseEnhanced = false,
                    EnableWordConfidence = false,
#pragma warning disable CS0612
                    EnableSpeakerDiarization = true,
                    DiarizationSpeakerCount = -901346833,
#pragma warning restore CS0612
                    AlternativeLanguageCodes =
                    {
                        "alternative_language_codesc303bdc8",
                    },
                    DiarizationConfig = new SpeakerDiarizationConfig
                    {
                        EnableSpeakerDiarization = true,
                        MinSpeakerCount = -1536699080,
                        MaxSpeakerCount = -353144096,
#pragma warning disable CS0612
                        SpeakerTag = 1615278445,
#pragma warning restore CS0612
                    },
                    Adaptation = new SpeechAdaptation
                    {
                        PhraseSets =
                        {
                            new PhraseSet
                            {
                                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                                Phrases =
                                {
                                    new PhraseSet.Types.Phrase
                                    {
                                        Value = "value60c16320",
                                        Boost = 7.584708E+17F,
                                    },
                                },
                                Boost = 7.584708E+17F,
                            },
                        },
                        PhraseSetReferences =
                        {
                            "phrase_set_references7ba122d6",
                        },
                        CustomClasses =
                        {
                            new CustomClass
                            {
                                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                                CustomClassId = "custom_class_idb1fbae50",
                                Items =
                                {
                                    new CustomClass.Types.ClassItem
                                    {
                                        Value = "value60c16320",
                                    },
                                },
                            },
                        },
                    },
                },
                Audio = new RecognitionAudio
                {
                    Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                    Uri = "uri3db70593",
                },
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Results =
                {
                    new SpeechRecognitionResult
                    {
                        Alternatives =
                        {
                            new SpeechRecognitionAlternative
                            {
                                Transcript = "transcript20c5b28b",
                                Confidence = 8.101506E+17F,
                                Words =
                                {
                                    new WordInfo
                                    {
                                        StartTime = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        EndTime = new wkt::Duration
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        Word = "word70187dc4",
                                        Confidence = 8.101506E+17F,
                                        SpeakerTag = 1615278445,
                                    },
                                },
                            },
                        },
                        ChannelTag = 1588685770,
                        LanguageCode = "language_code2f6c7160",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RecognizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecognizeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognizeResponse responseCallSettings = await client.RecognizeAsync(request.Config, request.Audio, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecognizeResponse responseCancellationToken = await client.RecognizeAsync(request.Config, request.Audio, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
