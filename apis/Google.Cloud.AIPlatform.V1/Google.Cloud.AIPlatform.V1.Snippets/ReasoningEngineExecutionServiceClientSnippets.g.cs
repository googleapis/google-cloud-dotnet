// Copyright 2026 Google LLC
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
    using Google.Api;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedReasoningEngineExecutionServiceClientSnippets
    {
        /// <summary>Snippet for QueryReasoningEngine</summary>
        public void QueryReasoningEngineRequestObject()
        {
            // Snippet: QueryReasoningEngine(QueryReasoningEngineRequest, CallSettings)
            // Create client
            ReasoningEngineExecutionServiceClient reasoningEngineExecutionServiceClient = ReasoningEngineExecutionServiceClient.Create();
            // Initialize request argument(s)
            QueryReasoningEngineRequest request = new QueryReasoningEngineRequest
            {
                ReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                Input = new Struct(),
                ClassMethod = "",
            };
            // Make the request
            QueryReasoningEngineResponse response = reasoningEngineExecutionServiceClient.QueryReasoningEngine(request);
            // End snippet
        }

        /// <summary>Snippet for QueryReasoningEngineAsync</summary>
        public async Task QueryReasoningEngineRequestObjectAsync()
        {
            // Snippet: QueryReasoningEngineAsync(QueryReasoningEngineRequest, CallSettings)
            // Additional: QueryReasoningEngineAsync(QueryReasoningEngineRequest, CancellationToken)
            // Create client
            ReasoningEngineExecutionServiceClient reasoningEngineExecutionServiceClient = await ReasoningEngineExecutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryReasoningEngineRequest request = new QueryReasoningEngineRequest
            {
                ReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                Input = new Struct(),
                ClassMethod = "",
            };
            // Make the request
            QueryReasoningEngineResponse response = await reasoningEngineExecutionServiceClient.QueryReasoningEngineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StreamQueryReasoningEngine</summary>
        public async Task StreamQueryReasoningEngineRequestObject()
        {
            // Snippet: StreamQueryReasoningEngine(StreamQueryReasoningEngineRequest, CallSettings)
            // Create client
            ReasoningEngineExecutionServiceClient reasoningEngineExecutionServiceClient = ReasoningEngineExecutionServiceClient.Create();
            // Initialize request argument(s)
            StreamQueryReasoningEngineRequest request = new StreamQueryReasoningEngineRequest
            {
                ReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                Input = new Struct(),
                ClassMethod = "",
            };
            // Make the request, returning a streaming response
            using ReasoningEngineExecutionServiceClient.StreamQueryReasoningEngineStream response = reasoningEngineExecutionServiceClient.StreamQueryReasoningEngine(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<HttpBody> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                HttpBody responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for AsyncQueryReasoningEngine</summary>
        public void AsyncQueryReasoningEngineRequestObject()
        {
            // Snippet: AsyncQueryReasoningEngine(AsyncQueryReasoningEngineRequest, CallSettings)
            // Create client
            ReasoningEngineExecutionServiceClient reasoningEngineExecutionServiceClient = ReasoningEngineExecutionServiceClient.Create();
            // Initialize request argument(s)
            AsyncQueryReasoningEngineRequest request = new AsyncQueryReasoningEngineRequest
            {
                ReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                InputGcsUri = "",
                OutputGcsUri = "",
            };
            // Make the request
            Operation<AsyncQueryReasoningEngineResponse, AsyncQueryReasoningEngineOperationMetadata> response = reasoningEngineExecutionServiceClient.AsyncQueryReasoningEngine(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncQueryReasoningEngineResponse, AsyncQueryReasoningEngineOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncQueryReasoningEngineResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncQueryReasoningEngineResponse, AsyncQueryReasoningEngineOperationMetadata> retrievedResponse = reasoningEngineExecutionServiceClient.PollOnceAsyncQueryReasoningEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncQueryReasoningEngineResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncQueryReasoningEngineAsync</summary>
        public async Task AsyncQueryReasoningEngineRequestObjectAsync()
        {
            // Snippet: AsyncQueryReasoningEngineAsync(AsyncQueryReasoningEngineRequest, CallSettings)
            // Additional: AsyncQueryReasoningEngineAsync(AsyncQueryReasoningEngineRequest, CancellationToken)
            // Create client
            ReasoningEngineExecutionServiceClient reasoningEngineExecutionServiceClient = await ReasoningEngineExecutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            AsyncQueryReasoningEngineRequest request = new AsyncQueryReasoningEngineRequest
            {
                ReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                InputGcsUri = "",
                OutputGcsUri = "",
            };
            // Make the request
            Operation<AsyncQueryReasoningEngineResponse, AsyncQueryReasoningEngineOperationMetadata> response = await reasoningEngineExecutionServiceClient.AsyncQueryReasoningEngineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncQueryReasoningEngineResponse, AsyncQueryReasoningEngineOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncQueryReasoningEngineResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncQueryReasoningEngineResponse, AsyncQueryReasoningEngineOperationMetadata> retrievedResponse = await reasoningEngineExecutionServiceClient.PollOnceAsyncQueryReasoningEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncQueryReasoningEngineResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
