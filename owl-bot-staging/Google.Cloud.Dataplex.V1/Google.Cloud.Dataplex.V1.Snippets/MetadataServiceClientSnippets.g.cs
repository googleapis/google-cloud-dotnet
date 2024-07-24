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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMetadataServiceClientSnippets
    {
        /// <summary>Snippet for CreateEntity</summary>
        public void CreateEntityRequestObject()
        {
            // Snippet: CreateEntity(CreateEntityRequest, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateEntityRequest request = new gcdv::CreateEntityRequest
            {
                ParentAsZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Entity = new gcdv::Entity(),
                ValidateOnly = false,
            };
            // Make the request
            gcdv::Entity response = metadataServiceClient.CreateEntity(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityAsync</summary>
        public async Task CreateEntityRequestObjectAsync()
        {
            // Snippet: CreateEntityAsync(CreateEntityRequest, CallSettings)
            // Additional: CreateEntityAsync(CreateEntityRequest, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateEntityRequest request = new gcdv::CreateEntityRequest
            {
                ParentAsZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Entity = new gcdv::Entity(),
                ValidateOnly = false,
            };
            // Make the request
            gcdv::Entity response = await metadataServiceClient.CreateEntityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntity</summary>
        public void CreateEntity()
        {
            // Snippet: CreateEntity(string, Entity, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            gcdv::Entity entity = new gcdv::Entity();
            // Make the request
            gcdv::Entity response = metadataServiceClient.CreateEntity(parent, entity);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityAsync</summary>
        public async Task CreateEntityAsync()
        {
            // Snippet: CreateEntityAsync(string, Entity, CallSettings)
            // Additional: CreateEntityAsync(string, Entity, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            gcdv::Entity entity = new gcdv::Entity();
            // Make the request
            gcdv::Entity response = await metadataServiceClient.CreateEntityAsync(parent, entity);
            // End snippet
        }

        /// <summary>Snippet for CreateEntity</summary>
        public void CreateEntityResourceNames()
        {
            // Snippet: CreateEntity(ZoneName, Entity, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ZoneName parent = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            gcdv::Entity entity = new gcdv::Entity();
            // Make the request
            gcdv::Entity response = metadataServiceClient.CreateEntity(parent, entity);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityAsync</summary>
        public async Task CreateEntityResourceNamesAsync()
        {
            // Snippet: CreateEntityAsync(ZoneName, Entity, CallSettings)
            // Additional: CreateEntityAsync(ZoneName, Entity, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ZoneName parent = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            gcdv::Entity entity = new gcdv::Entity();
            // Make the request
            gcdv::Entity response = await metadataServiceClient.CreateEntityAsync(parent, entity);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntity</summary>
        public void UpdateEntityRequestObject()
        {
            // Snippet: UpdateEntity(UpdateEntityRequest, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateEntityRequest request = new gcdv::UpdateEntityRequest
            {
                Entity = new gcdv::Entity(),
                ValidateOnly = false,
            };
            // Make the request
            gcdv::Entity response = metadataServiceClient.UpdateEntity(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityAsync</summary>
        public async Task UpdateEntityRequestObjectAsync()
        {
            // Snippet: UpdateEntityAsync(UpdateEntityRequest, CallSettings)
            // Additional: UpdateEntityAsync(UpdateEntityRequest, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateEntityRequest request = new gcdv::UpdateEntityRequest
            {
                Entity = new gcdv::Entity(),
                ValidateOnly = false,
            };
            // Make the request
            gcdv::Entity response = await metadataServiceClient.UpdateEntityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntity</summary>
        public void DeleteEntityRequestObject()
        {
            // Snippet: DeleteEntity(DeleteEntityRequest, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteEntityRequest request = new gcdv::DeleteEntityRequest
            {
                EntityName = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Etag = "",
            };
            // Make the request
            metadataServiceClient.DeleteEntity(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityAsync</summary>
        public async Task DeleteEntityRequestObjectAsync()
        {
            // Snippet: DeleteEntityAsync(DeleteEntityRequest, CallSettings)
            // Additional: DeleteEntityAsync(DeleteEntityRequest, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteEntityRequest request = new gcdv::DeleteEntityRequest
            {
                EntityName = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Etag = "",
            };
            // Make the request
            await metadataServiceClient.DeleteEntityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntity</summary>
        public void DeleteEntity()
        {
            // Snippet: DeleteEntity(string, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            // Make the request
            metadataServiceClient.DeleteEntity(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityAsync</summary>
        public async Task DeleteEntityAsync()
        {
            // Snippet: DeleteEntityAsync(string, CallSettings)
            // Additional: DeleteEntityAsync(string, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            // Make the request
            await metadataServiceClient.DeleteEntityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntity</summary>
        public void DeleteEntityResourceNames()
        {
            // Snippet: DeleteEntity(EntityName, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntityName name = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            // Make the request
            metadataServiceClient.DeleteEntity(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityAsync</summary>
        public async Task DeleteEntityResourceNamesAsync()
        {
            // Snippet: DeleteEntityAsync(EntityName, CallSettings)
            // Additional: DeleteEntityAsync(EntityName, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntityName name = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            // Make the request
            await metadataServiceClient.DeleteEntityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntity</summary>
        public void GetEntityRequestObject()
        {
            // Snippet: GetEntity(GetEntityRequest, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetEntityRequest request = new gcdv::GetEntityRequest
            {
                EntityName = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                View = gcdv::GetEntityRequest.Types.EntityView.Unspecified,
            };
            // Make the request
            gcdv::Entity response = metadataServiceClient.GetEntity(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntityAsync</summary>
        public async Task GetEntityRequestObjectAsync()
        {
            // Snippet: GetEntityAsync(GetEntityRequest, CallSettings)
            // Additional: GetEntityAsync(GetEntityRequest, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetEntityRequest request = new gcdv::GetEntityRequest
            {
                EntityName = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                View = gcdv::GetEntityRequest.Types.EntityView.Unspecified,
            };
            // Make the request
            gcdv::Entity response = await metadataServiceClient.GetEntityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntity</summary>
        public void GetEntity()
        {
            // Snippet: GetEntity(string, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            // Make the request
            gcdv::Entity response = metadataServiceClient.GetEntity(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityAsync</summary>
        public async Task GetEntityAsync()
        {
            // Snippet: GetEntityAsync(string, CallSettings)
            // Additional: GetEntityAsync(string, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            // Make the request
            gcdv::Entity response = await metadataServiceClient.GetEntityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntity</summary>
        public void GetEntityResourceNames()
        {
            // Snippet: GetEntity(EntityName, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntityName name = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            // Make the request
            gcdv::Entity response = metadataServiceClient.GetEntity(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityAsync</summary>
        public async Task GetEntityResourceNamesAsync()
        {
            // Snippet: GetEntityAsync(EntityName, CallSettings)
            // Additional: GetEntityAsync(EntityName, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntityName name = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            // Make the request
            gcdv::Entity response = await metadataServiceClient.GetEntityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEntities</summary>
        public void ListEntitiesRequestObject()
        {
            // Snippet: ListEntities(ListEntitiesRequest, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListEntitiesRequest request = new gcdv::ListEntitiesRequest
            {
                ParentAsZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                View = gcdv::ListEntitiesRequest.Types.EntityView.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListEntitiesResponse, gcdv::Entity> response = metadataServiceClient.ListEntities(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Entity item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entity> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entity item in singlePage)
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
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListEntitiesRequest request = new gcdv::ListEntitiesRequest
            {
                ParentAsZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                View = gcdv::ListEntitiesRequest.Types.EntityView.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntitiesResponse, gcdv::Entity> response = metadataServiceClient.ListEntitiesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Entity item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entity> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entity item in singlePage)
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
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedEnumerable<gcdv::ListEntitiesResponse, gcdv::Entity> response = metadataServiceClient.ListEntities(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Entity item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entity> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entity item in singlePage)
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
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntitiesResponse, gcdv::Entity> response = metadataServiceClient.ListEntitiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Entity item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entity> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entity item in singlePage)
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
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ZoneName parent = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedEnumerable<gcdv::ListEntitiesResponse, gcdv::Entity> response = metadataServiceClient.ListEntities(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Entity item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entity> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entity item in singlePage)
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
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ZoneName parent = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntitiesResponse, gcdv::Entity> response = metadataServiceClient.ListEntitiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Entity item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entity> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entity item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreatePartition</summary>
        public void CreatePartitionRequestObject()
        {
            // Snippet: CreatePartition(CreatePartitionRequest, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreatePartitionRequest request = new gcdv::CreatePartitionRequest
            {
                ParentAsEntityName = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Partition = new gcdv::Partition(),
                ValidateOnly = false,
            };
            // Make the request
            gcdv::Partition response = metadataServiceClient.CreatePartition(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePartitionAsync</summary>
        public async Task CreatePartitionRequestObjectAsync()
        {
            // Snippet: CreatePartitionAsync(CreatePartitionRequest, CallSettings)
            // Additional: CreatePartitionAsync(CreatePartitionRequest, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreatePartitionRequest request = new gcdv::CreatePartitionRequest
            {
                ParentAsEntityName = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Partition = new gcdv::Partition(),
                ValidateOnly = false,
            };
            // Make the request
            gcdv::Partition response = await metadataServiceClient.CreatePartitionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePartition</summary>
        public void CreatePartition()
        {
            // Snippet: CreatePartition(string, Partition, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            gcdv::Partition partition = new gcdv::Partition();
            // Make the request
            gcdv::Partition response = metadataServiceClient.CreatePartition(parent, partition);
            // End snippet
        }

        /// <summary>Snippet for CreatePartitionAsync</summary>
        public async Task CreatePartitionAsync()
        {
            // Snippet: CreatePartitionAsync(string, Partition, CallSettings)
            // Additional: CreatePartitionAsync(string, Partition, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            gcdv::Partition partition = new gcdv::Partition();
            // Make the request
            gcdv::Partition response = await metadataServiceClient.CreatePartitionAsync(parent, partition);
            // End snippet
        }

        /// <summary>Snippet for CreatePartition</summary>
        public void CreatePartitionResourceNames()
        {
            // Snippet: CreatePartition(EntityName, Partition, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntityName parent = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            gcdv::Partition partition = new gcdv::Partition();
            // Make the request
            gcdv::Partition response = metadataServiceClient.CreatePartition(parent, partition);
            // End snippet
        }

        /// <summary>Snippet for CreatePartitionAsync</summary>
        public async Task CreatePartitionResourceNamesAsync()
        {
            // Snippet: CreatePartitionAsync(EntityName, Partition, CallSettings)
            // Additional: CreatePartitionAsync(EntityName, Partition, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntityName parent = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            gcdv::Partition partition = new gcdv::Partition();
            // Make the request
            gcdv::Partition response = await metadataServiceClient.CreatePartitionAsync(parent, partition);
            // End snippet
        }

        /// <summary>Snippet for DeletePartition</summary>
        public void DeletePartitionRequestObject()
        {
            // Snippet: DeletePartition(DeletePartitionRequest, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeletePartitionRequest request = new gcdv::DeletePartitionRequest
            {
                PartitionName = gcdv::PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            // Make the request
            metadataServiceClient.DeletePartition(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePartitionAsync</summary>
        public async Task DeletePartitionRequestObjectAsync()
        {
            // Snippet: DeletePartitionAsync(DeletePartitionRequest, CallSettings)
            // Additional: DeletePartitionAsync(DeletePartitionRequest, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeletePartitionRequest request = new gcdv::DeletePartitionRequest
            {
                PartitionName = gcdv::PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            // Make the request
            await metadataServiceClient.DeletePartitionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePartition</summary>
        public void DeletePartition()
        {
            // Snippet: DeletePartition(string, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]/partitions/[PARTITION]";
            // Make the request
            metadataServiceClient.DeletePartition(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePartitionAsync</summary>
        public async Task DeletePartitionAsync()
        {
            // Snippet: DeletePartitionAsync(string, CallSettings)
            // Additional: DeletePartitionAsync(string, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]/partitions/[PARTITION]";
            // Make the request
            await metadataServiceClient.DeletePartitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePartition</summary>
        public void DeletePartitionResourceNames()
        {
            // Snippet: DeletePartition(PartitionName, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::PartitionName name = gcdv::PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]");
            // Make the request
            metadataServiceClient.DeletePartition(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePartitionAsync</summary>
        public async Task DeletePartitionResourceNamesAsync()
        {
            // Snippet: DeletePartitionAsync(PartitionName, CallSettings)
            // Additional: DeletePartitionAsync(PartitionName, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::PartitionName name = gcdv::PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]");
            // Make the request
            await metadataServiceClient.DeletePartitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartition</summary>
        public void GetPartitionRequestObject()
        {
            // Snippet: GetPartition(GetPartitionRequest, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetPartitionRequest request = new gcdv::GetPartitionRequest
            {
                PartitionName = gcdv::PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            // Make the request
            gcdv::Partition response = metadataServiceClient.GetPartition(request);
            // End snippet
        }

        /// <summary>Snippet for GetPartitionAsync</summary>
        public async Task GetPartitionRequestObjectAsync()
        {
            // Snippet: GetPartitionAsync(GetPartitionRequest, CallSettings)
            // Additional: GetPartitionAsync(GetPartitionRequest, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetPartitionRequest request = new gcdv::GetPartitionRequest
            {
                PartitionName = gcdv::PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]"),
            };
            // Make the request
            gcdv::Partition response = await metadataServiceClient.GetPartitionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPartition</summary>
        public void GetPartition()
        {
            // Snippet: GetPartition(string, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]/partitions/[PARTITION]";
            // Make the request
            gcdv::Partition response = metadataServiceClient.GetPartition(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartitionAsync</summary>
        public async Task GetPartitionAsync()
        {
            // Snippet: GetPartitionAsync(string, CallSettings)
            // Additional: GetPartitionAsync(string, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]/partitions/[PARTITION]";
            // Make the request
            gcdv::Partition response = await metadataServiceClient.GetPartitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartition</summary>
        public void GetPartitionResourceNames()
        {
            // Snippet: GetPartition(PartitionName, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::PartitionName name = gcdv::PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]");
            // Make the request
            gcdv::Partition response = metadataServiceClient.GetPartition(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartitionAsync</summary>
        public async Task GetPartitionResourceNamesAsync()
        {
            // Snippet: GetPartitionAsync(PartitionName, CallSettings)
            // Additional: GetPartitionAsync(PartitionName, CancellationToken)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::PartitionName name = gcdv::PartitionName.FromProjectLocationLakeZoneEntityPartition("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]", "[PARTITION]");
            // Make the request
            gcdv::Partition response = await metadataServiceClient.GetPartitionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPartitions</summary>
        public void ListPartitionsRequestObject()
        {
            // Snippet: ListPartitions(ListPartitionsRequest, CallSettings)
            // Create client
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListPartitionsRequest request = new gcdv::ListPartitionsRequest
            {
                ParentAsEntityName = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListPartitionsResponse, gcdv::Partition> response = metadataServiceClient.ListPartitions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Partition item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListPartitionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Partition> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Partition item in singlePage)
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
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListPartitionsRequest request = new gcdv::ListPartitionsRequest
            {
                ParentAsEntityName = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListPartitionsResponse, gcdv::Partition> response = metadataServiceClient.ListPartitionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Partition item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListPartitionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Partition> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Partition item in singlePage)
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
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            // Make the request
            PagedEnumerable<gcdv::ListPartitionsResponse, gcdv::Partition> response = metadataServiceClient.ListPartitions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Partition item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListPartitionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Partition> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Partition item in singlePage)
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
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/entities/[ENTITY]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListPartitionsResponse, gcdv::Partition> response = metadataServiceClient.ListPartitionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Partition item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListPartitionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Partition> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Partition item in singlePage)
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
            gcdv::MetadataServiceClient metadataServiceClient = gcdv::MetadataServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntityName parent = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            // Make the request
            PagedEnumerable<gcdv::ListPartitionsResponse, gcdv::Partition> response = metadataServiceClient.ListPartitions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Partition item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListPartitionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Partition> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Partition item in singlePage)
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
            gcdv::MetadataServiceClient metadataServiceClient = await gcdv::MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntityName parent = gcdv::EntityName.FromProjectLocationLakeZoneEntity("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ENTITY]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListPartitionsResponse, gcdv::Partition> response = metadataServiceClient.ListPartitionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Partition item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListPartitionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Partition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Partition> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Partition item in singlePage)
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
