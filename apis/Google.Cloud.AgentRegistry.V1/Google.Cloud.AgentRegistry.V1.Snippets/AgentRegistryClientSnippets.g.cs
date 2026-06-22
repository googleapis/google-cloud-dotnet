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
    }
}
