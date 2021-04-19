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
    public sealed class GeneratedGlobalOperationsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListGlobalOperationsRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            AggregatedListGlobalOperationsRequest request = new AggregatedListGlobalOperationsRequest
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
            OperationAggregatedList response = globalOperationsClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListGlobalOperationsRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListGlobalOperationsRequest, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListGlobalOperationsRequest request = new AggregatedListGlobalOperationsRequest
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
            OperationAggregatedList response = await globalOperationsClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            OperationAggregatedList response = globalOperationsClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            OperationAggregatedList response = await globalOperationsClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteGlobalOperationRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            DeleteGlobalOperationRequest request = new DeleteGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            DeleteGlobalOperationResponse response = globalOperationsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteGlobalOperationRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalOperationRequest, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalOperationRequest request = new DeleteGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            DeleteGlobalOperationResponse response = await globalOperationsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            DeleteGlobalOperationResponse response = globalOperationsClient.Delete(project, operation);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            DeleteGlobalOperationResponse response = await globalOperationsClient.DeleteAsync(project, operation);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetGlobalOperationRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            GetGlobalOperationRequest request = new GetGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = globalOperationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalOperationRequest, CallSettings)
            // Additional: GetAsync(GetGlobalOperationRequest, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalOperationRequest request = new GetGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = await globalOperationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            Operation response = globalOperationsClient.Get(project, operation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            Operation response = await globalOperationsClient.GetAsync(project, operation);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListGlobalOperationsRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            ListGlobalOperationsRequest request = new ListGlobalOperationsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            OperationList response = globalOperationsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListGlobalOperationsRequest, CallSettings)
            // Additional: ListAsync(ListGlobalOperationsRequest, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalOperationsRequest request = new ListGlobalOperationsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            OperationList response = await globalOperationsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            OperationList response = globalOperationsClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            OperationList response = await globalOperationsClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Wait</summary>
        public void WaitRequestObject()
        {
            // Snippet: Wait(WaitGlobalOperationRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            WaitGlobalOperationRequest request = new WaitGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = globalOperationsClient.Wait(request);
            // End snippet
        }

        /// <summary>Snippet for WaitAsync</summary>
        public async Task WaitRequestObjectAsync()
        {
            // Snippet: WaitAsync(WaitGlobalOperationRequest, CallSettings)
            // Additional: WaitAsync(WaitGlobalOperationRequest, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            WaitGlobalOperationRequest request = new WaitGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = await globalOperationsClient.WaitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Wait</summary>
        public void Wait()
        {
            // Snippet: Wait(string, string, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            Operation response = globalOperationsClient.Wait(project, operation);
            // End snippet
        }

        /// <summary>Snippet for WaitAsync</summary>
        public async Task WaitAsync()
        {
            // Snippet: WaitAsync(string, string, CallSettings)
            // Additional: WaitAsync(string, string, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            Operation response = await globalOperationsClient.WaitAsync(project, operation);
            // End snippet
        }
    }
}
