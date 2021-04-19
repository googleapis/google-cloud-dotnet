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
    public sealed class GeneratedTargetPoolsClientSnippets
    {
        /// <summary>Snippet for AddHealthCheck</summary>
        public void AddHealthCheckRequestObject()
        {
            // Snippet: AddHealthCheck(AddHealthCheckTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            AddHealthCheckTargetPoolRequest request = new AddHealthCheckTargetPoolRequest
            {
                TargetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest(),
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = targetPoolsClient.AddHealthCheck(request);
            // End snippet
        }

        /// <summary>Snippet for AddHealthCheckAsync</summary>
        public async Task AddHealthCheckRequestObjectAsync()
        {
            // Snippet: AddHealthCheckAsync(AddHealthCheckTargetPoolRequest, CallSettings)
            // Additional: AddHealthCheckAsync(AddHealthCheckTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            AddHealthCheckTargetPoolRequest request = new AddHealthCheckTargetPoolRequest
            {
                TargetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest(),
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await targetPoolsClient.AddHealthCheckAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddHealthCheck</summary>
        public void AddHealthCheck()
        {
            // Snippet: AddHealthCheck(string, string, string, TargetPoolsAddHealthCheckRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsAddHealthCheckRequest targetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest();
            // Make the request
            Operation response = targetPoolsClient.AddHealthCheck(project, region, targetPool, targetPoolsAddHealthCheckRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AddHealthCheckAsync</summary>
        public async Task AddHealthCheckAsync()
        {
            // Snippet: AddHealthCheckAsync(string, string, string, TargetPoolsAddHealthCheckRequest, CallSettings)
            // Additional: AddHealthCheckAsync(string, string, string, TargetPoolsAddHealthCheckRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsAddHealthCheckRequest targetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest();
            // Make the request
            Operation response = await targetPoolsClient.AddHealthCheckAsync(project, region, targetPool, targetPoolsAddHealthCheckRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AddInstance</summary>
        public void AddInstanceRequestObject()
        {
            // Snippet: AddInstance(AddInstanceTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            AddInstanceTargetPoolRequest request = new AddInstanceTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                TargetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest(),
                Project = "",
            };
            // Make the request
            Operation response = targetPoolsClient.AddInstance(request);
            // End snippet
        }

        /// <summary>Snippet for AddInstanceAsync</summary>
        public async Task AddInstanceRequestObjectAsync()
        {
            // Snippet: AddInstanceAsync(AddInstanceTargetPoolRequest, CallSettings)
            // Additional: AddInstanceAsync(AddInstanceTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            AddInstanceTargetPoolRequest request = new AddInstanceTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                TargetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest(),
                Project = "",
            };
            // Make the request
            Operation response = await targetPoolsClient.AddInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddInstance</summary>
        public void AddInstance()
        {
            // Snippet: AddInstance(string, string, string, TargetPoolsAddInstanceRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsAddInstanceRequest targetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest();
            // Make the request
            Operation response = targetPoolsClient.AddInstance(project, region, targetPool, targetPoolsAddInstanceRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AddInstanceAsync</summary>
        public async Task AddInstanceAsync()
        {
            // Snippet: AddInstanceAsync(string, string, string, TargetPoolsAddInstanceRequest, CallSettings)
            // Additional: AddInstanceAsync(string, string, string, TargetPoolsAddInstanceRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsAddInstanceRequest targetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest();
            // Make the request
            Operation response = await targetPoolsClient.AddInstanceAsync(project, region, targetPool, targetPoolsAddInstanceRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListTargetPoolsRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            AggregatedListTargetPoolsRequest request = new AggregatedListTargetPoolsRequest
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
            TargetPoolAggregatedList response = targetPoolsClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListTargetPoolsRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListTargetPoolsRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListTargetPoolsRequest request = new AggregatedListTargetPoolsRequest
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
            TargetPoolAggregatedList response = await targetPoolsClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            TargetPoolAggregatedList response = targetPoolsClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            TargetPoolAggregatedList response = await targetPoolsClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            DeleteTargetPoolRequest request = new DeleteTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = targetPoolsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteTargetPoolRequest, CallSettings)
            // Additional: DeleteAsync(DeleteTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetPoolRequest request = new DeleteTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await targetPoolsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            // Make the request
            Operation response = targetPoolsClient.Delete(project, region, targetPool);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            // Make the request
            Operation response = await targetPoolsClient.DeleteAsync(project, region, targetPool);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            TargetPool response = targetPoolsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetTargetPoolRequest, CallSettings)
            // Additional: GetAsync(GetTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            TargetPool response = await targetPoolsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            // Make the request
            TargetPool response = targetPoolsClient.Get(project, region, targetPool);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            // Make the request
            TargetPool response = await targetPoolsClient.GetAsync(project, region, targetPool);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealthRequestObject()
        {
            // Snippet: GetHealth(GetHealthTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                InstanceReferenceResource = new InstanceReference(),
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            TargetPoolInstanceHealth response = targetPoolsClient.GetHealth(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthRequestObjectAsync()
        {
            // Snippet: GetHealthAsync(GetHealthTargetPoolRequest, CallSettings)
            // Additional: GetHealthAsync(GetHealthTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                InstanceReferenceResource = new InstanceReference(),
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            TargetPoolInstanceHealth response = await targetPoolsClient.GetHealthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealth()
        {
            // Snippet: GetHealth(string, string, string, InstanceReference, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            InstanceReference instanceReferenceResource = new InstanceReference();
            // Make the request
            TargetPoolInstanceHealth response = targetPoolsClient.GetHealth(project, region, targetPool, instanceReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthAsync()
        {
            // Snippet: GetHealthAsync(string, string, string, InstanceReference, CallSettings)
            // Additional: GetHealthAsync(string, string, string, InstanceReference, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            InstanceReference instanceReferenceResource = new InstanceReference();
            // Make the request
            TargetPoolInstanceHealth response = await targetPoolsClient.GetHealthAsync(project, region, targetPool, instanceReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            InsertTargetPoolRequest request = new InsertTargetPoolRequest
            {
                RequestId = "",
                TargetPoolResource = new TargetPool(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = targetPoolsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertTargetPoolRequest, CallSettings)
            // Additional: InsertAsync(InsertTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            InsertTargetPoolRequest request = new InsertTargetPoolRequest
            {
                RequestId = "",
                TargetPoolResource = new TargetPool(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await targetPoolsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, TargetPool, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetPool targetPoolResource = new TargetPool();
            // Make the request
            Operation response = targetPoolsClient.Insert(project, region, targetPoolResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, TargetPool, CallSettings)
            // Additional: InsertAsync(string, string, TargetPool, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetPool targetPoolResource = new TargetPool();
            // Make the request
            Operation response = await targetPoolsClient.InsertAsync(project, region, targetPoolResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListTargetPoolsRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            ListTargetPoolsRequest request = new ListTargetPoolsRequest
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
            TargetPoolList response = targetPoolsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListTargetPoolsRequest, CallSettings)
            // Additional: ListAsync(ListTargetPoolsRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetPoolsRequest request = new ListTargetPoolsRequest
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
            TargetPoolList response = await targetPoolsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            TargetPoolList response = targetPoolsClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            TargetPoolList response = await targetPoolsClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for RemoveHealthCheck</summary>
        public void RemoveHealthCheckRequestObject()
        {
            // Snippet: RemoveHealthCheck(RemoveHealthCheckTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            RemoveHealthCheckTargetPoolRequest request = new RemoveHealthCheckTargetPoolRequest
            {
                TargetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest(),
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = targetPoolsClient.RemoveHealthCheck(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveHealthCheckAsync</summary>
        public async Task RemoveHealthCheckRequestObjectAsync()
        {
            // Snippet: RemoveHealthCheckAsync(RemoveHealthCheckTargetPoolRequest, CallSettings)
            // Additional: RemoveHealthCheckAsync(RemoveHealthCheckTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            RemoveHealthCheckTargetPoolRequest request = new RemoveHealthCheckTargetPoolRequest
            {
                TargetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest(),
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await targetPoolsClient.RemoveHealthCheckAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveHealthCheck</summary>
        public void RemoveHealthCheck()
        {
            // Snippet: RemoveHealthCheck(string, string, string, TargetPoolsRemoveHealthCheckRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsRemoveHealthCheckRequest targetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest();
            // Make the request
            Operation response = targetPoolsClient.RemoveHealthCheck(project, region, targetPool, targetPoolsRemoveHealthCheckRequestResource);
            // End snippet
        }

        /// <summary>Snippet for RemoveHealthCheckAsync</summary>
        public async Task RemoveHealthCheckAsync()
        {
            // Snippet: RemoveHealthCheckAsync(string, string, string, TargetPoolsRemoveHealthCheckRequest, CallSettings)
            // Additional: RemoveHealthCheckAsync(string, string, string, TargetPoolsRemoveHealthCheckRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsRemoveHealthCheckRequest targetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest();
            // Make the request
            Operation response = await targetPoolsClient.RemoveHealthCheckAsync(project, region, targetPool, targetPoolsRemoveHealthCheckRequestResource);
            // End snippet
        }

        /// <summary>Snippet for RemoveInstance</summary>
        public void RemoveInstanceRequestObject()
        {
            // Snippet: RemoveInstance(RemoveInstanceTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            RemoveInstanceTargetPoolRequest request = new RemoveInstanceTargetPoolRequest
            {
                TargetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest(),
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = targetPoolsClient.RemoveInstance(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveInstanceAsync</summary>
        public async Task RemoveInstanceRequestObjectAsync()
        {
            // Snippet: RemoveInstanceAsync(RemoveInstanceTargetPoolRequest, CallSettings)
            // Additional: RemoveInstanceAsync(RemoveInstanceTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            RemoveInstanceTargetPoolRequest request = new RemoveInstanceTargetPoolRequest
            {
                TargetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest(),
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await targetPoolsClient.RemoveInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveInstance</summary>
        public void RemoveInstance()
        {
            // Snippet: RemoveInstance(string, string, string, TargetPoolsRemoveInstanceRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsRemoveInstanceRequest targetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest();
            // Make the request
            Operation response = targetPoolsClient.RemoveInstance(project, region, targetPool, targetPoolsRemoveInstanceRequestResource);
            // End snippet
        }

        /// <summary>Snippet for RemoveInstanceAsync</summary>
        public async Task RemoveInstanceAsync()
        {
            // Snippet: RemoveInstanceAsync(string, string, string, TargetPoolsRemoveInstanceRequest, CallSettings)
            // Additional: RemoveInstanceAsync(string, string, string, TargetPoolsRemoveInstanceRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsRemoveInstanceRequest targetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest();
            // Make the request
            Operation response = await targetPoolsClient.RemoveInstanceAsync(project, region, targetPool, targetPoolsRemoveInstanceRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetBackup</summary>
        public void SetBackupRequestObject()
        {
            // Snippet: SetBackup(SetBackupTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            SetBackupTargetPoolRequest request = new SetBackupTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                FailoverRatio = 0F,
                Project = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            Operation response = targetPoolsClient.SetBackup(request);
            // End snippet
        }

        /// <summary>Snippet for SetBackupAsync</summary>
        public async Task SetBackupRequestObjectAsync()
        {
            // Snippet: SetBackupAsync(SetBackupTargetPoolRequest, CallSettings)
            // Additional: SetBackupAsync(SetBackupTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            SetBackupTargetPoolRequest request = new SetBackupTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                FailoverRatio = 0F,
                Project = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            Operation response = await targetPoolsClient.SetBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetBackup</summary>
        public void SetBackup()
        {
            // Snippet: SetBackup(string, string, string, TargetReference, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            Operation response = targetPoolsClient.SetBackup(project, region, targetPool, targetReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for SetBackupAsync</summary>
        public async Task SetBackupAsync()
        {
            // Snippet: SetBackupAsync(string, string, string, TargetReference, CallSettings)
            // Additional: SetBackupAsync(string, string, string, TargetReference, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            Operation response = await targetPoolsClient.SetBackupAsync(project, region, targetPool, targetReferenceResource);
            // End snippet
        }
    }
}
