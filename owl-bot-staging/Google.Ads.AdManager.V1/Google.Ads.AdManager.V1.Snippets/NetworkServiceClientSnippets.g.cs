// Copyright 2025 Google LLC
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

namespace GoogleCSharpSnippets
{
    using Google.Ads.AdManager.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNetworkServiceClientSnippets
    {
        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetworkRequestObject()
        {
            // Snippet: GetNetwork(GetNetworkRequest, CallSettings)
            // Create client
            NetworkServiceClient networkServiceClient = NetworkServiceClient.Create();
            // Initialize request argument(s)
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
            };
            // Make the request
            Network response = networkServiceClient.GetNetwork(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkRequestObjectAsync()
        {
            // Snippet: GetNetworkAsync(GetNetworkRequest, CallSettings)
            // Additional: GetNetworkAsync(GetNetworkRequest, CancellationToken)
            // Create client
            NetworkServiceClient networkServiceClient = await NetworkServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
            };
            // Make the request
            Network response = await networkServiceClient.GetNetworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetwork()
        {
            // Snippet: GetNetwork(string, CallSettings)
            // Create client
            NetworkServiceClient networkServiceClient = NetworkServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]";
            // Make the request
            Network response = networkServiceClient.GetNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkAsync()
        {
            // Snippet: GetNetworkAsync(string, CallSettings)
            // Additional: GetNetworkAsync(string, CancellationToken)
            // Create client
            NetworkServiceClient networkServiceClient = await NetworkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]";
            // Make the request
            Network response = await networkServiceClient.GetNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetworkResourceNames()
        {
            // Snippet: GetNetwork(NetworkName, CallSettings)
            // Create client
            NetworkServiceClient networkServiceClient = NetworkServiceClient.Create();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            Network response = networkServiceClient.GetNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkResourceNamesAsync()
        {
            // Snippet: GetNetworkAsync(NetworkName, CallSettings)
            // Additional: GetNetworkAsync(NetworkName, CancellationToken)
            // Create client
            NetworkServiceClient networkServiceClient = await NetworkServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            Network response = await networkServiceClient.GetNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNetworks</summary>
        public void ListNetworksRequestObject()
        {
            // Snippet: ListNetworks(ListNetworksRequest, CallSettings)
            // Create client
            NetworkServiceClient networkServiceClient = NetworkServiceClient.Create();
            // Initialize request argument(s)
            ListNetworksRequest request = new ListNetworksRequest { };
            // Make the request
            ListNetworksResponse response = networkServiceClient.ListNetworks(request);
            // End snippet
        }

        /// <summary>Snippet for ListNetworksAsync</summary>
        public async Task ListNetworksRequestObjectAsync()
        {
            // Snippet: ListNetworksAsync(ListNetworksRequest, CallSettings)
            // Additional: ListNetworksAsync(ListNetworksRequest, CancellationToken)
            // Create client
            NetworkServiceClient networkServiceClient = await NetworkServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworksRequest request = new ListNetworksRequest { };
            // Make the request
            ListNetworksResponse response = await networkServiceClient.ListNetworksAsync(request);
            // End snippet
        }
    }
}
