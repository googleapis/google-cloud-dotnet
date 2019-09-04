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

// This is a generated sample ("Request", "speech_transcribe_recognition_metadata_beta")

// sample-metadata
//   title: Adding recognition metadata (Local File) (Beta)
//   description: Adds additional details short audio file included in this recognition request
//   usage: dotnet run [--local_file_path "resources/commercial_mono.wav"]

using CommandLine;

namespace Google.Cloud.Speech.V1P1Beta1.Samples
{
    // [START speech_transcribe_recognition_metadata_beta]
    using Google.Cloud.Speech.V1P1Beta1;
    using Google.Protobuf;
    using System;
    using System.IO;

    public class SpeechTranscribeRecognitionMetadataBeta
    {
        /// <summary>
        /// Adds additional details short audio file included in this recognition request
        /// </summary>
        /// <param name="localFilePath">Path to local audio file, e.g. /path/audio.wav</param>
        public static void SampleRecognize(string localFilePath)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string localFilePath = "resources/commercial_mono.wav"
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    Metadata = new RecognitionMetadata
                               {
                                   InteractionType = RecognitionMetadata.Types.InteractionType.VoiceSearch,
                                   RecordingDeviceType = RecognitionMetadata.Types.RecordingDeviceType.Smartphone,
                                   RecordingDeviceName = "Pixel 3",
                               },
                    // The language of the supplied audio. Even though additional languages are
                    // provided by alternative_language_codes, a primary language is still required.
                    LanguageCode = "en-US",
                },
                Audio = new RecognitionAudio
                {
                    Content = ByteString.CopyFrom(File.ReadAllBytes(localFilePath)),
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

    // [END speech_transcribe_recognition_metadata_beta]

    public class SpeechTranscribeRecognitionMetadataBetaMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeRecognitionMetadataBeta.SampleRecognize(opts.LocalFilePath));
        }

        public class Options
        {
            [Option("local_file_path", Default = "resources/commercial_mono.wav")]
            public string LocalFilePath { get; set; }
        }
    }
}