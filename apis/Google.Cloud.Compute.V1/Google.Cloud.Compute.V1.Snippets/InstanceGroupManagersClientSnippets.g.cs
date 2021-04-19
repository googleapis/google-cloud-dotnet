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
    public sealed class GeneratedInstanceGroupManagersClientSnippets
    {
        /// <summary>Snippet for AbandonInstances</summary>
        public void AbandonInstancesRequestObject()
        {
            // Snippet: AbandonInstances(AbandonInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            AbandonInstancesInstanceGroupManagerRequest request = new AbandonInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = instanceGroupManagersClient.AbandonInstances(request);
            // End snippet
        }

        /// <summary>Snippet for AbandonInstancesAsync</summary>
        public async Task AbandonInstancesRequestObjectAsync()
        {
            // Snippet: AbandonInstancesAsync(AbandonInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: AbandonInstancesAsync(AbandonInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            AbandonInstancesInstanceGroupManagerRequest request = new AbandonInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.AbandonInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AbandonInstances</summary>
        public void AbandonInstances()
        {
            // Snippet: AbandonInstances(string, string, string, InstanceGroupManagersAbandonInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersAbandonInstancesRequest instanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest();
            // Make the request
            Operation response = instanceGroupManagersClient.AbandonInstances(project, zone, instanceGroupManager, instanceGroupManagersAbandonInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AbandonInstancesAsync</summary>
        public async Task AbandonInstancesAsync()
        {
            // Snippet: AbandonInstancesAsync(string, string, string, InstanceGroupManagersAbandonInstancesRequest, CallSettings)
            // Additional: AbandonInstancesAsync(string, string, string, InstanceGroupManagersAbandonInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersAbandonInstancesRequest instanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest();
            // Make the request
            Operation response = await instanceGroupManagersClient.AbandonInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersAbandonInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            AggregatedListInstanceGroupManagersRequest request = new AggregatedListInstanceGroupManagersRequest
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
            InstanceGroupManagerAggregatedList response = instanceGroupManagersClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListInstanceGroupManagersRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListInstanceGroupManagersRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListInstanceGroupManagersRequest request = new AggregatedListInstanceGroupManagersRequest
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
            InstanceGroupManagerAggregatedList response = await instanceGroupManagersClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            InstanceGroupManagerAggregatedList response = instanceGroupManagersClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            InstanceGroupManagerAggregatedList response = await instanceGroupManagersClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstances</summary>
        public void ApplyUpdatesToInstancesRequestObject()
        {
            // Snippet: ApplyUpdatesToInstances(ApplyUpdatesToInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ApplyUpdatesToInstancesInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest(),
            };
            // Make the request
            Operation response = instanceGroupManagersClient.ApplyUpdatesToInstances(request);
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstancesAsync</summary>
        public async Task ApplyUpdatesToInstancesRequestObjectAsync()
        {
            // Snippet: ApplyUpdatesToInstancesAsync(ApplyUpdatesToInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: ApplyUpdatesToInstancesAsync(ApplyUpdatesToInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ApplyUpdatesToInstancesInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest(),
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.ApplyUpdatesToInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstances</summary>
        public void ApplyUpdatesToInstances()
        {
            // Snippet: ApplyUpdatesToInstances(string, string, string, InstanceGroupManagersApplyUpdatesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersApplyUpdatesRequest instanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest();
            // Make the request
            Operation response = instanceGroupManagersClient.ApplyUpdatesToInstances(project, zone, instanceGroupManager, instanceGroupManagersApplyUpdatesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstancesAsync</summary>
        public async Task ApplyUpdatesToInstancesAsync()
        {
            // Snippet: ApplyUpdatesToInstancesAsync(string, string, string, InstanceGroupManagersApplyUpdatesRequest, CallSettings)
            // Additional: ApplyUpdatesToInstancesAsync(string, string, string, InstanceGroupManagersApplyUpdatesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersApplyUpdatesRequest instanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest();
            // Make the request
            Operation response = await instanceGroupManagersClient.ApplyUpdatesToInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersApplyUpdatesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for CreateInstances</summary>
        public void CreateInstancesRequestObject()
        {
            // Snippet: CreateInstances(CreateInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            CreateInstancesInstanceGroupManagerRequest request = new CreateInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = instanceGroupManagersClient.CreateInstances(request);
            // End snippet
        }

        /// <summary>Snippet for CreateInstancesAsync</summary>
        public async Task CreateInstancesRequestObjectAsync()
        {
            // Snippet: CreateInstancesAsync(CreateInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: CreateInstancesAsync(CreateInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstancesInstanceGroupManagerRequest request = new CreateInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.CreateInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateInstances</summary>
        public void CreateInstances()
        {
            // Snippet: CreateInstances(string, string, string, InstanceGroupManagersCreateInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersCreateInstancesRequest instanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest();
            // Make the request
            Operation response = instanceGroupManagersClient.CreateInstances(project, zone, instanceGroupManager, instanceGroupManagersCreateInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for CreateInstancesAsync</summary>
        public async Task CreateInstancesAsync()
        {
            // Snippet: CreateInstancesAsync(string, string, string, InstanceGroupManagersCreateInstancesRequest, CallSettings)
            // Additional: CreateInstancesAsync(string, string, string, InstanceGroupManagersCreateInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersCreateInstancesRequest instanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest();
            // Make the request
            Operation response = await instanceGroupManagersClient.CreateInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersCreateInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeleteInstanceGroupManagerRequest request = new DeleteInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = instanceGroupManagersClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteInstanceGroupManagerRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceGroupManagerRequest request = new DeleteInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            Operation response = instanceGroupManagersClient.Delete(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            Operation response = await instanceGroupManagersClient.DeleteAsync(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstances</summary>
        public void DeleteInstancesRequestObject()
        {
            // Snippet: DeleteInstances(DeleteInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeleteInstancesInstanceGroupManagerRequest request = new DeleteInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = instanceGroupManagersClient.DeleteInstances(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancesAsync</summary>
        public async Task DeleteInstancesRequestObjectAsync()
        {
            // Snippet: DeleteInstancesAsync(DeleteInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: DeleteInstancesAsync(DeleteInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstancesInstanceGroupManagerRequest request = new DeleteInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.DeleteInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstances</summary>
        public void DeleteInstances()
        {
            // Snippet: DeleteInstances(string, string, string, InstanceGroupManagersDeleteInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersDeleteInstancesRequest instanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest();
            // Make the request
            Operation response = instanceGroupManagersClient.DeleteInstances(project, zone, instanceGroupManager, instanceGroupManagersDeleteInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancesAsync</summary>
        public async Task DeleteInstancesAsync()
        {
            // Snippet: DeleteInstancesAsync(string, string, string, InstanceGroupManagersDeleteInstancesRequest, CallSettings)
            // Additional: DeleteInstancesAsync(string, string, string, InstanceGroupManagersDeleteInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersDeleteInstancesRequest instanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest();
            // Make the request
            Operation response = await instanceGroupManagersClient.DeleteInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersDeleteInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigs</summary>
        public void DeletePerInstanceConfigsRequestObject()
        {
            // Snippet: DeletePerInstanceConfigs(DeletePerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeletePerInstanceConfigsInstanceGroupManagerRequest request = new DeletePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = instanceGroupManagersClient.DeletePerInstanceConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigsAsync</summary>
        public async Task DeletePerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: DeletePerInstanceConfigsAsync(DeletePerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Additional: DeletePerInstanceConfigsAsync(DeletePerInstanceConfigsInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeletePerInstanceConfigsInstanceGroupManagerRequest request = new DeletePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.DeletePerInstanceConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigs</summary>
        public void DeletePerInstanceConfigs()
        {
            // Snippet: DeletePerInstanceConfigs(string, string, string, InstanceGroupManagersDeletePerInstanceConfigsReq, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersDeletePerInstanceConfigsReq instanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq();
            // Make the request
            Operation response = instanceGroupManagersClient.DeletePerInstanceConfigs(project, zone, instanceGroupManager, instanceGroupManagersDeletePerInstanceConfigsReqResource);
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigsAsync</summary>
        public async Task DeletePerInstanceConfigsAsync()
        {
            // Snippet: DeletePerInstanceConfigsAsync(string, string, string, InstanceGroupManagersDeletePerInstanceConfigsReq, CallSettings)
            // Additional: DeletePerInstanceConfigsAsync(string, string, string, InstanceGroupManagersDeletePerInstanceConfigsReq, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersDeletePerInstanceConfigsReq instanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq();
            // Make the request
            Operation response = await instanceGroupManagersClient.DeletePerInstanceConfigsAsync(project, zone, instanceGroupManager, instanceGroupManagersDeletePerInstanceConfigsReqResource);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            GetInstanceGroupManagerRequest request = new GetInstanceGroupManagerRequest
            {
                Zone = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManager response = instanceGroupManagersClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInstanceGroupManagerRequest, CallSettings)
            // Additional: GetAsync(GetInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceGroupManagerRequest request = new GetInstanceGroupManagerRequest
            {
                Zone = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManager response = await instanceGroupManagersClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManager response = instanceGroupManagersClient.Get(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManager response = await instanceGroupManagersClient.GetAsync(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            InsertInstanceGroupManagerRequest request = new InsertInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            Operation response = instanceGroupManagersClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertInstanceGroupManagerRequest, CallSettings)
            // Additional: InsertAsync(InsertInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            InsertInstanceGroupManagerRequest request = new InsertInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, InstanceGroupManager, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            Operation response = instanceGroupManagersClient.Insert(project, zone, instanceGroupManagerResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, InstanceGroupManager, CallSettings)
            // Additional: InsertAsync(string, string, InstanceGroupManager, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            Operation response = await instanceGroupManagersClient.InsertAsync(project, zone, instanceGroupManagerResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListInstanceGroupManagersRequest request = new ListInstanceGroupManagersRequest
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
            InstanceGroupManagerList response = instanceGroupManagersClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListInstanceGroupManagersRequest, CallSettings)
            // Additional: ListAsync(ListInstanceGroupManagersRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListInstanceGroupManagersRequest request = new ListInstanceGroupManagersRequest
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
            InstanceGroupManagerList response = await instanceGroupManagersClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            InstanceGroupManagerList response = instanceGroupManagersClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            InstanceGroupManagerList response = await instanceGroupManagersClient.ListAsync(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListErrors</summary>
        public void ListErrorsRequestObject()
        {
            // Snippet: ListErrors(ListErrorsInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListErrorsInstanceGroupManagersRequest request = new ListErrorsInstanceGroupManagersRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManagersListErrorsResponse response = instanceGroupManagersClient.ListErrors(request);
            // End snippet
        }

        /// <summary>Snippet for ListErrorsAsync</summary>
        public async Task ListErrorsRequestObjectAsync()
        {
            // Snippet: ListErrorsAsync(ListErrorsInstanceGroupManagersRequest, CallSettings)
            // Additional: ListErrorsAsync(ListErrorsInstanceGroupManagersRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListErrorsInstanceGroupManagersRequest request = new ListErrorsInstanceGroupManagersRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManagersListErrorsResponse response = await instanceGroupManagersClient.ListErrorsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListErrors</summary>
        public void ListErrors()
        {
            // Snippet: ListErrors(string, string, string, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManagersListErrorsResponse response = instanceGroupManagersClient.ListErrors(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for ListErrorsAsync</summary>
        public async Task ListErrorsAsync()
        {
            // Snippet: ListErrorsAsync(string, string, string, CallSettings)
            // Additional: ListErrorsAsync(string, string, string, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManagersListErrorsResponse response = await instanceGroupManagersClient.ListErrorsAsync(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstances</summary>
        public void ListManagedInstancesRequestObject()
        {
            // Snippet: ListManagedInstances(ListManagedInstancesInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListManagedInstancesInstanceGroupManagersRequest request = new ListManagedInstancesInstanceGroupManagersRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManagersListManagedInstancesResponse response = instanceGroupManagersClient.ListManagedInstances(request);
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstancesAsync</summary>
        public async Task ListManagedInstancesRequestObjectAsync()
        {
            // Snippet: ListManagedInstancesAsync(ListManagedInstancesInstanceGroupManagersRequest, CallSettings)
            // Additional: ListManagedInstancesAsync(ListManagedInstancesInstanceGroupManagersRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListManagedInstancesInstanceGroupManagersRequest request = new ListManagedInstancesInstanceGroupManagersRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManagersListManagedInstancesResponse response = await instanceGroupManagersClient.ListManagedInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstances</summary>
        public void ListManagedInstances()
        {
            // Snippet: ListManagedInstances(string, string, string, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManagersListManagedInstancesResponse response = instanceGroupManagersClient.ListManagedInstances(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstancesAsync</summary>
        public async Task ListManagedInstancesAsync()
        {
            // Snippet: ListManagedInstancesAsync(string, string, string, CallSettings)
            // Additional: ListManagedInstancesAsync(string, string, string, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManagersListManagedInstancesResponse response = await instanceGroupManagersClient.ListManagedInstancesAsync(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigs</summary>
        public void ListPerInstanceConfigsRequestObject()
        {
            // Snippet: ListPerInstanceConfigs(ListPerInstanceConfigsInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListPerInstanceConfigsInstanceGroupManagersRequest request = new ListPerInstanceConfigsInstanceGroupManagersRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManagersListPerInstanceConfigsResp response = instanceGroupManagersClient.ListPerInstanceConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigsAsync</summary>
        public async Task ListPerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: ListPerInstanceConfigsAsync(ListPerInstanceConfigsInstanceGroupManagersRequest, CallSettings)
            // Additional: ListPerInstanceConfigsAsync(ListPerInstanceConfigsInstanceGroupManagersRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListPerInstanceConfigsInstanceGroupManagersRequest request = new ListPerInstanceConfigsInstanceGroupManagersRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManagersListPerInstanceConfigsResp response = await instanceGroupManagersClient.ListPerInstanceConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigs</summary>
        public void ListPerInstanceConfigs()
        {
            // Snippet: ListPerInstanceConfigs(string, string, string, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManagersListPerInstanceConfigsResp response = instanceGroupManagersClient.ListPerInstanceConfigs(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigsAsync</summary>
        public async Task ListPerInstanceConfigsAsync()
        {
            // Snippet: ListPerInstanceConfigsAsync(string, string, string, CallSettings)
            // Additional: ListPerInstanceConfigsAsync(string, string, string, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManagersListPerInstanceConfigsResp response = await instanceGroupManagersClient.ListPerInstanceConfigsAsync(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            PatchInstanceGroupManagerRequest request = new PatchInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            Operation response = instanceGroupManagersClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchInstanceGroupManagerRequest, CallSettings)
            // Additional: PatchAsync(PatchInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            PatchInstanceGroupManagerRequest request = new PatchInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, InstanceGroupManager, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            Operation response = instanceGroupManagersClient.Patch(project, zone, instanceGroupManager, instanceGroupManagerResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, InstanceGroupManager, CallSettings)
            // Additional: PatchAsync(string, string, string, InstanceGroupManager, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            Operation response = await instanceGroupManagersClient.PatchAsync(project, zone, instanceGroupManager, instanceGroupManagerResource);
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigs</summary>
        public void PatchPerInstanceConfigsRequestObject()
        {
            // Snippet: PatchPerInstanceConfigs(PatchPerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            PatchPerInstanceConfigsInstanceGroupManagerRequest request = new PatchPerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = instanceGroupManagersClient.PatchPerInstanceConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigsAsync</summary>
        public async Task PatchPerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: PatchPerInstanceConfigsAsync(PatchPerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Additional: PatchPerInstanceConfigsAsync(PatchPerInstanceConfigsInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            PatchPerInstanceConfigsInstanceGroupManagerRequest request = new PatchPerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.PatchPerInstanceConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigs</summary>
        public void PatchPerInstanceConfigs()
        {
            // Snippet: PatchPerInstanceConfigs(string, string, string, InstanceGroupManagersPatchPerInstanceConfigsReq, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersPatchPerInstanceConfigsReq instanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq();
            // Make the request
            Operation response = instanceGroupManagersClient.PatchPerInstanceConfigs(project, zone, instanceGroupManager, instanceGroupManagersPatchPerInstanceConfigsReqResource);
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigsAsync</summary>
        public async Task PatchPerInstanceConfigsAsync()
        {
            // Snippet: PatchPerInstanceConfigsAsync(string, string, string, InstanceGroupManagersPatchPerInstanceConfigsReq, CallSettings)
            // Additional: PatchPerInstanceConfigsAsync(string, string, string, InstanceGroupManagersPatchPerInstanceConfigsReq, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersPatchPerInstanceConfigsReq instanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq();
            // Make the request
            Operation response = await instanceGroupManagersClient.PatchPerInstanceConfigsAsync(project, zone, instanceGroupManager, instanceGroupManagersPatchPerInstanceConfigsReqResource);
            // End snippet
        }

        /// <summary>Snippet for RecreateInstances</summary>
        public void RecreateInstancesRequestObject()
        {
            // Snippet: RecreateInstances(RecreateInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            RecreateInstancesInstanceGroupManagerRequest request = new RecreateInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = instanceGroupManagersClient.RecreateInstances(request);
            // End snippet
        }

        /// <summary>Snippet for RecreateInstancesAsync</summary>
        public async Task RecreateInstancesRequestObjectAsync()
        {
            // Snippet: RecreateInstancesAsync(RecreateInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: RecreateInstancesAsync(RecreateInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            RecreateInstancesInstanceGroupManagerRequest request = new RecreateInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.RecreateInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RecreateInstances</summary>
        public void RecreateInstances()
        {
            // Snippet: RecreateInstances(string, string, string, InstanceGroupManagersRecreateInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersRecreateInstancesRequest instanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest();
            // Make the request
            Operation response = instanceGroupManagersClient.RecreateInstances(project, zone, instanceGroupManager, instanceGroupManagersRecreateInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for RecreateInstancesAsync</summary>
        public async Task RecreateInstancesAsync()
        {
            // Snippet: RecreateInstancesAsync(string, string, string, InstanceGroupManagersRecreateInstancesRequest, CallSettings)
            // Additional: RecreateInstancesAsync(string, string, string, InstanceGroupManagersRecreateInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersRecreateInstancesRequest instanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest();
            // Make the request
            Operation response = await instanceGroupManagersClient.RecreateInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersRecreateInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void ResizeRequestObject()
        {
            // Snippet: Resize(ResizeInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ResizeInstanceGroupManagerRequest request = new ResizeInstanceGroupManagerRequest
            {
                Size = 0,
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = instanceGroupManagersClient.Resize(request);
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeRequestObjectAsync()
        {
            // Snippet: ResizeAsync(ResizeInstanceGroupManagerRequest, CallSettings)
            // Additional: ResizeAsync(ResizeInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ResizeInstanceGroupManagerRequest request = new ResizeInstanceGroupManagerRequest
            {
                Size = 0,
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.ResizeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void Resize()
        {
            // Snippet: Resize(string, string, string, int, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            int size = 0;
            // Make the request
            Operation response = instanceGroupManagersClient.Resize(project, zone, instanceGroupManager, size);
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeAsync()
        {
            // Snippet: ResizeAsync(string, string, string, int, CallSettings)
            // Additional: ResizeAsync(string, string, string, int, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            int size = 0;
            // Make the request
            Operation response = await instanceGroupManagersClient.ResizeAsync(project, zone, instanceGroupManager, size);
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplate</summary>
        public void SetInstanceTemplateRequestObject()
        {
            // Snippet: SetInstanceTemplate(SetInstanceTemplateInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            SetInstanceTemplateInstanceGroupManagerRequest request = new SetInstanceTemplateInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = instanceGroupManagersClient.SetInstanceTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplateAsync</summary>
        public async Task SetInstanceTemplateRequestObjectAsync()
        {
            // Snippet: SetInstanceTemplateAsync(SetInstanceTemplateInstanceGroupManagerRequest, CallSettings)
            // Additional: SetInstanceTemplateAsync(SetInstanceTemplateInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            SetInstanceTemplateInstanceGroupManagerRequest request = new SetInstanceTemplateInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.SetInstanceTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplate</summary>
        public void SetInstanceTemplate()
        {
            // Snippet: SetInstanceTemplate(string, string, string, InstanceGroupManagersSetInstanceTemplateRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersSetInstanceTemplateRequest instanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest();
            // Make the request
            Operation response = instanceGroupManagersClient.SetInstanceTemplate(project, zone, instanceGroupManager, instanceGroupManagersSetInstanceTemplateRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplateAsync</summary>
        public async Task SetInstanceTemplateAsync()
        {
            // Snippet: SetInstanceTemplateAsync(string, string, string, InstanceGroupManagersSetInstanceTemplateRequest, CallSettings)
            // Additional: SetInstanceTemplateAsync(string, string, string, InstanceGroupManagersSetInstanceTemplateRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersSetInstanceTemplateRequest instanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest();
            // Make the request
            Operation response = await instanceGroupManagersClient.SetInstanceTemplateAsync(project, zone, instanceGroupManager, instanceGroupManagersSetInstanceTemplateRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetTargetPools</summary>
        public void SetTargetPoolsRequestObject()
        {
            // Snippet: SetTargetPools(SetTargetPoolsInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            SetTargetPoolsInstanceGroupManagerRequest request = new SetTargetPoolsInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = instanceGroupManagersClient.SetTargetPools(request);
            // End snippet
        }

        /// <summary>Snippet for SetTargetPoolsAsync</summary>
        public async Task SetTargetPoolsRequestObjectAsync()
        {
            // Snippet: SetTargetPoolsAsync(SetTargetPoolsInstanceGroupManagerRequest, CallSettings)
            // Additional: SetTargetPoolsAsync(SetTargetPoolsInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            SetTargetPoolsInstanceGroupManagerRequest request = new SetTargetPoolsInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.SetTargetPoolsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetTargetPools</summary>
        public void SetTargetPools()
        {
            // Snippet: SetTargetPools(string, string, string, InstanceGroupManagersSetTargetPoolsRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersSetTargetPoolsRequest instanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest();
            // Make the request
            Operation response = instanceGroupManagersClient.SetTargetPools(project, zone, instanceGroupManager, instanceGroupManagersSetTargetPoolsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetTargetPoolsAsync</summary>
        public async Task SetTargetPoolsAsync()
        {
            // Snippet: SetTargetPoolsAsync(string, string, string, InstanceGroupManagersSetTargetPoolsRequest, CallSettings)
            // Additional: SetTargetPoolsAsync(string, string, string, InstanceGroupManagersSetTargetPoolsRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersSetTargetPoolsRequest instanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest();
            // Make the request
            Operation response = await instanceGroupManagersClient.SetTargetPoolsAsync(project, zone, instanceGroupManager, instanceGroupManagersSetTargetPoolsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigs</summary>
        public void UpdatePerInstanceConfigsRequestObject()
        {
            // Snippet: UpdatePerInstanceConfigs(UpdatePerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            UpdatePerInstanceConfigsInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = instanceGroupManagersClient.UpdatePerInstanceConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigsAsync</summary>
        public async Task UpdatePerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: UpdatePerInstanceConfigsAsync(UpdatePerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Additional: UpdatePerInstanceConfigsAsync(UpdatePerInstanceConfigsInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePerInstanceConfigsInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await instanceGroupManagersClient.UpdatePerInstanceConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigs</summary>
        public void UpdatePerInstanceConfigs()
        {
            // Snippet: UpdatePerInstanceConfigs(string, string, string, InstanceGroupManagersUpdatePerInstanceConfigsReq, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersUpdatePerInstanceConfigsReq instanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq();
            // Make the request
            Operation response = instanceGroupManagersClient.UpdatePerInstanceConfigs(project, zone, instanceGroupManager, instanceGroupManagersUpdatePerInstanceConfigsReqResource);
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigsAsync</summary>
        public async Task UpdatePerInstanceConfigsAsync()
        {
            // Snippet: UpdatePerInstanceConfigsAsync(string, string, string, InstanceGroupManagersUpdatePerInstanceConfigsReq, CallSettings)
            // Additional: UpdatePerInstanceConfigsAsync(string, string, string, InstanceGroupManagersUpdatePerInstanceConfigsReq, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersUpdatePerInstanceConfigsReq instanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq();
            // Make the request
            Operation response = await instanceGroupManagersClient.UpdatePerInstanceConfigsAsync(project, zone, instanceGroupManager, instanceGroupManagersUpdatePerInstanceConfigsReqResource);
            // End snippet
        }
    }
}
