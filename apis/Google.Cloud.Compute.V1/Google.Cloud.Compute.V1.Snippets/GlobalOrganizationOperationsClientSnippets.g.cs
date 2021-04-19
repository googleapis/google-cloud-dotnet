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
    public sealed class GeneratedGlobalOrganizationOperationsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteGlobalOrganizationOperationRequest, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Initialize request argument(s)
            DeleteGlobalOrganizationOperationRequest request = new DeleteGlobalOrganizationOperationRequest
            {
                Operation = "",
                ParentId = "",
            };
            // Make the request
            DeleteGlobalOrganizationOperationResponse response = globalOrganizationOperationsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteGlobalOrganizationOperationRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalOrganizationOperationRequest, CancellationToken)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalOrganizationOperationRequest request = new DeleteGlobalOrganizationOperationRequest
            {
                Operation = "",
                ParentId = "",
            };
            // Make the request
            DeleteGlobalOrganizationOperationResponse response = await globalOrganizationOperationsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Initialize request argument(s)
            string operation = "";
            // Make the request
            DeleteGlobalOrganizationOperationResponse response = globalOrganizationOperationsClient.Delete(operation);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, CallSettings)
            // Additional: DeleteAsync(string, CancellationToken)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string operation = "";
            // Make the request
            DeleteGlobalOrganizationOperationResponse response = await globalOrganizationOperationsClient.DeleteAsync(operation);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetGlobalOrganizationOperationRequest, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Initialize request argument(s)
            GetGlobalOrganizationOperationRequest request = new GetGlobalOrganizationOperationRequest
            {
                Operation = "",
                ParentId = "",
            };
            // Make the request
            Operation response = globalOrganizationOperationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalOrganizationOperationRequest, CallSettings)
            // Additional: GetAsync(GetGlobalOrganizationOperationRequest, CancellationToken)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalOrganizationOperationRequest request = new GetGlobalOrganizationOperationRequest
            {
                Operation = "",
                ParentId = "",
            };
            // Make the request
            Operation response = await globalOrganizationOperationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Initialize request argument(s)
            string operation = "";
            // Make the request
            Operation response = globalOrganizationOperationsClient.Get(operation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, CallSettings)
            // Additional: GetAsync(string, CancellationToken)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string operation = "";
            // Make the request
            Operation response = await globalOrganizationOperationsClient.GetAsync(operation);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListGlobalOrganizationOperationsRequest, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Initialize request argument(s)
            ListGlobalOrganizationOperationsRequest request = new ListGlobalOrganizationOperationsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                ParentId = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            OperationList response = globalOrganizationOperationsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListGlobalOrganizationOperationsRequest, CallSettings)
            // Additional: ListAsync(ListGlobalOrganizationOperationsRequest, CancellationToken)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalOrganizationOperationsRequest request = new ListGlobalOrganizationOperationsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                ParentId = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            OperationList response = await globalOrganizationOperationsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Make the request
            OperationList response = globalOrganizationOperationsClient.List();
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(CallSettings)
            // Additional: ListAsync(CancellationToken)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Make the request
            OperationList response = await globalOrganizationOperationsClient.ListAsync();
            // End snippet
        }
    }
}
