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
    using Google.Cloud.Iam.V1;
    using Google.Cloud.ResourceManager.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFoldersClientSnippets
    {
        /// <summary>Snippet for GetFolder</summary>
        public void GetFolderRequestObject()
        {
            // Snippet: GetFolder(GetFolderRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            GetFolderRequest request = new GetFolderRequest
            {
                FolderName = FolderName.FromFolder("[FOLDER]"),
            };
            // Make the request
            Folder response = foldersClient.GetFolder(request);
            // End snippet
        }

        /// <summary>Snippet for GetFolderAsync</summary>
        public async Task GetFolderRequestObjectAsync()
        {
            // Snippet: GetFolderAsync(GetFolderRequest, CallSettings)
            // Additional: GetFolderAsync(GetFolderRequest, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            GetFolderRequest request = new GetFolderRequest
            {
                FolderName = FolderName.FromFolder("[FOLDER]"),
            };
            // Make the request
            Folder response = await foldersClient.GetFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFolder</summary>
        public void GetFolder()
        {
            // Snippet: GetFolder(string, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]";
            // Make the request
            Folder response = foldersClient.GetFolder(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolderAsync</summary>
        public async Task GetFolderAsync()
        {
            // Snippet: GetFolderAsync(string, CallSettings)
            // Additional: GetFolderAsync(string, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]";
            // Make the request
            Folder response = await foldersClient.GetFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolder</summary>
        public void GetFolderResourceNames()
        {
            // Snippet: GetFolder(FolderName, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            Folder response = foldersClient.GetFolder(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolderAsync</summary>
        public async Task GetFolderResourceNamesAsync()
        {
            // Snippet: GetFolderAsync(FolderName, CallSettings)
            // Additional: GetFolderAsync(FolderName, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            Folder response = await foldersClient.GetFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFolders</summary>
        public void ListFoldersRequestObject()
        {
            // Snippet: ListFolders(ListFoldersRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            ListFoldersRequest request = new ListFoldersRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListFoldersResponse, Folder> response = foldersClient.ListFolders(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Folder item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFoldersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Folder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Folder> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Folder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFoldersAsync</summary>
        public async Task ListFoldersRequestObjectAsync()
        {
            // Snippet: ListFoldersAsync(ListFoldersRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            ListFoldersRequest request = new ListFoldersRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListFoldersResponse, Folder> response = foldersClient.ListFoldersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Folder item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFoldersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Folder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Folder> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Folder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFolders</summary>
        public void ListFolders()
        {
            // Snippet: ListFolders(string, string, int?, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedEnumerable<ListFoldersResponse, Folder> response = foldersClient.ListFolders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Folder item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFoldersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Folder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Folder> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Folder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFoldersAsync</summary>
        public async Task ListFoldersAsync()
        {
            // Snippet: ListFoldersAsync(string, string, int?, CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedAsyncEnumerable<ListFoldersResponse, Folder> response = foldersClient.ListFoldersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Folder item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFoldersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Folder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Folder> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Folder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFolders</summary>
        public void ListFoldersResourceNames()
        {
            // Snippet: ListFolders(IResourceName, string, int?, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListFoldersResponse, Folder> response = foldersClient.ListFolders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Folder item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFoldersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Folder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Folder> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Folder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFoldersAsync</summary>
        public async Task ListFoldersResourceNamesAsync()
        {
            // Snippet: ListFoldersAsync(IResourceName, string, int?, CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListFoldersResponse, Folder> response = foldersClient.ListFoldersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Folder item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFoldersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Folder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Folder> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Folder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFolders</summary>
        public void SearchFoldersRequestObject()
        {
            // Snippet: SearchFolders(SearchFoldersRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            SearchFoldersRequest request = new SearchFoldersRequest { Query = "", };
            // Make the request
            PagedEnumerable<SearchFoldersResponse, Folder> response = foldersClient.SearchFolders(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Folder item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchFoldersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Folder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Folder> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Folder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFoldersAsync</summary>
        public async Task SearchFoldersRequestObjectAsync()
        {
            // Snippet: SearchFoldersAsync(SearchFoldersRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            SearchFoldersRequest request = new SearchFoldersRequest { Query = "", };
            // Make the request
            PagedAsyncEnumerable<SearchFoldersResponse, Folder> response = foldersClient.SearchFoldersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Folder item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchFoldersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Folder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Folder> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Folder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFolders</summary>
        public void SearchFolders()
        {
            // Snippet: SearchFolders(string, string, int?, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string query = "";
            // Make the request
            PagedEnumerable<SearchFoldersResponse, Folder> response = foldersClient.SearchFolders(query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Folder item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchFoldersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Folder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Folder> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Folder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFoldersAsync</summary>
        public async Task SearchFoldersAsync()
        {
            // Snippet: SearchFoldersAsync(string, string, int?, CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchFoldersResponse, Folder> response = foldersClient.SearchFoldersAsync(query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Folder item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchFoldersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Folder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Folder> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Folder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateFolder</summary>
        public void CreateFolderRequestObject()
        {
            // Snippet: CreateFolder(CreateFolderRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            CreateFolderRequest request = new CreateFolderRequest
            {
                Folder = new Folder(),
            };
            // Make the request
            Operation<Folder, CreateFolderMetadata> response = foldersClient.CreateFolder(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, CreateFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, CreateFolderMetadata> retrievedResponse = foldersClient.PollOnceCreateFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFolderAsync</summary>
        public async Task CreateFolderRequestObjectAsync()
        {
            // Snippet: CreateFolderAsync(CreateFolderRequest, CallSettings)
            // Additional: CreateFolderAsync(CreateFolderRequest, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            CreateFolderRequest request = new CreateFolderRequest
            {
                Folder = new Folder(),
            };
            // Make the request
            Operation<Folder, CreateFolderMetadata> response = await foldersClient.CreateFolderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, CreateFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, CreateFolderMetadata> retrievedResponse = await foldersClient.PollOnceCreateFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFolder</summary>
        public void CreateFolder()
        {
            // Snippet: CreateFolder(Folder, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            Folder folder = new Folder();
            // Make the request
            Operation<Folder, CreateFolderMetadata> response = foldersClient.CreateFolder(folder);

            // Poll until the returned long-running operation is complete
            Operation<Folder, CreateFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, CreateFolderMetadata> retrievedResponse = foldersClient.PollOnceCreateFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFolderAsync</summary>
        public async Task CreateFolderAsync()
        {
            // Snippet: CreateFolderAsync(Folder, CallSettings)
            // Additional: CreateFolderAsync(Folder, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            Folder folder = new Folder();
            // Make the request
            Operation<Folder, CreateFolderMetadata> response = await foldersClient.CreateFolderAsync(folder);

            // Poll until the returned long-running operation is complete
            Operation<Folder, CreateFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, CreateFolderMetadata> retrievedResponse = await foldersClient.PollOnceCreateFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFolder</summary>
        public void UpdateFolderRequestObject()
        {
            // Snippet: UpdateFolder(UpdateFolderRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            UpdateFolderRequest request = new UpdateFolderRequest
            {
                Folder = new Folder(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Folder, UpdateFolderMetadata> response = foldersClient.UpdateFolder(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, UpdateFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, UpdateFolderMetadata> retrievedResponse = foldersClient.PollOnceUpdateFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFolderAsync</summary>
        public async Task UpdateFolderRequestObjectAsync()
        {
            // Snippet: UpdateFolderAsync(UpdateFolderRequest, CallSettings)
            // Additional: UpdateFolderAsync(UpdateFolderRequest, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFolderRequest request = new UpdateFolderRequest
            {
                Folder = new Folder(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Folder, UpdateFolderMetadata> response = await foldersClient.UpdateFolderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, UpdateFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, UpdateFolderMetadata> retrievedResponse = await foldersClient.PollOnceUpdateFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFolder</summary>
        public void UpdateFolder()
        {
            // Snippet: UpdateFolder(Folder, FieldMask, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            Folder folder = new Folder();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Folder, UpdateFolderMetadata> response = foldersClient.UpdateFolder(folder, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Folder, UpdateFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, UpdateFolderMetadata> retrievedResponse = foldersClient.PollOnceUpdateFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFolderAsync</summary>
        public async Task UpdateFolderAsync()
        {
            // Snippet: UpdateFolderAsync(Folder, FieldMask, CallSettings)
            // Additional: UpdateFolderAsync(Folder, FieldMask, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            Folder folder = new Folder();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Folder, UpdateFolderMetadata> response = await foldersClient.UpdateFolderAsync(folder, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Folder, UpdateFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, UpdateFolderMetadata> retrievedResponse = await foldersClient.PollOnceUpdateFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveFolder</summary>
        public void MoveFolderRequestObject()
        {
            // Snippet: MoveFolder(MoveFolderRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            MoveFolderRequest request = new MoveFolderRequest
            {
                FolderName = FolderName.FromFolder("[FOLDER]"),
                DestinationParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            Operation<Folder, MoveFolderMetadata> response = foldersClient.MoveFolder(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, MoveFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, MoveFolderMetadata> retrievedResponse = foldersClient.PollOnceMoveFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveFolderAsync</summary>
        public async Task MoveFolderRequestObjectAsync()
        {
            // Snippet: MoveFolderAsync(MoveFolderRequest, CallSettings)
            // Additional: MoveFolderAsync(MoveFolderRequest, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            MoveFolderRequest request = new MoveFolderRequest
            {
                FolderName = FolderName.FromFolder("[FOLDER]"),
                DestinationParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            Operation<Folder, MoveFolderMetadata> response = await foldersClient.MoveFolderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, MoveFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, MoveFolderMetadata> retrievedResponse = await foldersClient.PollOnceMoveFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveFolder</summary>
        public void MoveFolder()
        {
            // Snippet: MoveFolder(string, string, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]";
            string destinationParent = "a/wildcard/resource";
            // Make the request
            Operation<Folder, MoveFolderMetadata> response = foldersClient.MoveFolder(name, destinationParent);

            // Poll until the returned long-running operation is complete
            Operation<Folder, MoveFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, MoveFolderMetadata> retrievedResponse = foldersClient.PollOnceMoveFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveFolderAsync</summary>
        public async Task MoveFolderAsync()
        {
            // Snippet: MoveFolderAsync(string, string, CallSettings)
            // Additional: MoveFolderAsync(string, string, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]";
            string destinationParent = "a/wildcard/resource";
            // Make the request
            Operation<Folder, MoveFolderMetadata> response = await foldersClient.MoveFolderAsync(name, destinationParent);

            // Poll until the returned long-running operation is complete
            Operation<Folder, MoveFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, MoveFolderMetadata> retrievedResponse = await foldersClient.PollOnceMoveFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveFolder</summary>
        public void MoveFolderResourceNames()
        {
            // Snippet: MoveFolder(FolderName, IResourceName, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            IResourceName destinationParent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Operation<Folder, MoveFolderMetadata> response = foldersClient.MoveFolder(name, destinationParent);

            // Poll until the returned long-running operation is complete
            Operation<Folder, MoveFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, MoveFolderMetadata> retrievedResponse = foldersClient.PollOnceMoveFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveFolderAsync</summary>
        public async Task MoveFolderResourceNamesAsync()
        {
            // Snippet: MoveFolderAsync(FolderName, IResourceName, CallSettings)
            // Additional: MoveFolderAsync(FolderName, IResourceName, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            IResourceName destinationParent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Operation<Folder, MoveFolderMetadata> response = await foldersClient.MoveFolderAsync(name, destinationParent);

            // Poll until the returned long-running operation is complete
            Operation<Folder, MoveFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, MoveFolderMetadata> retrievedResponse = await foldersClient.PollOnceMoveFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolderRequestObject()
        {
            // Snippet: DeleteFolder(DeleteFolderRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            DeleteFolderRequest request = new DeleteFolderRequest
            {
                FolderName = FolderName.FromFolder("[FOLDER]"),
            };
            // Make the request
            Operation<Folder, DeleteFolderMetadata> response = foldersClient.DeleteFolder(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, DeleteFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, DeleteFolderMetadata> retrievedResponse = foldersClient.PollOnceDeleteFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderRequestObjectAsync()
        {
            // Snippet: DeleteFolderAsync(DeleteFolderRequest, CallSettings)
            // Additional: DeleteFolderAsync(DeleteFolderRequest, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFolderRequest request = new DeleteFolderRequest
            {
                FolderName = FolderName.FromFolder("[FOLDER]"),
            };
            // Make the request
            Operation<Folder, DeleteFolderMetadata> response = await foldersClient.DeleteFolderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, DeleteFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, DeleteFolderMetadata> retrievedResponse = await foldersClient.PollOnceDeleteFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolder()
        {
            // Snippet: DeleteFolder(string, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]";
            // Make the request
            Operation<Folder, DeleteFolderMetadata> response = foldersClient.DeleteFolder(name);

            // Poll until the returned long-running operation is complete
            Operation<Folder, DeleteFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, DeleteFolderMetadata> retrievedResponse = foldersClient.PollOnceDeleteFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderAsync()
        {
            // Snippet: DeleteFolderAsync(string, CallSettings)
            // Additional: DeleteFolderAsync(string, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]";
            // Make the request
            Operation<Folder, DeleteFolderMetadata> response = await foldersClient.DeleteFolderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Folder, DeleteFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, DeleteFolderMetadata> retrievedResponse = await foldersClient.PollOnceDeleteFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolderResourceNames()
        {
            // Snippet: DeleteFolder(FolderName, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            Operation<Folder, DeleteFolderMetadata> response = foldersClient.DeleteFolder(name);

            // Poll until the returned long-running operation is complete
            Operation<Folder, DeleteFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, DeleteFolderMetadata> retrievedResponse = foldersClient.PollOnceDeleteFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderResourceNamesAsync()
        {
            // Snippet: DeleteFolderAsync(FolderName, CallSettings)
            // Additional: DeleteFolderAsync(FolderName, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            Operation<Folder, DeleteFolderMetadata> response = await foldersClient.DeleteFolderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Folder, DeleteFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, DeleteFolderMetadata> retrievedResponse = await foldersClient.PollOnceDeleteFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteFolder</summary>
        public void UndeleteFolderRequestObject()
        {
            // Snippet: UndeleteFolder(UndeleteFolderRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            UndeleteFolderRequest request = new UndeleteFolderRequest
            {
                FolderName = FolderName.FromFolder("[FOLDER]"),
            };
            // Make the request
            Operation<Folder, UndeleteFolderMetadata> response = foldersClient.UndeleteFolder(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, UndeleteFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, UndeleteFolderMetadata> retrievedResponse = foldersClient.PollOnceUndeleteFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteFolderAsync</summary>
        public async Task UndeleteFolderRequestObjectAsync()
        {
            // Snippet: UndeleteFolderAsync(UndeleteFolderRequest, CallSettings)
            // Additional: UndeleteFolderAsync(UndeleteFolderRequest, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteFolderRequest request = new UndeleteFolderRequest
            {
                FolderName = FolderName.FromFolder("[FOLDER]"),
            };
            // Make the request
            Operation<Folder, UndeleteFolderMetadata> response = await foldersClient.UndeleteFolderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, UndeleteFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, UndeleteFolderMetadata> retrievedResponse = await foldersClient.PollOnceUndeleteFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteFolder</summary>
        public void UndeleteFolder()
        {
            // Snippet: UndeleteFolder(string, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]";
            // Make the request
            Operation<Folder, UndeleteFolderMetadata> response = foldersClient.UndeleteFolder(name);

            // Poll until the returned long-running operation is complete
            Operation<Folder, UndeleteFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, UndeleteFolderMetadata> retrievedResponse = foldersClient.PollOnceUndeleteFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteFolderAsync</summary>
        public async Task UndeleteFolderAsync()
        {
            // Snippet: UndeleteFolderAsync(string, CallSettings)
            // Additional: UndeleteFolderAsync(string, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]";
            // Make the request
            Operation<Folder, UndeleteFolderMetadata> response = await foldersClient.UndeleteFolderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Folder, UndeleteFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, UndeleteFolderMetadata> retrievedResponse = await foldersClient.PollOnceUndeleteFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteFolder</summary>
        public void UndeleteFolderResourceNames()
        {
            // Snippet: UndeleteFolder(FolderName, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            Operation<Folder, UndeleteFolderMetadata> response = foldersClient.UndeleteFolder(name);

            // Poll until the returned long-running operation is complete
            Operation<Folder, UndeleteFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, UndeleteFolderMetadata> retrievedResponse = foldersClient.PollOnceUndeleteFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteFolderAsync</summary>
        public async Task UndeleteFolderResourceNamesAsync()
        {
            // Snippet: UndeleteFolderAsync(FolderName, CallSettings)
            // Additional: UndeleteFolderAsync(FolderName, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            Operation<Folder, UndeleteFolderMetadata> response = await foldersClient.UndeleteFolderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Folder, UndeleteFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, UndeleteFolderMetadata> retrievedResponse = await foldersClient.PollOnceUndeleteFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = foldersClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await foldersClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = foldersClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await foldersClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = foldersClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await foldersClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = foldersClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await foldersClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = foldersClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await foldersClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = foldersClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await foldersClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = foldersClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await foldersClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = foldersClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await foldersClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = foldersClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await foldersClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }
    }
}
