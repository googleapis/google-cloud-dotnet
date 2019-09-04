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

// This is a generated sample ("Request", "speech_quickstart_beta")

// sample-metadata
//   title: Quickstart Beta
//   description: Performs synchronous speech recognition on an audio file
//   usage: dotnet run [--storage_uri "gs://cloud-samples-data/speech/brooklyn_bridge.mp3"]

using CommandLine;

namespace Google.Cloud.Speech.V1P1Beta1.Samples
{
    // [START speech_quickstart_beta]
    using Google.Cloud.Speech.V1P1Beta1;
    using System;

    public class SpeechQuickstartBeta
    {
        /// <summary>
        /// Performs synchronous speech recognition on an audio file
        /// </summary>
        /// <param name="storageUri">URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]</param>
        public static void SampleRecognize(string storageUri)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string storageUri = "gs://cloud-samples-data/speech/brooklyn_bridge.mp3"
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    // The language of the supplied audio
                    LanguageCode = "en-US",
                    // Sample rate in Hertz of the audio data sent
                    SampleRateHertz = 44100,
                    // Encoding of audio data sent. This sample sets this explicitly.
                    // This field is optional for FLAC and WAV audio formats.
                    Encoding = RecognitionConfig.Types.AudioEncoding.Mp3,
                },
                Audio = new RecognitionAudio
                {
                    // URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]
                    Uri = "gs://cloud-samples-data/speech/brooklyn_bridge.mp3",
                },
            };
            RecognizeResponse response = speechClient.Recognize(request);
            foreach (SpeechRecognitionResult result in response.Results) {
                // First alternative is the most probable result
                SpeechRecognitionAlternative alternative = result.Alternatives[0];
                Console.WriteLine($"Transcript: {alternative.Transcript}");
            }
        }
    }

    // [END speech_quickstart_beta]

    public class SpeechQuickstartBetaMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechQuickstartBeta.SampleRecognize(opts.StorageUri));
        }

        public class Options
        {
            [Option("storage_uri", Default = "gs://cloud-samples-data/speech/brooklyn_bridge.mp3")]
            public string StorageUri { get; set; }
        }
    }
}