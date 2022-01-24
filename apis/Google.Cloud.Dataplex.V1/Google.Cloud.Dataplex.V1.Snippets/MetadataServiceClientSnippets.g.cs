// Copyright 2022 Google LLC
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

namespace Google.Cloud.Dataplex.V1.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedMetadataServiceClientSnippets
    {
        /// <summary>Snippet for GetEntity</summary>
        public void GetEntityRequestObject()
        {
            // Snippet: GetEntity(GetEntityRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            GetEntityRequest request = new GetEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                View = GetEntityRequest.Types.EntityView.Unspecified,
            };
            // Make the request
            Entity response = metadataServiceClient.GetEntity(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntityAsync</summary>
        public async Task GetEntityRequestObjectAsync()
        {
            // Snippet: GetEntityAsync(GetEntityRequest, CallSettings)
            // Additional: GetEntityAsync(GetEntityRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEntityRequest request = new GetEntityRequest
            {
                EntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                View = GetEntityRequest.Types.EntityView.Unspecified,
            };
            // Make the request
            Entity response = await metadataServiceClient.GetEntityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntity</summary>
        public void GetEntity()
        {
            // Snippet: GetEntity(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            // Make the request
            Entity response = metadataServiceClient.GetEntity(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityAsync</summary>
        public async Task GetEntityAsync()
        {
            // Snippet: GetEntityAsync(string, CallSettings)
            // Additional: GetEntityAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            // Make the request
            Entity response = await metadataServiceClient.GetEntityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntity</summary>
        public void GetEntityResourceNames()
        {
            // Snippet: GetEntity(EntityName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            EntityName name = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            // Make the request
            Entity response = metadataServiceClient.GetEntity(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityAsync</summary>
        public async Task GetEntityResourceNamesAsync()
        {
            // Snippet: GetEntityAsync(EntityName, CallSettings)
            // Additional: GetEntityAsync(EntityName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityName name = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            // Make the request
            Entity response = await metadataServiceClient.GetEntityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEntities</summary>
        public void ListEntitiesRequestObject()
        {
            // Snippet: ListEntities(ListEntitiesRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ListEntitiesRequest request = new ListEntitiesRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                View = ListEntitiesRequest.Types.EntityView.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListEntitiesResponse, Entity> response = metadataServiceClient.ListEntities(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entity item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entity> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entity item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitiesAsync</summary>
        public async Task ListEntitiesRequestObjectAsync()
        {
            // Snippet: ListEntitiesAsync(ListEntitiesRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEntitiesRequest request = new ListEntitiesRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                View = ListEntitiesRequest.Types.EntityView.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEntitiesResponse, Entity> response = metadataServiceClient.ListEntitiesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entity item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entity> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entity item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntities</summary>
        public void ListEntities()
        {
            // Snippet: ListEntities(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedEnumerable<ListEntitiesResponse, Entity> response = metadataServiceClient.ListEntities(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entity item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entity> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entity item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitiesAsync</summary>
        public async Task ListEntitiesAsync()
        {
            // Snippet: ListEntitiesAsync(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedAsyncEnumerable<ListEntitiesResponse, Entity> response = metadataServiceClient.ListEntitiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entity item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entity> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entity item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntities</summary>
        public void ListEntitiesResourceNames()
        {
            // Snippet: ListEntities(ZoneName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedEnumerable<ListEntitiesResponse, Entity> response = metadataServiceClient.ListEntities(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entity item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entity> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entity item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitiesAsync</summary>
        public async Task ListEntitiesResourceNamesAsync()
        {
            // Snippet: ListEntitiesAsync(ZoneName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedAsyncEnumerable<ListEntitiesResponse, Entity> response = metadataServiceClient.ListEntitiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entity item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entity> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entity item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPartition</summary>
        public void GetPartitionRequestObject()
        {
            // Snippet: GetPartition(GetPartitionRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            GetPartitionRequest request = new GetPartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            // Make the request
            Partition response = metadataServiceClient.GetPartition(request);
            // End snippet
        }

        /// <summary>Snippet for GetPartitionAsync</summary>
        public async Task GetPartitionRequestObjectAsync()
        {
            // Snippet: GetPartitionAsync(GetPartitionRequest, CallSettings)
            // Additional: GetPartitionAsync(GetPartitionRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPartitionRequest request = new GetPartitionRequest
            {
                PartitionName = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            // Make the request
            Partition response = await metadataServiceClient.GetPartitionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPartition</summary>
        public void GetPartition()
        {
            // Snippet: GetPartition(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]/partitions/[PARTITION]";
            // Make the request
            Partition response = metadataServiceClient.GetPartition(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartitionAsync</summary>
        public async Task GetPartitionAsync()
        {
            // Snippet: GetPartitionAsync(string, CallSettings)
            // Additional: GetPartitionAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]/partitions/[PARTITION]";
            // Make the request
            Partition response = await metadataServiceClient.GetPartitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartition</summary>
        public void GetPartitionResourceNames()
        {
            // Snippet: GetPartition(PartitionName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            PartitionName name = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]");
            // Make the request
            Partition response = metadataServiceClient.GetPartition(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartitionAsync</summary>
        public async Task GetPartitionResourceNamesAsync()
        {
            // Snippet: GetPartitionAsync(PartitionName, CallSettings)
            // Additional: GetPartitionAsync(PartitionName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            PartitionName name = PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]");
            // Make the request
            Partition response = await metadataServiceClient.GetPartitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPartitions</summary>
        public void ListPartitionsRequestObject()
        {
            // Snippet: ListPartitions(ListPartitionsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ListPartitionsRequest request = new ListPartitionsRequest
            {
                ParentAsEntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPartitionsResponse, Partition> response = metadataServiceClient.ListPartitions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Partition item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPartitionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partition> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partition item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPartitionsAsync</summary>
        public async Task ListPartitionsRequestObjectAsync()
        {
            // Snippet: ListPartitionsAsync(ListPartitionsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPartitionsRequest request = new ListPartitionsRequest
            {
                ParentAsEntityName = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPartitionsResponse, Partition> response = metadataServiceClient.ListPartitionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Partition item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPartitionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partition> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partition item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPartitions</summary>
        public void ListPartitions()
        {
            // Snippet: ListPartitions(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            // Make the request
            PagedEnumerable<ListPartitionsResponse, Partition> response = metadataServiceClient.ListPartitions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Partition item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPartitionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partition> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partition item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPartitionsAsync</summary>
        public async Task ListPartitionsAsync()
        {
            // Snippet: ListPartitionsAsync(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            // Make the request
            PagedAsyncEnumerable<ListPartitionsResponse, Partition> response = metadataServiceClient.ListPartitionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Partition item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPartitionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partition> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partition item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPartitions</summary>
        public void ListPartitionsResourceNames()
        {
            // Snippet: ListPartitions(EntityName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            EntityName parent = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            // Make the request
            PagedEnumerable<ListPartitionsResponse, Partition> response = metadataServiceClient.ListPartitions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Partition item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPartitionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partition> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partition item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPartitionsAsync</summary>
        public async Task ListPartitionsResourceNamesAsync()
        {
            // Snippet: ListPartitionsAsync(EntityName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityName parent = EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            // Make the request
            PagedAsyncEnumerable<ListPartitionsResponse, Partition> response = metadataServiceClient.ListPartitionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Partition item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPartitionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partition> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partition item in singlePage)
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
