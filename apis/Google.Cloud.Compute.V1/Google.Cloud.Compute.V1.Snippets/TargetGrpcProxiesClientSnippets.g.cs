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
    public sealed class GeneratedTargetGrpcProxiesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteTargetGrpcProxyRequest, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            DeleteTargetGrpcProxyRequest request = new DeleteTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = targetGrpcProxiesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteTargetGrpcProxyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteTargetGrpcProxyRequest, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetGrpcProxyRequest request = new DeleteTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = await targetGrpcProxiesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            // Make the request
            Operation response = targetGrpcProxiesClient.Delete(project, targetGrpcProxy);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            // Make the request
            Operation response = await targetGrpcProxiesClient.DeleteAsync(project, targetGrpcProxy);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetTargetGrpcProxyRequest, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            GetTargetGrpcProxyRequest request = new GetTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                Project = "",
            };
            // Make the request
            TargetGrpcProxy response = targetGrpcProxiesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetTargetGrpcProxyRequest, CallSettings)
            // Additional: GetAsync(GetTargetGrpcProxyRequest, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetGrpcProxyRequest request = new GetTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                Project = "",
            };
            // Make the request
            TargetGrpcProxy response = await targetGrpcProxiesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            // Make the request
            TargetGrpcProxy response = targetGrpcProxiesClient.Get(project, targetGrpcProxy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            // Make the request
            TargetGrpcProxy response = await targetGrpcProxiesClient.GetAsync(project, targetGrpcProxy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertTargetGrpcProxyRequest, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            InsertTargetGrpcProxyRequest request = new InsertTargetGrpcProxyRequest
            {
                RequestId = "",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
                Project = "",
            };
            // Make the request
            Operation response = targetGrpcProxiesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertTargetGrpcProxyRequest, CallSettings)
            // Additional: InsertAsync(InsertTargetGrpcProxyRequest, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            InsertTargetGrpcProxyRequest request = new InsertTargetGrpcProxyRequest
            {
                RequestId = "",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
                Project = "",
            };
            // Make the request
            Operation response = await targetGrpcProxiesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, TargetGrpcProxy, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            TargetGrpcProxy targetGrpcProxyResource = new TargetGrpcProxy();
            // Make the request
            Operation response = targetGrpcProxiesClient.Insert(project, targetGrpcProxyResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, TargetGrpcProxy, CallSettings)
            // Additional: InsertAsync(string, TargetGrpcProxy, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            TargetGrpcProxy targetGrpcProxyResource = new TargetGrpcProxy();
            // Make the request
            Operation response = await targetGrpcProxiesClient.InsertAsync(project, targetGrpcProxyResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListTargetGrpcProxiesRequest, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            ListTargetGrpcProxiesRequest request = new ListTargetGrpcProxiesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            TargetGrpcProxyList response = targetGrpcProxiesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListTargetGrpcProxiesRequest, CallSettings)
            // Additional: ListAsync(ListTargetGrpcProxiesRequest, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetGrpcProxiesRequest request = new ListTargetGrpcProxiesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            TargetGrpcProxyList response = await targetGrpcProxiesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            TargetGrpcProxyList response = targetGrpcProxiesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            TargetGrpcProxyList response = await targetGrpcProxiesClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchTargetGrpcProxyRequest, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            PatchTargetGrpcProxyRequest request = new PatchTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                RequestId = "",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
                Project = "",
            };
            // Make the request
            Operation response = targetGrpcProxiesClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchTargetGrpcProxyRequest, CallSettings)
            // Additional: PatchAsync(PatchTargetGrpcProxyRequest, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            PatchTargetGrpcProxyRequest request = new PatchTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                RequestId = "",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
                Project = "",
            };
            // Make the request
            Operation response = await targetGrpcProxiesClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, TargetGrpcProxy, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            TargetGrpcProxy targetGrpcProxyResource = new TargetGrpcProxy();
            // Make the request
            Operation response = targetGrpcProxiesClient.Patch(project, targetGrpcProxy, targetGrpcProxyResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, TargetGrpcProxy, CallSettings)
            // Additional: PatchAsync(string, string, TargetGrpcProxy, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            TargetGrpcProxy targetGrpcProxyResource = new TargetGrpcProxy();
            // Make the request
            Operation response = await targetGrpcProxiesClient.PatchAsync(project, targetGrpcProxy, targetGrpcProxyResource);
            // End snippet
        }
    }
}
