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
    public sealed class GeneratedPublicDelegatedPrefixesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListPublicDelegatedPrefixesRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            AggregatedListPublicDelegatedPrefixesRequest request = new AggregatedListPublicDelegatedPrefixesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PublicDelegatedPrefixAggregatedList response = publicDelegatedPrefixesClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListPublicDelegatedPrefixesRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListPublicDelegatedPrefixesRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListPublicDelegatedPrefixesRequest request = new AggregatedListPublicDelegatedPrefixesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PublicDelegatedPrefixAggregatedList response = await publicDelegatedPrefixesClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PublicDelegatedPrefixAggregatedList response = publicDelegatedPrefixesClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PublicDelegatedPrefixAggregatedList response = await publicDelegatedPrefixesClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeletePublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            DeletePublicDelegatedPrefixeRequest request = new DeletePublicDelegatedPrefixeRequest
            {
                RequestId = "",
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            Operation response = publicDelegatedPrefixesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeletePublicDelegatedPrefixeRequest, CallSettings)
            // Additional: DeleteAsync(DeletePublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            DeletePublicDelegatedPrefixeRequest request = new DeletePublicDelegatedPrefixeRequest
            {
                RequestId = "",
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            Operation response = await publicDelegatedPrefixesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            Operation response = publicDelegatedPrefixesClient.Delete(project, region, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            Operation response = await publicDelegatedPrefixesClient.DeleteAsync(project, region, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            GetPublicDelegatedPrefixeRequest request = new GetPublicDelegatedPrefixeRequest
            {
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicDelegatedPrefix response = publicDelegatedPrefixesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: GetAsync(GetPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            GetPublicDelegatedPrefixeRequest request = new GetPublicDelegatedPrefixeRequest
            {
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicDelegatedPrefix response = await publicDelegatedPrefixesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            PublicDelegatedPrefix response = publicDelegatedPrefixesClient.Get(project, region, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            PublicDelegatedPrefix response = await publicDelegatedPrefixesClient.GetAsync(project, region, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            InsertPublicDelegatedPrefixeRequest request = new InsertPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = publicDelegatedPrefixesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: InsertAsync(InsertPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            InsertPublicDelegatedPrefixeRequest request = new InsertPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await publicDelegatedPrefixesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, PublicDelegatedPrefix, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            Operation response = publicDelegatedPrefixesClient.Insert(project, region, publicDelegatedPrefixResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, PublicDelegatedPrefix, CallSettings)
            // Additional: InsertAsync(string, string, PublicDelegatedPrefix, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            Operation response = await publicDelegatedPrefixesClient.InsertAsync(project, region, publicDelegatedPrefixResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListPublicDelegatedPrefixesRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            ListPublicDelegatedPrefixesRequest request = new ListPublicDelegatedPrefixesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PublicDelegatedPrefixList response = publicDelegatedPrefixesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListPublicDelegatedPrefixesRequest, CallSettings)
            // Additional: ListAsync(ListPublicDelegatedPrefixesRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            ListPublicDelegatedPrefixesRequest request = new ListPublicDelegatedPrefixesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PublicDelegatedPrefixList response = await publicDelegatedPrefixesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PublicDelegatedPrefixList response = publicDelegatedPrefixesClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PublicDelegatedPrefixList response = await publicDelegatedPrefixesClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            PatchPublicDelegatedPrefixeRequest request = new PatchPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            Operation response = publicDelegatedPrefixesClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: PatchAsync(PatchPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            PatchPublicDelegatedPrefixeRequest request = new PatchPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            Operation response = await publicDelegatedPrefixesClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, PublicDelegatedPrefix, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            Operation response = publicDelegatedPrefixesClient.Patch(project, region, publicDelegatedPrefix, publicDelegatedPrefixResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, PublicDelegatedPrefix, CallSettings)
            // Additional: PatchAsync(string, string, string, PublicDelegatedPrefix, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            Operation response = await publicDelegatedPrefixesClient.PatchAsync(project, region, publicDelegatedPrefix, publicDelegatedPrefixResource);
            // End snippet
        }
    }
}
