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
    using Google.Cloud.AIPlatform.V1Beta1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMatchServiceClientSnippets
    {
        /// <summary>Snippet for FindNeighbors</summary>
        public void FindNeighborsRequestObject()
        {
            // Snippet: FindNeighbors(FindNeighborsRequest, CallSettings)
            // Create client
            MatchServiceClient matchServiceClient = MatchServiceClient.Create();
            // Initialize request argument(s)
            FindNeighborsRequest request = new FindNeighborsRequest
            {
                IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndexId = "",
                Queries =
                {
                    new FindNeighborsRequest.Types.Query(),
                },
                ReturnFullDatapoint = false,
            };
            // Make the request
            FindNeighborsResponse response = matchServiceClient.FindNeighbors(request);
            // End snippet
        }

        /// <summary>Snippet for FindNeighborsAsync</summary>
        public async Task FindNeighborsRequestObjectAsync()
        {
            // Snippet: FindNeighborsAsync(FindNeighborsRequest, CallSettings)
            // Additional: FindNeighborsAsync(FindNeighborsRequest, CancellationToken)
            // Create client
            MatchServiceClient matchServiceClient = await MatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            FindNeighborsRequest request = new FindNeighborsRequest
            {
                IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndexId = "",
                Queries =
                {
                    new FindNeighborsRequest.Types.Query(),
                },
                ReturnFullDatapoint = false,
            };
            // Make the request
            FindNeighborsResponse response = await matchServiceClient.FindNeighborsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadIndexDatapoints</summary>
        public void ReadIndexDatapointsRequestObject()
        {
            // Snippet: ReadIndexDatapoints(ReadIndexDatapointsRequest, CallSettings)
            // Create client
            MatchServiceClient matchServiceClient = MatchServiceClient.Create();
            // Initialize request argument(s)
            ReadIndexDatapointsRequest request = new ReadIndexDatapointsRequest
            {
                IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndexId = "",
                Ids = { "", },
            };
            // Make the request
            ReadIndexDatapointsResponse response = matchServiceClient.ReadIndexDatapoints(request);
            // End snippet
        }

        /// <summary>Snippet for ReadIndexDatapointsAsync</summary>
        public async Task ReadIndexDatapointsRequestObjectAsync()
        {
            // Snippet: ReadIndexDatapointsAsync(ReadIndexDatapointsRequest, CallSettings)
            // Additional: ReadIndexDatapointsAsync(ReadIndexDatapointsRequest, CancellationToken)
            // Create client
            MatchServiceClient matchServiceClient = await MatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReadIndexDatapointsRequest request = new ReadIndexDatapointsRequest
            {
                IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndexId = "",
                Ids = { "", },
            };
            // Make the request
            ReadIndexDatapointsResponse response = await matchServiceClient.ReadIndexDatapointsAsync(request);
            // End snippet
        }
    }
}
