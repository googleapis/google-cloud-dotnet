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
    public sealed class GeneratedGlobalPublicDelegatedPrefixesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            DeleteGlobalPublicDelegatedPrefixeRequest request = new DeleteGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            Operation response = globalPublicDelegatedPrefixesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalPublicDelegatedPrefixeRequest request = new DeleteGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            Operation response = await globalPublicDelegatedPrefixesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            // Make the request
            Operation response = globalPublicDelegatedPrefixesClient.Delete(project, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            // Make the request
            Operation response = await globalPublicDelegatedPrefixesClient.DeleteAsync(project, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            GetGlobalPublicDelegatedPrefixeRequest request = new GetGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicDelegatedPrefix response = globalPublicDelegatedPrefixesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: GetAsync(GetGlobalPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalPublicDelegatedPrefixeRequest request = new GetGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicDelegatedPrefix response = await globalPublicDelegatedPrefixesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            // Make the request
            PublicDelegatedPrefix response = globalPublicDelegatedPrefixesClient.Get(project, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            // Make the request
            PublicDelegatedPrefix response = await globalPublicDelegatedPrefixesClient.GetAsync(project, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            InsertGlobalPublicDelegatedPrefixeRequest request = new InsertGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Project = "",
            };
            // Make the request
            Operation response = globalPublicDelegatedPrefixesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: InsertAsync(InsertGlobalPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            InsertGlobalPublicDelegatedPrefixeRequest request = new InsertGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Project = "",
            };
            // Make the request
            Operation response = await globalPublicDelegatedPrefixesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, PublicDelegatedPrefix, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            Operation response = globalPublicDelegatedPrefixesClient.Insert(project, publicDelegatedPrefixResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, PublicDelegatedPrefix, CallSettings)
            // Additional: InsertAsync(string, PublicDelegatedPrefix, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            Operation response = await globalPublicDelegatedPrefixesClient.InsertAsync(project, publicDelegatedPrefixResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListGlobalPublicDelegatedPrefixesRequest, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            ListGlobalPublicDelegatedPrefixesRequest request = new ListGlobalPublicDelegatedPrefixesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PublicDelegatedPrefixList response = globalPublicDelegatedPrefixesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListGlobalPublicDelegatedPrefixesRequest, CallSettings)
            // Additional: ListAsync(ListGlobalPublicDelegatedPrefixesRequest, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalPublicDelegatedPrefixesRequest request = new ListGlobalPublicDelegatedPrefixesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PublicDelegatedPrefixList response = await globalPublicDelegatedPrefixesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PublicDelegatedPrefixList response = globalPublicDelegatedPrefixesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PublicDelegatedPrefixList response = await globalPublicDelegatedPrefixesClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            PatchGlobalPublicDelegatedPrefixeRequest request = new PatchGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            Operation response = globalPublicDelegatedPrefixesClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: PatchAsync(PatchGlobalPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            PatchGlobalPublicDelegatedPrefixeRequest request = new PatchGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            Operation response = await globalPublicDelegatedPrefixesClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, PublicDelegatedPrefix, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            Operation response = globalPublicDelegatedPrefixesClient.Patch(project, publicDelegatedPrefix, publicDelegatedPrefixResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, PublicDelegatedPrefix, CallSettings)
            // Additional: PatchAsync(string, string, PublicDelegatedPrefix, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            Operation response = await globalPublicDelegatedPrefixesClient.PatchAsync(project, publicDelegatedPrefix, publicDelegatedPrefixResource);
            // End snippet
        }
    }
}
