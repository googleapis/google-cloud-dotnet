// Copyright 2016, Google Inc. All rights reserved.
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Speech.V1Beta1;
using Google.LongRunning;
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
            SpeechClient speechClient = await SpeechClient.CreateAsync();
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

        public async Task SyncRecognizeAsync_RequestObject()
        {
            // Snippet: SyncRecognizeAsync(SyncRecognizeRequest,CallSettings)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            SyncRecognizeRequest request = new SyncRecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
            };
            // Make the request
            SyncRecognizeResponse response = await speechClient.SyncRecognizeAsync(request);
            // End snippet
        }

        public void SyncRecognize_RequestObject()
        {
            // Snippet: SyncRecognize(SyncRecognizeRequest,CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            SyncRecognizeRequest request = new SyncRecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
            };
            // Make the request
            SyncRecognizeResponse response = speechClient.SyncRecognize(request);
            // End snippet
        }

        public async Task AsyncRecognizeAsync()
        {
            // Snippet: AsyncRecognizeAsync(RecognitionConfig,RecognitionAudio,CallSettings)
            // Additional: AsyncRecognizeAsync(RecognitionConfig,RecognitionAudio,CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            RecognitionConfig config = new RecognitionConfig();
            RecognitionAudio audio = new RecognitionAudio();
            // Make the request
            Operation<AsyncRecognizeResponse> response =
                await speechClient.AsyncRecognizeAsync(config, audio);

            // Poll until the returned long-running operation is complete
            Operation<AsyncRecognizeResponse> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncRecognizeResponse> retrievedResponse =
                await speechClient.PollOnceAsyncRecognizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
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
            Operation<AsyncRecognizeResponse> response =
                speechClient.AsyncRecognize(config, audio);

            // Poll until the returned long-running operation is complete
            Operation<AsyncRecognizeResponse> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncRecognizeResponse> retrievedResponse =
                speechClient.PollOnceAsyncRecognize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public async Task AsyncRecognizeAsync_RequestObject()
        {
            // Snippet: AsyncRecognizeAsync(AsyncRecognizeRequest,CallSettings)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            AsyncRecognizeRequest request = new AsyncRecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
            };
            // Make the request
            Operation<AsyncRecognizeResponse> response =
                await speechClient.AsyncRecognizeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncRecognizeResponse> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncRecognizeResponse> retrievedResponse =
                await speechClient.PollOnceAsyncRecognizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public void AsyncRecognize_RequestObject()
        {
            // Snippet: AsyncRecognize(AsyncRecognizeRequest,CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            AsyncRecognizeRequest request = new AsyncRecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
            };
            // Make the request
            Operation<AsyncRecognizeResponse> response =
                speechClient.AsyncRecognize(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncRecognizeResponse> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncRecognizeResponse> retrievedResponse =
                speechClient.PollOnceAsyncRecognize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

    }
}
