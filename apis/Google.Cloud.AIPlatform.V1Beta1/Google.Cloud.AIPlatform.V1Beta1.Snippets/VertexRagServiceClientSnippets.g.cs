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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1Beta1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVertexRagServiceClientSnippets
    {
        /// <summary>Snippet for RetrieveContexts</summary>
        public void RetrieveContextsRequestObject()
        {
            // Snippet: RetrieveContexts(RetrieveContextsRequest, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            RetrieveContextsRequest request = new RetrieveContextsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VertexRagStore = new RetrieveContextsRequest.Types.VertexRagStore(),
                Query = new RagQuery(),
            };
            // Make the request
            RetrieveContextsResponse response = vertexRagServiceClient.RetrieveContexts(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveContextsAsync</summary>
        public async Task RetrieveContextsRequestObjectAsync()
        {
            // Snippet: RetrieveContextsAsync(RetrieveContextsRequest, CallSettings)
            // Additional: RetrieveContextsAsync(RetrieveContextsRequest, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveContextsRequest request = new RetrieveContextsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VertexRagStore = new RetrieveContextsRequest.Types.VertexRagStore(),
                Query = new RagQuery(),
            };
            // Make the request
            RetrieveContextsResponse response = await vertexRagServiceClient.RetrieveContextsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveContexts</summary>
        public void RetrieveContexts()
        {
            // Snippet: RetrieveContexts(string, RagQuery, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RagQuery query = new RagQuery();
            // Make the request
            RetrieveContextsResponse response = vertexRagServiceClient.RetrieveContexts(parent, query);
            // End snippet
        }

        /// <summary>Snippet for RetrieveContextsAsync</summary>
        public async Task RetrieveContextsAsync()
        {
            // Snippet: RetrieveContextsAsync(string, RagQuery, CallSettings)
            // Additional: RetrieveContextsAsync(string, RagQuery, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RagQuery query = new RagQuery();
            // Make the request
            RetrieveContextsResponse response = await vertexRagServiceClient.RetrieveContextsAsync(parent, query);
            // End snippet
        }

        /// <summary>Snippet for RetrieveContexts</summary>
        public void RetrieveContextsResourceNames()
        {
            // Snippet: RetrieveContexts(LocationName, RagQuery, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RagQuery query = new RagQuery();
            // Make the request
            RetrieveContextsResponse response = vertexRagServiceClient.RetrieveContexts(parent, query);
            // End snippet
        }

        /// <summary>Snippet for RetrieveContextsAsync</summary>
        public async Task RetrieveContextsResourceNamesAsync()
        {
            // Snippet: RetrieveContextsAsync(LocationName, RagQuery, CallSettings)
            // Additional: RetrieveContextsAsync(LocationName, RagQuery, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RagQuery query = new RagQuery();
            // Make the request
            RetrieveContextsResponse response = await vertexRagServiceClient.RetrieveContextsAsync(parent, query);
            // End snippet
        }
    }
}
