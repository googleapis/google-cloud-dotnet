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

// This is a generated sample ("Request", "speech_contexts_classes_beta")

// sample-metadata
//   title: Using Context Classes (Cloud Storage)
//   description: Transcribe a short audio file with static context classes.
//   usage: dotnet run [--storage_uri "gs://cloud-samples-data/speech/time.mp3"] [--phrase "$TIME"]

using CommandLine;

namespace Google.Cloud.Speech.V1P1Beta1.Samples
{
    // [START speech_contexts_classes_beta]
    using Google.Cloud.Speech.V1P1Beta1;
    using System;
    using System.Collections.Generic;

    public class SpeechContextsClassesBeta
    {
        /// <summary>
        /// Transcribe a short audio file with static context classes.
        /// </summary>
        /// <param name="storageUri">URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]</param>
        /// <param name="phrase">Phrase "hints" help recognize the specified phrases from your audio.
        /// In this sample we are using a static class phrase ($TIME).
        /// Classes represent groups of words that represent common concepts
        /// that occur in natural language.
        /// </param>
        public static void SampleRecognize(string storageUri, string phrase)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string storageUri = "gs://cloud-samples-data/speech/time.mp3"
            // string phrase = "$TIME"
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    SpeechContexts = {
                                         new SpeechContext
                                         {
                                             Phrases = {
                                                           "$TIME",
                                                       },
                                         },
                                     },
                    // The language of the supplied audio
                    LanguageCode = "en-US",
                    // Sample rate in Hertz of the audio data sent
                    SampleRateHertz = 24000,
                    // Encoding of audio data sent. This sample sets this explicitly.
                    // This field is optional for FLAC and WAV audio formats.
                    Encoding = RecognitionConfig.Types.AudioEncoding.Mp3,
                },
                Audio = new RecognitionAudio
                {
                    // URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]
                    Uri = "gs://cloud-samples-data/speech/time.mp3",
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

    // [END speech_contexts_classes_beta]

    public class SpeechContextsClassesBetaMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechContextsClassesBeta.SampleRecognize(opts.StorageUri, opts.Phrase));
        }

        public class Options
        {
            [Option("storage_uri", Default = "gs://cloud-samples-data/speech/time.mp3")]
            public string StorageUri { get; set; }

            [Option("phrase", Default = "$TIME")]
            public string Phrase { get; set; }
        }
    }
}