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

// This is a generated sample ("LongRunningRequestPollUntilComplete", "speech_transcribe_async")

// sample-metadata
//   title: Transcribe Audio File using Long Running Operation (Local File) (LRO)
//   description: Transcribe a long audio file using asynchronous speech recognition
//   usage: dotnet run [--local_file_path "resources/brooklyn_bridge.raw"]

using CommandLine;

namespace Google.Cloud.Speech.V1.Samples
{
    // [START speech_transcribe_async]
    using Google.Cloud.Speech.V1;
    using Google.Protobuf;
    using System;
    using System.IO;

    public class SpeechTranscribeAsync
    {
        /// <summary>
        /// Transcribe a long audio file using asynchronous speech recognition
        /// </summary>
        /// <param name="localFilePath">Path to local audio file, e.g. /path/audio.wav</param>
        public static void SampleLongRunningRecognize(string localFilePath)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string localFilePath = "resources/brooklyn_bridge.raw"
            LongRunningRecognizeRequest request = new LongRunningRecognizeRequest
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
            // Poll until the returned long-running operation is complete
            LongRunningRecognizeResponse response = speechClient.LongRunningRecognize(request).PollUntilCompleted().Result;
            foreach (SpeechRecognitionResult result in response.Results) {
                // First alternative is the most probable result
                SpeechRecognitionAlternative alternative = result.Alternatives[0];
                Console.WriteLine($"Transcript: {alternative.Transcript}");
            }
        }
    }

    // [END speech_transcribe_async]

    public class SpeechTranscribeAsyncMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeAsync.SampleLongRunningRecognize(opts.LocalFilePath));
        }

        public class Options
        {
            [Option("local_file_path", Default = "resources/brooklyn_bridge.raw")]
            public string LocalFilePath { get; set; }
        }
    }
}