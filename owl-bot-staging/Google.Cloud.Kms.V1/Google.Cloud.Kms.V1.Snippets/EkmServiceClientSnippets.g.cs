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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Kms.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEkmServiceClientSnippets
    {
        /// <summary>Snippet for ListEkmConnections</summary>
        public void ListEkmConnectionsRequestObject()
        {
            // Snippet: ListEkmConnections(ListEkmConnectionsRequest, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            ListEkmConnectionsRequest request = new ListEkmConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEkmConnectionsResponse, EkmConnection> response = ekmServiceClient.ListEkmConnections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EkmConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEkmConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EkmConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EkmConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EkmConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEkmConnectionsAsync</summary>
        public async Task ListEkmConnectionsRequestObjectAsync()
        {
            // Snippet: ListEkmConnectionsAsync(ListEkmConnectionsRequest, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEkmConnectionsRequest request = new ListEkmConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEkmConnectionsResponse, EkmConnection> response = ekmServiceClient.ListEkmConnectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EkmConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEkmConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EkmConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EkmConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EkmConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEkmConnections</summary>
        public void ListEkmConnections()
        {
            // Snippet: ListEkmConnections(string, string, int?, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEkmConnectionsResponse, EkmConnection> response = ekmServiceClient.ListEkmConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EkmConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEkmConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EkmConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EkmConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EkmConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEkmConnectionsAsync</summary>
        public async Task ListEkmConnectionsAsync()
        {
            // Snippet: ListEkmConnectionsAsync(string, string, int?, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEkmConnectionsResponse, EkmConnection> response = ekmServiceClient.ListEkmConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EkmConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEkmConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EkmConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EkmConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EkmConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEkmConnections</summary>
        public void ListEkmConnectionsResourceNames()
        {
            // Snippet: ListEkmConnections(LocationName, string, int?, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEkmConnectionsResponse, EkmConnection> response = ekmServiceClient.ListEkmConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EkmConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEkmConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EkmConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EkmConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EkmConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEkmConnectionsAsync</summary>
        public async Task ListEkmConnectionsResourceNamesAsync()
        {
            // Snippet: ListEkmConnectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEkmConnectionsResponse, EkmConnection> response = ekmServiceClient.ListEkmConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EkmConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEkmConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EkmConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EkmConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EkmConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnection</summary>
        public void GetEkmConnectionRequestObject()
        {
            // Snippet: GetEkmConnection(GetEkmConnectionRequest, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            GetEkmConnectionRequest request = new GetEkmConnectionRequest
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
            };
            // Make the request
            EkmConnection response = ekmServiceClient.GetEkmConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnectionAsync</summary>
        public async Task GetEkmConnectionRequestObjectAsync()
        {
            // Snippet: GetEkmConnectionAsync(GetEkmConnectionRequest, CallSettings)
            // Additional: GetEkmConnectionAsync(GetEkmConnectionRequest, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEkmConnectionRequest request = new GetEkmConnectionRequest
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
            };
            // Make the request
            EkmConnection response = await ekmServiceClient.GetEkmConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnection</summary>
        public void GetEkmConnection()
        {
            // Snippet: GetEkmConnection(string, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ekmConnections/[EKM_CONNECTION]";
            // Make the request
            EkmConnection response = ekmServiceClient.GetEkmConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnectionAsync</summary>
        public async Task GetEkmConnectionAsync()
        {
            // Snippet: GetEkmConnectionAsync(string, CallSettings)
            // Additional: GetEkmConnectionAsync(string, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ekmConnections/[EKM_CONNECTION]";
            // Make the request
            EkmConnection response = await ekmServiceClient.GetEkmConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnection</summary>
        public void GetEkmConnectionResourceNames()
        {
            // Snippet: GetEkmConnection(EkmConnectionName, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            EkmConnectionName name = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]");
            // Make the request
            EkmConnection response = ekmServiceClient.GetEkmConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnectionAsync</summary>
        public async Task GetEkmConnectionResourceNamesAsync()
        {
            // Snippet: GetEkmConnectionAsync(EkmConnectionName, CallSettings)
            // Additional: GetEkmConnectionAsync(EkmConnectionName, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            EkmConnectionName name = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]");
            // Make the request
            EkmConnection response = await ekmServiceClient.GetEkmConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEkmConnection</summary>
        public void CreateEkmConnectionRequestObject()
        {
            // Snippet: CreateEkmConnection(CreateEkmConnectionRequest, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            CreateEkmConnectionRequest request = new CreateEkmConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EkmConnectionId = "",
                EkmConnection = new EkmConnection(),
            };
            // Make the request
            EkmConnection response = ekmServiceClient.CreateEkmConnection(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEkmConnectionAsync</summary>
        public async Task CreateEkmConnectionRequestObjectAsync()
        {
            // Snippet: CreateEkmConnectionAsync(CreateEkmConnectionRequest, CallSettings)
            // Additional: CreateEkmConnectionAsync(CreateEkmConnectionRequest, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEkmConnectionRequest request = new CreateEkmConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EkmConnectionId = "",
                EkmConnection = new EkmConnection(),
            };
            // Make the request
            EkmConnection response = await ekmServiceClient.CreateEkmConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEkmConnection</summary>
        public void CreateEkmConnection()
        {
            // Snippet: CreateEkmConnection(string, string, EkmConnection, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string ekmConnectionId = "";
            EkmConnection ekmConnection = new EkmConnection();
            // Make the request
            EkmConnection response = ekmServiceClient.CreateEkmConnection(parent, ekmConnectionId, ekmConnection);
            // End snippet
        }

        /// <summary>Snippet for CreateEkmConnectionAsync</summary>
        public async Task CreateEkmConnectionAsync()
        {
            // Snippet: CreateEkmConnectionAsync(string, string, EkmConnection, CallSettings)
            // Additional: CreateEkmConnectionAsync(string, string, EkmConnection, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string ekmConnectionId = "";
            EkmConnection ekmConnection = new EkmConnection();
            // Make the request
            EkmConnection response = await ekmServiceClient.CreateEkmConnectionAsync(parent, ekmConnectionId, ekmConnection);
            // End snippet
        }

        /// <summary>Snippet for CreateEkmConnection</summary>
        public void CreateEkmConnectionResourceNames()
        {
            // Snippet: CreateEkmConnection(LocationName, string, EkmConnection, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string ekmConnectionId = "";
            EkmConnection ekmConnection = new EkmConnection();
            // Make the request
            EkmConnection response = ekmServiceClient.CreateEkmConnection(parent, ekmConnectionId, ekmConnection);
            // End snippet
        }

        /// <summary>Snippet for CreateEkmConnectionAsync</summary>
        public async Task CreateEkmConnectionResourceNamesAsync()
        {
            // Snippet: CreateEkmConnectionAsync(LocationName, string, EkmConnection, CallSettings)
            // Additional: CreateEkmConnectionAsync(LocationName, string, EkmConnection, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string ekmConnectionId = "";
            EkmConnection ekmConnection = new EkmConnection();
            // Make the request
            EkmConnection response = await ekmServiceClient.CreateEkmConnectionAsync(parent, ekmConnectionId, ekmConnection);
            // End snippet
        }

        /// <summary>Snippet for UpdateEkmConnection</summary>
        public void UpdateEkmConnectionRequestObject()
        {
            // Snippet: UpdateEkmConnection(UpdateEkmConnectionRequest, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            UpdateEkmConnectionRequest request = new UpdateEkmConnectionRequest
            {
                EkmConnection = new EkmConnection(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EkmConnection response = ekmServiceClient.UpdateEkmConnection(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEkmConnectionAsync</summary>
        public async Task UpdateEkmConnectionRequestObjectAsync()
        {
            // Snippet: UpdateEkmConnectionAsync(UpdateEkmConnectionRequest, CallSettings)
            // Additional: UpdateEkmConnectionAsync(UpdateEkmConnectionRequest, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEkmConnectionRequest request = new UpdateEkmConnectionRequest
            {
                EkmConnection = new EkmConnection(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EkmConnection response = await ekmServiceClient.UpdateEkmConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEkmConnection</summary>
        public void UpdateEkmConnection()
        {
            // Snippet: UpdateEkmConnection(EkmConnection, FieldMask, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            EkmConnection ekmConnection = new EkmConnection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EkmConnection response = ekmServiceClient.UpdateEkmConnection(ekmConnection, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEkmConnectionAsync</summary>
        public async Task UpdateEkmConnectionAsync()
        {
            // Snippet: UpdateEkmConnectionAsync(EkmConnection, FieldMask, CallSettings)
            // Additional: UpdateEkmConnectionAsync(EkmConnection, FieldMask, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            EkmConnection ekmConnection = new EkmConnection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EkmConnection response = await ekmServiceClient.UpdateEkmConnectionAsync(ekmConnection, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConfig</summary>
        public void GetEkmConfigRequestObject()
        {
            // Snippet: GetEkmConfig(GetEkmConfigRequest, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            GetEkmConfigRequest request = new GetEkmConfigRequest
            {
                EkmConfigName = EkmConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            EkmConfig response = ekmServiceClient.GetEkmConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConfigAsync</summary>
        public async Task GetEkmConfigRequestObjectAsync()
        {
            // Snippet: GetEkmConfigAsync(GetEkmConfigRequest, CallSettings)
            // Additional: GetEkmConfigAsync(GetEkmConfigRequest, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEkmConfigRequest request = new GetEkmConfigRequest
            {
                EkmConfigName = EkmConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            EkmConfig response = await ekmServiceClient.GetEkmConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConfig</summary>
        public void GetEkmConfig()
        {
            // Snippet: GetEkmConfig(string, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ekmConfig";
            // Make the request
            EkmConfig response = ekmServiceClient.GetEkmConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConfigAsync</summary>
        public async Task GetEkmConfigAsync()
        {
            // Snippet: GetEkmConfigAsync(string, CallSettings)
            // Additional: GetEkmConfigAsync(string, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ekmConfig";
            // Make the request
            EkmConfig response = await ekmServiceClient.GetEkmConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConfig</summary>
        public void GetEkmConfigResourceNames()
        {
            // Snippet: GetEkmConfig(EkmConfigName, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            EkmConfigName name = EkmConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            EkmConfig response = ekmServiceClient.GetEkmConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConfigAsync</summary>
        public async Task GetEkmConfigResourceNamesAsync()
        {
            // Snippet: GetEkmConfigAsync(EkmConfigName, CallSettings)
            // Additional: GetEkmConfigAsync(EkmConfigName, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            EkmConfigName name = EkmConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            EkmConfig response = await ekmServiceClient.GetEkmConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateEkmConfig</summary>
        public void UpdateEkmConfigRequestObject()
        {
            // Snippet: UpdateEkmConfig(UpdateEkmConfigRequest, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            UpdateEkmConfigRequest request = new UpdateEkmConfigRequest
            {
                EkmConfig = new EkmConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EkmConfig response = ekmServiceClient.UpdateEkmConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEkmConfigAsync</summary>
        public async Task UpdateEkmConfigRequestObjectAsync()
        {
            // Snippet: UpdateEkmConfigAsync(UpdateEkmConfigRequest, CallSettings)
            // Additional: UpdateEkmConfigAsync(UpdateEkmConfigRequest, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEkmConfigRequest request = new UpdateEkmConfigRequest
            {
                EkmConfig = new EkmConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EkmConfig response = await ekmServiceClient.UpdateEkmConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEkmConfig</summary>
        public void UpdateEkmConfig()
        {
            // Snippet: UpdateEkmConfig(EkmConfig, FieldMask, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            EkmConfig ekmConfig = new EkmConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EkmConfig response = ekmServiceClient.UpdateEkmConfig(ekmConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEkmConfigAsync</summary>
        public async Task UpdateEkmConfigAsync()
        {
            // Snippet: UpdateEkmConfigAsync(EkmConfig, FieldMask, CallSettings)
            // Additional: UpdateEkmConfigAsync(EkmConfig, FieldMask, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            EkmConfig ekmConfig = new EkmConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EkmConfig response = await ekmServiceClient.UpdateEkmConfigAsync(ekmConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for VerifyConnectivity</summary>
        public void VerifyConnectivityRequestObject()
        {
            // Snippet: VerifyConnectivity(VerifyConnectivityRequest, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            VerifyConnectivityRequest request = new VerifyConnectivityRequest
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
            };
            // Make the request
            VerifyConnectivityResponse response = ekmServiceClient.VerifyConnectivity(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyConnectivityAsync</summary>
        public async Task VerifyConnectivityRequestObjectAsync()
        {
            // Snippet: VerifyConnectivityAsync(VerifyConnectivityRequest, CallSettings)
            // Additional: VerifyConnectivityAsync(VerifyConnectivityRequest, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            VerifyConnectivityRequest request = new VerifyConnectivityRequest
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
            };
            // Make the request
            VerifyConnectivityResponse response = await ekmServiceClient.VerifyConnectivityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyConnectivity</summary>
        public void VerifyConnectivity()
        {
            // Snippet: VerifyConnectivity(string, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ekmConnections/[EKM_CONNECTION]";
            // Make the request
            VerifyConnectivityResponse response = ekmServiceClient.VerifyConnectivity(name);
            // End snippet
        }

        /// <summary>Snippet for VerifyConnectivityAsync</summary>
        public async Task VerifyConnectivityAsync()
        {
            // Snippet: VerifyConnectivityAsync(string, CallSettings)
            // Additional: VerifyConnectivityAsync(string, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ekmConnections/[EKM_CONNECTION]";
            // Make the request
            VerifyConnectivityResponse response = await ekmServiceClient.VerifyConnectivityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for VerifyConnectivity</summary>
        public void VerifyConnectivityResourceNames()
        {
            // Snippet: VerifyConnectivity(EkmConnectionName, CallSettings)
            // Create client
            EkmServiceClient ekmServiceClient = EkmServiceClient.Create();
            // Initialize request argument(s)
            EkmConnectionName name = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]");
            // Make the request
            VerifyConnectivityResponse response = ekmServiceClient.VerifyConnectivity(name);
            // End snippet
        }

        /// <summary>Snippet for VerifyConnectivityAsync</summary>
        public async Task VerifyConnectivityResourceNamesAsync()
        {
            // Snippet: VerifyConnectivityAsync(EkmConnectionName, CallSettings)
            // Additional: VerifyConnectivityAsync(EkmConnectionName, CancellationToken)
            // Create client
            EkmServiceClient ekmServiceClient = await EkmServiceClient.CreateAsync();
            // Initialize request argument(s)
            EkmConnectionName name = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]");
            // Make the request
            VerifyConnectivityResponse response = await ekmServiceClient.VerifyConnectivityAsync(name);
            // End snippet
        }
    }
}
