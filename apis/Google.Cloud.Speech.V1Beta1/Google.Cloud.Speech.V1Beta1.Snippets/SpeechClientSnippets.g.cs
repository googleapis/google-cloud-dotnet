// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Speech.V1Beta1.Snippets
{
    public class GeneratedSpeechClientSnippets
    {
        public async Task SyncRecognizeAsync()
        {
            // Snippet: SyncRecognizeAsync(RecognitionConfig,RecognitionAudio,CallSettings)
            // Additional: SyncRecognizeAsync(RecognitionConfig,RecognitionAudio,CancellationToken)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognitionConfig config = new RecognitionConfig();
            RecognitionAudio audio = new RecognitionAudio();
            // Make the request
            SyncRecognizeResponse response = await speechClient.SyncRecognizeAsync(config, audio);
            // End snippet
        }

        public void SyncRecognize()
        {
            // Snippet: SyncRecognize(RecognitionConfig,RecognitionAudio,CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognitionConfig config = new RecognitionConfig();
            RecognitionAudio audio = new RecognitionAudio();
            // Make the request
            SyncRecognizeResponse response = speechClient.SyncRecognize(config, audio);
            // End snippet
        }

        public async Task AsyncRecognizeAsync()
        {
            // Snippet: AsyncRecognizeAsync(RecognitionConfig,RecognitionAudio,CallSettings)
            // Additional: AsyncRecognizeAsync(RecognitionConfig,RecognitionAudio,CancellationToken)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognitionConfig config = new RecognitionConfig();
            RecognitionAudio audio = new RecognitionAudio();
            // Make the request
            Operation response = await speechClient.AsyncRecognizeAsync(config, audio);
            // End snippet
        }

        public void AsyncRecognize()
        {
            // Snippet: AsyncRecognize(RecognitionConfig,RecognitionAudio,CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognitionConfig config = new RecognitionConfig();
            RecognitionAudio audio = new RecognitionAudio();
            // Make the request
            Operation response = speechClient.AsyncRecognize(config, audio);
            // End snippet
        }

    }
}
