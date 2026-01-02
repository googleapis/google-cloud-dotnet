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
    using Google.Cloud.ApiRegistry.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudApiRegistryClientSnippets
    {
        /// <summary>Snippet for GetMcpServer</summary>
        public void GetMcpServerRequestObject()
        {
            // Snippet: GetMcpServer(GetMcpServerRequest, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            GetMcpServerRequest request = new GetMcpServerRequest
            {
                McpServerName = McpServerName.FromProjectLocationApiNamespaceMcpServer("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]"),
            };
            // Make the request
            McpServer response = cloudApiRegistryClient.GetMcpServer(request);
            // End snippet
        }

        /// <summary>Snippet for GetMcpServerAsync</summary>
        public async Task GetMcpServerRequestObjectAsync()
        {
            // Snippet: GetMcpServerAsync(GetMcpServerRequest, CallSettings)
            // Additional: GetMcpServerAsync(GetMcpServerRequest, CancellationToken)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetMcpServerRequest request = new GetMcpServerRequest
            {
                McpServerName = McpServerName.FromProjectLocationApiNamespaceMcpServer("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]"),
            };
            // Make the request
            McpServer response = await cloudApiRegistryClient.GetMcpServerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMcpServer</summary>
        public void GetMcpServer()
        {
            // Snippet: GetMcpServer(string, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apiNamespaces/[API_NAMESPACE]/mcpServers/[MCP_SERVER]";
            // Make the request
            McpServer response = cloudApiRegistryClient.GetMcpServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetMcpServerAsync</summary>
        public async Task GetMcpServerAsync()
        {
            // Snippet: GetMcpServerAsync(string, CallSettings)
            // Additional: GetMcpServerAsync(string, CancellationToken)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apiNamespaces/[API_NAMESPACE]/mcpServers/[MCP_SERVER]";
            // Make the request
            McpServer response = await cloudApiRegistryClient.GetMcpServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMcpServer</summary>
        public void GetMcpServerResourceNames()
        {
            // Snippet: GetMcpServer(McpServerName, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            McpServerName name = McpServerName.FromProjectLocationApiNamespaceMcpServer("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]");
            // Make the request
            McpServer response = cloudApiRegistryClient.GetMcpServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetMcpServerAsync</summary>
        public async Task GetMcpServerResourceNamesAsync()
        {
            // Snippet: GetMcpServerAsync(McpServerName, CallSettings)
            // Additional: GetMcpServerAsync(McpServerName, CancellationToken)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            McpServerName name = McpServerName.FromProjectLocationApiNamespaceMcpServer("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]");
            // Make the request
            McpServer response = await cloudApiRegistryClient.GetMcpServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMcpServers</summary>
        public void ListMcpServersRequestObject()
        {
            // Snippet: ListMcpServers(ListMcpServersRequest, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            ListMcpServersRequest request = new ListMcpServersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListMcpServersResponse, McpServer> response = cloudApiRegistryClient.ListMcpServers(request);

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
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListMcpServersRequest request = new ListMcpServersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMcpServersResponse, McpServer> response = cloudApiRegistryClient.ListMcpServersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((McpServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMcpServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMcpServersResponse, McpServer> response = cloudApiRegistryClient.ListMcpServers(parent);

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
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMcpServersResponse, McpServer> response = cloudApiRegistryClient.ListMcpServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((McpServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMcpServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMcpServersResponse, McpServer> response = cloudApiRegistryClient.ListMcpServers(parent);

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
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMcpServersResponse, McpServer> response = cloudApiRegistryClient.ListMcpServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((McpServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMcpServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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

        /// <summary>Snippet for GetMcpTool</summary>
        public void GetMcpToolRequestObject()
        {
            // Snippet: GetMcpTool(GetMcpToolRequest, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            GetMcpToolRequest request = new GetMcpToolRequest
            {
                McpToolName = McpToolName.FromProjectLocationApiNamespaceMcpServerMcpTool("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]", "[MCP_TOOL]"),
            };
            // Make the request
            McpTool response = cloudApiRegistryClient.GetMcpTool(request);
            // End snippet
        }

        /// <summary>Snippet for GetMcpToolAsync</summary>
        public async Task GetMcpToolRequestObjectAsync()
        {
            // Snippet: GetMcpToolAsync(GetMcpToolRequest, CallSettings)
            // Additional: GetMcpToolAsync(GetMcpToolRequest, CancellationToken)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetMcpToolRequest request = new GetMcpToolRequest
            {
                McpToolName = McpToolName.FromProjectLocationApiNamespaceMcpServerMcpTool("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]", "[MCP_TOOL]"),
            };
            // Make the request
            McpTool response = await cloudApiRegistryClient.GetMcpToolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMcpTool</summary>
        public void GetMcpTool()
        {
            // Snippet: GetMcpTool(string, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apiNamespaces/[API_NAMESPACE]/mcpServers/[MCP_SERVER]/mcpTools/[MCP_TOOL]";
            // Make the request
            McpTool response = cloudApiRegistryClient.GetMcpTool(name);
            // End snippet
        }

        /// <summary>Snippet for GetMcpToolAsync</summary>
        public async Task GetMcpToolAsync()
        {
            // Snippet: GetMcpToolAsync(string, CallSettings)
            // Additional: GetMcpToolAsync(string, CancellationToken)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apiNamespaces/[API_NAMESPACE]/mcpServers/[MCP_SERVER]/mcpTools/[MCP_TOOL]";
            // Make the request
            McpTool response = await cloudApiRegistryClient.GetMcpToolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMcpTool</summary>
        public void GetMcpToolResourceNames()
        {
            // Snippet: GetMcpTool(McpToolName, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            McpToolName name = McpToolName.FromProjectLocationApiNamespaceMcpServerMcpTool("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]", "[MCP_TOOL]");
            // Make the request
            McpTool response = cloudApiRegistryClient.GetMcpTool(name);
            // End snippet
        }

        /// <summary>Snippet for GetMcpToolAsync</summary>
        public async Task GetMcpToolResourceNamesAsync()
        {
            // Snippet: GetMcpToolAsync(McpToolName, CallSettings)
            // Additional: GetMcpToolAsync(McpToolName, CancellationToken)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            McpToolName name = McpToolName.FromProjectLocationApiNamespaceMcpServerMcpTool("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]", "[MCP_TOOL]");
            // Make the request
            McpTool response = await cloudApiRegistryClient.GetMcpToolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMcpTools</summary>
        public void ListMcpToolsRequestObject()
        {
            // Snippet: ListMcpTools(ListMcpToolsRequest, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            ListMcpToolsRequest request = new ListMcpToolsRequest
            {
                ParentAsMcpServerName = McpServerName.FromProjectLocationApiNamespaceMcpServer("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListMcpToolsResponse, McpTool> response = cloudApiRegistryClient.ListMcpTools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpTool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMcpToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpTool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpTool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpTool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMcpToolsAsync</summary>
        public async Task ListMcpToolsRequestObjectAsync()
        {
            // Snippet: ListMcpToolsAsync(ListMcpToolsRequest, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            ListMcpToolsRequest request = new ListMcpToolsRequest
            {
                ParentAsMcpServerName = McpServerName.FromProjectLocationApiNamespaceMcpServer("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMcpToolsResponse, McpTool> response = cloudApiRegistryClient.ListMcpToolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((McpTool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMcpToolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpTool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpTool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpTool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMcpTools</summary>
        public void ListMcpTools()
        {
            // Snippet: ListMcpTools(string, string, int?, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apiNamespaces/[API_NAMESPACE]/mcpServers/[MCP_SERVER]";
            // Make the request
            PagedEnumerable<ListMcpToolsResponse, McpTool> response = cloudApiRegistryClient.ListMcpTools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpTool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMcpToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpTool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpTool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpTool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMcpToolsAsync</summary>
        public async Task ListMcpToolsAsync()
        {
            // Snippet: ListMcpToolsAsync(string, string, int?, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apiNamespaces/[API_NAMESPACE]/mcpServers/[MCP_SERVER]";
            // Make the request
            PagedAsyncEnumerable<ListMcpToolsResponse, McpTool> response = cloudApiRegistryClient.ListMcpToolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((McpTool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMcpToolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpTool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpTool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpTool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMcpTools</summary>
        public void ListMcpToolsResourceNames()
        {
            // Snippet: ListMcpTools(McpServerName, string, int?, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = CloudApiRegistryClient.Create();
            // Initialize request argument(s)
            McpServerName parent = McpServerName.FromProjectLocationApiNamespaceMcpServer("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]");
            // Make the request
            PagedEnumerable<ListMcpToolsResponse, McpTool> response = cloudApiRegistryClient.ListMcpTools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (McpTool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMcpToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpTool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpTool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpTool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMcpToolsAsync</summary>
        public async Task ListMcpToolsResourceNamesAsync()
        {
            // Snippet: ListMcpToolsAsync(McpServerName, string, int?, CallSettings)
            // Create client
            CloudApiRegistryClient cloudApiRegistryClient = await CloudApiRegistryClient.CreateAsync();
            // Initialize request argument(s)
            McpServerName parent = McpServerName.FromProjectLocationApiNamespaceMcpServer("[PROJECT]", "[LOCATION]", "[API_NAMESPACE]", "[MCP_SERVER]");
            // Make the request
            PagedAsyncEnumerable<ListMcpToolsResponse, McpTool> response = cloudApiRegistryClient.ListMcpToolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((McpTool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMcpToolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (McpTool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<McpTool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (McpTool item in singlePage)
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
