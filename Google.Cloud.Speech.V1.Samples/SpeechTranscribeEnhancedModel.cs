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

// This is a generated sample ("Request", "speech_transcribe_enhanced_model")

// sample-metadata
//   title: Using Enhanced Models (Local File)
//   description: Transcribe a short audio file using an enhanced model
//   usage: dotnet run [--local_file_path "resources/hello.wav"]

using CommandLine;

namespace Google.Cloud.Speech.V1.Samples
{
    // [START speech_transcribe_enhanced_model]
    using Google.Cloud.Speech.V1;
    using Google.Protobuf;
    using System;
    using System.IO;

    public class SpeechTranscribeEnhancedModel
    {
        /// <summary>
        /// Transcribe a short audio file using an enhanced model
        /// </summary>
        /// <param name="localFilePath">Path to local audio file, e.g. /path/audio.wav</param>
        public static void SampleRecognize(string localFilePath)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string localFilePath = "resources/hello.wav"
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    // The enhanced model to use, e.g. phone_call
                    // Currently phone_call is the only model available as an enhanced model.
                    Model = "phone_call",
                    // Use an enhanced model for speech recognition (when set to true).
                    // Project must be eligible for requesting enhanced models.
                    // Enhanced speech models require that you opt-in to data logging.
                    UseEnhanced = true,
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
                // First alternative is the most probable result
                SpeechRecognitionAlternative alternative = result.Alternatives[0];
                Console.WriteLine($"Transcript: {alternative.Transcript}");
            }
        }
    }

    // [END speech_transcribe_enhanced_model]

    public class SpeechTranscribeEnhancedModelMain
    {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeEnhancedModel.SampleRecognize(opts.LocalFilePath));
        }

        public class Options
        {
            [Option("local_file_path", Default = "resources/hello.wav")]
            public string LocalFilePath { get; set; }
        }
    }
}
