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
    public sealed class AllGeneratedDataStoreServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataStore</summary>
        public void CreateDataStoreRequestObject()
        {
            // Snippet: CreateDataStore(CreateDataStoreRequest, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            CreateDataStoreRequest request = new CreateDataStoreRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                DataStore = new DataStore(),
                DataStoreId = "",
                CreateAdvancedSiteSearch = false,
            };
            // Make the request
            Operation<DataStore, CreateDataStoreMetadata> response = dataStoreServiceClient.CreateDataStore(request);

            // Poll until the returned long-running operation is complete
            Operation<DataStore, CreateDataStoreMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataStore, CreateDataStoreMetadata> retrievedResponse = dataStoreServiceClient.PollOnceCreateDataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataStoreAsync</summary>
        public async Task CreateDataStoreRequestObjectAsync()
        {
            // Snippet: CreateDataStoreAsync(CreateDataStoreRequest, CallSettings)
            // Additional: CreateDataStoreAsync(CreateDataStoreRequest, CancellationToken)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataStoreRequest request = new CreateDataStoreRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                DataStore = new DataStore(),
                DataStoreId = "",
                CreateAdvancedSiteSearch = false,
            };
            // Make the request
            Operation<DataStore, CreateDataStoreMetadata> response = await dataStoreServiceClient.CreateDataStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DataStore, CreateDataStoreMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataStore, CreateDataStoreMetadata> retrievedResponse = await dataStoreServiceClient.PollOnceCreateDataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataStore</summary>
        public void CreateDataStore()
        {
            // Snippet: CreateDataStore(string, DataStore, string, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            DataStore dataStore = new DataStore();
            string dataStoreId = "";
            // Make the request
            Operation<DataStore, CreateDataStoreMetadata> response = dataStoreServiceClient.CreateDataStore(parent, dataStore, dataStoreId);

            // Poll until the returned long-running operation is complete
            Operation<DataStore, CreateDataStoreMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataStore, CreateDataStoreMetadata> retrievedResponse = dataStoreServiceClient.PollOnceCreateDataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataStoreAsync</summary>
        public async Task CreateDataStoreAsync()
        {
            // Snippet: CreateDataStoreAsync(string, DataStore, string, CallSettings)
            // Additional: CreateDataStoreAsync(string, DataStore, string, CancellationToken)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            DataStore dataStore = new DataStore();
            string dataStoreId = "";
            // Make the request
            Operation<DataStore, CreateDataStoreMetadata> response = await dataStoreServiceClient.CreateDataStoreAsync(parent, dataStore, dataStoreId);

            // Poll until the returned long-running operation is complete
            Operation<DataStore, CreateDataStoreMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataStore, CreateDataStoreMetadata> retrievedResponse = await dataStoreServiceClient.PollOnceCreateDataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataStore</summary>
        public void CreateDataStoreResourceNames()
        {
            // Snippet: CreateDataStore(CollectionName, DataStore, string, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            DataStore dataStore = new DataStore();
            string dataStoreId = "";
            // Make the request
            Operation<DataStore, CreateDataStoreMetadata> response = dataStoreServiceClient.CreateDataStore(parent, dataStore, dataStoreId);

            // Poll until the returned long-running operation is complete
            Operation<DataStore, CreateDataStoreMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataStore, CreateDataStoreMetadata> retrievedResponse = dataStoreServiceClient.PollOnceCreateDataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataStoreAsync</summary>
        public async Task CreateDataStoreResourceNamesAsync()
        {
            // Snippet: CreateDataStoreAsync(CollectionName, DataStore, string, CallSettings)
            // Additional: CreateDataStoreAsync(CollectionName, DataStore, string, CancellationToken)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            DataStore dataStore = new DataStore();
            string dataStoreId = "";
            // Make the request
            Operation<DataStore, CreateDataStoreMetadata> response = await dataStoreServiceClient.CreateDataStoreAsync(parent, dataStore, dataStoreId);

            // Poll until the returned long-running operation is complete
            Operation<DataStore, CreateDataStoreMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataStore, CreateDataStoreMetadata> retrievedResponse = await dataStoreServiceClient.PollOnceCreateDataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDataStore</summary>
        public void GetDataStoreRequestObject()
        {
            // Snippet: GetDataStore(GetDataStoreRequest, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            GetDataStoreRequest request = new GetDataStoreRequest
            {
                DataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            DataStore response = dataStoreServiceClient.GetDataStore(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataStoreAsync</summary>
        public async Task GetDataStoreRequestObjectAsync()
        {
            // Snippet: GetDataStoreAsync(GetDataStoreRequest, CallSettings)
            // Additional: GetDataStoreAsync(GetDataStoreRequest, CancellationToken)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataStoreRequest request = new GetDataStoreRequest
            {
                DataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            DataStore response = await dataStoreServiceClient.GetDataStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataStore</summary>
        public void GetDataStore()
        {
            // Snippet: GetDataStore(string, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            DataStore response = dataStoreServiceClient.GetDataStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataStoreAsync</summary>
        public async Task GetDataStoreAsync()
        {
            // Snippet: GetDataStoreAsync(string, CallSettings)
            // Additional: GetDataStoreAsync(string, CancellationToken)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            DataStore response = await dataStoreServiceClient.GetDataStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataStore</summary>
        public void GetDataStoreResourceNames()
        {
            // Snippet: GetDataStore(DataStoreName, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName name = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            DataStore response = dataStoreServiceClient.GetDataStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataStoreAsync</summary>
        public async Task GetDataStoreResourceNamesAsync()
        {
            // Snippet: GetDataStoreAsync(DataStoreName, CallSettings)
            // Additional: GetDataStoreAsync(DataStoreName, CancellationToken)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName name = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            DataStore response = await dataStoreServiceClient.GetDataStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataStores</summary>
        public void ListDataStoresRequestObject()
        {
            // Snippet: ListDataStores(ListDataStoresRequest, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            ListDataStoresRequest request = new ListDataStoresRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDataStoresResponse, DataStore> response = dataStoreServiceClient.ListDataStores(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataStoresAsync</summary>
        public async Task ListDataStoresRequestObjectAsync()
        {
            // Snippet: ListDataStoresAsync(ListDataStoresRequest, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataStoresRequest request = new ListDataStoresRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDataStoresResponse, DataStore> response = dataStoreServiceClient.ListDataStoresAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataStores</summary>
        public void ListDataStores()
        {
            // Snippet: ListDataStores(string, string, int?, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            PagedEnumerable<ListDataStoresResponse, DataStore> response = dataStoreServiceClient.ListDataStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataStoresAsync</summary>
        public async Task ListDataStoresAsync()
        {
            // Snippet: ListDataStoresAsync(string, string, int?, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            PagedAsyncEnumerable<ListDataStoresResponse, DataStore> response = dataStoreServiceClient.ListDataStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataStores</summary>
        public void ListDataStoresResourceNames()
        {
            // Snippet: ListDataStores(CollectionName, string, int?, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            PagedEnumerable<ListDataStoresResponse, DataStore> response = dataStoreServiceClient.ListDataStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataStoresAsync</summary>
        public async Task ListDataStoresResourceNamesAsync()
        {
            // Snippet: ListDataStoresAsync(CollectionName, string, int?, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            PagedAsyncEnumerable<ListDataStoresResponse, DataStore> response = dataStoreServiceClient.ListDataStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStore</summary>
        public void DeleteDataStoreRequestObject()
        {
            // Snippet: DeleteDataStore(DeleteDataStoreRequest, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataStoreRequest request = new DeleteDataStoreRequest
            {
                DataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<Empty, DeleteDataStoreMetadata> response = dataStoreServiceClient.DeleteDataStore(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDataStoreMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDataStoreMetadata> retrievedResponse = dataStoreServiceClient.PollOnceDeleteDataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStoreAsync</summary>
        public async Task DeleteDataStoreRequestObjectAsync()
        {
            // Snippet: DeleteDataStoreAsync(DeleteDataStoreRequest, CallSettings)
            // Additional: DeleteDataStoreAsync(DeleteDataStoreRequest, CancellationToken)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataStoreRequest request = new DeleteDataStoreRequest
            {
                DataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<Empty, DeleteDataStoreMetadata> response = await dataStoreServiceClient.DeleteDataStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDataStoreMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDataStoreMetadata> retrievedResponse = await dataStoreServiceClient.PollOnceDeleteDataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStore</summary>
        public void DeleteDataStore()
        {
            // Snippet: DeleteDataStore(string, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            Operation<Empty, DeleteDataStoreMetadata> response = dataStoreServiceClient.DeleteDataStore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDataStoreMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDataStoreMetadata> retrievedResponse = dataStoreServiceClient.PollOnceDeleteDataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStoreAsync</summary>
        public async Task DeleteDataStoreAsync()
        {
            // Snippet: DeleteDataStoreAsync(string, CallSettings)
            // Additional: DeleteDataStoreAsync(string, CancellationToken)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            Operation<Empty, DeleteDataStoreMetadata> response = await dataStoreServiceClient.DeleteDataStoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDataStoreMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDataStoreMetadata> retrievedResponse = await dataStoreServiceClient.PollOnceDeleteDataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStore</summary>
        public void DeleteDataStoreResourceNames()
        {
            // Snippet: DeleteDataStore(DataStoreName, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName name = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            Operation<Empty, DeleteDataStoreMetadata> response = dataStoreServiceClient.DeleteDataStore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDataStoreMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDataStoreMetadata> retrievedResponse = dataStoreServiceClient.PollOnceDeleteDataStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStoreAsync</summary>
        public async Task DeleteDataStoreResourceNamesAsync()
        {
            // Snippet: DeleteDataStoreAsync(DataStoreName, CallSettings)
            // Additional: DeleteDataStoreAsync(DataStoreName, CancellationToken)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName name = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            Operation<Empty, DeleteDataStoreMetadata> response = await dataStoreServiceClient.DeleteDataStoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteDataStoreMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteDataStoreMetadata> retrievedResponse = await dataStoreServiceClient.PollOnceDeleteDataStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataStore</summary>
        public void UpdateDataStoreRequestObject()
        {
            // Snippet: UpdateDataStore(UpdateDataStoreRequest, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataStoreRequest request = new UpdateDataStoreRequest
            {
                DataStore = new DataStore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataStore response = dataStoreServiceClient.UpdateDataStore(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataStoreAsync</summary>
        public async Task UpdateDataStoreRequestObjectAsync()
        {
            // Snippet: UpdateDataStoreAsync(UpdateDataStoreRequest, CallSettings)
            // Additional: UpdateDataStoreAsync(UpdateDataStoreRequest, CancellationToken)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataStoreRequest request = new UpdateDataStoreRequest
            {
                DataStore = new DataStore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataStore response = await dataStoreServiceClient.UpdateDataStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataStore</summary>
        public void UpdateDataStore()
        {
            // Snippet: UpdateDataStore(DataStore, FieldMask, CallSettings)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = DataStoreServiceClient.Create();
            // Initialize request argument(s)
            DataStore dataStore = new DataStore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataStore response = dataStoreServiceClient.UpdateDataStore(dataStore, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataStoreAsync</summary>
        public async Task UpdateDataStoreAsync()
        {
            // Snippet: UpdateDataStoreAsync(DataStore, FieldMask, CallSettings)
            // Additional: UpdateDataStoreAsync(DataStore, FieldMask, CancellationToken)
            // Create client
            DataStoreServiceClient dataStoreServiceClient = await DataStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStore dataStore = new DataStore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataStore response = await dataStoreServiceClient.UpdateDataStoreAsync(dataStore, updateMask);
            // End snippet
        }
    }
}
