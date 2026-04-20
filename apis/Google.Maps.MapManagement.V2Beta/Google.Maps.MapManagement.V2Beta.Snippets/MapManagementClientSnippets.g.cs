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
    using Google.Maps.MapManagement.V2Beta;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMapManagementClientSnippets
    {
        /// <summary>Snippet for CreateMapConfig</summary>
        public void CreateMapConfigRequestObject()
        {
            // Snippet: CreateMapConfig(CreateMapConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            CreateMapConfigRequest request = new CreateMapConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                MapConfig = new MapConfig(),
            };
            // Make the request
            MapConfig response = mapManagementClient.CreateMapConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMapConfigAsync</summary>
        public async Task CreateMapConfigRequestObjectAsync()
        {
            // Snippet: CreateMapConfigAsync(CreateMapConfigRequest, CallSettings)
            // Additional: CreateMapConfigAsync(CreateMapConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateMapConfigRequest request = new CreateMapConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                MapConfig = new MapConfig(),
            };
            // Make the request
            MapConfig response = await mapManagementClient.CreateMapConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMapConfig</summary>
        public void CreateMapConfig()
        {
            // Snippet: CreateMapConfig(string, MapConfig, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            MapConfig mapConfig = new MapConfig();
            // Make the request
            MapConfig response = mapManagementClient.CreateMapConfig(parent, mapConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateMapConfigAsync</summary>
        public async Task CreateMapConfigAsync()
        {
            // Snippet: CreateMapConfigAsync(string, MapConfig, CallSettings)
            // Additional: CreateMapConfigAsync(string, MapConfig, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            MapConfig mapConfig = new MapConfig();
            // Make the request
            MapConfig response = await mapManagementClient.CreateMapConfigAsync(parent, mapConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateMapConfig</summary>
        public void CreateMapConfigResourceNames()
        {
            // Snippet: CreateMapConfig(ProjectName, MapConfig, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            MapConfig mapConfig = new MapConfig();
            // Make the request
            MapConfig response = mapManagementClient.CreateMapConfig(parent, mapConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateMapConfigAsync</summary>
        public async Task CreateMapConfigResourceNamesAsync()
        {
            // Snippet: CreateMapConfigAsync(ProjectName, MapConfig, CallSettings)
            // Additional: CreateMapConfigAsync(ProjectName, MapConfig, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            MapConfig mapConfig = new MapConfig();
            // Make the request
            MapConfig response = await mapManagementClient.CreateMapConfigAsync(parent, mapConfig);
            // End snippet
        }

        /// <summary>Snippet for GetMapConfig</summary>
        public void GetMapConfigRequestObject()
        {
            // Snippet: GetMapConfig(GetMapConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            GetMapConfigRequest request = new GetMapConfigRequest
            {
                MapConfigName = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]"),
            };
            // Make the request
            MapConfig response = mapManagementClient.GetMapConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetMapConfigAsync</summary>
        public async Task GetMapConfigRequestObjectAsync()
        {
            // Snippet: GetMapConfigAsync(GetMapConfigRequest, CallSettings)
            // Additional: GetMapConfigAsync(GetMapConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetMapConfigRequest request = new GetMapConfigRequest
            {
                MapConfigName = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]"),
            };
            // Make the request
            MapConfig response = await mapManagementClient.GetMapConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMapConfig</summary>
        public void GetMapConfig()
        {
            // Snippet: GetMapConfig(string, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]";
            // Make the request
            MapConfig response = mapManagementClient.GetMapConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetMapConfigAsync</summary>
        public async Task GetMapConfigAsync()
        {
            // Snippet: GetMapConfigAsync(string, CallSettings)
            // Additional: GetMapConfigAsync(string, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]";
            // Make the request
            MapConfig response = await mapManagementClient.GetMapConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMapConfig</summary>
        public void GetMapConfigResourceNames()
        {
            // Snippet: GetMapConfig(MapConfigName, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            MapConfigName name = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]");
            // Make the request
            MapConfig response = mapManagementClient.GetMapConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetMapConfigAsync</summary>
        public async Task GetMapConfigResourceNamesAsync()
        {
            // Snippet: GetMapConfigAsync(MapConfigName, CallSettings)
            // Additional: GetMapConfigAsync(MapConfigName, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            MapConfigName name = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]");
            // Make the request
            MapConfig response = await mapManagementClient.GetMapConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMapConfigs</summary>
        public void ListMapConfigsRequestObject()
        {
            // Snippet: ListMapConfigs(ListMapConfigsRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            ListMapConfigsRequest request = new ListMapConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListMapConfigsResponse, MapConfig> response = mapManagementClient.ListMapConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MapConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMapConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMapConfigsAsync</summary>
        public async Task ListMapConfigsRequestObjectAsync()
        {
            // Snippet: ListMapConfigsAsync(ListMapConfigsRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListMapConfigsRequest request = new ListMapConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMapConfigsResponse, MapConfig> response = mapManagementClient.ListMapConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MapConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMapConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMapConfigs</summary>
        public void ListMapConfigs()
        {
            // Snippet: ListMapConfigs(string, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListMapConfigsResponse, MapConfig> response = mapManagementClient.ListMapConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MapConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMapConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMapConfigsAsync</summary>
        public async Task ListMapConfigsAsync()
        {
            // Snippet: ListMapConfigsAsync(string, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListMapConfigsResponse, MapConfig> response = mapManagementClient.ListMapConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MapConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMapConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMapConfigs</summary>
        public void ListMapConfigsResourceNames()
        {
            // Snippet: ListMapConfigs(ProjectName, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListMapConfigsResponse, MapConfig> response = mapManagementClient.ListMapConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MapConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMapConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMapConfigsAsync</summary>
        public async Task ListMapConfigsResourceNamesAsync()
        {
            // Snippet: ListMapConfigsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListMapConfigsResponse, MapConfig> response = mapManagementClient.ListMapConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MapConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMapConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateMapConfig</summary>
        public void UpdateMapConfigRequestObject()
        {
            // Snippet: UpdateMapConfig(UpdateMapConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            UpdateMapConfigRequest request = new UpdateMapConfigRequest
            {
                MapConfig = new MapConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            MapConfig response = mapManagementClient.UpdateMapConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMapConfigAsync</summary>
        public async Task UpdateMapConfigRequestObjectAsync()
        {
            // Snippet: UpdateMapConfigAsync(UpdateMapConfigRequest, CallSettings)
            // Additional: UpdateMapConfigAsync(UpdateMapConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMapConfigRequest request = new UpdateMapConfigRequest
            {
                MapConfig = new MapConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            MapConfig response = await mapManagementClient.UpdateMapConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMapConfig</summary>
        public void UpdateMapConfig()
        {
            // Snippet: UpdateMapConfig(MapConfig, FieldMask, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            MapConfig mapConfig = new MapConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            MapConfig response = mapManagementClient.UpdateMapConfig(mapConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateMapConfigAsync</summary>
        public async Task UpdateMapConfigAsync()
        {
            // Snippet: UpdateMapConfigAsync(MapConfig, FieldMask, CallSettings)
            // Additional: UpdateMapConfigAsync(MapConfig, FieldMask, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            MapConfig mapConfig = new MapConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            MapConfig response = await mapManagementClient.UpdateMapConfigAsync(mapConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapConfig</summary>
        public void DeleteMapConfigRequestObject()
        {
            // Snippet: DeleteMapConfig(DeleteMapConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            DeleteMapConfigRequest request = new DeleteMapConfigRequest
            {
                MapConfigName = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]"),
                Force = false,
            };
            // Make the request
            mapManagementClient.DeleteMapConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapConfigAsync</summary>
        public async Task DeleteMapConfigRequestObjectAsync()
        {
            // Snippet: DeleteMapConfigAsync(DeleteMapConfigRequest, CallSettings)
            // Additional: DeleteMapConfigAsync(DeleteMapConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMapConfigRequest request = new DeleteMapConfigRequest
            {
                MapConfigName = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]"),
                Force = false,
            };
            // Make the request
            await mapManagementClient.DeleteMapConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapConfig</summary>
        public void DeleteMapConfig()
        {
            // Snippet: DeleteMapConfig(string, bool, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]";
            bool force = false;
            // Make the request
            mapManagementClient.DeleteMapConfig(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapConfigAsync</summary>
        public async Task DeleteMapConfigAsync()
        {
            // Snippet: DeleteMapConfigAsync(string, bool, CallSettings)
            // Additional: DeleteMapConfigAsync(string, bool, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]";
            bool force = false;
            // Make the request
            await mapManagementClient.DeleteMapConfigAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapConfig</summary>
        public void DeleteMapConfigResourceNames()
        {
            // Snippet: DeleteMapConfig(MapConfigName, bool, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            MapConfigName name = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]");
            bool force = false;
            // Make the request
            mapManagementClient.DeleteMapConfig(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapConfigAsync</summary>
        public async Task DeleteMapConfigResourceNamesAsync()
        {
            // Snippet: DeleteMapConfigAsync(MapConfigName, bool, CallSettings)
            // Additional: DeleteMapConfigAsync(MapConfigName, bool, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            MapConfigName name = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]");
            bool force = false;
            // Make the request
            await mapManagementClient.DeleteMapConfigAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for CreateStyleConfig</summary>
        public void CreateStyleConfigRequestObject()
        {
            // Snippet: CreateStyleConfig(CreateStyleConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            CreateStyleConfigRequest request = new CreateStyleConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                StyleConfig = new StyleConfig(),
            };
            // Make the request
            StyleConfig response = mapManagementClient.CreateStyleConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateStyleConfigAsync</summary>
        public async Task CreateStyleConfigRequestObjectAsync()
        {
            // Snippet: CreateStyleConfigAsync(CreateStyleConfigRequest, CallSettings)
            // Additional: CreateStyleConfigAsync(CreateStyleConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateStyleConfigRequest request = new CreateStyleConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                StyleConfig = new StyleConfig(),
            };
            // Make the request
            StyleConfig response = await mapManagementClient.CreateStyleConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateStyleConfig</summary>
        public void CreateStyleConfig()
        {
            // Snippet: CreateStyleConfig(string, StyleConfig, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            StyleConfig styleConfig = new StyleConfig();
            // Make the request
            StyleConfig response = mapManagementClient.CreateStyleConfig(parent, styleConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateStyleConfigAsync</summary>
        public async Task CreateStyleConfigAsync()
        {
            // Snippet: CreateStyleConfigAsync(string, StyleConfig, CallSettings)
            // Additional: CreateStyleConfigAsync(string, StyleConfig, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            StyleConfig styleConfig = new StyleConfig();
            // Make the request
            StyleConfig response = await mapManagementClient.CreateStyleConfigAsync(parent, styleConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateStyleConfig</summary>
        public void CreateStyleConfigResourceNames()
        {
            // Snippet: CreateStyleConfig(ProjectName, StyleConfig, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            StyleConfig styleConfig = new StyleConfig();
            // Make the request
            StyleConfig response = mapManagementClient.CreateStyleConfig(parent, styleConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateStyleConfigAsync</summary>
        public async Task CreateStyleConfigResourceNamesAsync()
        {
            // Snippet: CreateStyleConfigAsync(ProjectName, StyleConfig, CallSettings)
            // Additional: CreateStyleConfigAsync(ProjectName, StyleConfig, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            StyleConfig styleConfig = new StyleConfig();
            // Make the request
            StyleConfig response = await mapManagementClient.CreateStyleConfigAsync(parent, styleConfig);
            // End snippet
        }

        /// <summary>Snippet for GetStyleConfig</summary>
        public void GetStyleConfigRequestObject()
        {
            // Snippet: GetStyleConfig(GetStyleConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            GetStyleConfigRequest request = new GetStyleConfigRequest
            {
                StyleConfigName = StyleConfigName.FromProjectStyleConfig("[PROJECT]", "[STYLE_CONFIG]"),
            };
            // Make the request
            StyleConfig response = mapManagementClient.GetStyleConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetStyleConfigAsync</summary>
        public async Task GetStyleConfigRequestObjectAsync()
        {
            // Snippet: GetStyleConfigAsync(GetStyleConfigRequest, CallSettings)
            // Additional: GetStyleConfigAsync(GetStyleConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetStyleConfigRequest request = new GetStyleConfigRequest
            {
                StyleConfigName = StyleConfigName.FromProjectStyleConfig("[PROJECT]", "[STYLE_CONFIG]"),
            };
            // Make the request
            StyleConfig response = await mapManagementClient.GetStyleConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStyleConfig</summary>
        public void GetStyleConfig()
        {
            // Snippet: GetStyleConfig(string, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/styleConfigs/[STYLE_CONFIG]";
            // Make the request
            StyleConfig response = mapManagementClient.GetStyleConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetStyleConfigAsync</summary>
        public async Task GetStyleConfigAsync()
        {
            // Snippet: GetStyleConfigAsync(string, CallSettings)
            // Additional: GetStyleConfigAsync(string, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/styleConfigs/[STYLE_CONFIG]";
            // Make the request
            StyleConfig response = await mapManagementClient.GetStyleConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStyleConfig</summary>
        public void GetStyleConfigResourceNames()
        {
            // Snippet: GetStyleConfig(StyleConfigName, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            StyleConfigName name = StyleConfigName.FromProjectStyleConfig("[PROJECT]", "[STYLE_CONFIG]");
            // Make the request
            StyleConfig response = mapManagementClient.GetStyleConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetStyleConfigAsync</summary>
        public async Task GetStyleConfigResourceNamesAsync()
        {
            // Snippet: GetStyleConfigAsync(StyleConfigName, CallSettings)
            // Additional: GetStyleConfigAsync(StyleConfigName, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            StyleConfigName name = StyleConfigName.FromProjectStyleConfig("[PROJECT]", "[STYLE_CONFIG]");
            // Make the request
            StyleConfig response = await mapManagementClient.GetStyleConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListStyleConfigs</summary>
        public void ListStyleConfigsRequestObject()
        {
            // Snippet: ListStyleConfigs(ListStyleConfigsRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            ListStyleConfigsRequest request = new ListStyleConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
                View = StyleConfigView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListStyleConfigsResponse, StyleConfig> response = mapManagementClient.ListStyleConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StyleConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStyleConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StyleConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StyleConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StyleConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStyleConfigsAsync</summary>
        public async Task ListStyleConfigsRequestObjectAsync()
        {
            // Snippet: ListStyleConfigsAsync(ListStyleConfigsRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListStyleConfigsRequest request = new ListStyleConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
                View = StyleConfigView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListStyleConfigsResponse, StyleConfig> response = mapManagementClient.ListStyleConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (StyleConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListStyleConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StyleConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StyleConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StyleConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStyleConfigs</summary>
        public void ListStyleConfigs()
        {
            // Snippet: ListStyleConfigs(string, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListStyleConfigsResponse, StyleConfig> response = mapManagementClient.ListStyleConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StyleConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStyleConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StyleConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StyleConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StyleConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStyleConfigsAsync</summary>
        public async Task ListStyleConfigsAsync()
        {
            // Snippet: ListStyleConfigsAsync(string, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListStyleConfigsResponse, StyleConfig> response = mapManagementClient.ListStyleConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (StyleConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListStyleConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StyleConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StyleConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StyleConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStyleConfigs</summary>
        public void ListStyleConfigsResourceNames()
        {
            // Snippet: ListStyleConfigs(ProjectName, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListStyleConfigsResponse, StyleConfig> response = mapManagementClient.ListStyleConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StyleConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStyleConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StyleConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StyleConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StyleConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStyleConfigsAsync</summary>
        public async Task ListStyleConfigsResourceNamesAsync()
        {
            // Snippet: ListStyleConfigsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListStyleConfigsResponse, StyleConfig> response = mapManagementClient.ListStyleConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (StyleConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListStyleConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StyleConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StyleConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StyleConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateStyleConfig</summary>
        public void UpdateStyleConfigRequestObject()
        {
            // Snippet: UpdateStyleConfig(UpdateStyleConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            UpdateStyleConfigRequest request = new UpdateStyleConfigRequest
            {
                StyleConfig = new StyleConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            StyleConfig response = mapManagementClient.UpdateStyleConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateStyleConfigAsync</summary>
        public async Task UpdateStyleConfigRequestObjectAsync()
        {
            // Snippet: UpdateStyleConfigAsync(UpdateStyleConfigRequest, CallSettings)
            // Additional: UpdateStyleConfigAsync(UpdateStyleConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            UpdateStyleConfigRequest request = new UpdateStyleConfigRequest
            {
                StyleConfig = new StyleConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            StyleConfig response = await mapManagementClient.UpdateStyleConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateStyleConfig</summary>
        public void UpdateStyleConfig()
        {
            // Snippet: UpdateStyleConfig(StyleConfig, FieldMask, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            StyleConfig styleConfig = new StyleConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            StyleConfig response = mapManagementClient.UpdateStyleConfig(styleConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateStyleConfigAsync</summary>
        public async Task UpdateStyleConfigAsync()
        {
            // Snippet: UpdateStyleConfigAsync(StyleConfig, FieldMask, CallSettings)
            // Additional: UpdateStyleConfigAsync(StyleConfig, FieldMask, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            StyleConfig styleConfig = new StyleConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            StyleConfig response = await mapManagementClient.UpdateStyleConfigAsync(styleConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteStyleConfig</summary>
        public void DeleteStyleConfigRequestObject()
        {
            // Snippet: DeleteStyleConfig(DeleteStyleConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            DeleteStyleConfigRequest request = new DeleteStyleConfigRequest
            {
                StyleConfigName = StyleConfigName.FromProjectStyleConfig("[PROJECT]", "[STYLE_CONFIG]"),
            };
            // Make the request
            mapManagementClient.DeleteStyleConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteStyleConfigAsync</summary>
        public async Task DeleteStyleConfigRequestObjectAsync()
        {
            // Snippet: DeleteStyleConfigAsync(DeleteStyleConfigRequest, CallSettings)
            // Additional: DeleteStyleConfigAsync(DeleteStyleConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            DeleteStyleConfigRequest request = new DeleteStyleConfigRequest
            {
                StyleConfigName = StyleConfigName.FromProjectStyleConfig("[PROJECT]", "[STYLE_CONFIG]"),
            };
            // Make the request
            await mapManagementClient.DeleteStyleConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteStyleConfig</summary>
        public void DeleteStyleConfig()
        {
            // Snippet: DeleteStyleConfig(string, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/styleConfigs/[STYLE_CONFIG]";
            // Make the request
            mapManagementClient.DeleteStyleConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStyleConfigAsync</summary>
        public async Task DeleteStyleConfigAsync()
        {
            // Snippet: DeleteStyleConfigAsync(string, CallSettings)
            // Additional: DeleteStyleConfigAsync(string, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/styleConfigs/[STYLE_CONFIG]";
            // Make the request
            await mapManagementClient.DeleteStyleConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStyleConfig</summary>
        public void DeleteStyleConfigResourceNames()
        {
            // Snippet: DeleteStyleConfig(StyleConfigName, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            StyleConfigName name = StyleConfigName.FromProjectStyleConfig("[PROJECT]", "[STYLE_CONFIG]");
            // Make the request
            mapManagementClient.DeleteStyleConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStyleConfigAsync</summary>
        public async Task DeleteStyleConfigResourceNamesAsync()
        {
            // Snippet: DeleteStyleConfigAsync(StyleConfigName, CallSettings)
            // Additional: DeleteStyleConfigAsync(StyleConfigName, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            StyleConfigName name = StyleConfigName.FromProjectStyleConfig("[PROJECT]", "[STYLE_CONFIG]");
            // Make the request
            await mapManagementClient.DeleteStyleConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMapContextConfig</summary>
        public void CreateMapContextConfigRequestObject()
        {
            // Snippet: CreateMapContextConfig(CreateMapContextConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            CreateMapContextConfigRequest request = new CreateMapContextConfigRequest
            {
                ParentAsMapConfigName = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]"),
                MapContextConfig = new MapContextConfig(),
            };
            // Make the request
            MapContextConfig response = mapManagementClient.CreateMapContextConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMapContextConfigAsync</summary>
        public async Task CreateMapContextConfigRequestObjectAsync()
        {
            // Snippet: CreateMapContextConfigAsync(CreateMapContextConfigRequest, CallSettings)
            // Additional: CreateMapContextConfigAsync(CreateMapContextConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateMapContextConfigRequest request = new CreateMapContextConfigRequest
            {
                ParentAsMapConfigName = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]"),
                MapContextConfig = new MapContextConfig(),
            };
            // Make the request
            MapContextConfig response = await mapManagementClient.CreateMapContextConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMapContextConfig</summary>
        public void CreateMapContextConfig()
        {
            // Snippet: CreateMapContextConfig(string, MapContextConfig, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]";
            MapContextConfig mapContextConfig = new MapContextConfig();
            // Make the request
            MapContextConfig response = mapManagementClient.CreateMapContextConfig(parent, mapContextConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateMapContextConfigAsync</summary>
        public async Task CreateMapContextConfigAsync()
        {
            // Snippet: CreateMapContextConfigAsync(string, MapContextConfig, CallSettings)
            // Additional: CreateMapContextConfigAsync(string, MapContextConfig, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]";
            MapContextConfig mapContextConfig = new MapContextConfig();
            // Make the request
            MapContextConfig response = await mapManagementClient.CreateMapContextConfigAsync(parent, mapContextConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateMapContextConfig</summary>
        public void CreateMapContextConfigResourceNames()
        {
            // Snippet: CreateMapContextConfig(MapConfigName, MapContextConfig, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            MapConfigName parent = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]");
            MapContextConfig mapContextConfig = new MapContextConfig();
            // Make the request
            MapContextConfig response = mapManagementClient.CreateMapContextConfig(parent, mapContextConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateMapContextConfigAsync</summary>
        public async Task CreateMapContextConfigResourceNamesAsync()
        {
            // Snippet: CreateMapContextConfigAsync(MapConfigName, MapContextConfig, CallSettings)
            // Additional: CreateMapContextConfigAsync(MapConfigName, MapContextConfig, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            MapConfigName parent = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]");
            MapContextConfig mapContextConfig = new MapContextConfig();
            // Make the request
            MapContextConfig response = await mapManagementClient.CreateMapContextConfigAsync(parent, mapContextConfig);
            // End snippet
        }

        /// <summary>Snippet for GetMapContextConfig</summary>
        public void GetMapContextConfigRequestObject()
        {
            // Snippet: GetMapContextConfig(GetMapContextConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            GetMapContextConfigRequest request = new GetMapContextConfigRequest
            {
                MapContextConfigName = MapContextConfigName.FromProjectMapConfigMapContextConfig("[PROJECT]", "[MAP_CONFIG]", "[MAP_CONTEXT_CONFIG]"),
            };
            // Make the request
            MapContextConfig response = mapManagementClient.GetMapContextConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetMapContextConfigAsync</summary>
        public async Task GetMapContextConfigRequestObjectAsync()
        {
            // Snippet: GetMapContextConfigAsync(GetMapContextConfigRequest, CallSettings)
            // Additional: GetMapContextConfigAsync(GetMapContextConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetMapContextConfigRequest request = new GetMapContextConfigRequest
            {
                MapContextConfigName = MapContextConfigName.FromProjectMapConfigMapContextConfig("[PROJECT]", "[MAP_CONFIG]", "[MAP_CONTEXT_CONFIG]"),
            };
            // Make the request
            MapContextConfig response = await mapManagementClient.GetMapContextConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMapContextConfig</summary>
        public void GetMapContextConfig()
        {
            // Snippet: GetMapContextConfig(string, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]/mapContextConfigs/[MAP_CONTEXT_CONFIG]";
            // Make the request
            MapContextConfig response = mapManagementClient.GetMapContextConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetMapContextConfigAsync</summary>
        public async Task GetMapContextConfigAsync()
        {
            // Snippet: GetMapContextConfigAsync(string, CallSettings)
            // Additional: GetMapContextConfigAsync(string, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]/mapContextConfigs/[MAP_CONTEXT_CONFIG]";
            // Make the request
            MapContextConfig response = await mapManagementClient.GetMapContextConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMapContextConfig</summary>
        public void GetMapContextConfigResourceNames()
        {
            // Snippet: GetMapContextConfig(MapContextConfigName, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            MapContextConfigName name = MapContextConfigName.FromProjectMapConfigMapContextConfig("[PROJECT]", "[MAP_CONFIG]", "[MAP_CONTEXT_CONFIG]");
            // Make the request
            MapContextConfig response = mapManagementClient.GetMapContextConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetMapContextConfigAsync</summary>
        public async Task GetMapContextConfigResourceNamesAsync()
        {
            // Snippet: GetMapContextConfigAsync(MapContextConfigName, CallSettings)
            // Additional: GetMapContextConfigAsync(MapContextConfigName, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            MapContextConfigName name = MapContextConfigName.FromProjectMapConfigMapContextConfig("[PROJECT]", "[MAP_CONFIG]", "[MAP_CONTEXT_CONFIG]");
            // Make the request
            MapContextConfig response = await mapManagementClient.GetMapContextConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMapContextConfigs</summary>
        public void ListMapContextConfigsRequestObject()
        {
            // Snippet: ListMapContextConfigs(ListMapContextConfigsRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            ListMapContextConfigsRequest request = new ListMapContextConfigsRequest
            {
                ParentAsMapConfigName = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]"),
            };
            // Make the request
            PagedEnumerable<ListMapContextConfigsResponse, MapContextConfig> response = mapManagementClient.ListMapContextConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MapContextConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMapContextConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapContextConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapContextConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapContextConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMapContextConfigsAsync</summary>
        public async Task ListMapContextConfigsRequestObjectAsync()
        {
            // Snippet: ListMapContextConfigsAsync(ListMapContextConfigsRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListMapContextConfigsRequest request = new ListMapContextConfigsRequest
            {
                ParentAsMapConfigName = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMapContextConfigsResponse, MapContextConfig> response = mapManagementClient.ListMapContextConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MapContextConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMapContextConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapContextConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapContextConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapContextConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMapContextConfigs</summary>
        public void ListMapContextConfigs()
        {
            // Snippet: ListMapContextConfigs(string, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]";
            // Make the request
            PagedEnumerable<ListMapContextConfigsResponse, MapContextConfig> response = mapManagementClient.ListMapContextConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MapContextConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMapContextConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapContextConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapContextConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapContextConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMapContextConfigsAsync</summary>
        public async Task ListMapContextConfigsAsync()
        {
            // Snippet: ListMapContextConfigsAsync(string, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]";
            // Make the request
            PagedAsyncEnumerable<ListMapContextConfigsResponse, MapContextConfig> response = mapManagementClient.ListMapContextConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MapContextConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMapContextConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapContextConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapContextConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapContextConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMapContextConfigs</summary>
        public void ListMapContextConfigsResourceNames()
        {
            // Snippet: ListMapContextConfigs(MapConfigName, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            MapConfigName parent = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]");
            // Make the request
            PagedEnumerable<ListMapContextConfigsResponse, MapContextConfig> response = mapManagementClient.ListMapContextConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MapContextConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMapContextConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapContextConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapContextConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapContextConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMapContextConfigsAsync</summary>
        public async Task ListMapContextConfigsResourceNamesAsync()
        {
            // Snippet: ListMapContextConfigsAsync(MapConfigName, string, int?, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            MapConfigName parent = MapConfigName.FromProjectMapConfig("[PROJECT]", "[MAP_CONFIG]");
            // Make the request
            PagedAsyncEnumerable<ListMapContextConfigsResponse, MapContextConfig> response = mapManagementClient.ListMapContextConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MapContextConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMapContextConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MapContextConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MapContextConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MapContextConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateMapContextConfig</summary>
        public void UpdateMapContextConfigRequestObject()
        {
            // Snippet: UpdateMapContextConfig(UpdateMapContextConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            UpdateMapContextConfigRequest request = new UpdateMapContextConfigRequest
            {
                MapContextConfig = new MapContextConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            MapContextConfig response = mapManagementClient.UpdateMapContextConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMapContextConfigAsync</summary>
        public async Task UpdateMapContextConfigRequestObjectAsync()
        {
            // Snippet: UpdateMapContextConfigAsync(UpdateMapContextConfigRequest, CallSettings)
            // Additional: UpdateMapContextConfigAsync(UpdateMapContextConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMapContextConfigRequest request = new UpdateMapContextConfigRequest
            {
                MapContextConfig = new MapContextConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            MapContextConfig response = await mapManagementClient.UpdateMapContextConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMapContextConfig</summary>
        public void UpdateMapContextConfig()
        {
            // Snippet: UpdateMapContextConfig(MapContextConfig, FieldMask, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            MapContextConfig mapContextConfig = new MapContextConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            MapContextConfig response = mapManagementClient.UpdateMapContextConfig(mapContextConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateMapContextConfigAsync</summary>
        public async Task UpdateMapContextConfigAsync()
        {
            // Snippet: UpdateMapContextConfigAsync(MapContextConfig, FieldMask, CallSettings)
            // Additional: UpdateMapContextConfigAsync(MapContextConfig, FieldMask, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            MapContextConfig mapContextConfig = new MapContextConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            MapContextConfig response = await mapManagementClient.UpdateMapContextConfigAsync(mapContextConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapContextConfig</summary>
        public void DeleteMapContextConfigRequestObject()
        {
            // Snippet: DeleteMapContextConfig(DeleteMapContextConfigRequest, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            DeleteMapContextConfigRequest request = new DeleteMapContextConfigRequest
            {
                MapContextConfigName = MapContextConfigName.FromProjectMapConfigMapContextConfig("[PROJECT]", "[MAP_CONFIG]", "[MAP_CONTEXT_CONFIG]"),
            };
            // Make the request
            mapManagementClient.DeleteMapContextConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapContextConfigAsync</summary>
        public async Task DeleteMapContextConfigRequestObjectAsync()
        {
            // Snippet: DeleteMapContextConfigAsync(DeleteMapContextConfigRequest, CallSettings)
            // Additional: DeleteMapContextConfigAsync(DeleteMapContextConfigRequest, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMapContextConfigRequest request = new DeleteMapContextConfigRequest
            {
                MapContextConfigName = MapContextConfigName.FromProjectMapConfigMapContextConfig("[PROJECT]", "[MAP_CONFIG]", "[MAP_CONTEXT_CONFIG]"),
            };
            // Make the request
            await mapManagementClient.DeleteMapContextConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapContextConfig</summary>
        public void DeleteMapContextConfig()
        {
            // Snippet: DeleteMapContextConfig(string, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]/mapContextConfigs/[MAP_CONTEXT_CONFIG]";
            // Make the request
            mapManagementClient.DeleteMapContextConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapContextConfigAsync</summary>
        public async Task DeleteMapContextConfigAsync()
        {
            // Snippet: DeleteMapContextConfigAsync(string, CallSettings)
            // Additional: DeleteMapContextConfigAsync(string, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/mapConfigs/[MAP_CONFIG]/mapContextConfigs/[MAP_CONTEXT_CONFIG]";
            // Make the request
            await mapManagementClient.DeleteMapContextConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapContextConfig</summary>
        public void DeleteMapContextConfigResourceNames()
        {
            // Snippet: DeleteMapContextConfig(MapContextConfigName, CallSettings)
            // Create client
            MapManagementClient mapManagementClient = MapManagementClient.Create();
            // Initialize request argument(s)
            MapContextConfigName name = MapContextConfigName.FromProjectMapConfigMapContextConfig("[PROJECT]", "[MAP_CONFIG]", "[MAP_CONTEXT_CONFIG]");
            // Make the request
            mapManagementClient.DeleteMapContextConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMapContextConfigAsync</summary>
        public async Task DeleteMapContextConfigResourceNamesAsync()
        {
            // Snippet: DeleteMapContextConfigAsync(MapContextConfigName, CallSettings)
            // Additional: DeleteMapContextConfigAsync(MapContextConfigName, CancellationToken)
            // Create client
            MapManagementClient mapManagementClient = await MapManagementClient.CreateAsync();
            // Initialize request argument(s)
            MapContextConfigName name = MapContextConfigName.FromProjectMapConfigMapContextConfig("[PROJECT]", "[MAP_CONFIG]", "[MAP_CONTEXT_CONFIG]");
            // Make the request
            await mapManagementClient.DeleteMapContextConfigAsync(name);
            // End snippet
        }
    }
}
