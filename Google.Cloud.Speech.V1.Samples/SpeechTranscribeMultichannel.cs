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

// This is a generated sample ("Request", "speech_transcribe_multichannel")

// sample-metadata
//   title: Multi-Channel Audio Transcription (Local File)
//   description: Transcribe a short audio file with multiple channels
//   usage: dotnet run [--local_file_path "resources/multi.wav"]

using CommandLine;

namespace Google.Cloud.Speech.V1.Samples
{
    // [START speech_transcribe_multichannel]
    using Google.Cloud.Speech.V1;
    using Google.Protobuf;
    using System;
    using System.IO;

    public class SpeechTranscribeMultichannel
    {
        /// <summary>
        /// Transcribe a short audio file with multiple channels
        /// </summary>
        /// <param name="localFilePath">Path to local audio file, e.g. /path/audio.wav</param>
        public static void SampleRecognize(string localFilePath)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string localFilePath = "resources/multi.wav"
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    // The number of channels in the input audio file (optional)
                    AudioChannelCount = 2,
                    // When set to true, each audio channel will be recognized separately.
                    // The recognition result will contain a channel_tag field to state which
                    // channel that result belongs to
                    EnableSeparateRecognitionPerChannel = true,
                    // The language of the supplied audio
                    LanguageCode = "en-US",
                },
                Audio = new RecognitionAudio
                {
                    Content = ByteString.CopyFrom(File.ReadAllBytes(localFilePath)),
                },
            };
            RecognizeResponse response = speechClient.Recognize(request);
            foreach (SpeechRecognitionResult result in response.Results)
            {
                // channelTag to recognize which audio channel this result is for
                Console.WriteLine($"Channel tag: {result.ChannelTag}");
                // First alternative is the most probable result
                SpeechRecognitionAlternative alternative = result.Alternatives[0];
                Console.WriteLine($"Transcript: {alternative.Transcript}");
            }
        }
    }

    // [END speech_transcribe_multichannel]

    public class SpeechTranscribeMultichannelMain
    {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeMultichannel.SampleRecognize(opts.LocalFilePath));
        }

        public class Options
        {
            [Option("local_file_path", Default = "resources/multi.wav")]
            public string LocalFilePath { get; set; }
        }
    }
}
