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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.DiscoveryEngine.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGroundedGenerationServiceClientSnippets
    {
        /// <summary>Snippet for StreamGenerateGroundedContent</summary>
        public async Task StreamGenerateGroundedContent()
        {
            // Snippet: StreamGenerateGroundedContent(CallSettings, BidirectionalStreamingSettings)
            // Create client
            GroundedGenerationServiceClient groundedGenerationServiceClient = GroundedGenerationServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using GroundedGenerationServiceClient.StreamGenerateGroundedContentStream response = groundedGenerationServiceClient.StreamGenerateGroundedContent();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<GenerateGroundedContentResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    GenerateGroundedContentResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                GenerateGroundedContentRequest request = new GenerateGroundedContentRequest
                {
                    LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                    Contents =
                    {
                        new GroundedGenerationContent(),
                    },
                    GenerationSpec = new GenerateGroundedContentRequest.Types.GenerationSpec(),
                    GroundingSpec = new GenerateGroundedContentRequest.Types.GroundingSpec(),
                    SystemInstruction = new GroundedGenerationContent(),
                    UserLabels = { { "", "" }, },
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

        /// <summary>Snippet for GenerateGroundedContent</summary>
        public void GenerateGroundedContentRequestObject()
        {
            // Snippet: GenerateGroundedContent(GenerateGroundedContentRequest, CallSettings)
            // Create client
            GroundedGenerationServiceClient groundedGenerationServiceClient = GroundedGenerationServiceClient.Create();
            // Initialize request argument(s)
            GenerateGroundedContentRequest request = new GenerateGroundedContentRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Contents =
                {
                    new GroundedGenerationContent(),
                },
                GenerationSpec = new GenerateGroundedContentRequest.Types.GenerationSpec(),
                GroundingSpec = new GenerateGroundedContentRequest.Types.GroundingSpec(),
                SystemInstruction = new GroundedGenerationContent(),
                UserLabels = { { "", "" }, },
            };
            // Make the request
            GenerateGroundedContentResponse response = groundedGenerationServiceClient.GenerateGroundedContent(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateGroundedContentAsync</summary>
        public async Task GenerateGroundedContentRequestObjectAsync()
        {
            // Snippet: GenerateGroundedContentAsync(GenerateGroundedContentRequest, CallSettings)
            // Additional: GenerateGroundedContentAsync(GenerateGroundedContentRequest, CancellationToken)
            // Create client
            GroundedGenerationServiceClient groundedGenerationServiceClient = await GroundedGenerationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateGroundedContentRequest request = new GenerateGroundedContentRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Contents =
                {
                    new GroundedGenerationContent(),
                },
                GenerationSpec = new GenerateGroundedContentRequest.Types.GenerationSpec(),
                GroundingSpec = new GenerateGroundedContentRequest.Types.GroundingSpec(),
                SystemInstruction = new GroundedGenerationContent(),
                UserLabels = { { "", "" }, },
            };
            // Make the request
            GenerateGroundedContentResponse response = await groundedGenerationServiceClient.GenerateGroundedContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckGrounding</summary>
        public void CheckGroundingRequestObject()
        {
            // Snippet: CheckGrounding(CheckGroundingRequest, CallSettings)
            // Create client
            GroundedGenerationServiceClient groundedGenerationServiceClient = GroundedGenerationServiceClient.Create();
            // Initialize request argument(s)
            CheckGroundingRequest request = new CheckGroundingRequest
            {
                GroundingConfigAsGroundingConfigName = GroundingConfigName.FromProjectLocationGroundingConfig("[PROJECT]", "[LOCATION]", "[GROUNDING_CONFIG]"),
                AnswerCandidate = "",
                Facts =
                {
                    new GroundingFact(),
                },
                GroundingSpec = new CheckGroundingSpec(),
                UserLabels = { { "", "" }, },
            };
            // Make the request
            CheckGroundingResponse response = groundedGenerationServiceClient.CheckGrounding(request);
            // End snippet
        }

        /// <summary>Snippet for CheckGroundingAsync</summary>
        public async Task CheckGroundingRequestObjectAsync()
        {
            // Snippet: CheckGroundingAsync(CheckGroundingRequest, CallSettings)
            // Additional: CheckGroundingAsync(CheckGroundingRequest, CancellationToken)
            // Create client
            GroundedGenerationServiceClient groundedGenerationServiceClient = await GroundedGenerationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CheckGroundingRequest request = new CheckGroundingRequest
            {
                GroundingConfigAsGroundingConfigName = GroundingConfigName.FromProjectLocationGroundingConfig("[PROJECT]", "[LOCATION]", "[GROUNDING_CONFIG]"),
                AnswerCandidate = "",
                Facts =
                {
                    new GroundingFact(),
                },
                GroundingSpec = new CheckGroundingSpec(),
                UserLabels = { { "", "" }, },
            };
            // Make the request
            CheckGroundingResponse response = await groundedGenerationServiceClient.CheckGroundingAsync(request);
            // End snippet
        }
    }
}
