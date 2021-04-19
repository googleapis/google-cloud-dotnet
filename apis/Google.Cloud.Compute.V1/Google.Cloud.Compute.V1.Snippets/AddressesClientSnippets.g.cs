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
    public sealed class GeneratedAddressesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListAddressesRequest, CallSettings)
            // Create client
            AddressesClient addressesClient = AddressesClient.Create();
            // Initialize request argument(s)
            AggregatedListAddressesRequest request = new AggregatedListAddressesRequest
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
            AddressAggregatedList response = addressesClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListAddressesRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListAddressesRequest, CancellationToken)
            // Create client
            AddressesClient addressesClient = await AddressesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListAddressesRequest request = new AggregatedListAddressesRequest
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
            AddressAggregatedList response = await addressesClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            AddressesClient addressesClient = AddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            AddressAggregatedList response = addressesClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            AddressesClient addressesClient = await AddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            AddressAggregatedList response = await addressesClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteAddressRequest, CallSettings)
            // Create client
            AddressesClient addressesClient = AddressesClient.Create();
            // Initialize request argument(s)
            DeleteAddressRequest request = new DeleteAddressRequest
            {
                RequestId = "",
                Region = "",
                Address = "",
                Project = "",
            };
            // Make the request
            Operation response = addressesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteAddressRequest, CallSettings)
            // Additional: DeleteAsync(DeleteAddressRequest, CancellationToken)
            // Create client
            AddressesClient addressesClient = await AddressesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAddressRequest request = new DeleteAddressRequest
            {
                RequestId = "",
                Region = "",
                Address = "",
                Project = "",
            };
            // Make the request
            Operation response = await addressesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            AddressesClient addressesClient = AddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string address = "";
            // Make the request
            Operation response = addressesClient.Delete(project, region, address);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            AddressesClient addressesClient = await AddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string address = "";
            // Make the request
            Operation response = await addressesClient.DeleteAsync(project, region, address);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetAddressRequest, CallSettings)
            // Create client
            AddressesClient addressesClient = AddressesClient.Create();
            // Initialize request argument(s)
            GetAddressRequest request = new GetAddressRequest
            {
                Region = "",
                Address = "",
                Project = "",
            };
            // Make the request
            Address response = addressesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetAddressRequest, CallSettings)
            // Additional: GetAsync(GetAddressRequest, CancellationToken)
            // Create client
            AddressesClient addressesClient = await AddressesClient.CreateAsync();
            // Initialize request argument(s)
            GetAddressRequest request = new GetAddressRequest
            {
                Region = "",
                Address = "",
                Project = "",
            };
            // Make the request
            Address response = await addressesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            AddressesClient addressesClient = AddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string address = "";
            // Make the request
            Address response = addressesClient.Get(project, region, address);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            AddressesClient addressesClient = await AddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string address = "";
            // Make the request
            Address response = await addressesClient.GetAsync(project, region, address);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertAddressRequest, CallSettings)
            // Create client
            AddressesClient addressesClient = AddressesClient.Create();
            // Initialize request argument(s)
            InsertAddressRequest request = new InsertAddressRequest
            {
                RequestId = "",
                Region = "",
                AddressResource = new Address(),
                Project = "",
            };
            // Make the request
            Operation response = addressesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertAddressRequest, CallSettings)
            // Additional: InsertAsync(InsertAddressRequest, CancellationToken)
            // Create client
            AddressesClient addressesClient = await AddressesClient.CreateAsync();
            // Initialize request argument(s)
            InsertAddressRequest request = new InsertAddressRequest
            {
                RequestId = "",
                Region = "",
                AddressResource = new Address(),
                Project = "",
            };
            // Make the request
            Operation response = await addressesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, Address, CallSettings)
            // Create client
            AddressesClient addressesClient = AddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Address addressResource = new Address();
            // Make the request
            Operation response = addressesClient.Insert(project, region, addressResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, Address, CallSettings)
            // Additional: InsertAsync(string, string, Address, CancellationToken)
            // Create client
            AddressesClient addressesClient = await AddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Address addressResource = new Address();
            // Make the request
            Operation response = await addressesClient.InsertAsync(project, region, addressResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListAddressesRequest, CallSettings)
            // Create client
            AddressesClient addressesClient = AddressesClient.Create();
            // Initialize request argument(s)
            ListAddressesRequest request = new ListAddressesRequest
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
            AddressList response = addressesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListAddressesRequest, CallSettings)
            // Additional: ListAsync(ListAddressesRequest, CancellationToken)
            // Create client
            AddressesClient addressesClient = await AddressesClient.CreateAsync();
            // Initialize request argument(s)
            ListAddressesRequest request = new ListAddressesRequest
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
            AddressList response = await addressesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            AddressesClient addressesClient = AddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            AddressList response = addressesClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            AddressesClient addressesClient = await AddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            AddressList response = await addressesClient.ListAsync(project, region);
            // End snippet
        }
    }
}
