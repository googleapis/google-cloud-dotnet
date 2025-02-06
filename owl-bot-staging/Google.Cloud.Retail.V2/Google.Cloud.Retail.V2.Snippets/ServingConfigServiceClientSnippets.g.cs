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
    using Google.Cloud.Retail.V2;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedServingConfigServiceClientSnippets
    {
        /// <summary>Snippet for CreateServingConfig</summary>
        public void CreateServingConfigRequestObject()
        {
            // Snippet: CreateServingConfig(CreateServingConfigRequest, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            CreateServingConfigRequest request = new CreateServingConfigRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                ServingConfig = new ServingConfig(),
                ServingConfigId = "",
            };
            // Make the request
            ServingConfig response = servingConfigServiceClient.CreateServingConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServingConfigAsync</summary>
        public async Task CreateServingConfigRequestObjectAsync()
        {
            // Snippet: CreateServingConfigAsync(CreateServingConfigRequest, CallSettings)
            // Additional: CreateServingConfigAsync(CreateServingConfigRequest, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateServingConfigRequest request = new CreateServingConfigRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                ServingConfig = new ServingConfig(),
                ServingConfigId = "",
            };
            // Make the request
            ServingConfig response = await servingConfigServiceClient.CreateServingConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServingConfig</summary>
        public void CreateServingConfig()
        {
            // Snippet: CreateServingConfig(string, ServingConfig, string, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            ServingConfig servingConfig = new ServingConfig();
            string servingConfigId = "";
            // Make the request
            ServingConfig response = servingConfigServiceClient.CreateServingConfig(parent, servingConfig, servingConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateServingConfigAsync</summary>
        public async Task CreateServingConfigAsync()
        {
            // Snippet: CreateServingConfigAsync(string, ServingConfig, string, CallSettings)
            // Additional: CreateServingConfigAsync(string, ServingConfig, string, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            ServingConfig servingConfig = new ServingConfig();
            string servingConfigId = "";
            // Make the request
            ServingConfig response = await servingConfigServiceClient.CreateServingConfigAsync(parent, servingConfig, servingConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateServingConfig</summary>
        public void CreateServingConfigResourceNames()
        {
            // Snippet: CreateServingConfig(CatalogName, ServingConfig, string, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            ServingConfig servingConfig = new ServingConfig();
            string servingConfigId = "";
            // Make the request
            ServingConfig response = servingConfigServiceClient.CreateServingConfig(parent, servingConfig, servingConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateServingConfigAsync</summary>
        public async Task CreateServingConfigResourceNamesAsync()
        {
            // Snippet: CreateServingConfigAsync(CatalogName, ServingConfig, string, CallSettings)
            // Additional: CreateServingConfigAsync(CatalogName, ServingConfig, string, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            ServingConfig servingConfig = new ServingConfig();
            string servingConfigId = "";
            // Make the request
            ServingConfig response = await servingConfigServiceClient.CreateServingConfigAsync(parent, servingConfig, servingConfigId);
            // End snippet
        }

        /// <summary>Snippet for DeleteServingConfig</summary>
        public void DeleteServingConfigRequestObject()
        {
            // Snippet: DeleteServingConfig(DeleteServingConfigRequest, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            DeleteServingConfigRequest request = new DeleteServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            // Make the request
            servingConfigServiceClient.DeleteServingConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServingConfigAsync</summary>
        public async Task DeleteServingConfigRequestObjectAsync()
        {
            // Snippet: DeleteServingConfigAsync(DeleteServingConfigRequest, CallSettings)
            // Additional: DeleteServingConfigAsync(DeleteServingConfigRequest, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServingConfigRequest request = new DeleteServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            // Make the request
            await servingConfigServiceClient.DeleteServingConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServingConfig</summary>
        public void DeleteServingConfig()
        {
            // Snippet: DeleteServingConfig(string, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/servingConfigs/[SERVING_CONFIG]";
            // Make the request
            servingConfigServiceClient.DeleteServingConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServingConfigAsync</summary>
        public async Task DeleteServingConfigAsync()
        {
            // Snippet: DeleteServingConfigAsync(string, CallSettings)
            // Additional: DeleteServingConfigAsync(string, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/servingConfigs/[SERVING_CONFIG]";
            // Make the request
            await servingConfigServiceClient.DeleteServingConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServingConfig</summary>
        public void DeleteServingConfigResourceNames()
        {
            // Snippet: DeleteServingConfig(ServingConfigName, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            ServingConfigName name = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]");
            // Make the request
            servingConfigServiceClient.DeleteServingConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServingConfigAsync</summary>
        public async Task DeleteServingConfigResourceNamesAsync()
        {
            // Snippet: DeleteServingConfigAsync(ServingConfigName, CallSettings)
            // Additional: DeleteServingConfigAsync(ServingConfigName, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServingConfigName name = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]");
            // Make the request
            await servingConfigServiceClient.DeleteServingConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateServingConfig</summary>
        public void UpdateServingConfigRequestObject()
        {
            // Snippet: UpdateServingConfig(UpdateServingConfigRequest, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            UpdateServingConfigRequest request = new UpdateServingConfigRequest
            {
                ServingConfig = new ServingConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ServingConfig response = servingConfigServiceClient.UpdateServingConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateServingConfigAsync</summary>
        public async Task UpdateServingConfigRequestObjectAsync()
        {
            // Snippet: UpdateServingConfigAsync(UpdateServingConfigRequest, CallSettings)
            // Additional: UpdateServingConfigAsync(UpdateServingConfigRequest, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServingConfigRequest request = new UpdateServingConfigRequest
            {
                ServingConfig = new ServingConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ServingConfig response = await servingConfigServiceClient.UpdateServingConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateServingConfig</summary>
        public void UpdateServingConfig()
        {
            // Snippet: UpdateServingConfig(ServingConfig, FieldMask, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            ServingConfig servingConfig = new ServingConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ServingConfig response = servingConfigServiceClient.UpdateServingConfig(servingConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateServingConfigAsync</summary>
        public async Task UpdateServingConfigAsync()
        {
            // Snippet: UpdateServingConfigAsync(ServingConfig, FieldMask, CallSettings)
            // Additional: UpdateServingConfigAsync(ServingConfig, FieldMask, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServingConfig servingConfig = new ServingConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ServingConfig response = await servingConfigServiceClient.UpdateServingConfigAsync(servingConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetServingConfig</summary>
        public void GetServingConfigRequestObject()
        {
            // Snippet: GetServingConfig(GetServingConfigRequest, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            GetServingConfigRequest request = new GetServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            // Make the request
            ServingConfig response = servingConfigServiceClient.GetServingConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetServingConfigAsync</summary>
        public async Task GetServingConfigRequestObjectAsync()
        {
            // Snippet: GetServingConfigAsync(GetServingConfigRequest, CallSettings)
            // Additional: GetServingConfigAsync(GetServingConfigRequest, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServingConfigRequest request = new GetServingConfigRequest
            {
                ServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
            };
            // Make the request
            ServingConfig response = await servingConfigServiceClient.GetServingConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServingConfig</summary>
        public void GetServingConfig()
        {
            // Snippet: GetServingConfig(string, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/servingConfigs/[SERVING_CONFIG]";
            // Make the request
            ServingConfig response = servingConfigServiceClient.GetServingConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetServingConfigAsync</summary>
        public async Task GetServingConfigAsync()
        {
            // Snippet: GetServingConfigAsync(string, CallSettings)
            // Additional: GetServingConfigAsync(string, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/servingConfigs/[SERVING_CONFIG]";
            // Make the request
            ServingConfig response = await servingConfigServiceClient.GetServingConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServingConfig</summary>
        public void GetServingConfigResourceNames()
        {
            // Snippet: GetServingConfig(ServingConfigName, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            ServingConfigName name = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]");
            // Make the request
            ServingConfig response = servingConfigServiceClient.GetServingConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetServingConfigAsync</summary>
        public async Task GetServingConfigResourceNamesAsync()
        {
            // Snippet: GetServingConfigAsync(ServingConfigName, CallSettings)
            // Additional: GetServingConfigAsync(ServingConfigName, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServingConfigName name = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]");
            // Make the request
            ServingConfig response = await servingConfigServiceClient.GetServingConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListServingConfigs</summary>
        public void ListServingConfigsRequestObject()
        {
            // Snippet: ListServingConfigs(ListServingConfigsRequest, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            ListServingConfigsRequest request = new ListServingConfigsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            // Make the request
            PagedEnumerable<ListServingConfigsResponse, ServingConfig> response = servingConfigServiceClient.ListServingConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServingConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServingConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServingConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServingConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServingConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServingConfigsAsync</summary>
        public async Task ListServingConfigsRequestObjectAsync()
        {
            // Snippet: ListServingConfigsAsync(ListServingConfigsRequest, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListServingConfigsRequest request = new ListServingConfigsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListServingConfigsResponse, ServingConfig> response = servingConfigServiceClient.ListServingConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServingConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServingConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServingConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServingConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServingConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServingConfigs</summary>
        public void ListServingConfigs()
        {
            // Snippet: ListServingConfigs(string, string, int?, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            PagedEnumerable<ListServingConfigsResponse, ServingConfig> response = servingConfigServiceClient.ListServingConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServingConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServingConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServingConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServingConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServingConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServingConfigsAsync</summary>
        public async Task ListServingConfigsAsync()
        {
            // Snippet: ListServingConfigsAsync(string, string, int?, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            PagedAsyncEnumerable<ListServingConfigsResponse, ServingConfig> response = servingConfigServiceClient.ListServingConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServingConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServingConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServingConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServingConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServingConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServingConfigs</summary>
        public void ListServingConfigsResourceNames()
        {
            // Snippet: ListServingConfigs(CatalogName, string, int?, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            PagedEnumerable<ListServingConfigsResponse, ServingConfig> response = servingConfigServiceClient.ListServingConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServingConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServingConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServingConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServingConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServingConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServingConfigsAsync</summary>
        public async Task ListServingConfigsResourceNamesAsync()
        {
            // Snippet: ListServingConfigsAsync(CatalogName, string, int?, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            PagedAsyncEnumerable<ListServingConfigsResponse, ServingConfig> response = servingConfigServiceClient.ListServingConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServingConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServingConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServingConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServingConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServingConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AddControl</summary>
        public void AddControlRequestObject()
        {
            // Snippet: AddControl(AddControlRequest, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            AddControlRequest request = new AddControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                ControlId = "",
            };
            // Make the request
            ServingConfig response = servingConfigServiceClient.AddControl(request);
            // End snippet
        }

        /// <summary>Snippet for AddControlAsync</summary>
        public async Task AddControlRequestObjectAsync()
        {
            // Snippet: AddControlAsync(AddControlRequest, CallSettings)
            // Additional: AddControlAsync(AddControlRequest, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddControlRequest request = new AddControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                ControlId = "",
            };
            // Make the request
            ServingConfig response = await servingConfigServiceClient.AddControlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddControl</summary>
        public void AddControl()
        {
            // Snippet: AddControl(string, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            string servingConfig = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/servingConfigs/[SERVING_CONFIG]";
            // Make the request
            ServingConfig response = servingConfigServiceClient.AddControl(servingConfig);
            // End snippet
        }

        /// <summary>Snippet for AddControlAsync</summary>
        public async Task AddControlAsync()
        {
            // Snippet: AddControlAsync(string, CallSettings)
            // Additional: AddControlAsync(string, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string servingConfig = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/servingConfigs/[SERVING_CONFIG]";
            // Make the request
            ServingConfig response = await servingConfigServiceClient.AddControlAsync(servingConfig);
            // End snippet
        }

        /// <summary>Snippet for AddControl</summary>
        public void AddControlResourceNames()
        {
            // Snippet: AddControl(ServingConfigName, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            ServingConfigName servingConfig = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]");
            // Make the request
            ServingConfig response = servingConfigServiceClient.AddControl(servingConfig);
            // End snippet
        }

        /// <summary>Snippet for AddControlAsync</summary>
        public async Task AddControlResourceNamesAsync()
        {
            // Snippet: AddControlAsync(ServingConfigName, CallSettings)
            // Additional: AddControlAsync(ServingConfigName, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServingConfigName servingConfig = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]");
            // Make the request
            ServingConfig response = await servingConfigServiceClient.AddControlAsync(servingConfig);
            // End snippet
        }

        /// <summary>Snippet for RemoveControl</summary>
        public void RemoveControlRequestObject()
        {
            // Snippet: RemoveControl(RemoveControlRequest, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            RemoveControlRequest request = new RemoveControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                ControlId = "",
            };
            // Make the request
            ServingConfig response = servingConfigServiceClient.RemoveControl(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveControlAsync</summary>
        public async Task RemoveControlRequestObjectAsync()
        {
            // Snippet: RemoveControlAsync(RemoveControlRequest, CallSettings)
            // Additional: RemoveControlAsync(RemoveControlRequest, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            RemoveControlRequest request = new RemoveControlRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]"),
                ControlId = "",
            };
            // Make the request
            ServingConfig response = await servingConfigServiceClient.RemoveControlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveControl</summary>
        public void RemoveControl()
        {
            // Snippet: RemoveControl(string, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            string servingConfig = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/servingConfigs/[SERVING_CONFIG]";
            // Make the request
            ServingConfig response = servingConfigServiceClient.RemoveControl(servingConfig);
            // End snippet
        }

        /// <summary>Snippet for RemoveControlAsync</summary>
        public async Task RemoveControlAsync()
        {
            // Snippet: RemoveControlAsync(string, CallSettings)
            // Additional: RemoveControlAsync(string, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string servingConfig = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/servingConfigs/[SERVING_CONFIG]";
            // Make the request
            ServingConfig response = await servingConfigServiceClient.RemoveControlAsync(servingConfig);
            // End snippet
        }

        /// <summary>Snippet for RemoveControl</summary>
        public void RemoveControlResourceNames()
        {
            // Snippet: RemoveControl(ServingConfigName, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            ServingConfigName servingConfig = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]");
            // Make the request
            ServingConfig response = servingConfigServiceClient.RemoveControl(servingConfig);
            // End snippet
        }

        /// <summary>Snippet for RemoveControlAsync</summary>
        public async Task RemoveControlResourceNamesAsync()
        {
            // Snippet: RemoveControlAsync(ServingConfigName, CallSettings)
            // Additional: RemoveControlAsync(ServingConfigName, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServingConfigName servingConfig = ServingConfigName.FromProjectLocationCatalogServingConfig("[PROJECT]", "[LOCATION]", "[CATALOG]", "[SERVING_CONFIG]");
            // Make the request
            ServingConfig response = await servingConfigServiceClient.RemoveControlAsync(servingConfig);
            // End snippet
        }
    }
}
