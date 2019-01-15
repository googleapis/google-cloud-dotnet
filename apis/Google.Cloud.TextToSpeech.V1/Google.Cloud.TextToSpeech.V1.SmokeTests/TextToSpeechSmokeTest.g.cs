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

namespace Google.Cloud.TextToSpeech.V1.SmokeTests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;

    public class TextToSpeechSmokeTest
    {
        public static int Main(string[] args)
        {
            // Create client
            TextToSpeechClient client = TextToSpeechClient.Create();

            // Initialize request argument(s)
            SynthesisInput input = new SynthesisInput
            {
                Text = "test",
            };
            VoiceSelectionParams voice = new VoiceSelectionParams
            {
                LanguageCode = "en-US",
            };
            AudioConfig audioConfig = new AudioConfig
            {
                AudioEncoding = AudioEncoding.Mp3,
            };

            // Call API method
            SynthesizeSpeechResponse response = client.SynthesizeSpeech(input, voice, audioConfig);
            // Show the result
            Console.WriteLine(response);

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
