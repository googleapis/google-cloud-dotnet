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
    public sealed class GeneratedHealthChecksClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListHealthChecksRequest, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            AggregatedListHealthChecksRequest request = new AggregatedListHealthChecksRequest
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
            HealthChecksAggregatedList response = healthChecksClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListHealthChecksRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListHealthChecksRequest, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListHealthChecksRequest request = new AggregatedListHealthChecksRequest
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
            HealthChecksAggregatedList response = await healthChecksClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            HealthChecksAggregatedList response = healthChecksClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            HealthChecksAggregatedList response = await healthChecksClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteHealthCheckRequest, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            DeleteHealthCheckRequest request = new DeleteHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                Project = "",
            };
            // Make the request
            Operation response = healthChecksClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteHealthCheckRequest, CallSettings)
            // Additional: DeleteAsync(DeleteHealthCheckRequest, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteHealthCheckRequest request = new DeleteHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                Project = "",
            };
            // Make the request
            Operation response = await healthChecksClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string healthCheck = "";
            // Make the request
            Operation response = healthChecksClient.Delete(project, healthCheck);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string healthCheck = "";
            // Make the request
            Operation response = await healthChecksClient.DeleteAsync(project, healthCheck);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetHealthCheckRequest, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            GetHealthCheckRequest request = new GetHealthCheckRequest
            {
                HealthCheck = "",
                Project = "",
            };
            // Make the request
            HealthCheck response = healthChecksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetHealthCheckRequest, CallSettings)
            // Additional: GetAsync(GetHealthCheckRequest, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            GetHealthCheckRequest request = new GetHealthCheckRequest
            {
                HealthCheck = "",
                Project = "",
            };
            // Make the request
            HealthCheck response = await healthChecksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string healthCheck = "";
            // Make the request
            HealthCheck response = healthChecksClient.Get(project, healthCheck);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string healthCheck = "";
            // Make the request
            HealthCheck response = await healthChecksClient.GetAsync(project, healthCheck);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertHealthCheckRequest, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            InsertHealthCheckRequest request = new InsertHealthCheckRequest
            {
                RequestId = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = healthChecksClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertHealthCheckRequest, CallSettings)
            // Additional: InsertAsync(InsertHealthCheckRequest, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            InsertHealthCheckRequest request = new InsertHealthCheckRequest
            {
                RequestId = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = await healthChecksClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, HealthCheck, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = healthChecksClient.Insert(project, healthCheckResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, HealthCheck, CallSettings)
            // Additional: InsertAsync(string, HealthCheck, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = await healthChecksClient.InsertAsync(project, healthCheckResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListHealthChecksRequest, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            ListHealthChecksRequest request = new ListHealthChecksRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            HealthCheckList response = healthChecksClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListHealthChecksRequest, CallSettings)
            // Additional: ListAsync(ListHealthChecksRequest, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            ListHealthChecksRequest request = new ListHealthChecksRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            HealthCheckList response = await healthChecksClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            HealthCheckList response = healthChecksClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            HealthCheckList response = await healthChecksClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchHealthCheckRequest, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            PatchHealthCheckRequest request = new PatchHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = healthChecksClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchHealthCheckRequest, CallSettings)
            // Additional: PatchAsync(PatchHealthCheckRequest, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            PatchHealthCheckRequest request = new PatchHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = await healthChecksClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, HealthCheck, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = healthChecksClient.Patch(project, healthCheck, healthCheckResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, HealthCheck, CallSettings)
            // Additional: PatchAsync(string, string, HealthCheck, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = await healthChecksClient.PatchAsync(project, healthCheck, healthCheckResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateHealthCheckRequest, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            UpdateHealthCheckRequest request = new UpdateHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = healthChecksClient.Update(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdateHealthCheckRequest, CallSettings)
            // Additional: UpdateAsync(UpdateHealthCheckRequest, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateHealthCheckRequest request = new UpdateHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = await healthChecksClient.UpdateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, HealthCheck, CallSettings)
            // Create client
            HealthChecksClient healthChecksClient = HealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = healthChecksClient.Update(project, healthCheck, healthCheckResource);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, HealthCheck, CallSettings)
            // Additional: UpdateAsync(string, string, HealthCheck, CancellationToken)
            // Create client
            HealthChecksClient healthChecksClient = await HealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = await healthChecksClient.UpdateAsync(project, healthCheck, healthCheckResource);
            // End snippet
        }
    }
}
