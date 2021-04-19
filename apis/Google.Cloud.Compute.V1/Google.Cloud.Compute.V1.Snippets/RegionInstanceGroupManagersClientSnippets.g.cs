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
    public sealed class GeneratedRegionInstanceGroupManagersClientSnippets
    {
        /// <summary>Snippet for AbandonInstances</summary>
        public void AbandonInstancesRequestObject()
        {
            // Snippet: AbandonInstances(AbandonInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            AbandonInstancesRegionInstanceGroupManagerRequest request = new AbandonInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.AbandonInstances(request);
            // End snippet
        }

        /// <summary>Snippet for AbandonInstancesAsync</summary>
        public async Task AbandonInstancesRequestObjectAsync()
        {
            // Snippet: AbandonInstancesAsync(AbandonInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: AbandonInstancesAsync(AbandonInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            AbandonInstancesRegionInstanceGroupManagerRequest request = new AbandonInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.AbandonInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AbandonInstances</summary>
        public void AbandonInstances()
        {
            // Snippet: AbandonInstances(string, string, string, RegionInstanceGroupManagersAbandonInstancesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersAbandonInstancesRequest regionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.AbandonInstances(project, region, instanceGroupManager, regionInstanceGroupManagersAbandonInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AbandonInstancesAsync</summary>
        public async Task AbandonInstancesAsync()
        {
            // Snippet: AbandonInstancesAsync(string, string, string, RegionInstanceGroupManagersAbandonInstancesRequest, CallSettings)
            // Additional: AbandonInstancesAsync(string, string, string, RegionInstanceGroupManagersAbandonInstancesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersAbandonInstancesRequest regionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.AbandonInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersAbandonInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstances</summary>
        public void ApplyUpdatesToInstancesRequestObject()
        {
            // Snippet: ApplyUpdatesToInstances(ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.ApplyUpdatesToInstances(request);
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstancesAsync</summary>
        public async Task ApplyUpdatesToInstancesRequestObjectAsync()
        {
            // Snippet: ApplyUpdatesToInstancesAsync(ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: ApplyUpdatesToInstancesAsync(ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.ApplyUpdatesToInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstances</summary>
        public void ApplyUpdatesToInstances()
        {
            // Snippet: ApplyUpdatesToInstances(string, string, string, RegionInstanceGroupManagersApplyUpdatesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersApplyUpdatesRequest regionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.ApplyUpdatesToInstances(project, region, instanceGroupManager, regionInstanceGroupManagersApplyUpdatesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstancesAsync</summary>
        public async Task ApplyUpdatesToInstancesAsync()
        {
            // Snippet: ApplyUpdatesToInstancesAsync(string, string, string, RegionInstanceGroupManagersApplyUpdatesRequest, CallSettings)
            // Additional: ApplyUpdatesToInstancesAsync(string, string, string, RegionInstanceGroupManagersApplyUpdatesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersApplyUpdatesRequest regionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.ApplyUpdatesToInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersApplyUpdatesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for CreateInstances</summary>
        public void CreateInstancesRequestObject()
        {
            // Snippet: CreateInstances(CreateInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            CreateInstancesRegionInstanceGroupManagerRequest request = new CreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                RegionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.CreateInstances(request);
            // End snippet
        }

        /// <summary>Snippet for CreateInstancesAsync</summary>
        public async Task CreateInstancesRequestObjectAsync()
        {
            // Snippet: CreateInstancesAsync(CreateInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: CreateInstancesAsync(CreateInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstancesRegionInstanceGroupManagerRequest request = new CreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                RegionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.CreateInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateInstances</summary>
        public void CreateInstances()
        {
            // Snippet: CreateInstances(string, string, string, RegionInstanceGroupManagersCreateInstancesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersCreateInstancesRequest regionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.CreateInstances(project, region, instanceGroupManager, regionInstanceGroupManagersCreateInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for CreateInstancesAsync</summary>
        public async Task CreateInstancesAsync()
        {
            // Snippet: CreateInstancesAsync(string, string, string, RegionInstanceGroupManagersCreateInstancesRequest, CallSettings)
            // Additional: CreateInstancesAsync(string, string, string, RegionInstanceGroupManagersCreateInstancesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersCreateInstancesRequest regionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.CreateInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersCreateInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeleteRegionInstanceGroupManagerRequest request = new DeleteRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionInstanceGroupManagerRequest request = new DeleteRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            Operation response = regionInstanceGroupManagersClient.Delete(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.DeleteAsync(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstances</summary>
        public void DeleteInstancesRequestObject()
        {
            // Snippet: DeleteInstances(DeleteInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeleteInstancesRegionInstanceGroupManagerRequest request = new DeleteInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                RegionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest(),
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.DeleteInstances(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancesAsync</summary>
        public async Task DeleteInstancesRequestObjectAsync()
        {
            // Snippet: DeleteInstancesAsync(DeleteInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: DeleteInstancesAsync(DeleteInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstancesRegionInstanceGroupManagerRequest request = new DeleteInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                RegionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest(),
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.DeleteInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstances</summary>
        public void DeleteInstances()
        {
            // Snippet: DeleteInstances(string, string, string, RegionInstanceGroupManagersDeleteInstancesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersDeleteInstancesRequest regionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.DeleteInstances(project, region, instanceGroupManager, regionInstanceGroupManagersDeleteInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancesAsync</summary>
        public async Task DeleteInstancesAsync()
        {
            // Snippet: DeleteInstancesAsync(string, string, string, RegionInstanceGroupManagersDeleteInstancesRequest, CallSettings)
            // Additional: DeleteInstancesAsync(string, string, string, RegionInstanceGroupManagersDeleteInstancesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersDeleteInstancesRequest regionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.DeleteInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersDeleteInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigs</summary>
        public void DeletePerInstanceConfigsRequestObject()
        {
            // Snippet: DeletePerInstanceConfigs(DeletePerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeletePerInstanceConfigsRegionInstanceGroupManagerRequest request = new DeletePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.DeletePerInstanceConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigsAsync</summary>
        public async Task DeletePerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: DeletePerInstanceConfigsAsync(DeletePerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: DeletePerInstanceConfigsAsync(DeletePerInstanceConfigsRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeletePerInstanceConfigsRegionInstanceGroupManagerRequest request = new DeletePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.DeletePerInstanceConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigs</summary>
        public void DeletePerInstanceConfigs()
        {
            // Snippet: DeletePerInstanceConfigs(string, string, string, RegionInstanceGroupManagerDeleteInstanceConfigReq, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerDeleteInstanceConfigReq regionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.DeletePerInstanceConfigs(project, region, instanceGroupManager, regionInstanceGroupManagerDeleteInstanceConfigReqResource);
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigsAsync</summary>
        public async Task DeletePerInstanceConfigsAsync()
        {
            // Snippet: DeletePerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerDeleteInstanceConfigReq, CallSettings)
            // Additional: DeletePerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerDeleteInstanceConfigReq, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerDeleteInstanceConfigReq regionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.DeletePerInstanceConfigsAsync(project, region, instanceGroupManager, regionInstanceGroupManagerDeleteInstanceConfigReqResource);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManager response = regionInstanceGroupManagersClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: GetAsync(GetRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManager response = await regionInstanceGroupManagersClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManager response = regionInstanceGroupManagersClient.Get(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManager response = await regionInstanceGroupManagersClient.GetAsync(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            InsertRegionInstanceGroupManagerRequest request = new InsertRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionInstanceGroupManagerRequest request = new InsertRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, InstanceGroupManager, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.Insert(project, region, instanceGroupManagerResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, InstanceGroupManager, CallSettings)
            // Additional: InsertAsync(string, string, InstanceGroupManager, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.InsertAsync(project, region, instanceGroupManagerResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListRegionInstanceGroupManagersRequest request = new ListRegionInstanceGroupManagersRequest
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
            RegionInstanceGroupManagerList response = regionInstanceGroupManagersClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionInstanceGroupManagersRequest, CallSettings)
            // Additional: ListAsync(ListRegionInstanceGroupManagersRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionInstanceGroupManagersRequest request = new ListRegionInstanceGroupManagersRequest
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
            RegionInstanceGroupManagerList response = await regionInstanceGroupManagersClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            RegionInstanceGroupManagerList response = regionInstanceGroupManagersClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            RegionInstanceGroupManagerList response = await regionInstanceGroupManagersClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListErrors</summary>
        public void ListErrorsRequestObject()
        {
            // Snippet: ListErrors(ListErrorsRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListErrorsRegionInstanceGroupManagersRequest request = new ListErrorsRegionInstanceGroupManagersRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            RegionInstanceGroupManagersListErrorsResponse response = regionInstanceGroupManagersClient.ListErrors(request);
            // End snippet
        }

        /// <summary>Snippet for ListErrorsAsync</summary>
        public async Task ListErrorsRequestObjectAsync()
        {
            // Snippet: ListErrorsAsync(ListErrorsRegionInstanceGroupManagersRequest, CallSettings)
            // Additional: ListErrorsAsync(ListErrorsRegionInstanceGroupManagersRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListErrorsRegionInstanceGroupManagersRequest request = new ListErrorsRegionInstanceGroupManagersRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            RegionInstanceGroupManagersListErrorsResponse response = await regionInstanceGroupManagersClient.ListErrorsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListErrors</summary>
        public void ListErrors()
        {
            // Snippet: ListErrors(string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            RegionInstanceGroupManagersListErrorsResponse response = regionInstanceGroupManagersClient.ListErrors(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for ListErrorsAsync</summary>
        public async Task ListErrorsAsync()
        {
            // Snippet: ListErrorsAsync(string, string, string, CallSettings)
            // Additional: ListErrorsAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            RegionInstanceGroupManagersListErrorsResponse response = await regionInstanceGroupManagersClient.ListErrorsAsync(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstances</summary>
        public void ListManagedInstancesRequestObject()
        {
            // Snippet: ListManagedInstances(ListManagedInstancesRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListManagedInstancesRegionInstanceGroupManagersRequest request = new ListManagedInstancesRegionInstanceGroupManagersRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            RegionInstanceGroupManagersListInstancesResponse response = regionInstanceGroupManagersClient.ListManagedInstances(request);
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstancesAsync</summary>
        public async Task ListManagedInstancesRequestObjectAsync()
        {
            // Snippet: ListManagedInstancesAsync(ListManagedInstancesRegionInstanceGroupManagersRequest, CallSettings)
            // Additional: ListManagedInstancesAsync(ListManagedInstancesRegionInstanceGroupManagersRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListManagedInstancesRegionInstanceGroupManagersRequest request = new ListManagedInstancesRegionInstanceGroupManagersRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            RegionInstanceGroupManagersListInstancesResponse response = await regionInstanceGroupManagersClient.ListManagedInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstances</summary>
        public void ListManagedInstances()
        {
            // Snippet: ListManagedInstances(string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            RegionInstanceGroupManagersListInstancesResponse response = regionInstanceGroupManagersClient.ListManagedInstances(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstancesAsync</summary>
        public async Task ListManagedInstancesAsync()
        {
            // Snippet: ListManagedInstancesAsync(string, string, string, CallSettings)
            // Additional: ListManagedInstancesAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            RegionInstanceGroupManagersListInstancesResponse response = await regionInstanceGroupManagersClient.ListManagedInstancesAsync(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigs</summary>
        public void ListPerInstanceConfigsRequestObject()
        {
            // Snippet: ListPerInstanceConfigs(ListPerInstanceConfigsRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListPerInstanceConfigsRegionInstanceGroupManagersRequest request = new ListPerInstanceConfigsRegionInstanceGroupManagersRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            RegionInstanceGroupManagersListInstanceConfigsResp response = regionInstanceGroupManagersClient.ListPerInstanceConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigsAsync</summary>
        public async Task ListPerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: ListPerInstanceConfigsAsync(ListPerInstanceConfigsRegionInstanceGroupManagersRequest, CallSettings)
            // Additional: ListPerInstanceConfigsAsync(ListPerInstanceConfigsRegionInstanceGroupManagersRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListPerInstanceConfigsRegionInstanceGroupManagersRequest request = new ListPerInstanceConfigsRegionInstanceGroupManagersRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
                InstanceGroupManager = "",
            };
            // Make the request
            RegionInstanceGroupManagersListInstanceConfigsResp response = await regionInstanceGroupManagersClient.ListPerInstanceConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigs</summary>
        public void ListPerInstanceConfigs()
        {
            // Snippet: ListPerInstanceConfigs(string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            RegionInstanceGroupManagersListInstanceConfigsResp response = regionInstanceGroupManagersClient.ListPerInstanceConfigs(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigsAsync</summary>
        public async Task ListPerInstanceConfigsAsync()
        {
            // Snippet: ListPerInstanceConfigsAsync(string, string, string, CallSettings)
            // Additional: ListPerInstanceConfigsAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            RegionInstanceGroupManagersListInstanceConfigsResp response = await regionInstanceGroupManagersClient.ListPerInstanceConfigsAsync(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            PatchRegionInstanceGroupManagerRequest request = new PatchRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionInstanceGroupManagerRequest request = new PatchRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, InstanceGroupManager, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.Patch(project, region, instanceGroupManager, instanceGroupManagerResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, InstanceGroupManager, CallSettings)
            // Additional: PatchAsync(string, string, string, InstanceGroupManager, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.PatchAsync(project, region, instanceGroupManager, instanceGroupManagerResource);
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigs</summary>
        public void PatchPerInstanceConfigsRequestObject()
        {
            // Snippet: PatchPerInstanceConfigs(PatchPerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            PatchPerInstanceConfigsRegionInstanceGroupManagerRequest request = new PatchPerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.PatchPerInstanceConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigsAsync</summary>
        public async Task PatchPerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: PatchPerInstanceConfigsAsync(PatchPerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: PatchPerInstanceConfigsAsync(PatchPerInstanceConfigsRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            PatchPerInstanceConfigsRegionInstanceGroupManagerRequest request = new PatchPerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.PatchPerInstanceConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigs</summary>
        public void PatchPerInstanceConfigs()
        {
            // Snippet: PatchPerInstanceConfigs(string, string, string, RegionInstanceGroupManagerPatchInstanceConfigReq, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerPatchInstanceConfigReq regionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.PatchPerInstanceConfigs(project, region, instanceGroupManager, regionInstanceGroupManagerPatchInstanceConfigReqResource);
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigsAsync</summary>
        public async Task PatchPerInstanceConfigsAsync()
        {
            // Snippet: PatchPerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerPatchInstanceConfigReq, CallSettings)
            // Additional: PatchPerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerPatchInstanceConfigReq, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerPatchInstanceConfigReq regionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.PatchPerInstanceConfigsAsync(project, region, instanceGroupManager, regionInstanceGroupManagerPatchInstanceConfigReqResource);
            // End snippet
        }

        /// <summary>Snippet for RecreateInstances</summary>
        public void RecreateInstancesRequestObject()
        {
            // Snippet: RecreateInstances(RecreateInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            RecreateInstancesRegionInstanceGroupManagerRequest request = new RecreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.RecreateInstances(request);
            // End snippet
        }

        /// <summary>Snippet for RecreateInstancesAsync</summary>
        public async Task RecreateInstancesRequestObjectAsync()
        {
            // Snippet: RecreateInstancesAsync(RecreateInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: RecreateInstancesAsync(RecreateInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            RecreateInstancesRegionInstanceGroupManagerRequest request = new RecreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.RecreateInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RecreateInstances</summary>
        public void RecreateInstances()
        {
            // Snippet: RecreateInstances(string, string, string, RegionInstanceGroupManagersRecreateRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersRecreateRequest regionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.RecreateInstances(project, region, instanceGroupManager, regionInstanceGroupManagersRecreateRequestResource);
            // End snippet
        }

        /// <summary>Snippet for RecreateInstancesAsync</summary>
        public async Task RecreateInstancesAsync()
        {
            // Snippet: RecreateInstancesAsync(string, string, string, RegionInstanceGroupManagersRecreateRequest, CallSettings)
            // Additional: RecreateInstancesAsync(string, string, string, RegionInstanceGroupManagersRecreateRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersRecreateRequest regionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.RecreateInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersRecreateRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void ResizeRequestObject()
        {
            // Snippet: Resize(ResizeRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ResizeRegionInstanceGroupManagerRequest request = new ResizeRegionInstanceGroupManagerRequest
            {
                Size = 0,
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.Resize(request);
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeRequestObjectAsync()
        {
            // Snippet: ResizeAsync(ResizeRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: ResizeAsync(ResizeRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ResizeRegionInstanceGroupManagerRequest request = new ResizeRegionInstanceGroupManagerRequest
            {
                Size = 0,
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.ResizeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void Resize()
        {
            // Snippet: Resize(string, string, string, int, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            int size = 0;
            // Make the request
            Operation response = regionInstanceGroupManagersClient.Resize(project, region, instanceGroupManager, size);
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeAsync()
        {
            // Snippet: ResizeAsync(string, string, string, int, CallSettings)
            // Additional: ResizeAsync(string, string, string, int, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            int size = 0;
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.ResizeAsync(project, region, instanceGroupManager, size);
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplate</summary>
        public void SetInstanceTemplateRequestObject()
        {
            // Snippet: SetInstanceTemplate(SetInstanceTemplateRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            SetInstanceTemplateRegionInstanceGroupManagerRequest request = new SetInstanceTemplateRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.SetInstanceTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplateAsync</summary>
        public async Task SetInstanceTemplateRequestObjectAsync()
        {
            // Snippet: SetInstanceTemplateAsync(SetInstanceTemplateRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: SetInstanceTemplateAsync(SetInstanceTemplateRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            SetInstanceTemplateRegionInstanceGroupManagerRequest request = new SetInstanceTemplateRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.SetInstanceTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplate</summary>
        public void SetInstanceTemplate()
        {
            // Snippet: SetInstanceTemplate(string, string, string, RegionInstanceGroupManagersSetTemplateRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersSetTemplateRequest regionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.SetInstanceTemplate(project, region, instanceGroupManager, regionInstanceGroupManagersSetTemplateRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplateAsync</summary>
        public async Task SetInstanceTemplateAsync()
        {
            // Snippet: SetInstanceTemplateAsync(string, string, string, RegionInstanceGroupManagersSetTemplateRequest, CallSettings)
            // Additional: SetInstanceTemplateAsync(string, string, string, RegionInstanceGroupManagersSetTemplateRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersSetTemplateRequest regionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.SetInstanceTemplateAsync(project, region, instanceGroupManager, regionInstanceGroupManagersSetTemplateRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetTargetPools</summary>
        public void SetTargetPoolsRequestObject()
        {
            // Snippet: SetTargetPools(SetTargetPoolsRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            SetTargetPoolsRegionInstanceGroupManagerRequest request = new SetTargetPoolsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                RegionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.SetTargetPools(request);
            // End snippet
        }

        /// <summary>Snippet for SetTargetPoolsAsync</summary>
        public async Task SetTargetPoolsRequestObjectAsync()
        {
            // Snippet: SetTargetPoolsAsync(SetTargetPoolsRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: SetTargetPoolsAsync(SetTargetPoolsRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            SetTargetPoolsRegionInstanceGroupManagerRequest request = new SetTargetPoolsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                RegionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.SetTargetPoolsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetTargetPools</summary>
        public void SetTargetPools()
        {
            // Snippet: SetTargetPools(string, string, string, RegionInstanceGroupManagersSetTargetPoolsRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersSetTargetPoolsRequest regionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.SetTargetPools(project, region, instanceGroupManager, regionInstanceGroupManagersSetTargetPoolsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetTargetPoolsAsync</summary>
        public async Task SetTargetPoolsAsync()
        {
            // Snippet: SetTargetPoolsAsync(string, string, string, RegionInstanceGroupManagersSetTargetPoolsRequest, CallSettings)
            // Additional: SetTargetPoolsAsync(string, string, string, RegionInstanceGroupManagersSetTargetPoolsRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersSetTargetPoolsRequest regionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.SetTargetPoolsAsync(project, region, instanceGroupManager, regionInstanceGroupManagersSetTargetPoolsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigs</summary>
        public void UpdatePerInstanceConfigsRequestObject()
        {
            // Snippet: UpdatePerInstanceConfigs(UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                RegionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = regionInstanceGroupManagersClient.UpdatePerInstanceConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigsAsync</summary>
        public async Task UpdatePerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: UpdatePerInstanceConfigsAsync(UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: UpdatePerInstanceConfigsAsync(UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                RegionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.UpdatePerInstanceConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigs</summary>
        public void UpdatePerInstanceConfigs()
        {
            // Snippet: UpdatePerInstanceConfigs(string, string, string, RegionInstanceGroupManagerUpdateInstanceConfigReq, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerUpdateInstanceConfigReq regionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq();
            // Make the request
            Operation response = regionInstanceGroupManagersClient.UpdatePerInstanceConfigs(project, region, instanceGroupManager, regionInstanceGroupManagerUpdateInstanceConfigReqResource);
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigsAsync</summary>
        public async Task UpdatePerInstanceConfigsAsync()
        {
            // Snippet: UpdatePerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerUpdateInstanceConfigReq, CallSettings)
            // Additional: UpdatePerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerUpdateInstanceConfigReq, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerUpdateInstanceConfigReq regionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq();
            // Make the request
            Operation response = await regionInstanceGroupManagersClient.UpdatePerInstanceConfigsAsync(project, region, instanceGroupManager, regionInstanceGroupManagerUpdateInstanceConfigReqResource);
            // End snippet
        }
    }
}
