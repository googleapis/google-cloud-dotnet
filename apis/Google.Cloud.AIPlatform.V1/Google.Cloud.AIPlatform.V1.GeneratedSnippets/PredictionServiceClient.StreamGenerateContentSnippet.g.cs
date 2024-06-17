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
    // [START aiplatform_v1_generated_PredictionService_StreamGenerateContent_sync_flattened]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.AIPlatform.V1;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for StreamGenerateContent</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task StreamGenerateContent()
        {
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string model = "";
            IEnumerable<Content> contents = new Content[]
            {
                new Content
                {
                    Parts =
                    {
                        new Part
                        {
                            Text = "",
                            VideoMetadata = new VideoMetadata { },
                        },
                    },
                },
            };
            // Make the request, returning a streaming response
            using PredictionServiceClient.StreamGenerateContentStream response = predictionServiceClient.StreamGenerateContent(model, contents);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<GenerateContentResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                GenerateContentResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END aiplatform_v1_generated_PredictionService_StreamGenerateContent_sync_flattened]
}
