// Copyright 2024 Google LLC
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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Speech.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSpeechClientSnippets
    {
        /// <summary>Snippet for Recognize</summary>
        public void RecognizeRequestObject()
        {
            // Snippet: Recognize(RecognizeRequest, CallSettings)
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
            // End snippet
        }

        /// <summary>Snippet for RecognizeAsync</summary>
        public async Task RecognizeRequestObjectAsync()
        {
            // Snippet: RecognizeAsync(RecognizeRequest, CallSettings)
            // Additional: RecognizeAsync(RecognizeRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
            };
            // Make the request
            RecognizeResponse response = await speechClient.RecognizeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Recognize</summary>
        public void Recognize()
        {
            // Snippet: Recognize(RecognitionConfig, RecognitionAudio, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognitionConfig config = new RecognitionConfig();
            RecognitionAudio audio = new RecognitionAudio();
            // Make the request
            RecognizeResponse response = speechClient.Recognize(config, audio);
            // End snippet
        }

        /// <summary>Snippet for RecognizeAsync</summary>
        public async Task RecognizeAsync()
        {
            // Snippet: RecognizeAsync(RecognitionConfig, RecognitionAudio, CallSettings)
            // Additional: RecognizeAsync(RecognitionConfig, RecognitionAudio, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            RecognitionConfig config = new RecognitionConfig();
            RecognitionAudio audio = new RecognitionAudio();
            // Make the request
            RecognizeResponse response = await speechClient.RecognizeAsync(config, audio);
            // End snippet
        }

        /// <summary>Snippet for LongRunningRecognize</summary>
        public void LongRunningRecognizeRequestObject()
        {
            // Snippet: LongRunningRecognize(LongRunningRecognizeRequest, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            LongRunningRecognizeRequest request = new LongRunningRecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
                OutputConfig = new TranscriptOutputConfig(),
            };
            // Make the request
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> response = speechClient.LongRunningRecognize(request);

            // Poll until the returned long-running operation is complete
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LongRunningRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> retrievedResponse = speechClient.PollOnceLongRunningRecognize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LongRunningRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LongRunningRecognizeAsync</summary>
        public async Task LongRunningRecognizeRequestObjectAsync()
        {
            // Snippet: LongRunningRecognizeAsync(LongRunningRecognizeRequest, CallSettings)
            // Additional: LongRunningRecognizeAsync(LongRunningRecognizeRequest, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            LongRunningRecognizeRequest request = new LongRunningRecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
                OutputConfig = new TranscriptOutputConfig(),
            };
            // Make the request
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> response = await speechClient.LongRunningRecognizeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LongRunningRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> retrievedResponse = await speechClient.PollOnceLongRunningRecognizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LongRunningRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LongRunningRecognize</summary>
        public void LongRunningRecognize()
        {
            // Snippet: LongRunningRecognize(RecognitionConfig, RecognitionAudio, CallSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognitionConfig config = new RecognitionConfig();
            RecognitionAudio audio = new RecognitionAudio();
            // Make the request
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> response = speechClient.LongRunningRecognize(config, audio);

            // Poll until the returned long-running operation is complete
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LongRunningRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> retrievedResponse = speechClient.PollOnceLongRunningRecognize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LongRunningRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LongRunningRecognizeAsync</summary>
        public async Task LongRunningRecognizeAsync()
        {
            // Snippet: LongRunningRecognizeAsync(RecognitionConfig, RecognitionAudio, CallSettings)
            // Additional: LongRunningRecognizeAsync(RecognitionConfig, RecognitionAudio, CancellationToken)
            // Create client
            SpeechClient speechClient = await SpeechClient.CreateAsync();
            // Initialize request argument(s)
            RecognitionConfig config = new RecognitionConfig();
            RecognitionAudio audio = new RecognitionAudio();
            // Make the request
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> response = await speechClient.LongRunningRecognizeAsync(config, audio);

            // Poll until the returned long-running operation is complete
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LongRunningRecognizeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> retrievedResponse = await speechClient.PollOnceLongRunningRecognizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LongRunningRecognizeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StreamingRecognize</summary>
        public async Task StreamingRecognize()
        {
            // Snippet: StreamingRecognize(CallSettings, BidirectionalStreamingSettings)
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize streaming call, retrieving the stream object
            using SpeechClient.StreamingRecognizeStream response = speechClient.StreamingRecognize();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamingRecognizeResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamingRecognizeResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamingRecognizeRequest request = new StreamingRecognizeRequest
                {
                    StreamingConfig = new StreamingRecognitionConfig(),
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }
    }
}
