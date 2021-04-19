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
    public sealed class GeneratedRoutersClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListRoutersRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            AggregatedListRoutersRequest request = new AggregatedListRoutersRequest
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
            RouterAggregatedList response = routersClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListRoutersRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListRoutersRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListRoutersRequest request = new AggregatedListRoutersRequest
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
            RouterAggregatedList response = await routersClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            RouterAggregatedList response = routersClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            RouterAggregatedList response = await routersClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            DeleteRouterRequest request = new DeleteRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            Operation response = routersClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteRouterRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRouterRequest request = new DeleteRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            Operation response = await routersClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            Operation response = routersClient.Delete(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            Operation response = await routersClient.DeleteAsync(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            GetRouterRequest request = new GetRouterRequest
            {
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            Router response = routersClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRouterRequest, CallSettings)
            // Additional: GetAsync(GetRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            GetRouterRequest request = new GetRouterRequest
            {
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            Router response = await routersClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            Router response = routersClient.Get(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            Router response = await routersClient.GetAsync(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for GetNatMappingInfo</summary>
        public void GetNatMappingInfoRequestObject()
        {
            // Snippet: GetNatMappingInfo(GetNatMappingInfoRoutersRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            GetNatMappingInfoRoutersRequest request = new GetNatMappingInfoRoutersRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                Router = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            VmEndpointNatMappingsList response = routersClient.GetNatMappingInfo(request);
            // End snippet
        }

        /// <summary>Snippet for GetNatMappingInfoAsync</summary>
        public async Task GetNatMappingInfoRequestObjectAsync()
        {
            // Snippet: GetNatMappingInfoAsync(GetNatMappingInfoRoutersRequest, CallSettings)
            // Additional: GetNatMappingInfoAsync(GetNatMappingInfoRoutersRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            GetNatMappingInfoRoutersRequest request = new GetNatMappingInfoRoutersRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                Router = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            VmEndpointNatMappingsList response = await routersClient.GetNatMappingInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNatMappingInfo</summary>
        public void GetNatMappingInfo()
        {
            // Snippet: GetNatMappingInfo(string, string, string, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            VmEndpointNatMappingsList response = routersClient.GetNatMappingInfo(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for GetNatMappingInfoAsync</summary>
        public async Task GetNatMappingInfoAsync()
        {
            // Snippet: GetNatMappingInfoAsync(string, string, string, CallSettings)
            // Additional: GetNatMappingInfoAsync(string, string, string, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            VmEndpointNatMappingsList response = await routersClient.GetNatMappingInfoAsync(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for GetRouterStatus</summary>
        public void GetRouterStatusRequestObject()
        {
            // Snippet: GetRouterStatus(GetRouterStatusRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            GetRouterStatusRouterRequest request = new GetRouterStatusRouterRequest
            {
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            RouterStatusResponse response = routersClient.GetRouterStatus(request);
            // End snippet
        }

        /// <summary>Snippet for GetRouterStatusAsync</summary>
        public async Task GetRouterStatusRequestObjectAsync()
        {
            // Snippet: GetRouterStatusAsync(GetRouterStatusRouterRequest, CallSettings)
            // Additional: GetRouterStatusAsync(GetRouterStatusRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            GetRouterStatusRouterRequest request = new GetRouterStatusRouterRequest
            {
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            RouterStatusResponse response = await routersClient.GetRouterStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRouterStatus</summary>
        public void GetRouterStatus()
        {
            // Snippet: GetRouterStatus(string, string, string, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            RouterStatusResponse response = routersClient.GetRouterStatus(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for GetRouterStatusAsync</summary>
        public async Task GetRouterStatusAsync()
        {
            // Snippet: GetRouterStatusAsync(string, string, string, CallSettings)
            // Additional: GetRouterStatusAsync(string, string, string, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            RouterStatusResponse response = await routersClient.GetRouterStatusAsync(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            InsertRouterRequest request = new InsertRouterRequest
            {
                RequestId = "",
                Region = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            Operation response = routersClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertRouterRequest, CallSettings)
            // Additional: InsertAsync(InsertRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            InsertRouterRequest request = new InsertRouterRequest
            {
                RequestId = "",
                Region = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            Operation response = await routersClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, Router, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Router routerResource = new Router();
            // Make the request
            Operation response = routersClient.Insert(project, region, routerResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, Router, CallSettings)
            // Additional: InsertAsync(string, string, Router, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Router routerResource = new Router();
            // Make the request
            Operation response = await routersClient.InsertAsync(project, region, routerResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRoutersRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            ListRoutersRequest request = new ListRoutersRequest
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
            RouterList response = routersClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRoutersRequest, CallSettings)
            // Additional: ListAsync(ListRoutersRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            ListRoutersRequest request = new ListRoutersRequest
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
            RouterList response = await routersClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            RouterList response = routersClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            RouterList response = await routersClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            PatchRouterRequest request = new PatchRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            Operation response = routersClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchRouterRequest, CallSettings)
            // Additional: PatchAsync(PatchRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            PatchRouterRequest request = new PatchRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            Operation response = await routersClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, Router, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            Operation response = routersClient.Patch(project, region, router, routerResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, Router, CallSettings)
            // Additional: PatchAsync(string, string, string, Router, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            Operation response = await routersClient.PatchAsync(project, region, router, routerResource);
            // End snippet
        }

        /// <summary>Snippet for Preview</summary>
        public void PreviewRequestObject()
        {
            // Snippet: Preview(PreviewRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            PreviewRouterRequest request = new PreviewRouterRequest
            {
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            RoutersPreviewResponse response = routersClient.Preview(request);
            // End snippet
        }

        /// <summary>Snippet for PreviewAsync</summary>
        public async Task PreviewRequestObjectAsync()
        {
            // Snippet: PreviewAsync(PreviewRouterRequest, CallSettings)
            // Additional: PreviewAsync(PreviewRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            PreviewRouterRequest request = new PreviewRouterRequest
            {
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            RoutersPreviewResponse response = await routersClient.PreviewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Preview</summary>
        public void Preview()
        {
            // Snippet: Preview(string, string, string, Router, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            RoutersPreviewResponse response = routersClient.Preview(project, region, router, routerResource);
            // End snippet
        }

        /// <summary>Snippet for PreviewAsync</summary>
        public async Task PreviewAsync()
        {
            // Snippet: PreviewAsync(string, string, string, Router, CallSettings)
            // Additional: PreviewAsync(string, string, string, Router, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            RoutersPreviewResponse response = await routersClient.PreviewAsync(project, region, router, routerResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            UpdateRouterRequest request = new UpdateRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            Operation response = routersClient.Update(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdateRouterRequest, CallSettings)
            // Additional: UpdateAsync(UpdateRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRouterRequest request = new UpdateRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            Operation response = await routersClient.UpdateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, string, Router, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            Operation response = routersClient.Update(project, region, router, routerResource);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, string, Router, CallSettings)
            // Additional: UpdateAsync(string, string, string, Router, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            Operation response = await routersClient.UpdateAsync(project, region, router, routerResource);
            // End snippet
        }
    }
}
