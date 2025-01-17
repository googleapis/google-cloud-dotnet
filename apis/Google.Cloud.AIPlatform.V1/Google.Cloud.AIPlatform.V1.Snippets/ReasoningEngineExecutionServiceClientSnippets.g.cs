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
    using Google.Api;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.AIPlatform.V1;
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
    }
}
