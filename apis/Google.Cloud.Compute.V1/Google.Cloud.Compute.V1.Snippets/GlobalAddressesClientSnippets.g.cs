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
    public sealed class GeneratedGlobalAddressesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteGlobalAddressRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            DeleteGlobalAddressRequest request = new DeleteGlobalAddressRequest
            {
                RequestId = "",
                Address = "",
                Project = "",
            };
            // Make the request
            Operation response = globalAddressesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteGlobalAddressRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalAddressRequest, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalAddressRequest request = new DeleteGlobalAddressRequest
            {
                RequestId = "",
                Address = "",
                Project = "",
            };
            // Make the request
            Operation response = await globalAddressesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string address = "";
            // Make the request
            Operation response = globalAddressesClient.Delete(project, address);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string address = "";
            // Make the request
            Operation response = await globalAddressesClient.DeleteAsync(project, address);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetGlobalAddressRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Address = "",
                Project = "",
            };
            // Make the request
            Address response = globalAddressesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalAddressRequest, CallSettings)
            // Additional: GetAsync(GetGlobalAddressRequest, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Address = "",
                Project = "",
            };
            // Make the request
            Address response = await globalAddressesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string address = "";
            // Make the request
            Address response = globalAddressesClient.Get(project, address);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string address = "";
            // Make the request
            Address response = await globalAddressesClient.GetAsync(project, address);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertGlobalAddressRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            InsertGlobalAddressRequest request = new InsertGlobalAddressRequest
            {
                RequestId = "",
                AddressResource = new Address(),
                Project = "",
            };
            // Make the request
            Operation response = globalAddressesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertGlobalAddressRequest, CallSettings)
            // Additional: InsertAsync(InsertGlobalAddressRequest, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            InsertGlobalAddressRequest request = new InsertGlobalAddressRequest
            {
                RequestId = "",
                AddressResource = new Address(),
                Project = "",
            };
            // Make the request
            Operation response = await globalAddressesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, Address, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            Address addressResource = new Address();
            // Make the request
            Operation response = globalAddressesClient.Insert(project, addressResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, Address, CallSettings)
            // Additional: InsertAsync(string, Address, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            Address addressResource = new Address();
            // Make the request
            Operation response = await globalAddressesClient.InsertAsync(project, addressResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListGlobalAddressesRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            ListGlobalAddressesRequest request = new ListGlobalAddressesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            AddressList response = globalAddressesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListGlobalAddressesRequest, CallSettings)
            // Additional: ListAsync(ListGlobalAddressesRequest, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalAddressesRequest request = new ListGlobalAddressesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            AddressList response = await globalAddressesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            AddressList response = globalAddressesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            AddressList response = await globalAddressesClient.ListAsync(project);
            // End snippet
        }
    }
}
