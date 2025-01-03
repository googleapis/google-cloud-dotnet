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
    using Google.Cloud.ApiKeys.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedApiKeysClientSnippets
    {
        /// <summary>Snippet for CreateKey</summary>
        public void CreateKeyRequestObject()
        {
            // Snippet: CreateKey(CreateKeyRequest, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            CreateKeyRequest request = new CreateKeyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Key = new Key(),
                KeyId = "",
            };
            // Make the request
            Operation<Key, Empty> response = apiKeysClient.CreateKey(request);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = apiKeysClient.PollOnceCreateKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKeyAsync</summary>
        public async Task CreateKeyRequestObjectAsync()
        {
            // Snippet: CreateKeyAsync(CreateKeyRequest, CallSettings)
            // Additional: CreateKeyAsync(CreateKeyRequest, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            CreateKeyRequest request = new CreateKeyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Key = new Key(),
                KeyId = "",
            };
            // Make the request
            Operation<Key, Empty> response = await apiKeysClient.CreateKeyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = await apiKeysClient.PollOnceCreateKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKey</summary>
        public void CreateKey()
        {
            // Snippet: CreateKey(string, Key, string, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Key key = new Key();
            string keyId = "";
            // Make the request
            Operation<Key, Empty> response = apiKeysClient.CreateKey(parent, key, keyId);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = apiKeysClient.PollOnceCreateKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKeyAsync</summary>
        public async Task CreateKeyAsync()
        {
            // Snippet: CreateKeyAsync(string, Key, string, CallSettings)
            // Additional: CreateKeyAsync(string, Key, string, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Key key = new Key();
            string keyId = "";
            // Make the request
            Operation<Key, Empty> response = await apiKeysClient.CreateKeyAsync(parent, key, keyId);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = await apiKeysClient.PollOnceCreateKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKey</summary>
        public void CreateKeyResourceNames()
        {
            // Snippet: CreateKey(LocationName, Key, string, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Key key = new Key();
            string keyId = "";
            // Make the request
            Operation<Key, Empty> response = apiKeysClient.CreateKey(parent, key, keyId);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = apiKeysClient.PollOnceCreateKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKeyAsync</summary>
        public async Task CreateKeyResourceNamesAsync()
        {
            // Snippet: CreateKeyAsync(LocationName, Key, string, CallSettings)
            // Additional: CreateKeyAsync(LocationName, Key, string, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Key key = new Key();
            string keyId = "";
            // Make the request
            Operation<Key, Empty> response = await apiKeysClient.CreateKeyAsync(parent, key, keyId);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = await apiKeysClient.PollOnceCreateKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListKeys</summary>
        public void ListKeysRequestObject()
        {
            // Snippet: ListKeys(ListKeysRequest, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            ListKeysRequest request = new ListKeysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListKeysResponse, Key> response = apiKeysClient.ListKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Key item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Key item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Key> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Key item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeysAsync</summary>
        public async Task ListKeysRequestObjectAsync()
        {
            // Snippet: ListKeysAsync(ListKeysRequest, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            ListKeysRequest request = new ListKeysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListKeysResponse, Key> response = apiKeysClient.ListKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Key item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Key item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Key> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Key item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeys</summary>
        public void ListKeys()
        {
            // Snippet: ListKeys(string, string, int?, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListKeysResponse, Key> response = apiKeysClient.ListKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Key item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Key item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Key> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Key item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeysAsync</summary>
        public async Task ListKeysAsync()
        {
            // Snippet: ListKeysAsync(string, string, int?, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListKeysResponse, Key> response = apiKeysClient.ListKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Key item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Key item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Key> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Key item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeys</summary>
        public void ListKeysResourceNames()
        {
            // Snippet: ListKeys(LocationName, string, int?, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListKeysResponse, Key> response = apiKeysClient.ListKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Key item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Key item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Key> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Key item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeysAsync</summary>
        public async Task ListKeysResourceNamesAsync()
        {
            // Snippet: ListKeysAsync(LocationName, string, int?, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListKeysResponse, Key> response = apiKeysClient.ListKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Key item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Key item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Key> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Key item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetKey</summary>
        public void GetKeyRequestObject()
        {
            // Snippet: GetKey(GetKeyRequest, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            // Make the request
            Key response = apiKeysClient.GetKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyAsync</summary>
        public async Task GetKeyRequestObjectAsync()
        {
            // Snippet: GetKeyAsync(GetKeyRequest, CallSettings)
            // Additional: GetKeyAsync(GetKeyRequest, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            // Make the request
            Key response = await apiKeysClient.GetKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKey</summary>
        public void GetKey()
        {
            // Snippet: GetKey(string, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keys/[KEY]";
            // Make the request
            Key response = apiKeysClient.GetKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyAsync</summary>
        public async Task GetKeyAsync()
        {
            // Snippet: GetKeyAsync(string, CallSettings)
            // Additional: GetKeyAsync(string, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keys/[KEY]";
            // Make the request
            Key response = await apiKeysClient.GetKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetKey</summary>
        public void GetKeyResourceNames()
        {
            // Snippet: GetKey(KeyName, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]");
            // Make the request
            Key response = apiKeysClient.GetKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyAsync</summary>
        public async Task GetKeyResourceNamesAsync()
        {
            // Snippet: GetKeyAsync(KeyName, CallSettings)
            // Additional: GetKeyAsync(KeyName, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]");
            // Make the request
            Key response = await apiKeysClient.GetKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyString</summary>
        public void GetKeyStringRequestObject()
        {
            // Snippet: GetKeyString(GetKeyStringRequest, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            GetKeyStringRequest request = new GetKeyStringRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            // Make the request
            GetKeyStringResponse response = apiKeysClient.GetKeyString(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyStringAsync</summary>
        public async Task GetKeyStringRequestObjectAsync()
        {
            // Snippet: GetKeyStringAsync(GetKeyStringRequest, CallSettings)
            // Additional: GetKeyStringAsync(GetKeyStringRequest, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            GetKeyStringRequest request = new GetKeyStringRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            // Make the request
            GetKeyStringResponse response = await apiKeysClient.GetKeyStringAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyString</summary>
        public void GetKeyString()
        {
            // Snippet: GetKeyString(string, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keys/[KEY]";
            // Make the request
            GetKeyStringResponse response = apiKeysClient.GetKeyString(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyStringAsync</summary>
        public async Task GetKeyStringAsync()
        {
            // Snippet: GetKeyStringAsync(string, CallSettings)
            // Additional: GetKeyStringAsync(string, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keys/[KEY]";
            // Make the request
            GetKeyStringResponse response = await apiKeysClient.GetKeyStringAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyString</summary>
        public void GetKeyStringResourceNames()
        {
            // Snippet: GetKeyString(KeyName, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]");
            // Make the request
            GetKeyStringResponse response = apiKeysClient.GetKeyString(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyStringAsync</summary>
        public async Task GetKeyStringResourceNamesAsync()
        {
            // Snippet: GetKeyStringAsync(KeyName, CallSettings)
            // Additional: GetKeyStringAsync(KeyName, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]");
            // Make the request
            GetKeyStringResponse response = await apiKeysClient.GetKeyStringAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateKey</summary>
        public void UpdateKeyRequestObject()
        {
            // Snippet: UpdateKey(UpdateKeyRequest, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            UpdateKeyRequest request = new UpdateKeyRequest
            {
                Key = new Key(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Key, Empty> response = apiKeysClient.UpdateKey(request);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = apiKeysClient.PollOnceUpdateKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateKeyAsync</summary>
        public async Task UpdateKeyRequestObjectAsync()
        {
            // Snippet: UpdateKeyAsync(UpdateKeyRequest, CallSettings)
            // Additional: UpdateKeyAsync(UpdateKeyRequest, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            UpdateKeyRequest request = new UpdateKeyRequest
            {
                Key = new Key(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Key, Empty> response = await apiKeysClient.UpdateKeyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = await apiKeysClient.PollOnceUpdateKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateKey</summary>
        public void UpdateKey()
        {
            // Snippet: UpdateKey(Key, FieldMask, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            Key key = new Key();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Key, Empty> response = apiKeysClient.UpdateKey(key, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = apiKeysClient.PollOnceUpdateKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateKeyAsync</summary>
        public async Task UpdateKeyAsync()
        {
            // Snippet: UpdateKeyAsync(Key, FieldMask, CallSettings)
            // Additional: UpdateKeyAsync(Key, FieldMask, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            Key key = new Key();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Key, Empty> response = await apiKeysClient.UpdateKeyAsync(key, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = await apiKeysClient.PollOnceUpdateKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteKey</summary>
        public void DeleteKeyRequestObject()
        {
            // Snippet: DeleteKey(DeleteKeyRequest, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            DeleteKeyRequest request = new DeleteKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
                Etag = "",
            };
            // Make the request
            Operation<Key, Empty> response = apiKeysClient.DeleteKey(request);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = apiKeysClient.PollOnceDeleteKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyAsync</summary>
        public async Task DeleteKeyRequestObjectAsync()
        {
            // Snippet: DeleteKeyAsync(DeleteKeyRequest, CallSettings)
            // Additional: DeleteKeyAsync(DeleteKeyRequest, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            DeleteKeyRequest request = new DeleteKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
                Etag = "",
            };
            // Make the request
            Operation<Key, Empty> response = await apiKeysClient.DeleteKeyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = await apiKeysClient.PollOnceDeleteKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteKey</summary>
        public void DeleteKey()
        {
            // Snippet: DeleteKey(string, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keys/[KEY]";
            // Make the request
            Operation<Key, Empty> response = apiKeysClient.DeleteKey(name);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = apiKeysClient.PollOnceDeleteKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyAsync</summary>
        public async Task DeleteKeyAsync()
        {
            // Snippet: DeleteKeyAsync(string, CallSettings)
            // Additional: DeleteKeyAsync(string, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keys/[KEY]";
            // Make the request
            Operation<Key, Empty> response = await apiKeysClient.DeleteKeyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = await apiKeysClient.PollOnceDeleteKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteKey</summary>
        public void DeleteKeyResourceNames()
        {
            // Snippet: DeleteKey(KeyName, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]");
            // Make the request
            Operation<Key, Empty> response = apiKeysClient.DeleteKey(name);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = apiKeysClient.PollOnceDeleteKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyAsync</summary>
        public async Task DeleteKeyResourceNamesAsync()
        {
            // Snippet: DeleteKeyAsync(KeyName, CallSettings)
            // Additional: DeleteKeyAsync(KeyName, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]");
            // Make the request
            Operation<Key, Empty> response = await apiKeysClient.DeleteKeyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = await apiKeysClient.PollOnceDeleteKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteKey</summary>
        public void UndeleteKeyRequestObject()
        {
            // Snippet: UndeleteKey(UndeleteKeyRequest, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            UndeleteKeyRequest request = new UndeleteKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            // Make the request
            Operation<Key, Empty> response = apiKeysClient.UndeleteKey(request);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = apiKeysClient.PollOnceUndeleteKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteKeyAsync</summary>
        public async Task UndeleteKeyRequestObjectAsync()
        {
            // Snippet: UndeleteKeyAsync(UndeleteKeyRequest, CallSettings)
            // Additional: UndeleteKeyAsync(UndeleteKeyRequest, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteKeyRequest request = new UndeleteKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            // Make the request
            Operation<Key, Empty> response = await apiKeysClient.UndeleteKeyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = await apiKeysClient.PollOnceUndeleteKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LookupKey</summary>
        public void LookupKeyRequestObject()
        {
            // Snippet: LookupKey(LookupKeyRequest, CallSettings)
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            LookupKeyRequest request = new LookupKeyRequest { KeyString = "", };
            // Make the request
            LookupKeyResponse response = apiKeysClient.LookupKey(request);
            // End snippet
        }

        /// <summary>Snippet for LookupKeyAsync</summary>
        public async Task LookupKeyRequestObjectAsync()
        {
            // Snippet: LookupKeyAsync(LookupKeyRequest, CallSettings)
            // Additional: LookupKeyAsync(LookupKeyRequest, CancellationToken)
            // Create client
            ApiKeysClient apiKeysClient = await ApiKeysClient.CreateAsync();
            // Initialize request argument(s)
            LookupKeyRequest request = new LookupKeyRequest { KeyString = "", };
            // Make the request
            LookupKeyResponse response = await apiKeysClient.LookupKeyAsync(request);
            // End snippet
        }
    }
}
