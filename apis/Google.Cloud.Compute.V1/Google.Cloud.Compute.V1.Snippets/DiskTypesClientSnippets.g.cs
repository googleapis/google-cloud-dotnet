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
    public sealed class GeneratedDiskTypesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListDiskTypesRequest, CallSettings)
            // Create client
            DiskTypesClient diskTypesClient = DiskTypesClient.Create();
            // Initialize request argument(s)
            AggregatedListDiskTypesRequest request = new AggregatedListDiskTypesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            DiskTypeAggregatedList response = diskTypesClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListDiskTypesRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListDiskTypesRequest, CancellationToken)
            // Create client
            DiskTypesClient diskTypesClient = await DiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListDiskTypesRequest request = new AggregatedListDiskTypesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            DiskTypeAggregatedList response = await diskTypesClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            DiskTypesClient diskTypesClient = DiskTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            DiskTypeAggregatedList response = diskTypesClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            DiskTypesClient diskTypesClient = await DiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            DiskTypeAggregatedList response = await diskTypesClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetDiskTypeRequest, CallSettings)
            // Create client
            DiskTypesClient diskTypesClient = DiskTypesClient.Create();
            // Initialize request argument(s)
            GetDiskTypeRequest request = new GetDiskTypeRequest
            {
                Zone = "",
                DiskType = "",
                Project = "",
            };
            // Make the request
            DiskType response = diskTypesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetDiskTypeRequest, CallSettings)
            // Additional: GetAsync(GetDiskTypeRequest, CancellationToken)
            // Create client
            DiskTypesClient diskTypesClient = await DiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            GetDiskTypeRequest request = new GetDiskTypeRequest
            {
                Zone = "",
                DiskType = "",
                Project = "",
            };
            // Make the request
            DiskType response = await diskTypesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            DiskTypesClient diskTypesClient = DiskTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string diskType = "";
            // Make the request
            DiskType response = diskTypesClient.Get(project, zone, diskType);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            DiskTypesClient diskTypesClient = await DiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string diskType = "";
            // Make the request
            DiskType response = await diskTypesClient.GetAsync(project, zone, diskType);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListDiskTypesRequest, CallSettings)
            // Create client
            DiskTypesClient diskTypesClient = DiskTypesClient.Create();
            // Initialize request argument(s)
            ListDiskTypesRequest request = new ListDiskTypesRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            DiskTypeList response = diskTypesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListDiskTypesRequest, CallSettings)
            // Additional: ListAsync(ListDiskTypesRequest, CancellationToken)
            // Create client
            DiskTypesClient diskTypesClient = await DiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            ListDiskTypesRequest request = new ListDiskTypesRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            DiskTypeList response = await diskTypesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            DiskTypesClient diskTypesClient = DiskTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            DiskTypeList response = diskTypesClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            DiskTypesClient diskTypesClient = await DiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            DiskTypeList response = await diskTypesClient.ListAsync(project, zone);
            // End snippet
        }
    }
}
