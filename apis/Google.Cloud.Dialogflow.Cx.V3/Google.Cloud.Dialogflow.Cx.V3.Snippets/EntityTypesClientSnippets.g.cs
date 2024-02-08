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
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEntityTypesClientSnippets
    {
        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityTypeRequestObject()
        {
            // Snippet: GetEntityType(GetEntityTypeRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
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
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                LanguageCode = "",
            };
            // Make the request
            EntityType response = await entityTypesClient.GetEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityType()
        {
            // Snippet: GetEntityType(string, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            EntityType response = entityTypesClient.GetEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityTypeAsync()
        {
            // Snippet: GetEntityTypeAsync(string, CallSettings)
            // Additional: GetEntityTypeAsync(string, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            EntityType response = await entityTypesClient.GetEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityTypeResourceNames()
        {
            // Snippet: GetEntityType(EntityTypeName, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]");
            // Make the request
            EntityType response = entityTypesClient.GetEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityTypeResourceNamesAsync()
        {
            // Snippet: GetEntityTypeAsync(EntityTypeName, CallSettings)
            // Additional: GetEntityTypeAsync(EntityTypeName, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]");
            // Make the request
            EntityType response = await entityTypesClient.GetEntityTypeAsync(name);
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
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
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
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityType = new EntityType(),
                LanguageCode = "",
            };
            // Make the request
            EntityType response = await entityTypesClient.CreateEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType()
        {
            // Snippet: CreateEntityType(string, EntityType, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = entityTypesClient.CreateEntityType(parent, entityType);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityTypeAsync()
        {
            // Snippet: CreateEntityTypeAsync(string, EntityType, CallSettings)
            // Additional: CreateEntityTypeAsync(string, EntityType, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = await entityTypesClient.CreateEntityTypeAsync(parent, entityType);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityTypeResourceNames()
        {
            // Snippet: CreateEntityType(AgentName, EntityType, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = entityTypesClient.CreateEntityType(parent, entityType);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityTypeResourceNamesAsync()
        {
            // Snippet: CreateEntityTypeAsync(AgentName, EntityType, CallSettings)
            // Additional: CreateEntityTypeAsync(AgentName, EntityType, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = await entityTypesClient.CreateEntityTypeAsync(parent, entityType);
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
        public void UpdateEntityType()
        {
            // Snippet: UpdateEntityType(EntityType, FieldMask, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EntityType response = entityTypesClient.UpdateEntityType(entityType, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityTypeAsync</summary>
        public async Task UpdateEntityTypeAsync()
        {
            // Snippet: UpdateEntityTypeAsync(EntityType, FieldMask, CallSettings)
            // Additional: UpdateEntityTypeAsync(EntityType, FieldMask, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EntityType response = await entityTypesClient.UpdateEntityTypeAsync(entityType, updateMask);
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
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                Force = false,
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
                EntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
                Force = false,
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/entityTypes/[ENTITY_TYPE]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/entityTypes/[ENTITY_TYPE]";
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
            EntityTypeName name = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]");
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
            EntityTypeName name = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]");
            // Make the request
            await entityTypesClient.DeleteEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypesRequestObject()
        {
            // Snippet: ListEntityTypes(ListEntityTypesRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
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
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
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
        public void ListEntityTypes()
        {
            // Snippet: ListEntityTypes(string, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
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
        public async Task ListEntityTypesAsync()
        {
            // Snippet: ListEntityTypesAsync(string, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
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
        public void ListEntityTypesResourceNames()
        {
            // Snippet: ListEntityTypes(AgentName, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
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
        public async Task ListEntityTypesResourceNamesAsync()
        {
            // Snippet: ListEntityTypesAsync(AgentName, string, int?, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
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

        /// <summary>Snippet for ExportEntityTypes</summary>
        public void ExportEntityTypesRequestObject()
        {
            // Snippet: ExportEntityTypes(ExportEntityTypesRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            ExportEntityTypesRequest request = new ExportEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityTypes = { "", },
                EntityTypesUri = "",
                DataFormat = ExportEntityTypesRequest.Types.DataFormat.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata> response = entityTypesClient.ExportEntityTypes(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportEntityTypesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata> retrievedResponse = entityTypesClient.PollOnceExportEntityTypes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEntityTypesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportEntityTypesAsync</summary>
        public async Task ExportEntityTypesRequestObjectAsync()
        {
            // Snippet: ExportEntityTypesAsync(ExportEntityTypesRequest, CallSettings)
            // Additional: ExportEntityTypesAsync(ExportEntityTypesRequest, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            ExportEntityTypesRequest request = new ExportEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityTypes = { "", },
                EntityTypesUri = "",
                DataFormat = ExportEntityTypesRequest.Types.DataFormat.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata> response = await entityTypesClient.ExportEntityTypesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportEntityTypesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata> retrievedResponse = await entityTypesClient.PollOnceExportEntityTypesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEntityTypesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEntityTypes</summary>
        public void ImportEntityTypesRequestObject()
        {
            // Snippet: ImportEntityTypes(ImportEntityTypesRequest, CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            ImportEntityTypesRequest request = new ImportEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityTypesUri = "",
                MergeOption = ImportEntityTypesRequest.Types.MergeOption.Unspecified,
                TargetEntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
            };
            // Make the request
            Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> response = entityTypesClient.ImportEntityTypes(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportEntityTypesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> retrievedResponse = entityTypesClient.PollOnceImportEntityTypes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportEntityTypesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEntityTypesAsync</summary>
        public async Task ImportEntityTypesRequestObjectAsync()
        {
            // Snippet: ImportEntityTypesAsync(ImportEntityTypesRequest, CallSettings)
            // Additional: ImportEntityTypesAsync(ImportEntityTypesRequest, CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            ImportEntityTypesRequest request = new ImportEntityTypesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                EntityTypesUri = "",
                MergeOption = ImportEntityTypesRequest.Types.MergeOption.Unspecified,
                TargetEntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationAgentEntityType("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENTITY_TYPE]"),
            };
            // Make the request
            Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> response = await entityTypesClient.ImportEntityTypesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportEntityTypesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> retrievedResponse = await entityTypesClient.PollOnceImportEntityTypesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportEntityTypesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
