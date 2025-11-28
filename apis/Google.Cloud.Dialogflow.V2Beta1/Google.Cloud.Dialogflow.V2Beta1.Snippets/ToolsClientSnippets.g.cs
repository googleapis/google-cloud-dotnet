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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Tool = new Tool(),
                ToolId = "",
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Tool = new Tool(),
                ToolId = "",
            };
            // Make the request
            Tool response = await toolsClient.CreateToolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTool</summary>
        public void CreateTool()
        {
            // Snippet: CreateTool(string, Tool, string, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Tool tool = new Tool();
            string toolId = "";
            // Make the request
            Tool response = toolsClient.CreateTool(parent, tool, toolId);
            // End snippet
        }

        /// <summary>Snippet for CreateToolAsync</summary>
        public async Task CreateToolAsync()
        {
            // Snippet: CreateToolAsync(string, Tool, string, CallSettings)
            // Additional: CreateToolAsync(string, Tool, string, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Tool tool = new Tool();
            string toolId = "";
            // Make the request
            Tool response = await toolsClient.CreateToolAsync(parent, tool, toolId);
            // End snippet
        }

        /// <summary>Snippet for CreateTool</summary>
        public void CreateToolResourceNames()
        {
            // Snippet: CreateTool(LocationName, Tool, string, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Tool tool = new Tool();
            string toolId = "";
            // Make the request
            Tool response = toolsClient.CreateTool(parent, tool, toolId);
            // End snippet
        }

        /// <summary>Snippet for CreateToolAsync</summary>
        public async Task CreateToolResourceNamesAsync()
        {
            // Snippet: CreateToolAsync(LocationName, Tool, string, CallSettings)
            // Additional: CreateToolAsync(LocationName, Tool, string, CancellationToken)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Tool tool = new Tool();
            string toolId = "";
            // Make the request
            Tool response = await toolsClient.CreateToolAsync(parent, tool, toolId);
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
                ToolName = ToolName.FromProjectLocationTool("[PROJECT]", "[LOCATION]", "[TOOL]"),
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
                ToolName = ToolName.FromProjectLocationTool("[PROJECT]", "[LOCATION]", "[TOOL]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/tools/[TOOL]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/tools/[TOOL]";
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
            ToolName name = ToolName.FromProjectLocationTool("[PROJECT]", "[LOCATION]", "[TOOL]");
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
            ToolName name = ToolName.FromProjectLocationTool("[PROJECT]", "[LOCATION]", "[TOOL]");
            // Make the request
            Tool response = await toolsClient.GetToolAsync(name);
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListToolsResponse, Tool> response = toolsClient.ListToolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListToolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListToolsResponse, Tool> response = toolsClient.ListToolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListToolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            // Snippet: ListTools(LocationName, string, int?, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
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
            // Snippet: ListToolsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ToolsClient toolsClient = await ToolsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListToolsResponse, Tool> response = toolsClient.ListToolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListToolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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

        /// <summary>Snippet for DeleteTool</summary>
        public void DeleteToolRequestObject()
        {
            // Snippet: DeleteTool(DeleteToolRequest, CallSettings)
            // Create client
            ToolsClient toolsClient = ToolsClient.Create();
            // Initialize request argument(s)
            DeleteToolRequest request = new DeleteToolRequest
            {
                ToolName = ToolName.FromProjectLocationTool("[PROJECT]", "[LOCATION]", "[TOOL]"),
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
                ToolName = ToolName.FromProjectLocationTool("[PROJECT]", "[LOCATION]", "[TOOL]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/tools/[TOOL]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/tools/[TOOL]";
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
            ToolName name = ToolName.FromProjectLocationTool("[PROJECT]", "[LOCATION]", "[TOOL]");
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
            ToolName name = ToolName.FromProjectLocationTool("[PROJECT]", "[LOCATION]", "[TOOL]");
            // Make the request
            await toolsClient.DeleteToolAsync(name);
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
    }
}
