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
    public sealed class GeneratedTargetVpnGatewaysClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListTargetVpnGatewaysRequest, CallSettings)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = TargetVpnGatewaysClient.Create();
            // Initialize request argument(s)
            AggregatedListTargetVpnGatewaysRequest request = new AggregatedListTargetVpnGatewaysRequest
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
            TargetVpnGatewayAggregatedList response = targetVpnGatewaysClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListTargetVpnGatewaysRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListTargetVpnGatewaysRequest, CancellationToken)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = await TargetVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListTargetVpnGatewaysRequest request = new AggregatedListTargetVpnGatewaysRequest
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
            TargetVpnGatewayAggregatedList response = await targetVpnGatewaysClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = TargetVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            TargetVpnGatewayAggregatedList response = targetVpnGatewaysClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = await TargetVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            TargetVpnGatewayAggregatedList response = await targetVpnGatewaysClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteTargetVpnGatewayRequest, CallSettings)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = TargetVpnGatewaysClient.Create();
            // Initialize request argument(s)
            DeleteTargetVpnGatewayRequest request = new DeleteTargetVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                TargetVpnGateway = "",
            };
            // Make the request
            Operation response = targetVpnGatewaysClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteTargetVpnGatewayRequest, CallSettings)
            // Additional: DeleteAsync(DeleteTargetVpnGatewayRequest, CancellationToken)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = await TargetVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetVpnGatewayRequest request = new DeleteTargetVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                TargetVpnGateway = "",
            };
            // Make the request
            Operation response = await targetVpnGatewaysClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = TargetVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetVpnGateway = "";
            // Make the request
            Operation response = targetVpnGatewaysClient.Delete(project, region, targetVpnGateway);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = await TargetVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetVpnGateway = "";
            // Make the request
            Operation response = await targetVpnGatewaysClient.DeleteAsync(project, region, targetVpnGateway);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetTargetVpnGatewayRequest, CallSettings)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = TargetVpnGatewaysClient.Create();
            // Initialize request argument(s)
            GetTargetVpnGatewayRequest request = new GetTargetVpnGatewayRequest
            {
                Region = "",
                Project = "",
                TargetVpnGateway = "",
            };
            // Make the request
            TargetVpnGateway response = targetVpnGatewaysClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetTargetVpnGatewayRequest, CallSettings)
            // Additional: GetAsync(GetTargetVpnGatewayRequest, CancellationToken)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = await TargetVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetVpnGatewayRequest request = new GetTargetVpnGatewayRequest
            {
                Region = "",
                Project = "",
                TargetVpnGateway = "",
            };
            // Make the request
            TargetVpnGateway response = await targetVpnGatewaysClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = TargetVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetVpnGateway = "";
            // Make the request
            TargetVpnGateway response = targetVpnGatewaysClient.Get(project, region, targetVpnGateway);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = await TargetVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetVpnGateway = "";
            // Make the request
            TargetVpnGateway response = await targetVpnGatewaysClient.GetAsync(project, region, targetVpnGateway);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertTargetVpnGatewayRequest, CallSettings)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = TargetVpnGatewaysClient.Create();
            // Initialize request argument(s)
            InsertTargetVpnGatewayRequest request = new InsertTargetVpnGatewayRequest
            {
                TargetVpnGatewayResource = new TargetVpnGateway(),
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = targetVpnGatewaysClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertTargetVpnGatewayRequest, CallSettings)
            // Additional: InsertAsync(InsertTargetVpnGatewayRequest, CancellationToken)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = await TargetVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            InsertTargetVpnGatewayRequest request = new InsertTargetVpnGatewayRequest
            {
                TargetVpnGatewayResource = new TargetVpnGateway(),
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await targetVpnGatewaysClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, TargetVpnGateway, CallSettings)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = TargetVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetVpnGateway targetVpnGatewayResource = new TargetVpnGateway();
            // Make the request
            Operation response = targetVpnGatewaysClient.Insert(project, region, targetVpnGatewayResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, TargetVpnGateway, CallSettings)
            // Additional: InsertAsync(string, string, TargetVpnGateway, CancellationToken)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = await TargetVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetVpnGateway targetVpnGatewayResource = new TargetVpnGateway();
            // Make the request
            Operation response = await targetVpnGatewaysClient.InsertAsync(project, region, targetVpnGatewayResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListTargetVpnGatewaysRequest, CallSettings)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = TargetVpnGatewaysClient.Create();
            // Initialize request argument(s)
            ListTargetVpnGatewaysRequest request = new ListTargetVpnGatewaysRequest
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
            TargetVpnGatewayList response = targetVpnGatewaysClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListTargetVpnGatewaysRequest, CallSettings)
            // Additional: ListAsync(ListTargetVpnGatewaysRequest, CancellationToken)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = await TargetVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetVpnGatewaysRequest request = new ListTargetVpnGatewaysRequest
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
            TargetVpnGatewayList response = await targetVpnGatewaysClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = TargetVpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            TargetVpnGatewayList response = targetVpnGatewaysClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            TargetVpnGatewaysClient targetVpnGatewaysClient = await TargetVpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            TargetVpnGatewayList response = await targetVpnGatewaysClient.ListAsync(project, region);
            // End snippet
        }
    }
}
