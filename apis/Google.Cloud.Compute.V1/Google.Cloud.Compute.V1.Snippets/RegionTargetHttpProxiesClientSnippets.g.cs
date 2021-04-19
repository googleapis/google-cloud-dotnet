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
    public sealed class GeneratedRegionTargetHttpProxiesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionTargetHttpProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            DeleteRegionTargetHttpProxyRequest request = new DeleteRegionTargetHttpProxyRequest
            {
                RequestId = "",
                Region = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            Operation response = regionTargetHttpProxiesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteRegionTargetHttpProxyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionTargetHttpProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionTargetHttpProxyRequest request = new DeleteRegionTargetHttpProxyRequest
            {
                RequestId = "",
                Region = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            Operation response = await regionTargetHttpProxiesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            // Make the request
            Operation response = regionTargetHttpProxiesClient.Delete(project, region, targetHttpProxy);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            // Make the request
            Operation response = await regionTargetHttpProxiesClient.DeleteAsync(project, region, targetHttpProxy);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionTargetHttpProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            TargetHttpProxy response = regionTargetHttpProxiesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionTargetHttpProxyRequest, CallSettings)
            // Additional: GetAsync(GetRegionTargetHttpProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            TargetHttpProxy response = await regionTargetHttpProxiesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            // Make the request
            TargetHttpProxy response = regionTargetHttpProxiesClient.Get(project, region, targetHttpProxy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            // Make the request
            TargetHttpProxy response = await regionTargetHttpProxiesClient.GetAsync(project, region, targetHttpProxy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionTargetHttpProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            InsertRegionTargetHttpProxyRequest request = new InsertRegionTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = regionTargetHttpProxiesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertRegionTargetHttpProxyRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionTargetHttpProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionTargetHttpProxyRequest request = new InsertRegionTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await regionTargetHttpProxiesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, TargetHttpProxy, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetHttpProxy targetHttpProxyResource = new TargetHttpProxy();
            // Make the request
            Operation response = regionTargetHttpProxiesClient.Insert(project, region, targetHttpProxyResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, TargetHttpProxy, CallSettings)
            // Additional: InsertAsync(string, string, TargetHttpProxy, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetHttpProxy targetHttpProxyResource = new TargetHttpProxy();
            // Make the request
            Operation response = await regionTargetHttpProxiesClient.InsertAsync(project, region, targetHttpProxyResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionTargetHttpProxiesRequest, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            ListRegionTargetHttpProxiesRequest request = new ListRegionTargetHttpProxiesRequest
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
            TargetHttpProxyList response = regionTargetHttpProxiesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionTargetHttpProxiesRequest, CallSettings)
            // Additional: ListAsync(ListRegionTargetHttpProxiesRequest, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionTargetHttpProxiesRequest request = new ListRegionTargetHttpProxiesRequest
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
            TargetHttpProxyList response = await regionTargetHttpProxiesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            TargetHttpProxyList response = regionTargetHttpProxiesClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            TargetHttpProxyList response = await regionTargetHttpProxiesClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for SetUrlMap</summary>
        public void SetUrlMapRequestObject()
        {
            // Snippet: SetUrlMap(SetUrlMapRegionTargetHttpProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            SetUrlMapRegionTargetHttpProxyRequest request = new SetUrlMapRegionTargetHttpProxyRequest
            {
                RequestId = "",
                UrlMapReferenceResource = new UrlMapReference(),
                Region = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            Operation response = regionTargetHttpProxiesClient.SetUrlMap(request);
            // End snippet
        }

        /// <summary>Snippet for SetUrlMapAsync</summary>
        public async Task SetUrlMapRequestObjectAsync()
        {
            // Snippet: SetUrlMapAsync(SetUrlMapRegionTargetHttpProxyRequest, CallSettings)
            // Additional: SetUrlMapAsync(SetUrlMapRegionTargetHttpProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetUrlMapRegionTargetHttpProxyRequest request = new SetUrlMapRegionTargetHttpProxyRequest
            {
                RequestId = "",
                UrlMapReferenceResource = new UrlMapReference(),
                Region = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            Operation response = await regionTargetHttpProxiesClient.SetUrlMapAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetUrlMap</summary>
        public void SetUrlMap()
        {
            // Snippet: SetUrlMap(string, string, string, UrlMapReference, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            UrlMapReference urlMapReferenceResource = new UrlMapReference();
            // Make the request
            Operation response = regionTargetHttpProxiesClient.SetUrlMap(project, region, targetHttpProxy, urlMapReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for SetUrlMapAsync</summary>
        public async Task SetUrlMapAsync()
        {
            // Snippet: SetUrlMapAsync(string, string, string, UrlMapReference, CallSettings)
            // Additional: SetUrlMapAsync(string, string, string, UrlMapReference, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            UrlMapReference urlMapReferenceResource = new UrlMapReference();
            // Make the request
            Operation response = await regionTargetHttpProxiesClient.SetUrlMapAsync(project, region, targetHttpProxy, urlMapReferenceResource);
            // End snippet
        }
    }
}
