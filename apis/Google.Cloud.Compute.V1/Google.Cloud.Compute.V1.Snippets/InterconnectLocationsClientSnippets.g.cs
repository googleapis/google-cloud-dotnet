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
    public sealed class GeneratedInterconnectLocationsClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetInterconnectLocationRequest, CallSettings)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = InterconnectLocationsClient.Create();
            // Initialize request argument(s)
            GetInterconnectLocationRequest request = new GetInterconnectLocationRequest
            {
                InterconnectLocation = "",
                Project = "",
            };
            // Make the request
            InterconnectLocation response = interconnectLocationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInterconnectLocationRequest, CallSettings)
            // Additional: GetAsync(GetInterconnectLocationRequest, CancellationToken)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = await InterconnectLocationsClient.CreateAsync();
            // Initialize request argument(s)
            GetInterconnectLocationRequest request = new GetInterconnectLocationRequest
            {
                InterconnectLocation = "",
                Project = "",
            };
            // Make the request
            InterconnectLocation response = await interconnectLocationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = InterconnectLocationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectLocation = "";
            // Make the request
            InterconnectLocation response = interconnectLocationsClient.Get(project, interconnectLocation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = await InterconnectLocationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectLocation = "";
            // Make the request
            InterconnectLocation response = await interconnectLocationsClient.GetAsync(project, interconnectLocation);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListInterconnectLocationsRequest, CallSettings)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = InterconnectLocationsClient.Create();
            // Initialize request argument(s)
            ListInterconnectLocationsRequest request = new ListInterconnectLocationsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InterconnectLocationList response = interconnectLocationsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListInterconnectLocationsRequest, CallSettings)
            // Additional: ListAsync(ListInterconnectLocationsRequest, CancellationToken)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = await InterconnectLocationsClient.CreateAsync();
            // Initialize request argument(s)
            ListInterconnectLocationsRequest request = new ListInterconnectLocationsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InterconnectLocationList response = await interconnectLocationsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = InterconnectLocationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            InterconnectLocationList response = interconnectLocationsClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            InterconnectLocationsClient interconnectLocationsClient = await InterconnectLocationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            InterconnectLocationList response = await interconnectLocationsClient.ListAsync(project);
            // End snippet
        }
    }
}
