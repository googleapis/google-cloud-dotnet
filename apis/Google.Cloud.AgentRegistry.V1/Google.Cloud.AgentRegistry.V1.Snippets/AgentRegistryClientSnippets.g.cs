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
    using Google.Cloud.AgentRegistry.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAgentRegistryClientSnippets
    {
        /// <summary>Snippet for ListAgents</summary>
        public void ListAgentsRequestObject()
        {
            // Snippet: ListAgents(ListAgentsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListAgentsRequest request = new ListAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAgentsResponse, Agent> response = agentRegistryClient.ListAgents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentsAsync</summary>
        public async Task ListAgentsRequestObjectAsync()
        {
            // Snippet: ListAgentsAsync(ListAgentsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListAgentsRequest request = new ListAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAgentsResponse, Agent> response = agentRegistryClient.ListAgentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgents</summary>
        public void ListAgents()
        {
            // Snippet: ListAgents(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAgentsResponse, Agent> response = agentRegistryClient.ListAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentsAsync</summary>
        public async Task ListAgentsAsync()
        {
            // Snippet: ListAgentsAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAgentsResponse, Agent> response = agentRegistryClient.ListAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgents</summary>
        public void ListAgentsResourceNames()
        {
            // Snippet: ListAgents(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAgentsResponse, Agent> response = agentRegistryClient.ListAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentsAsync</summary>
        public async Task ListAgentsResourceNamesAsync()
        {
            // Snippet: ListAgentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAgentsResponse, Agent> response = agentRegistryClient.ListAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgents</summary>
        public void SearchAgentsRequestObject()
        {
            // Snippet: SearchAgents(SearchAgentsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            SearchAgentsRequest request = new SearchAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SearchString = "",
            };
            // Make the request
            PagedEnumerable<SearchAgentsResponse, Agent> response = agentRegistryClient.SearchAgents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgentsAsync</summary>
        public async Task SearchAgentsRequestObjectAsync()
        {
            // Snippet: SearchAgentsAsync(SearchAgentsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SearchAgentsRequest request = new SearchAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SearchString = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchAgentsResponse, Agent> response = agentRegistryClient.SearchAgentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgents</summary>
        public void SearchAgents()
        {
            // Snippet: SearchAgents(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<SearchAgentsResponse, Agent> response = agentRegistryClient.SearchAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgentsAsync</summary>
        public async Task SearchAgentsAsync()
        {
            // Snippet: SearchAgentsAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<SearchAgentsResponse, Agent> response = agentRegistryClient.SearchAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgents</summary>
        public void SearchAgentsResourceNames()
        {
            // Snippet: SearchAgents(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<SearchAgentsResponse, Agent> response = agentRegistryClient.SearchAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAgentsAsync</summary>
        public async Task SearchAgentsResourceNamesAsync()
        {
            // Snippet: SearchAgentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<SearchAgentsResponse, Agent> response = agentRegistryClient.SearchAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAgent</summary>
        public void GetAgentRequestObject()
        {
            // Snippet: GetAgent(GetAgentRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetAgentRequest request = new GetAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            Agent response = agentRegistryClient.GetAgent(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAsync</summary>
        public async Task GetAgentRequestObjectAsync()
        {
            // Snippet: GetAgentAsync(GetAgentRequest, CallSettings)
            // Additional: GetAgentAsync(GetAgentRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetAgentRequest request = new GetAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            Agent response = await agentRegistryClient.GetAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgent</summary>
        public void GetAgent()
        {
            // Snippet: GetAgent(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            Agent response = agentRegistryClient.GetAgent(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAsync</summary>
        public async Task GetAgentAsync()
        {
            // Snippet: GetAgentAsync(string, CallSettings)
            // Additional: GetAgentAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            Agent response = await agentRegistryClient.GetAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgent</summary>
        public void GetAgentResourceNames()
        {
            // Snippet: GetAgent(AgentName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            Agent response = agentRegistryClient.GetAgent(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAsync</summary>
        public async Task GetAgentResourceNamesAsync()
        {
            // Snippet: GetAgentAsync(AgentName, CallSettings)
            // Additional: GetAgentAsync(AgentName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            Agent response = await agentRegistryClient.GetAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEndpoints</summary>
        public void ListEndpointsRequestObject()
        {
            // Snippet: ListEndpoints(ListEndpointsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = agentRegistryClient.ListEndpoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointsAsync</summary>
        public async Task ListEndpointsRequestObjectAsync()
        {
            // Snippet: ListEndpointsAsync(ListEndpointsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = agentRegistryClient.ListEndpointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpoints</summary>
        public void ListEndpoints()
        {
            // Snippet: ListEndpoints(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = agentRegistryClient.ListEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointsAsync</summary>
        public async Task ListEndpointsAsync()
        {
            // Snippet: ListEndpointsAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = agentRegistryClient.ListEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpoints</summary>
        public void ListEndpointsResourceNames()
        {
            // Snippet: ListEndpoints(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = agentRegistryClient.ListEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointsAsync</summary>
        public async Task ListEndpointsResourceNamesAsync()
        {
            // Snippet: ListEndpointsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = agentRegistryClient.ListEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpointRequestObject()
        {
            // Snippet: GetEndpoint(GetEndpointRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            // Make the request
            Endpoint response = agentRegistryClient.GetEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointRequestObjectAsync()
        {
            // Snippet: GetEndpointAsync(GetEndpointRequest, CallSettings)
            // Additional: GetEndpointAsync(GetEndpointRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            // Make the request
            Endpoint response = await agentRegistryClient.GetEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpoint()
        {
            // Snippet: GetEndpoint(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Endpoint response = agentRegistryClient.GetEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointAsync()
        {
            // Snippet: GetEndpointAsync(string, CallSettings)
            // Additional: GetEndpointAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Endpoint response = await agentRegistryClient.GetEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpointResourceNames()
        {
            // Snippet: GetEndpoint(EndpointName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Endpoint response = agentRegistryClient.GetEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointResourceNamesAsync()
        {
            // Snippet: GetEndpointAsync(EndpointName, CallSettings)
            // Additional: GetEndpointAsync(EndpointName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Endpoint response = await agentRegistryClient.GetEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMcpServers</summary>
        public void ListMcpServersRequestObject()
        {
            // Snippet: ListMcpServers(ListMcpServersRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListMcpServersRequest request = new ListMcpServersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListMcpServersResponse, McpServer> response = agentRegistryClient.ListMcpServers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMcpServersAsync</summary>
        public async Task ListMcpServersRequestObjectAsync()
        {
            // Snippet: ListMcpServersAsync(ListMcpServersRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListMcpServersRequest request = new ListMcpServersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMcpServersResponse, McpServer> response = agentRegistryClient.ListMcpServersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMcpServers</summary>
        public void ListMcpServers()
        {
            // Snippet: ListMcpServers(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMcpServersResponse, McpServer> response = agentRegistryClient.ListMcpServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMcpServersAsync</summary>
        public async Task ListMcpServersAsync()
        {
            // Snippet: ListMcpServersAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMcpServersResponse, McpServer> response = agentRegistryClient.ListMcpServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMcpServers</summary>
        public void ListMcpServersResourceNames()
        {
            // Snippet: ListMcpServers(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMcpServersResponse, McpServer> response = agentRegistryClient.ListMcpServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMcpServersAsync</summary>
        public async Task ListMcpServersResourceNamesAsync()
        {
            // Snippet: ListMcpServersAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMcpServersResponse, McpServer> response = agentRegistryClient.ListMcpServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchMcpServers</summary>
        public void SearchMcpServersRequestObject()
        {
            // Snippet: SearchMcpServers(SearchMcpServersRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            SearchMcpServersRequest request = new SearchMcpServersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SearchString = "",
            };
            // Make the request
            PagedEnumerable<SearchMcpServersResponse, McpServer> response = agentRegistryClient.SearchMcpServers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchMcpServersAsync</summary>
        public async Task SearchMcpServersRequestObjectAsync()
        {
            // Snippet: SearchMcpServersAsync(SearchMcpServersRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SearchMcpServersRequest request = new SearchMcpServersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SearchString = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchMcpServersResponse, McpServer> response = agentRegistryClient.SearchMcpServersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchMcpServers</summary>
        public void SearchMcpServers()
        {
            // Snippet: SearchMcpServers(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<SearchMcpServersResponse, McpServer> response = agentRegistryClient.SearchMcpServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchMcpServersAsync</summary>
        public async Task SearchMcpServersAsync()
        {
            // Snippet: SearchMcpServersAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<SearchMcpServersResponse, McpServer> response = agentRegistryClient.SearchMcpServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchMcpServers</summary>
        public void SearchMcpServersResourceNames()
        {
            // Snippet: SearchMcpServers(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<SearchMcpServersResponse, McpServer> response = agentRegistryClient.SearchMcpServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchMcpServersAsync</summary>
        public async Task SearchMcpServersResourceNamesAsync()
        {
            // Snippet: SearchMcpServersAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<SearchMcpServersResponse, McpServer> response = agentRegistryClient.SearchMcpServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMcpServer</summary>
        public void GetMcpServerRequestObject()
        {
            // Snippet: GetMcpServer(GetMcpServerRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetMcpServerRequest request = new GetMcpServerRequest
            {
                McpServerName = McpServerName.FromProjectLocationMcpServer("[PROJECT]", "[LOCATION]", "[MCP_SERVER]"),
            };
            // Make the request
            McpServer response = agentRegistryClient.GetMcpServer(request);
            // End snippet
        }

        /// <summary>Snippet for GetMcpServerAsync</summary>
        public async Task GetMcpServerRequestObjectAsync()
        {
            // Snippet: GetMcpServerAsync(GetMcpServerRequest, CallSettings)
            // Additional: GetMcpServerAsync(GetMcpServerRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetMcpServerRequest request = new GetMcpServerRequest
            {
                McpServerName = McpServerName.FromProjectLocationMcpServer("[PROJECT]", "[LOCATION]", "[MCP_SERVER]"),
            };
            // Make the request
            McpServer response = await agentRegistryClient.GetMcpServerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMcpServer</summary>
        public void GetMcpServer()
        {
            // Snippet: GetMcpServer(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mcpServers/[MCP_SERVER]";
            // Make the request
            McpServer response = agentRegistryClient.GetMcpServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetMcpServerAsync</summary>
        public async Task GetMcpServerAsync()
        {
            // Snippet: GetMcpServerAsync(string, CallSettings)
            // Additional: GetMcpServerAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mcpServers/[MCP_SERVER]";
            // Make the request
            McpServer response = await agentRegistryClient.GetMcpServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMcpServer</summary>
        public void GetMcpServerResourceNames()
        {
            // Snippet: GetMcpServer(McpServerName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            McpServerName name = McpServerName.FromProjectLocationMcpServer("[PROJECT]", "[LOCATION]", "[MCP_SERVER]");
            // Make the request
            McpServer response = agentRegistryClient.GetMcpServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetMcpServerAsync</summary>
        public async Task GetMcpServerResourceNamesAsync()
        {
            // Snippet: GetMcpServerAsync(McpServerName, CallSettings)
            // Additional: GetMcpServerAsync(McpServerName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            McpServerName name = McpServerName.FromProjectLocationMcpServer("[PROJECT]", "[LOCATION]", "[MCP_SERVER]");
            // Make the request
            McpServer response = await agentRegistryClient.GetMcpServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesRequestObject()
        {
            // Snippet: ListServices(ListServicesRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = agentRegistryClient.ListServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesRequestObjectAsync()
        {
            // Snippet: ListServicesAsync(ListServicesRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = agentRegistryClient.ListServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServices()
        {
            // Snippet: ListServices(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = agentRegistryClient.ListServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesAsync()
        {
            // Snippet: ListServicesAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = agentRegistryClient.ListServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesResourceNames()
        {
            // Snippet: ListServices(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = agentRegistryClient.ListServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesResourceNamesAsync()
        {
            // Snippet: ListServicesAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = agentRegistryClient.ListServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceRequestObject()
        {
            // Snippet: GetService(GetServiceRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            // Make the request
            Service response = agentRegistryClient.GetService(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceRequestObjectAsync()
        {
            // Snippet: GetServiceAsync(GetServiceRequest, CallSettings)
            // Additional: GetServiceAsync(GetServiceRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            // Make the request
            Service response = await agentRegistryClient.GetServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetService()
        {
            // Snippet: GetService(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            Service response = agentRegistryClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceAsync()
        {
            // Snippet: GetServiceAsync(string, CallSettings)
            // Additional: GetServiceAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            Service response = await agentRegistryClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceResourceNames()
        {
            // Snippet: GetService(ServiceName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            Service response = agentRegistryClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceResourceNamesAsync()
        {
            // Snippet: GetServiceAsync(ServiceName, CallSettings)
            // Additional: GetServiceAsync(ServiceName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            Service response = await agentRegistryClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceRequestObject()
        {
            // Snippet: CreateService(CreateServiceRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceId = "",
                Service = new Service(),
                RequestId = "",
            };
            // Make the request
            Operation<Service, OperationMetadata> response = agentRegistryClient.CreateService(request);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceRequestObjectAsync()
        {
            // Snippet: CreateServiceAsync(CreateServiceRequest, CallSettings)
            // Additional: CreateServiceAsync(CreateServiceRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceId = "",
                Service = new Service(),
                RequestId = "",
            };
            // Make the request
            Operation<Service, OperationMetadata> response = await agentRegistryClient.CreateServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateService()
        {
            // Snippet: CreateService(string, Service, string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Operation<Service, OperationMetadata> response = agentRegistryClient.CreateService(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceAsync()
        {
            // Snippet: CreateServiceAsync(string, Service, string, CallSettings)
            // Additional: CreateServiceAsync(string, Service, string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Operation<Service, OperationMetadata> response = await agentRegistryClient.CreateServiceAsync(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceResourceNames()
        {
            // Snippet: CreateService(LocationName, Service, string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Operation<Service, OperationMetadata> response = agentRegistryClient.CreateService(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceResourceNamesAsync()
        {
            // Snippet: CreateServiceAsync(LocationName, Service, string, CallSettings)
            // Additional: CreateServiceAsync(LocationName, Service, string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Operation<Service, OperationMetadata> response = await agentRegistryClient.CreateServiceAsync(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateServiceRequestObject()
        {
            // Snippet: UpdateService(UpdateServiceRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                UpdateMask = new FieldMask(),
                Service = new Service(),
                RequestId = "",
            };
            // Make the request
            Operation<Service, OperationMetadata> response = agentRegistryClient.UpdateService(request);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceUpdateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateServiceRequestObjectAsync()
        {
            // Snippet: UpdateServiceAsync(UpdateServiceRequest, CallSettings)
            // Additional: UpdateServiceAsync(UpdateServiceRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                UpdateMask = new FieldMask(),
                Service = new Service(),
                RequestId = "",
            };
            // Make the request
            Operation<Service, OperationMetadata> response = await agentRegistryClient.UpdateServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceUpdateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateService()
        {
            // Snippet: UpdateService(Service, FieldMask, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            Service service = new Service();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Service, OperationMetadata> response = agentRegistryClient.UpdateService(service, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceUpdateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateServiceAsync()
        {
            // Snippet: UpdateServiceAsync(Service, FieldMask, CallSettings)
            // Additional: UpdateServiceAsync(Service, FieldMask, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            Service service = new Service();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Service, OperationMetadata> response = await agentRegistryClient.UpdateServiceAsync(service, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceUpdateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceRequestObject()
        {
            // Snippet: DeleteService(DeleteServiceRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteService(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceRequestObjectAsync()
        {
            // Snippet: DeleteServiceAsync(DeleteServiceRequest, CallSettings)
            // Additional: DeleteServiceAsync(DeleteServiceRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteService()
        {
            // Snippet: DeleteService(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteService(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceAsync()
        {
            // Snippet: DeleteServiceAsync(string, CallSettings)
            // Additional: DeleteServiceAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteServiceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceResourceNames()
        {
            // Snippet: DeleteService(ServiceName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteService(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceResourceNamesAsync()
        {
            // Snippet: DeleteServiceAsync(ServiceName, CallSettings)
            // Additional: DeleteServiceAsync(ServiceName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteServiceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListBindings</summary>
        public void ListBindingsRequestObject()
        {
            // Snippet: ListBindings(ListBindingsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListBindingsRequest request = new ListBindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListBindingsResponse, Binding> response = agentRegistryClient.ListBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBindingsAsync</summary>
        public async Task ListBindingsRequestObjectAsync()
        {
            // Snippet: ListBindingsAsync(ListBindingsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListBindingsRequest request = new ListBindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBindingsResponse, Binding> response = agentRegistryClient.ListBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBindings</summary>
        public void ListBindings()
        {
            // Snippet: ListBindings(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBindingsResponse, Binding> response = agentRegistryClient.ListBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBindingsAsync</summary>
        public async Task ListBindingsAsync()
        {
            // Snippet: ListBindingsAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBindingsResponse, Binding> response = agentRegistryClient.ListBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBindings</summary>
        public void ListBindingsResourceNames()
        {
            // Snippet: ListBindings(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBindingsResponse, Binding> response = agentRegistryClient.ListBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBindingsAsync</summary>
        public async Task ListBindingsResourceNamesAsync()
        {
            // Snippet: ListBindingsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBindingsResponse, Binding> response = agentRegistryClient.ListBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetBinding</summary>
        public void GetBindingRequestObject()
        {
            // Snippet: GetBinding(GetBindingRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetBindingRequest request = new GetBindingRequest
            {
                BindingName = BindingName.FromProjectLocationBinding("[PROJECT]", "[LOCATION]", "[BINDING]"),
            };
            // Make the request
            Binding response = agentRegistryClient.GetBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetBindingAsync</summary>
        public async Task GetBindingRequestObjectAsync()
        {
            // Snippet: GetBindingAsync(GetBindingRequest, CallSettings)
            // Additional: GetBindingAsync(GetBindingRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetBindingRequest request = new GetBindingRequest
            {
                BindingName = BindingName.FromProjectLocationBinding("[PROJECT]", "[LOCATION]", "[BINDING]"),
            };
            // Make the request
            Binding response = await agentRegistryClient.GetBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBinding</summary>
        public void GetBinding()
        {
            // Snippet: GetBinding(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/bindings/[BINDING]";
            // Make the request
            Binding response = agentRegistryClient.GetBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetBindingAsync</summary>
        public async Task GetBindingAsync()
        {
            // Snippet: GetBindingAsync(string, CallSettings)
            // Additional: GetBindingAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/bindings/[BINDING]";
            // Make the request
            Binding response = await agentRegistryClient.GetBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBinding</summary>
        public void GetBindingResourceNames()
        {
            // Snippet: GetBinding(BindingName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            BindingName name = BindingName.FromProjectLocationBinding("[PROJECT]", "[LOCATION]", "[BINDING]");
            // Make the request
            Binding response = agentRegistryClient.GetBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetBindingAsync</summary>
        public async Task GetBindingResourceNamesAsync()
        {
            // Snippet: GetBindingAsync(BindingName, CallSettings)
            // Additional: GetBindingAsync(BindingName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            BindingName name = BindingName.FromProjectLocationBinding("[PROJECT]", "[LOCATION]", "[BINDING]");
            // Make the request
            Binding response = await agentRegistryClient.GetBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateBinding</summary>
        public void CreateBindingRequestObject()
        {
            // Snippet: CreateBinding(CreateBindingRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            CreateBindingRequest request = new CreateBindingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BindingId = "",
                Binding = new Binding(),
                RequestId = "",
            };
            // Make the request
            Operation<Binding, OperationMetadata> response = agentRegistryClient.CreateBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Binding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Binding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Binding, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Binding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBindingAsync</summary>
        public async Task CreateBindingRequestObjectAsync()
        {
            // Snippet: CreateBindingAsync(CreateBindingRequest, CallSettings)
            // Additional: CreateBindingAsync(CreateBindingRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateBindingRequest request = new CreateBindingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BindingId = "",
                Binding = new Binding(),
                RequestId = "",
            };
            // Make the request
            Operation<Binding, OperationMetadata> response = await agentRegistryClient.CreateBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Binding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Binding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Binding, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Binding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBinding</summary>
        public void CreateBinding()
        {
            // Snippet: CreateBinding(string, Binding, string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Binding binding = new Binding();
            string bindingId = "";
            // Make the request
            Operation<Binding, OperationMetadata> response = agentRegistryClient.CreateBinding(parent, binding, bindingId);

            // Poll until the returned long-running operation is complete
            Operation<Binding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Binding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Binding, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Binding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBindingAsync</summary>
        public async Task CreateBindingAsync()
        {
            // Snippet: CreateBindingAsync(string, Binding, string, CallSettings)
            // Additional: CreateBindingAsync(string, Binding, string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Binding binding = new Binding();
            string bindingId = "";
            // Make the request
            Operation<Binding, OperationMetadata> response = await agentRegistryClient.CreateBindingAsync(parent, binding, bindingId);

            // Poll until the returned long-running operation is complete
            Operation<Binding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Binding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Binding, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Binding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBinding</summary>
        public void CreateBindingResourceNames()
        {
            // Snippet: CreateBinding(LocationName, Binding, string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Binding binding = new Binding();
            string bindingId = "";
            // Make the request
            Operation<Binding, OperationMetadata> response = agentRegistryClient.CreateBinding(parent, binding, bindingId);

            // Poll until the returned long-running operation is complete
            Operation<Binding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Binding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Binding, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Binding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBindingAsync</summary>
        public async Task CreateBindingResourceNamesAsync()
        {
            // Snippet: CreateBindingAsync(LocationName, Binding, string, CallSettings)
            // Additional: CreateBindingAsync(LocationName, Binding, string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Binding binding = new Binding();
            string bindingId = "";
            // Make the request
            Operation<Binding, OperationMetadata> response = await agentRegistryClient.CreateBindingAsync(parent, binding, bindingId);

            // Poll until the returned long-running operation is complete
            Operation<Binding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Binding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Binding, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Binding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBinding</summary>
        public void UpdateBindingRequestObject()
        {
            // Snippet: UpdateBinding(UpdateBindingRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            UpdateBindingRequest request = new UpdateBindingRequest
            {
                Binding = new Binding(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<Binding, OperationMetadata> response = agentRegistryClient.UpdateBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Binding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Binding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Binding, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceUpdateBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Binding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBindingAsync</summary>
        public async Task UpdateBindingRequestObjectAsync()
        {
            // Snippet: UpdateBindingAsync(UpdateBindingRequest, CallSettings)
            // Additional: UpdateBindingAsync(UpdateBindingRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBindingRequest request = new UpdateBindingRequest
            {
                Binding = new Binding(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<Binding, OperationMetadata> response = await agentRegistryClient.UpdateBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Binding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Binding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Binding, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceUpdateBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Binding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBinding</summary>
        public void UpdateBinding()
        {
            // Snippet: UpdateBinding(Binding, FieldMask, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            Binding binding = new Binding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Binding, OperationMetadata> response = agentRegistryClient.UpdateBinding(binding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Binding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Binding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Binding, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceUpdateBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Binding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBindingAsync</summary>
        public async Task UpdateBindingAsync()
        {
            // Snippet: UpdateBindingAsync(Binding, FieldMask, CallSettings)
            // Additional: UpdateBindingAsync(Binding, FieldMask, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            Binding binding = new Binding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Binding, OperationMetadata> response = await agentRegistryClient.UpdateBindingAsync(binding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Binding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Binding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Binding, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceUpdateBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Binding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBinding</summary>
        public void DeleteBindingRequestObject()
        {
            // Snippet: DeleteBinding(DeleteBindingRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            DeleteBindingRequest request = new DeleteBindingRequest
            {
                BindingName = BindingName.FromProjectLocationBinding("[PROJECT]", "[LOCATION]", "[BINDING]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBindingAsync</summary>
        public async Task DeleteBindingRequestObjectAsync()
        {
            // Snippet: DeleteBindingAsync(DeleteBindingRequest, CallSettings)
            // Additional: DeleteBindingAsync(DeleteBindingRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBindingRequest request = new DeleteBindingRequest
            {
                BindingName = BindingName.FromProjectLocationBinding("[PROJECT]", "[LOCATION]", "[BINDING]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBinding</summary>
        public void DeleteBinding()
        {
            // Snippet: DeleteBinding(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/bindings/[BINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBindingAsync</summary>
        public async Task DeleteBindingAsync()
        {
            // Snippet: DeleteBindingAsync(string, CallSettings)
            // Additional: DeleteBindingAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/bindings/[BINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBinding</summary>
        public void DeleteBindingResourceNames()
        {
            // Snippet: DeleteBinding(BindingName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            BindingName name = BindingName.FromProjectLocationBinding("[PROJECT]", "[LOCATION]", "[BINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBindingAsync</summary>
        public async Task DeleteBindingResourceNamesAsync()
        {
            // Snippet: DeleteBindingAsync(BindingName, CallSettings)
            // Additional: DeleteBindingAsync(BindingName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            BindingName name = BindingName.FromProjectLocationBinding("[PROJECT]", "[LOCATION]", "[BINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchAvailableBindings</summary>
        public void FetchAvailableBindingsRequestObject()
        {
            // Snippet: FetchAvailableBindings(FetchAvailableBindingsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            FetchAvailableBindingsRequest request = new FetchAvailableBindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceIdentifier = "",
                TargetIdentifier = "",
            };
            // Make the request
            PagedEnumerable<FetchAvailableBindingsResponse, Binding> response = agentRegistryClient.FetchAvailableBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchAvailableBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchAvailableBindingsAsync</summary>
        public async Task FetchAvailableBindingsRequestObjectAsync()
        {
            // Snippet: FetchAvailableBindingsAsync(FetchAvailableBindingsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            FetchAvailableBindingsRequest request = new FetchAvailableBindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceIdentifier = "",
                TargetIdentifier = "",
            };
            // Make the request
            PagedAsyncEnumerable<FetchAvailableBindingsResponse, Binding> response = agentRegistryClient.FetchAvailableBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchAvailableBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchAvailableBindings</summary>
        public void FetchAvailableBindings()
        {
            // Snippet: FetchAvailableBindings(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<FetchAvailableBindingsResponse, Binding> response = agentRegistryClient.FetchAvailableBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchAvailableBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchAvailableBindingsAsync</summary>
        public async Task FetchAvailableBindingsAsync()
        {
            // Snippet: FetchAvailableBindingsAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<FetchAvailableBindingsResponse, Binding> response = agentRegistryClient.FetchAvailableBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchAvailableBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchAvailableBindings</summary>
        public void FetchAvailableBindingsResourceNames()
        {
            // Snippet: FetchAvailableBindings(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<FetchAvailableBindingsResponse, Binding> response = agentRegistryClient.FetchAvailableBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchAvailableBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchAvailableBindingsAsync</summary>
        public async Task FetchAvailableBindingsResourceNamesAsync()
        {
            // Snippet: FetchAvailableBindingsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<FetchAvailableBindingsResponse, Binding> response = agentRegistryClient.FetchAvailableBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Binding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchAvailableBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Binding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Binding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Binding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSkill</summary>
        public void CreateSkillRequestObject()
        {
            // Snippet: CreateSkill(CreateSkillRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            CreateSkillRequest request = new CreateSkillRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SkillId = "",
                Skill = new Skill(),
                RequestId = "",
            };
            // Make the request
            Operation<Skill, OperationMetadata> response = agentRegistryClient.CreateSkill(request);

            // Poll until the returned long-running operation is complete
            Operation<Skill, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Skill result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Skill, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateSkill(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Skill retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSkillAsync</summary>
        public async Task CreateSkillRequestObjectAsync()
        {
            // Snippet: CreateSkillAsync(CreateSkillRequest, CallSettings)
            // Additional: CreateSkillAsync(CreateSkillRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateSkillRequest request = new CreateSkillRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SkillId = "",
                Skill = new Skill(),
                RequestId = "",
            };
            // Make the request
            Operation<Skill, OperationMetadata> response = await agentRegistryClient.CreateSkillAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Skill, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Skill result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Skill, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateSkillAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Skill retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSkill</summary>
        public void CreateSkill()
        {
            // Snippet: CreateSkill(string, Skill, string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Skill skill = new Skill();
            string skillId = "";
            // Make the request
            Operation<Skill, OperationMetadata> response = agentRegistryClient.CreateSkill(parent, skill, skillId);

            // Poll until the returned long-running operation is complete
            Operation<Skill, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Skill result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Skill, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateSkill(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Skill retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSkillAsync</summary>
        public async Task CreateSkillAsync()
        {
            // Snippet: CreateSkillAsync(string, Skill, string, CallSettings)
            // Additional: CreateSkillAsync(string, Skill, string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Skill skill = new Skill();
            string skillId = "";
            // Make the request
            Operation<Skill, OperationMetadata> response = await agentRegistryClient.CreateSkillAsync(parent, skill, skillId);

            // Poll until the returned long-running operation is complete
            Operation<Skill, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Skill result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Skill, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateSkillAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Skill retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSkill</summary>
        public void CreateSkillResourceNames()
        {
            // Snippet: CreateSkill(LocationName, Skill, string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Skill skill = new Skill();
            string skillId = "";
            // Make the request
            Operation<Skill, OperationMetadata> response = agentRegistryClient.CreateSkill(parent, skill, skillId);

            // Poll until the returned long-running operation is complete
            Operation<Skill, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Skill result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Skill, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateSkill(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Skill retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSkillAsync</summary>
        public async Task CreateSkillResourceNamesAsync()
        {
            // Snippet: CreateSkillAsync(LocationName, Skill, string, CallSettings)
            // Additional: CreateSkillAsync(LocationName, Skill, string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Skill skill = new Skill();
            string skillId = "";
            // Make the request
            Operation<Skill, OperationMetadata> response = await agentRegistryClient.CreateSkillAsync(parent, skill, skillId);

            // Poll until the returned long-running operation is complete
            Operation<Skill, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Skill result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Skill, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateSkillAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Skill retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetSkill</summary>
        public void GetSkillRequestObject()
        {
            // Snippet: GetSkill(GetSkillRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetSkillRequest request = new GetSkillRequest
            {
                SkillName = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]"),
            };
            // Make the request
            Skill response = agentRegistryClient.GetSkill(request);
            // End snippet
        }

        /// <summary>Snippet for GetSkillAsync</summary>
        public async Task GetSkillRequestObjectAsync()
        {
            // Snippet: GetSkillAsync(GetSkillRequest, CallSettings)
            // Additional: GetSkillAsync(GetSkillRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetSkillRequest request = new GetSkillRequest
            {
                SkillName = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]"),
            };
            // Make the request
            Skill response = await agentRegistryClient.GetSkillAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSkill</summary>
        public void GetSkill()
        {
            // Snippet: GetSkill(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]";
            // Make the request
            Skill response = agentRegistryClient.GetSkill(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkillAsync</summary>
        public async Task GetSkillAsync()
        {
            // Snippet: GetSkillAsync(string, CallSettings)
            // Additional: GetSkillAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]";
            // Make the request
            Skill response = await agentRegistryClient.GetSkillAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkill</summary>
        public void GetSkillResourceNames()
        {
            // Snippet: GetSkill(SkillName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            SkillName name = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]");
            // Make the request
            Skill response = agentRegistryClient.GetSkill(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkillAsync</summary>
        public async Task GetSkillResourceNamesAsync()
        {
            // Snippet: GetSkillAsync(SkillName, CallSettings)
            // Additional: GetSkillAsync(SkillName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SkillName name = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]");
            // Make the request
            Skill response = await agentRegistryClient.GetSkillAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSkill</summary>
        public void UpdateSkillRequestObject()
        {
            // Snippet: UpdateSkill(UpdateSkillRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            UpdateSkillRequest request = new UpdateSkillRequest
            {
                Skill = new Skill(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<Skill, OperationMetadata> response = agentRegistryClient.UpdateSkill(request);

            // Poll until the returned long-running operation is complete
            Operation<Skill, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Skill result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Skill, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceUpdateSkill(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Skill retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSkillAsync</summary>
        public async Task UpdateSkillRequestObjectAsync()
        {
            // Snippet: UpdateSkillAsync(UpdateSkillRequest, CallSettings)
            // Additional: UpdateSkillAsync(UpdateSkillRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSkillRequest request = new UpdateSkillRequest
            {
                Skill = new Skill(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<Skill, OperationMetadata> response = await agentRegistryClient.UpdateSkillAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Skill, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Skill result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Skill, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceUpdateSkillAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Skill retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSkill</summary>
        public void UpdateSkill()
        {
            // Snippet: UpdateSkill(Skill, FieldMask, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            Skill skill = new Skill();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Skill, OperationMetadata> response = agentRegistryClient.UpdateSkill(skill, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Skill, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Skill result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Skill, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceUpdateSkill(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Skill retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSkillAsync</summary>
        public async Task UpdateSkillAsync()
        {
            // Snippet: UpdateSkillAsync(Skill, FieldMask, CallSettings)
            // Additional: UpdateSkillAsync(Skill, FieldMask, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            Skill skill = new Skill();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Skill, OperationMetadata> response = await agentRegistryClient.UpdateSkillAsync(skill, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Skill, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Skill result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Skill, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceUpdateSkillAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Skill retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSkill</summary>
        public void DeleteSkillRequestObject()
        {
            // Snippet: DeleteSkill(DeleteSkillRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            DeleteSkillRequest request = new DeleteSkillRequest
            {
                SkillName = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteSkill(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteSkill(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSkillAsync</summary>
        public async Task DeleteSkillRequestObjectAsync()
        {
            // Snippet: DeleteSkillAsync(DeleteSkillRequest, CallSettings)
            // Additional: DeleteSkillAsync(DeleteSkillRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSkillRequest request = new DeleteSkillRequest
            {
                SkillName = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteSkillAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteSkillAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSkill</summary>
        public void DeleteSkill()
        {
            // Snippet: DeleteSkill(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteSkill(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteSkill(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSkillAsync</summary>
        public async Task DeleteSkillAsync()
        {
            // Snippet: DeleteSkillAsync(string, CallSettings)
            // Additional: DeleteSkillAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteSkillAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteSkillAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSkill</summary>
        public void DeleteSkillResourceNames()
        {
            // Snippet: DeleteSkill(SkillName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            SkillName name = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteSkill(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteSkill(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSkillAsync</summary>
        public async Task DeleteSkillResourceNamesAsync()
        {
            // Snippet: DeleteSkillAsync(SkillName, CallSettings)
            // Additional: DeleteSkillAsync(SkillName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SkillName name = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteSkillAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteSkillAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSkills</summary>
        public void ListSkillsRequestObject()
        {
            // Snippet: ListSkills(ListSkillsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListSkillsRequest request = new ListSkillsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSkillsResponse, Skill> response = agentRegistryClient.ListSkills(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Skill item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkillsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Skill item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Skill> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Skill item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkillsAsync</summary>
        public async Task ListSkillsRequestObjectAsync()
        {
            // Snippet: ListSkillsAsync(ListSkillsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListSkillsRequest request = new ListSkillsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSkillsResponse, Skill> response = agentRegistryClient.ListSkillsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Skill item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkillsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Skill item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Skill> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Skill item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkills</summary>
        public void ListSkills()
        {
            // Snippet: ListSkills(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSkillsResponse, Skill> response = agentRegistryClient.ListSkills(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Skill item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkillsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Skill item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Skill> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Skill item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkillsAsync</summary>
        public async Task ListSkillsAsync()
        {
            // Snippet: ListSkillsAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSkillsResponse, Skill> response = agentRegistryClient.ListSkillsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Skill item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkillsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Skill item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Skill> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Skill item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkills</summary>
        public void ListSkillsResourceNames()
        {
            // Snippet: ListSkills(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSkillsResponse, Skill> response = agentRegistryClient.ListSkills(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Skill item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkillsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Skill item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Skill> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Skill item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkillsAsync</summary>
        public async Task ListSkillsResourceNamesAsync()
        {
            // Snippet: ListSkillsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSkillsResponse, Skill> response = agentRegistryClient.ListSkillsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Skill item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkillsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Skill item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Skill> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Skill item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchSkills</summary>
        public void SearchSkillsRequestObject()
        {
            // Snippet: SearchSkills(SearchSkillsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            SearchSkillsRequest request = new SearchSkillsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                SearchType = SearchType.Unspecified,
                SearchString = "",
            };
            // Make the request
            PagedEnumerable<SearchSkillsResponse, Skill> response = agentRegistryClient.SearchSkills(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Skill item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchSkillsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Skill item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Skill> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Skill item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchSkillsAsync</summary>
        public async Task SearchSkillsRequestObjectAsync()
        {
            // Snippet: SearchSkillsAsync(SearchSkillsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SearchSkillsRequest request = new SearchSkillsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                SearchType = SearchType.Unspecified,
                SearchString = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchSkillsResponse, Skill> response = agentRegistryClient.SearchSkillsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Skill item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchSkillsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Skill item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Skill> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Skill item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSkillRevision</summary>
        public void CreateSkillRevisionRequestObject()
        {
            // Snippet: CreateSkillRevision(CreateSkillRevisionRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            CreateSkillRevisionRequest request = new CreateSkillRevisionRequest
            {
                ParentAsSkillName = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]"),
                SkillRevision = new SkillRevision(),
                SkillRevisionId = "",
                RequestId = "",
            };
            // Make the request
            Operation<SkillRevision, OperationMetadata> response = agentRegistryClient.CreateSkillRevision(request);

            // Poll until the returned long-running operation is complete
            Operation<SkillRevision, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SkillRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SkillRevision, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateSkillRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SkillRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSkillRevisionAsync</summary>
        public async Task CreateSkillRevisionRequestObjectAsync()
        {
            // Snippet: CreateSkillRevisionAsync(CreateSkillRevisionRequest, CallSettings)
            // Additional: CreateSkillRevisionAsync(CreateSkillRevisionRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            CreateSkillRevisionRequest request = new CreateSkillRevisionRequest
            {
                ParentAsSkillName = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]"),
                SkillRevision = new SkillRevision(),
                SkillRevisionId = "",
                RequestId = "",
            };
            // Make the request
            Operation<SkillRevision, OperationMetadata> response = await agentRegistryClient.CreateSkillRevisionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SkillRevision, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SkillRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SkillRevision, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateSkillRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SkillRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSkillRevision</summary>
        public void CreateSkillRevision()
        {
            // Snippet: CreateSkillRevision(string, SkillRevision, string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]";
            SkillRevision skillRevision = new SkillRevision();
            string skillRevisionId = "";
            // Make the request
            Operation<SkillRevision, OperationMetadata> response = agentRegistryClient.CreateSkillRevision(parent, skillRevision, skillRevisionId);

            // Poll until the returned long-running operation is complete
            Operation<SkillRevision, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SkillRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SkillRevision, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateSkillRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SkillRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSkillRevisionAsync</summary>
        public async Task CreateSkillRevisionAsync()
        {
            // Snippet: CreateSkillRevisionAsync(string, SkillRevision, string, CallSettings)
            // Additional: CreateSkillRevisionAsync(string, SkillRevision, string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]";
            SkillRevision skillRevision = new SkillRevision();
            string skillRevisionId = "";
            // Make the request
            Operation<SkillRevision, OperationMetadata> response = await agentRegistryClient.CreateSkillRevisionAsync(parent, skillRevision, skillRevisionId);

            // Poll until the returned long-running operation is complete
            Operation<SkillRevision, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SkillRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SkillRevision, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateSkillRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SkillRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSkillRevision</summary>
        public void CreateSkillRevisionResourceNames()
        {
            // Snippet: CreateSkillRevision(SkillName, SkillRevision, string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            SkillName parent = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]");
            SkillRevision skillRevision = new SkillRevision();
            string skillRevisionId = "";
            // Make the request
            Operation<SkillRevision, OperationMetadata> response = agentRegistryClient.CreateSkillRevision(parent, skillRevision, skillRevisionId);

            // Poll until the returned long-running operation is complete
            Operation<SkillRevision, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SkillRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SkillRevision, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceCreateSkillRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SkillRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSkillRevisionAsync</summary>
        public async Task CreateSkillRevisionResourceNamesAsync()
        {
            // Snippet: CreateSkillRevisionAsync(SkillName, SkillRevision, string, CallSettings)
            // Additional: CreateSkillRevisionAsync(SkillName, SkillRevision, string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SkillName parent = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]");
            SkillRevision skillRevision = new SkillRevision();
            string skillRevisionId = "";
            // Make the request
            Operation<SkillRevision, OperationMetadata> response = await agentRegistryClient.CreateSkillRevisionAsync(parent, skillRevision, skillRevisionId);

            // Poll until the returned long-running operation is complete
            Operation<SkillRevision, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SkillRevision result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SkillRevision, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceCreateSkillRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SkillRevision retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetSkillRevision</summary>
        public void GetSkillRevisionRequestObject()
        {
            // Snippet: GetSkillRevision(GetSkillRevisionRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetSkillRevisionRequest request = new GetSkillRevisionRequest
            {
                SkillRevisionName = SkillRevisionName.FromProjectLocationSkillRevision("[PROJECT]", "[LOCATION]", "[SKILL]", "[REVISION]"),
            };
            // Make the request
            SkillRevision response = agentRegistryClient.GetSkillRevision(request);
            // End snippet
        }

        /// <summary>Snippet for GetSkillRevisionAsync</summary>
        public async Task GetSkillRevisionRequestObjectAsync()
        {
            // Snippet: GetSkillRevisionAsync(GetSkillRevisionRequest, CallSettings)
            // Additional: GetSkillRevisionAsync(GetSkillRevisionRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetSkillRevisionRequest request = new GetSkillRevisionRequest
            {
                SkillRevisionName = SkillRevisionName.FromProjectLocationSkillRevision("[PROJECT]", "[LOCATION]", "[SKILL]", "[REVISION]"),
            };
            // Make the request
            SkillRevision response = await agentRegistryClient.GetSkillRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSkillRevision</summary>
        public void GetSkillRevision()
        {
            // Snippet: GetSkillRevision(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]/revisions/[REVISION]";
            // Make the request
            SkillRevision response = agentRegistryClient.GetSkillRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkillRevisionAsync</summary>
        public async Task GetSkillRevisionAsync()
        {
            // Snippet: GetSkillRevisionAsync(string, CallSettings)
            // Additional: GetSkillRevisionAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]/revisions/[REVISION]";
            // Make the request
            SkillRevision response = await agentRegistryClient.GetSkillRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkillRevision</summary>
        public void GetSkillRevisionResourceNames()
        {
            // Snippet: GetSkillRevision(SkillRevisionName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            SkillRevisionName name = SkillRevisionName.FromProjectLocationSkillRevision("[PROJECT]", "[LOCATION]", "[SKILL]", "[REVISION]");
            // Make the request
            SkillRevision response = agentRegistryClient.GetSkillRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkillRevisionAsync</summary>
        public async Task GetSkillRevisionResourceNamesAsync()
        {
            // Snippet: GetSkillRevisionAsync(SkillRevisionName, CallSettings)
            // Additional: GetSkillRevisionAsync(SkillRevisionName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SkillRevisionName name = SkillRevisionName.FromProjectLocationSkillRevision("[PROJECT]", "[LOCATION]", "[SKILL]", "[REVISION]");
            // Make the request
            SkillRevision response = await agentRegistryClient.GetSkillRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSkillRevision</summary>
        public void DeleteSkillRevisionRequestObject()
        {
            // Snippet: DeleteSkillRevision(DeleteSkillRevisionRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            DeleteSkillRevisionRequest request = new DeleteSkillRevisionRequest
            {
                SkillRevisionName = SkillRevisionName.FromProjectLocationSkillRevision("[PROJECT]", "[LOCATION]", "[SKILL]", "[REVISION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteSkillRevision(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteSkillRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSkillRevisionAsync</summary>
        public async Task DeleteSkillRevisionRequestObjectAsync()
        {
            // Snippet: DeleteSkillRevisionAsync(DeleteSkillRevisionRequest, CallSettings)
            // Additional: DeleteSkillRevisionAsync(DeleteSkillRevisionRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSkillRevisionRequest request = new DeleteSkillRevisionRequest
            {
                SkillRevisionName = SkillRevisionName.FromProjectLocationSkillRevision("[PROJECT]", "[LOCATION]", "[SKILL]", "[REVISION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteSkillRevisionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteSkillRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSkillRevision</summary>
        public void DeleteSkillRevision()
        {
            // Snippet: DeleteSkillRevision(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]/revisions/[REVISION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteSkillRevision(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteSkillRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSkillRevisionAsync</summary>
        public async Task DeleteSkillRevisionAsync()
        {
            // Snippet: DeleteSkillRevisionAsync(string, CallSettings)
            // Additional: DeleteSkillRevisionAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]/revisions/[REVISION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteSkillRevisionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteSkillRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSkillRevision</summary>
        public void DeleteSkillRevisionResourceNames()
        {
            // Snippet: DeleteSkillRevision(SkillRevisionName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            SkillRevisionName name = SkillRevisionName.FromProjectLocationSkillRevision("[PROJECT]", "[LOCATION]", "[SKILL]", "[REVISION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = agentRegistryClient.DeleteSkillRevision(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceDeleteSkillRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSkillRevisionAsync</summary>
        public async Task DeleteSkillRevisionResourceNamesAsync()
        {
            // Snippet: DeleteSkillRevisionAsync(SkillRevisionName, CallSettings)
            // Additional: DeleteSkillRevisionAsync(SkillRevisionName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SkillRevisionName name = SkillRevisionName.FromProjectLocationSkillRevision("[PROJECT]", "[LOCATION]", "[SKILL]", "[REVISION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentRegistryClient.DeleteSkillRevisionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceDeleteSkillRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSkillRevisions</summary>
        public void ListSkillRevisionsRequestObject()
        {
            // Snippet: ListSkillRevisions(ListSkillRevisionsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListSkillRevisionsRequest request = new ListSkillRevisionsRequest
            {
                ParentAsSkillName = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]"),
            };
            // Make the request
            PagedEnumerable<ListSkillRevisionsResponse, SkillRevision> response = agentRegistryClient.ListSkillRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SkillRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkillRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkillRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkillRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkillRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkillRevisionsAsync</summary>
        public async Task ListSkillRevisionsRequestObjectAsync()
        {
            // Snippet: ListSkillRevisionsAsync(ListSkillRevisionsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListSkillRevisionsRequest request = new ListSkillRevisionsRequest
            {
                ParentAsSkillName = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSkillRevisionsResponse, SkillRevision> response = agentRegistryClient.ListSkillRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SkillRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkillRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkillRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkillRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkillRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkillRevisions</summary>
        public void ListSkillRevisions()
        {
            // Snippet: ListSkillRevisions(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]";
            // Make the request
            PagedEnumerable<ListSkillRevisionsResponse, SkillRevision> response = agentRegistryClient.ListSkillRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SkillRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkillRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkillRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkillRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkillRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkillRevisionsAsync</summary>
        public async Task ListSkillRevisionsAsync()
        {
            // Snippet: ListSkillRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/skills/[SKILL]";
            // Make the request
            PagedAsyncEnumerable<ListSkillRevisionsResponse, SkillRevision> response = agentRegistryClient.ListSkillRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SkillRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkillRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkillRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkillRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkillRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkillRevisions</summary>
        public void ListSkillRevisionsResourceNames()
        {
            // Snippet: ListSkillRevisions(SkillName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            SkillName parent = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]");
            // Make the request
            PagedEnumerable<ListSkillRevisionsResponse, SkillRevision> response = agentRegistryClient.ListSkillRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SkillRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkillRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkillRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkillRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkillRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkillRevisionsAsync</summary>
        public async Task ListSkillRevisionsResourceNamesAsync()
        {
            // Snippet: ListSkillRevisionsAsync(SkillName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SkillName parent = SkillName.FromProjectLocationSkill("[PROJECT]", "[LOCATION]", "[SKILL]");
            // Make the request
            PagedAsyncEnumerable<ListSkillRevisionsResponse, SkillRevision> response = agentRegistryClient.ListSkillRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SkillRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkillRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkillRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkillRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkillRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPublisher</summary>
        public void GetPublisherRequestObject()
        {
            // Snippet: GetPublisher(GetPublisherRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetPublisherRequest request = new GetPublisherRequest
            {
                PublisherName = PublisherName.FromProjectLocationPublisher("[PROJECT]", "[LOCATION]", "[PUBLISHER]"),
            };
            // Make the request
            Publisher response = agentRegistryClient.GetPublisher(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherAsync</summary>
        public async Task GetPublisherRequestObjectAsync()
        {
            // Snippet: GetPublisherAsync(GetPublisherRequest, CallSettings)
            // Additional: GetPublisherAsync(GetPublisherRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetPublisherRequest request = new GetPublisherRequest
            {
                PublisherName = PublisherName.FromProjectLocationPublisher("[PROJECT]", "[LOCATION]", "[PUBLISHER]"),
            };
            // Make the request
            Publisher response = await agentRegistryClient.GetPublisherAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublisher</summary>
        public void GetPublisher()
        {
            // Snippet: GetPublisher(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/publishers/[PUBLISHER]";
            // Make the request
            Publisher response = agentRegistryClient.GetPublisher(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherAsync</summary>
        public async Task GetPublisherAsync()
        {
            // Snippet: GetPublisherAsync(string, CallSettings)
            // Additional: GetPublisherAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/publishers/[PUBLISHER]";
            // Make the request
            Publisher response = await agentRegistryClient.GetPublisherAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublisher</summary>
        public void GetPublisherResourceNames()
        {
            // Snippet: GetPublisher(PublisherName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            PublisherName name = PublisherName.FromProjectLocationPublisher("[PROJECT]", "[LOCATION]", "[PUBLISHER]");
            // Make the request
            Publisher response = agentRegistryClient.GetPublisher(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherAsync</summary>
        public async Task GetPublisherResourceNamesAsync()
        {
            // Snippet: GetPublisherAsync(PublisherName, CallSettings)
            // Additional: GetPublisherAsync(PublisherName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            PublisherName name = PublisherName.FromProjectLocationPublisher("[PROJECT]", "[LOCATION]", "[PUBLISHER]");
            // Make the request
            Publisher response = await agentRegistryClient.GetPublisherAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPublishers</summary>
        public void ListPublishersRequestObject()
        {
            // Snippet: ListPublishers(ListPublishersRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListPublishersRequest request = new ListPublishersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListPublishersResponse, Publisher> response = agentRegistryClient.ListPublishers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Publisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Publisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Publisher> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Publisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublishersAsync</summary>
        public async Task ListPublishersRequestObjectAsync()
        {
            // Snippet: ListPublishersAsync(ListPublishersRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListPublishersRequest request = new ListPublishersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPublishersResponse, Publisher> response = agentRegistryClient.ListPublishersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Publisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Publisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Publisher> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Publisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublishers</summary>
        public void ListPublishers()
        {
            // Snippet: ListPublishers(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPublishersResponse, Publisher> response = agentRegistryClient.ListPublishers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Publisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Publisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Publisher> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Publisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublishersAsync</summary>
        public async Task ListPublishersAsync()
        {
            // Snippet: ListPublishersAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPublishersResponse, Publisher> response = agentRegistryClient.ListPublishersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Publisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Publisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Publisher> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Publisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublishers</summary>
        public void ListPublishersResourceNames()
        {
            // Snippet: ListPublishers(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPublishersResponse, Publisher> response = agentRegistryClient.ListPublishers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Publisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Publisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Publisher> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Publisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublishersAsync</summary>
        public async Task ListPublishersResourceNamesAsync()
        {
            // Snippet: ListPublishersAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPublishersResponse, Publisher> response = agentRegistryClient.ListPublishersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Publisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Publisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Publisher> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Publisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAiApplication</summary>
        public void GetAiApplicationRequestObject()
        {
            // Snippet: GetAiApplication(GetAiApplicationRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetAiApplicationRequest request = new GetAiApplicationRequest
            {
                AiApplicationName = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]"),
            };
            // Make the request
            AiApplication response = agentRegistryClient.GetAiApplication(request);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationAsync</summary>
        public async Task GetAiApplicationRequestObjectAsync()
        {
            // Snippet: GetAiApplicationAsync(GetAiApplicationRequest, CallSettings)
            // Additional: GetAiApplicationAsync(GetAiApplicationRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetAiApplicationRequest request = new GetAiApplicationRequest
            {
                AiApplicationName = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]"),
            };
            // Make the request
            AiApplication response = await agentRegistryClient.GetAiApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplication</summary>
        public void GetAiApplication()
        {
            // Snippet: GetAiApplication(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/aiApplications/[AI_APPLICATION]";
            // Make the request
            AiApplication response = agentRegistryClient.GetAiApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationAsync</summary>
        public async Task GetAiApplicationAsync()
        {
            // Snippet: GetAiApplicationAsync(string, CallSettings)
            // Additional: GetAiApplicationAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/aiApplications/[AI_APPLICATION]";
            // Make the request
            AiApplication response = await agentRegistryClient.GetAiApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplication</summary>
        public void GetAiApplicationResourceNames()
        {
            // Snippet: GetAiApplication(AiApplicationName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            AiApplicationName name = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]");
            // Make the request
            AiApplication response = agentRegistryClient.GetAiApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationAsync</summary>
        public async Task GetAiApplicationResourceNamesAsync()
        {
            // Snippet: GetAiApplicationAsync(AiApplicationName, CallSettings)
            // Additional: GetAiApplicationAsync(AiApplicationName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            AiApplicationName name = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]");
            // Make the request
            AiApplication response = await agentRegistryClient.GetAiApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAiApplications</summary>
        public void ListAiApplicationsRequestObject()
        {
            // Snippet: ListAiApplications(ListAiApplicationsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListAiApplicationsRequest request = new ListAiApplicationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAiApplicationsResponse, AiApplication> response = agentRegistryClient.ListAiApplications(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AiApplication item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AiApplication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AiApplication> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AiApplication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationsAsync</summary>
        public async Task ListAiApplicationsRequestObjectAsync()
        {
            // Snippet: ListAiApplicationsAsync(ListAiApplicationsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListAiApplicationsRequest request = new ListAiApplicationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationsResponse, AiApplication> response = agentRegistryClient.ListAiApplicationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AiApplication item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AiApplication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AiApplication> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AiApplication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplications</summary>
        public void ListAiApplications()
        {
            // Snippet: ListAiApplications(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAiApplicationsResponse, AiApplication> response = agentRegistryClient.ListAiApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AiApplication item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AiApplication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AiApplication> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AiApplication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationsAsync</summary>
        public async Task ListAiApplicationsAsync()
        {
            // Snippet: ListAiApplicationsAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationsResponse, AiApplication> response = agentRegistryClient.ListAiApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AiApplication item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AiApplication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AiApplication> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AiApplication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplications</summary>
        public void ListAiApplicationsResourceNames()
        {
            // Snippet: ListAiApplications(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAiApplicationsResponse, AiApplication> response = agentRegistryClient.ListAiApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AiApplication item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AiApplication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AiApplication> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AiApplication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationsAsync</summary>
        public async Task ListAiApplicationsResourceNamesAsync()
        {
            // Snippet: ListAiApplicationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationsResponse, AiApplication> response = agentRegistryClient.ListAiApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AiApplication item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AiApplication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AiApplication> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AiApplication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationAgent</summary>
        public void GetAiApplicationAgentRequestObject()
        {
            // Snippet: GetAiApplicationAgent(GetAiApplicationAgentRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetAiApplicationAgentRequest request = new GetAiApplicationAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            Agent response = agentRegistryClient.GetAiApplicationAgent(request);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationAgentAsync</summary>
        public async Task GetAiApplicationAgentRequestObjectAsync()
        {
            // Snippet: GetAiApplicationAgentAsync(GetAiApplicationAgentRequest, CallSettings)
            // Additional: GetAiApplicationAgentAsync(GetAiApplicationAgentRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetAiApplicationAgentRequest request = new GetAiApplicationAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            Agent response = await agentRegistryClient.GetAiApplicationAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationAgent</summary>
        public void GetAiApplicationAgent()
        {
            // Snippet: GetAiApplicationAgent(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            Agent response = agentRegistryClient.GetAiApplicationAgent(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationAgentAsync</summary>
        public async Task GetAiApplicationAgentAsync()
        {
            // Snippet: GetAiApplicationAgentAsync(string, CallSettings)
            // Additional: GetAiApplicationAgentAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            Agent response = await agentRegistryClient.GetAiApplicationAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationAgent</summary>
        public void GetAiApplicationAgentResourceNames()
        {
            // Snippet: GetAiApplicationAgent(AgentName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            Agent response = agentRegistryClient.GetAiApplicationAgent(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationAgentAsync</summary>
        public async Task GetAiApplicationAgentResourceNamesAsync()
        {
            // Snippet: GetAiApplicationAgentAsync(AgentName, CallSettings)
            // Additional: GetAiApplicationAgentAsync(AgentName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            Agent response = await agentRegistryClient.GetAiApplicationAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationAgents</summary>
        public void ListAiApplicationAgentsRequestObject()
        {
            // Snippet: ListAiApplicationAgents(ListAiApplicationAgentsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListAiApplicationAgentsRequest request = new ListAiApplicationAgentsRequest
            {
                ParentAsAiApplicationName = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]"),
            };
            // Make the request
            PagedEnumerable<ListAiApplicationAgentsResponse, Agent> response = agentRegistryClient.ListAiApplicationAgents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationAgentsAsync</summary>
        public async Task ListAiApplicationAgentsRequestObjectAsync()
        {
            // Snippet: ListAiApplicationAgentsAsync(ListAiApplicationAgentsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListAiApplicationAgentsRequest request = new ListAiApplicationAgentsRequest
            {
                ParentAsAiApplicationName = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationAgentsResponse, Agent> response = agentRegistryClient.ListAiApplicationAgentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationAgents</summary>
        public void ListAiApplicationAgents()
        {
            // Snippet: ListAiApplicationAgents(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/aiApplications/[AI_APPLICATION]";
            // Make the request
            PagedEnumerable<ListAiApplicationAgentsResponse, Agent> response = agentRegistryClient.ListAiApplicationAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationAgentsAsync</summary>
        public async Task ListAiApplicationAgentsAsync()
        {
            // Snippet: ListAiApplicationAgentsAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/aiApplications/[AI_APPLICATION]";
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationAgentsResponse, Agent> response = agentRegistryClient.ListAiApplicationAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationAgents</summary>
        public void ListAiApplicationAgentsResourceNames()
        {
            // Snippet: ListAiApplicationAgents(AiApplicationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            AiApplicationName parent = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]");
            // Make the request
            PagedEnumerable<ListAiApplicationAgentsResponse, Agent> response = agentRegistryClient.ListAiApplicationAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationAgentsAsync</summary>
        public async Task ListAiApplicationAgentsResourceNamesAsync()
        {
            // Snippet: ListAiApplicationAgentsAsync(AiApplicationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            AiApplicationName parent = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]");
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationAgentsResponse, Agent> response = agentRegistryClient.ListAiApplicationAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationMcpServer</summary>
        public void GetAiApplicationMcpServerRequestObject()
        {
            // Snippet: GetAiApplicationMcpServer(GetAiApplicationMcpServerRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetAiApplicationMcpServerRequest request = new GetAiApplicationMcpServerRequest
            {
                McpServerName = McpServerName.FromProjectLocationMcpServer("[PROJECT]", "[LOCATION]", "[MCP_SERVER]"),
            };
            // Make the request
            McpServer response = agentRegistryClient.GetAiApplicationMcpServer(request);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationMcpServerAsync</summary>
        public async Task GetAiApplicationMcpServerRequestObjectAsync()
        {
            // Snippet: GetAiApplicationMcpServerAsync(GetAiApplicationMcpServerRequest, CallSettings)
            // Additional: GetAiApplicationMcpServerAsync(GetAiApplicationMcpServerRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetAiApplicationMcpServerRequest request = new GetAiApplicationMcpServerRequest
            {
                McpServerName = McpServerName.FromProjectLocationMcpServer("[PROJECT]", "[LOCATION]", "[MCP_SERVER]"),
            };
            // Make the request
            McpServer response = await agentRegistryClient.GetAiApplicationMcpServerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationMcpServer</summary>
        public void GetAiApplicationMcpServer()
        {
            // Snippet: GetAiApplicationMcpServer(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mcpServers/[MCP_SERVER]";
            // Make the request
            McpServer response = agentRegistryClient.GetAiApplicationMcpServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationMcpServerAsync</summary>
        public async Task GetAiApplicationMcpServerAsync()
        {
            // Snippet: GetAiApplicationMcpServerAsync(string, CallSettings)
            // Additional: GetAiApplicationMcpServerAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mcpServers/[MCP_SERVER]";
            // Make the request
            McpServer response = await agentRegistryClient.GetAiApplicationMcpServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationMcpServer</summary>
        public void GetAiApplicationMcpServerResourceNames()
        {
            // Snippet: GetAiApplicationMcpServer(McpServerName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            McpServerName name = McpServerName.FromProjectLocationMcpServer("[PROJECT]", "[LOCATION]", "[MCP_SERVER]");
            // Make the request
            McpServer response = agentRegistryClient.GetAiApplicationMcpServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationMcpServerAsync</summary>
        public async Task GetAiApplicationMcpServerResourceNamesAsync()
        {
            // Snippet: GetAiApplicationMcpServerAsync(McpServerName, CallSettings)
            // Additional: GetAiApplicationMcpServerAsync(McpServerName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            McpServerName name = McpServerName.FromProjectLocationMcpServer("[PROJECT]", "[LOCATION]", "[MCP_SERVER]");
            // Make the request
            McpServer response = await agentRegistryClient.GetAiApplicationMcpServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationMcpServers</summary>
        public void ListAiApplicationMcpServersRequestObject()
        {
            // Snippet: ListAiApplicationMcpServers(ListAiApplicationMcpServersRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListAiApplicationMcpServersRequest request = new ListAiApplicationMcpServersRequest
            {
                ParentAsAiApplicationName = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]"),
            };
            // Make the request
            PagedEnumerable<ListAiApplicationMcpServersResponse, McpServer> response = agentRegistryClient.ListAiApplicationMcpServers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationMcpServersAsync</summary>
        public async Task ListAiApplicationMcpServersRequestObjectAsync()
        {
            // Snippet: ListAiApplicationMcpServersAsync(ListAiApplicationMcpServersRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListAiApplicationMcpServersRequest request = new ListAiApplicationMcpServersRequest
            {
                ParentAsAiApplicationName = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationMcpServersResponse, McpServer> response = agentRegistryClient.ListAiApplicationMcpServersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationMcpServers</summary>
        public void ListAiApplicationMcpServers()
        {
            // Snippet: ListAiApplicationMcpServers(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/aiApplications/[AI_APPLICATION]";
            // Make the request
            PagedEnumerable<ListAiApplicationMcpServersResponse, McpServer> response = agentRegistryClient.ListAiApplicationMcpServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationMcpServersAsync</summary>
        public async Task ListAiApplicationMcpServersAsync()
        {
            // Snippet: ListAiApplicationMcpServersAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/aiApplications/[AI_APPLICATION]";
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationMcpServersResponse, McpServer> response = agentRegistryClient.ListAiApplicationMcpServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationMcpServers</summary>
        public void ListAiApplicationMcpServersResourceNames()
        {
            // Snippet: ListAiApplicationMcpServers(AiApplicationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            AiApplicationName parent = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]");
            // Make the request
            PagedEnumerable<ListAiApplicationMcpServersResponse, McpServer> response = agentRegistryClient.ListAiApplicationMcpServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationMcpServersAsync</summary>
        public async Task ListAiApplicationMcpServersResourceNamesAsync()
        {
            // Snippet: ListAiApplicationMcpServersAsync(AiApplicationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            AiApplicationName parent = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]");
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationMcpServersResponse, McpServer> response = agentRegistryClient.ListAiApplicationMcpServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (McpServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationMcpServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFinding</summary>
        public void GetFindingRequestObject()
        {
            // Snippet: GetFinding(GetFindingRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetFindingRequest request = new GetFindingRequest
            {
                FindingName = FindingName.FromProjectLocationFinding("[PROJECT]", "[LOCATION]", "[FINDING]"),
            };
            // Make the request
            Finding response = agentRegistryClient.GetFinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetFindingAsync</summary>
        public async Task GetFindingRequestObjectAsync()
        {
            // Snippet: GetFindingAsync(GetFindingRequest, CallSettings)
            // Additional: GetFindingAsync(GetFindingRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetFindingRequest request = new GetFindingRequest
            {
                FindingName = FindingName.FromProjectLocationFinding("[PROJECT]", "[LOCATION]", "[FINDING]"),
            };
            // Make the request
            Finding response = await agentRegistryClient.GetFindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFinding</summary>
        public void GetFinding()
        {
            // Snippet: GetFinding(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/findings/[FINDING]";
            // Make the request
            Finding response = agentRegistryClient.GetFinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetFindingAsync</summary>
        public async Task GetFindingAsync()
        {
            // Snippet: GetFindingAsync(string, CallSettings)
            // Additional: GetFindingAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/findings/[FINDING]";
            // Make the request
            Finding response = await agentRegistryClient.GetFindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFinding</summary>
        public void GetFindingResourceNames()
        {
            // Snippet: GetFinding(FindingName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            FindingName name = FindingName.FromProjectLocationFinding("[PROJECT]", "[LOCATION]", "[FINDING]");
            // Make the request
            Finding response = agentRegistryClient.GetFinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetFindingAsync</summary>
        public async Task GetFindingResourceNamesAsync()
        {
            // Snippet: GetFindingAsync(FindingName, CallSettings)
            // Additional: GetFindingAsync(FindingName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            FindingName name = FindingName.FromProjectLocationFinding("[PROJECT]", "[LOCATION]", "[FINDING]");
            // Make the request
            Finding response = await agentRegistryClient.GetFindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public void ListFindingsRequestObject()
        {
            // Snippet: ListFindings(ListFindingsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListFindingsRequest request = new ListFindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFindingsResponse, Finding> response = agentRegistryClient.ListFindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Finding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsAsync</summary>
        public async Task ListFindingsRequestObjectAsync()
        {
            // Snippet: ListFindingsAsync(ListFindingsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListFindingsRequest request = new ListFindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFindingsResponse, Finding> response = agentRegistryClient.ListFindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Finding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public void ListFindings()
        {
            // Snippet: ListFindings(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFindingsResponse, Finding> response = agentRegistryClient.ListFindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Finding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsAsync</summary>
        public async Task ListFindingsAsync()
        {
            // Snippet: ListFindingsAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFindingsResponse, Finding> response = agentRegistryClient.ListFindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Finding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public void ListFindingsResourceNames()
        {
            // Snippet: ListFindings(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFindingsResponse, Finding> response = agentRegistryClient.ListFindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Finding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsAsync</summary>
        public async Task ListFindingsResourceNamesAsync()
        {
            // Snippet: ListFindingsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFindingsResponse, Finding> response = agentRegistryClient.ListFindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Finding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationEndpoint</summary>
        public void GetAiApplicationEndpointRequestObject()
        {
            // Snippet: GetAiApplicationEndpoint(GetAiApplicationEndpointRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetAiApplicationEndpointRequest request = new GetAiApplicationEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            // Make the request
            Endpoint response = agentRegistryClient.GetAiApplicationEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationEndpointAsync</summary>
        public async Task GetAiApplicationEndpointRequestObjectAsync()
        {
            // Snippet: GetAiApplicationEndpointAsync(GetAiApplicationEndpointRequest, CallSettings)
            // Additional: GetAiApplicationEndpointAsync(GetAiApplicationEndpointRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetAiApplicationEndpointRequest request = new GetAiApplicationEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            // Make the request
            Endpoint response = await agentRegistryClient.GetAiApplicationEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationEndpoint</summary>
        public void GetAiApplicationEndpoint()
        {
            // Snippet: GetAiApplicationEndpoint(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Endpoint response = agentRegistryClient.GetAiApplicationEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationEndpointAsync</summary>
        public async Task GetAiApplicationEndpointAsync()
        {
            // Snippet: GetAiApplicationEndpointAsync(string, CallSettings)
            // Additional: GetAiApplicationEndpointAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            // Make the request
            Endpoint response = await agentRegistryClient.GetAiApplicationEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationEndpoint</summary>
        public void GetAiApplicationEndpointResourceNames()
        {
            // Snippet: GetAiApplicationEndpoint(EndpointName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Endpoint response = agentRegistryClient.GetAiApplicationEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetAiApplicationEndpointAsync</summary>
        public async Task GetAiApplicationEndpointResourceNamesAsync()
        {
            // Snippet: GetAiApplicationEndpointAsync(EndpointName, CallSettings)
            // Additional: GetAiApplicationEndpointAsync(EndpointName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            // Make the request
            Endpoint response = await agentRegistryClient.GetAiApplicationEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationEndpoints</summary>
        public void ListAiApplicationEndpointsRequestObject()
        {
            // Snippet: ListAiApplicationEndpoints(ListAiApplicationEndpointsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            ListAiApplicationEndpointsRequest request = new ListAiApplicationEndpointsRequest
            {
                ParentAsAiApplicationName = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]"),
            };
            // Make the request
            PagedEnumerable<ListAiApplicationEndpointsResponse, Endpoint> response = agentRegistryClient.ListAiApplicationEndpoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationEndpointsAsync</summary>
        public async Task ListAiApplicationEndpointsRequestObjectAsync()
        {
            // Snippet: ListAiApplicationEndpointsAsync(ListAiApplicationEndpointsRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListAiApplicationEndpointsRequest request = new ListAiApplicationEndpointsRequest
            {
                ParentAsAiApplicationName = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationEndpointsResponse, Endpoint> response = agentRegistryClient.ListAiApplicationEndpointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationEndpoints</summary>
        public void ListAiApplicationEndpoints()
        {
            // Snippet: ListAiApplicationEndpoints(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/aiApplications/[AI_APPLICATION]";
            // Make the request
            PagedEnumerable<ListAiApplicationEndpointsResponse, Endpoint> response = agentRegistryClient.ListAiApplicationEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationEndpointsAsync</summary>
        public async Task ListAiApplicationEndpointsAsync()
        {
            // Snippet: ListAiApplicationEndpointsAsync(string, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/aiApplications/[AI_APPLICATION]";
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationEndpointsResponse, Endpoint> response = agentRegistryClient.ListAiApplicationEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationEndpoints</summary>
        public void ListAiApplicationEndpointsResourceNames()
        {
            // Snippet: ListAiApplicationEndpoints(AiApplicationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            AiApplicationName parent = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]");
            // Make the request
            PagedEnumerable<ListAiApplicationEndpointsResponse, Endpoint> response = agentRegistryClient.ListAiApplicationEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAiApplicationEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAiApplicationEndpointsAsync</summary>
        public async Task ListAiApplicationEndpointsResourceNamesAsync()
        {
            // Snippet: ListAiApplicationEndpointsAsync(AiApplicationName, string, int?, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            AiApplicationName parent = AiApplicationName.FromProjectLocationAiApplication("[PROJECT]", "[LOCATION]", "[AI_APPLICATION]");
            // Make the request
            PagedAsyncEnumerable<ListAiApplicationEndpointsResponse, Endpoint> response = agentRegistryClient.ListAiApplicationEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAiApplicationEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSkillEncryptionSpec</summary>
        public void GetSkillEncryptionSpecRequestObject()
        {
            // Snippet: GetSkillEncryptionSpec(GetSkillEncryptionSpecRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            GetSkillEncryptionSpecRequest request = new GetSkillEncryptionSpecRequest
            {
                SkillEncryptionSpecName = SkillEncryptionSpecName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            SkillEncryptionSpec response = agentRegistryClient.GetSkillEncryptionSpec(request);
            // End snippet
        }

        /// <summary>Snippet for GetSkillEncryptionSpecAsync</summary>
        public async Task GetSkillEncryptionSpecRequestObjectAsync()
        {
            // Snippet: GetSkillEncryptionSpecAsync(GetSkillEncryptionSpecRequest, CallSettings)
            // Additional: GetSkillEncryptionSpecAsync(GetSkillEncryptionSpecRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetSkillEncryptionSpecRequest request = new GetSkillEncryptionSpecRequest
            {
                SkillEncryptionSpecName = SkillEncryptionSpecName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            SkillEncryptionSpec response = await agentRegistryClient.GetSkillEncryptionSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSkillEncryptionSpec</summary>
        public void GetSkillEncryptionSpec()
        {
            // Snippet: GetSkillEncryptionSpec(string, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skillEncryptionSpec";
            // Make the request
            SkillEncryptionSpec response = agentRegistryClient.GetSkillEncryptionSpec(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkillEncryptionSpecAsync</summary>
        public async Task GetSkillEncryptionSpecAsync()
        {
            // Snippet: GetSkillEncryptionSpecAsync(string, CallSettings)
            // Additional: GetSkillEncryptionSpecAsync(string, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skillEncryptionSpec";
            // Make the request
            SkillEncryptionSpec response = await agentRegistryClient.GetSkillEncryptionSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkillEncryptionSpec</summary>
        public void GetSkillEncryptionSpecResourceNames()
        {
            // Snippet: GetSkillEncryptionSpec(SkillEncryptionSpecName, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            SkillEncryptionSpecName name = SkillEncryptionSpecName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            SkillEncryptionSpec response = agentRegistryClient.GetSkillEncryptionSpec(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkillEncryptionSpecAsync</summary>
        public async Task GetSkillEncryptionSpecResourceNamesAsync()
        {
            // Snippet: GetSkillEncryptionSpecAsync(SkillEncryptionSpecName, CallSettings)
            // Additional: GetSkillEncryptionSpecAsync(SkillEncryptionSpecName, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SkillEncryptionSpecName name = SkillEncryptionSpecName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            SkillEncryptionSpec response = await agentRegistryClient.GetSkillEncryptionSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSkillEncryptionSpec</summary>
        public void UpdateSkillEncryptionSpecRequestObject()
        {
            // Snippet: UpdateSkillEncryptionSpec(UpdateSkillEncryptionSpecRequest, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            UpdateSkillEncryptionSpecRequest request = new UpdateSkillEncryptionSpecRequest
            {
                SkillEncryptionSpec = new SkillEncryptionSpec(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<SkillEncryptionSpec, OperationMetadata> response = agentRegistryClient.UpdateSkillEncryptionSpec(request);

            // Poll until the returned long-running operation is complete
            Operation<SkillEncryptionSpec, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SkillEncryptionSpec result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SkillEncryptionSpec, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceUpdateSkillEncryptionSpec(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SkillEncryptionSpec retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSkillEncryptionSpecAsync</summary>
        public async Task UpdateSkillEncryptionSpecRequestObjectAsync()
        {
            // Snippet: UpdateSkillEncryptionSpecAsync(UpdateSkillEncryptionSpecRequest, CallSettings)
            // Additional: UpdateSkillEncryptionSpecAsync(UpdateSkillEncryptionSpecRequest, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSkillEncryptionSpecRequest request = new UpdateSkillEncryptionSpecRequest
            {
                SkillEncryptionSpec = new SkillEncryptionSpec(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<SkillEncryptionSpec, OperationMetadata> response = await agentRegistryClient.UpdateSkillEncryptionSpecAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SkillEncryptionSpec, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SkillEncryptionSpec result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SkillEncryptionSpec, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceUpdateSkillEncryptionSpecAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SkillEncryptionSpec retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSkillEncryptionSpec</summary>
        public void UpdateSkillEncryptionSpec()
        {
            // Snippet: UpdateSkillEncryptionSpec(SkillEncryptionSpec, FieldMask, CallSettings)
            // Create client
            AgentRegistryClient agentRegistryClient = AgentRegistryClient.Create();
            // Initialize request argument(s)
            SkillEncryptionSpec skillEncryptionSpec = new SkillEncryptionSpec();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<SkillEncryptionSpec, OperationMetadata> response = agentRegistryClient.UpdateSkillEncryptionSpec(skillEncryptionSpec, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<SkillEncryptionSpec, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SkillEncryptionSpec result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SkillEncryptionSpec, OperationMetadata> retrievedResponse = agentRegistryClient.PollOnceUpdateSkillEncryptionSpec(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SkillEncryptionSpec retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSkillEncryptionSpecAsync</summary>
        public async Task UpdateSkillEncryptionSpecAsync()
        {
            // Snippet: UpdateSkillEncryptionSpecAsync(SkillEncryptionSpec, FieldMask, CallSettings)
            // Additional: UpdateSkillEncryptionSpecAsync(SkillEncryptionSpec, FieldMask, CancellationToken)
            // Create client
            AgentRegistryClient agentRegistryClient = await AgentRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SkillEncryptionSpec skillEncryptionSpec = new SkillEncryptionSpec();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<SkillEncryptionSpec, OperationMetadata> response = await agentRegistryClient.UpdateSkillEncryptionSpecAsync(skillEncryptionSpec, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<SkillEncryptionSpec, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SkillEncryptionSpec result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SkillEncryptionSpec, OperationMetadata> retrievedResponse = await agentRegistryClient.PollOnceUpdateSkillEncryptionSpecAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SkillEncryptionSpec retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
