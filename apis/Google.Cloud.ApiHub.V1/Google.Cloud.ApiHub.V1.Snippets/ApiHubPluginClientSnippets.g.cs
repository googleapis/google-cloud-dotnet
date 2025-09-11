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
    using Google.Cloud.ApiHub.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedApiHubPluginClientSnippets
    {
        /// <summary>Snippet for GetPlugin</summary>
        public void GetPluginRequestObject()
        {
            // Snippet: GetPlugin(GetPluginRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            GetPluginRequest request = new GetPluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = apiHubPluginClient.GetPlugin(request);
            // End snippet
        }

        /// <summary>Snippet for GetPluginAsync</summary>
        public async Task GetPluginRequestObjectAsync()
        {
            // Snippet: GetPluginAsync(GetPluginRequest, CallSettings)
            // Additional: GetPluginAsync(GetPluginRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            GetPluginRequest request = new GetPluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = await apiHubPluginClient.GetPluginAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPlugin</summary>
        public void GetPlugin()
        {
            // Snippet: GetPlugin(string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = apiHubPluginClient.GetPlugin(name);
            // End snippet
        }

        /// <summary>Snippet for GetPluginAsync</summary>
        public async Task GetPluginAsync()
        {
            // Snippet: GetPluginAsync(string, CallSettings)
            // Additional: GetPluginAsync(string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = await apiHubPluginClient.GetPluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlugin</summary>
        public void GetPluginResourceNames()
        {
            // Snippet: GetPlugin(PluginName, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = apiHubPluginClient.GetPlugin(name);
            // End snippet
        }

        /// <summary>Snippet for GetPluginAsync</summary>
        public async Task GetPluginResourceNamesAsync()
        {
            // Snippet: GetPluginAsync(PluginName, CallSettings)
            // Additional: GetPluginAsync(PluginName, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = await apiHubPluginClient.GetPluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnablePlugin</summary>
        public void EnablePluginRequestObject()
        {
            // Snippet: EnablePlugin(EnablePluginRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            EnablePluginRequest request = new EnablePluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = apiHubPluginClient.EnablePlugin(request);
            // End snippet
        }

        /// <summary>Snippet for EnablePluginAsync</summary>
        public async Task EnablePluginRequestObjectAsync()
        {
            // Snippet: EnablePluginAsync(EnablePluginRequest, CallSettings)
            // Additional: EnablePluginAsync(EnablePluginRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            EnablePluginRequest request = new EnablePluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = await apiHubPluginClient.EnablePluginAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EnablePlugin</summary>
        public void EnablePlugin()
        {
            // Snippet: EnablePlugin(string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = apiHubPluginClient.EnablePlugin(name);
            // End snippet
        }

        /// <summary>Snippet for EnablePluginAsync</summary>
        public async Task EnablePluginAsync()
        {
            // Snippet: EnablePluginAsync(string, CallSettings)
            // Additional: EnablePluginAsync(string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = await apiHubPluginClient.EnablePluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnablePlugin</summary>
        public void EnablePluginResourceNames()
        {
            // Snippet: EnablePlugin(PluginName, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = apiHubPluginClient.EnablePlugin(name);
            // End snippet
        }

        /// <summary>Snippet for EnablePluginAsync</summary>
        public async Task EnablePluginResourceNamesAsync()
        {
            // Snippet: EnablePluginAsync(PluginName, CallSettings)
            // Additional: EnablePluginAsync(PluginName, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = await apiHubPluginClient.EnablePluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisablePlugin</summary>
        public void DisablePluginRequestObject()
        {
            // Snippet: DisablePlugin(DisablePluginRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            DisablePluginRequest request = new DisablePluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = apiHubPluginClient.DisablePlugin(request);
            // End snippet
        }

        /// <summary>Snippet for DisablePluginAsync</summary>
        public async Task DisablePluginRequestObjectAsync()
        {
            // Snippet: DisablePluginAsync(DisablePluginRequest, CallSettings)
            // Additional: DisablePluginAsync(DisablePluginRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            DisablePluginRequest request = new DisablePluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Plugin response = await apiHubPluginClient.DisablePluginAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DisablePlugin</summary>
        public void DisablePlugin()
        {
            // Snippet: DisablePlugin(string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = apiHubPluginClient.DisablePlugin(name);
            // End snippet
        }

        /// <summary>Snippet for DisablePluginAsync</summary>
        public async Task DisablePluginAsync()
        {
            // Snippet: DisablePluginAsync(string, CallSettings)
            // Additional: DisablePluginAsync(string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Plugin response = await apiHubPluginClient.DisablePluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisablePlugin</summary>
        public void DisablePluginResourceNames()
        {
            // Snippet: DisablePlugin(PluginName, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = apiHubPluginClient.DisablePlugin(name);
            // End snippet
        }

        /// <summary>Snippet for DisablePluginAsync</summary>
        public async Task DisablePluginResourceNamesAsync()
        {
            // Snippet: DisablePluginAsync(PluginName, CallSettings)
            // Additional: DisablePluginAsync(PluginName, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Plugin response = await apiHubPluginClient.DisablePluginAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePlugin</summary>
        public void CreatePluginRequestObject()
        {
            // Snippet: CreatePlugin(CreatePluginRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            CreatePluginRequest request = new CreatePluginRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PluginId = "",
                Plugin = new Plugin(),
            };
            // Make the request
            Plugin response = apiHubPluginClient.CreatePlugin(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePluginAsync</summary>
        public async Task CreatePluginRequestObjectAsync()
        {
            // Snippet: CreatePluginAsync(CreatePluginRequest, CallSettings)
            // Additional: CreatePluginAsync(CreatePluginRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            CreatePluginRequest request = new CreatePluginRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PluginId = "",
                Plugin = new Plugin(),
            };
            // Make the request
            Plugin response = await apiHubPluginClient.CreatePluginAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePlugin</summary>
        public void CreatePlugin()
        {
            // Snippet: CreatePlugin(string, Plugin, string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Plugin plugin = new Plugin();
            string pluginId = "";
            // Make the request
            Plugin response = apiHubPluginClient.CreatePlugin(parent, plugin, pluginId);
            // End snippet
        }

        /// <summary>Snippet for CreatePluginAsync</summary>
        public async Task CreatePluginAsync()
        {
            // Snippet: CreatePluginAsync(string, Plugin, string, CallSettings)
            // Additional: CreatePluginAsync(string, Plugin, string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Plugin plugin = new Plugin();
            string pluginId = "";
            // Make the request
            Plugin response = await apiHubPluginClient.CreatePluginAsync(parent, plugin, pluginId);
            // End snippet
        }

        /// <summary>Snippet for CreatePlugin</summary>
        public void CreatePluginResourceNames()
        {
            // Snippet: CreatePlugin(LocationName, Plugin, string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Plugin plugin = new Plugin();
            string pluginId = "";
            // Make the request
            Plugin response = apiHubPluginClient.CreatePlugin(parent, plugin, pluginId);
            // End snippet
        }

        /// <summary>Snippet for CreatePluginAsync</summary>
        public async Task CreatePluginResourceNamesAsync()
        {
            // Snippet: CreatePluginAsync(LocationName, Plugin, string, CallSettings)
            // Additional: CreatePluginAsync(LocationName, Plugin, string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Plugin plugin = new Plugin();
            string pluginId = "";
            // Make the request
            Plugin response = await apiHubPluginClient.CreatePluginAsync(parent, plugin, pluginId);
            // End snippet
        }

        /// <summary>Snippet for ListPlugins</summary>
        public void ListPluginsRequestObject()
        {
            // Snippet: ListPlugins(ListPluginsRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            ListPluginsRequest request = new ListPluginsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPluginsResponse, Plugin> response = apiHubPluginClient.ListPlugins(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Plugin item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPluginsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Plugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Plugin> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Plugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluginsAsync</summary>
        public async Task ListPluginsRequestObjectAsync()
        {
            // Snippet: ListPluginsAsync(ListPluginsRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            ListPluginsRequest request = new ListPluginsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPluginsResponse, Plugin> response = apiHubPluginClient.ListPluginsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Plugin item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPluginsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Plugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Plugin> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Plugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlugins</summary>
        public void ListPlugins()
        {
            // Snippet: ListPlugins(string, string, int?, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPluginsResponse, Plugin> response = apiHubPluginClient.ListPlugins(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Plugin item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPluginsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Plugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Plugin> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Plugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluginsAsync</summary>
        public async Task ListPluginsAsync()
        {
            // Snippet: ListPluginsAsync(string, string, int?, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPluginsResponse, Plugin> response = apiHubPluginClient.ListPluginsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Plugin item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPluginsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Plugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Plugin> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Plugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlugins</summary>
        public void ListPluginsResourceNames()
        {
            // Snippet: ListPlugins(LocationName, string, int?, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPluginsResponse, Plugin> response = apiHubPluginClient.ListPlugins(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Plugin item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPluginsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Plugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Plugin> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Plugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluginsAsync</summary>
        public async Task ListPluginsResourceNamesAsync()
        {
            // Snippet: ListPluginsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPluginsResponse, Plugin> response = apiHubPluginClient.ListPluginsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Plugin item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPluginsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Plugin item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Plugin> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Plugin item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeletePlugin</summary>
        public void DeletePluginRequestObject()
        {
            // Snippet: DeletePlugin(DeletePluginRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            DeletePluginRequest request = new DeletePluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = apiHubPluginClient.DeletePlugin(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceDeletePlugin(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePluginAsync</summary>
        public async Task DeletePluginRequestObjectAsync()
        {
            // Snippet: DeletePluginAsync(DeletePluginRequest, CallSettings)
            // Additional: DeletePluginAsync(DeletePluginRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            DeletePluginRequest request = new DeletePluginRequest
            {
                PluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiHubPluginClient.DeletePluginAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceDeletePluginAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePlugin</summary>
        public void DeletePlugin()
        {
            // Snippet: DeletePlugin(string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = apiHubPluginClient.DeletePlugin(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceDeletePlugin(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePluginAsync</summary>
        public async Task DeletePluginAsync()
        {
            // Snippet: DeletePluginAsync(string, CallSettings)
            // Additional: DeletePluginAsync(string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiHubPluginClient.DeletePluginAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceDeletePluginAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePlugin</summary>
        public void DeletePluginResourceNames()
        {
            // Snippet: DeletePlugin(PluginName, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = apiHubPluginClient.DeletePlugin(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceDeletePlugin(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePluginAsync</summary>
        public async Task DeletePluginResourceNamesAsync()
        {
            // Snippet: DeletePluginAsync(PluginName, CallSettings)
            // Additional: DeletePluginAsync(PluginName, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginName name = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiHubPluginClient.DeletePluginAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceDeletePluginAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePluginInstance</summary>
        public void CreatePluginInstanceRequestObject()
        {
            // Snippet: CreatePluginInstance(CreatePluginInstanceRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            CreatePluginInstanceRequest request = new CreatePluginInstanceRequest
            {
                ParentAsPluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
                PluginInstanceId = "",
                PluginInstance = new PluginInstance(),
            };
            // Make the request
            Operation<PluginInstance, OperationMetadata> response = apiHubPluginClient.CreatePluginInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<PluginInstance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PluginInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PluginInstance, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceCreatePluginInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PluginInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePluginInstanceAsync</summary>
        public async Task CreatePluginInstanceRequestObjectAsync()
        {
            // Snippet: CreatePluginInstanceAsync(CreatePluginInstanceRequest, CallSettings)
            // Additional: CreatePluginInstanceAsync(CreatePluginInstanceRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            CreatePluginInstanceRequest request = new CreatePluginInstanceRequest
            {
                ParentAsPluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
                PluginInstanceId = "",
                PluginInstance = new PluginInstance(),
            };
            // Make the request
            Operation<PluginInstance, OperationMetadata> response = await apiHubPluginClient.CreatePluginInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PluginInstance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PluginInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PluginInstance, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceCreatePluginInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PluginInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePluginInstance</summary>
        public void CreatePluginInstance()
        {
            // Snippet: CreatePluginInstance(string, PluginInstance, string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            PluginInstance pluginInstance = new PluginInstance();
            string pluginInstanceId = "";
            // Make the request
            Operation<PluginInstance, OperationMetadata> response = apiHubPluginClient.CreatePluginInstance(parent, pluginInstance, pluginInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<PluginInstance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PluginInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PluginInstance, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceCreatePluginInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PluginInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePluginInstanceAsync</summary>
        public async Task CreatePluginInstanceAsync()
        {
            // Snippet: CreatePluginInstanceAsync(string, PluginInstance, string, CallSettings)
            // Additional: CreatePluginInstanceAsync(string, PluginInstance, string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            PluginInstance pluginInstance = new PluginInstance();
            string pluginInstanceId = "";
            // Make the request
            Operation<PluginInstance, OperationMetadata> response = await apiHubPluginClient.CreatePluginInstanceAsync(parent, pluginInstance, pluginInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<PluginInstance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PluginInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PluginInstance, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceCreatePluginInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PluginInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePluginInstance</summary>
        public void CreatePluginInstanceResourceNames()
        {
            // Snippet: CreatePluginInstance(PluginName, PluginInstance, string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginName parent = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            PluginInstance pluginInstance = new PluginInstance();
            string pluginInstanceId = "";
            // Make the request
            Operation<PluginInstance, OperationMetadata> response = apiHubPluginClient.CreatePluginInstance(parent, pluginInstance, pluginInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<PluginInstance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PluginInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PluginInstance, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceCreatePluginInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PluginInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePluginInstanceAsync</summary>
        public async Task CreatePluginInstanceResourceNamesAsync()
        {
            // Snippet: CreatePluginInstanceAsync(PluginName, PluginInstance, string, CallSettings)
            // Additional: CreatePluginInstanceAsync(PluginName, PluginInstance, string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginName parent = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            PluginInstance pluginInstance = new PluginInstance();
            string pluginInstanceId = "";
            // Make the request
            Operation<PluginInstance, OperationMetadata> response = await apiHubPluginClient.CreatePluginInstanceAsync(parent, pluginInstance, pluginInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<PluginInstance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PluginInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PluginInstance, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceCreatePluginInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PluginInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecutePluginInstanceAction</summary>
        public void ExecutePluginInstanceActionRequestObject()
        {
            // Snippet: ExecutePluginInstanceAction(ExecutePluginInstanceActionRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            ExecutePluginInstanceActionRequest request = new ExecutePluginInstanceActionRequest
            {
                PluginInstanceName = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]"),
                ActionExecutionDetail = new ActionExecutionDetail(),
            };
            // Make the request
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> response = apiHubPluginClient.ExecutePluginInstanceAction(request);

            // Poll until the returned long-running operation is complete
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExecutePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceExecutePluginInstanceAction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecutePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecutePluginInstanceActionAsync</summary>
        public async Task ExecutePluginInstanceActionRequestObjectAsync()
        {
            // Snippet: ExecutePluginInstanceActionAsync(ExecutePluginInstanceActionRequest, CallSettings)
            // Additional: ExecutePluginInstanceActionAsync(ExecutePluginInstanceActionRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            ExecutePluginInstanceActionRequest request = new ExecutePluginInstanceActionRequest
            {
                PluginInstanceName = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]"),
                ActionExecutionDetail = new ActionExecutionDetail(),
            };
            // Make the request
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> response = await apiHubPluginClient.ExecutePluginInstanceActionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExecutePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceExecutePluginInstanceActionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecutePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecutePluginInstanceAction</summary>
        public void ExecutePluginInstanceAction()
        {
            // Snippet: ExecutePluginInstanceAction(string, ActionExecutionDetail, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/instances/[INSTANCE]";
            ActionExecutionDetail actionExecutionDetail = new ActionExecutionDetail();
            // Make the request
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> response = apiHubPluginClient.ExecutePluginInstanceAction(name, actionExecutionDetail);

            // Poll until the returned long-running operation is complete
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExecutePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceExecutePluginInstanceAction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecutePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecutePluginInstanceActionAsync</summary>
        public async Task ExecutePluginInstanceActionAsync()
        {
            // Snippet: ExecutePluginInstanceActionAsync(string, ActionExecutionDetail, CallSettings)
            // Additional: ExecutePluginInstanceActionAsync(string, ActionExecutionDetail, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/instances/[INSTANCE]";
            ActionExecutionDetail actionExecutionDetail = new ActionExecutionDetail();
            // Make the request
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> response = await apiHubPluginClient.ExecutePluginInstanceActionAsync(name, actionExecutionDetail);

            // Poll until the returned long-running operation is complete
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExecutePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceExecutePluginInstanceActionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecutePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecutePluginInstanceAction</summary>
        public void ExecutePluginInstanceActionResourceNames()
        {
            // Snippet: ExecutePluginInstanceAction(PluginInstanceName, ActionExecutionDetail, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginInstanceName name = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]");
            ActionExecutionDetail actionExecutionDetail = new ActionExecutionDetail();
            // Make the request
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> response = apiHubPluginClient.ExecutePluginInstanceAction(name, actionExecutionDetail);

            // Poll until the returned long-running operation is complete
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExecutePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceExecutePluginInstanceAction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecutePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecutePluginInstanceActionAsync</summary>
        public async Task ExecutePluginInstanceActionResourceNamesAsync()
        {
            // Snippet: ExecutePluginInstanceActionAsync(PluginInstanceName, ActionExecutionDetail, CallSettings)
            // Additional: ExecutePluginInstanceActionAsync(PluginInstanceName, ActionExecutionDetail, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginInstanceName name = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]");
            ActionExecutionDetail actionExecutionDetail = new ActionExecutionDetail();
            // Make the request
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> response = await apiHubPluginClient.ExecutePluginInstanceActionAsync(name, actionExecutionDetail);

            // Poll until the returned long-running operation is complete
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExecutePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecutePluginInstanceActionResponse, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceExecutePluginInstanceActionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecutePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPluginInstance</summary>
        public void GetPluginInstanceRequestObject()
        {
            // Snippet: GetPluginInstance(GetPluginInstanceRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            GetPluginInstanceRequest request = new GetPluginInstanceRequest
            {
                PluginInstanceName = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]"),
            };
            // Make the request
            PluginInstance response = apiHubPluginClient.GetPluginInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetPluginInstanceAsync</summary>
        public async Task GetPluginInstanceRequestObjectAsync()
        {
            // Snippet: GetPluginInstanceAsync(GetPluginInstanceRequest, CallSettings)
            // Additional: GetPluginInstanceAsync(GetPluginInstanceRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            GetPluginInstanceRequest request = new GetPluginInstanceRequest
            {
                PluginInstanceName = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]"),
            };
            // Make the request
            PluginInstance response = await apiHubPluginClient.GetPluginInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPluginInstance</summary>
        public void GetPluginInstance()
        {
            // Snippet: GetPluginInstance(string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/instances/[INSTANCE]";
            // Make the request
            PluginInstance response = apiHubPluginClient.GetPluginInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetPluginInstanceAsync</summary>
        public async Task GetPluginInstanceAsync()
        {
            // Snippet: GetPluginInstanceAsync(string, CallSettings)
            // Additional: GetPluginInstanceAsync(string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/instances/[INSTANCE]";
            // Make the request
            PluginInstance response = await apiHubPluginClient.GetPluginInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPluginInstance</summary>
        public void GetPluginInstanceResourceNames()
        {
            // Snippet: GetPluginInstance(PluginInstanceName, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginInstanceName name = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]");
            // Make the request
            PluginInstance response = apiHubPluginClient.GetPluginInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetPluginInstanceAsync</summary>
        public async Task GetPluginInstanceResourceNamesAsync()
        {
            // Snippet: GetPluginInstanceAsync(PluginInstanceName, CallSettings)
            // Additional: GetPluginInstanceAsync(PluginInstanceName, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginInstanceName name = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]");
            // Make the request
            PluginInstance response = await apiHubPluginClient.GetPluginInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPluginInstances</summary>
        public void ListPluginInstancesRequestObject()
        {
            // Snippet: ListPluginInstances(ListPluginInstancesRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            ListPluginInstancesRequest request = new ListPluginInstancesRequest
            {
                ParentAsPluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPluginInstancesResponse, PluginInstance> response = apiHubPluginClient.ListPluginInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PluginInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPluginInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluginInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluginInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluginInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluginInstancesAsync</summary>
        public async Task ListPluginInstancesRequestObjectAsync()
        {
            // Snippet: ListPluginInstancesAsync(ListPluginInstancesRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            ListPluginInstancesRequest request = new ListPluginInstancesRequest
            {
                ParentAsPluginName = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPluginInstancesResponse, PluginInstance> response = apiHubPluginClient.ListPluginInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PluginInstance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPluginInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluginInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluginInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluginInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluginInstances</summary>
        public void ListPluginInstances()
        {
            // Snippet: ListPluginInstances(string, string, int?, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            PagedEnumerable<ListPluginInstancesResponse, PluginInstance> response = apiHubPluginClient.ListPluginInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PluginInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPluginInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluginInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluginInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluginInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluginInstancesAsync</summary>
        public async Task ListPluginInstancesAsync()
        {
            // Snippet: ListPluginInstancesAsync(string, string, int?, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]";
            // Make the request
            PagedAsyncEnumerable<ListPluginInstancesResponse, PluginInstance> response = apiHubPluginClient.ListPluginInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PluginInstance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPluginInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluginInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluginInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluginInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluginInstances</summary>
        public void ListPluginInstancesResourceNames()
        {
            // Snippet: ListPluginInstances(PluginName, string, int?, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginName parent = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            PagedEnumerable<ListPluginInstancesResponse, PluginInstance> response = apiHubPluginClient.ListPluginInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PluginInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPluginInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluginInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluginInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluginInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluginInstancesAsync</summary>
        public async Task ListPluginInstancesResourceNamesAsync()
        {
            // Snippet: ListPluginInstancesAsync(PluginName, string, int?, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginName parent = PluginName.FromProjectLocationPlugin("[PROJECT]", "[LOCATION]", "[PLUGIN]");
            // Make the request
            PagedAsyncEnumerable<ListPluginInstancesResponse, PluginInstance> response = apiHubPluginClient.ListPluginInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PluginInstance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPluginInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluginInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluginInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluginInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for EnablePluginInstanceAction</summary>
        public void EnablePluginInstanceActionRequestObject()
        {
            // Snippet: EnablePluginInstanceAction(EnablePluginInstanceActionRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            EnablePluginInstanceActionRequest request = new EnablePluginInstanceActionRequest
            {
                PluginInstanceName = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]"),
                ActionId = "",
            };
            // Make the request
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> response = apiHubPluginClient.EnablePluginInstanceAction(request);

            // Poll until the returned long-running operation is complete
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EnablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceEnablePluginInstanceAction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnablePluginInstanceActionAsync</summary>
        public async Task EnablePluginInstanceActionRequestObjectAsync()
        {
            // Snippet: EnablePluginInstanceActionAsync(EnablePluginInstanceActionRequest, CallSettings)
            // Additional: EnablePluginInstanceActionAsync(EnablePluginInstanceActionRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            EnablePluginInstanceActionRequest request = new EnablePluginInstanceActionRequest
            {
                PluginInstanceName = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]"),
                ActionId = "",
            };
            // Make the request
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> response = await apiHubPluginClient.EnablePluginInstanceActionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EnablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceEnablePluginInstanceActionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnablePluginInstanceAction</summary>
        public void EnablePluginInstanceAction()
        {
            // Snippet: EnablePluginInstanceAction(string, string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/instances/[INSTANCE]";
            string actionId = "";
            // Make the request
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> response = apiHubPluginClient.EnablePluginInstanceAction(name, actionId);

            // Poll until the returned long-running operation is complete
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EnablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceEnablePluginInstanceAction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnablePluginInstanceActionAsync</summary>
        public async Task EnablePluginInstanceActionAsync()
        {
            // Snippet: EnablePluginInstanceActionAsync(string, string, CallSettings)
            // Additional: EnablePluginInstanceActionAsync(string, string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/instances/[INSTANCE]";
            string actionId = "";
            // Make the request
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> response = await apiHubPluginClient.EnablePluginInstanceActionAsync(name, actionId);

            // Poll until the returned long-running operation is complete
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EnablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceEnablePluginInstanceActionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnablePluginInstanceAction</summary>
        public void EnablePluginInstanceActionResourceNames()
        {
            // Snippet: EnablePluginInstanceAction(PluginInstanceName, string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginInstanceName name = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]");
            string actionId = "";
            // Make the request
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> response = apiHubPluginClient.EnablePluginInstanceAction(name, actionId);

            // Poll until the returned long-running operation is complete
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EnablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceEnablePluginInstanceAction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnablePluginInstanceActionAsync</summary>
        public async Task EnablePluginInstanceActionResourceNamesAsync()
        {
            // Snippet: EnablePluginInstanceActionAsync(PluginInstanceName, string, CallSettings)
            // Additional: EnablePluginInstanceActionAsync(PluginInstanceName, string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginInstanceName name = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]");
            string actionId = "";
            // Make the request
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> response = await apiHubPluginClient.EnablePluginInstanceActionAsync(name, actionId);

            // Poll until the returned long-running operation is complete
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EnablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceEnablePluginInstanceActionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisablePluginInstanceAction</summary>
        public void DisablePluginInstanceActionRequestObject()
        {
            // Snippet: DisablePluginInstanceAction(DisablePluginInstanceActionRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            DisablePluginInstanceActionRequest request = new DisablePluginInstanceActionRequest
            {
                PluginInstanceName = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]"),
                ActionId = "",
            };
            // Make the request
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> response = apiHubPluginClient.DisablePluginInstanceAction(request);

            // Poll until the returned long-running operation is complete
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DisablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceDisablePluginInstanceAction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisablePluginInstanceActionAsync</summary>
        public async Task DisablePluginInstanceActionRequestObjectAsync()
        {
            // Snippet: DisablePluginInstanceActionAsync(DisablePluginInstanceActionRequest, CallSettings)
            // Additional: DisablePluginInstanceActionAsync(DisablePluginInstanceActionRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            DisablePluginInstanceActionRequest request = new DisablePluginInstanceActionRequest
            {
                PluginInstanceName = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]"),
                ActionId = "",
            };
            // Make the request
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> response = await apiHubPluginClient.DisablePluginInstanceActionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DisablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceDisablePluginInstanceActionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisablePluginInstanceAction</summary>
        public void DisablePluginInstanceAction()
        {
            // Snippet: DisablePluginInstanceAction(string, string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/instances/[INSTANCE]";
            string actionId = "";
            // Make the request
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> response = apiHubPluginClient.DisablePluginInstanceAction(name, actionId);

            // Poll until the returned long-running operation is complete
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DisablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceDisablePluginInstanceAction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisablePluginInstanceActionAsync</summary>
        public async Task DisablePluginInstanceActionAsync()
        {
            // Snippet: DisablePluginInstanceActionAsync(string, string, CallSettings)
            // Additional: DisablePluginInstanceActionAsync(string, string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/instances/[INSTANCE]";
            string actionId = "";
            // Make the request
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> response = await apiHubPluginClient.DisablePluginInstanceActionAsync(name, actionId);

            // Poll until the returned long-running operation is complete
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DisablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceDisablePluginInstanceActionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisablePluginInstanceAction</summary>
        public void DisablePluginInstanceActionResourceNames()
        {
            // Snippet: DisablePluginInstanceAction(PluginInstanceName, string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginInstanceName name = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]");
            string actionId = "";
            // Make the request
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> response = apiHubPluginClient.DisablePluginInstanceAction(name, actionId);

            // Poll until the returned long-running operation is complete
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DisablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceDisablePluginInstanceAction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisablePluginInstanceActionAsync</summary>
        public async Task DisablePluginInstanceActionResourceNamesAsync()
        {
            // Snippet: DisablePluginInstanceActionAsync(PluginInstanceName, string, CallSettings)
            // Additional: DisablePluginInstanceActionAsync(PluginInstanceName, string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginInstanceName name = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]");
            string actionId = "";
            // Make the request
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> response = await apiHubPluginClient.DisablePluginInstanceActionAsync(name, actionId);

            // Poll until the returned long-running operation is complete
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DisablePluginInstanceActionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisablePluginInstanceActionResponse, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceDisablePluginInstanceActionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisablePluginInstanceActionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePluginInstance</summary>
        public void UpdatePluginInstanceRequestObject()
        {
            // Snippet: UpdatePluginInstance(UpdatePluginInstanceRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            UpdatePluginInstanceRequest request = new UpdatePluginInstanceRequest
            {
                PluginInstance = new PluginInstance(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PluginInstance response = apiHubPluginClient.UpdatePluginInstance(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePluginInstanceAsync</summary>
        public async Task UpdatePluginInstanceRequestObjectAsync()
        {
            // Snippet: UpdatePluginInstanceAsync(UpdatePluginInstanceRequest, CallSettings)
            // Additional: UpdatePluginInstanceAsync(UpdatePluginInstanceRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePluginInstanceRequest request = new UpdatePluginInstanceRequest
            {
                PluginInstance = new PluginInstance(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PluginInstance response = await apiHubPluginClient.UpdatePluginInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePluginInstance</summary>
        public void UpdatePluginInstance()
        {
            // Snippet: UpdatePluginInstance(PluginInstance, FieldMask, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginInstance pluginInstance = new PluginInstance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PluginInstance response = apiHubPluginClient.UpdatePluginInstance(pluginInstance, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePluginInstanceAsync</summary>
        public async Task UpdatePluginInstanceAsync()
        {
            // Snippet: UpdatePluginInstanceAsync(PluginInstance, FieldMask, CallSettings)
            // Additional: UpdatePluginInstanceAsync(PluginInstance, FieldMask, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginInstance pluginInstance = new PluginInstance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PluginInstance response = await apiHubPluginClient.UpdatePluginInstanceAsync(pluginInstance, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeletePluginInstance</summary>
        public void DeletePluginInstanceRequestObject()
        {
            // Snippet: DeletePluginInstance(DeletePluginInstanceRequest, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            DeletePluginInstanceRequest request = new DeletePluginInstanceRequest
            {
                PluginInstanceName = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = apiHubPluginClient.DeletePluginInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceDeletePluginInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePluginInstanceAsync</summary>
        public async Task DeletePluginInstanceRequestObjectAsync()
        {
            // Snippet: DeletePluginInstanceAsync(DeletePluginInstanceRequest, CallSettings)
            // Additional: DeletePluginInstanceAsync(DeletePluginInstanceRequest, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            DeletePluginInstanceRequest request = new DeletePluginInstanceRequest
            {
                PluginInstanceName = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiHubPluginClient.DeletePluginInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceDeletePluginInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePluginInstance</summary>
        public void DeletePluginInstance()
        {
            // Snippet: DeletePluginInstance(string, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = apiHubPluginClient.DeletePluginInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceDeletePluginInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePluginInstanceAsync</summary>
        public async Task DeletePluginInstanceAsync()
        {
            // Snippet: DeletePluginInstanceAsync(string, CallSettings)
            // Additional: DeletePluginInstanceAsync(string, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/plugins/[PLUGIN]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiHubPluginClient.DeletePluginInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceDeletePluginInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePluginInstance</summary>
        public void DeletePluginInstanceResourceNames()
        {
            // Snippet: DeletePluginInstance(PluginInstanceName, CallSettings)
            // Create client
            ApiHubPluginClient apiHubPluginClient = ApiHubPluginClient.Create();
            // Initialize request argument(s)
            PluginInstanceName name = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = apiHubPluginClient.DeletePluginInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = apiHubPluginClient.PollOnceDeletePluginInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePluginInstanceAsync</summary>
        public async Task DeletePluginInstanceResourceNamesAsync()
        {
            // Snippet: DeletePluginInstanceAsync(PluginInstanceName, CallSettings)
            // Additional: DeletePluginInstanceAsync(PluginInstanceName, CancellationToken)
            // Create client
            ApiHubPluginClient apiHubPluginClient = await ApiHubPluginClient.CreateAsync();
            // Initialize request argument(s)
            PluginInstanceName name = PluginInstanceName.FromProjectLocationPluginInstance("[PROJECT]", "[LOCATION]", "[PLUGIN]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await apiHubPluginClient.DeletePluginInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await apiHubPluginClient.PollOnceDeletePluginInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
