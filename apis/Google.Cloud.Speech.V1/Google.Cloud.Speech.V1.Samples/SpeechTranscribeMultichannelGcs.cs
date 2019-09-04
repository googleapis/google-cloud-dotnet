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

// This is a generated sample ("Request", "speech_transcribe_multichannel_gcs")

// sample-metadata
//   title: Multi-Channel Audio Transcription (Cloud Storage)
//   description: Transcribe a short audio file from Cloud Storage with multiple channels
//   usage: dotnet run [--storage_uri "gs://cloud-samples-data/speech/multi.wav"]

using CommandLine;

namespace Google.Cloud.Speech.V1.Samples
{
    // [START speech_transcribe_multichannel_gcs]
    using Google.Cloud.Speech.V1;
    using System;

    public class SpeechTranscribeMultichannelGcs
    {
        /// <summary>
        /// Transcribe a short audio file from Cloud Storage with multiple channels
        /// </summary>
        /// <param name="storageUri">URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]</param>
        public static void SampleRecognize(string storageUri)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string storageUri = "gs://cloud-samples-data/speech/multi.wav"
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
                    // URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]
                    Uri = "gs://cloud-samples-data/speech/multi.wav",
                },
            };
            RecognizeResponse response = speechClient.Recognize(request);
            foreach (SpeechRecognitionResult result in response.Results) {
                // channelTag to recognize which audio channel this result is for
                Console.WriteLine($"Channel tag: {result.ChannelTag}");
                // First alternative is the most probable result
                SpeechRecognitionAlternative alternative = result.Alternatives[0];
                Console.WriteLine($"Transcript: {alternative.Transcript}");
            }
        }
    }

    // [END speech_transcribe_multichannel_gcs]

    public class SpeechTranscribeMultichannelGcsMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeMultichannelGcs.SampleRecognize(opts.StorageUri));
        }

        public class Options
        {
            [Option("storage_uri", Default = "gs://cloud-samples-data/speech/multi.wav")]
            public string StorageUri { get; set; }
        }
    }
}