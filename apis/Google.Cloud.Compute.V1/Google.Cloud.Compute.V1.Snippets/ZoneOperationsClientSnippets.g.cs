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
    public sealed class GeneratedZoneOperationsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteZoneOperationRequest, CallSettings)
            // Create client
            ZoneOperationsClient zoneOperationsClient = ZoneOperationsClient.Create();
            // Initialize request argument(s)
            DeleteZoneOperationRequest request = new DeleteZoneOperationRequest
            {
                Zone = "",
                Operation = "",
                Project = "",
            };
            // Make the request
            DeleteZoneOperationResponse response = zoneOperationsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteZoneOperationRequest, CallSettings)
            // Additional: DeleteAsync(DeleteZoneOperationRequest, CancellationToken)
            // Create client
            ZoneOperationsClient zoneOperationsClient = await ZoneOperationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteZoneOperationRequest request = new DeleteZoneOperationRequest
            {
                Zone = "",
                Operation = "",
                Project = "",
            };
            // Make the request
            DeleteZoneOperationResponse response = await zoneOperationsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            ZoneOperationsClient zoneOperationsClient = ZoneOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string operation = "";
            // Make the request
            DeleteZoneOperationResponse response = zoneOperationsClient.Delete(project, zone, operation);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            ZoneOperationsClient zoneOperationsClient = await ZoneOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string operation = "";
            // Make the request
            DeleteZoneOperationResponse response = await zoneOperationsClient.DeleteAsync(project, zone, operation);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetZoneOperationRequest, CallSettings)
            // Create client
            ZoneOperationsClient zoneOperationsClient = ZoneOperationsClient.Create();
            // Initialize request argument(s)
            GetZoneOperationRequest request = new GetZoneOperationRequest
            {
                Zone = "",
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = zoneOperationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetZoneOperationRequest, CallSettings)
            // Additional: GetAsync(GetZoneOperationRequest, CancellationToken)
            // Create client
            ZoneOperationsClient zoneOperationsClient = await ZoneOperationsClient.CreateAsync();
            // Initialize request argument(s)
            GetZoneOperationRequest request = new GetZoneOperationRequest
            {
                Zone = "",
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = await zoneOperationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            ZoneOperationsClient zoneOperationsClient = ZoneOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string operation = "";
            // Make the request
            Operation response = zoneOperationsClient.Get(project, zone, operation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            ZoneOperationsClient zoneOperationsClient = await ZoneOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string operation = "";
            // Make the request
            Operation response = await zoneOperationsClient.GetAsync(project, zone, operation);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListZoneOperationsRequest, CallSettings)
            // Create client
            ZoneOperationsClient zoneOperationsClient = ZoneOperationsClient.Create();
            // Initialize request argument(s)
            ListZoneOperationsRequest request = new ListZoneOperationsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            OperationList response = zoneOperationsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListZoneOperationsRequest, CallSettings)
            // Additional: ListAsync(ListZoneOperationsRequest, CancellationToken)
            // Create client
            ZoneOperationsClient zoneOperationsClient = await ZoneOperationsClient.CreateAsync();
            // Initialize request argument(s)
            ListZoneOperationsRequest request = new ListZoneOperationsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            OperationList response = await zoneOperationsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            ZoneOperationsClient zoneOperationsClient = ZoneOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            OperationList response = zoneOperationsClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            ZoneOperationsClient zoneOperationsClient = await ZoneOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            OperationList response = await zoneOperationsClient.ListAsync(project, zone);
            // End snippet
        }

        /// <summary>Snippet for Wait</summary>
        public void WaitRequestObject()
        {
            // Snippet: Wait(WaitZoneOperationRequest, CallSettings)
            // Create client
            ZoneOperationsClient zoneOperationsClient = ZoneOperationsClient.Create();
            // Initialize request argument(s)
            WaitZoneOperationRequest request = new WaitZoneOperationRequest
            {
                Zone = "",
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = zoneOperationsClient.Wait(request);
            // End snippet
        }

        /// <summary>Snippet for WaitAsync</summary>
        public async Task WaitRequestObjectAsync()
        {
            // Snippet: WaitAsync(WaitZoneOperationRequest, CallSettings)
            // Additional: WaitAsync(WaitZoneOperationRequest, CancellationToken)
            // Create client
            ZoneOperationsClient zoneOperationsClient = await ZoneOperationsClient.CreateAsync();
            // Initialize request argument(s)
            WaitZoneOperationRequest request = new WaitZoneOperationRequest
            {
                Zone = "",
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = await zoneOperationsClient.WaitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Wait</summary>
        public void Wait()
        {
            // Snippet: Wait(string, string, string, CallSettings)
            // Create client
            ZoneOperationsClient zoneOperationsClient = ZoneOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string operation = "";
            // Make the request
            Operation response = zoneOperationsClient.Wait(project, zone, operation);
            // End snippet
        }

        /// <summary>Snippet for WaitAsync</summary>
        public async Task WaitAsync()
        {
            // Snippet: WaitAsync(string, string, string, CallSettings)
            // Additional: WaitAsync(string, string, string, CancellationToken)
            // Create client
            ZoneOperationsClient zoneOperationsClient = await ZoneOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string operation = "";
            // Make the request
            Operation response = await zoneOperationsClient.WaitAsync(project, zone, operation);
            // End snippet
        }
    }
}
