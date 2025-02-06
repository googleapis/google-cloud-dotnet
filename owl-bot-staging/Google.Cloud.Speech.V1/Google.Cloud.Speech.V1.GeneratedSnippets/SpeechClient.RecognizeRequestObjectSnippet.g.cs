// Copyright 2025 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START speech_v1_generated_Speech_Recognize_sync]
    using Google.Cloud.Speech.V1;

    public sealed partial class GeneratedSpeechClientSnippets
    {
        /// <summary>Snippet for Recognize</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void RecognizeRequestObject()
        {
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
            };
            // Make the request
            RecognizeResponse response = speechClient.Recognize(request);
        }
    }
    // [END speech_v1_generated_Speech_Recognize_sync]
}
