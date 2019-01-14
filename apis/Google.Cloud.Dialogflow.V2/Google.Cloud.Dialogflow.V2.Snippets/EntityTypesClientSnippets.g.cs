// Copyright 2019 Google LLC
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

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedEntityTypesClientSnippets
    {
        /// <summary>Snippet for ListEntityTypesAsync</summary>
        public async Task ListEntityTypesAsync1()
        {
            // Snippet: ListEntityTypesAsync(ProjectAgentName,string,int?,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> response =
                entityTypesClient.ListEntityTypesAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypes1()
        {
            // Snippet: ListEntityTypes(ProjectAgentName,string,int?,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListEntityTypesResponse, EntityType> response =
                entityTypesClient.ListEntityTypes(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypesAsync</summary>
        public async Task ListEntityTypesAsync2()
        {
            // Snippet: ListEntityTypesAsync(ProjectAgentName,string,string,int?,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            string languageCode = "";
            // Make the request
            PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> response =
                entityTypesClient.ListEntityTypesAsync(parent: parent, languageCode: languageCode);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypes2()
        {
            // Snippet: ListEntityTypes(ProjectAgentName,string,string,int?,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            string languageCode = "";
            // Make the request
            PagedEnumerable<ListEntityTypesResponse, EntityType> response =
                entityTypesClient.ListEntityTypes(parent: parent, languageCode: languageCode);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypesAsync</summary>
        public async Task ListEntityTypesAsync_RequestObject()
        {
            // Snippet: ListEntityTypesAsync(ListEntityTypesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> response =
                entityTypesClient.ListEntityTypesAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypes_RequestObject()
        {
            // Snippet: ListEntityTypes(ListEntityTypesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListEntityTypesResponse, EntityType> response =
                entityTypesClient.ListEntityTypes(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityTypeAsync1()
        {
            // Snippet: GetEntityTypeAsync(EntityTypeName,CallSettings)
            // Additional: GetEntityTypeAsync(EntityTypeName,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            // Make the request
            EntityType response = await entityTypesClient.GetEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityType1()
        {
            // Snippet: GetEntityType(EntityTypeName,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            // Make the request
            EntityType response = entityTypesClient.GetEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityTypeAsync2()
        {
            // Snippet: GetEntityTypeAsync(EntityTypeName,string,CallSettings)
            // Additional: GetEntityTypeAsync(EntityTypeName,string,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            string languageCode = "";
            // Make the request
            EntityType response = await entityTypesClient.GetEntityTypeAsync(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityType2()
        {
            // Snippet: GetEntityType(EntityTypeName,string,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            string languageCode = "";
            // Make the request
            EntityType response = entityTypesClient.GetEntityType(name, languageCode);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityTypeAsync_RequestObject()
        {
            // Snippet: GetEntityTypeAsync(GetEntityTypeRequest,CallSettings)
            // Additional: GetEntityTypeAsync(GetEntityTypeRequest,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            // Make the request
            EntityType response = await entityTypesClient.GetEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityType_RequestObject()
        {
            // Snippet: GetEntityType(GetEntityTypeRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            // Make the request
            EntityType response = entityTypesClient.GetEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityTypeAsync1()
        {
            // Snippet: CreateEntityTypeAsync(ProjectAgentName,EntityType,CallSettings)
            // Additional: CreateEntityTypeAsync(ProjectAgentName,EntityType,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = await entityTypesClient.CreateEntityTypeAsync(parent, entityType);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType1()
        {
            // Snippet: CreateEntityType(ProjectAgentName,EntityType,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = entityTypesClient.CreateEntityType(parent, entityType);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityTypeAsync2()
        {
            // Snippet: CreateEntityTypeAsync(ProjectAgentName,EntityType,string,CallSettings)
            // Additional: CreateEntityTypeAsync(ProjectAgentName,EntityType,string,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            EntityType entityType = new EntityType();
            string languageCode = "";
            // Make the request
            EntityType response = await entityTypesClient.CreateEntityTypeAsync(parent, entityType, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType2()
        {
            // Snippet: CreateEntityType(ProjectAgentName,EntityType,string,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            EntityType entityType = new EntityType();
            string languageCode = "";
            // Make the request
            EntityType response = entityTypesClient.CreateEntityType(parent, entityType, languageCode);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityTypeAsync_RequestObject()
        {
            // Snippet: CreateEntityTypeAsync(CreateEntityTypeRequest,CallSettings)
            // Additional: CreateEntityTypeAsync(CreateEntityTypeRequest,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                EntityType = new EntityType(),
            };
            // Make the request
            EntityType response = await entityTypesClient.CreateEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType_RequestObject()
        {
            // Snippet: CreateEntityType(CreateEntityTypeRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                EntityType = new EntityType(),
            };
            // Make the request
            EntityType response = entityTypesClient.CreateEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityTypeAsync</summary>
        public async Task UpdateEntityTypeAsync1()
        {
            // Snippet: UpdateEntityTypeAsync(EntityType,CallSettings)
            // Additional: UpdateEntityTypeAsync(EntityType,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = await entityTypesClient.UpdateEntityTypeAsync(entityType);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityType</summary>
        public void UpdateEntityType1()
        {
            // Snippet: UpdateEntityType(EntityType,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            // Make the request
            EntityType response = entityTypesClient.UpdateEntityType(entityType);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityTypeAsync</summary>
        public async Task UpdateEntityTypeAsync2()
        {
            // Snippet: UpdateEntityTypeAsync(EntityType,string,CallSettings)
            // Additional: UpdateEntityTypeAsync(EntityType,string,CancellationToken)
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
        public void UpdateEntityType2()
        {
            // Snippet: UpdateEntityType(EntityType,string,CallSettings)
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
        public async Task UpdateEntityTypeAsync_RequestObject()
        {
            // Snippet: UpdateEntityTypeAsync(UpdateEntityTypeRequest,CallSettings)
            // Additional: UpdateEntityTypeAsync(UpdateEntityTypeRequest,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
            };
            // Make the request
            EntityType response = await entityTypesClient.UpdateEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityType</summary>
        public void UpdateEntityType_RequestObject()
        {
            // Snippet: UpdateEntityType(UpdateEntityTypeRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
            };
            // Make the request
            EntityType response = entityTypesClient.UpdateEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityTypeAsync</summary>
        public async Task DeleteEntityTypeAsync()
        {
            // Snippet: DeleteEntityTypeAsync(EntityTypeName,CallSettings)
            // Additional: DeleteEntityTypeAsync(EntityTypeName,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            // Make the request
            await entityTypesClient.DeleteEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityType</summary>
        public void DeleteEntityType()
        {
            // Snippet: DeleteEntityType(EntityTypeName,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName name = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            // Make the request
            entityTypesClient.DeleteEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityTypeAsync</summary>
        public async Task DeleteEntityTypeAsync_RequestObject()
        {
            // Snippet: DeleteEntityTypeAsync(DeleteEntityTypeRequest,CallSettings)
            // Additional: DeleteEntityTypeAsync(DeleteEntityTypeRequest,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            // Make the request
            await entityTypesClient.DeleteEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityType</summary>
        public void DeleteEntityType_RequestObject()
        {
            // Snippet: DeleteEntityType(DeleteEntityTypeRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
            };
            // Make the request
            entityTypesClient.DeleteEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntityTypesAsync</summary>
        public async Task BatchUpdateEntityTypesAsync_RequestObject()
        {
            // Snippet: BatchUpdateEntityTypesAsync(BatchUpdateEntityTypesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateEntityTypesRequest request = new BatchUpdateEntityTypesRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
            };
            // Make the request
            Operation<BatchUpdateEntityTypesResponse, Struct> response =
                await entityTypesClient.BatchUpdateEntityTypesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateEntityTypesResponse, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchUpdateEntityTypesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateEntityTypesResponse, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchUpdateEntityTypesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateEntityTypesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntityTypes</summary>
        public void BatchUpdateEntityTypes_RequestObject()
        {
            // Snippet: BatchUpdateEntityTypes(BatchUpdateEntityTypesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            BatchUpdateEntityTypesRequest request = new BatchUpdateEntityTypesRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
            };
            // Make the request
            Operation<BatchUpdateEntityTypesResponse, Struct> response =
                entityTypesClient.BatchUpdateEntityTypes(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateEntityTypesResponse, Struct> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            BatchUpdateEntityTypesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateEntityTypesResponse, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchUpdateEntityTypes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateEntityTypesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntityTypesAsync</summary>
        public async Task BatchDeleteEntityTypesAsync()
        {
            // Snippet: BatchDeleteEntityTypesAsync(ProjectAgentName,IEnumerable<string>,CallSettings)
            // Additional: BatchDeleteEntityTypesAsync(ProjectAgentName,IEnumerable<string>,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            IEnumerable<string> entityTypeNames = new List<string>();
            // Make the request
            Operation<Empty, Struct> response =
                await entityTypesClient.BatchDeleteEntityTypesAsync(parent, entityTypeNames);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchDeleteEntityTypesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntityTypes</summary>
        public void BatchDeleteEntityTypes()
        {
            // Snippet: BatchDeleteEntityTypes(ProjectAgentName,IEnumerable<string>,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            ProjectAgentName parent = new ProjectAgentName("[PROJECT]");
            IEnumerable<string> entityTypeNames = new List<string>();
            // Make the request
            Operation<Empty, Struct> response =
                entityTypesClient.BatchDeleteEntityTypes(parent, entityTypeNames);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchDeleteEntityTypes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntityTypesAsync</summary>
        public async Task BatchDeleteEntityTypesAsync_RequestObject()
        {
            // Snippet: BatchDeleteEntityTypesAsync(BatchDeleteEntityTypesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteEntityTypesRequest request = new BatchDeleteEntityTypesRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                EntityTypeNames = { },
            };
            // Make the request
            Operation<Empty, Struct> response =
                await entityTypesClient.BatchDeleteEntityTypesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchDeleteEntityTypesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntityTypes</summary>
        public void BatchDeleteEntityTypes_RequestObject()
        {
            // Snippet: BatchDeleteEntityTypes(BatchDeleteEntityTypesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            BatchDeleteEntityTypesRequest request = new BatchDeleteEntityTypesRequest
            {
                ParentAsProjectAgentName = new ProjectAgentName("[PROJECT]"),
                EntityTypeNames = { },
            };
            // Make the request
            Operation<Empty, Struct> response =
                entityTypesClient.BatchDeleteEntityTypes(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchDeleteEntityTypes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitiesAsync</summary>
        public async Task BatchCreateEntitiesAsync1()
        {
            // Snippet: BatchCreateEntitiesAsync(EntityTypeName,IEnumerable<EntityType.Types.Entity>,CallSettings)
            // Additional: BatchCreateEntitiesAsync(EntityTypeName,IEnumerable<EntityType.Types.Entity>,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new List<EntityType.Types.Entity>();
            // Make the request
            Operation<Empty, Struct> response =
                await entityTypesClient.BatchCreateEntitiesAsync(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchCreateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntities</summary>
        public void BatchCreateEntities1()
        {
            // Snippet: BatchCreateEntities(EntityTypeName,IEnumerable<EntityType.Types.Entity>,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new List<EntityType.Types.Entity>();
            // Make the request
            Operation<Empty, Struct> response =
                entityTypesClient.BatchCreateEntities(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchCreateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitiesAsync</summary>
        public async Task BatchCreateEntitiesAsync2()
        {
            // Snippet: BatchCreateEntitiesAsync(EntityTypeName,IEnumerable<EntityType.Types.Entity>,string,CallSettings)
            // Additional: BatchCreateEntitiesAsync(EntityTypeName,IEnumerable<EntityType.Types.Entity>,string,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new List<EntityType.Types.Entity>();
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response =
                await entityTypesClient.BatchCreateEntitiesAsync(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchCreateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntities</summary>
        public void BatchCreateEntities2()
        {
            // Snippet: BatchCreateEntities(EntityTypeName,IEnumerable<EntityType.Types.Entity>,string,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new List<EntityType.Types.Entity>();
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response =
                entityTypesClient.BatchCreateEntities(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchCreateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntitiesAsync</summary>
        public async Task BatchCreateEntitiesAsync_RequestObject()
        {
            // Snippet: BatchCreateEntitiesAsync(BatchCreateEntitiesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateEntitiesRequest request = new BatchCreateEntitiesRequest
            {
                ParentAsEntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                Entities = { },
            };
            // Make the request
            Operation<Empty, Struct> response =
                await entityTypesClient.BatchCreateEntitiesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchCreateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateEntities</summary>
        public void BatchCreateEntities_RequestObject()
        {
            // Snippet: BatchCreateEntities(BatchCreateEntitiesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            BatchCreateEntitiesRequest request = new BatchCreateEntitiesRequest
            {
                ParentAsEntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                Entities = { },
            };
            // Make the request
            Operation<Empty, Struct> response =
                entityTypesClient.BatchCreateEntities(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchCreateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitiesAsync</summary>
        public async Task BatchUpdateEntitiesAsync1()
        {
            // Snippet: BatchUpdateEntitiesAsync(EntityTypeName,IEnumerable<EntityType.Types.Entity>,CallSettings)
            // Additional: BatchUpdateEntitiesAsync(EntityTypeName,IEnumerable<EntityType.Types.Entity>,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new List<EntityType.Types.Entity>();
            // Make the request
            Operation<Empty, Struct> response =
                await entityTypesClient.BatchUpdateEntitiesAsync(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchUpdateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntities</summary>
        public void BatchUpdateEntities1()
        {
            // Snippet: BatchUpdateEntities(EntityTypeName,IEnumerable<EntityType.Types.Entity>,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new List<EntityType.Types.Entity>();
            // Make the request
            Operation<Empty, Struct> response =
                entityTypesClient.BatchUpdateEntities(parent, entities);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchUpdateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitiesAsync</summary>
        public async Task BatchUpdateEntitiesAsync2()
        {
            // Snippet: BatchUpdateEntitiesAsync(EntityTypeName,IEnumerable<EntityType.Types.Entity>,string,CallSettings)
            // Additional: BatchUpdateEntitiesAsync(EntityTypeName,IEnumerable<EntityType.Types.Entity>,string,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new List<EntityType.Types.Entity>();
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response =
                await entityTypesClient.BatchUpdateEntitiesAsync(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchUpdateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntities</summary>
        public void BatchUpdateEntities2()
        {
            // Snippet: BatchUpdateEntities(EntityTypeName,IEnumerable<EntityType.Types.Entity>,string,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<EntityType.Types.Entity> entities = new List<EntityType.Types.Entity>();
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response =
                entityTypesClient.BatchUpdateEntities(parent, entities, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchUpdateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntitiesAsync</summary>
        public async Task BatchUpdateEntitiesAsync_RequestObject()
        {
            // Snippet: BatchUpdateEntitiesAsync(BatchUpdateEntitiesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateEntitiesRequest request = new BatchUpdateEntitiesRequest
            {
                ParentAsEntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                Entities = { },
            };
            // Make the request
            Operation<Empty, Struct> response =
                await entityTypesClient.BatchUpdateEntitiesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchUpdateEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateEntities</summary>
        public void BatchUpdateEntities_RequestObject()
        {
            // Snippet: BatchUpdateEntities(BatchUpdateEntitiesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            BatchUpdateEntitiesRequest request = new BatchUpdateEntitiesRequest
            {
                ParentAsEntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                Entities = { },
            };
            // Make the request
            Operation<Empty, Struct> response =
                entityTypesClient.BatchUpdateEntities(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchUpdateEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntitiesAsync</summary>
        public async Task BatchDeleteEntitiesAsync1()
        {
            // Snippet: BatchDeleteEntitiesAsync(EntityTypeName,IEnumerable<string>,CallSettings)
            // Additional: BatchDeleteEntitiesAsync(EntityTypeName,IEnumerable<string>,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<string> entityValues = new List<string>();
            // Make the request
            Operation<Empty, Struct> response =
                await entityTypesClient.BatchDeleteEntitiesAsync(parent, entityValues);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchDeleteEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntities</summary>
        public void BatchDeleteEntities1()
        {
            // Snippet: BatchDeleteEntities(EntityTypeName,IEnumerable<string>,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<string> entityValues = new List<string>();
            // Make the request
            Operation<Empty, Struct> response =
                entityTypesClient.BatchDeleteEntities(parent, entityValues);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchDeleteEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntitiesAsync</summary>
        public async Task BatchDeleteEntitiesAsync2()
        {
            // Snippet: BatchDeleteEntitiesAsync(EntityTypeName,IEnumerable<string>,string,CallSettings)
            // Additional: BatchDeleteEntitiesAsync(EntityTypeName,IEnumerable<string>,string,CancellationToken)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<string> entityValues = new List<string>();
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response =
                await entityTypesClient.BatchDeleteEntitiesAsync(parent, entityValues, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchDeleteEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntities</summary>
        public void BatchDeleteEntities2()
        {
            // Snippet: BatchDeleteEntities(EntityTypeName,IEnumerable<string>,string,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]");
            IEnumerable<string> entityValues = new List<string>();
            string languageCode = "";
            // Make the request
            Operation<Empty, Struct> response =
                entityTypesClient.BatchDeleteEntities(parent, entityValues, languageCode);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchDeleteEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntitiesAsync</summary>
        public async Task BatchDeleteEntitiesAsync_RequestObject()
        {
            // Snippet: BatchDeleteEntitiesAsync(BatchDeleteEntitiesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = await EntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteEntitiesRequest request = new BatchDeleteEntitiesRequest
            {
                ParentAsEntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                EntityValues = { },
            };
            // Make the request
            Operation<Empty, Struct> response =
                await entityTypesClient.BatchDeleteEntitiesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                await entityTypesClient.PollOnceBatchDeleteEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteEntities</summary>
        public void BatchDeleteEntities_RequestObject()
        {
            // Snippet: BatchDeleteEntities(BatchDeleteEntitiesRequest,CallSettings)
            // Create client
            EntityTypesClient entityTypesClient = EntityTypesClient.Create();
            // Initialize request argument(s)
            BatchDeleteEntitiesRequest request = new BatchDeleteEntitiesRequest
            {
                ParentAsEntityTypeName = new EntityTypeName("[PROJECT]", "[ENTITY_TYPE]"),
                EntityValues = { },
            };
            // Make the request
            Operation<Empty, Struct> response =
                entityTypesClient.BatchDeleteEntities(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Struct> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Struct> retrievedResponse =
                entityTypesClient.PollOnceBatchDeleteEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

    }
}
