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
    public sealed class GeneratedRegionDiskTypesClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionDiskTypeRequest, CallSettings)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = RegionDiskTypesClient.Create();
            // Initialize request argument(s)
            GetRegionDiskTypeRequest request = new GetRegionDiskTypeRequest
            {
                DiskType = "",
                Region = "",
                Project = "",
            };
            // Make the request
            DiskType response = regionDiskTypesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionDiskTypeRequest, CallSettings)
            // Additional: GetAsync(GetRegionDiskTypeRequest, CancellationToken)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = await RegionDiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionDiskTypeRequest request = new GetRegionDiskTypeRequest
            {
                DiskType = "",
                Region = "",
                Project = "",
            };
            // Make the request
            DiskType response = await regionDiskTypesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = RegionDiskTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string diskType = "";
            // Make the request
            DiskType response = regionDiskTypesClient.Get(project, region, diskType);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = await RegionDiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string diskType = "";
            // Make the request
            DiskType response = await regionDiskTypesClient.GetAsync(project, region, diskType);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionDiskTypesRequest, CallSettings)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = RegionDiskTypesClient.Create();
            // Initialize request argument(s)
            ListRegionDiskTypesRequest request = new ListRegionDiskTypesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            RegionDiskTypeList response = regionDiskTypesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionDiskTypesRequest, CallSettings)
            // Additional: ListAsync(ListRegionDiskTypesRequest, CancellationToken)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = await RegionDiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionDiskTypesRequest request = new ListRegionDiskTypesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            RegionDiskTypeList response = await regionDiskTypesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = RegionDiskTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            RegionDiskTypeList response = regionDiskTypesClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = await RegionDiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            RegionDiskTypeList response = await regionDiskTypesClient.ListAsync(project, region);
            // End snippet
        }
    }
}
