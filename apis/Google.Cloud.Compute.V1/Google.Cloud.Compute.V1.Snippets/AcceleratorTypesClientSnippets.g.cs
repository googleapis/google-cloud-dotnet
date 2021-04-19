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
    public sealed class GeneratedAcceleratorTypesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListAcceleratorTypesRequest, CallSettings)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = AcceleratorTypesClient.Create();
            // Initialize request argument(s)
            AggregatedListAcceleratorTypesRequest request = new AggregatedListAcceleratorTypesRequest
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
            AcceleratorTypeAggregatedList response = acceleratorTypesClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListAcceleratorTypesRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListAcceleratorTypesRequest, CancellationToken)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = await AcceleratorTypesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListAcceleratorTypesRequest request = new AggregatedListAcceleratorTypesRequest
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
            AcceleratorTypeAggregatedList response = await acceleratorTypesClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = AcceleratorTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            AcceleratorTypeAggregatedList response = acceleratorTypesClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = await AcceleratorTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            AcceleratorTypeAggregatedList response = await acceleratorTypesClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetAcceleratorTypeRequest, CallSettings)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = AcceleratorTypesClient.Create();
            // Initialize request argument(s)
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                Zone = "",
                AcceleratorType = "",
                Project = "",
            };
            // Make the request
            AcceleratorType response = acceleratorTypesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetAcceleratorTypeRequest, CallSettings)
            // Additional: GetAsync(GetAcceleratorTypeRequest, CancellationToken)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = await AcceleratorTypesClient.CreateAsync();
            // Initialize request argument(s)
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                Zone = "",
                AcceleratorType = "",
                Project = "",
            };
            // Make the request
            AcceleratorType response = await acceleratorTypesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = AcceleratorTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string acceleratorType = "";
            // Make the request
            AcceleratorType response = acceleratorTypesClient.Get(project, zone, acceleratorType);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = await AcceleratorTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string acceleratorType = "";
            // Make the request
            AcceleratorType response = await acceleratorTypesClient.GetAsync(project, zone, acceleratorType);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListAcceleratorTypesRequest, CallSettings)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = AcceleratorTypesClient.Create();
            // Initialize request argument(s)
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
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
            AcceleratorTypeList response = acceleratorTypesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListAcceleratorTypesRequest, CallSettings)
            // Additional: ListAsync(ListAcceleratorTypesRequest, CancellationToken)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = await AcceleratorTypesClient.CreateAsync();
            // Initialize request argument(s)
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
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
            AcceleratorTypeList response = await acceleratorTypesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = AcceleratorTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            AcceleratorTypeList response = acceleratorTypesClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            AcceleratorTypesClient acceleratorTypesClient = await AcceleratorTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            AcceleratorTypeList response = await acceleratorTypesClient.ListAsync(project, zone);
            // End snippet
        }
    }
}
