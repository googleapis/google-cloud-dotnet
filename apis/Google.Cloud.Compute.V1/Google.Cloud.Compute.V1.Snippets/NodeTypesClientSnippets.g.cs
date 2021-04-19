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
    public sealed class GeneratedNodeTypesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListNodeTypesRequest, CallSettings)
            // Create client
            NodeTypesClient nodeTypesClient = NodeTypesClient.Create();
            // Initialize request argument(s)
            AggregatedListNodeTypesRequest request = new AggregatedListNodeTypesRequest
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
            NodeTypeAggregatedList response = nodeTypesClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListNodeTypesRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListNodeTypesRequest, CancellationToken)
            // Create client
            NodeTypesClient nodeTypesClient = await NodeTypesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListNodeTypesRequest request = new AggregatedListNodeTypesRequest
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
            NodeTypeAggregatedList response = await nodeTypesClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            NodeTypesClient nodeTypesClient = NodeTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NodeTypeAggregatedList response = nodeTypesClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            NodeTypesClient nodeTypesClient = await NodeTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NodeTypeAggregatedList response = await nodeTypesClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetNodeTypeRequest, CallSettings)
            // Create client
            NodeTypesClient nodeTypesClient = NodeTypesClient.Create();
            // Initialize request argument(s)
            GetNodeTypeRequest request = new GetNodeTypeRequest
            {
                Zone = "",
                NodeType = "",
                Project = "",
            };
            // Make the request
            NodeType response = nodeTypesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetNodeTypeRequest, CallSettings)
            // Additional: GetAsync(GetNodeTypeRequest, CancellationToken)
            // Create client
            NodeTypesClient nodeTypesClient = await NodeTypesClient.CreateAsync();
            // Initialize request argument(s)
            GetNodeTypeRequest request = new GetNodeTypeRequest
            {
                Zone = "",
                NodeType = "",
                Project = "",
            };
            // Make the request
            NodeType response = await nodeTypesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            NodeTypesClient nodeTypesClient = NodeTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeType = "";
            // Make the request
            NodeType response = nodeTypesClient.Get(project, zone, nodeType);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            NodeTypesClient nodeTypesClient = await NodeTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeType = "";
            // Make the request
            NodeType response = await nodeTypesClient.GetAsync(project, zone, nodeType);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListNodeTypesRequest, CallSettings)
            // Create client
            NodeTypesClient nodeTypesClient = NodeTypesClient.Create();
            // Initialize request argument(s)
            ListNodeTypesRequest request = new ListNodeTypesRequest
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
            NodeTypeList response = nodeTypesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListNodeTypesRequest, CallSettings)
            // Additional: ListAsync(ListNodeTypesRequest, CancellationToken)
            // Create client
            NodeTypesClient nodeTypesClient = await NodeTypesClient.CreateAsync();
            // Initialize request argument(s)
            ListNodeTypesRequest request = new ListNodeTypesRequest
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
            NodeTypeList response = await nodeTypesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            NodeTypesClient nodeTypesClient = NodeTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            NodeTypeList response = nodeTypesClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            NodeTypesClient nodeTypesClient = await NodeTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            NodeTypeList response = await nodeTypesClient.ListAsync(project, zone);
            // End snippet
        }
    }
}
