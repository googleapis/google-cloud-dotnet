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

// This is a generated sample ("Request", "speech_transcribe_model_selection_gcs")

// sample-metadata
//   title: Selecting a Transcription Model (Cloud Storage)
//   description: Transcribe a short audio file from Cloud Storage using a specified transcription model
//   usage: dotnet run [--storage_uri "gs://cloud-samples-data/speech/hello.wav"] [--model "phone_call"]

using CommandLine;

namespace Google.Cloud.Speech.V1.Samples
{
    // [START speech_transcribe_model_selection_gcs]
    using Google.Cloud.Speech.V1;
    using System;

    public class SpeechTranscribeModelSelectionGcs
    {
        /// <summary>
        /// Transcribe a short audio file from Cloud Storage using a specified transcription model
        /// </summary>
        /// <param name="storageUri">URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]</param>
        /// <param name="model">The transcription model to use, e.g. video, phone_call, default
        /// For a list of available transcription models, see:
        /// https://cloud.google.com/speech-to-text/docs/transcription-model#transcription_models
        /// </param>
        public static void SampleRecognize(string storageUri, string model)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string storageUri = "gs://cloud-samples-data/speech/hello.wav"
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
                    // URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]
                    Uri = "gs://cloud-samples-data/speech/hello.wav",
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

    // [END speech_transcribe_model_selection_gcs]

    public class SpeechTranscribeModelSelectionGcsMain
    {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeModelSelectionGcs.SampleRecognize(opts.StorageUri, opts.Model));
        }

        public class Options
        {
            [Option("storage_uri", Default = "gs://cloud-samples-data/speech/hello.wav")]
            public string StorageUri { get; set; }

            [Option("model", Default = "phone_call")]
            public string Model { get; set; }
        }
    }
}
