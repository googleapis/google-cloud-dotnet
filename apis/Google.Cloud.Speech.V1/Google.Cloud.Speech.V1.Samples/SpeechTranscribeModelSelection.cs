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

// This is a generated sample ("Request", "speech_transcribe_model_selection")

// sample-metadata
//   title: Selecting a Transcription Model (Local File)
//   description: Transcribe a short audio file using a specified transcription model
//   usage: dotnet run [--local_file_path "resources/hello.wav"] [--model "phone_call"]

using CommandLine;

namespace Google.Cloud.Speech.V1.Samples
{
    // [START speech_transcribe_model_selection]
    using Google.Cloud.Speech.V1;
    using Google.Protobuf;
    using System;
    using System.IO;

    public class SpeechTranscribeModelSelection
    {
        /// <summary>
        /// Transcribe a short audio file using a specified transcription model
        /// </summary>
        /// <param name="localFilePath">Path to local audio file, e.g. /path/audio.wav</param>
        /// <param name="model">The transcription model to use, e.g. video, phone_call, default
        /// For a list of available transcription models, see:
        /// https://cloud.google.com/speech-to-text/docs/transcription-model#transcription_models
        /// </param>
        public static void SampleRecognize(string localFilePath, string model)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string localFilePath = "resources/hello.wav"
            // string model = "phone_call"
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    // The transcription model to use, e.g. video, phone_call, default
                    // For a list of available transcription models, see:
                    // https://cloud.google.com/speech-to-text/docs/transcription-model#transcription_models
                    Model = "phone_call",
                    // The language of the supplied audio
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

    // [END speech_transcribe_model_selection]

    public class SpeechTranscribeModelSelectionMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeModelSelection.SampleRecognize(opts.LocalFilePath, opts.Model));
        }

        public class Options
        {
            [Option("local_file_path", Default = "resources/hello.wav")]
            public string LocalFilePath { get; set; }

            [Option("model", Default = "phone_call")]
            public string Model { get; set; }
        }
    }
}