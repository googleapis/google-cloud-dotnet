// Copyright 2026 Google LLC
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
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;
    using gcvv = Google.Cloud.VectorSearch.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVectorSearchServiceClientSnippets
    {
        /// <summary>Snippet for ListCollections</summary>
        public void ListCollectionsRequestObject()
        {
            // Snippet: ListCollections(ListCollectionsRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::ListCollectionsRequest request = new gcvv::ListCollectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = vectorSearchServiceClient.ListCollections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Collection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionsAsync</summary>
        public async Task ListCollectionsRequestObjectAsync()
        {
            // Snippet: ListCollectionsAsync(ListCollectionsRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ListCollectionsRequest request = new gcvv::ListCollectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = vectorSearchServiceClient.ListCollectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcvv::Collection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcvv::ListCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollections</summary>
        public void ListCollections()
        {
            // Snippet: ListCollections(string, string, int?, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = vectorSearchServiceClient.ListCollections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Collection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionsAsync</summary>
        public async Task ListCollectionsAsync()
        {
            // Snippet: ListCollectionsAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = vectorSearchServiceClient.ListCollectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcvv::Collection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcvv::ListCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollections</summary>
        public void ListCollectionsResourceNames()
        {
            // Snippet: ListCollections(LocationName, string, int?, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = vectorSearchServiceClient.ListCollections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Collection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionsAsync</summary>
        public async Task ListCollectionsResourceNamesAsync()
        {
            // Snippet: ListCollectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = vectorSearchServiceClient.ListCollectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcvv::Collection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcvv::ListCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCollection</summary>
        public void GetCollectionRequestObject()
        {
            // Snippet: GetCollection(GetCollectionRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::GetCollectionRequest request = new gcvv::GetCollectionRequest
            {
                CollectionName = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
            };
            // Make the request
            gcvv::Collection response = vectorSearchServiceClient.GetCollection(request);
            // End snippet
        }

        /// <summary>Snippet for GetCollectionAsync</summary>
        public async Task GetCollectionRequestObjectAsync()
        {
            // Snippet: GetCollectionAsync(GetCollectionRequest, CallSettings)
            // Additional: GetCollectionAsync(GetCollectionRequest, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GetCollectionRequest request = new gcvv::GetCollectionRequest
            {
                CollectionName = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
            };
            // Make the request
            gcvv::Collection response = await vectorSearchServiceClient.GetCollectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCollection</summary>
        public void GetCollection()
        {
            // Snippet: GetCollection(string, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            gcvv::Collection response = vectorSearchServiceClient.GetCollection(name);
            // End snippet
        }

        /// <summary>Snippet for GetCollectionAsync</summary>
        public async Task GetCollectionAsync()
        {
            // Snippet: GetCollectionAsync(string, CallSettings)
            // Additional: GetCollectionAsync(string, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            gcvv::Collection response = await vectorSearchServiceClient.GetCollectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCollection</summary>
        public void GetCollectionResourceNames()
        {
            // Snippet: GetCollection(CollectionName, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::CollectionName name = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            gcvv::Collection response = vectorSearchServiceClient.GetCollection(name);
            // End snippet
        }

        /// <summary>Snippet for GetCollectionAsync</summary>
        public async Task GetCollectionResourceNamesAsync()
        {
            // Snippet: GetCollectionAsync(CollectionName, CallSettings)
            // Additional: GetCollectionAsync(CollectionName, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CollectionName name = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            gcvv::Collection response = await vectorSearchServiceClient.GetCollectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCollection</summary>
        public void CreateCollectionRequestObject()
        {
            // Snippet: CreateCollection(CreateCollectionRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::CreateCollectionRequest request = new gcvv::CreateCollectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CollectionId = "",
                Collection = new gcvv::Collection(),
                RequestId = "",
            };
            // Make the request
            Operation<gcvv::Collection, gcvv::OperationMetadata> response = vectorSearchServiceClient.CreateCollection(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceCreateCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollectionAsync</summary>
        public async Task CreateCollectionRequestObjectAsync()
        {
            // Snippet: CreateCollectionAsync(CreateCollectionRequest, CallSettings)
            // Additional: CreateCollectionAsync(CreateCollectionRequest, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CreateCollectionRequest request = new gcvv::CreateCollectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CollectionId = "",
                Collection = new gcvv::Collection(),
                RequestId = "",
            };
            // Make the request
            Operation<gcvv::Collection, gcvv::OperationMetadata> response = await vectorSearchServiceClient.CreateCollectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceCreateCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollection</summary>
        public void CreateCollection()
        {
            // Snippet: CreateCollection(string, Collection, string, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcvv::Collection collection = new gcvv::Collection();
            string collectionId = "";
            // Make the request
            Operation<gcvv::Collection, gcvv::OperationMetadata> response = vectorSearchServiceClient.CreateCollection(parent, collection, collectionId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceCreateCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollectionAsync</summary>
        public async Task CreateCollectionAsync()
        {
            // Snippet: CreateCollectionAsync(string, Collection, string, CallSettings)
            // Additional: CreateCollectionAsync(string, Collection, string, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcvv::Collection collection = new gcvv::Collection();
            string collectionId = "";
            // Make the request
            Operation<gcvv::Collection, gcvv::OperationMetadata> response = await vectorSearchServiceClient.CreateCollectionAsync(parent, collection, collectionId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceCreateCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollection</summary>
        public void CreateCollectionResourceNames()
        {
            // Snippet: CreateCollection(LocationName, Collection, string, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcvv::Collection collection = new gcvv::Collection();
            string collectionId = "";
            // Make the request
            Operation<gcvv::Collection, gcvv::OperationMetadata> response = vectorSearchServiceClient.CreateCollection(parent, collection, collectionId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceCreateCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollectionAsync</summary>
        public async Task CreateCollectionResourceNamesAsync()
        {
            // Snippet: CreateCollectionAsync(LocationName, Collection, string, CallSettings)
            // Additional: CreateCollectionAsync(LocationName, Collection, string, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcvv::Collection collection = new gcvv::Collection();
            string collectionId = "";
            // Make the request
            Operation<gcvv::Collection, gcvv::OperationMetadata> response = await vectorSearchServiceClient.CreateCollectionAsync(parent, collection, collectionId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceCreateCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCollection</summary>
        public void UpdateCollectionRequestObject()
        {
            // Snippet: UpdateCollection(UpdateCollectionRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::UpdateCollectionRequest request = new gcvv::UpdateCollectionRequest
            {
                UpdateMask = new FieldMask(),
                Collection = new gcvv::Collection(),
                RequestId = "",
            };
            // Make the request
            Operation<gcvv::Collection, gcvv::OperationMetadata> response = vectorSearchServiceClient.UpdateCollection(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceUpdateCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCollectionAsync</summary>
        public async Task UpdateCollectionRequestObjectAsync()
        {
            // Snippet: UpdateCollectionAsync(UpdateCollectionRequest, CallSettings)
            // Additional: UpdateCollectionAsync(UpdateCollectionRequest, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UpdateCollectionRequest request = new gcvv::UpdateCollectionRequest
            {
                UpdateMask = new FieldMask(),
                Collection = new gcvv::Collection(),
                RequestId = "",
            };
            // Make the request
            Operation<gcvv::Collection, gcvv::OperationMetadata> response = await vectorSearchServiceClient.UpdateCollectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceUpdateCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCollection</summary>
        public void UpdateCollection()
        {
            // Snippet: UpdateCollection(Collection, FieldMask, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::Collection collection = new gcvv::Collection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcvv::Collection, gcvv::OperationMetadata> response = vectorSearchServiceClient.UpdateCollection(collection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceUpdateCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCollectionAsync</summary>
        public async Task UpdateCollectionAsync()
        {
            // Snippet: UpdateCollectionAsync(Collection, FieldMask, CallSettings)
            // Additional: UpdateCollectionAsync(Collection, FieldMask, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::Collection collection = new gcvv::Collection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcvv::Collection, gcvv::OperationMetadata> response = await vectorSearchServiceClient.UpdateCollectionAsync(collection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceUpdateCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollection</summary>
        public void DeleteCollectionRequestObject()
        {
            // Snippet: DeleteCollection(DeleteCollectionRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::DeleteCollectionRequest request = new gcvv::DeleteCollectionRequest
            {
                CollectionName = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = vectorSearchServiceClient.DeleteCollection(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceDeleteCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectionAsync</summary>
        public async Task DeleteCollectionRequestObjectAsync()
        {
            // Snippet: DeleteCollectionAsync(DeleteCollectionRequest, CallSettings)
            // Additional: DeleteCollectionAsync(DeleteCollectionRequest, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeleteCollectionRequest request = new gcvv::DeleteCollectionRequest
            {
                CollectionName = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = await vectorSearchServiceClient.DeleteCollectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceDeleteCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollection</summary>
        public void DeleteCollection()
        {
            // Snippet: DeleteCollection(string, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = vectorSearchServiceClient.DeleteCollection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceDeleteCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectionAsync</summary>
        public async Task DeleteCollectionAsync()
        {
            // Snippet: DeleteCollectionAsync(string, CallSettings)
            // Additional: DeleteCollectionAsync(string, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = await vectorSearchServiceClient.DeleteCollectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceDeleteCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollection</summary>
        public void DeleteCollectionResourceNames()
        {
            // Snippet: DeleteCollection(CollectionName, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::CollectionName name = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = vectorSearchServiceClient.DeleteCollection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceDeleteCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectionAsync</summary>
        public async Task DeleteCollectionResourceNamesAsync()
        {
            // Snippet: DeleteCollectionAsync(CollectionName, CallSettings)
            // Additional: DeleteCollectionAsync(CollectionName, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CollectionName name = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = await vectorSearchServiceClient.DeleteCollectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceDeleteCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexesRequestObject()
        {
            // Snippet: ListIndexes(ListIndexesRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::ListIndexesRequest request = new gcvv::ListIndexesRequest
            {
                ParentAsCollectionName = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = vectorSearchServiceClient.ListIndexes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesRequestObjectAsync()
        {
            // Snippet: ListIndexesAsync(ListIndexesRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ListIndexesRequest request = new gcvv::ListIndexesRequest
            {
                ParentAsCollectionName = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = vectorSearchServiceClient.ListIndexesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcvv::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcvv::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexes()
        {
            // Snippet: ListIndexes(string, string, int?, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            PagedEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = vectorSearchServiceClient.ListIndexes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesAsync()
        {
            // Snippet: ListIndexesAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = vectorSearchServiceClient.ListIndexesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcvv::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcvv::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexesResourceNames()
        {
            // Snippet: ListIndexes(CollectionName, string, int?, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::CollectionName parent = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            PagedEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = vectorSearchServiceClient.ListIndexes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesResourceNamesAsync()
        {
            // Snippet: ListIndexesAsync(CollectionName, string, int?, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CollectionName parent = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = vectorSearchServiceClient.ListIndexesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcvv::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcvv::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndexRequestObject()
        {
            // Snippet: GetIndex(GetIndexRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::GetIndexRequest request = new gcvv::GetIndexRequest
            {
                IndexName = gcvv::IndexName.FromProjectLocationCollectionIndex("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[INDEX]"),
            };
            // Make the request
            gcvv::Index response = vectorSearchServiceClient.GetIndex(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexRequestObjectAsync()
        {
            // Snippet: GetIndexAsync(GetIndexRequest, CallSettings)
            // Additional: GetIndexAsync(GetIndexRequest, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GetIndexRequest request = new gcvv::GetIndexRequest
            {
                IndexName = gcvv::IndexName.FromProjectLocationCollectionIndex("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[INDEX]"),
            };
            // Make the request
            gcvv::Index response = await vectorSearchServiceClient.GetIndexAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndex()
        {
            // Snippet: GetIndex(string, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/indexes/[INDEX]";
            // Make the request
            gcvv::Index response = vectorSearchServiceClient.GetIndex(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexAsync()
        {
            // Snippet: GetIndexAsync(string, CallSettings)
            // Additional: GetIndexAsync(string, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/indexes/[INDEX]";
            // Make the request
            gcvv::Index response = await vectorSearchServiceClient.GetIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndexResourceNames()
        {
            // Snippet: GetIndex(IndexName, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::IndexName name = gcvv::IndexName.FromProjectLocationCollectionIndex("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[INDEX]");
            // Make the request
            gcvv::Index response = vectorSearchServiceClient.GetIndex(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexResourceNamesAsync()
        {
            // Snippet: GetIndexAsync(IndexName, CallSettings)
            // Additional: GetIndexAsync(IndexName, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::IndexName name = gcvv::IndexName.FromProjectLocationCollectionIndex("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[INDEX]");
            // Make the request
            gcvv::Index response = await vectorSearchServiceClient.GetIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndexRequestObject()
        {
            // Snippet: CreateIndex(CreateIndexRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::CreateIndexRequest request = new gcvv::CreateIndexRequest
            {
                ParentAsCollectionName = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                IndexId = "",
                Index = new gcvv::Index(),
                RequestId = "",
            };
            // Make the request
            Operation<gcvv::Index, gcvv::OperationMetadata> response = vectorSearchServiceClient.CreateIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexRequestObjectAsync()
        {
            // Snippet: CreateIndexAsync(CreateIndexRequest, CallSettings)
            // Additional: CreateIndexAsync(CreateIndexRequest, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CreateIndexRequest request = new gcvv::CreateIndexRequest
            {
                ParentAsCollectionName = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                IndexId = "",
                Index = new gcvv::Index(),
                RequestId = "",
            };
            // Make the request
            Operation<gcvv::Index, gcvv::OperationMetadata> response = await vectorSearchServiceClient.CreateIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndex()
        {
            // Snippet: CreateIndex(string, Index, string, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            gcvv::Index index = new gcvv::Index();
            string indexId = "";
            // Make the request
            Operation<gcvv::Index, gcvv::OperationMetadata> response = vectorSearchServiceClient.CreateIndex(parent, index, indexId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexAsync()
        {
            // Snippet: CreateIndexAsync(string, Index, string, CallSettings)
            // Additional: CreateIndexAsync(string, Index, string, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            gcvv::Index index = new gcvv::Index();
            string indexId = "";
            // Make the request
            Operation<gcvv::Index, gcvv::OperationMetadata> response = await vectorSearchServiceClient.CreateIndexAsync(parent, index, indexId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndexResourceNames()
        {
            // Snippet: CreateIndex(CollectionName, Index, string, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::CollectionName parent = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            gcvv::Index index = new gcvv::Index();
            string indexId = "";
            // Make the request
            Operation<gcvv::Index, gcvv::OperationMetadata> response = vectorSearchServiceClient.CreateIndex(parent, index, indexId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexResourceNamesAsync()
        {
            // Snippet: CreateIndexAsync(CollectionName, Index, string, CallSettings)
            // Additional: CreateIndexAsync(CollectionName, Index, string, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CollectionName parent = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            gcvv::Index index = new gcvv::Index();
            string indexId = "";
            // Make the request
            Operation<gcvv::Index, gcvv::OperationMetadata> response = await vectorSearchServiceClient.CreateIndexAsync(parent, index, indexId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndexRequestObject()
        {
            // Snippet: DeleteIndex(DeleteIndexRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::DeleteIndexRequest request = new gcvv::DeleteIndexRequest
            {
                IndexName = gcvv::IndexName.FromProjectLocationCollectionIndex("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[INDEX]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = vectorSearchServiceClient.DeleteIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceDeleteIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexRequestObjectAsync()
        {
            // Snippet: DeleteIndexAsync(DeleteIndexRequest, CallSettings)
            // Additional: DeleteIndexAsync(DeleteIndexRequest, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeleteIndexRequest request = new gcvv::DeleteIndexRequest
            {
                IndexName = gcvv::IndexName.FromProjectLocationCollectionIndex("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[INDEX]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = await vectorSearchServiceClient.DeleteIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceDeleteIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndex()
        {
            // Snippet: DeleteIndex(string, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/indexes/[INDEX]";
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = vectorSearchServiceClient.DeleteIndex(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceDeleteIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexAsync()
        {
            // Snippet: DeleteIndexAsync(string, CallSettings)
            // Additional: DeleteIndexAsync(string, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/indexes/[INDEX]";
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = await vectorSearchServiceClient.DeleteIndexAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceDeleteIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndexResourceNames()
        {
            // Snippet: DeleteIndex(IndexName, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::IndexName name = gcvv::IndexName.FromProjectLocationCollectionIndex("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[INDEX]");
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = vectorSearchServiceClient.DeleteIndex(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceDeleteIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexResourceNamesAsync()
        {
            // Snippet: DeleteIndexAsync(IndexName, CallSettings)
            // Additional: DeleteIndexAsync(IndexName, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::IndexName name = gcvv::IndexName.FromProjectLocationCollectionIndex("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[INDEX]");
            // Make the request
            Operation<Empty, gcvv::OperationMetadata> response = await vectorSearchServiceClient.DeleteIndexAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::OperationMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceDeleteIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataObjects</summary>
        public void ImportDataObjectsRequestObject()
        {
            // Snippet: ImportDataObjects(ImportDataObjectsRequest, CallSettings)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = gcvv::VectorSearchServiceClient.Create();
            // Initialize request argument(s)
            gcvv::ImportDataObjectsRequest request = new gcvv::ImportDataObjectsRequest
            {
                CollectionName = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                GcsImport = new gcvv::ImportDataObjectsRequest.Types.GcsImportConfig(),
            };
            // Make the request
            Operation<gcvv::ImportDataObjectsResponse, gcvv::ImportDataObjectsMetadata> response = vectorSearchServiceClient.ImportDataObjects(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::ImportDataObjectsResponse, gcvv::ImportDataObjectsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::ImportDataObjectsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::ImportDataObjectsResponse, gcvv::ImportDataObjectsMetadata> retrievedResponse = vectorSearchServiceClient.PollOnceImportDataObjects(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::ImportDataObjectsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataObjectsAsync</summary>
        public async Task ImportDataObjectsRequestObjectAsync()
        {
            // Snippet: ImportDataObjectsAsync(ImportDataObjectsRequest, CallSettings)
            // Additional: ImportDataObjectsAsync(ImportDataObjectsRequest, CancellationToken)
            // Create client
            gcvv::VectorSearchServiceClient vectorSearchServiceClient = await gcvv::VectorSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ImportDataObjectsRequest request = new gcvv::ImportDataObjectsRequest
            {
                CollectionName = gcvv::CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                GcsImport = new gcvv::ImportDataObjectsRequest.Types.GcsImportConfig(),
            };
            // Make the request
            Operation<gcvv::ImportDataObjectsResponse, gcvv::ImportDataObjectsMetadata> response = await vectorSearchServiceClient.ImportDataObjectsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::ImportDataObjectsResponse, gcvv::ImportDataObjectsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::ImportDataObjectsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::ImportDataObjectsResponse, gcvv::ImportDataObjectsMetadata> retrievedResponse = await vectorSearchServiceClient.PollOnceImportDataObjectsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::ImportDataObjectsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
