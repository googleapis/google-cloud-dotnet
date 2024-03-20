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
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFeatureOnlineStoreAdminServiceClientSnippets
    {
        /// <summary>Snippet for CreateFeatureOnlineStore</summary>
        public void CreateFeatureOnlineStoreRequestObject()
        {
            // Snippet: CreateFeatureOnlineStore(CreateFeatureOnlineStoreRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateFeatureOnlineStoreRequest request = new CreateFeatureOnlineStoreRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FeatureOnlineStore = new FeatureOnlineStore(),
                FeatureOnlineStoreId = "",
            };
            // Make the request
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> response = featureOnlineStoreAdminServiceClient.CreateFeatureOnlineStore(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureOnlineStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureOnlineStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureOnlineStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureOnlineStoreAsync</summary>
        public async Task CreateFeatureOnlineStoreRequestObjectAsync()
        {
            // Snippet: CreateFeatureOnlineStoreAsync(CreateFeatureOnlineStoreRequest, CallSettings)
            // Additional: CreateFeatureOnlineStoreAsync(CreateFeatureOnlineStoreRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeatureOnlineStoreRequest request = new CreateFeatureOnlineStoreRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FeatureOnlineStore = new FeatureOnlineStore(),
                FeatureOnlineStoreId = "",
            };
            // Make the request
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> response = await featureOnlineStoreAdminServiceClient.CreateFeatureOnlineStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureOnlineStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureOnlineStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureOnlineStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureOnlineStore</summary>
        public void CreateFeatureOnlineStore()
        {
            // Snippet: CreateFeatureOnlineStore(string, FeatureOnlineStore, string, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FeatureOnlineStore featureOnlineStore = new FeatureOnlineStore();
            string featureOnlineStoreId = "";
            // Make the request
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> response = featureOnlineStoreAdminServiceClient.CreateFeatureOnlineStore(parent, featureOnlineStore, featureOnlineStoreId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureOnlineStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureOnlineStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureOnlineStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureOnlineStoreAsync</summary>
        public async Task CreateFeatureOnlineStoreAsync()
        {
            // Snippet: CreateFeatureOnlineStoreAsync(string, FeatureOnlineStore, string, CallSettings)
            // Additional: CreateFeatureOnlineStoreAsync(string, FeatureOnlineStore, string, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FeatureOnlineStore featureOnlineStore = new FeatureOnlineStore();
            string featureOnlineStoreId = "";
            // Make the request
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> response = await featureOnlineStoreAdminServiceClient.CreateFeatureOnlineStoreAsync(parent, featureOnlineStore, featureOnlineStoreId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureOnlineStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureOnlineStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureOnlineStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureOnlineStore</summary>
        public void CreateFeatureOnlineStoreResourceNames()
        {
            // Snippet: CreateFeatureOnlineStore(LocationName, FeatureOnlineStore, string, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FeatureOnlineStore featureOnlineStore = new FeatureOnlineStore();
            string featureOnlineStoreId = "";
            // Make the request
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> response = featureOnlineStoreAdminServiceClient.CreateFeatureOnlineStore(parent, featureOnlineStore, featureOnlineStoreId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureOnlineStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureOnlineStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureOnlineStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureOnlineStoreAsync</summary>
        public async Task CreateFeatureOnlineStoreResourceNamesAsync()
        {
            // Snippet: CreateFeatureOnlineStoreAsync(LocationName, FeatureOnlineStore, string, CallSettings)
            // Additional: CreateFeatureOnlineStoreAsync(LocationName, FeatureOnlineStore, string, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FeatureOnlineStore featureOnlineStore = new FeatureOnlineStore();
            string featureOnlineStoreId = "";
            // Make the request
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> response = await featureOnlineStoreAdminServiceClient.CreateFeatureOnlineStoreAsync(parent, featureOnlineStore, featureOnlineStoreId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureOnlineStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureOnlineStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureOnlineStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetFeatureOnlineStore</summary>
        public void GetFeatureOnlineStoreRequestObject()
        {
            // Snippet: GetFeatureOnlineStore(GetFeatureOnlineStoreRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            GetFeatureOnlineStoreRequest request = new GetFeatureOnlineStoreRequest
            {
                FeatureOnlineStoreName = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]"),
            };
            // Make the request
            FeatureOnlineStore response = featureOnlineStoreAdminServiceClient.GetFeatureOnlineStore(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureOnlineStoreAsync</summary>
        public async Task GetFeatureOnlineStoreRequestObjectAsync()
        {
            // Snippet: GetFeatureOnlineStoreAsync(GetFeatureOnlineStoreRequest, CallSettings)
            // Additional: GetFeatureOnlineStoreAsync(GetFeatureOnlineStoreRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeatureOnlineStoreRequest request = new GetFeatureOnlineStoreRequest
            {
                FeatureOnlineStoreName = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]"),
            };
            // Make the request
            FeatureOnlineStore response = await featureOnlineStoreAdminServiceClient.GetFeatureOnlineStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureOnlineStore</summary>
        public void GetFeatureOnlineStore()
        {
            // Snippet: GetFeatureOnlineStore(string, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]";
            // Make the request
            FeatureOnlineStore response = featureOnlineStoreAdminServiceClient.GetFeatureOnlineStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureOnlineStoreAsync</summary>
        public async Task GetFeatureOnlineStoreAsync()
        {
            // Snippet: GetFeatureOnlineStoreAsync(string, CallSettings)
            // Additional: GetFeatureOnlineStoreAsync(string, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]";
            // Make the request
            FeatureOnlineStore response = await featureOnlineStoreAdminServiceClient.GetFeatureOnlineStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureOnlineStore</summary>
        public void GetFeatureOnlineStoreResourceNames()
        {
            // Snippet: GetFeatureOnlineStore(FeatureOnlineStoreName, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureOnlineStoreName name = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]");
            // Make the request
            FeatureOnlineStore response = featureOnlineStoreAdminServiceClient.GetFeatureOnlineStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureOnlineStoreAsync</summary>
        public async Task GetFeatureOnlineStoreResourceNamesAsync()
        {
            // Snippet: GetFeatureOnlineStoreAsync(FeatureOnlineStoreName, CallSettings)
            // Additional: GetFeatureOnlineStoreAsync(FeatureOnlineStoreName, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureOnlineStoreName name = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]");
            // Make the request
            FeatureOnlineStore response = await featureOnlineStoreAdminServiceClient.GetFeatureOnlineStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeatureOnlineStores</summary>
        public void ListFeatureOnlineStoresRequestObject()
        {
            // Snippet: ListFeatureOnlineStores(ListFeatureOnlineStoresRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            ListFeatureOnlineStoresRequest request = new ListFeatureOnlineStoresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> response = featureOnlineStoreAdminServiceClient.ListFeatureOnlineStores(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureOnlineStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureOnlineStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureOnlineStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureOnlineStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureOnlineStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureOnlineStoresAsync</summary>
        public async Task ListFeatureOnlineStoresRequestObjectAsync()
        {
            // Snippet: ListFeatureOnlineStoresAsync(ListFeatureOnlineStoresRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeatureOnlineStoresRequest request = new ListFeatureOnlineStoresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> response = featureOnlineStoreAdminServiceClient.ListFeatureOnlineStoresAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureOnlineStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureOnlineStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureOnlineStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureOnlineStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureOnlineStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureOnlineStores</summary>
        public void ListFeatureOnlineStores()
        {
            // Snippet: ListFeatureOnlineStores(string, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> response = featureOnlineStoreAdminServiceClient.ListFeatureOnlineStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureOnlineStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureOnlineStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureOnlineStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureOnlineStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureOnlineStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureOnlineStoresAsync</summary>
        public async Task ListFeatureOnlineStoresAsync()
        {
            // Snippet: ListFeatureOnlineStoresAsync(string, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> response = featureOnlineStoreAdminServiceClient.ListFeatureOnlineStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureOnlineStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureOnlineStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureOnlineStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureOnlineStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureOnlineStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureOnlineStores</summary>
        public void ListFeatureOnlineStoresResourceNames()
        {
            // Snippet: ListFeatureOnlineStores(LocationName, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> response = featureOnlineStoreAdminServiceClient.ListFeatureOnlineStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureOnlineStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureOnlineStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureOnlineStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureOnlineStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureOnlineStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureOnlineStoresAsync</summary>
        public async Task ListFeatureOnlineStoresResourceNamesAsync()
        {
            // Snippet: ListFeatureOnlineStoresAsync(LocationName, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> response = featureOnlineStoreAdminServiceClient.ListFeatureOnlineStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureOnlineStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureOnlineStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureOnlineStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureOnlineStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureOnlineStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureOnlineStore</summary>
        public void UpdateFeatureOnlineStoreRequestObject()
        {
            // Snippet: UpdateFeatureOnlineStore(UpdateFeatureOnlineStoreRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateFeatureOnlineStoreRequest request = new UpdateFeatureOnlineStoreRequest
            {
                FeatureOnlineStore = new FeatureOnlineStore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> response = featureOnlineStoreAdminServiceClient.UpdateFeatureOnlineStore(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureOnlineStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceUpdateFeatureOnlineStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureOnlineStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureOnlineStoreAsync</summary>
        public async Task UpdateFeatureOnlineStoreRequestObjectAsync()
        {
            // Snippet: UpdateFeatureOnlineStoreAsync(UpdateFeatureOnlineStoreRequest, CallSettings)
            // Additional: UpdateFeatureOnlineStoreAsync(UpdateFeatureOnlineStoreRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFeatureOnlineStoreRequest request = new UpdateFeatureOnlineStoreRequest
            {
                FeatureOnlineStore = new FeatureOnlineStore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> response = await featureOnlineStoreAdminServiceClient.UpdateFeatureOnlineStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureOnlineStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceUpdateFeatureOnlineStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureOnlineStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureOnlineStore</summary>
        public void UpdateFeatureOnlineStore()
        {
            // Snippet: UpdateFeatureOnlineStore(FeatureOnlineStore, FieldMask, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureOnlineStore featureOnlineStore = new FeatureOnlineStore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> response = featureOnlineStoreAdminServiceClient.UpdateFeatureOnlineStore(featureOnlineStore, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureOnlineStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceUpdateFeatureOnlineStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureOnlineStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureOnlineStoreAsync</summary>
        public async Task UpdateFeatureOnlineStoreAsync()
        {
            // Snippet: UpdateFeatureOnlineStoreAsync(FeatureOnlineStore, FieldMask, CallSettings)
            // Additional: UpdateFeatureOnlineStoreAsync(FeatureOnlineStore, FieldMask, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureOnlineStore featureOnlineStore = new FeatureOnlineStore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> response = await featureOnlineStoreAdminServiceClient.UpdateFeatureOnlineStoreAsync(featureOnlineStore, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureOnlineStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceUpdateFeatureOnlineStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureOnlineStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureOnlineStore</summary>
        public void DeleteFeatureOnlineStoreRequestObject()
        {
            // Snippet: DeleteFeatureOnlineStore(DeleteFeatureOnlineStoreRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteFeatureOnlineStoreRequest request = new DeleteFeatureOnlineStoreRequest
            {
                FeatureOnlineStoreName = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureOnlineStoreAdminServiceClient.DeleteFeatureOnlineStore(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureOnlineStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureOnlineStoreAsync</summary>
        public async Task DeleteFeatureOnlineStoreRequestObjectAsync()
        {
            // Snippet: DeleteFeatureOnlineStoreAsync(DeleteFeatureOnlineStoreRequest, CallSettings)
            // Additional: DeleteFeatureOnlineStoreAsync(DeleteFeatureOnlineStoreRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeatureOnlineStoreRequest request = new DeleteFeatureOnlineStoreRequest
            {
                FeatureOnlineStoreName = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureOnlineStoreAdminServiceClient.DeleteFeatureOnlineStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureOnlineStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureOnlineStore</summary>
        public void DeleteFeatureOnlineStore()
        {
            // Snippet: DeleteFeatureOnlineStore(string, bool, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]";
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureOnlineStoreAdminServiceClient.DeleteFeatureOnlineStore(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureOnlineStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureOnlineStoreAsync</summary>
        public async Task DeleteFeatureOnlineStoreAsync()
        {
            // Snippet: DeleteFeatureOnlineStoreAsync(string, bool, CallSettings)
            // Additional: DeleteFeatureOnlineStoreAsync(string, bool, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]";
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureOnlineStoreAdminServiceClient.DeleteFeatureOnlineStoreAsync(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureOnlineStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureOnlineStore</summary>
        public void DeleteFeatureOnlineStoreResourceNames()
        {
            // Snippet: DeleteFeatureOnlineStore(FeatureOnlineStoreName, bool, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureOnlineStoreName name = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]");
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureOnlineStoreAdminServiceClient.DeleteFeatureOnlineStore(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureOnlineStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureOnlineStoreAsync</summary>
        public async Task DeleteFeatureOnlineStoreResourceNamesAsync()
        {
            // Snippet: DeleteFeatureOnlineStoreAsync(FeatureOnlineStoreName, bool, CallSettings)
            // Additional: DeleteFeatureOnlineStoreAsync(FeatureOnlineStoreName, bool, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureOnlineStoreName name = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]");
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureOnlineStoreAdminServiceClient.DeleteFeatureOnlineStoreAsync(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureOnlineStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureView</summary>
        public void CreateFeatureViewRequestObject()
        {
            // Snippet: CreateFeatureView(CreateFeatureViewRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateFeatureViewRequest request = new CreateFeatureViewRequest
            {
                ParentAsFeatureOnlineStoreName = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]"),
                FeatureView = new FeatureView(),
                FeatureViewId = "",
                RunSyncImmediately = false,
            };
            // Make the request
            Operation<FeatureView, CreateFeatureViewOperationMetadata> response = featureOnlineStoreAdminServiceClient.CreateFeatureView(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureView, CreateFeatureViewOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureView, CreateFeatureViewOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureViewAsync</summary>
        public async Task CreateFeatureViewRequestObjectAsync()
        {
            // Snippet: CreateFeatureViewAsync(CreateFeatureViewRequest, CallSettings)
            // Additional: CreateFeatureViewAsync(CreateFeatureViewRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeatureViewRequest request = new CreateFeatureViewRequest
            {
                ParentAsFeatureOnlineStoreName = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]"),
                FeatureView = new FeatureView(),
                FeatureViewId = "",
                RunSyncImmediately = false,
            };
            // Make the request
            Operation<FeatureView, CreateFeatureViewOperationMetadata> response = await featureOnlineStoreAdminServiceClient.CreateFeatureViewAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureView, CreateFeatureViewOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureView, CreateFeatureViewOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureView</summary>
        public void CreateFeatureView()
        {
            // Snippet: CreateFeatureView(string, FeatureView, string, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]";
            FeatureView featureView = new FeatureView();
            string featureViewId = "";
            // Make the request
            Operation<FeatureView, CreateFeatureViewOperationMetadata> response = featureOnlineStoreAdminServiceClient.CreateFeatureView(parent, featureView, featureViewId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureView, CreateFeatureViewOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureView, CreateFeatureViewOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureViewAsync</summary>
        public async Task CreateFeatureViewAsync()
        {
            // Snippet: CreateFeatureViewAsync(string, FeatureView, string, CallSettings)
            // Additional: CreateFeatureViewAsync(string, FeatureView, string, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]";
            FeatureView featureView = new FeatureView();
            string featureViewId = "";
            // Make the request
            Operation<FeatureView, CreateFeatureViewOperationMetadata> response = await featureOnlineStoreAdminServiceClient.CreateFeatureViewAsync(parent, featureView, featureViewId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureView, CreateFeatureViewOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureView, CreateFeatureViewOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureView</summary>
        public void CreateFeatureViewResourceNames()
        {
            // Snippet: CreateFeatureView(FeatureOnlineStoreName, FeatureView, string, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureOnlineStoreName parent = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]");
            FeatureView featureView = new FeatureView();
            string featureViewId = "";
            // Make the request
            Operation<FeatureView, CreateFeatureViewOperationMetadata> response = featureOnlineStoreAdminServiceClient.CreateFeatureView(parent, featureView, featureViewId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureView, CreateFeatureViewOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureView, CreateFeatureViewOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureViewAsync</summary>
        public async Task CreateFeatureViewResourceNamesAsync()
        {
            // Snippet: CreateFeatureViewAsync(FeatureOnlineStoreName, FeatureView, string, CallSettings)
            // Additional: CreateFeatureViewAsync(FeatureOnlineStoreName, FeatureView, string, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureOnlineStoreName parent = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]");
            FeatureView featureView = new FeatureView();
            string featureViewId = "";
            // Make the request
            Operation<FeatureView, CreateFeatureViewOperationMetadata> response = await featureOnlineStoreAdminServiceClient.CreateFeatureViewAsync(parent, featureView, featureViewId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureView, CreateFeatureViewOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureView, CreateFeatureViewOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetFeatureView</summary>
        public void GetFeatureViewRequestObject()
        {
            // Snippet: GetFeatureView(GetFeatureViewRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            GetFeatureViewRequest request = new GetFeatureViewRequest
            {
                FeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
            };
            // Make the request
            FeatureView response = featureOnlineStoreAdminServiceClient.GetFeatureView(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureViewAsync</summary>
        public async Task GetFeatureViewRequestObjectAsync()
        {
            // Snippet: GetFeatureViewAsync(GetFeatureViewRequest, CallSettings)
            // Additional: GetFeatureViewAsync(GetFeatureViewRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeatureViewRequest request = new GetFeatureViewRequest
            {
                FeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
            };
            // Make the request
            FeatureView response = await featureOnlineStoreAdminServiceClient.GetFeatureViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureView</summary>
        public void GetFeatureView()
        {
            // Snippet: GetFeatureView(string, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]";
            // Make the request
            FeatureView response = featureOnlineStoreAdminServiceClient.GetFeatureView(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureViewAsync</summary>
        public async Task GetFeatureViewAsync()
        {
            // Snippet: GetFeatureViewAsync(string, CallSettings)
            // Additional: GetFeatureViewAsync(string, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]";
            // Make the request
            FeatureView response = await featureOnlineStoreAdminServiceClient.GetFeatureViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureView</summary>
        public void GetFeatureViewResourceNames()
        {
            // Snippet: GetFeatureView(FeatureViewName, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureViewName name = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            // Make the request
            FeatureView response = featureOnlineStoreAdminServiceClient.GetFeatureView(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureViewAsync</summary>
        public async Task GetFeatureViewResourceNamesAsync()
        {
            // Snippet: GetFeatureViewAsync(FeatureViewName, CallSettings)
            // Additional: GetFeatureViewAsync(FeatureViewName, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureViewName name = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            // Make the request
            FeatureView response = await featureOnlineStoreAdminServiceClient.GetFeatureViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViews</summary>
        public void ListFeatureViewsRequestObject()
        {
            // Snippet: ListFeatureViews(ListFeatureViewsRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            ListFeatureViewsRequest request = new ListFeatureViewsRequest
            {
                ParentAsFeatureOnlineStoreName = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFeatureViewsResponse, FeatureView> response = featureOnlineStoreAdminServiceClient.ListFeatureViews(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViewsAsync</summary>
        public async Task ListFeatureViewsRequestObjectAsync()
        {
            // Snippet: ListFeatureViewsAsync(ListFeatureViewsRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeatureViewsRequest request = new ListFeatureViewsRequest
            {
                ParentAsFeatureOnlineStoreName = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFeatureViewsResponse, FeatureView> response = featureOnlineStoreAdminServiceClient.ListFeatureViewsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViews</summary>
        public void ListFeatureViews()
        {
            // Snippet: ListFeatureViews(string, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]";
            // Make the request
            PagedEnumerable<ListFeatureViewsResponse, FeatureView> response = featureOnlineStoreAdminServiceClient.ListFeatureViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViewsAsync</summary>
        public async Task ListFeatureViewsAsync()
        {
            // Snippet: ListFeatureViewsAsync(string, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]";
            // Make the request
            PagedAsyncEnumerable<ListFeatureViewsResponse, FeatureView> response = featureOnlineStoreAdminServiceClient.ListFeatureViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViews</summary>
        public void ListFeatureViewsResourceNames()
        {
            // Snippet: ListFeatureViews(FeatureOnlineStoreName, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureOnlineStoreName parent = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]");
            // Make the request
            PagedEnumerable<ListFeatureViewsResponse, FeatureView> response = featureOnlineStoreAdminServiceClient.ListFeatureViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViewsAsync</summary>
        public async Task ListFeatureViewsResourceNamesAsync()
        {
            // Snippet: ListFeatureViewsAsync(FeatureOnlineStoreName, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureOnlineStoreName parent = FeatureOnlineStoreName.FromProjectLocationFeatureOnlineStore("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListFeatureViewsResponse, FeatureView> response = featureOnlineStoreAdminServiceClient.ListFeatureViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureView</summary>
        public void UpdateFeatureViewRequestObject()
        {
            // Snippet: UpdateFeatureView(UpdateFeatureViewRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateFeatureViewRequest request = new UpdateFeatureViewRequest
            {
                FeatureView = new FeatureView(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> response = featureOnlineStoreAdminServiceClient.UpdateFeatureView(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceUpdateFeatureView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureViewAsync</summary>
        public async Task UpdateFeatureViewRequestObjectAsync()
        {
            // Snippet: UpdateFeatureViewAsync(UpdateFeatureViewRequest, CallSettings)
            // Additional: UpdateFeatureViewAsync(UpdateFeatureViewRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFeatureViewRequest request = new UpdateFeatureViewRequest
            {
                FeatureView = new FeatureView(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> response = await featureOnlineStoreAdminServiceClient.UpdateFeatureViewAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceUpdateFeatureViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureView</summary>
        public void UpdateFeatureView()
        {
            // Snippet: UpdateFeatureView(FeatureView, FieldMask, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureView featureView = new FeatureView();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> response = featureOnlineStoreAdminServiceClient.UpdateFeatureView(featureView, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceUpdateFeatureView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureViewAsync</summary>
        public async Task UpdateFeatureViewAsync()
        {
            // Snippet: UpdateFeatureViewAsync(FeatureView, FieldMask, CallSettings)
            // Additional: UpdateFeatureViewAsync(FeatureView, FieldMask, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureView featureView = new FeatureView();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> response = await featureOnlineStoreAdminServiceClient.UpdateFeatureViewAsync(featureView, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceUpdateFeatureViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureView</summary>
        public void DeleteFeatureViewRequestObject()
        {
            // Snippet: DeleteFeatureView(DeleteFeatureViewRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteFeatureViewRequest request = new DeleteFeatureViewRequest
            {
                FeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureOnlineStoreAdminServiceClient.DeleteFeatureView(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureViewAsync</summary>
        public async Task DeleteFeatureViewRequestObjectAsync()
        {
            // Snippet: DeleteFeatureViewAsync(DeleteFeatureViewRequest, CallSettings)
            // Additional: DeleteFeatureViewAsync(DeleteFeatureViewRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeatureViewRequest request = new DeleteFeatureViewRequest
            {
                FeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureOnlineStoreAdminServiceClient.DeleteFeatureViewAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureView</summary>
        public void DeleteFeatureView()
        {
            // Snippet: DeleteFeatureView(string, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureOnlineStoreAdminServiceClient.DeleteFeatureView(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureViewAsync</summary>
        public async Task DeleteFeatureViewAsync()
        {
            // Snippet: DeleteFeatureViewAsync(string, CallSettings)
            // Additional: DeleteFeatureViewAsync(string, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureOnlineStoreAdminServiceClient.DeleteFeatureViewAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureView</summary>
        public void DeleteFeatureViewResourceNames()
        {
            // Snippet: DeleteFeatureView(FeatureViewName, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureViewName name = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featureOnlineStoreAdminServiceClient.DeleteFeatureView(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureViewAsync</summary>
        public async Task DeleteFeatureViewResourceNamesAsync()
        {
            // Snippet: DeleteFeatureViewAsync(FeatureViewName, CallSettings)
            // Additional: DeleteFeatureViewAsync(FeatureViewName, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureViewName name = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featureOnlineStoreAdminServiceClient.DeleteFeatureViewAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceDeleteFeatureViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SyncFeatureView</summary>
        public void SyncFeatureViewRequestObject()
        {
            // Snippet: SyncFeatureView(SyncFeatureViewRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            SyncFeatureViewRequest request = new SyncFeatureViewRequest
            {
                FeatureViewAsFeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
            };
            // Make the request
            SyncFeatureViewResponse response = featureOnlineStoreAdminServiceClient.SyncFeatureView(request);
            // End snippet
        }

        /// <summary>Snippet for SyncFeatureViewAsync</summary>
        public async Task SyncFeatureViewRequestObjectAsync()
        {
            // Snippet: SyncFeatureViewAsync(SyncFeatureViewRequest, CallSettings)
            // Additional: SyncFeatureViewAsync(SyncFeatureViewRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SyncFeatureViewRequest request = new SyncFeatureViewRequest
            {
                FeatureViewAsFeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
            };
            // Make the request
            SyncFeatureViewResponse response = await featureOnlineStoreAdminServiceClient.SyncFeatureViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SyncFeatureView</summary>
        public void SyncFeatureView()
        {
            // Snippet: SyncFeatureView(string, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            string featureView = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]";
            // Make the request
            SyncFeatureViewResponse response = featureOnlineStoreAdminServiceClient.SyncFeatureView(featureView);
            // End snippet
        }

        /// <summary>Snippet for SyncFeatureViewAsync</summary>
        public async Task SyncFeatureViewAsync()
        {
            // Snippet: SyncFeatureViewAsync(string, CallSettings)
            // Additional: SyncFeatureViewAsync(string, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string featureView = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]";
            // Make the request
            SyncFeatureViewResponse response = await featureOnlineStoreAdminServiceClient.SyncFeatureViewAsync(featureView);
            // End snippet
        }

        /// <summary>Snippet for SyncFeatureView</summary>
        public void SyncFeatureViewResourceNames()
        {
            // Snippet: SyncFeatureView(FeatureViewName, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureViewName featureView = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            // Make the request
            SyncFeatureViewResponse response = featureOnlineStoreAdminServiceClient.SyncFeatureView(featureView);
            // End snippet
        }

        /// <summary>Snippet for SyncFeatureViewAsync</summary>
        public async Task SyncFeatureViewResourceNamesAsync()
        {
            // Snippet: SyncFeatureViewAsync(FeatureViewName, CallSettings)
            // Additional: SyncFeatureViewAsync(FeatureViewName, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureViewName featureView = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            // Make the request
            SyncFeatureViewResponse response = await featureOnlineStoreAdminServiceClient.SyncFeatureViewAsync(featureView);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureViewSync</summary>
        public void GetFeatureViewSyncRequestObject()
        {
            // Snippet: GetFeatureViewSync(GetFeatureViewSyncRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            GetFeatureViewSyncRequest request = new GetFeatureViewSyncRequest
            {
                FeatureViewSyncName = FeatureViewSyncName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
            };
            // Make the request
            FeatureViewSync response = featureOnlineStoreAdminServiceClient.GetFeatureViewSync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureViewSyncAsync</summary>
        public async Task GetFeatureViewSyncRequestObjectAsync()
        {
            // Snippet: GetFeatureViewSyncAsync(GetFeatureViewSyncRequest, CallSettings)
            // Additional: GetFeatureViewSyncAsync(GetFeatureViewSyncRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeatureViewSyncRequest request = new GetFeatureViewSyncRequest
            {
                FeatureViewSyncName = FeatureViewSyncName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
            };
            // Make the request
            FeatureViewSync response = await featureOnlineStoreAdminServiceClient.GetFeatureViewSyncAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureViewSync</summary>
        public void GetFeatureViewSync()
        {
            // Snippet: GetFeatureViewSync(string, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]/featureViewSyncs/feature_view_sync";
            // Make the request
            FeatureViewSync response = featureOnlineStoreAdminServiceClient.GetFeatureViewSync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureViewSyncAsync</summary>
        public async Task GetFeatureViewSyncAsync()
        {
            // Snippet: GetFeatureViewSyncAsync(string, CallSettings)
            // Additional: GetFeatureViewSyncAsync(string, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]/featureViewSyncs/feature_view_sync";
            // Make the request
            FeatureViewSync response = await featureOnlineStoreAdminServiceClient.GetFeatureViewSyncAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureViewSync</summary>
        public void GetFeatureViewSyncResourceNames()
        {
            // Snippet: GetFeatureViewSync(FeatureViewSyncName, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureViewSyncName name = FeatureViewSyncName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            // Make the request
            FeatureViewSync response = featureOnlineStoreAdminServiceClient.GetFeatureViewSync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureViewSyncAsync</summary>
        public async Task GetFeatureViewSyncResourceNamesAsync()
        {
            // Snippet: GetFeatureViewSyncAsync(FeatureViewSyncName, CallSettings)
            // Additional: GetFeatureViewSyncAsync(FeatureViewSyncName, CancellationToken)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureViewSyncName name = FeatureViewSyncName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            // Make the request
            FeatureViewSync response = await featureOnlineStoreAdminServiceClient.GetFeatureViewSyncAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViewSyncs</summary>
        public void ListFeatureViewSyncsRequestObject()
        {
            // Snippet: ListFeatureViewSyncs(ListFeatureViewSyncsRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            ListFeatureViewSyncsRequest request = new ListFeatureViewSyncsRequest
            {
                ParentAsFeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> response = featureOnlineStoreAdminServiceClient.ListFeatureViewSyncs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureViewSync item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureViewSyncsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureViewSync item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureViewSync> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureViewSync item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViewSyncsAsync</summary>
        public async Task ListFeatureViewSyncsRequestObjectAsync()
        {
            // Snippet: ListFeatureViewSyncsAsync(ListFeatureViewSyncsRequest, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeatureViewSyncsRequest request = new ListFeatureViewSyncsRequest
            {
                ParentAsFeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> response = featureOnlineStoreAdminServiceClient.ListFeatureViewSyncsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureViewSync item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureViewSyncsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureViewSync item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureViewSync> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureViewSync item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViewSyncs</summary>
        public void ListFeatureViewSyncs()
        {
            // Snippet: ListFeatureViewSyncs(string, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]";
            // Make the request
            PagedEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> response = featureOnlineStoreAdminServiceClient.ListFeatureViewSyncs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureViewSync item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureViewSyncsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureViewSync item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureViewSync> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureViewSync item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViewSyncsAsync</summary>
        public async Task ListFeatureViewSyncsAsync()
        {
            // Snippet: ListFeatureViewSyncsAsync(string, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]";
            // Make the request
            PagedAsyncEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> response = featureOnlineStoreAdminServiceClient.ListFeatureViewSyncsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureViewSync item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureViewSyncsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureViewSync item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureViewSync> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureViewSync item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViewSyncs</summary>
        public void ListFeatureViewSyncsResourceNames()
        {
            // Snippet: ListFeatureViewSyncs(FeatureViewName, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureViewName parent = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            // Make the request
            PagedEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> response = featureOnlineStoreAdminServiceClient.ListFeatureViewSyncs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeatureViewSync item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeatureViewSyncsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureViewSync item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureViewSync> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureViewSync item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatureViewSyncsAsync</summary>
        public async Task ListFeatureViewSyncsResourceNamesAsync()
        {
            // Snippet: ListFeatureViewSyncsAsync(FeatureViewName, string, int?, CallSettings)
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureViewName parent = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            // Make the request
            PagedAsyncEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> response = featureOnlineStoreAdminServiceClient.ListFeatureViewSyncsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FeatureViewSync item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeatureViewSyncsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeatureViewSync item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeatureViewSync> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeatureViewSync item in singlePage)
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
