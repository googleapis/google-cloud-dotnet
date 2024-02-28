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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMetadataServiceClientSnippets
    {
        /// <summary>Snippet for CreateMetadataStore</summary>
        public void CreateMetadataStoreRequestObject()
        {
            // Snippet: CreateMetadataStore(CreateMetadataStoreRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            CreateMetadataStoreRequest request = new CreateMetadataStoreRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MetadataStore = new MetadataStore(),
                MetadataStoreId = "",
            };
            // Make the request
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> response = metadataServiceClient.CreateMetadataStore(request);

            // Poll until the returned long-running operation is complete
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MetadataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceCreateMetadataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MetadataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataStoreAsync</summary>
        public async Task CreateMetadataStoreRequestObjectAsync()
        {
            // Snippet: CreateMetadataStoreAsync(CreateMetadataStoreRequest, CallSettings)
            // Additional: CreateMetadataStoreAsync(CreateMetadataStoreRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMetadataStoreRequest request = new CreateMetadataStoreRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MetadataStore = new MetadataStore(),
                MetadataStoreId = "",
            };
            // Make the request
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> response = await metadataServiceClient.CreateMetadataStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MetadataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceCreateMetadataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MetadataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataStore</summary>
        public void CreateMetadataStore()
        {
            // Snippet: CreateMetadataStore(string, MetadataStore, string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MetadataStore metadataStore = new MetadataStore();
            string metadataStoreId = "";
            // Make the request
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> response = metadataServiceClient.CreateMetadataStore(parent, metadataStore, metadataStoreId);

            // Poll until the returned long-running operation is complete
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MetadataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceCreateMetadataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MetadataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataStoreAsync</summary>
        public async Task CreateMetadataStoreAsync()
        {
            // Snippet: CreateMetadataStoreAsync(string, MetadataStore, string, CallSettings)
            // Additional: CreateMetadataStoreAsync(string, MetadataStore, string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MetadataStore metadataStore = new MetadataStore();
            string metadataStoreId = "";
            // Make the request
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> response = await metadataServiceClient.CreateMetadataStoreAsync(parent, metadataStore, metadataStoreId);

            // Poll until the returned long-running operation is complete
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MetadataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceCreateMetadataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MetadataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataStore</summary>
        public void CreateMetadataStoreResourceNames()
        {
            // Snippet: CreateMetadataStore(LocationName, MetadataStore, string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MetadataStore metadataStore = new MetadataStore();
            string metadataStoreId = "";
            // Make the request
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> response = metadataServiceClient.CreateMetadataStore(parent, metadataStore, metadataStoreId);

            // Poll until the returned long-running operation is complete
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MetadataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceCreateMetadataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MetadataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataStoreAsync</summary>
        public async Task CreateMetadataStoreResourceNamesAsync()
        {
            // Snippet: CreateMetadataStoreAsync(LocationName, MetadataStore, string, CallSettings)
            // Additional: CreateMetadataStoreAsync(LocationName, MetadataStore, string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MetadataStore metadataStore = new MetadataStore();
            string metadataStoreId = "";
            // Make the request
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> response = await metadataServiceClient.CreateMetadataStoreAsync(parent, metadataStore, metadataStoreId);

            // Poll until the returned long-running operation is complete
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MetadataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MetadataStore, CreateMetadataStoreOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceCreateMetadataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MetadataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetMetadataStore</summary>
        public void GetMetadataStoreRequestObject()
        {
            // Snippet: GetMetadataStore(GetMetadataStoreRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            GetMetadataStoreRequest request = new GetMetadataStoreRequest
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
            };
            // Make the request
            MetadataStore response = metadataServiceClient.GetMetadataStore(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataStoreAsync</summary>
        public async Task GetMetadataStoreRequestObjectAsync()
        {
            // Snippet: GetMetadataStoreAsync(GetMetadataStoreRequest, CallSettings)
            // Additional: GetMetadataStoreAsync(GetMetadataStoreRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMetadataStoreRequest request = new GetMetadataStoreRequest
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
            };
            // Make the request
            MetadataStore response = await metadataServiceClient.GetMetadataStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataStore</summary>
        public void GetMetadataStore()
        {
            // Snippet: GetMetadataStore(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            MetadataStore response = metadataServiceClient.GetMetadataStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataStoreAsync</summary>
        public async Task GetMetadataStoreAsync()
        {
            // Snippet: GetMetadataStoreAsync(string, CallSettings)
            // Additional: GetMetadataStoreAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            MetadataStore response = await metadataServiceClient.GetMetadataStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataStore</summary>
        public void GetMetadataStoreResourceNames()
        {
            // Snippet: GetMetadataStore(MetadataStoreName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName name = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            MetadataStore response = metadataServiceClient.GetMetadataStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataStoreAsync</summary>
        public async Task GetMetadataStoreResourceNamesAsync()
        {
            // Snippet: GetMetadataStoreAsync(MetadataStoreName, CallSettings)
            // Additional: GetMetadataStoreAsync(MetadataStoreName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName name = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            MetadataStore response = await metadataServiceClient.GetMetadataStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMetadataStores</summary>
        public void ListMetadataStoresRequestObject()
        {
            // Snippet: ListMetadataStores(ListMetadataStoresRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ListMetadataStoresRequest request = new ListMetadataStoresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListMetadataStoresResponse, MetadataStore> response = metadataServiceClient.ListMetadataStores(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetadataStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetadataStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataStoresAsync</summary>
        public async Task ListMetadataStoresRequestObjectAsync()
        {
            // Snippet: ListMetadataStoresAsync(ListMetadataStoresRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMetadataStoresRequest request = new ListMetadataStoresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMetadataStoresResponse, MetadataStore> response = metadataServiceClient.ListMetadataStoresAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetadataStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetadataStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataStores</summary>
        public void ListMetadataStores()
        {
            // Snippet: ListMetadataStores(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMetadataStoresResponse, MetadataStore> response = metadataServiceClient.ListMetadataStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetadataStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetadataStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataStoresAsync</summary>
        public async Task ListMetadataStoresAsync()
        {
            // Snippet: ListMetadataStoresAsync(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMetadataStoresResponse, MetadataStore> response = metadataServiceClient.ListMetadataStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetadataStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetadataStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataStores</summary>
        public void ListMetadataStoresResourceNames()
        {
            // Snippet: ListMetadataStores(LocationName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMetadataStoresResponse, MetadataStore> response = metadataServiceClient.ListMetadataStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetadataStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetadataStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataStoresAsync</summary>
        public async Task ListMetadataStoresResourceNamesAsync()
        {
            // Snippet: ListMetadataStoresAsync(LocationName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMetadataStoresResponse, MetadataStore> response = metadataServiceClient.ListMetadataStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetadataStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetadataStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteMetadataStore</summary>
        public void DeleteMetadataStoreRequestObject()
        {
            // Snippet: DeleteMetadataStore(DeleteMetadataStoreRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            DeleteMetadataStoreRequest request = new DeleteMetadataStoreRequest
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
            };
            // Make the request
            Operation<Empty, DeleteMetadataStoreOperationMetadata> response = metadataServiceClient.DeleteMetadataStore(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMetadataStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMetadataStoreOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteMetadataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMetadataStoreAsync</summary>
        public async Task DeleteMetadataStoreRequestObjectAsync()
        {
            // Snippet: DeleteMetadataStoreAsync(DeleteMetadataStoreRequest, CallSettings)
            // Additional: DeleteMetadataStoreAsync(DeleteMetadataStoreRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMetadataStoreRequest request = new DeleteMetadataStoreRequest
            {
                MetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
            };
            // Make the request
            Operation<Empty, DeleteMetadataStoreOperationMetadata> response = await metadataServiceClient.DeleteMetadataStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMetadataStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMetadataStoreOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteMetadataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMetadataStore</summary>
        public void DeleteMetadataStore()
        {
            // Snippet: DeleteMetadataStore(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            Operation<Empty, DeleteMetadataStoreOperationMetadata> response = metadataServiceClient.DeleteMetadataStore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMetadataStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMetadataStoreOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteMetadataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMetadataStoreAsync</summary>
        public async Task DeleteMetadataStoreAsync()
        {
            // Snippet: DeleteMetadataStoreAsync(string, CallSettings)
            // Additional: DeleteMetadataStoreAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            Operation<Empty, DeleteMetadataStoreOperationMetadata> response = await metadataServiceClient.DeleteMetadataStoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMetadataStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMetadataStoreOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteMetadataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMetadataStore</summary>
        public void DeleteMetadataStoreResourceNames()
        {
            // Snippet: DeleteMetadataStore(MetadataStoreName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName name = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            Operation<Empty, DeleteMetadataStoreOperationMetadata> response = metadataServiceClient.DeleteMetadataStore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMetadataStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMetadataStoreOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteMetadataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMetadataStoreAsync</summary>
        public async Task DeleteMetadataStoreResourceNamesAsync()
        {
            // Snippet: DeleteMetadataStoreAsync(MetadataStoreName, CallSettings)
            // Additional: DeleteMetadataStoreAsync(MetadataStoreName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName name = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            Operation<Empty, DeleteMetadataStoreOperationMetadata> response = await metadataServiceClient.DeleteMetadataStoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMetadataStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMetadataStoreOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteMetadataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifactRequestObject()
        {
            // Snippet: CreateArtifact(CreateArtifactRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Artifact = new Artifact(),
                ArtifactId = "",
            };
            // Make the request
            Artifact response = metadataServiceClient.CreateArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactRequestObjectAsync()
        {
            // Snippet: CreateArtifactAsync(CreateArtifactRequest, CallSettings)
            // Additional: CreateArtifactAsync(CreateArtifactRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Artifact = new Artifact(),
                ArtifactId = "",
            };
            // Make the request
            Artifact response = await metadataServiceClient.CreateArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifact()
        {
            // Snippet: CreateArtifact(string, Artifact, string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = metadataServiceClient.CreateArtifact(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactAsync()
        {
            // Snippet: CreateArtifactAsync(string, Artifact, string, CallSettings)
            // Additional: CreateArtifactAsync(string, Artifact, string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = await metadataServiceClient.CreateArtifactAsync(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifactResourceNames()
        {
            // Snippet: CreateArtifact(MetadataStoreName, Artifact, string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = metadataServiceClient.CreateArtifact(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactResourceNamesAsync()
        {
            // Snippet: CreateArtifactAsync(MetadataStoreName, Artifact, string, CallSettings)
            // Additional: CreateArtifactAsync(MetadataStoreName, Artifact, string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            Artifact artifact = new Artifact();
            string artifactId = "";
            // Make the request
            Artifact response = await metadataServiceClient.CreateArtifactAsync(parent, artifact, artifactId);
            // End snippet
        }

        /// <summary>Snippet for GetArtifact</summary>
        public void GetArtifactRequestObject()
        {
            // Snippet: GetArtifact(GetArtifactRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            // Make the request
            Artifact response = metadataServiceClient.GetArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactAsync</summary>
        public async Task GetArtifactRequestObjectAsync()
        {
            // Snippet: GetArtifactAsync(GetArtifactRequest, CallSettings)
            // Additional: GetArtifactAsync(GetArtifactRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            // Make the request
            Artifact response = await metadataServiceClient.GetArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetArtifact</summary>
        public void GetArtifact()
        {
            // Snippet: GetArtifact(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/artifacts/[ARTIFACT]";
            // Make the request
            Artifact response = metadataServiceClient.GetArtifact(name);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactAsync</summary>
        public async Task GetArtifactAsync()
        {
            // Snippet: GetArtifactAsync(string, CallSettings)
            // Additional: GetArtifactAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/artifacts/[ARTIFACT]";
            // Make the request
            Artifact response = await metadataServiceClient.GetArtifactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetArtifact</summary>
        public void GetArtifactResourceNames()
        {
            // Snippet: GetArtifact(ArtifactName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ArtifactName name = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]");
            // Make the request
            Artifact response = metadataServiceClient.GetArtifact(name);
            // End snippet
        }

        /// <summary>Snippet for GetArtifactAsync</summary>
        public async Task GetArtifactResourceNamesAsync()
        {
            // Snippet: GetArtifactAsync(ArtifactName, CallSettings)
            // Additional: GetArtifactAsync(ArtifactName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ArtifactName name = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]");
            // Make the request
            Artifact response = await metadataServiceClient.GetArtifactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifactsRequestObject()
        {
            // Snippet: ListArtifacts(ListArtifactsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response = metadataServiceClient.ListArtifacts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsRequestObjectAsync()
        {
            // Snippet: ListArtifactsAsync(ListArtifactsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response = metadataServiceClient.ListArtifactsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifacts()
        {
            // Snippet: ListArtifacts(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response = metadataServiceClient.ListArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsAsync()
        {
            // Snippet: ListArtifactsAsync(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response = metadataServiceClient.ListArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifactsResourceNames()
        {
            // Snippet: ListArtifacts(MetadataStoreName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response = metadataServiceClient.ListArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsResourceNamesAsync()
        {
            // Snippet: ListArtifactsAsync(MetadataStoreName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response = metadataServiceClient.ListArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateArtifact</summary>
        public void UpdateArtifactRequestObject()
        {
            // Snippet: UpdateArtifact(UpdateArtifactRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            UpdateArtifactRequest request = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Artifact response = metadataServiceClient.UpdateArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateArtifactAsync</summary>
        public async Task UpdateArtifactRequestObjectAsync()
        {
            // Snippet: UpdateArtifactAsync(UpdateArtifactRequest, CallSettings)
            // Additional: UpdateArtifactAsync(UpdateArtifactRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateArtifactRequest request = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Artifact response = await metadataServiceClient.UpdateArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateArtifact</summary>
        public void UpdateArtifact()
        {
            // Snippet: UpdateArtifact(Artifact, FieldMask, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            Artifact artifact = new Artifact();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Artifact response = metadataServiceClient.UpdateArtifact(artifact, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateArtifactAsync</summary>
        public async Task UpdateArtifactAsync()
        {
            // Snippet: UpdateArtifactAsync(Artifact, FieldMask, CallSettings)
            // Additional: UpdateArtifactAsync(Artifact, FieldMask, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            Artifact artifact = new Artifact();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Artifact response = await metadataServiceClient.UpdateArtifactAsync(artifact, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifact</summary>
        public void DeleteArtifactRequestObject()
        {
            // Snippet: DeleteArtifact(DeleteArtifactRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = metadataServiceClient.DeleteArtifact(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteArtifact(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifactAsync</summary>
        public async Task DeleteArtifactRequestObjectAsync()
        {
            // Snippet: DeleteArtifactAsync(DeleteArtifactRequest, CallSettings)
            // Additional: DeleteArtifactAsync(DeleteArtifactRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await metadataServiceClient.DeleteArtifactAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteArtifactAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifact</summary>
        public void DeleteArtifact()
        {
            // Snippet: DeleteArtifact(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/artifacts/[ARTIFACT]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = metadataServiceClient.DeleteArtifact(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteArtifact(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifactAsync</summary>
        public async Task DeleteArtifactAsync()
        {
            // Snippet: DeleteArtifactAsync(string, CallSettings)
            // Additional: DeleteArtifactAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/artifacts/[ARTIFACT]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await metadataServiceClient.DeleteArtifactAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteArtifactAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifact</summary>
        public void DeleteArtifactResourceNames()
        {
            // Snippet: DeleteArtifact(ArtifactName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ArtifactName name = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = metadataServiceClient.DeleteArtifact(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteArtifact(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifactAsync</summary>
        public async Task DeleteArtifactResourceNamesAsync()
        {
            // Snippet: DeleteArtifactAsync(ArtifactName, CallSettings)
            // Additional: DeleteArtifactAsync(ArtifactName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ArtifactName name = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await metadataServiceClient.DeleteArtifactAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteArtifactAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeArtifacts</summary>
        public void PurgeArtifactsRequestObject()
        {
            // Snippet: PurgeArtifacts(PurgeArtifactsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            PurgeArtifactsRequest request = new PurgeArtifactsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> response = metadataServiceClient.PurgeArtifacts(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> retrievedResponse = metadataServiceClient.PollOncePurgeArtifacts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeArtifactsAsync</summary>
        public async Task PurgeArtifactsRequestObjectAsync()
        {
            // Snippet: PurgeArtifactsAsync(PurgeArtifactsRequest, CallSettings)
            // Additional: PurgeArtifactsAsync(PurgeArtifactsRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeArtifactsRequest request = new PurgeArtifactsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> response = await metadataServiceClient.PurgeArtifactsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> retrievedResponse = await metadataServiceClient.PollOncePurgeArtifactsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeArtifacts</summary>
        public void PurgeArtifacts()
        {
            // Snippet: PurgeArtifacts(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> response = metadataServiceClient.PurgeArtifacts(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> retrievedResponse = metadataServiceClient.PollOncePurgeArtifacts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeArtifactsAsync</summary>
        public async Task PurgeArtifactsAsync()
        {
            // Snippet: PurgeArtifactsAsync(string, CallSettings)
            // Additional: PurgeArtifactsAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> response = await metadataServiceClient.PurgeArtifactsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> retrievedResponse = await metadataServiceClient.PollOncePurgeArtifactsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeArtifacts</summary>
        public void PurgeArtifactsResourceNames()
        {
            // Snippet: PurgeArtifacts(MetadataStoreName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> response = metadataServiceClient.PurgeArtifacts(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> retrievedResponse = metadataServiceClient.PollOncePurgeArtifacts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeArtifactsAsync</summary>
        public async Task PurgeArtifactsResourceNamesAsync()
        {
            // Snippet: PurgeArtifactsAsync(MetadataStoreName, CallSettings)
            // Additional: PurgeArtifactsAsync(MetadataStoreName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> response = await metadataServiceClient.PurgeArtifactsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> retrievedResponse = await metadataServiceClient.PollOncePurgeArtifactsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateContext</summary>
        public void CreateContextRequestObject()
        {
            // Snippet: CreateContext(CreateContextRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Context = new Context(),
                ContextId = "",
            };
            // Make the request
            Context response = metadataServiceClient.CreateContext(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContextAsync</summary>
        public async Task CreateContextRequestObjectAsync()
        {
            // Snippet: CreateContextAsync(CreateContextRequest, CallSettings)
            // Additional: CreateContextAsync(CreateContextRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Context = new Context(),
                ContextId = "",
            };
            // Make the request
            Context response = await metadataServiceClient.CreateContextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContext</summary>
        public void CreateContext()
        {
            // Snippet: CreateContext(string, Context, string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            Context context = new Context();
            string contextId = "";
            // Make the request
            Context response = metadataServiceClient.CreateContext(parent, context, contextId);
            // End snippet
        }

        /// <summary>Snippet for CreateContextAsync</summary>
        public async Task CreateContextAsync()
        {
            // Snippet: CreateContextAsync(string, Context, string, CallSettings)
            // Additional: CreateContextAsync(string, Context, string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            Context context = new Context();
            string contextId = "";
            // Make the request
            Context response = await metadataServiceClient.CreateContextAsync(parent, context, contextId);
            // End snippet
        }

        /// <summary>Snippet for CreateContext</summary>
        public void CreateContextResourceNames()
        {
            // Snippet: CreateContext(MetadataStoreName, Context, string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            Context context = new Context();
            string contextId = "";
            // Make the request
            Context response = metadataServiceClient.CreateContext(parent, context, contextId);
            // End snippet
        }

        /// <summary>Snippet for CreateContextAsync</summary>
        public async Task CreateContextResourceNamesAsync()
        {
            // Snippet: CreateContextAsync(MetadataStoreName, Context, string, CallSettings)
            // Additional: CreateContextAsync(MetadataStoreName, Context, string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            Context context = new Context();
            string contextId = "";
            // Make the request
            Context response = await metadataServiceClient.CreateContextAsync(parent, context, contextId);
            // End snippet
        }

        /// <summary>Snippet for GetContext</summary>
        public void GetContextRequestObject()
        {
            // Snippet: GetContext(GetContextRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            // Make the request
            Context response = metadataServiceClient.GetContext(request);
            // End snippet
        }

        /// <summary>Snippet for GetContextAsync</summary>
        public async Task GetContextRequestObjectAsync()
        {
            // Snippet: GetContextAsync(GetContextRequest, CallSettings)
            // Additional: GetContextAsync(GetContextRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            // Make the request
            Context response = await metadataServiceClient.GetContextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetContext</summary>
        public void GetContext()
        {
            // Snippet: GetContext(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            // Make the request
            Context response = metadataServiceClient.GetContext(name);
            // End snippet
        }

        /// <summary>Snippet for GetContextAsync</summary>
        public async Task GetContextAsync()
        {
            // Snippet: GetContextAsync(string, CallSettings)
            // Additional: GetContextAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            // Make the request
            Context response = await metadataServiceClient.GetContextAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetContext</summary>
        public void GetContextResourceNames()
        {
            // Snippet: GetContext(ContextName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ContextName name = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            // Make the request
            Context response = metadataServiceClient.GetContext(name);
            // End snippet
        }

        /// <summary>Snippet for GetContextAsync</summary>
        public async Task GetContextResourceNamesAsync()
        {
            // Snippet: GetContextAsync(ContextName, CallSettings)
            // Additional: GetContextAsync(ContextName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContextName name = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            // Make the request
            Context response = await metadataServiceClient.GetContextAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListContexts</summary>
        public void ListContextsRequestObject()
        {
            // Snippet: ListContexts(ListContextsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ListContextsRequest request = new ListContextsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListContextsResponse, Context> response = metadataServiceClient.ListContexts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Context item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContextsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Context item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Context> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Context item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContextsAsync</summary>
        public async Task ListContextsRequestObjectAsync()
        {
            // Snippet: ListContextsAsync(ListContextsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListContextsRequest request = new ListContextsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListContextsResponse, Context> response = metadataServiceClient.ListContextsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Context item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContextsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Context item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Context> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Context item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContexts</summary>
        public void ListContexts()
        {
            // Snippet: ListContexts(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            PagedEnumerable<ListContextsResponse, Context> response = metadataServiceClient.ListContexts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Context item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContextsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Context item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Context> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Context item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContextsAsync</summary>
        public async Task ListContextsAsync()
        {
            // Snippet: ListContextsAsync(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            PagedAsyncEnumerable<ListContextsResponse, Context> response = metadataServiceClient.ListContextsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Context item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContextsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Context item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Context> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Context item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContexts</summary>
        public void ListContextsResourceNames()
        {
            // Snippet: ListContexts(MetadataStoreName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            PagedEnumerable<ListContextsResponse, Context> response = metadataServiceClient.ListContexts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Context item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContextsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Context item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Context> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Context item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContextsAsync</summary>
        public async Task ListContextsResourceNamesAsync()
        {
            // Snippet: ListContextsAsync(MetadataStoreName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListContextsResponse, Context> response = metadataServiceClient.ListContextsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Context item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContextsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Context item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Context> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Context item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateContext</summary>
        public void UpdateContextRequestObject()
        {
            // Snippet: UpdateContext(UpdateContextRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Context response = metadataServiceClient.UpdateContext(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateContextAsync</summary>
        public async Task UpdateContextRequestObjectAsync()
        {
            // Snippet: UpdateContextAsync(UpdateContextRequest, CallSettings)
            // Additional: UpdateContextAsync(UpdateContextRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Context response = await metadataServiceClient.UpdateContextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateContext</summary>
        public void UpdateContext()
        {
            // Snippet: UpdateContext(Context, FieldMask, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            Context context = new Context();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Context response = metadataServiceClient.UpdateContext(context, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateContextAsync</summary>
        public async Task UpdateContextAsync()
        {
            // Snippet: UpdateContextAsync(Context, FieldMask, CallSettings)
            // Additional: UpdateContextAsync(Context, FieldMask, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            Context context = new Context();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Context response = await metadataServiceClient.UpdateContextAsync(context, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteContext</summary>
        public void DeleteContextRequestObject()
        {
            // Snippet: DeleteContext(DeleteContextRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = metadataServiceClient.DeleteContext(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteContext(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteContextAsync</summary>
        public async Task DeleteContextRequestObjectAsync()
        {
            // Snippet: DeleteContextAsync(DeleteContextRequest, CallSettings)
            // Additional: DeleteContextAsync(DeleteContextRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await metadataServiceClient.DeleteContextAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteContextAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteContext</summary>
        public void DeleteContext()
        {
            // Snippet: DeleteContext(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = metadataServiceClient.DeleteContext(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteContext(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteContextAsync</summary>
        public async Task DeleteContextAsync()
        {
            // Snippet: DeleteContextAsync(string, CallSettings)
            // Additional: DeleteContextAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await metadataServiceClient.DeleteContextAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteContextAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteContext</summary>
        public void DeleteContextResourceNames()
        {
            // Snippet: DeleteContext(ContextName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ContextName name = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = metadataServiceClient.DeleteContext(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteContext(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteContextAsync</summary>
        public async Task DeleteContextResourceNamesAsync()
        {
            // Snippet: DeleteContextAsync(ContextName, CallSettings)
            // Additional: DeleteContextAsync(ContextName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContextName name = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await metadataServiceClient.DeleteContextAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteContextAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeContexts</summary>
        public void PurgeContextsRequestObject()
        {
            // Snippet: PurgeContexts(PurgeContextsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            PurgeContextsRequest request = new PurgeContextsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeContextsResponse, PurgeContextsMetadata> response = metadataServiceClient.PurgeContexts(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeContextsResponse, PurgeContextsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeContextsResponse, PurgeContextsMetadata> retrievedResponse = metadataServiceClient.PollOncePurgeContexts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeContextsAsync</summary>
        public async Task PurgeContextsRequestObjectAsync()
        {
            // Snippet: PurgeContextsAsync(PurgeContextsRequest, CallSettings)
            // Additional: PurgeContextsAsync(PurgeContextsRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeContextsRequest request = new PurgeContextsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeContextsResponse, PurgeContextsMetadata> response = await metadataServiceClient.PurgeContextsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeContextsResponse, PurgeContextsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeContextsResponse, PurgeContextsMetadata> retrievedResponse = await metadataServiceClient.PollOncePurgeContextsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeContexts</summary>
        public void PurgeContexts()
        {
            // Snippet: PurgeContexts(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            Operation<PurgeContextsResponse, PurgeContextsMetadata> response = metadataServiceClient.PurgeContexts(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeContextsResponse, PurgeContextsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeContextsResponse, PurgeContextsMetadata> retrievedResponse = metadataServiceClient.PollOncePurgeContexts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeContextsAsync</summary>
        public async Task PurgeContextsAsync()
        {
            // Snippet: PurgeContextsAsync(string, CallSettings)
            // Additional: PurgeContextsAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            Operation<PurgeContextsResponse, PurgeContextsMetadata> response = await metadataServiceClient.PurgeContextsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeContextsResponse, PurgeContextsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeContextsResponse, PurgeContextsMetadata> retrievedResponse = await metadataServiceClient.PollOncePurgeContextsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeContexts</summary>
        public void PurgeContextsResourceNames()
        {
            // Snippet: PurgeContexts(MetadataStoreName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            Operation<PurgeContextsResponse, PurgeContextsMetadata> response = metadataServiceClient.PurgeContexts(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeContextsResponse, PurgeContextsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeContextsResponse, PurgeContextsMetadata> retrievedResponse = metadataServiceClient.PollOncePurgeContexts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeContextsAsync</summary>
        public async Task PurgeContextsResourceNamesAsync()
        {
            // Snippet: PurgeContextsAsync(MetadataStoreName, CallSettings)
            // Additional: PurgeContextsAsync(MetadataStoreName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            Operation<PurgeContextsResponse, PurgeContextsMetadata> response = await metadataServiceClient.PurgeContextsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeContextsResponse, PurgeContextsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeContextsResponse, PurgeContextsMetadata> retrievedResponse = await metadataServiceClient.PollOncePurgeContextsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddContextArtifactsAndExecutions</summary>
        public void AddContextArtifactsAndExecutionsRequestObject()
        {
            // Snippet: AddContextArtifactsAndExecutions(AddContextArtifactsAndExecutionsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            AddContextArtifactsAndExecutionsRequest request = new AddContextArtifactsAndExecutionsRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ArtifactsAsArtifactNames =
                {
                    ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                },
                ExecutionsAsExecutionNames =
                {
                    ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                },
            };
            // Make the request
            AddContextArtifactsAndExecutionsResponse response = metadataServiceClient.AddContextArtifactsAndExecutions(request);
            // End snippet
        }

        /// <summary>Snippet for AddContextArtifactsAndExecutionsAsync</summary>
        public async Task AddContextArtifactsAndExecutionsRequestObjectAsync()
        {
            // Snippet: AddContextArtifactsAndExecutionsAsync(AddContextArtifactsAndExecutionsRequest, CallSettings)
            // Additional: AddContextArtifactsAndExecutionsAsync(AddContextArtifactsAndExecutionsRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddContextArtifactsAndExecutionsRequest request = new AddContextArtifactsAndExecutionsRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ArtifactsAsArtifactNames =
                {
                    ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                },
                ExecutionsAsExecutionNames =
                {
                    ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                },
            };
            // Make the request
            AddContextArtifactsAndExecutionsResponse response = await metadataServiceClient.AddContextArtifactsAndExecutionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddContextArtifactsAndExecutions</summary>
        public void AddContextArtifactsAndExecutions()
        {
            // Snippet: AddContextArtifactsAndExecutions(string, IEnumerable<string>, IEnumerable<string>, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string context = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            IEnumerable<string> artifacts = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/artifacts/[ARTIFACT]",
            };
            IEnumerable<string> executions = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/executions/[EXECUTION]",
            };
            // Make the request
            AddContextArtifactsAndExecutionsResponse response = metadataServiceClient.AddContextArtifactsAndExecutions(context, artifacts, executions);
            // End snippet
        }

        /// <summary>Snippet for AddContextArtifactsAndExecutionsAsync</summary>
        public async Task AddContextArtifactsAndExecutionsAsync()
        {
            // Snippet: AddContextArtifactsAndExecutionsAsync(string, IEnumerable<string>, IEnumerable<string>, CallSettings)
            // Additional: AddContextArtifactsAndExecutionsAsync(string, IEnumerable<string>, IEnumerable<string>, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string context = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            IEnumerable<string> artifacts = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/artifacts/[ARTIFACT]",
            };
            IEnumerable<string> executions = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/executions/[EXECUTION]",
            };
            // Make the request
            AddContextArtifactsAndExecutionsResponse response = await metadataServiceClient.AddContextArtifactsAndExecutionsAsync(context, artifacts, executions);
            // End snippet
        }

        /// <summary>Snippet for AddContextArtifactsAndExecutions</summary>
        public void AddContextArtifactsAndExecutionsResourceNames()
        {
            // Snippet: AddContextArtifactsAndExecutions(ContextName, IEnumerable<ArtifactName>, IEnumerable<ExecutionName>, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ContextName context = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            IEnumerable<ArtifactName> artifacts = new ArtifactName[]
            {
                ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            IEnumerable<ExecutionName> executions = new ExecutionName[]
            {
                ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            // Make the request
            AddContextArtifactsAndExecutionsResponse response = metadataServiceClient.AddContextArtifactsAndExecutions(context, artifacts, executions);
            // End snippet
        }

        /// <summary>Snippet for AddContextArtifactsAndExecutionsAsync</summary>
        public async Task AddContextArtifactsAndExecutionsResourceNamesAsync()
        {
            // Snippet: AddContextArtifactsAndExecutionsAsync(ContextName, IEnumerable<ArtifactName>, IEnumerable<ExecutionName>, CallSettings)
            // Additional: AddContextArtifactsAndExecutionsAsync(ContextName, IEnumerable<ArtifactName>, IEnumerable<ExecutionName>, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContextName context = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            IEnumerable<ArtifactName> artifacts = new ArtifactName[]
            {
                ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
            };
            IEnumerable<ExecutionName> executions = new ExecutionName[]
            {
                ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            // Make the request
            AddContextArtifactsAndExecutionsResponse response = await metadataServiceClient.AddContextArtifactsAndExecutionsAsync(context, artifacts, executions);
            // End snippet
        }

        /// <summary>Snippet for AddContextChildren</summary>
        public void AddContextChildrenRequestObject()
        {
            // Snippet: AddContextChildren(AddContextChildrenRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            AddContextChildrenRequest request = new AddContextChildrenRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ChildContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
            };
            // Make the request
            AddContextChildrenResponse response = metadataServiceClient.AddContextChildren(request);
            // End snippet
        }

        /// <summary>Snippet for AddContextChildrenAsync</summary>
        public async Task AddContextChildrenRequestObjectAsync()
        {
            // Snippet: AddContextChildrenAsync(AddContextChildrenRequest, CallSettings)
            // Additional: AddContextChildrenAsync(AddContextChildrenRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddContextChildrenRequest request = new AddContextChildrenRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ChildContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
            };
            // Make the request
            AddContextChildrenResponse response = await metadataServiceClient.AddContextChildrenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddContextChildren</summary>
        public void AddContextChildren()
        {
            // Snippet: AddContextChildren(string, IEnumerable<string>, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string context = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            IEnumerable<string> childContexts = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]",
            };
            // Make the request
            AddContextChildrenResponse response = metadataServiceClient.AddContextChildren(context, childContexts);
            // End snippet
        }

        /// <summary>Snippet for AddContextChildrenAsync</summary>
        public async Task AddContextChildrenAsync()
        {
            // Snippet: AddContextChildrenAsync(string, IEnumerable<string>, CallSettings)
            // Additional: AddContextChildrenAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string context = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            IEnumerable<string> childContexts = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]",
            };
            // Make the request
            AddContextChildrenResponse response = await metadataServiceClient.AddContextChildrenAsync(context, childContexts);
            // End snippet
        }

        /// <summary>Snippet for AddContextChildren</summary>
        public void AddContextChildrenResourceNames()
        {
            // Snippet: AddContextChildren(ContextName, IEnumerable<ContextName>, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ContextName context = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            IEnumerable<ContextName> childContexts = new ContextName[]
            {
                ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            // Make the request
            AddContextChildrenResponse response = metadataServiceClient.AddContextChildren(context, childContexts);
            // End snippet
        }

        /// <summary>Snippet for AddContextChildrenAsync</summary>
        public async Task AddContextChildrenResourceNamesAsync()
        {
            // Snippet: AddContextChildrenAsync(ContextName, IEnumerable<ContextName>, CallSettings)
            // Additional: AddContextChildrenAsync(ContextName, IEnumerable<ContextName>, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContextName context = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            IEnumerable<ContextName> childContexts = new ContextName[]
            {
                ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            // Make the request
            AddContextChildrenResponse response = await metadataServiceClient.AddContextChildrenAsync(context, childContexts);
            // End snippet
        }

        /// <summary>Snippet for RemoveContextChildren</summary>
        public void RemoveContextChildrenRequestObject()
        {
            // Snippet: RemoveContextChildren(RemoveContextChildrenRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            RemoveContextChildrenRequest request = new RemoveContextChildrenRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ChildContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
            };
            // Make the request
            RemoveContextChildrenResponse response = metadataServiceClient.RemoveContextChildren(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveContextChildrenAsync</summary>
        public async Task RemoveContextChildrenRequestObjectAsync()
        {
            // Snippet: RemoveContextChildrenAsync(RemoveContextChildrenRequest, CallSettings)
            // Additional: RemoveContextChildrenAsync(RemoveContextChildrenRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RemoveContextChildrenRequest request = new RemoveContextChildrenRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                ChildContextsAsContextNames =
                {
                    ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                },
            };
            // Make the request
            RemoveContextChildrenResponse response = await metadataServiceClient.RemoveContextChildrenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveContextChildren</summary>
        public void RemoveContextChildren()
        {
            // Snippet: RemoveContextChildren(string, IEnumerable<string>, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string context = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            IEnumerable<string> childContexts = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]",
            };
            // Make the request
            RemoveContextChildrenResponse response = metadataServiceClient.RemoveContextChildren(context, childContexts);
            // End snippet
        }

        /// <summary>Snippet for RemoveContextChildrenAsync</summary>
        public async Task RemoveContextChildrenAsync()
        {
            // Snippet: RemoveContextChildrenAsync(string, IEnumerable<string>, CallSettings)
            // Additional: RemoveContextChildrenAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string context = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            IEnumerable<string> childContexts = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]",
            };
            // Make the request
            RemoveContextChildrenResponse response = await metadataServiceClient.RemoveContextChildrenAsync(context, childContexts);
            // End snippet
        }

        /// <summary>Snippet for RemoveContextChildren</summary>
        public void RemoveContextChildrenResourceNames()
        {
            // Snippet: RemoveContextChildren(ContextName, IEnumerable<ContextName>, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ContextName context = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            IEnumerable<ContextName> childContexts = new ContextName[]
            {
                ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            // Make the request
            RemoveContextChildrenResponse response = metadataServiceClient.RemoveContextChildren(context, childContexts);
            // End snippet
        }

        /// <summary>Snippet for RemoveContextChildrenAsync</summary>
        public async Task RemoveContextChildrenResourceNamesAsync()
        {
            // Snippet: RemoveContextChildrenAsync(ContextName, IEnumerable<ContextName>, CallSettings)
            // Additional: RemoveContextChildrenAsync(ContextName, IEnumerable<ContextName>, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContextName context = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            IEnumerable<ContextName> childContexts = new ContextName[]
            {
                ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            // Make the request
            RemoveContextChildrenResponse response = await metadataServiceClient.RemoveContextChildrenAsync(context, childContexts);
            // End snippet
        }

        /// <summary>Snippet for QueryContextLineageSubgraph</summary>
        public void QueryContextLineageSubgraphRequestObject()
        {
            // Snippet: QueryContextLineageSubgraph(QueryContextLineageSubgraphRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            QueryContextLineageSubgraphRequest request = new QueryContextLineageSubgraphRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            // Make the request
            LineageSubgraph response = metadataServiceClient.QueryContextLineageSubgraph(request);
            // End snippet
        }

        /// <summary>Snippet for QueryContextLineageSubgraphAsync</summary>
        public async Task QueryContextLineageSubgraphRequestObjectAsync()
        {
            // Snippet: QueryContextLineageSubgraphAsync(QueryContextLineageSubgraphRequest, CallSettings)
            // Additional: QueryContextLineageSubgraphAsync(QueryContextLineageSubgraphRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryContextLineageSubgraphRequest request = new QueryContextLineageSubgraphRequest
            {
                ContextAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
            };
            // Make the request
            LineageSubgraph response = await metadataServiceClient.QueryContextLineageSubgraphAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryContextLineageSubgraph</summary>
        public void QueryContextLineageSubgraph()
        {
            // Snippet: QueryContextLineageSubgraph(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string context = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            // Make the request
            LineageSubgraph response = metadataServiceClient.QueryContextLineageSubgraph(context);
            // End snippet
        }

        /// <summary>Snippet for QueryContextLineageSubgraphAsync</summary>
        public async Task QueryContextLineageSubgraphAsync()
        {
            // Snippet: QueryContextLineageSubgraphAsync(string, CallSettings)
            // Additional: QueryContextLineageSubgraphAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string context = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/contexts/[CONTEXT]";
            // Make the request
            LineageSubgraph response = await metadataServiceClient.QueryContextLineageSubgraphAsync(context);
            // End snippet
        }

        /// <summary>Snippet for QueryContextLineageSubgraph</summary>
        public void QueryContextLineageSubgraphResourceNames()
        {
            // Snippet: QueryContextLineageSubgraph(ContextName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ContextName context = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            // Make the request
            LineageSubgraph response = metadataServiceClient.QueryContextLineageSubgraph(context);
            // End snippet
        }

        /// <summary>Snippet for QueryContextLineageSubgraphAsync</summary>
        public async Task QueryContextLineageSubgraphResourceNamesAsync()
        {
            // Snippet: QueryContextLineageSubgraphAsync(ContextName, CallSettings)
            // Additional: QueryContextLineageSubgraphAsync(ContextName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContextName context = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]");
            // Make the request
            LineageSubgraph response = await metadataServiceClient.QueryContextLineageSubgraphAsync(context);
            // End snippet
        }

        /// <summary>Snippet for CreateExecution</summary>
        public void CreateExecutionRequestObject()
        {
            // Snippet: CreateExecution(CreateExecutionRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Execution = new Execution(),
                ExecutionId = "",
            };
            // Make the request
            Execution response = metadataServiceClient.CreateExecution(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionRequestObjectAsync()
        {
            // Snippet: CreateExecutionAsync(CreateExecutionRequest, CallSettings)
            // Additional: CreateExecutionAsync(CreateExecutionRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Execution = new Execution(),
                ExecutionId = "",
            };
            // Make the request
            Execution response = await metadataServiceClient.CreateExecutionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExecution</summary>
        public void CreateExecution()
        {
            // Snippet: CreateExecution(string, Execution, string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Execution response = metadataServiceClient.CreateExecution(parent, execution, executionId);
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionAsync()
        {
            // Snippet: CreateExecutionAsync(string, Execution, string, CallSettings)
            // Additional: CreateExecutionAsync(string, Execution, string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Execution response = await metadataServiceClient.CreateExecutionAsync(parent, execution, executionId);
            // End snippet
        }

        /// <summary>Snippet for CreateExecution</summary>
        public void CreateExecutionResourceNames()
        {
            // Snippet: CreateExecution(MetadataStoreName, Execution, string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Execution response = metadataServiceClient.CreateExecution(parent, execution, executionId);
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionResourceNamesAsync()
        {
            // Snippet: CreateExecutionAsync(MetadataStoreName, Execution, string, CallSettings)
            // Additional: CreateExecutionAsync(MetadataStoreName, Execution, string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Execution response = await metadataServiceClient.CreateExecutionAsync(parent, execution, executionId);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecutionRequestObject()
        {
            // Snippet: GetExecution(GetExecutionRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            // Make the request
            Execution response = metadataServiceClient.GetExecution(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionRequestObjectAsync()
        {
            // Snippet: GetExecutionAsync(GetExecutionRequest, CallSettings)
            // Additional: GetExecutionAsync(GetExecutionRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            // Make the request
            Execution response = await metadataServiceClient.GetExecutionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecution()
        {
            // Snippet: GetExecution(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/executions/[EXECUTION]";
            // Make the request
            Execution response = metadataServiceClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionAsync()
        {
            // Snippet: GetExecutionAsync(string, CallSettings)
            // Additional: GetExecutionAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/executions/[EXECUTION]";
            // Make the request
            Execution response = await metadataServiceClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecutionResourceNames()
        {
            // Snippet: GetExecution(ExecutionName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]");
            // Make the request
            Execution response = metadataServiceClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionResourceNamesAsync()
        {
            // Snippet: GetExecutionAsync(ExecutionName, CallSettings)
            // Additional: GetExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]");
            // Make the request
            Execution response = await metadataServiceClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutionsRequestObject()
        {
            // Snippet: ListExecutions(ListExecutionsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = metadataServiceClient.ListExecutions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsRequestObjectAsync()
        {
            // Snippet: ListExecutionsAsync(ListExecutionsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = metadataServiceClient.ListExecutionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutions()
        {
            // Snippet: ListExecutions(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = metadataServiceClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsAsync()
        {
            // Snippet: ListExecutionsAsync(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = metadataServiceClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutionsResourceNames()
        {
            // Snippet: ListExecutions(MetadataStoreName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = metadataServiceClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsResourceNamesAsync()
        {
            // Snippet: ListExecutionsAsync(MetadataStoreName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = metadataServiceClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateExecution</summary>
        public void UpdateExecutionRequestObject()
        {
            // Snippet: UpdateExecution(UpdateExecutionRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            UpdateExecutionRequest request = new UpdateExecutionRequest
            {
                Execution = new Execution(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Execution response = metadataServiceClient.UpdateExecution(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExecutionAsync</summary>
        public async Task UpdateExecutionRequestObjectAsync()
        {
            // Snippet: UpdateExecutionAsync(UpdateExecutionRequest, CallSettings)
            // Additional: UpdateExecutionAsync(UpdateExecutionRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExecutionRequest request = new UpdateExecutionRequest
            {
                Execution = new Execution(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Execution response = await metadataServiceClient.UpdateExecutionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExecution</summary>
        public void UpdateExecution()
        {
            // Snippet: UpdateExecution(Execution, FieldMask, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            Execution execution = new Execution();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Execution response = metadataServiceClient.UpdateExecution(execution, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExecutionAsync</summary>
        public async Task UpdateExecutionAsync()
        {
            // Snippet: UpdateExecutionAsync(Execution, FieldMask, CallSettings)
            // Additional: UpdateExecutionAsync(Execution, FieldMask, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            Execution execution = new Execution();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Execution response = await metadataServiceClient.UpdateExecutionAsync(execution, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecutionRequestObject()
        {
            // Snippet: DeleteExecution(DeleteExecutionRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            DeleteExecutionRequest request = new DeleteExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = metadataServiceClient.DeleteExecution(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionRequestObjectAsync()
        {
            // Snippet: DeleteExecutionAsync(DeleteExecutionRequest, CallSettings)
            // Additional: DeleteExecutionAsync(DeleteExecutionRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExecutionRequest request = new DeleteExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await metadataServiceClient.DeleteExecutionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecution()
        {
            // Snippet: DeleteExecution(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/executions/[EXECUTION]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = metadataServiceClient.DeleteExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionAsync()
        {
            // Snippet: DeleteExecutionAsync(string, CallSettings)
            // Additional: DeleteExecutionAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/executions/[EXECUTION]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await metadataServiceClient.DeleteExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecutionResourceNames()
        {
            // Snippet: DeleteExecution(ExecutionName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = metadataServiceClient.DeleteExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = metadataServiceClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionResourceNamesAsync()
        {
            // Snippet: DeleteExecutionAsync(ExecutionName, CallSettings)
            // Additional: DeleteExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await metadataServiceClient.DeleteExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await metadataServiceClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeExecutions</summary>
        public void PurgeExecutionsRequestObject()
        {
            // Snippet: PurgeExecutions(PurgeExecutionsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            PurgeExecutionsRequest request = new PurgeExecutionsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> response = metadataServiceClient.PurgeExecutions(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeExecutionsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> retrievedResponse = metadataServiceClient.PollOncePurgeExecutions(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeExecutionsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeExecutionsAsync</summary>
        public async Task PurgeExecutionsRequestObjectAsync()
        {
            // Snippet: PurgeExecutionsAsync(PurgeExecutionsRequest, CallSettings)
            // Additional: PurgeExecutionsAsync(PurgeExecutionsRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeExecutionsRequest request = new PurgeExecutionsRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> response = await metadataServiceClient.PurgeExecutionsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeExecutionsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> retrievedResponse = await metadataServiceClient.PollOncePurgeExecutionsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeExecutionsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeExecutions</summary>
        public void PurgeExecutions()
        {
            // Snippet: PurgeExecutions(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> response = metadataServiceClient.PurgeExecutions(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeExecutionsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> retrievedResponse = metadataServiceClient.PollOncePurgeExecutions(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeExecutionsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeExecutionsAsync</summary>
        public async Task PurgeExecutionsAsync()
        {
            // Snippet: PurgeExecutionsAsync(string, CallSettings)
            // Additional: PurgeExecutionsAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> response = await metadataServiceClient.PurgeExecutionsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeExecutionsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> retrievedResponse = await metadataServiceClient.PollOncePurgeExecutionsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeExecutionsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeExecutions</summary>
        public void PurgeExecutionsResourceNames()
        {
            // Snippet: PurgeExecutions(MetadataStoreName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> response = metadataServiceClient.PurgeExecutions(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeExecutionsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> retrievedResponse = metadataServiceClient.PollOncePurgeExecutions(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeExecutionsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeExecutionsAsync</summary>
        public async Task PurgeExecutionsResourceNamesAsync()
        {
            // Snippet: PurgeExecutionsAsync(MetadataStoreName, CallSettings)
            // Additional: PurgeExecutionsAsync(MetadataStoreName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> response = await metadataServiceClient.PurgeExecutionsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeExecutionsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeExecutionsResponse, PurgeExecutionsMetadata> retrievedResponse = await metadataServiceClient.PollOncePurgeExecutionsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeExecutionsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddExecutionEvents</summary>
        public void AddExecutionEventsRequestObject()
        {
            // Snippet: AddExecutionEvents(AddExecutionEventsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            AddExecutionEventsRequest request = new AddExecutionEventsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                Events = { new Event(), },
            };
            // Make the request
            AddExecutionEventsResponse response = metadataServiceClient.AddExecutionEvents(request);
            // End snippet
        }

        /// <summary>Snippet for AddExecutionEventsAsync</summary>
        public async Task AddExecutionEventsRequestObjectAsync()
        {
            // Snippet: AddExecutionEventsAsync(AddExecutionEventsRequest, CallSettings)
            // Additional: AddExecutionEventsAsync(AddExecutionEventsRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddExecutionEventsRequest request = new AddExecutionEventsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                Events = { new Event(), },
            };
            // Make the request
            AddExecutionEventsResponse response = await metadataServiceClient.AddExecutionEventsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddExecutionEvents</summary>
        public void AddExecutionEvents()
        {
            // Snippet: AddExecutionEvents(string, IEnumerable<Event>, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string execution = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/executions/[EXECUTION]";
            IEnumerable<Event> events = new Event[] { new Event(), };
            // Make the request
            AddExecutionEventsResponse response = metadataServiceClient.AddExecutionEvents(execution, events);
            // End snippet
        }

        /// <summary>Snippet for AddExecutionEventsAsync</summary>
        public async Task AddExecutionEventsAsync()
        {
            // Snippet: AddExecutionEventsAsync(string, IEnumerable<Event>, CallSettings)
            // Additional: AddExecutionEventsAsync(string, IEnumerable<Event>, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string execution = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/executions/[EXECUTION]";
            IEnumerable<Event> events = new Event[] { new Event(), };
            // Make the request
            AddExecutionEventsResponse response = await metadataServiceClient.AddExecutionEventsAsync(execution, events);
            // End snippet
        }

        /// <summary>Snippet for AddExecutionEvents</summary>
        public void AddExecutionEventsResourceNames()
        {
            // Snippet: AddExecutionEvents(ExecutionName, IEnumerable<Event>, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ExecutionName execution = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]");
            IEnumerable<Event> events = new Event[] { new Event(), };
            // Make the request
            AddExecutionEventsResponse response = metadataServiceClient.AddExecutionEvents(execution, events);
            // End snippet
        }

        /// <summary>Snippet for AddExecutionEventsAsync</summary>
        public async Task AddExecutionEventsResourceNamesAsync()
        {
            // Snippet: AddExecutionEventsAsync(ExecutionName, IEnumerable<Event>, CallSettings)
            // Additional: AddExecutionEventsAsync(ExecutionName, IEnumerable<Event>, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName execution = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]");
            IEnumerable<Event> events = new Event[] { new Event(), };
            // Make the request
            AddExecutionEventsResponse response = await metadataServiceClient.AddExecutionEventsAsync(execution, events);
            // End snippet
        }

        /// <summary>Snippet for QueryExecutionInputsAndOutputs</summary>
        public void QueryExecutionInputsAndOutputsRequestObject()
        {
            // Snippet: QueryExecutionInputsAndOutputs(QueryExecutionInputsAndOutputsRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            QueryExecutionInputsAndOutputsRequest request = new QueryExecutionInputsAndOutputsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            // Make the request
            LineageSubgraph response = metadataServiceClient.QueryExecutionInputsAndOutputs(request);
            // End snippet
        }

        /// <summary>Snippet for QueryExecutionInputsAndOutputsAsync</summary>
        public async Task QueryExecutionInputsAndOutputsRequestObjectAsync()
        {
            // Snippet: QueryExecutionInputsAndOutputsAsync(QueryExecutionInputsAndOutputsRequest, CallSettings)
            // Additional: QueryExecutionInputsAndOutputsAsync(QueryExecutionInputsAndOutputsRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryExecutionInputsAndOutputsRequest request = new QueryExecutionInputsAndOutputsRequest
            {
                ExecutionAsExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
            };
            // Make the request
            LineageSubgraph response = await metadataServiceClient.QueryExecutionInputsAndOutputsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryExecutionInputsAndOutputs</summary>
        public void QueryExecutionInputsAndOutputs()
        {
            // Snippet: QueryExecutionInputsAndOutputs(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string execution = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/executions/[EXECUTION]";
            // Make the request
            LineageSubgraph response = metadataServiceClient.QueryExecutionInputsAndOutputs(execution);
            // End snippet
        }

        /// <summary>Snippet for QueryExecutionInputsAndOutputsAsync</summary>
        public async Task QueryExecutionInputsAndOutputsAsync()
        {
            // Snippet: QueryExecutionInputsAndOutputsAsync(string, CallSettings)
            // Additional: QueryExecutionInputsAndOutputsAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string execution = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/executions/[EXECUTION]";
            // Make the request
            LineageSubgraph response = await metadataServiceClient.QueryExecutionInputsAndOutputsAsync(execution);
            // End snippet
        }

        /// <summary>Snippet for QueryExecutionInputsAndOutputs</summary>
        public void QueryExecutionInputsAndOutputsResourceNames()
        {
            // Snippet: QueryExecutionInputsAndOutputs(ExecutionName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ExecutionName execution = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]");
            // Make the request
            LineageSubgraph response = metadataServiceClient.QueryExecutionInputsAndOutputs(execution);
            // End snippet
        }

        /// <summary>Snippet for QueryExecutionInputsAndOutputsAsync</summary>
        public async Task QueryExecutionInputsAndOutputsResourceNamesAsync()
        {
            // Snippet: QueryExecutionInputsAndOutputsAsync(ExecutionName, CallSettings)
            // Additional: QueryExecutionInputsAndOutputsAsync(ExecutionName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName execution = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]");
            // Make the request
            LineageSubgraph response = await metadataServiceClient.QueryExecutionInputsAndOutputsAsync(execution);
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataSchema</summary>
        public void CreateMetadataSchemaRequestObject()
        {
            // Snippet: CreateMetadataSchema(CreateMetadataSchemaRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            CreateMetadataSchemaRequest request = new CreateMetadataSchemaRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                MetadataSchema = new MetadataSchema(),
                MetadataSchemaId = "",
            };
            // Make the request
            MetadataSchema response = metadataServiceClient.CreateMetadataSchema(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataSchemaAsync</summary>
        public async Task CreateMetadataSchemaRequestObjectAsync()
        {
            // Snippet: CreateMetadataSchemaAsync(CreateMetadataSchemaRequest, CallSettings)
            // Additional: CreateMetadataSchemaAsync(CreateMetadataSchemaRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMetadataSchemaRequest request = new CreateMetadataSchemaRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                MetadataSchema = new MetadataSchema(),
                MetadataSchemaId = "",
            };
            // Make the request
            MetadataSchema response = await metadataServiceClient.CreateMetadataSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataSchema</summary>
        public void CreateMetadataSchema()
        {
            // Snippet: CreateMetadataSchema(string, MetadataSchema, string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            MetadataSchema metadataSchema = new MetadataSchema();
            string metadataSchemaId = "";
            // Make the request
            MetadataSchema response = metadataServiceClient.CreateMetadataSchema(parent, metadataSchema, metadataSchemaId);
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataSchemaAsync</summary>
        public async Task CreateMetadataSchemaAsync()
        {
            // Snippet: CreateMetadataSchemaAsync(string, MetadataSchema, string, CallSettings)
            // Additional: CreateMetadataSchemaAsync(string, MetadataSchema, string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            MetadataSchema metadataSchema = new MetadataSchema();
            string metadataSchemaId = "";
            // Make the request
            MetadataSchema response = await metadataServiceClient.CreateMetadataSchemaAsync(parent, metadataSchema, metadataSchemaId);
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataSchema</summary>
        public void CreateMetadataSchemaResourceNames()
        {
            // Snippet: CreateMetadataSchema(MetadataStoreName, MetadataSchema, string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            MetadataSchema metadataSchema = new MetadataSchema();
            string metadataSchemaId = "";
            // Make the request
            MetadataSchema response = metadataServiceClient.CreateMetadataSchema(parent, metadataSchema, metadataSchemaId);
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataSchemaAsync</summary>
        public async Task CreateMetadataSchemaResourceNamesAsync()
        {
            // Snippet: CreateMetadataSchemaAsync(MetadataStoreName, MetadataSchema, string, CallSettings)
            // Additional: CreateMetadataSchemaAsync(MetadataStoreName, MetadataSchema, string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            MetadataSchema metadataSchema = new MetadataSchema();
            string metadataSchemaId = "";
            // Make the request
            MetadataSchema response = await metadataServiceClient.CreateMetadataSchemaAsync(parent, metadataSchema, metadataSchemaId);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataSchema</summary>
        public void GetMetadataSchemaRequestObject()
        {
            // Snippet: GetMetadataSchema(GetMetadataSchemaRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            GetMetadataSchemaRequest request = new GetMetadataSchemaRequest
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
            };
            // Make the request
            MetadataSchema response = metadataServiceClient.GetMetadataSchema(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataSchemaAsync</summary>
        public async Task GetMetadataSchemaRequestObjectAsync()
        {
            // Snippet: GetMetadataSchemaAsync(GetMetadataSchemaRequest, CallSettings)
            // Additional: GetMetadataSchemaAsync(GetMetadataSchemaRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMetadataSchemaRequest request = new GetMetadataSchemaRequest
            {
                MetadataSchemaName = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]"),
            };
            // Make the request
            MetadataSchema response = await metadataServiceClient.GetMetadataSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataSchema</summary>
        public void GetMetadataSchema()
        {
            // Snippet: GetMetadataSchema(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/metadataSchemas/[METADATA_SCHEMA]";
            // Make the request
            MetadataSchema response = metadataServiceClient.GetMetadataSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataSchemaAsync</summary>
        public async Task GetMetadataSchemaAsync()
        {
            // Snippet: GetMetadataSchemaAsync(string, CallSettings)
            // Additional: GetMetadataSchemaAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/metadataSchemas/[METADATA_SCHEMA]";
            // Make the request
            MetadataSchema response = await metadataServiceClient.GetMetadataSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataSchema</summary>
        public void GetMetadataSchemaResourceNames()
        {
            // Snippet: GetMetadataSchema(MetadataSchemaName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataSchemaName name = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]");
            // Make the request
            MetadataSchema response = metadataServiceClient.GetMetadataSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataSchemaAsync</summary>
        public async Task GetMetadataSchemaResourceNamesAsync()
        {
            // Snippet: GetMetadataSchemaAsync(MetadataSchemaName, CallSettings)
            // Additional: GetMetadataSchemaAsync(MetadataSchemaName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataSchemaName name = MetadataSchemaName.FromProjectLocationMetadataStoreMetadataSchema("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[METADATA_SCHEMA]");
            // Make the request
            MetadataSchema response = await metadataServiceClient.GetMetadataSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMetadataSchemas</summary>
        public void ListMetadataSchemasRequestObject()
        {
            // Snippet: ListMetadataSchemas(ListMetadataSchemasRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ListMetadataSchemasRequest request = new ListMetadataSchemasRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListMetadataSchemasResponse, MetadataSchema> response = metadataServiceClient.ListMetadataSchemas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetadataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetadataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataSchemasAsync</summary>
        public async Task ListMetadataSchemasRequestObjectAsync()
        {
            // Snippet: ListMetadataSchemasAsync(ListMetadataSchemasRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMetadataSchemasRequest request = new ListMetadataSchemasRequest
            {
                ParentAsMetadataStoreName = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMetadataSchemasResponse, MetadataSchema> response = metadataServiceClient.ListMetadataSchemasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetadataSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetadataSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataSchemas</summary>
        public void ListMetadataSchemas()
        {
            // Snippet: ListMetadataSchemas(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            PagedEnumerable<ListMetadataSchemasResponse, MetadataSchema> response = metadataServiceClient.ListMetadataSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetadataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetadataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataSchemasAsync</summary>
        public async Task ListMetadataSchemasAsync()
        {
            // Snippet: ListMetadataSchemasAsync(string, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            PagedAsyncEnumerable<ListMetadataSchemasResponse, MetadataSchema> response = metadataServiceClient.ListMetadataSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetadataSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetadataSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataSchemas</summary>
        public void ListMetadataSchemasResourceNames()
        {
            // Snippet: ListMetadataSchemas(MetadataStoreName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            PagedEnumerable<ListMetadataSchemasResponse, MetadataSchema> response = metadataServiceClient.ListMetadataSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetadataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetadataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataSchemasAsync</summary>
        public async Task ListMetadataSchemasResourceNamesAsync()
        {
            // Snippet: ListMetadataSchemasAsync(MetadataStoreName, string, int?, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetadataStoreName parent = MetadataStoreName.FromProjectLocationMetadataStore("[PROJECT]", "[LOCATION]", "[METADATA_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListMetadataSchemasResponse, MetadataSchema> response = metadataServiceClient.ListMetadataSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetadataSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetadataSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetadataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetadataSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetadataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryArtifactLineageSubgraph</summary>
        public void QueryArtifactLineageSubgraphRequestObject()
        {
            // Snippet: QueryArtifactLineageSubgraph(QueryArtifactLineageSubgraphRequest, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            QueryArtifactLineageSubgraphRequest request = new QueryArtifactLineageSubgraphRequest
            {
                ArtifactAsArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                MaxHops = 0,
                Filter = "",
            };
            // Make the request
            LineageSubgraph response = metadataServiceClient.QueryArtifactLineageSubgraph(request);
            // End snippet
        }

        /// <summary>Snippet for QueryArtifactLineageSubgraphAsync</summary>
        public async Task QueryArtifactLineageSubgraphRequestObjectAsync()
        {
            // Snippet: QueryArtifactLineageSubgraphAsync(QueryArtifactLineageSubgraphRequest, CallSettings)
            // Additional: QueryArtifactLineageSubgraphAsync(QueryArtifactLineageSubgraphRequest, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryArtifactLineageSubgraphRequest request = new QueryArtifactLineageSubgraphRequest
            {
                ArtifactAsArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                MaxHops = 0,
                Filter = "",
            };
            // Make the request
            LineageSubgraph response = await metadataServiceClient.QueryArtifactLineageSubgraphAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryArtifactLineageSubgraph</summary>
        public void QueryArtifactLineageSubgraph()
        {
            // Snippet: QueryArtifactLineageSubgraph(string, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string artifact = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/artifacts/[ARTIFACT]";
            // Make the request
            LineageSubgraph response = metadataServiceClient.QueryArtifactLineageSubgraph(artifact);
            // End snippet
        }

        /// <summary>Snippet for QueryArtifactLineageSubgraphAsync</summary>
        public async Task QueryArtifactLineageSubgraphAsync()
        {
            // Snippet: QueryArtifactLineageSubgraphAsync(string, CallSettings)
            // Additional: QueryArtifactLineageSubgraphAsync(string, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string artifact = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]/artifacts/[ARTIFACT]";
            // Make the request
            LineageSubgraph response = await metadataServiceClient.QueryArtifactLineageSubgraphAsync(artifact);
            // End snippet
        }

        /// <summary>Snippet for QueryArtifactLineageSubgraph</summary>
        public void QueryArtifactLineageSubgraphResourceNames()
        {
            // Snippet: QueryArtifactLineageSubgraph(ArtifactName, CallSettings)
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            ArtifactName artifact = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]");
            // Make the request
            LineageSubgraph response = metadataServiceClient.QueryArtifactLineageSubgraph(artifact);
            // End snippet
        }

        /// <summary>Snippet for QueryArtifactLineageSubgraphAsync</summary>
        public async Task QueryArtifactLineageSubgraphResourceNamesAsync()
        {
            // Snippet: QueryArtifactLineageSubgraphAsync(ArtifactName, CallSettings)
            // Additional: QueryArtifactLineageSubgraphAsync(ArtifactName, CancellationToken)
            // Create client
            MetadataServiceClient metadataServiceClient = await MetadataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ArtifactName artifact = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]");
            // Make the request
            LineageSubgraph response = await metadataServiceClient.QueryArtifactLineageSubgraphAsync(artifact);
            // End snippet
        }
    }
}
