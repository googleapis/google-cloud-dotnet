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

// This is a generated sample ("LongRunningRequestPollUntilComplete", "speech_transcribe_async_word_time_offsets_gcs")

// sample-metadata
//   title: Getting word timestamps (Cloud Storage) (LRO)
//   description: Print start and end time of each word spoken in audio file from Cloud Storage
//   usage: dotnet run [--storage_uri "gs://cloud-samples-data/speech/brooklyn_bridge.flac"]

using CommandLine;

namespace Google.Cloud.Speech.V1.Samples
{
    // [START speech_transcribe_async_word_time_offsets_gcs]
    using Google.Cloud.Speech.V1;
    using System;

    public class SpeechTranscribeAsyncWordTimeOffsetsGcs
    {
        /// <summary>
        /// Print start and end time of each word spoken in audio file from Cloud Storage
        /// </summary>
        /// <param name="storageUri">URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]</param>
        public static void SampleLongRunningRecognize(string storageUri)
        {
            SpeechClient speechClient = SpeechClient.Create();
            // string storageUri = "gs://cloud-samples-data/speech/brooklyn_bridge.flac"
            LongRunningRecognizeRequest request = new LongRunningRecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    // When enabled, the first result returned by the API will include a list
                    // of words and the start and end time offsets (timestamps) for those words.
                    EnableWordTimeOffsets = true,
                    // The language of the supplied audio
                    LanguageCode = "en-US",
                },
                Audio = new RecognitionAudio
                {
                    // URI for audio file in Cloud Storage, e.g. gs://[BUCKET]/[FILE]
                    Uri = "gs://cloud-samples-data/speech/brooklyn_bridge.flac",
                },
            };
            // Poll until the returned long-running operation is complete
            LongRunningRecognizeResponse response = speechClient.LongRunningRecognize(request).PollUntilCompleted().Result;
            // The first result includes start and end time word offsets
            SpeechRecognitionResult result = response.Results[0];
            // First alternative is the most probable result
            SpeechRecognitionAlternative alternative = result.Alternatives[0];
            Console.WriteLine($"Transcript: {alternative.Transcript}");
            // Print the start and end time of each word
            foreach (WordInfo word in alternative.Words)
            {
                Console.WriteLine($"Word: {word.Word}");
                Console.WriteLine($"Start time: {word.StartTime.Seconds} seconds {word.StartTime.Nanos} nanos");
                Console.WriteLine($"End time: {word.EndTime.Seconds} seconds {word.EndTime.Nanos} nanos");
            }
        }
    }

    // [END speech_transcribe_async_word_time_offsets_gcs]

    public class SpeechTranscribeAsyncWordTimeOffsetsGcsMain
    {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    SpeechTranscribeAsyncWordTimeOffsetsGcs.SampleLongRunningRecognize(opts.StorageUri));
        }

        public class Options
        {
            [Option("storage_uri", Default = "gs://cloud-samples-data/speech/brooklyn_bridge.flac")]
            public string StorageUri { get; set; }
        }
    }
}
