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
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedToolsClientSnippets
    {
        /// <summary>Snippet for CreateTool</summary>
        public void CreateToolRequestObject()
        {
            // Snippet: CreateTool(CreateToolRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            CreateToolRequest request = new CreateToolRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Tool = new Tool(),
            };
            // Make the request
            Tool response = toolsClient.CreateTool(request);
            // End snippet
        }

        /// <summary>Snippet for CreateToolAsync</summary>
        public async Task CreateToolRequestObjectAsync()
        {
            // Snippet: CreateToolAsync(CreateToolRequest, CallSettings)
            // Additional: CreateToolAsync(CreateToolRequest, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            CreateToolRequest request = new CreateToolRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Tool = new Tool(),
            };
            // Make the request
            Tool response = await toolsClient.CreateToolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTool</summary>
        public void CreateTool()
        {
            // Snippet: CreateTool(string, Tool, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            Tool tool = new Tool();
            // Make the request
            Tool response = toolsClient.CreateTool(parent, tool);
            // End snippet
        }

        /// <summary>Snippet for CreateToolAsync</summary>
        public async Task CreateToolAsync()
        {
            // Snippet: CreateToolAsync(string, Tool, CallSettings)
            // Additional: CreateToolAsync(string, Tool, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            Tool tool = new Tool();
            // Make the request
            Tool response = await toolsClient.CreateToolAsync(parent, tool);
            // End snippet
        }

        /// <summary>Snippet for CreateTool</summary>
        public void CreateToolResourceNames()
        {
            // Snippet: CreateTool(AgentName, Tool, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            Tool tool = new Tool();
            // Make the request
            Tool response = toolsClient.CreateTool(parent, tool);
            // End snippet
        }

        /// <summary>Snippet for CreateToolAsync</summary>
        public async Task CreateToolResourceNamesAsync()
        {
            // Snippet: CreateToolAsync(AgentName, Tool, CallSettings)
            // Additional: CreateToolAsync(AgentName, Tool, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            Tool tool = new Tool();
            // Make the request
            Tool response = await toolsClient.CreateToolAsync(parent, tool);
            // End snippet
        }

        /// <summary>Snippet for ListTools</summary>
        public void ListToolsRequestObject()
        {
            // Snippet: ListTools(ListToolsRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            ListToolsRequest request = new ListToolsRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            PagedEnumerable<ListToolsResponse, Tool> response = toolsClient.ListTools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolsAsync</summary>
        public async Task ListToolsRequestObjectAsync()
        {
            // Snippet: ListToolsAsync(ListToolsRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            ListToolsRequest request = new ListToolsRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListToolsResponse, Tool> response = toolsClient.ListToolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTools</summary>
        public void ListTools()
        {
            // Snippet: ListTools(string, string, int?, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedEnumerable<ListToolsResponse, Tool> response = toolsClient.ListTools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolsAsync</summary>
        public async Task ListToolsAsync()
        {
            // Snippet: ListToolsAsync(string, string, int?, CallSettings)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedAsyncEnumerable<ListToolsResponse, Tool> response = toolsClient.ListToolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTools</summary>
        public void ListToolsResourceNames()
        {
            // Snippet: ListTools(AgentName, string, int?, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedEnumerable<ListToolsResponse, Tool> response = toolsClient.ListTools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolsAsync</summary>
        public async Task ListToolsResourceNamesAsync()
        {
            // Snippet: ListToolsAsync(AgentName, string, int?, CallSettings)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedAsyncEnumerable<ListToolsResponse, Tool> response = toolsClient.ListToolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTool</summary>
        public void GetToolRequestObject()
        {
            // Snippet: GetTool(GetToolRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            GetToolRequest request = new GetToolRequest
            {
                ToolName = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]"),
            };
            // Make the request
            Tool response = toolsClient.GetTool(request);
            // End snippet
        }

        /// <summary>Snippet for GetToolAsync</summary>
        public async Task GetToolRequestObjectAsync()
        {
            // Snippet: GetToolAsync(GetToolRequest, CallSettings)
            // Additional: GetToolAsync(GetToolRequest, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            GetToolRequest request = new GetToolRequest
            {
                ToolName = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]"),
            };
            // Make the request
            Tool response = await toolsClient.GetToolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTool</summary>
        public void GetTool()
        {
            // Snippet: GetTool(string, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]";
            // Make the request
            Tool response = toolsClient.GetTool(name);
            // End snippet
        }

        /// <summary>Snippet for GetToolAsync</summary>
        public async Task GetToolAsync()
        {
            // Snippet: GetToolAsync(string, CallSettings)
            // Additional: GetToolAsync(string, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]";
            // Make the request
            Tool response = await toolsClient.GetToolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTool</summary>
        public void GetToolResourceNames()
        {
            // Snippet: GetTool(ToolName, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            ToolName name = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]");
            // Make the request
            Tool response = toolsClient.GetTool(name);
            // End snippet
        }

        /// <summary>Snippet for GetToolAsync</summary>
        public async Task GetToolResourceNamesAsync()
        {
            // Snippet: GetToolAsync(ToolName, CallSettings)
            // Additional: GetToolAsync(ToolName, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            ToolName name = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]");
            // Make the request
            Tool response = await toolsClient.GetToolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTool</summary>
        public void UpdateToolRequestObject()
        {
            // Snippet: UpdateTool(UpdateToolRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            UpdateToolRequest request = new UpdateToolRequest
            {
                Tool = new Tool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Tool response = toolsClient.UpdateTool(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateToolAsync</summary>
        public async Task UpdateToolRequestObjectAsync()
        {
            // Snippet: UpdateToolAsync(UpdateToolRequest, CallSettings)
            // Additional: UpdateToolAsync(UpdateToolRequest, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateToolRequest request = new UpdateToolRequest
            {
                Tool = new Tool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Tool response = await toolsClient.UpdateToolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTool</summary>
        public void UpdateTool()
        {
            // Snippet: UpdateTool(Tool, FieldMask, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            Tool tool = new Tool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Tool response = toolsClient.UpdateTool(tool, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateToolAsync</summary>
        public async Task UpdateToolAsync()
        {
            // Snippet: UpdateToolAsync(Tool, FieldMask, CallSettings)
            // Additional: UpdateToolAsync(Tool, FieldMask, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            Tool tool = new Tool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Tool response = await toolsClient.UpdateToolAsync(tool, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTool</summary>
        public void DeleteToolRequestObject()
        {
            // Snippet: DeleteTool(DeleteToolRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            DeleteToolRequest request = new DeleteToolRequest
            {
                ToolName = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]"),
                Force = false,
            };
            // Make the request
            toolsClient.DeleteTool(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolAsync</summary>
        public async Task DeleteToolRequestObjectAsync()
        {
            // Snippet: DeleteToolAsync(DeleteToolRequest, CallSettings)
            // Additional: DeleteToolAsync(DeleteToolRequest, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteToolRequest request = new DeleteToolRequest
            {
                ToolName = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]"),
                Force = false,
            };
            // Make the request
            await toolsClient.DeleteToolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTool</summary>
        public void DeleteTool()
        {
            // Snippet: DeleteTool(string, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]";
            // Make the request
            toolsClient.DeleteTool(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolAsync</summary>
        public async Task DeleteToolAsync()
        {
            // Snippet: DeleteToolAsync(string, CallSettings)
            // Additional: DeleteToolAsync(string, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]";
            // Make the request
            await toolsClient.DeleteToolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTool</summary>
        public void DeleteToolResourceNames()
        {
            // Snippet: DeleteTool(ToolName, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            ToolName name = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]");
            // Make the request
            toolsClient.DeleteTool(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolAsync</summary>
        public async Task DeleteToolResourceNamesAsync()
        {
            // Snippet: DeleteToolAsync(ToolName, CallSettings)
            // Additional: DeleteToolAsync(ToolName, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            ToolName name = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]");
            // Make the request
            await toolsClient.DeleteToolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListToolVersions</summary>
        public void ListToolVersionsRequestObject()
        {
            // Snippet: ListToolVersions(ListToolVersionsRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            ListToolVersionsRequest request = new ListToolVersionsRequest
            {
                ParentAsToolName = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]"),
            };
            // Make the request
            PagedEnumerable<ListToolVersionsResponse, ToolVersion> response = toolsClient.ListToolVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ToolVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ToolVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ToolVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ToolVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolVersionsAsync</summary>
        public async Task ListToolVersionsRequestObjectAsync()
        {
            // Snippet: ListToolVersionsAsync(ListToolVersionsRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            ListToolVersionsRequest request = new ListToolVersionsRequest
            {
                ParentAsToolName = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListToolVersionsResponse, ToolVersion> response = toolsClient.ListToolVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ToolVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ToolVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ToolVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ToolVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolVersions</summary>
        public void ListToolVersions()
        {
            // Snippet: ListToolVersions(string, string, int?, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]";
            // Make the request
            PagedEnumerable<ListToolVersionsResponse, ToolVersion> response = toolsClient.ListToolVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ToolVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ToolVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ToolVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ToolVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolVersionsAsync</summary>
        public async Task ListToolVersionsAsync()
        {
            // Snippet: ListToolVersionsAsync(string, string, int?, CallSettings)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]";
            // Make the request
            PagedAsyncEnumerable<ListToolVersionsResponse, ToolVersion> response = toolsClient.ListToolVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ToolVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ToolVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ToolVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ToolVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolVersions</summary>
        public void ListToolVersionsResourceNames()
        {
            // Snippet: ListToolVersions(ToolName, string, int?, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            ToolName parent = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]");
            // Make the request
            PagedEnumerable<ListToolVersionsResponse, ToolVersion> response = toolsClient.ListToolVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ToolVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ToolVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ToolVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ToolVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolVersionsAsync</summary>
        public async Task ListToolVersionsResourceNamesAsync()
        {
            // Snippet: ListToolVersionsAsync(ToolName, string, int?, CallSettings)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            ToolName parent = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]");
            // Make the request
            PagedAsyncEnumerable<ListToolVersionsResponse, ToolVersion> response = toolsClient.ListToolVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ToolVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ToolVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ToolVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ToolVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateToolVersion</summary>
        public void CreateToolVersionRequestObject()
        {
            // Snippet: CreateToolVersion(CreateToolVersionRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            CreateToolVersionRequest request = new CreateToolVersionRequest
            {
                ParentAsToolName = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]"),
                ToolVersion = new ToolVersion(),
            };
            // Make the request
            ToolVersion response = toolsClient.CreateToolVersion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateToolVersionAsync</summary>
        public async Task CreateToolVersionRequestObjectAsync()
        {
            // Snippet: CreateToolVersionAsync(CreateToolVersionRequest, CallSettings)
            // Additional: CreateToolVersionAsync(CreateToolVersionRequest, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            CreateToolVersionRequest request = new CreateToolVersionRequest
            {
                ParentAsToolName = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]"),
                ToolVersion = new ToolVersion(),
            };
            // Make the request
            ToolVersion response = await toolsClient.CreateToolVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateToolVersion</summary>
        public void CreateToolVersion()
        {
            // Snippet: CreateToolVersion(string, ToolVersion, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]";
            ToolVersion toolVersion = new ToolVersion();
            // Make the request
            ToolVersion response = toolsClient.CreateToolVersion(parent, toolVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateToolVersionAsync</summary>
        public async Task CreateToolVersionAsync()
        {
            // Snippet: CreateToolVersionAsync(string, ToolVersion, CallSettings)
            // Additional: CreateToolVersionAsync(string, ToolVersion, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]";
            ToolVersion toolVersion = new ToolVersion();
            // Make the request
            ToolVersion response = await toolsClient.CreateToolVersionAsync(parent, toolVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateToolVersion</summary>
        public void CreateToolVersionResourceNames()
        {
            // Snippet: CreateToolVersion(ToolName, ToolVersion, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            ToolName parent = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]");
            ToolVersion toolVersion = new ToolVersion();
            // Make the request
            ToolVersion response = toolsClient.CreateToolVersion(parent, toolVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateToolVersionAsync</summary>
        public async Task CreateToolVersionResourceNamesAsync()
        {
            // Snippet: CreateToolVersionAsync(ToolName, ToolVersion, CallSettings)
            // Additional: CreateToolVersionAsync(ToolName, ToolVersion, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            ToolName parent = ToolName.FromProjectLocationAgentTool("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]");
            ToolVersion toolVersion = new ToolVersion();
            // Make the request
            ToolVersion response = await toolsClient.CreateToolVersionAsync(parent, toolVersion);
            // End snippet
        }

        /// <summary>Snippet for GetToolVersion</summary>
        public void GetToolVersionRequestObject()
        {
            // Snippet: GetToolVersion(GetToolVersionRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            GetToolVersionRequest request = new GetToolVersionRequest
            {
                ToolVersionName = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]"),
            };
            // Make the request
            ToolVersion response = toolsClient.GetToolVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetToolVersionAsync</summary>
        public async Task GetToolVersionRequestObjectAsync()
        {
            // Snippet: GetToolVersionAsync(GetToolVersionRequest, CallSettings)
            // Additional: GetToolVersionAsync(GetToolVersionRequest, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            GetToolVersionRequest request = new GetToolVersionRequest
            {
                ToolVersionName = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]"),
            };
            // Make the request
            ToolVersion response = await toolsClient.GetToolVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetToolVersion</summary>
        public void GetToolVersion()
        {
            // Snippet: GetToolVersion(string, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]/versions/[VERSION]";
            // Make the request
            ToolVersion response = toolsClient.GetToolVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetToolVersionAsync</summary>
        public async Task GetToolVersionAsync()
        {
            // Snippet: GetToolVersionAsync(string, CallSettings)
            // Additional: GetToolVersionAsync(string, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]/versions/[VERSION]";
            // Make the request
            ToolVersion response = await toolsClient.GetToolVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetToolVersion</summary>
        public void GetToolVersionResourceNames()
        {
            // Snippet: GetToolVersion(ToolVersionName, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            ToolVersionName name = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]");
            // Make the request
            ToolVersion response = toolsClient.GetToolVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetToolVersionAsync</summary>
        public async Task GetToolVersionResourceNamesAsync()
        {
            // Snippet: GetToolVersionAsync(ToolVersionName, CallSettings)
            // Additional: GetToolVersionAsync(ToolVersionName, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            ToolVersionName name = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]");
            // Make the request
            ToolVersion response = await toolsClient.GetToolVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolVersion</summary>
        public void DeleteToolVersionRequestObject()
        {
            // Snippet: DeleteToolVersion(DeleteToolVersionRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            DeleteToolVersionRequest request = new DeleteToolVersionRequest
            {
                ToolVersionName = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]"),
                Force = false,
            };
            // Make the request
            toolsClient.DeleteToolVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolVersionAsync</summary>
        public async Task DeleteToolVersionRequestObjectAsync()
        {
            // Snippet: DeleteToolVersionAsync(DeleteToolVersionRequest, CallSettings)
            // Additional: DeleteToolVersionAsync(DeleteToolVersionRequest, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteToolVersionRequest request = new DeleteToolVersionRequest
            {
                ToolVersionName = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]"),
                Force = false,
            };
            // Make the request
            await toolsClient.DeleteToolVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolVersion</summary>
        public void DeleteToolVersion()
        {
            // Snippet: DeleteToolVersion(string, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]/versions/[VERSION]";
            // Make the request
            toolsClient.DeleteToolVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolVersionAsync</summary>
        public async Task DeleteToolVersionAsync()
        {
            // Snippet: DeleteToolVersionAsync(string, CallSettings)
            // Additional: DeleteToolVersionAsync(string, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]/versions/[VERSION]";
            // Make the request
            await toolsClient.DeleteToolVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolVersion</summary>
        public void DeleteToolVersionResourceNames()
        {
            // Snippet: DeleteToolVersion(ToolVersionName, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            ToolVersionName name = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]");
            // Make the request
            toolsClient.DeleteToolVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolVersionAsync</summary>
        public async Task DeleteToolVersionResourceNamesAsync()
        {
            // Snippet: DeleteToolVersionAsync(ToolVersionName, CallSettings)
            // Additional: DeleteToolVersionAsync(ToolVersionName, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            ToolVersionName name = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]");
            // Make the request
            await toolsClient.DeleteToolVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreToolVersion</summary>
        public void RestoreToolVersionRequestObject()
        {
            // Snippet: RestoreToolVersion(RestoreToolVersionRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            RestoreToolVersionRequest request = new RestoreToolVersionRequest
            {
                ToolVersionName = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]"),
            };
            // Make the request
            RestoreToolVersionResponse response = toolsClient.RestoreToolVersion(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreToolVersionAsync</summary>
        public async Task RestoreToolVersionRequestObjectAsync()
        {
            // Snippet: RestoreToolVersionAsync(RestoreToolVersionRequest, CallSettings)
            // Additional: RestoreToolVersionAsync(RestoreToolVersionRequest, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            RestoreToolVersionRequest request = new RestoreToolVersionRequest
            {
                ToolVersionName = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]"),
            };
            // Make the request
            RestoreToolVersionResponse response = await toolsClient.RestoreToolVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreToolVersion</summary>
        public void RestoreToolVersion()
        {
            // Snippet: RestoreToolVersion(string, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]/versions/[VERSION]";
            // Make the request
            RestoreToolVersionResponse response = toolsClient.RestoreToolVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreToolVersionAsync</summary>
        public async Task RestoreToolVersionAsync()
        {
            // Snippet: RestoreToolVersionAsync(string, CallSettings)
            // Additional: RestoreToolVersionAsync(string, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/tools/[TOOL]/versions/[VERSION]";
            // Make the request
            RestoreToolVersionResponse response = await toolsClient.RestoreToolVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreToolVersion</summary>
        public void RestoreToolVersionResourceNames()
        {
            // Snippet: RestoreToolVersion(ToolVersionName, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            ToolVersionName name = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]");
            // Make the request
            RestoreToolVersionResponse response = toolsClient.RestoreToolVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreToolVersionAsync</summary>
        public async Task RestoreToolVersionResourceNamesAsync()
        {
            // Snippet: RestoreToolVersionAsync(ToolVersionName, CallSettings)
            // Additional: RestoreToolVersionAsync(ToolVersionName, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            ToolVersionName name = ToolVersionName.FromProjectLocationAgentToolVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[TOOL]", "[VERSION]");
            // Make the request
            RestoreToolVersionResponse response = await toolsClient.RestoreToolVersionAsync(name);
            // End snippet
        }
    }
}
