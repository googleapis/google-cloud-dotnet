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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AppTopology.V1;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAppTopologyClientSnippets
    {
        /// <summary>Snippet for GenerateDiscoveredResourcesTopology</summary>
        public void GenerateDiscoveredResourcesTopologyRequestObject()
        {
            // Snippet: GenerateDiscoveredResourcesTopology(GenerateDiscoveredResourcesTopologyRequest, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            GenerateDiscoveredResourcesTopologyRequest request = new GenerateDiscoveredResourcesTopologyRequest
            {
                DiscoveredResourcesTopologyName = DiscoveredResourcesTopologyName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TopologyDomainsAsDomainNames =
                {
                    DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                },
                Filter = new GraphPattern(),
            };
            // Make the request
            GenerateDiscoveredResourcesTopologyResponse response = appTopologyClient.GenerateDiscoveredResourcesTopology(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateDiscoveredResourcesTopologyAsync</summary>
        public async Task GenerateDiscoveredResourcesTopologyRequestObjectAsync()
        {
            // Snippet: GenerateDiscoveredResourcesTopologyAsync(GenerateDiscoveredResourcesTopologyRequest, CallSettings)
            // Additional: GenerateDiscoveredResourcesTopologyAsync(GenerateDiscoveredResourcesTopologyRequest, CancellationToken)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            GenerateDiscoveredResourcesTopologyRequest request = new GenerateDiscoveredResourcesTopologyRequest
            {
                DiscoveredResourcesTopologyName = DiscoveredResourcesTopologyName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TopologyDomainsAsDomainNames =
                {
                    DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                },
                Filter = new GraphPattern(),
            };
            // Make the request
            GenerateDiscoveredResourcesTopologyResponse response = await appTopologyClient.GenerateDiscoveredResourcesTopologyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateDiscoveredResourcesTopology</summary>
        public void GenerateDiscoveredResourcesTopology()
        {
            // Snippet: GenerateDiscoveredResourcesTopology(string, IEnumerable<string>, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveredResourcesTopology";
            IEnumerable<string> topologyDomains = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]",
            };
            // Make the request
            GenerateDiscoveredResourcesTopologyResponse response = appTopologyClient.GenerateDiscoveredResourcesTopology(name, topologyDomains);
            // End snippet
        }

        /// <summary>Snippet for GenerateDiscoveredResourcesTopologyAsync</summary>
        public async Task GenerateDiscoveredResourcesTopologyAsync()
        {
            // Snippet: GenerateDiscoveredResourcesTopologyAsync(string, IEnumerable<string>, CallSettings)
            // Additional: GenerateDiscoveredResourcesTopologyAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveredResourcesTopology";
            IEnumerable<string> topologyDomains = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]",
            };
            // Make the request
            GenerateDiscoveredResourcesTopologyResponse response = await appTopologyClient.GenerateDiscoveredResourcesTopologyAsync(name, topologyDomains);
            // End snippet
        }

        /// <summary>Snippet for GenerateDiscoveredResourcesTopology</summary>
        public void GenerateDiscoveredResourcesTopologyResourceNames()
        {
            // Snippet: GenerateDiscoveredResourcesTopology(DiscoveredResourcesTopologyName, IEnumerable<DomainName>, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            DiscoveredResourcesTopologyName name = DiscoveredResourcesTopologyName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<DomainName> topologyDomains = new DomainName[]
            {
                DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            GenerateDiscoveredResourcesTopologyResponse response = appTopologyClient.GenerateDiscoveredResourcesTopology(name, topologyDomains);
            // End snippet
        }

        /// <summary>Snippet for GenerateDiscoveredResourcesTopologyAsync</summary>
        public async Task GenerateDiscoveredResourcesTopologyResourceNamesAsync()
        {
            // Snippet: GenerateDiscoveredResourcesTopologyAsync(DiscoveredResourcesTopologyName, IEnumerable<DomainName>, CallSettings)
            // Additional: GenerateDiscoveredResourcesTopologyAsync(DiscoveredResourcesTopologyName, IEnumerable<DomainName>, CancellationToken)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            DiscoveredResourcesTopologyName name = DiscoveredResourcesTopologyName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<DomainName> topologyDomains = new DomainName[]
            {
                DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            GenerateDiscoveredResourcesTopologyResponse response = await appTopologyClient.GenerateDiscoveredResourcesTopologyAsync(name, topologyDomains);
            // End snippet
        }

        /// <summary>Snippet for GetSchema</summary>
        public void GetSchemaRequestObject()
        {
            // Snippet: GetSchema(GetSchemaRequest, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            Schema response = appTopologyClient.GetSchema(request);
            // End snippet
        }

        /// <summary>Snippet for GetSchemaAsync</summary>
        public async Task GetSchemaRequestObjectAsync()
        {
            // Snippet: GetSchemaAsync(GetSchemaRequest, CallSettings)
            // Additional: GetSchemaAsync(GetSchemaRequest, CancellationToken)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            Schema response = await appTopologyClient.GetSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSchema</summary>
        public void GetSchema()
        {
            // Snippet: GetSchema(string, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]/schema";
            // Make the request
            Schema response = appTopologyClient.GetSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchemaAsync</summary>
        public async Task GetSchemaAsync()
        {
            // Snippet: GetSchemaAsync(string, CallSettings)
            // Additional: GetSchemaAsync(string, CancellationToken)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]/schema";
            // Make the request
            Schema response = await appTopologyClient.GetSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchema</summary>
        public void GetSchemaResourceNames()
        {
            // Snippet: GetSchema(SchemaName, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            // Make the request
            Schema response = appTopologyClient.GetSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchemaAsync</summary>
        public async Task GetSchemaResourceNamesAsync()
        {
            // Snippet: GetSchemaAsync(SchemaName, CallSettings)
            // Additional: GetSchemaAsync(SchemaName, CancellationToken)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            // Make the request
            Schema response = await appTopologyClient.GetSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDomain</summary>
        public void GetDomainRequestObject()
        {
            // Snippet: GetDomain(GetDomainRequest, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            GetDomainRequest request = new GetDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            Domain response = appTopologyClient.GetDomain(request);
            // End snippet
        }

        /// <summary>Snippet for GetDomainAsync</summary>
        public async Task GetDomainRequestObjectAsync()
        {
            // Snippet: GetDomainAsync(GetDomainRequest, CallSettings)
            // Additional: GetDomainAsync(GetDomainRequest, CancellationToken)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            GetDomainRequest request = new GetDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            Domain response = await appTopologyClient.GetDomainAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDomain</summary>
        public void GetDomain()
        {
            // Snippet: GetDomain(string, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            // Make the request
            Domain response = appTopologyClient.GetDomain(name);
            // End snippet
        }

        /// <summary>Snippet for GetDomainAsync</summary>
        public async Task GetDomainAsync()
        {
            // Snippet: GetDomainAsync(string, CallSettings)
            // Additional: GetDomainAsync(string, CancellationToken)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            // Make the request
            Domain response = await appTopologyClient.GetDomainAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDomain</summary>
        public void GetDomainResourceNames()
        {
            // Snippet: GetDomain(DomainName, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            // Make the request
            Domain response = appTopologyClient.GetDomain(name);
            // End snippet
        }

        /// <summary>Snippet for GetDomainAsync</summary>
        public async Task GetDomainResourceNamesAsync()
        {
            // Snippet: GetDomainAsync(DomainName, CallSettings)
            // Additional: GetDomainAsync(DomainName, CancellationToken)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            // Make the request
            Domain response = await appTopologyClient.GetDomainAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDomains</summary>
        public void ListDomainsRequestObject()
        {
            // Snippet: ListDomains(ListDomainsRequest, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            ListDomainsRequest request = new ListDomainsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListDomainsResponse, Domain> response = appTopologyClient.ListDomains(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Domain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDomainsAsync</summary>
        public async Task ListDomainsRequestObjectAsync()
        {
            // Snippet: ListDomainsAsync(ListDomainsRequest, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            ListDomainsRequest request = new ListDomainsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDomainsResponse, Domain> response = appTopologyClient.ListDomainsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Domain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDomains</summary>
        public void ListDomains()
        {
            // Snippet: ListDomains(string, string, int?, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDomainsResponse, Domain> response = appTopologyClient.ListDomains(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Domain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDomainsAsync</summary>
        public async Task ListDomainsAsync()
        {
            // Snippet: ListDomainsAsync(string, string, int?, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDomainsResponse, Domain> response = appTopologyClient.ListDomainsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Domain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDomains</summary>
        public void ListDomainsResourceNames()
        {
            // Snippet: ListDomains(LocationName, string, int?, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = AppTopologyClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDomainsResponse, Domain> response = appTopologyClient.ListDomains(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Domain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDomainsAsync</summary>
        public async Task ListDomainsResourceNamesAsync()
        {
            // Snippet: ListDomainsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppTopologyClient appTopologyClient = await AppTopologyClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDomainsResponse, Domain> response = appTopologyClient.ListDomainsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Domain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
