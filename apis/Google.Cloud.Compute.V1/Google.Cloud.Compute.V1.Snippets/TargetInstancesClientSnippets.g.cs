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
    public sealed class GeneratedTargetInstancesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListTargetInstancesRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            AggregatedListTargetInstancesRequest request = new AggregatedListTargetInstancesRequest
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
            TargetInstanceAggregatedList response = targetInstancesClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListTargetInstancesRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListTargetInstancesRequest, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListTargetInstancesRequest request = new AggregatedListTargetInstancesRequest
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
            TargetInstanceAggregatedList response = await targetInstancesClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            TargetInstanceAggregatedList response = targetInstancesClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            TargetInstanceAggregatedList response = await targetInstancesClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteTargetInstanceRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            DeleteTargetInstanceRequest request = new DeleteTargetInstanceRequest
            {
                Zone = "",
                TargetInstance = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = targetInstancesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteTargetInstanceRequest, CallSettings)
            // Additional: DeleteAsync(DeleteTargetInstanceRequest, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetInstanceRequest request = new DeleteTargetInstanceRequest
            {
                Zone = "",
                TargetInstance = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = await targetInstancesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string targetInstance = "";
            // Make the request
            Operation response = targetInstancesClient.Delete(project, zone, targetInstance);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string targetInstance = "";
            // Make the request
            Operation response = await targetInstancesClient.DeleteAsync(project, zone, targetInstance);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetTargetInstanceRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            GetTargetInstanceRequest request = new GetTargetInstanceRequest
            {
                Zone = "",
                TargetInstance = "",
                Project = "",
            };
            // Make the request
            TargetInstance response = targetInstancesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetTargetInstanceRequest, CallSettings)
            // Additional: GetAsync(GetTargetInstanceRequest, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetInstanceRequest request = new GetTargetInstanceRequest
            {
                Zone = "",
                TargetInstance = "",
                Project = "",
            };
            // Make the request
            TargetInstance response = await targetInstancesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string targetInstance = "";
            // Make the request
            TargetInstance response = targetInstancesClient.Get(project, zone, targetInstance);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string targetInstance = "";
            // Make the request
            TargetInstance response = await targetInstancesClient.GetAsync(project, zone, targetInstance);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertTargetInstanceRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            InsertTargetInstanceRequest request = new InsertTargetInstanceRequest
            {
                Zone = "",
                RequestId = "",
                TargetInstanceResource = new TargetInstance(),
                Project = "",
            };
            // Make the request
            Operation response = targetInstancesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertTargetInstanceRequest, CallSettings)
            // Additional: InsertAsync(InsertTargetInstanceRequest, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            InsertTargetInstanceRequest request = new InsertTargetInstanceRequest
            {
                Zone = "",
                RequestId = "",
                TargetInstanceResource = new TargetInstance(),
                Project = "",
            };
            // Make the request
            Operation response = await targetInstancesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, TargetInstance, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            TargetInstance targetInstanceResource = new TargetInstance();
            // Make the request
            Operation response = targetInstancesClient.Insert(project, zone, targetInstanceResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, TargetInstance, CallSettings)
            // Additional: InsertAsync(string, string, TargetInstance, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            TargetInstance targetInstanceResource = new TargetInstance();
            // Make the request
            Operation response = await targetInstancesClient.InsertAsync(project, zone, targetInstanceResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListTargetInstancesRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            ListTargetInstancesRequest request = new ListTargetInstancesRequest
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
            TargetInstanceList response = targetInstancesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListTargetInstancesRequest, CallSettings)
            // Additional: ListAsync(ListTargetInstancesRequest, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetInstancesRequest request = new ListTargetInstancesRequest
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
            TargetInstanceList response = await targetInstancesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            TargetInstanceList response = targetInstancesClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            TargetInstanceList response = await targetInstancesClient.ListAsync(project, zone);
            // End snippet
        }
    }
}
