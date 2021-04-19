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
    public sealed class GeneratedRegionHealthChecksClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionHealthCheckRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            DeleteRegionHealthCheckRequest request = new DeleteRegionHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = regionHealthChecksClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteRegionHealthCheckRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionHealthCheckRequest, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionHealthCheckRequest request = new DeleteRegionHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await regionHealthChecksClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            // Make the request
            Operation response = regionHealthChecksClient.Delete(project, region, healthCheck);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            // Make the request
            Operation response = await regionHealthChecksClient.DeleteAsync(project, region, healthCheck);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionHealthCheckRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            GetRegionHealthCheckRequest request = new GetRegionHealthCheckRequest
            {
                HealthCheck = "",
                Region = "",
                Project = "",
            };
            // Make the request
            HealthCheck response = regionHealthChecksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionHealthCheckRequest, CallSettings)
            // Additional: GetAsync(GetRegionHealthCheckRequest, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionHealthCheckRequest request = new GetRegionHealthCheckRequest
            {
                HealthCheck = "",
                Region = "",
                Project = "",
            };
            // Make the request
            HealthCheck response = await regionHealthChecksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            // Make the request
            HealthCheck response = regionHealthChecksClient.Get(project, region, healthCheck);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            // Make the request
            HealthCheck response = await regionHealthChecksClient.GetAsync(project, region, healthCheck);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionHealthCheckRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            InsertRegionHealthCheckRequest request = new InsertRegionHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = regionHealthChecksClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertRegionHealthCheckRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionHealthCheckRequest, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionHealthCheckRequest request = new InsertRegionHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = await regionHealthChecksClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, HealthCheck, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = regionHealthChecksClient.Insert(project, region, healthCheckResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, HealthCheck, CallSettings)
            // Additional: InsertAsync(string, string, HealthCheck, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = await regionHealthChecksClient.InsertAsync(project, region, healthCheckResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionHealthChecksRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            ListRegionHealthChecksRequest request = new ListRegionHealthChecksRequest
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
            HealthCheckList response = regionHealthChecksClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionHealthChecksRequest, CallSettings)
            // Additional: ListAsync(ListRegionHealthChecksRequest, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionHealthChecksRequest request = new ListRegionHealthChecksRequest
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
            HealthCheckList response = await regionHealthChecksClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            HealthCheckList response = regionHealthChecksClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            HealthCheckList response = await regionHealthChecksClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchRegionHealthCheckRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            PatchRegionHealthCheckRequest request = new PatchRegionHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = regionHealthChecksClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchRegionHealthCheckRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionHealthCheckRequest, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionHealthCheckRequest request = new PatchRegionHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = await regionHealthChecksClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, HealthCheck, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = regionHealthChecksClient.Patch(project, region, healthCheck, healthCheckResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, HealthCheck, CallSettings)
            // Additional: PatchAsync(string, string, string, HealthCheck, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = await regionHealthChecksClient.PatchAsync(project, region, healthCheck, healthCheckResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateRegionHealthCheckRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            UpdateRegionHealthCheckRequest request = new UpdateRegionHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = regionHealthChecksClient.Update(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdateRegionHealthCheckRequest, CallSettings)
            // Additional: UpdateAsync(UpdateRegionHealthCheckRequest, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRegionHealthCheckRequest request = new UpdateRegionHealthCheckRequest
            {
                RequestId = "",
                HealthCheck = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            Operation response = await regionHealthChecksClient.UpdateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, string, HealthCheck, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = regionHealthChecksClient.Update(project, region, healthCheck, healthCheckResource);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, string, HealthCheck, CallSettings)
            // Additional: UpdateAsync(string, string, string, HealthCheck, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            Operation response = await regionHealthChecksClient.UpdateAsync(project, region, healthCheck, healthCheckResource);
            // End snippet
        }
    }
}
