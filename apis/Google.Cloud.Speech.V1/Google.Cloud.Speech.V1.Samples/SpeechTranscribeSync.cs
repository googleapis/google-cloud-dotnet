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

// This is a generated sample ("Request", "speech_transcribe_sync")

// sample-metadata
//   title: Transcribe Audio File (Local File)
//   description: Transcribe a short audio file using synchronous speech recognition
//   usage: dotnet run [--local_file_path "resources/brooklyn_bridge.raw"]

using CommandLine;

namespace Google.Cloud.Speech.V1.Samples
{
    // [START speech_transcribe_sync]
    using Google.Cloud.Speech.V1;
    using Google.Protobuf;
    using System;
    using System.IO;

    public class SpeechTranscribeSync
    {
        /// <summary>
        /// Transcribe a short audio file using synchronous speech recognition
        /// </summary>
        /// <param name="localFilePath">Path to local audio file, e.g. /path/audio.wav</param>
        public static void SampleRecognize(string localFilePath)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string localFilePath = "resources/brooklyn_bridge.raw"
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    // The language of the supplied audio
                    LanguageCode = "en-US",
                    // Sample rate in Hertz of the audio data sent
                    SampleRateHertz = 16000,
                    // Encoding of audio data sent. This sample sets this explicitly.
                    // This field is optional for FLAC and WAV audio formats.
                    Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
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

    // [END speech_transcribe_sync]

    public class SpeechTranscribeSyncMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeSync.SampleRecognize(opts.LocalFilePath));
        }

        public class Options
        {
            [Option("local_file_path", Default = "resources/brooklyn_bridge.raw")]
            public string LocalFilePath { get; set; }
        }
    }
}