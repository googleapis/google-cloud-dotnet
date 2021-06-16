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
    public sealed class GeneratedPublicAdvertisedPrefixesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeletePublicAdvertisedPrefixeRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            DeletePublicAdvertisedPrefixeRequest request = new DeletePublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            Operation response = publicAdvertisedPrefixesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeletePublicAdvertisedPrefixeRequest, CallSettings)
            // Additional: DeleteAsync(DeletePublicAdvertisedPrefixeRequest, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            DeletePublicAdvertisedPrefixeRequest request = new DeletePublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            Operation response = await publicAdvertisedPrefixesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            Operation response = publicAdvertisedPrefixesClient.Delete(project, publicAdvertisedPrefix);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            Operation response = await publicAdvertisedPrefixesClient.DeleteAsync(project, publicAdvertisedPrefix);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetPublicAdvertisedPrefixeRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            GetPublicAdvertisedPrefixeRequest request = new GetPublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicAdvertisedPrefix response = publicAdvertisedPrefixesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetPublicAdvertisedPrefixeRequest, CallSettings)
            // Additional: GetAsync(GetPublicAdvertisedPrefixeRequest, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            GetPublicAdvertisedPrefixeRequest request = new GetPublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicAdvertisedPrefix response = await publicAdvertisedPrefixesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            PublicAdvertisedPrefix response = publicAdvertisedPrefixesClient.Get(project, publicAdvertisedPrefix);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            PublicAdvertisedPrefix response = await publicAdvertisedPrefixesClient.GetAsync(project, publicAdvertisedPrefix);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertPublicAdvertisedPrefixeRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            InsertPublicAdvertisedPrefixeRequest request = new InsertPublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                Project = "",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
            };
            // Make the request
            Operation response = publicAdvertisedPrefixesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertPublicAdvertisedPrefixeRequest, CallSettings)
            // Additional: InsertAsync(InsertPublicAdvertisedPrefixeRequest, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            InsertPublicAdvertisedPrefixeRequest request = new InsertPublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                Project = "",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
            };
            // Make the request
            Operation response = await publicAdvertisedPrefixesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, PublicAdvertisedPrefix, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            PublicAdvertisedPrefix publicAdvertisedPrefixResource = new PublicAdvertisedPrefix();
            // Make the request
            Operation response = publicAdvertisedPrefixesClient.Insert(project, publicAdvertisedPrefixResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, PublicAdvertisedPrefix, CallSettings)
            // Additional: InsertAsync(string, PublicAdvertisedPrefix, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            PublicAdvertisedPrefix publicAdvertisedPrefixResource = new PublicAdvertisedPrefix();
            // Make the request
            Operation response = await publicAdvertisedPrefixesClient.InsertAsync(project, publicAdvertisedPrefixResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListPublicAdvertisedPrefixesRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            ListPublicAdvertisedPrefixesRequest request = new ListPublicAdvertisedPrefixesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PublicAdvertisedPrefixList response = publicAdvertisedPrefixesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListPublicAdvertisedPrefixesRequest, CallSettings)
            // Additional: ListAsync(ListPublicAdvertisedPrefixesRequest, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            ListPublicAdvertisedPrefixesRequest request = new ListPublicAdvertisedPrefixesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PublicAdvertisedPrefixList response = await publicAdvertisedPrefixesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PublicAdvertisedPrefixList response = publicAdvertisedPrefixesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PublicAdvertisedPrefixList response = await publicAdvertisedPrefixesClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchPublicAdvertisedPrefixeRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            PatchPublicAdvertisedPrefixeRequest request = new PatchPublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
            };
            // Make the request
            Operation response = publicAdvertisedPrefixesClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchPublicAdvertisedPrefixeRequest, CallSettings)
            // Additional: PatchAsync(PatchPublicAdvertisedPrefixeRequest, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            PatchPublicAdvertisedPrefixeRequest request = new PatchPublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
            };
            // Make the request
            Operation response = await publicAdvertisedPrefixesClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, PublicAdvertisedPrefix, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            PublicAdvertisedPrefix publicAdvertisedPrefixResource = new PublicAdvertisedPrefix();
            // Make the request
            Operation response = publicAdvertisedPrefixesClient.Patch(project, publicAdvertisedPrefix, publicAdvertisedPrefixResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, PublicAdvertisedPrefix, CallSettings)
            // Additional: PatchAsync(string, string, PublicAdvertisedPrefix, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            PublicAdvertisedPrefix publicAdvertisedPrefixResource = new PublicAdvertisedPrefix();
            // Make the request
            Operation response = await publicAdvertisedPrefixesClient.PatchAsync(project, publicAdvertisedPrefix, publicAdvertisedPrefixResource);
            // End snippet
        }
    }
}
