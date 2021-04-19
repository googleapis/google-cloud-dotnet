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
    public sealed class GeneratedZonesClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetZoneRequest, CallSettings)
            // Create client
            ZonesClient zonesClient = ZonesClient.Create();
            // Initialize request argument(s)
            GetZoneRequest request = new GetZoneRequest
            {
                Zone = "",
                Project = "",
            };
            // Make the request
            Zone response = zonesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetZoneRequest, CallSettings)
            // Additional: GetAsync(GetZoneRequest, CancellationToken)
            // Create client
            ZonesClient zonesClient = await ZonesClient.CreateAsync();
            // Initialize request argument(s)
            GetZoneRequest request = new GetZoneRequest
            {
                Zone = "",
                Project = "",
            };
            // Make the request
            Zone response = await zonesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            ZonesClient zonesClient = ZonesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            Zone response = zonesClient.Get(project, zone);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            ZonesClient zonesClient = await ZonesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            Zone response = await zonesClient.GetAsync(project, zone);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListZonesRequest, CallSettings)
            // Create client
            ZonesClient zonesClient = ZonesClient.Create();
            // Initialize request argument(s)
            ListZonesRequest request = new ListZonesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ZoneList response = zonesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListZonesRequest, CallSettings)
            // Additional: ListAsync(ListZonesRequest, CancellationToken)
            // Create client
            ZonesClient zonesClient = await ZonesClient.CreateAsync();
            // Initialize request argument(s)
            ListZonesRequest request = new ListZonesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ZoneList response = await zonesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            ZonesClient zonesClient = ZonesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ZoneList response = zonesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            ZonesClient zonesClient = await ZonesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ZoneList response = await zonesClient.ListAsync(project);
            // End snippet
        }
    }
}
