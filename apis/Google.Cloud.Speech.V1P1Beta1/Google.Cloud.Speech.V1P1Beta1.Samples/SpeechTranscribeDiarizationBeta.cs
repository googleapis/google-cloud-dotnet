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

// This is a generated sample ("LongRunningRequestPollUntilComplete", "speech_transcribe_diarization_beta")

// sample-metadata
//   title: Separating different speakers (Local File) (LRO) (Beta)
//   description: Print confidence level for individual words in a transcription of a short audio file
//     Separating different speakers in an audio file recording
//   usage: dotnet run [--local_file_path "resources/commercial_mono.wav"]

using CommandLine;

namespace Google.Cloud.Speech.V1P1Beta1.Samples
{
    // [START speech_transcribe_diarization_beta]
    using Google.Cloud.Speech.V1P1Beta1;
    using Google.Protobuf;
    using System;
    using System.IO;

    public class SpeechTranscribeDiarizationBeta
    {
        /// <summary>
        /// Print confidence level for individual words in a transcription of a short audio file
        /// Separating different speakers in an audio file recording
        /// </summary>
        /// <param name="localFilePath">Path to local audio file, e.g. /path/audio.wav</param>
        public static void SampleLongRunningRecognize(string localFilePath)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string localFilePath = "resources/commercial_mono.wav"
            LongRunningRecognizeRequest request = new LongRunningRecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    // If enabled, each word in the first alternative of each result will be
                    // tagged with a speaker tag to identify the speaker.
                    EnableSpeakerDiarization = true,
                    // Optional. Specifies the estimated number of speakers in the conversation.
                    DiarizationSpeakerCount = 2,
                    // The language of the supplied audio
                    LanguageCode = "en-US",
                },
                Audio = new RecognitionAudio
                {
                    Content = ByteString.CopyFrom(File.ReadAllBytes(localFilePath)),
                },
            };
            // Poll until the returned long-running operation is complete
            LongRunningRecognizeResponse response = speechClient.LongRunningRecognize(request).PollUntilCompleted().Result;
            foreach (SpeechRecognitionResult result in response.Results) {
                // First alternative has words tagged with speakers
                SpeechRecognitionAlternative alternative = result.Alternatives[0];
                Console.WriteLine($"Transcript: {alternative.Transcript}");
                // Print the speakerTag of each word
                foreach (WordInfo word in alternative.Words) {
                    Console.WriteLine($"Word: {word.Word}");
                    Console.WriteLine($"Speaker tag: {word.SpeakerTag}");
                }
            }
        }
    }

    // [END speech_transcribe_diarization_beta]

    public class SpeechTranscribeDiarizationBetaMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeDiarizationBeta.SampleLongRunningRecognize(opts.LocalFilePath));
        }

        public class Options
        {
            [Option("local_file_path", Default = "resources/commercial_mono.wav")]
            public string LocalFilePath { get; set; }
        }
    }
}