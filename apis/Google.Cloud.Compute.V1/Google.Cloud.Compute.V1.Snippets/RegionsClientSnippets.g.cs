// Copyright 2021 Google LLC
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

namespace Google.Cloud.Compute.V1.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedRegionsClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionRequest, CallSettings)
            // Create client
            RegionsClient regionsClient = RegionsClient.Create();
            // Initialize request argument(s)
            GetRegionRequest request = new GetRegionRequest
            {
                Region = "",
                Project = "",
            };
            // Make the request
            Region response = regionsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionRequest, CallSettings)
            // Additional: GetAsync(GetRegionRequest, CancellationToken)
            // Create client
            RegionsClient regionsClient = await RegionsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionRequest request = new GetRegionRequest
            {
                Region = "",
                Project = "",
            };
            // Make the request
            Region response = await regionsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            RegionsClient regionsClient = RegionsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            Region response = regionsClient.Get(project, region);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            RegionsClient regionsClient = await RegionsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            Region response = await regionsClient.GetAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionsRequest, CallSettings)
            // Create client
            RegionsClient regionsClient = RegionsClient.Create();
            // Initialize request argument(s)
            ListRegionsRequest request = new ListRegionsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            RegionList response = regionsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionsRequest, CallSettings)
            // Additional: ListAsync(ListRegionsRequest, CancellationToken)
            // Create client
            RegionsClient regionsClient = await RegionsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionsRequest request = new ListRegionsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            RegionList response = await regionsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            RegionsClient regionsClient = RegionsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            RegionList response = regionsClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            RegionsClient regionsClient = await RegionsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            RegionList response = await regionsClient.ListAsync(project);
            // End snippet
        }
    }
}
