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
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSchemaServiceClientSnippets
    {
        /// <summary>Snippet for GetSchema</summary>
        public void GetSchemaRequestObject()
        {
            // Snippet: GetSchema(GetSchemaRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectLocationDataStoreSchema("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SCHEMA]"),
            };
            // Make the request
            Schema response = schemaServiceClient.GetSchema(request);
            // End snippet
        }

        /// <summary>Snippet for GetSchemaAsync</summary>
        public async Task GetSchemaRequestObjectAsync()
        {
            // Snippet: GetSchemaAsync(GetSchemaRequest, CallSettings)
            // Additional: GetSchemaAsync(GetSchemaRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectLocationDataStoreSchema("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SCHEMA]"),
            };
            // Make the request
            Schema response = await schemaServiceClient.GetSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSchema</summary>
        public void GetSchema()
        {
            // Snippet: GetSchema(string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/schemas/[SCHEMA]";
            // Make the request
            Schema response = schemaServiceClient.GetSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchemaAsync</summary>
        public async Task GetSchemaAsync()
        {
            // Snippet: GetSchemaAsync(string, CallSettings)
            // Additional: GetSchemaAsync(string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/schemas/[SCHEMA]";
            // Make the request
            Schema response = await schemaServiceClient.GetSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchema</summary>
        public void GetSchemaResourceNames()
        {
            // Snippet: GetSchema(SchemaName, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectLocationDataStoreSchema("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SCHEMA]");
            // Make the request
            Schema response = schemaServiceClient.GetSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchemaAsync</summary>
        public async Task GetSchemaResourceNamesAsync()
        {
            // Snippet: GetSchemaAsync(SchemaName, CallSettings)
            // Additional: GetSchemaAsync(SchemaName, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectLocationDataStoreSchema("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SCHEMA]");
            // Make the request
            Schema response = await schemaServiceClient.GetSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSchemas</summary>
        public void ListSchemasRequestObject()
        {
            // Snippet: ListSchemas(ListSchemasRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            ListSchemasRequest request = new ListSchemasRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            PagedEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemasAsync</summary>
        public async Task ListSchemasRequestObjectAsync()
        {
            // Snippet: ListSchemasAsync(ListSchemasRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSchemasRequest request = new ListSchemasRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemas</summary>
        public void ListSchemas()
        {
            // Snippet: ListSchemas(string, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            PagedEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemasAsync</summary>
        public async Task ListSchemasAsync()
        {
            // Snippet: ListSchemasAsync(string, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            PagedAsyncEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemas</summary>
        public void ListSchemasResourceNames()
        {
            // Snippet: ListSchemas(DataStoreName, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchemasAsync</summary>
        public async Task ListSchemasResourceNamesAsync()
        {
            // Snippet: ListSchemasAsync(DataStoreName, string, int?, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListSchemasResponse, Schema> response = schemaServiceClient.ListSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSchema</summary>
        public void CreateSchemaRequestObject()
        {
            // Snippet: CreateSchema(CreateSchemaRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            CreateSchemaRequest request = new CreateSchemaRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Schema = new Schema(),
                SchemaId = "",
            };
            // Make the request
            Operation<Schema, CreateSchemaMetadata> response = schemaServiceClient.CreateSchema(request);

            // Poll until the returned long-running operation is complete
            Operation<Schema, CreateSchemaMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Schema result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schema, CreateSchemaMetadata> retrievedResponse = schemaServiceClient.PollOnceCreateSchema(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schema retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSchemaAsync</summary>
        public async Task CreateSchemaRequestObjectAsync()
        {
            // Snippet: CreateSchemaAsync(CreateSchemaRequest, CallSettings)
            // Additional: CreateSchemaAsync(CreateSchemaRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSchemaRequest request = new CreateSchemaRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Schema = new Schema(),
                SchemaId = "",
            };
            // Make the request
            Operation<Schema, CreateSchemaMetadata> response = await schemaServiceClient.CreateSchemaAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Schema, CreateSchemaMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Schema result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schema, CreateSchemaMetadata> retrievedResponse = await schemaServiceClient.PollOnceCreateSchemaAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schema retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSchema</summary>
        public void CreateSchema()
        {
            // Snippet: CreateSchema(string, Schema, string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            Schema schema = new Schema();
            string schemaId = "";
            // Make the request
            Operation<Schema, CreateSchemaMetadata> response = schemaServiceClient.CreateSchema(parent, schema, schemaId);

            // Poll until the returned long-running operation is complete
            Operation<Schema, CreateSchemaMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Schema result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schema, CreateSchemaMetadata> retrievedResponse = schemaServiceClient.PollOnceCreateSchema(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schema retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSchemaAsync</summary>
        public async Task CreateSchemaAsync()
        {
            // Snippet: CreateSchemaAsync(string, Schema, string, CallSettings)
            // Additional: CreateSchemaAsync(string, Schema, string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            Schema schema = new Schema();
            string schemaId = "";
            // Make the request
            Operation<Schema, CreateSchemaMetadata> response = await schemaServiceClient.CreateSchemaAsync(parent, schema, schemaId);

            // Poll until the returned long-running operation is complete
            Operation<Schema, CreateSchemaMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Schema result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schema, CreateSchemaMetadata> retrievedResponse = await schemaServiceClient.PollOnceCreateSchemaAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schema retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSchema</summary>
        public void CreateSchemaResourceNames()
        {
            // Snippet: CreateSchema(DataStoreName, Schema, string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            Schema schema = new Schema();
            string schemaId = "";
            // Make the request
            Operation<Schema, CreateSchemaMetadata> response = schemaServiceClient.CreateSchema(parent, schema, schemaId);

            // Poll until the returned long-running operation is complete
            Operation<Schema, CreateSchemaMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Schema result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schema, CreateSchemaMetadata> retrievedResponse = schemaServiceClient.PollOnceCreateSchema(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schema retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSchemaAsync</summary>
        public async Task CreateSchemaResourceNamesAsync()
        {
            // Snippet: CreateSchemaAsync(DataStoreName, Schema, string, CallSettings)
            // Additional: CreateSchemaAsync(DataStoreName, Schema, string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            Schema schema = new Schema();
            string schemaId = "";
            // Make the request
            Operation<Schema, CreateSchemaMetadata> response = await schemaServiceClient.CreateSchemaAsync(parent, schema, schemaId);

            // Poll until the returned long-running operation is complete
            Operation<Schema, CreateSchemaMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Schema result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schema, CreateSchemaMetadata> retrievedResponse = await schemaServiceClient.PollOnceCreateSchemaAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schema retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSchema</summary>
        public void UpdateSchemaRequestObject()
        {
            // Snippet: UpdateSchema(UpdateSchemaRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            UpdateSchemaRequest request = new UpdateSchemaRequest
            {
                Schema = new Schema(),
                AllowMissing = false,
            };
            // Make the request
            Operation<Schema, UpdateSchemaMetadata> response = schemaServiceClient.UpdateSchema(request);

            // Poll until the returned long-running operation is complete
            Operation<Schema, UpdateSchemaMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Schema result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schema, UpdateSchemaMetadata> retrievedResponse = schemaServiceClient.PollOnceUpdateSchema(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schema retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSchemaAsync</summary>
        public async Task UpdateSchemaRequestObjectAsync()
        {
            // Snippet: UpdateSchemaAsync(UpdateSchemaRequest, CallSettings)
            // Additional: UpdateSchemaAsync(UpdateSchemaRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSchemaRequest request = new UpdateSchemaRequest
            {
                Schema = new Schema(),
                AllowMissing = false,
            };
            // Make the request
            Operation<Schema, UpdateSchemaMetadata> response = await schemaServiceClient.UpdateSchemaAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Schema, UpdateSchemaMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Schema result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schema, UpdateSchemaMetadata> retrievedResponse = await schemaServiceClient.PollOnceUpdateSchemaAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schema retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSchema</summary>
        public void DeleteSchemaRequestObject()
        {
            // Snippet: DeleteSchema(DeleteSchemaRequest, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            DeleteSchemaRequest request = new DeleteSchemaRequest
            {
                SchemaName = SchemaName.FromProjectLocationDataStoreSchema("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SCHEMA]"),
            };
            // Make the request
            Operation<Empty, DeleteSchemaMetadata> response = schemaServiceClient.DeleteSchema(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSchemaMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSchemaMetadata> retrievedResponse = schemaServiceClient.PollOnceDeleteSchema(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaAsync</summary>
        public async Task DeleteSchemaRequestObjectAsync()
        {
            // Snippet: DeleteSchemaAsync(DeleteSchemaRequest, CallSettings)
            // Additional: DeleteSchemaAsync(DeleteSchemaRequest, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSchemaRequest request = new DeleteSchemaRequest
            {
                SchemaName = SchemaName.FromProjectLocationDataStoreSchema("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SCHEMA]"),
            };
            // Make the request
            Operation<Empty, DeleteSchemaMetadata> response = await schemaServiceClient.DeleteSchemaAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSchemaMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSchemaMetadata> retrievedResponse = await schemaServiceClient.PollOnceDeleteSchemaAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSchema</summary>
        public void DeleteSchema()
        {
            // Snippet: DeleteSchema(string, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/schemas/[SCHEMA]";
            // Make the request
            Operation<Empty, DeleteSchemaMetadata> response = schemaServiceClient.DeleteSchema(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSchemaMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSchemaMetadata> retrievedResponse = schemaServiceClient.PollOnceDeleteSchema(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaAsync</summary>
        public async Task DeleteSchemaAsync()
        {
            // Snippet: DeleteSchemaAsync(string, CallSettings)
            // Additional: DeleteSchemaAsync(string, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/schemas/[SCHEMA]";
            // Make the request
            Operation<Empty, DeleteSchemaMetadata> response = await schemaServiceClient.DeleteSchemaAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSchemaMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSchemaMetadata> retrievedResponse = await schemaServiceClient.PollOnceDeleteSchemaAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSchema</summary>
        public void DeleteSchemaResourceNames()
        {
            // Snippet: DeleteSchema(SchemaName, CallSettings)
            // Create client
            SchemaServiceClient schemaServiceClient = SchemaServiceClient.Create();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectLocationDataStoreSchema("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SCHEMA]");
            // Make the request
            Operation<Empty, DeleteSchemaMetadata> response = schemaServiceClient.DeleteSchema(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSchemaMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSchemaMetadata> retrievedResponse = schemaServiceClient.PollOnceDeleteSchema(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSchemaAsync</summary>
        public async Task DeleteSchemaResourceNamesAsync()
        {
            // Snippet: DeleteSchemaAsync(SchemaName, CallSettings)
            // Additional: DeleteSchemaAsync(SchemaName, CancellationToken)
            // Create client
            SchemaServiceClient schemaServiceClient = await SchemaServiceClient.CreateAsync();
            // Initialize request argument(s)
            SchemaName name = SchemaName.FromProjectLocationDataStoreSchema("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SCHEMA]");
            // Make the request
            Operation<Empty, DeleteSchemaMetadata> response = await schemaServiceClient.DeleteSchemaAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteSchemaMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteSchemaMetadata> retrievedResponse = await schemaServiceClient.PollOnceDeleteSchemaAsync(operationName);
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
