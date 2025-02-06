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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEntitySignalsMappingServiceClientSnippets
    {
        /// <summary>Snippet for GetEntitySignalsMapping</summary>
        public void GetEntitySignalsMappingRequestObject()
        {
            // Snippet: GetEntitySignalsMapping(GetEntitySignalsMappingRequest, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            GetEntitySignalsMappingRequest request = new GetEntitySignalsMappingRequest
            {
                EntitySignalsMappingName = EntitySignalsMappingName.FromNetworkCodeEntitySignalsMapping("[NETWORK_CODE]", "[ENTITY_SIGNALS_MAPPING]"),
            };
            // Make the request
            EntitySignalsMapping response = entitySignalsMappingServiceClient.GetEntitySignalsMapping(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntitySignalsMappingAsync</summary>
        public async Task GetEntitySignalsMappingRequestObjectAsync()
        {
            // Snippet: GetEntitySignalsMappingAsync(GetEntitySignalsMappingRequest, CallSettings)
            // Additional: GetEntitySignalsMappingAsync(GetEntitySignalsMappingRequest, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEntitySignalsMappingRequest request = new GetEntitySignalsMappingRequest
            {
                EntitySignalsMappingName = EntitySignalsMappingName.FromNetworkCodeEntitySignalsMapping("[NETWORK_CODE]", "[ENTITY_SIGNALS_MAPPING]"),
            };
            // Make the request
            EntitySignalsMapping response = await entitySignalsMappingServiceClient.GetEntitySignalsMappingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntitySignalsMapping</summary>
        public void GetEntitySignalsMapping()
        {
            // Snippet: GetEntitySignalsMapping(string, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/entitySignalsMappings/[ENTITY_SIGNALS_MAPPING]";
            // Make the request
            EntitySignalsMapping response = entitySignalsMappingServiceClient.GetEntitySignalsMapping(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntitySignalsMappingAsync</summary>
        public async Task GetEntitySignalsMappingAsync()
        {
            // Snippet: GetEntitySignalsMappingAsync(string, CallSettings)
            // Additional: GetEntitySignalsMappingAsync(string, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/entitySignalsMappings/[ENTITY_SIGNALS_MAPPING]";
            // Make the request
            EntitySignalsMapping response = await entitySignalsMappingServiceClient.GetEntitySignalsMappingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntitySignalsMapping</summary>
        public void GetEntitySignalsMappingResourceNames()
        {
            // Snippet: GetEntitySignalsMapping(EntitySignalsMappingName, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            EntitySignalsMappingName name = EntitySignalsMappingName.FromNetworkCodeEntitySignalsMapping("[NETWORK_CODE]", "[ENTITY_SIGNALS_MAPPING]");
            // Make the request
            EntitySignalsMapping response = entitySignalsMappingServiceClient.GetEntitySignalsMapping(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntitySignalsMappingAsync</summary>
        public async Task GetEntitySignalsMappingResourceNamesAsync()
        {
            // Snippet: GetEntitySignalsMappingAsync(EntitySignalsMappingName, CallSettings)
            // Additional: GetEntitySignalsMappingAsync(EntitySignalsMappingName, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntitySignalsMappingName name = EntitySignalsMappingName.FromNetworkCodeEntitySignalsMapping("[NETWORK_CODE]", "[ENTITY_SIGNALS_MAPPING]");
            // Make the request
            EntitySignalsMapping response = await entitySignalsMappingServiceClient.GetEntitySignalsMappingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEntitySignalsMappings</summary>
        public void ListEntitySignalsMappingsRequestObject()
        {
            // Snippet: ListEntitySignalsMappings(ListEntitySignalsMappingsRequest, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            ListEntitySignalsMappingsRequest request = new ListEntitySignalsMappingsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> response = entitySignalsMappingServiceClient.ListEntitySignalsMappings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntitySignalsMapping item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitySignalsMappingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntitySignalsMapping item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntitySignalsMapping> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntitySignalsMapping item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitySignalsMappingsAsync</summary>
        public async Task ListEntitySignalsMappingsRequestObjectAsync()
        {
            // Snippet: ListEntitySignalsMappingsAsync(ListEntitySignalsMappingsRequest, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEntitySignalsMappingsRequest request = new ListEntitySignalsMappingsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> response = entitySignalsMappingServiceClient.ListEntitySignalsMappingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntitySignalsMapping item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitySignalsMappingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntitySignalsMapping item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntitySignalsMapping> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntitySignalsMapping item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitySignalsMappings</summary>
        public void ListEntitySignalsMappings()
        {
            // Snippet: ListEntitySignalsMappings(string, string, int?, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> response = entitySignalsMappingServiceClient.ListEntitySignalsMappings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntitySignalsMapping item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitySignalsMappingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntitySignalsMapping item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntitySignalsMapping> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntitySignalsMapping item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitySignalsMappingsAsync</summary>
        public async Task ListEntitySignalsMappingsAsync()
        {
            // Snippet: ListEntitySignalsMappingsAsync(string, string, int?, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> response = entitySignalsMappingServiceClient.ListEntitySignalsMappingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntitySignalsMapping item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitySignalsMappingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntitySignalsMapping item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntitySignalsMapping> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntitySignalsMapping item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitySignalsMappings</summary>
        public void ListEntitySignalsMappingsResourceNames()
        {
            // Snippet: ListEntitySignalsMappings(NetworkName, string, int?, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> response = entitySignalsMappingServiceClient.ListEntitySignalsMappings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntitySignalsMapping item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitySignalsMappingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntitySignalsMapping item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntitySignalsMapping> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntitySignalsMapping item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitySignalsMappingsAsync</summary>
        public async Task ListEntitySignalsMappingsResourceNamesAsync()
        {
            // Snippet: ListEntitySignalsMappingsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> response = entitySignalsMappingServiceClient.ListEntitySignalsMappingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntitySignalsMapping item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitySignalsMappingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntitySignalsMapping item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntitySignalsMapping> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntitySignalsMapping item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateEntitySignalsMapping</summary>
        public void CreateEntitySignalsMappingRequestObject()
        {
            // Snippet: CreateEntitySignalsMapping(CreateEntitySignalsMappingRequest, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            CreateEntitySignalsMappingRequest request = new CreateEntitySignalsMappingRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                EntitySignalsMapping = new EntitySignalsMapping(),
            };
            // Make the request
            EntitySignalsMapping response = entitySignalsMappingServiceClient.CreateEntitySignalsMapping(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntitySignalsMappingAsync</summary>
        public async Task CreateEntitySignalsMappingRequestObjectAsync()
        {
            // Snippet: CreateEntitySignalsMappingAsync(CreateEntitySignalsMappingRequest, CallSettings)
            // Additional: CreateEntitySignalsMappingAsync(CreateEntitySignalsMappingRequest, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEntitySignalsMappingRequest request = new CreateEntitySignalsMappingRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                EntitySignalsMapping = new EntitySignalsMapping(),
            };
            // Make the request
            EntitySignalsMapping response = await entitySignalsMappingServiceClient.CreateEntitySignalsMappingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntitySignalsMapping</summary>
        public void CreateEntitySignalsMapping()
        {
            // Snippet: CreateEntitySignalsMapping(string, EntitySignalsMapping, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            EntitySignalsMapping entitySignalsMapping = new EntitySignalsMapping();
            // Make the request
            EntitySignalsMapping response = entitySignalsMappingServiceClient.CreateEntitySignalsMapping(parent, entitySignalsMapping);
            // End snippet
        }

        /// <summary>Snippet for CreateEntitySignalsMappingAsync</summary>
        public async Task CreateEntitySignalsMappingAsync()
        {
            // Snippet: CreateEntitySignalsMappingAsync(string, EntitySignalsMapping, CallSettings)
            // Additional: CreateEntitySignalsMappingAsync(string, EntitySignalsMapping, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            EntitySignalsMapping entitySignalsMapping = new EntitySignalsMapping();
            // Make the request
            EntitySignalsMapping response = await entitySignalsMappingServiceClient.CreateEntitySignalsMappingAsync(parent, entitySignalsMapping);
            // End snippet
        }

        /// <summary>Snippet for CreateEntitySignalsMapping</summary>
        public void CreateEntitySignalsMappingResourceNames()
        {
            // Snippet: CreateEntitySignalsMapping(NetworkName, EntitySignalsMapping, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            EntitySignalsMapping entitySignalsMapping = new EntitySignalsMapping();
            // Make the request
            EntitySignalsMapping response = entitySignalsMappingServiceClient.CreateEntitySignalsMapping(parent, entitySignalsMapping);
            // End snippet
        }

        /// <summary>Snippet for CreateEntitySignalsMappingAsync</summary>
        public async Task CreateEntitySignalsMappingResourceNamesAsync()
        {
            // Snippet: CreateEntitySignalsMappingAsync(NetworkName, EntitySignalsMapping, CallSettings)
            // Additional: CreateEntitySignalsMappingAsync(NetworkName, EntitySignalsMapping, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            EntitySignalsMapping entitySignalsMapping = new EntitySignalsMapping();
            // Make the request
            EntitySignalsMapping response = await entitySignalsMappingServiceClient.CreateEntitySignalsMappingAsync(parent, entitySignalsMapping);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntitySignalsMapping</summary>
        public void UpdateEntitySignalsMappingRequestObject()
        {
            // Snippet: UpdateEntitySignalsMapping(UpdateEntitySignalsMappingRequest, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            UpdateEntitySignalsMappingRequest request = new UpdateEntitySignalsMappingRequest
            {
                EntitySignalsMapping = new EntitySignalsMapping(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EntitySignalsMapping response = entitySignalsMappingServiceClient.UpdateEntitySignalsMapping(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntitySignalsMappingAsync</summary>
        public async Task UpdateEntitySignalsMappingRequestObjectAsync()
        {
            // Snippet: UpdateEntitySignalsMappingAsync(UpdateEntitySignalsMappingRequest, CallSettings)
            // Additional: UpdateEntitySignalsMappingAsync(UpdateEntitySignalsMappingRequest, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEntitySignalsMappingRequest request = new UpdateEntitySignalsMappingRequest
            {
                EntitySignalsMapping = new EntitySignalsMapping(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EntitySignalsMapping response = await entitySignalsMappingServiceClient.UpdateEntitySignalsMappingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntitySignalsMapping</summary>
        public void UpdateEntitySignalsMapping()
        {
            // Snippet: UpdateEntitySignalsMapping(EntitySignalsMapping, FieldMask, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            EntitySignalsMapping entitySignalsMapping = new EntitySignalsMapping();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EntitySignalsMapping response = entitySignalsMappingServiceClient.UpdateEntitySignalsMapping(entitySignalsMapping, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntitySignalsMappingAsync</summary>
        public async Task UpdateEntitySignalsMappingAsync()
        {
            // Snippet: UpdateEntitySignalsMappingAsync(EntitySignalsMapping, FieldMask, CallSettings)
            // Additional: UpdateEntitySignalsMappingAsync(EntitySignalsMapping, FieldMask, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntitySignalsMapping entitySignalsMapping = new EntitySignalsMapping();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EntitySignalsMapping response = await entitySignalsMappingServiceClient.UpdateEntitySignalsMappingAsync(entitySignalsMapping, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitySignalsMappings</summary>
        public void BatchCreateEntitySignalsMappingsRequestObject()
        {
            // Snippet: BatchCreateEntitySignalsMappings(BatchCreateEntitySignalsMappingsRequest, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateEntitySignalsMappingsRequest request = new BatchCreateEntitySignalsMappingsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateEntitySignalsMappingRequest(),
                },
            };
            // Make the request
            BatchCreateEntitySignalsMappingsResponse response = entitySignalsMappingServiceClient.BatchCreateEntitySignalsMappings(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitySignalsMappingsAsync</summary>
        public async Task BatchCreateEntitySignalsMappingsRequestObjectAsync()
        {
            // Snippet: BatchCreateEntitySignalsMappingsAsync(BatchCreateEntitySignalsMappingsRequest, CallSettings)
            // Additional: BatchCreateEntitySignalsMappingsAsync(BatchCreateEntitySignalsMappingsRequest, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateEntitySignalsMappingsRequest request = new BatchCreateEntitySignalsMappingsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateEntitySignalsMappingRequest(),
                },
            };
            // Make the request
            BatchCreateEntitySignalsMappingsResponse response = await entitySignalsMappingServiceClient.BatchCreateEntitySignalsMappingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitySignalsMappings</summary>
        public void BatchCreateEntitySignalsMappings()
        {
            // Snippet: BatchCreateEntitySignalsMappings(string, IEnumerable<CreateEntitySignalsMappingRequest>, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateEntitySignalsMappingRequest> requests = new CreateEntitySignalsMappingRequest[]
            {
                new CreateEntitySignalsMappingRequest(),
            };
            // Make the request
            BatchCreateEntitySignalsMappingsResponse response = entitySignalsMappingServiceClient.BatchCreateEntitySignalsMappings(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitySignalsMappingsAsync</summary>
        public async Task BatchCreateEntitySignalsMappingsAsync()
        {
            // Snippet: BatchCreateEntitySignalsMappingsAsync(string, IEnumerable<CreateEntitySignalsMappingRequest>, CallSettings)
            // Additional: BatchCreateEntitySignalsMappingsAsync(string, IEnumerable<CreateEntitySignalsMappingRequest>, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateEntitySignalsMappingRequest> requests = new CreateEntitySignalsMappingRequest[]
            {
                new CreateEntitySignalsMappingRequest(),
            };
            // Make the request
            BatchCreateEntitySignalsMappingsResponse response = await entitySignalsMappingServiceClient.BatchCreateEntitySignalsMappingsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitySignalsMappings</summary>
        public void BatchCreateEntitySignalsMappingsResourceNames()
        {
            // Snippet: BatchCreateEntitySignalsMappings(NetworkName, IEnumerable<CreateEntitySignalsMappingRequest>, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateEntitySignalsMappingRequest> requests = new CreateEntitySignalsMappingRequest[]
            {
                new CreateEntitySignalsMappingRequest(),
            };
            // Make the request
            BatchCreateEntitySignalsMappingsResponse response = entitySignalsMappingServiceClient.BatchCreateEntitySignalsMappings(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitySignalsMappingsAsync</summary>
        public async Task BatchCreateEntitySignalsMappingsResourceNamesAsync()
        {
            // Snippet: BatchCreateEntitySignalsMappingsAsync(NetworkName, IEnumerable<CreateEntitySignalsMappingRequest>, CallSettings)
            // Additional: BatchCreateEntitySignalsMappingsAsync(NetworkName, IEnumerable<CreateEntitySignalsMappingRequest>, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateEntitySignalsMappingRequest> requests = new CreateEntitySignalsMappingRequest[]
            {
                new CreateEntitySignalsMappingRequest(),
            };
            // Make the request
            BatchCreateEntitySignalsMappingsResponse response = await entitySignalsMappingServiceClient.BatchCreateEntitySignalsMappingsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitySignalsMappings</summary>
        public void BatchUpdateEntitySignalsMappingsRequestObject()
        {
            // Snippet: BatchUpdateEntitySignalsMappings(BatchUpdateEntitySignalsMappingsRequest, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateEntitySignalsMappingsRequest request = new BatchUpdateEntitySignalsMappingsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateEntitySignalsMappingRequest(),
                },
            };
            // Make the request
            BatchUpdateEntitySignalsMappingsResponse response = entitySignalsMappingServiceClient.BatchUpdateEntitySignalsMappings(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitySignalsMappingsAsync</summary>
        public async Task BatchUpdateEntitySignalsMappingsRequestObjectAsync()
        {
            // Snippet: BatchUpdateEntitySignalsMappingsAsync(BatchUpdateEntitySignalsMappingsRequest, CallSettings)
            // Additional: BatchUpdateEntitySignalsMappingsAsync(BatchUpdateEntitySignalsMappingsRequest, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateEntitySignalsMappingsRequest request = new BatchUpdateEntitySignalsMappingsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateEntitySignalsMappingRequest(),
                },
            };
            // Make the request
            BatchUpdateEntitySignalsMappingsResponse response = await entitySignalsMappingServiceClient.BatchUpdateEntitySignalsMappingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitySignalsMappings</summary>
        public void BatchUpdateEntitySignalsMappings()
        {
            // Snippet: BatchUpdateEntitySignalsMappings(string, IEnumerable<UpdateEntitySignalsMappingRequest>, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateEntitySignalsMappingRequest> requests = new UpdateEntitySignalsMappingRequest[]
            {
                new UpdateEntitySignalsMappingRequest(),
            };
            // Make the request
            BatchUpdateEntitySignalsMappingsResponse response = entitySignalsMappingServiceClient.BatchUpdateEntitySignalsMappings(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitySignalsMappingsAsync</summary>
        public async Task BatchUpdateEntitySignalsMappingsAsync()
        {
            // Snippet: BatchUpdateEntitySignalsMappingsAsync(string, IEnumerable<UpdateEntitySignalsMappingRequest>, CallSettings)
            // Additional: BatchUpdateEntitySignalsMappingsAsync(string, IEnumerable<UpdateEntitySignalsMappingRequest>, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateEntitySignalsMappingRequest> requests = new UpdateEntitySignalsMappingRequest[]
            {
                new UpdateEntitySignalsMappingRequest(),
            };
            // Make the request
            BatchUpdateEntitySignalsMappingsResponse response = await entitySignalsMappingServiceClient.BatchUpdateEntitySignalsMappingsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitySignalsMappings</summary>
        public void BatchUpdateEntitySignalsMappingsResourceNames()
        {
            // Snippet: BatchUpdateEntitySignalsMappings(NetworkName, IEnumerable<UpdateEntitySignalsMappingRequest>, CallSettings)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = EntitySignalsMappingServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateEntitySignalsMappingRequest> requests = new UpdateEntitySignalsMappingRequest[]
            {
                new UpdateEntitySignalsMappingRequest(),
            };
            // Make the request
            BatchUpdateEntitySignalsMappingsResponse response = entitySignalsMappingServiceClient.BatchUpdateEntitySignalsMappings(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitySignalsMappingsAsync</summary>
        public async Task BatchUpdateEntitySignalsMappingsResourceNamesAsync()
        {
            // Snippet: BatchUpdateEntitySignalsMappingsAsync(NetworkName, IEnumerable<UpdateEntitySignalsMappingRequest>, CallSettings)
            // Additional: BatchUpdateEntitySignalsMappingsAsync(NetworkName, IEnumerable<UpdateEntitySignalsMappingRequest>, CancellationToken)
            // Create client
            EntitySignalsMappingServiceClient entitySignalsMappingServiceClient = await EntitySignalsMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateEntitySignalsMappingRequest> requests = new UpdateEntitySignalsMappingRequest[]
            {
                new UpdateEntitySignalsMappingRequest(),
            };
            // Make the request
            BatchUpdateEntitySignalsMappingsResponse response = await entitySignalsMappingServiceClient.BatchUpdateEntitySignalsMappingsAsync(parent, requests);
            // End snippet
        }
    }
}
