// Copyright 2024 Google LLC
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
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedServingConfigServiceClientSnippets
    {
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
                ServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
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
                ServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/servingConfigs/[SERVING_CONFIG]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/servingConfigs/[SERVING_CONFIG]";
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
            ServingConfigName name = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]");
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
            ServingConfigName name = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]");
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
                ParentAsEngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
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
                ParentAsEngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
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
        public void ListServingConfigsResourceNames1()
        {
            // Snippet: ListServingConfigs(EngineName, string, int?, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            EngineName parent = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
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
        public async Task ListServingConfigsResourceNames1Async()
        {
            // Snippet: ListServingConfigsAsync(EngineName, string, int?, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            EngineName parent = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
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
        public void ListServingConfigsResourceNames2()
        {
            // Snippet: ListServingConfigs(DataStoreName, string, int?, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
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
        public async Task ListServingConfigsResourceNames2Async()
        {
            // Snippet: ListServingConfigsAsync(DataStoreName, string, int?, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
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
    }
}
