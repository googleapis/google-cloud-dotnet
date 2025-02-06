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
    using Google.Cloud.Kms.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAutokeyClientSnippets
    {
        /// <summary>Snippet for CreateKeyHandle</summary>
        public void CreateKeyHandleRequestObject()
        {
            // Snippet: CreateKeyHandle(CreateKeyHandleRequest, CallSettings)
            // Create client
            AutokeyClient autokeyClient = AutokeyClient.Create();
            // Initialize request argument(s)
            CreateKeyHandleRequest request = new CreateKeyHandleRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyHandleId = "",
                KeyHandle = new KeyHandle(),
            };
            // Make the request
            Operation<KeyHandle, CreateKeyHandleMetadata> response = autokeyClient.CreateKeyHandle(request);

            // Poll until the returned long-running operation is complete
            Operation<KeyHandle, CreateKeyHandleMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            KeyHandle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KeyHandle, CreateKeyHandleMetadata> retrievedResponse = autokeyClient.PollOnceCreateKeyHandle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KeyHandle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKeyHandleAsync</summary>
        public async Task CreateKeyHandleRequestObjectAsync()
        {
            // Snippet: CreateKeyHandleAsync(CreateKeyHandleRequest, CallSettings)
            // Additional: CreateKeyHandleAsync(CreateKeyHandleRequest, CancellationToken)
            // Create client
            AutokeyClient autokeyClient = await AutokeyClient.CreateAsync();
            // Initialize request argument(s)
            CreateKeyHandleRequest request = new CreateKeyHandleRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyHandleId = "",
                KeyHandle = new KeyHandle(),
            };
            // Make the request
            Operation<KeyHandle, CreateKeyHandleMetadata> response = await autokeyClient.CreateKeyHandleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<KeyHandle, CreateKeyHandleMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            KeyHandle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KeyHandle, CreateKeyHandleMetadata> retrievedResponse = await autokeyClient.PollOnceCreateKeyHandleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KeyHandle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKeyHandle</summary>
        public void CreateKeyHandle()
        {
            // Snippet: CreateKeyHandle(string, KeyHandle, string, CallSettings)
            // Create client
            AutokeyClient autokeyClient = AutokeyClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            KeyHandle keyHandle = new KeyHandle();
            string keyHandleId = "";
            // Make the request
            Operation<KeyHandle, CreateKeyHandleMetadata> response = autokeyClient.CreateKeyHandle(parent, keyHandle, keyHandleId);

            // Poll until the returned long-running operation is complete
            Operation<KeyHandle, CreateKeyHandleMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            KeyHandle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KeyHandle, CreateKeyHandleMetadata> retrievedResponse = autokeyClient.PollOnceCreateKeyHandle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KeyHandle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKeyHandleAsync</summary>
        public async Task CreateKeyHandleAsync()
        {
            // Snippet: CreateKeyHandleAsync(string, KeyHandle, string, CallSettings)
            // Additional: CreateKeyHandleAsync(string, KeyHandle, string, CancellationToken)
            // Create client
            AutokeyClient autokeyClient = await AutokeyClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            KeyHandle keyHandle = new KeyHandle();
            string keyHandleId = "";
            // Make the request
            Operation<KeyHandle, CreateKeyHandleMetadata> response = await autokeyClient.CreateKeyHandleAsync(parent, keyHandle, keyHandleId);

            // Poll until the returned long-running operation is complete
            Operation<KeyHandle, CreateKeyHandleMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            KeyHandle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KeyHandle, CreateKeyHandleMetadata> retrievedResponse = await autokeyClient.PollOnceCreateKeyHandleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KeyHandle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKeyHandle</summary>
        public void CreateKeyHandleResourceNames()
        {
            // Snippet: CreateKeyHandle(LocationName, KeyHandle, string, CallSettings)
            // Create client
            AutokeyClient autokeyClient = AutokeyClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            KeyHandle keyHandle = new KeyHandle();
            string keyHandleId = "";
            // Make the request
            Operation<KeyHandle, CreateKeyHandleMetadata> response = autokeyClient.CreateKeyHandle(parent, keyHandle, keyHandleId);

            // Poll until the returned long-running operation is complete
            Operation<KeyHandle, CreateKeyHandleMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            KeyHandle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KeyHandle, CreateKeyHandleMetadata> retrievedResponse = autokeyClient.PollOnceCreateKeyHandle(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KeyHandle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKeyHandleAsync</summary>
        public async Task CreateKeyHandleResourceNamesAsync()
        {
            // Snippet: CreateKeyHandleAsync(LocationName, KeyHandle, string, CallSettings)
            // Additional: CreateKeyHandleAsync(LocationName, KeyHandle, string, CancellationToken)
            // Create client
            AutokeyClient autokeyClient = await AutokeyClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            KeyHandle keyHandle = new KeyHandle();
            string keyHandleId = "";
            // Make the request
            Operation<KeyHandle, CreateKeyHandleMetadata> response = await autokeyClient.CreateKeyHandleAsync(parent, keyHandle, keyHandleId);

            // Poll until the returned long-running operation is complete
            Operation<KeyHandle, CreateKeyHandleMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            KeyHandle result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KeyHandle, CreateKeyHandleMetadata> retrievedResponse = await autokeyClient.PollOnceCreateKeyHandleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KeyHandle retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetKeyHandle</summary>
        public void GetKeyHandleRequestObject()
        {
            // Snippet: GetKeyHandle(GetKeyHandleRequest, CallSettings)
            // Create client
            AutokeyClient autokeyClient = AutokeyClient.Create();
            // Initialize request argument(s)
            GetKeyHandleRequest request = new GetKeyHandleRequest
            {
                KeyHandleName = KeyHandleName.FromProjectLocationKeyHandle("[PROJECT]", "[LOCATION]", "[KEY_HANDLE]"),
            };
            // Make the request
            KeyHandle response = autokeyClient.GetKeyHandle(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyHandleAsync</summary>
        public async Task GetKeyHandleRequestObjectAsync()
        {
            // Snippet: GetKeyHandleAsync(GetKeyHandleRequest, CallSettings)
            // Additional: GetKeyHandleAsync(GetKeyHandleRequest, CancellationToken)
            // Create client
            AutokeyClient autokeyClient = await AutokeyClient.CreateAsync();
            // Initialize request argument(s)
            GetKeyHandleRequest request = new GetKeyHandleRequest
            {
                KeyHandleName = KeyHandleName.FromProjectLocationKeyHandle("[PROJECT]", "[LOCATION]", "[KEY_HANDLE]"),
            };
            // Make the request
            KeyHandle response = await autokeyClient.GetKeyHandleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyHandle</summary>
        public void GetKeyHandle()
        {
            // Snippet: GetKeyHandle(string, CallSettings)
            // Create client
            AutokeyClient autokeyClient = AutokeyClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyHandles/[KEY_HANDLE]";
            // Make the request
            KeyHandle response = autokeyClient.GetKeyHandle(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyHandleAsync</summary>
        public async Task GetKeyHandleAsync()
        {
            // Snippet: GetKeyHandleAsync(string, CallSettings)
            // Additional: GetKeyHandleAsync(string, CancellationToken)
            // Create client
            AutokeyClient autokeyClient = await AutokeyClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyHandles/[KEY_HANDLE]";
            // Make the request
            KeyHandle response = await autokeyClient.GetKeyHandleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyHandle</summary>
        public void GetKeyHandleResourceNames()
        {
            // Snippet: GetKeyHandle(KeyHandleName, CallSettings)
            // Create client
            AutokeyClient autokeyClient = AutokeyClient.Create();
            // Initialize request argument(s)
            KeyHandleName name = KeyHandleName.FromProjectLocationKeyHandle("[PROJECT]", "[LOCATION]", "[KEY_HANDLE]");
            // Make the request
            KeyHandle response = autokeyClient.GetKeyHandle(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyHandleAsync</summary>
        public async Task GetKeyHandleResourceNamesAsync()
        {
            // Snippet: GetKeyHandleAsync(KeyHandleName, CallSettings)
            // Additional: GetKeyHandleAsync(KeyHandleName, CancellationToken)
            // Create client
            AutokeyClient autokeyClient = await AutokeyClient.CreateAsync();
            // Initialize request argument(s)
            KeyHandleName name = KeyHandleName.FromProjectLocationKeyHandle("[PROJECT]", "[LOCATION]", "[KEY_HANDLE]");
            // Make the request
            KeyHandle response = await autokeyClient.GetKeyHandleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListKeyHandles</summary>
        public void ListKeyHandlesRequestObject()
        {
            // Snippet: ListKeyHandles(ListKeyHandlesRequest, CallSettings)
            // Create client
            AutokeyClient autokeyClient = AutokeyClient.Create();
            // Initialize request argument(s)
            ListKeyHandlesRequest request = new ListKeyHandlesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListKeyHandlesResponse, KeyHandle> response = autokeyClient.ListKeyHandles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyHandle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyHandlesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyHandle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyHandle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyHandle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyHandlesAsync</summary>
        public async Task ListKeyHandlesRequestObjectAsync()
        {
            // Snippet: ListKeyHandlesAsync(ListKeyHandlesRequest, CallSettings)
            // Create client
            AutokeyClient autokeyClient = await AutokeyClient.CreateAsync();
            // Initialize request argument(s)
            ListKeyHandlesRequest request = new ListKeyHandlesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListKeyHandlesResponse, KeyHandle> response = autokeyClient.ListKeyHandlesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyHandle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyHandlesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyHandle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyHandle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyHandle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyHandles</summary>
        public void ListKeyHandles()
        {
            // Snippet: ListKeyHandles(string, string, int?, CallSettings)
            // Create client
            AutokeyClient autokeyClient = AutokeyClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListKeyHandlesResponse, KeyHandle> response = autokeyClient.ListKeyHandles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyHandle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyHandlesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyHandle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyHandle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyHandle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyHandlesAsync</summary>
        public async Task ListKeyHandlesAsync()
        {
            // Snippet: ListKeyHandlesAsync(string, string, int?, CallSettings)
            // Create client
            AutokeyClient autokeyClient = await AutokeyClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListKeyHandlesResponse, KeyHandle> response = autokeyClient.ListKeyHandlesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyHandle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyHandlesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyHandle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyHandle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyHandle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyHandles</summary>
        public void ListKeyHandlesResourceNames()
        {
            // Snippet: ListKeyHandles(LocationName, string, int?, CallSettings)
            // Create client
            AutokeyClient autokeyClient = AutokeyClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListKeyHandlesResponse, KeyHandle> response = autokeyClient.ListKeyHandles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyHandle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyHandlesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyHandle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyHandle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyHandle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyHandlesAsync</summary>
        public async Task ListKeyHandlesResourceNamesAsync()
        {
            // Snippet: ListKeyHandlesAsync(LocationName, string, int?, CallSettings)
            // Create client
            AutokeyClient autokeyClient = await AutokeyClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListKeyHandlesResponse, KeyHandle> response = autokeyClient.ListKeyHandlesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyHandle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyHandlesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyHandle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyHandle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyHandle item in singlePage)
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
