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
    // [START discoveryengine_v1_generated_GroundedGenerationService_StreamGenerateGroundedContent_sync]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.DiscoveryEngine.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGroundedGenerationServiceClientSnippets
    {
        /// <summary>Snippet for StreamGenerateGroundedContent</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task StreamGenerateGroundedContent()
        {
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
        }
    }
    // [END discoveryengine_v1_generated_GroundedGenerationService_StreamGenerateGroundedContent_sync]
}
