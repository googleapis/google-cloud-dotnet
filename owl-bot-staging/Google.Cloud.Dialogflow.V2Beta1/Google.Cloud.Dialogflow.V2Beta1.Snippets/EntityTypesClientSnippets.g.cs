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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEntityTypesClientSnippets
    {
        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypesRequestObject()
        {
            // Snippet: ListEntityTypes(ListEntityTypesRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListEntityTypesResponse, EntityType> response = entityTypesClient.ListEntityTypes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntityType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntityTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypesAsync</summary>
        public async Task ListEntityTypesRequestObjectAsync()
        {
            // Snippet: ListEntityTypesAsync(ListEntityTypesRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> response = entityTypesClient.ListEntityTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntityType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntityTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypes1()
        {
            // Snippet: ListEntityTypes(string, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            // Make the request
            PagedEnumerable<ListEntityTypesResponse, EntityType> response = entityTypesClient.ListEntityTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntityType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntityTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypesAsync</summary>
        public async Task ListEntityTypes1Async()
        {
            // Snippet: ListEntityTypesAsync(string, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            // Make the request
            PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> response = entityTypesClient.ListEntityTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntityType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntityTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypes1ResourceNames()
        {
            // Snippet: ListEntityTypes(AgentName, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListEntityTypesResponse, EntityType> response = entityTypesClient.ListEntityTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntityType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntityTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypesAsync</summary>
        public async Task ListEntityTypes1ResourceNamesAsync()
        {
            // Snippet: ListEntityTypesAsync(AgentName, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> response = entityTypesClient.ListEntityTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntityType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntityTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypes2()
        {
            // Snippet: ListEntityTypes(string, string, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            string languageCode = "";
            // Make the request
            PagedEnumerable<ListEntityTypesResponse, EntityType> response = entityTypesClient.ListEntityTypes(parent, languageCode: languageCode);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntityType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntityTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypesAsync</summary>
        public async Task ListEntityTypes2Async()
        {
            // Snippet: ListEntityTypesAsync(string, string, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            string languageCode = "";
            // Make the request
            PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> response = entityTypesClient.ListEntityTypesAsync(parent, languageCode: languageCode);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntityType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntityTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypes2ResourceNames()
        {
            // Snippet: ListEntityTypes(AgentName, string, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            string languageCode = "";
            // Make the request
            PagedEnumerable<ListEntityTypesResponse, EntityType> response = entityTypesClient.ListEntityTypes(parent, languageCode: languageCode);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntityType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntityTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypesAsync</summary>
        public async Task ListEntityTypes2ResourceNamesAsync()
        {
            // Snippet: ListEntityTypesAsync(AgentName, string, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            string languageCode = "";
            // Make the request
            PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> response = entityTypesClient.ListEntityTypesAsync(parent, languageCode: languageCode);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntityType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntityTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityTypeRequestObject()
        {
            // Snippet: GetEntityType(GetEntityTypeRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                LanguageCode = "",
            };
            // Make the request
            EntityType response = entityTypesClient.GetEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityTypeRequestObjectAsync()
        {
            // Snippet: GetEntityTypeAsync(GetEntityTypeRequest, CallSettings)
            // Additional: GetEntityTypeAsync(GetEntityTypeRequest, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                LanguageCode = "",
            };
            // Make the request
            EntityType response = await entityTypesClient.GetEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityType1()
        {
            // Snippet: GetEntityType(string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            // Make the request
            EntityType response = entityTypesClient.GetEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityType1Async()
        {
            // Snippet: GetEntityTypeAsync(string, CallSettings)
            // Additional: GetEntityTypeAsync(string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            // Make the request
            EntityType response = await entityTypesClient.GetEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityType1ResourceNames()
        {
            // Snippet: GetEntityType(EntityTypeName, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            // Make the request
            EntityType response = entityTypesClient.GetEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityType1ResourceNamesAsync()
        {
            // Snippet: GetEntityTypeAsync(EntityTypeName, CallSettings)
            // Additional: GetEntityTypeAsync(EntityTypeName, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            // Make the request
            EntityType response = await entityTypesClient.GetEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityType2()
        {
            // Snippet: GetEntityType(string, string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            string languageCode = "";
            // Make the request
            EntityType response = entityTypesClient.GetEntityType(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityType2Async()
        {
            // Snippet: GetEntityTypeAsync(string, string, CallSettings)
            // Additional: GetEntityTypeAsync(string, string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            string languageCode = "";
            // Make the request
            EntityType response = await entityTypesClient.GetEntityTypeAsync(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityType2ResourceNames()
        {
            // Snippet: GetEntityType(EntityTypeName, string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            string languageCode = "";
            // Make the request
            EntityType response = entityTypesClient.GetEntityType(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityType2ResourceNamesAsync()
        {
            // Snippet: GetEntityTypeAsync(EntityTypeName, string, CallSettings)
            // Additional: GetEntityTypeAsync(EntityTypeName, string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            string languageCode = "";
            // Make the request
            EntityType response = await entityTypesClient.GetEntityTypeAsync(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityTypeRequestObject()
        {
            // Snippet: CreateEntityType(CreateEntityTypeRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
                LanguageCode = "",
            };
            // Make the request
            EntityType response = entityTypesClient.CreateEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityTypeRequestObjectAsync()
        {
            // Snippet: CreateEntityTypeAsync(CreateEntityTypeRequest, CallSettings)
            // Additional: CreateEntityTypeAsync(CreateEntityTypeRequest, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityType = new EntityType(),
                LanguageCode = "",
            };
            // Make the request
            EntityType response = await entityTypesClient.CreateEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType1()
        {
            // Snippet: CreateEntityType(string, EntityType, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = entityTypesClient.CreateEntityType(parent, entityType);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityType1Async()
        {
            // Snippet: CreateEntityTypeAsync(string, EntityType, CallSettings)
            // Additional: CreateEntityTypeAsync(string, EntityType, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = await entityTypesClient.CreateEntityTypeAsync(parent, entityType);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType1ResourceNames()
        {
            // Snippet: CreateEntityType(AgentName, EntityType, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = entityTypesClient.CreateEntityType(parent, entityType);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityType1ResourceNamesAsync()
        {
            // Snippet: CreateEntityTypeAsync(AgentName, EntityType, CallSettings)
            // Additional: CreateEntityTypeAsync(AgentName, EntityType, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = await entityTypesClient.CreateEntityTypeAsync(parent, entityType);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType2()
        {
            // Snippet: CreateEntityType(string, EntityType, string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            EntityType entityType = new EntityType();
            string languageCode = "";
            // Make the request
            EntityType response = entityTypesClient.CreateEntityType(parent, entityType, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityType2Async()
        {
            // Snippet: CreateEntityTypeAsync(string, EntityType, string, CallSettings)
            // Additional: CreateEntityTypeAsync(string, EntityType, string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            EntityType entityType = new EntityType();
            string languageCode = "";
            // Make the request
            EntityType response = await entityTypesClient.CreateEntityTypeAsync(parent, entityType, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType2ResourceNames()
        {
            // Snippet: CreateEntityType(AgentName, EntityType, string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            EntityType entityType = new EntityType();
            string languageCode = "";
            // Make the request
            EntityType response = entityTypesClient.CreateEntityType(parent, entityType, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityType2ResourceNamesAsync()
        {
            // Snippet: CreateEntityTypeAsync(AgentName, EntityType, string, CallSettings)
            // Additional: CreateEntityTypeAsync(AgentName, EntityType, string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            EntityType entityType = new EntityType();
            string languageCode = "";
            // Make the request
            EntityType response = await entityTypesClient.CreateEntityTypeAsync(parent, entityType, languageCode);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityType</summary>
        public void UpdateEntityTypeRequestObject()
        {
            // Snippet: UpdateEntityType(UpdateEntityTypeRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "",
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EntityType response = entityTypesClient.UpdateEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityTypeAsync</summary>
        public async Task UpdateEntityTypeRequestObjectAsync()
        {
            // Snippet: UpdateEntityTypeAsync(UpdateEntityTypeRequest, CallSettings)
            // Additional: UpdateEntityTypeAsync(UpdateEntityTypeRequest, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                LanguageCode = "",
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EntityType response = await entityTypesClient.UpdateEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityType</summary>
        public void UpdateEntityType1()
        {
            // Snippet: UpdateEntityType(EntityType, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = entityTypesClient.UpdateEntityType(entityType);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityTypeAsync</summary>
        public async Task UpdateEntityType1Async()
        {
            // Snippet: UpdateEntityTypeAsync(EntityType, CallSettings)
            // Additional: UpdateEntityTypeAsync(EntityType, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = await entityTypesClient.UpdateEntityTypeAsync(entityType);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityType</summary>
        public void UpdateEntityType2()
        {
            // Snippet: UpdateEntityType(EntityType, string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            string languageCode = "";
            // Make the request
            EntityType response = entityTypesClient.UpdateEntityType(entityType, languageCode);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityTypeAsync</summary>
        public async Task UpdateEntityType2Async()
        {
            // Snippet: UpdateEntityTypeAsync(EntityType, string, CallSettings)
            // Additional: UpdateEntityTypeAsync(EntityType, string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            string languageCode = "";
            // Make the request
            EntityType response = await entityTypesClient.UpdateEntityTypeAsync(entityType, languageCode);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityType</summary>
        public void UpdateEntityType3()
        {
            // Snippet: UpdateEntityType(EntityType, string, FieldMask, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            string languageCode = "";
            FieldMask updateMask = new FieldMask();
            // Make the request
            EntityType response = entityTypesClient.UpdateEntityType(entityType, languageCode, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityTypeAsync</summary>
        public async Task UpdateEntityType3Async()
        {
            // Snippet: UpdateEntityTypeAsync(EntityType, string, FieldMask, CallSettings)
            // Additional: UpdateEntityTypeAsync(EntityType, string, FieldMask, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            string languageCode = "";
            FieldMask updateMask = new FieldMask();
            // Make the request
            EntityType response = await entityTypesClient.UpdateEntityTypeAsync(entityType, languageCode, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityType</summary>
        public void DeleteEntityTypeRequestObject()
        {
            // Snippet: DeleteEntityType(DeleteEntityTypeRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            // Make the request
            entityTypesClient.DeleteEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityTypeAsync</summary>
        public async Task DeleteEntityTypeRequestObjectAsync()
        {
            // Snippet: DeleteEntityTypeAsync(DeleteEntityTypeRequest, CallSettings)
            // Additional: DeleteEntityTypeAsync(DeleteEntityTypeRequest, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
            };
            // Make the request
            await entityTypesClient.DeleteEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityType</summary>
        public void DeleteEntityType()
        {
            // Snippet: DeleteEntityType(string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            // Make the request
            entityTypesClient.DeleteEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityTypeAsync</summary>
        public async Task DeleteEntityTypeAsync()
        {
            // Snippet: DeleteEntityTypeAsync(string, CallSettings)
            // Additional: DeleteEntityTypeAsync(string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            // Make the request
            await entityTypesClient.DeleteEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityType</summary>
        public void DeleteEntityTypeResourceNames()
        {
            // Snippet: DeleteEntityType(EntityTypeName, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            // Make the request
            entityTypesClient.DeleteEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityTypeAsync</summary>
        public async Task DeleteEntityTypeResourceNamesAsync()
        {
            // Snippet: DeleteEntityTypeAsync(EntityTypeName, CallSettings)
            // Additional: DeleteEntityTypeAsync(EntityTypeName, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            // Make the request
            await entityTypesClient.DeleteEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntityTypes</summary>
        public void BatchUpdateEntityTypesRequestObject()
        {
            // Snippet: BatchUpdateEntityTypes(BatchUpdateEntityTypesRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            BatchUpdateEntityTypesRequest request = new BatchUpdateEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityTypeBatchUri = "",
                LanguageCode = "",
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<BatchUpdateEntityTypesResponse, Struct> response = entityTypesClient.BatchUpdateEntityTypes(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateEntityTypesResponse, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchUpdateEntityTypesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateEntityTypesResponse, Struct> retrievedResponse = entityTypesClient.PollOnceBatchUpdateEntityTypes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateEntityTypesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntityTypesAsync</summary>
        public async Task BatchUpdateEntityTypesRequestObjectAsync()
        {
            // Snippet: BatchUpdateEntityTypesAsync(BatchUpdateEntityTypesRequest, CallSettings)
            // Additional: BatchUpdateEntityTypesAsync(BatchUpdateEntityTypesRequest, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateEntityTypesRequest request = new BatchUpdateEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityTypeBatchUri = "",
                LanguageCode = "",
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<BatchUpdateEntityTypesResponse, Struct> response = await entityTypesClient.BatchUpdateEntityTypesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateEntityTypesResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchUpdateEntityTypesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateEntityTypesResponse, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchUpdateEntityTypesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateEntityTypesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntityTypes</summary>
        public void BatchDeleteEntityTypesRequestObject()
        {
            // Snippet: BatchDeleteEntityTypes(BatchDeleteEntityTypesRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            BatchDeleteEntityTypesRequest request = new BatchDeleteEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityTypeNames = { "", },
            };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchDeleteEntityTypes(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchDeleteEntityTypes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntityTypesAsync</summary>
        public async Task BatchDeleteEntityTypesRequestObjectAsync()
        {
            // Snippet: BatchDeleteEntityTypesAsync(BatchDeleteEntityTypesRequest, CallSettings)
            // Additional: BatchDeleteEntityTypesAsync(BatchDeleteEntityTypesRequest, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteEntityTypesRequest request = new BatchDeleteEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                EntityTypeNames = { "", },
            };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchDeleteEntityTypesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchDeleteEntityTypesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntityTypes</summary>
        public void BatchDeleteEntityTypes()
        {
            // Snippet: BatchDeleteEntityTypes(string, IEnumerable<string>, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            IEnumerable<string> entityTypeNames = new string[] { "", };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchDeleteEntityTypes(parent, entityTypeNames);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchDeleteEntityTypes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntityTypesAsync</summary>
        public async Task BatchDeleteEntityTypesAsync()
        {
            // Snippet: BatchDeleteEntityTypesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeleteEntityTypesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent";
            IEnumerable<string> entityTypeNames = new string[] { "", };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchDeleteEntityTypesAsync(parent, entityTypeNames);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchDeleteEntityTypesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntityTypes</summary>
        public void BatchDeleteEntityTypesResourceNames()
        {
            // Snippet: BatchDeleteEntityTypes(AgentName, IEnumerable<string>, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            IEnumerable<string> entityTypeNames = new string[] { "", };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchDeleteEntityTypes(parent, entityTypeNames);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchDeleteEntityTypes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntityTypesAsync</summary>
        public async Task BatchDeleteEntityTypesResourceNamesAsync()
        {
            // Snippet: BatchDeleteEntityTypesAsync(AgentName, IEnumerable<string>, CallSettings)
            // Additional: BatchDeleteEntityTypesAsync(AgentName, IEnumerable<string>, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProject("[PROJECT]");
            IEnumerable<string> entityTypeNames = new string[] { "", };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchDeleteEntityTypesAsync(parent, entityTypeNames);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchDeleteEntityTypesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntities</summary>
        public void BatchCreateEntitiesRequestObject()
        {
            // Snippet: BatchCreateEntities(BatchCreateEntitiesRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            BatchCreateEntitiesRequest request = new BatchCreateEntitiesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                LanguageCode = "",
            };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchCreateEntities(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchCreateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitiesAsync</summary>
        public async Task BatchCreateEntitiesRequestObjectAsync()
        {
            // Snippet: BatchCreateEntitiesAsync(BatchCreateEntitiesRequest, CallSettings)
            // Additional: BatchCreateEntitiesAsync(BatchCreateEntitiesRequest, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateEntitiesRequest request = new BatchCreateEntitiesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                LanguageCode = "",
            };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchCreateEntitiesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchCreateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntities</summary>
        public void BatchCreateEntities1()
        {
            // Snippet: BatchCreateEntities(string, IEnumerable<EntityType.Types.Entity>, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchCreateEntities(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchCreateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitiesAsync</summary>
        public async Task BatchCreateEntities1Async()
        {
            // Snippet: BatchCreateEntitiesAsync(string, IEnumerable<EntityType.Types.Entity>, CallSettings)
            // Additional: BatchCreateEntitiesAsync(string, IEnumerable<EntityType.Types.Entity>, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchCreateEntitiesAsync(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchCreateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntities</summary>
        public void BatchCreateEntities1ResourceNames()
        {
            // Snippet: BatchCreateEntities(EntityTypeName, IEnumerable<EntityType.Types.Entity>, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchCreateEntities(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchCreateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitiesAsync</summary>
        public async Task BatchCreateEntities1ResourceNamesAsync()
        {
            // Snippet: BatchCreateEntitiesAsync(EntityTypeName, IEnumerable<EntityType.Types.Entity>, CallSettings)
            // Additional: BatchCreateEntitiesAsync(EntityTypeName, IEnumerable<EntityType.Types.Entity>, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchCreateEntitiesAsync(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchCreateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntities</summary>
        public void BatchCreateEntities2()
        {
            // Snippet: BatchCreateEntities(string, IEnumerable<EntityType.Types.Entity>, string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchCreateEntities(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchCreateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitiesAsync</summary>
        public async Task BatchCreateEntities2Async()
        {
            // Snippet: BatchCreateEntitiesAsync(string, IEnumerable<EntityType.Types.Entity>, string, CallSettings)
            // Additional: BatchCreateEntitiesAsync(string, IEnumerable<EntityType.Types.Entity>, string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchCreateEntitiesAsync(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchCreateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntities</summary>
        public void BatchCreateEntities2ResourceNames()
        {
            // Snippet: BatchCreateEntities(EntityTypeName, IEnumerable<EntityType.Types.Entity>, string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchCreateEntities(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchCreateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitiesAsync</summary>
        public async Task BatchCreateEntities2ResourceNamesAsync()
        {
            // Snippet: BatchCreateEntitiesAsync(EntityTypeName, IEnumerable<EntityType.Types.Entity>, string, CallSettings)
            // Additional: BatchCreateEntitiesAsync(EntityTypeName, IEnumerable<EntityType.Types.Entity>, string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchCreateEntitiesAsync(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchCreateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntities</summary>
        public void BatchUpdateEntitiesRequestObject()
        {
            // Snippet: BatchUpdateEntities(BatchUpdateEntitiesRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            BatchUpdateEntitiesRequest request = new BatchUpdateEntitiesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                LanguageCode = "",
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchUpdateEntities(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchUpdateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitiesAsync</summary>
        public async Task BatchUpdateEntitiesRequestObjectAsync()
        {
            // Snippet: BatchUpdateEntitiesAsync(BatchUpdateEntitiesRequest, CallSettings)
            // Additional: BatchUpdateEntitiesAsync(BatchUpdateEntitiesRequest, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateEntitiesRequest request = new BatchUpdateEntitiesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                Entities =
                {
                    new EntityType.Types.Entity(),
                },
                LanguageCode = "",
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchUpdateEntitiesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchUpdateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntities</summary>
        public void BatchUpdateEntities1()
        {
            // Snippet: BatchUpdateEntities(string, IEnumerable<EntityType.Types.Entity>, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchUpdateEntities(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchUpdateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitiesAsync</summary>
        public async Task BatchUpdateEntities1Async()
        {
            // Snippet: BatchUpdateEntitiesAsync(string, IEnumerable<EntityType.Types.Entity>, CallSettings)
            // Additional: BatchUpdateEntitiesAsync(string, IEnumerable<EntityType.Types.Entity>, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchUpdateEntitiesAsync(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchUpdateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntities</summary>
        public void BatchUpdateEntities1ResourceNames()
        {
            // Snippet: BatchUpdateEntities(EntityTypeName, IEnumerable<EntityType.Types.Entity>, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchUpdateEntities(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchUpdateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitiesAsync</summary>
        public async Task BatchUpdateEntities1ResourceNamesAsync()
        {
            // Snippet: BatchUpdateEntitiesAsync(EntityTypeName, IEnumerable<EntityType.Types.Entity>, CallSettings)
            // Additional: BatchUpdateEntitiesAsync(EntityTypeName, IEnumerable<EntityType.Types.Entity>, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchUpdateEntitiesAsync(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchUpdateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntities</summary>
        public void BatchUpdateEntities2()
        {
            // Snippet: BatchUpdateEntities(string, IEnumerable<EntityType.Types.Entity>, string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchUpdateEntities(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchUpdateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitiesAsync</summary>
        public async Task BatchUpdateEntities2Async()
        {
            // Snippet: BatchUpdateEntitiesAsync(string, IEnumerable<EntityType.Types.Entity>, string, CallSettings)
            // Additional: BatchUpdateEntitiesAsync(string, IEnumerable<EntityType.Types.Entity>, string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchUpdateEntitiesAsync(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchUpdateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntities</summary>
        public void BatchUpdateEntities2ResourceNames()
        {
            // Snippet: BatchUpdateEntities(EntityTypeName, IEnumerable<EntityType.Types.Entity>, string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchUpdateEntities(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchUpdateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitiesAsync</summary>
        public async Task BatchUpdateEntities2ResourceNamesAsync()
        {
            // Snippet: BatchUpdateEntitiesAsync(EntityTypeName, IEnumerable<EntityType.Types.Entity>, string, CallSettings)
            // Additional: BatchUpdateEntitiesAsync(EntityTypeName, IEnumerable<EntityType.Types.Entity>, string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new EntityType.Types.Entity[]
            {
                new EntityType.Types.Entity(),
            };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchUpdateEntitiesAsync(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchUpdateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntities</summary>
        public void BatchDeleteEntitiesRequestObject()
        {
            // Snippet: BatchDeleteEntities(BatchDeleteEntitiesRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            BatchDeleteEntitiesRequest request = new BatchDeleteEntitiesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                EntityValues = { "", },
                LanguageCode = "",
            };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchDeleteEntities(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchDeleteEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntitiesAsync</summary>
        public async Task BatchDeleteEntitiesRequestObjectAsync()
        {
            // Snippet: BatchDeleteEntitiesAsync(BatchDeleteEntitiesRequest, CallSettings)
            // Additional: BatchDeleteEntitiesAsync(BatchDeleteEntitiesRequest, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteEntitiesRequest request = new BatchDeleteEntitiesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]"),
                EntityValues = { "", },
                LanguageCode = "",
            };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchDeleteEntitiesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchDeleteEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntities</summary>
        public void BatchDeleteEntities1()
        {
            // Snippet: BatchDeleteEntities(string, IEnumerable<string>, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<string> entityValues = new string[] { "", };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchDeleteEntities(parent, entityValues);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchDeleteEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntitiesAsync</summary>
        public async Task BatchDeleteEntities1Async()
        {
            // Snippet: BatchDeleteEntitiesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeleteEntitiesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<string> entityValues = new string[] { "", };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchDeleteEntitiesAsync(parent, entityValues);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchDeleteEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntities</summary>
        public void BatchDeleteEntities1ResourceNames()
        {
            // Snippet: BatchDeleteEntities(EntityTypeName, IEnumerable<string>, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<string> entityValues = new string[] { "", };
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchDeleteEntities(parent, entityValues);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchDeleteEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntitiesAsync</summary>
        public async Task BatchDeleteEntities1ResourceNamesAsync()
        {
            // Snippet: BatchDeleteEntitiesAsync(EntityTypeName, IEnumerable<string>, CallSettings)
            // Additional: BatchDeleteEntitiesAsync(EntityTypeName, IEnumerable<string>, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<string> entityValues = new string[] { "", };
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchDeleteEntitiesAsync(parent, entityValues);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchDeleteEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntities</summary>
        public void BatchDeleteEntities2()
        {
            // Snippet: BatchDeleteEntities(string, IEnumerable<string>, string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<string> entityValues = new string[] { "", };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchDeleteEntities(parent, entityValues, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchDeleteEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntitiesAsync</summary>
        public async Task BatchDeleteEntities2Async()
        {
            // Snippet: BatchDeleteEntitiesAsync(string, IEnumerable<string>, string, CallSettings)
            // Additional: BatchDeleteEntitiesAsync(string, IEnumerable<string>, string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/entityTypes/[ENTITY_TYPE]";
            IEnumerable<string> entityValues = new string[] { "", };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchDeleteEntitiesAsync(parent, entityValues, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchDeleteEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntities</summary>
        public void BatchDeleteEntities2ResourceNames()
        {
            // Snippet: BatchDeleteEntities(EntityTypeName, IEnumerable<string>, string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<string> entityValues = new string[] { "", };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = entityTypesClient.BatchDeleteEntities(parent, entityValues, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = entityTypesClient.PollOnceBatchDeleteEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntitiesAsync</summary>
        public async Task BatchDeleteEntities2ResourceNamesAsync()
        {
            // Snippet: BatchDeleteEntitiesAsync(EntityTypeName, IEnumerable<string>, string, CallSettings)
            // Additional: BatchDeleteEntitiesAsync(EntityTypeName, IEnumerable<string>, string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectEntityType("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<string> entityValues = new string[] { "", };
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response = await entityTypesClient.BatchDeleteEntitiesAsync(parent, entityValues, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse = await entityTypesClient.PollOnceBatchDeleteEntitiesAsync(operationName);
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
