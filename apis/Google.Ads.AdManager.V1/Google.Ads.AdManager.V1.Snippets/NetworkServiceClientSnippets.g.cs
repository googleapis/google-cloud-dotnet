// Copyright 2026 Google LLC
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
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
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
            ListNetworksRequest request = new ListNetworksRequest { Skip = 0, };
            // Make the request
            PagedEnumerable<ListNetworksResponse, Network> response = networkServiceClient.ListNetworks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Network item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworksAsync</summary>
        public async Task ListNetworksRequestObjectAsync()
        {
            // Snippet: ListNetworksAsync(ListNetworksRequest, CallSettings)
            // Create client
            NetworkServiceClient networkServiceClient = await NetworkServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworksRequest request = new ListNetworksRequest { Skip = 0, };
            // Make the request
            PagedAsyncEnumerable<ListNetworksResponse, Network> response = networkServiceClient.ListNetworksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Network item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateNetwork</summary>
        public void UpdateNetworkRequestObject()
        {
            // Snippet: UpdateNetwork(UpdateNetworkRequest, CallSettings)
            // Create client
            NetworkServiceClient networkServiceClient = NetworkServiceClient.Create();
            // Initialize request argument(s)
            UpdateNetworkRequest request = new UpdateNetworkRequest
            {
                Network = new Network(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Network response = networkServiceClient.UpdateNetwork(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkAsync</summary>
        public async Task UpdateNetworkRequestObjectAsync()
        {
            // Snippet: UpdateNetworkAsync(UpdateNetworkRequest, CallSettings)
            // Additional: UpdateNetworkAsync(UpdateNetworkRequest, CancellationToken)
            // Create client
            NetworkServiceClient networkServiceClient = await NetworkServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNetworkRequest request = new UpdateNetworkRequest
            {
                Network = new Network(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Network response = await networkServiceClient.UpdateNetworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNetwork</summary>
        public void UpdateNetwork()
        {
            // Snippet: UpdateNetwork(Network, FieldMask, CallSettings)
            // Create client
            NetworkServiceClient networkServiceClient = NetworkServiceClient.Create();
            // Initialize request argument(s)
            Network network = new Network();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Network response = networkServiceClient.UpdateNetwork(network, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkAsync</summary>
        public async Task UpdateNetworkAsync()
        {
            // Snippet: UpdateNetworkAsync(Network, FieldMask, CallSettings)
            // Additional: UpdateNetworkAsync(Network, FieldMask, CancellationToken)
            // Create client
            NetworkServiceClient networkServiceClient = await NetworkServiceClient.CreateAsync();
            // Initialize request argument(s)
            Network network = new Network();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Network response = await networkServiceClient.UpdateNetworkAsync(network, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ProvisionTestNetwork</summary>
        public void ProvisionTestNetworkRequestObject()
        {
            // Snippet: ProvisionTestNetwork(ProvisionTestNetworkRequest, CallSettings)
            // Create client
            NetworkServiceClient networkServiceClient = NetworkServiceClient.Create();
            // Initialize request argument(s)
            ProvisionTestNetworkRequest request = new ProvisionTestNetworkRequest { };
            // Make the request
            Network response = networkServiceClient.ProvisionTestNetwork(request);
            // End snippet
        }

        /// <summary>Snippet for ProvisionTestNetworkAsync</summary>
        public async Task ProvisionTestNetworkRequestObjectAsync()
        {
            // Snippet: ProvisionTestNetworkAsync(ProvisionTestNetworkRequest, CallSettings)
            // Additional: ProvisionTestNetworkAsync(ProvisionTestNetworkRequest, CancellationToken)
            // Create client
            NetworkServiceClient networkServiceClient = await NetworkServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProvisionTestNetworkRequest request = new ProvisionTestNetworkRequest { };
            // Make the request
            Network response = await networkServiceClient.ProvisionTestNetworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultThirdPartyDataDeclaration</summary>
        public void GetDefaultThirdPartyDataDeclarationRequestObject()
        {
            // Snippet: GetDefaultThirdPartyDataDeclaration(GetDefaultThirdPartyDataDeclarationRequest, CallSettings)
            // Create client
            NetworkServiceClient networkServiceClient = NetworkServiceClient.Create();
            // Initialize request argument(s)
            GetDefaultThirdPartyDataDeclarationRequest request = new GetDefaultThirdPartyDataDeclarationRequest
            {
                DefaultThirdPartyDataDeclarationName = DefaultThirdPartyDataDeclarationName.FromNetworkCode("[NETWORK_CODE]"),
            };
            // Make the request
            DefaultThirdPartyDataDeclaration response = networkServiceClient.GetDefaultThirdPartyDataDeclaration(request);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultThirdPartyDataDeclarationAsync</summary>
        public async Task GetDefaultThirdPartyDataDeclarationRequestObjectAsync()
        {
            // Snippet: GetDefaultThirdPartyDataDeclarationAsync(GetDefaultThirdPartyDataDeclarationRequest, CallSettings)
            // Additional: GetDefaultThirdPartyDataDeclarationAsync(GetDefaultThirdPartyDataDeclarationRequest, CancellationToken)
            // Create client
            NetworkServiceClient networkServiceClient = await NetworkServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDefaultThirdPartyDataDeclarationRequest request = new GetDefaultThirdPartyDataDeclarationRequest
            {
                DefaultThirdPartyDataDeclarationName = DefaultThirdPartyDataDeclarationName.FromNetworkCode("[NETWORK_CODE]"),
            };
            // Make the request
            DefaultThirdPartyDataDeclaration response = await networkServiceClient.GetDefaultThirdPartyDataDeclarationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultThirdPartyDataDeclaration</summary>
        public void GetDefaultThirdPartyDataDeclaration()
        {
            // Snippet: GetDefaultThirdPartyDataDeclaration(string, CallSettings)
            // Create client
            NetworkServiceClient networkServiceClient = NetworkServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/defaultThirdPartyDataDeclaration";
            // Make the request
            DefaultThirdPartyDataDeclaration response = networkServiceClient.GetDefaultThirdPartyDataDeclaration(name);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultThirdPartyDataDeclarationAsync</summary>
        public async Task GetDefaultThirdPartyDataDeclarationAsync()
        {
            // Snippet: GetDefaultThirdPartyDataDeclarationAsync(string, CallSettings)
            // Additional: GetDefaultThirdPartyDataDeclarationAsync(string, CancellationToken)
            // Create client
            NetworkServiceClient networkServiceClient = await NetworkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/defaultThirdPartyDataDeclaration";
            // Make the request
            DefaultThirdPartyDataDeclaration response = await networkServiceClient.GetDefaultThirdPartyDataDeclarationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultThirdPartyDataDeclaration</summary>
        public void GetDefaultThirdPartyDataDeclarationResourceNames()
        {
            // Snippet: GetDefaultThirdPartyDataDeclaration(DefaultThirdPartyDataDeclarationName, CallSettings)
            // Create client
            NetworkServiceClient networkServiceClient = NetworkServiceClient.Create();
            // Initialize request argument(s)
            DefaultThirdPartyDataDeclarationName name = DefaultThirdPartyDataDeclarationName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            DefaultThirdPartyDataDeclaration response = networkServiceClient.GetDefaultThirdPartyDataDeclaration(name);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultThirdPartyDataDeclarationAsync</summary>
        public async Task GetDefaultThirdPartyDataDeclarationResourceNamesAsync()
        {
            // Snippet: GetDefaultThirdPartyDataDeclarationAsync(DefaultThirdPartyDataDeclarationName, CallSettings)
            // Additional: GetDefaultThirdPartyDataDeclarationAsync(DefaultThirdPartyDataDeclarationName, CancellationToken)
            // Create client
            NetworkServiceClient networkServiceClient = await NetworkServiceClient.CreateAsync();
            // Initialize request argument(s)
            DefaultThirdPartyDataDeclarationName name = DefaultThirdPartyDataDeclarationName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            DefaultThirdPartyDataDeclaration response = await networkServiceClient.GetDefaultThirdPartyDataDeclarationAsync(name);
            // End snippet
        }
    }
}
