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
    public sealed class GeneratedMachineTypesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListMachineTypesRequest, CallSettings)
            // Create client
            MachineTypesClient machineTypesClient = MachineTypesClient.Create();
            // Initialize request argument(s)
            AggregatedListMachineTypesRequest request = new AggregatedListMachineTypesRequest
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
            MachineTypeAggregatedList response = machineTypesClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListMachineTypesRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListMachineTypesRequest, CancellationToken)
            // Create client
            MachineTypesClient machineTypesClient = await MachineTypesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListMachineTypesRequest request = new AggregatedListMachineTypesRequest
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
            MachineTypeAggregatedList response = await machineTypesClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            MachineTypesClient machineTypesClient = MachineTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            MachineTypeAggregatedList response = machineTypesClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            MachineTypesClient machineTypesClient = await MachineTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            MachineTypeAggregatedList response = await machineTypesClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetMachineTypeRequest, CallSettings)
            // Create client
            MachineTypesClient machineTypesClient = MachineTypesClient.Create();
            // Initialize request argument(s)
            GetMachineTypeRequest request = new GetMachineTypeRequest
            {
                Zone = "",
                Project = "",
                MachineType = "",
            };
            // Make the request
            MachineType response = machineTypesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetMachineTypeRequest, CallSettings)
            // Additional: GetAsync(GetMachineTypeRequest, CancellationToken)
            // Create client
            MachineTypesClient machineTypesClient = await MachineTypesClient.CreateAsync();
            // Initialize request argument(s)
            GetMachineTypeRequest request = new GetMachineTypeRequest
            {
                Zone = "",
                Project = "",
                MachineType = "",
            };
            // Make the request
            MachineType response = await machineTypesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            MachineTypesClient machineTypesClient = MachineTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string machineType = "";
            // Make the request
            MachineType response = machineTypesClient.Get(project, zone, machineType);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            MachineTypesClient machineTypesClient = await MachineTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string machineType = "";
            // Make the request
            MachineType response = await machineTypesClient.GetAsync(project, zone, machineType);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListMachineTypesRequest, CallSettings)
            // Create client
            MachineTypesClient machineTypesClient = MachineTypesClient.Create();
            // Initialize request argument(s)
            ListMachineTypesRequest request = new ListMachineTypesRequest
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
            MachineTypeList response = machineTypesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListMachineTypesRequest, CallSettings)
            // Additional: ListAsync(ListMachineTypesRequest, CancellationToken)
            // Create client
            MachineTypesClient machineTypesClient = await MachineTypesClient.CreateAsync();
            // Initialize request argument(s)
            ListMachineTypesRequest request = new ListMachineTypesRequest
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
            MachineTypeList response = await machineTypesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            MachineTypesClient machineTypesClient = MachineTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            MachineTypeList response = machineTypesClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            MachineTypesClient machineTypesClient = await MachineTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            MachineTypeList response = await machineTypesClient.ListAsync(project, zone);
            // End snippet
        }
    }
}
