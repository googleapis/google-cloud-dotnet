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

// This is a generated sample ("Request", "speech_transcribe_word_level_confidence_beta")

// sample-metadata
//   title: Enabling word-level confidence (Local File) (Beta)
//   description: Print confidence level for individual words in a transcription of a short audio file.
//   usage: dotnet run [--local_file_path "resources/brooklyn_bridge.flac"]

using CommandLine;

namespace Google.Cloud.Speech.V1P1Beta1.Samples
{
    // [START speech_transcribe_word_level_confidence_beta]
    using Google.Cloud.Speech.V1P1Beta1;
    using Google.Protobuf;
    using System;
    using System.IO;

    public class SpeechTranscribeWordLevelConfidenceBeta
    {
        /// <summary>
        /// Print confidence level for individual words in a transcription of a short audio file.
        /// </summary>
        /// <param name="localFilePath">Path to local audio file, e.g. /path/audio.wav</param>
        public static void SampleRecognize(string localFilePath)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string localFilePath = "resources/brooklyn_bridge.flac"
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    // When enabled, the first result returned by the API will include a list
                    // of words and the confidence level for each of those words.
                    EnableWordConfidence = true,
                    // The language of the supplied audio
                    LanguageCode = "en-US",
                },
                Audio = new RecognitionAudio
                {
                    Content = ByteString.CopyFrom(File.ReadAllBytes(localFilePath)),
                },
            };
            RecognizeResponse response = speechClient.Recognize(request);
            // The first result includes confidence levels per word
            SpeechRecognitionResult result = response.Results[0];
            // First alternative is the most probable result
            SpeechRecognitionAlternative alternative = result.Alternatives[0];
            Console.WriteLine($"Transcript: {alternative.Transcript}");
            // Print the confidence level of each word
            foreach (WordInfo word in alternative.Words) {
                Console.WriteLine($"Word: {word.Word}");
                Console.WriteLine($"Confidence: {word.Confidence}");
            }
        }
    }

    // [END speech_transcribe_word_level_confidence_beta]

    public class SpeechTranscribeWordLevelConfidenceBetaMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeWordLevelConfidenceBeta.SampleRecognize(opts.LocalFilePath));
        }

        public class Options
        {
            [Option("local_file_path", Default = "resources/brooklyn_bridge.flac")]
            public string LocalFilePath { get; set; }
        }
    }
}