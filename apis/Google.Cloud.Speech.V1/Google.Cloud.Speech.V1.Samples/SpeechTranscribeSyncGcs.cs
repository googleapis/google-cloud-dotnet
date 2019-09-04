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

// This is a generated sample ("Request", "speech_transcribe_sync_gcs")

// sample-metadata
//   title: Transcript Audio File (Cloud Storage)
//   description: Transcribe short audio file from Cloud Storage using synchronous speech recognition
//   usage: dotnet run [--storage_uri "gs://cloud-samples-data/speech/brooklyn_bridge.raw"]

using CommandLine;

namespace Google.Cloud.Speech.V1.Samples
{
    // [START speech_transcribe_sync_gcs]
    using Google.Cloud.Speech.V1;
    using System;

    public class SpeechTranscribeSyncGcs
    {
        /// <summary>
        /// Transcribe short audio file from Cloud Storage using synchronous speech recognition
        /// </summary>
        /// <param name="storageUri">URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]</param>
        public static void SampleRecognize(string storageUri)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string storageUri = "gs://cloud-samples-data/speech/brooklyn_bridge.raw"
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    // Sample rate in Hertz of the audio data sent
                    SampleRateHertz = 16000,
                    // The language of the supplied audio
                    LanguageCode = "en-US",
                    // Encoding of audio data sent. This sample sets this explicitly.
                    // This field is optional for FLAC and WAV audio formats.
                    Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                },
                Audio = new RecognitionAudio
                {
                    // URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]
                    Uri = "gs://cloud-samples-data/speech/brooklyn_bridge.raw",
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

    // [END speech_transcribe_sync_gcs]

    public class SpeechTranscribeSyncGcsMain {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeSyncGcs.SampleRecognize(opts.StorageUri));
        }

        public class Options
        {
            [Option("storage_uri", Default = "gs://cloud-samples-data/speech/brooklyn_bridge.raw")]
            public string StorageUri { get; set; }
        }
    }
}