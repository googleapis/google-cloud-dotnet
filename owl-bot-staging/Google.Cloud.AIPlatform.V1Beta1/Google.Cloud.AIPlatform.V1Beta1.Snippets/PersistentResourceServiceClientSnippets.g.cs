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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPersistentResourceServiceClientSnippets
    {
        /// <summary>Snippet for CreatePersistentResource</summary>
        public void CreatePersistentResourceRequestObject()
        {
            // Snippet: CreatePersistentResource(CreatePersistentResourceRequest, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            CreatePersistentResourceRequest request = new CreatePersistentResourceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PersistentResource = new PersistentResource(),
                PersistentResourceId = "",
            };
            // Make the request
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> response = persistentResourceServiceClient.CreatePersistentResource(request);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceCreatePersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePersistentResourceAsync</summary>
        public async Task CreatePersistentResourceRequestObjectAsync()
        {
            // Snippet: CreatePersistentResourceAsync(CreatePersistentResourceRequest, CallSettings)
            // Additional: CreatePersistentResourceAsync(CreatePersistentResourceRequest, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePersistentResourceRequest request = new CreatePersistentResourceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PersistentResource = new PersistentResource(),
                PersistentResourceId = "",
            };
            // Make the request
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> response = await persistentResourceServiceClient.CreatePersistentResourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceCreatePersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePersistentResource</summary>
        public void CreatePersistentResource()
        {
            // Snippet: CreatePersistentResource(string, PersistentResource, string, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PersistentResource persistentResource = new PersistentResource();
            string persistentResourceId = "";
            // Make the request
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> response = persistentResourceServiceClient.CreatePersistentResource(parent, persistentResource, persistentResourceId);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceCreatePersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePersistentResourceAsync</summary>
        public async Task CreatePersistentResourceAsync()
        {
            // Snippet: CreatePersistentResourceAsync(string, PersistentResource, string, CallSettings)
            // Additional: CreatePersistentResourceAsync(string, PersistentResource, string, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PersistentResource persistentResource = new PersistentResource();
            string persistentResourceId = "";
            // Make the request
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> response = await persistentResourceServiceClient.CreatePersistentResourceAsync(parent, persistentResource, persistentResourceId);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceCreatePersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePersistentResource</summary>
        public void CreatePersistentResourceResourceNames()
        {
            // Snippet: CreatePersistentResource(LocationName, PersistentResource, string, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PersistentResource persistentResource = new PersistentResource();
            string persistentResourceId = "";
            // Make the request
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> response = persistentResourceServiceClient.CreatePersistentResource(parent, persistentResource, persistentResourceId);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceCreatePersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePersistentResourceAsync</summary>
        public async Task CreatePersistentResourceResourceNamesAsync()
        {
            // Snippet: CreatePersistentResourceAsync(LocationName, PersistentResource, string, CallSettings)
            // Additional: CreatePersistentResourceAsync(LocationName, PersistentResource, string, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PersistentResource persistentResource = new PersistentResource();
            string persistentResourceId = "";
            // Make the request
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> response = await persistentResourceServiceClient.CreatePersistentResourceAsync(parent, persistentResource, persistentResourceId);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceCreatePersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPersistentResource</summary>
        public void GetPersistentResourceRequestObject()
        {
            // Snippet: GetPersistentResource(GetPersistentResourceRequest, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            GetPersistentResourceRequest request = new GetPersistentResourceRequest
            {
                PersistentResourceName = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]"),
            };
            // Make the request
            PersistentResource response = persistentResourceServiceClient.GetPersistentResource(request);
            // End snippet
        }

        /// <summary>Snippet for GetPersistentResourceAsync</summary>
        public async Task GetPersistentResourceRequestObjectAsync()
        {
            // Snippet: GetPersistentResourceAsync(GetPersistentResourceRequest, CallSettings)
            // Additional: GetPersistentResourceAsync(GetPersistentResourceRequest, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPersistentResourceRequest request = new GetPersistentResourceRequest
            {
                PersistentResourceName = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]"),
            };
            // Make the request
            PersistentResource response = await persistentResourceServiceClient.GetPersistentResourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPersistentResource</summary>
        public void GetPersistentResource()
        {
            // Snippet: GetPersistentResource(string, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/persistentResources/[PERSISTENT_RESOURCE]";
            // Make the request
            PersistentResource response = persistentResourceServiceClient.GetPersistentResource(name);
            // End snippet
        }

        /// <summary>Snippet for GetPersistentResourceAsync</summary>
        public async Task GetPersistentResourceAsync()
        {
            // Snippet: GetPersistentResourceAsync(string, CallSettings)
            // Additional: GetPersistentResourceAsync(string, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/persistentResources/[PERSISTENT_RESOURCE]";
            // Make the request
            PersistentResource response = await persistentResourceServiceClient.GetPersistentResourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPersistentResource</summary>
        public void GetPersistentResourceResourceNames()
        {
            // Snippet: GetPersistentResource(PersistentResourceName, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            PersistentResourceName name = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]");
            // Make the request
            PersistentResource response = persistentResourceServiceClient.GetPersistentResource(name);
            // End snippet
        }

        /// <summary>Snippet for GetPersistentResourceAsync</summary>
        public async Task GetPersistentResourceResourceNamesAsync()
        {
            // Snippet: GetPersistentResourceAsync(PersistentResourceName, CallSettings)
            // Additional: GetPersistentResourceAsync(PersistentResourceName, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            PersistentResourceName name = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]");
            // Make the request
            PersistentResource response = await persistentResourceServiceClient.GetPersistentResourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPersistentResources</summary>
        public void ListPersistentResourcesRequestObject()
        {
            // Snippet: ListPersistentResources(ListPersistentResourcesRequest, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            ListPersistentResourcesRequest request = new ListPersistentResourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListPersistentResourcesResponse, PersistentResource> response = persistentResourceServiceClient.ListPersistentResources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PersistentResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPersistentResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PersistentResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PersistentResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PersistentResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPersistentResourcesAsync</summary>
        public async Task ListPersistentResourcesRequestObjectAsync()
        {
            // Snippet: ListPersistentResourcesAsync(ListPersistentResourcesRequest, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPersistentResourcesRequest request = new ListPersistentResourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPersistentResourcesResponse, PersistentResource> response = persistentResourceServiceClient.ListPersistentResourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PersistentResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPersistentResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PersistentResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PersistentResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PersistentResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPersistentResources</summary>
        public void ListPersistentResources()
        {
            // Snippet: ListPersistentResources(string, string, int?, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPersistentResourcesResponse, PersistentResource> response = persistentResourceServiceClient.ListPersistentResources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PersistentResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPersistentResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PersistentResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PersistentResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PersistentResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPersistentResourcesAsync</summary>
        public async Task ListPersistentResourcesAsync()
        {
            // Snippet: ListPersistentResourcesAsync(string, string, int?, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPersistentResourcesResponse, PersistentResource> response = persistentResourceServiceClient.ListPersistentResourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PersistentResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPersistentResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PersistentResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PersistentResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PersistentResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPersistentResources</summary>
        public void ListPersistentResourcesResourceNames()
        {
            // Snippet: ListPersistentResources(LocationName, string, int?, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPersistentResourcesResponse, PersistentResource> response = persistentResourceServiceClient.ListPersistentResources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PersistentResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPersistentResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PersistentResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PersistentResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PersistentResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPersistentResourcesAsync</summary>
        public async Task ListPersistentResourcesResourceNamesAsync()
        {
            // Snippet: ListPersistentResourcesAsync(LocationName, string, int?, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPersistentResourcesResponse, PersistentResource> response = persistentResourceServiceClient.ListPersistentResourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PersistentResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPersistentResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PersistentResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PersistentResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PersistentResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeletePersistentResource</summary>
        public void DeletePersistentResourceRequestObject()
        {
            // Snippet: DeletePersistentResource(DeletePersistentResourceRequest, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            DeletePersistentResourceRequest request = new DeletePersistentResourceRequest
            {
                PersistentResourceName = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = persistentResourceServiceClient.DeletePersistentResource(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceDeletePersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePersistentResourceAsync</summary>
        public async Task DeletePersistentResourceRequestObjectAsync()
        {
            // Snippet: DeletePersistentResourceAsync(DeletePersistentResourceRequest, CallSettings)
            // Additional: DeletePersistentResourceAsync(DeletePersistentResourceRequest, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePersistentResourceRequest request = new DeletePersistentResourceRequest
            {
                PersistentResourceName = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await persistentResourceServiceClient.DeletePersistentResourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceDeletePersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePersistentResource</summary>
        public void DeletePersistentResource()
        {
            // Snippet: DeletePersistentResource(string, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/persistentResources/[PERSISTENT_RESOURCE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = persistentResourceServiceClient.DeletePersistentResource(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceDeletePersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePersistentResourceAsync</summary>
        public async Task DeletePersistentResourceAsync()
        {
            // Snippet: DeletePersistentResourceAsync(string, CallSettings)
            // Additional: DeletePersistentResourceAsync(string, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/persistentResources/[PERSISTENT_RESOURCE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await persistentResourceServiceClient.DeletePersistentResourceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceDeletePersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePersistentResource</summary>
        public void DeletePersistentResourceResourceNames()
        {
            // Snippet: DeletePersistentResource(PersistentResourceName, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            PersistentResourceName name = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = persistentResourceServiceClient.DeletePersistentResource(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceDeletePersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePersistentResourceAsync</summary>
        public async Task DeletePersistentResourceResourceNamesAsync()
        {
            // Snippet: DeletePersistentResourceAsync(PersistentResourceName, CallSettings)
            // Additional: DeletePersistentResourceAsync(PersistentResourceName, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            PersistentResourceName name = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await persistentResourceServiceClient.DeletePersistentResourceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceDeletePersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePersistentResource</summary>
        public void UpdatePersistentResourceRequestObject()
        {
            // Snippet: UpdatePersistentResource(UpdatePersistentResourceRequest, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            UpdatePersistentResourceRequest request = new UpdatePersistentResourceRequest
            {
                PersistentResource = new PersistentResource(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> response = persistentResourceServiceClient.UpdatePersistentResource(request);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceUpdatePersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePersistentResourceAsync</summary>
        public async Task UpdatePersistentResourceRequestObjectAsync()
        {
            // Snippet: UpdatePersistentResourceAsync(UpdatePersistentResourceRequest, CallSettings)
            // Additional: UpdatePersistentResourceAsync(UpdatePersistentResourceRequest, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePersistentResourceRequest request = new UpdatePersistentResourceRequest
            {
                PersistentResource = new PersistentResource(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> response = await persistentResourceServiceClient.UpdatePersistentResourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceUpdatePersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePersistentResource</summary>
        public void UpdatePersistentResource()
        {
            // Snippet: UpdatePersistentResource(PersistentResource, FieldMask, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            PersistentResource persistentResource = new PersistentResource();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> response = persistentResourceServiceClient.UpdatePersistentResource(persistentResource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceUpdatePersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePersistentResourceAsync</summary>
        public async Task UpdatePersistentResourceAsync()
        {
            // Snippet: UpdatePersistentResourceAsync(PersistentResource, FieldMask, CallSettings)
            // Additional: UpdatePersistentResourceAsync(PersistentResource, FieldMask, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            PersistentResource persistentResource = new PersistentResource();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> response = await persistentResourceServiceClient.UpdatePersistentResourceAsync(persistentResource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceUpdatePersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RebootPersistentResource</summary>
        public void RebootPersistentResourceRequestObject()
        {
            // Snippet: RebootPersistentResource(RebootPersistentResourceRequest, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            RebootPersistentResourceRequest request = new RebootPersistentResourceRequest
            {
                PersistentResourceName = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]"),
            };
            // Make the request
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> response = persistentResourceServiceClient.RebootPersistentResource(request);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceRebootPersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RebootPersistentResourceAsync</summary>
        public async Task RebootPersistentResourceRequestObjectAsync()
        {
            // Snippet: RebootPersistentResourceAsync(RebootPersistentResourceRequest, CallSettings)
            // Additional: RebootPersistentResourceAsync(RebootPersistentResourceRequest, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            RebootPersistentResourceRequest request = new RebootPersistentResourceRequest
            {
                PersistentResourceName = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]"),
            };
            // Make the request
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> response = await persistentResourceServiceClient.RebootPersistentResourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceRebootPersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RebootPersistentResource</summary>
        public void RebootPersistentResource()
        {
            // Snippet: RebootPersistentResource(string, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/persistentResources/[PERSISTENT_RESOURCE]";
            // Make the request
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> response = persistentResourceServiceClient.RebootPersistentResource(name);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceRebootPersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RebootPersistentResourceAsync</summary>
        public async Task RebootPersistentResourceAsync()
        {
            // Snippet: RebootPersistentResourceAsync(string, CallSettings)
            // Additional: RebootPersistentResourceAsync(string, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/persistentResources/[PERSISTENT_RESOURCE]";
            // Make the request
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> response = await persistentResourceServiceClient.RebootPersistentResourceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceRebootPersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RebootPersistentResource</summary>
        public void RebootPersistentResourceResourceNames()
        {
            // Snippet: RebootPersistentResource(PersistentResourceName, CallSettings)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            PersistentResourceName name = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]");
            // Make the request
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> response = persistentResourceServiceClient.RebootPersistentResource(name);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceRebootPersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RebootPersistentResourceAsync</summary>
        public async Task RebootPersistentResourceResourceNamesAsync()
        {
            // Snippet: RebootPersistentResourceAsync(PersistentResourceName, CallSettings)
            // Additional: RebootPersistentResourceAsync(PersistentResourceName, CancellationToken)
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            PersistentResourceName name = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]");
            // Make the request
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> response = await persistentResourceServiceClient.RebootPersistentResourceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, RebootPersistentResourceOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceRebootPersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
