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
    using Google.Cloud.Storage.Control.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedStorageControlClientSnippets
    {
        /// <summary>Snippet for CreateFolder</summary>
        public void CreateFolderRequestObject()
        {
            // Snippet: CreateFolder(CreateFolderRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            CreateFolderRequest request = new CreateFolderRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Folder = new Folder(),
                FolderId = "",
                Recursive = false,
            };
            // Make the request
            Folder response = storageControlClient.CreateFolder(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFolderAsync</summary>
        public async Task CreateFolderRequestObjectAsync()
        {
            // Snippet: CreateFolderAsync(CreateFolderRequest, CallSettings)
            // Additional: CreateFolderAsync(CreateFolderRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            CreateFolderRequest request = new CreateFolderRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Folder = new Folder(),
                FolderId = "",
                Recursive = false,
            };
            // Make the request
            Folder response = await storageControlClient.CreateFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFolder</summary>
        public void CreateFolder()
        {
            // Snippet: CreateFolder(string, Folder, string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            Folder folder = new Folder();
            string folderId = "";
            // Make the request
            Folder response = storageControlClient.CreateFolder(parent, folder, folderId);
            // End snippet
        }

        /// <summary>Snippet for CreateFolderAsync</summary>
        public async Task CreateFolderAsync()
        {
            // Snippet: CreateFolderAsync(string, Folder, string, CallSettings)
            // Additional: CreateFolderAsync(string, Folder, string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            Folder folder = new Folder();
            string folderId = "";
            // Make the request
            Folder response = await storageControlClient.CreateFolderAsync(parent, folder, folderId);
            // End snippet
        }

        /// <summary>Snippet for CreateFolder</summary>
        public void CreateFolderResourceNames()
        {
            // Snippet: CreateFolder(BucketName, Folder, string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            Folder folder = new Folder();
            string folderId = "";
            // Make the request
            Folder response = storageControlClient.CreateFolder(parent, folder, folderId);
            // End snippet
        }

        /// <summary>Snippet for CreateFolderAsync</summary>
        public async Task CreateFolderResourceNamesAsync()
        {
            // Snippet: CreateFolderAsync(BucketName, Folder, string, CallSettings)
            // Additional: CreateFolderAsync(BucketName, Folder, string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            Folder folder = new Folder();
            string folderId = "";
            // Make the request
            Folder response = await storageControlClient.CreateFolderAsync(parent, folder, folderId);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolderRequestObject()
        {
            // Snippet: DeleteFolder(DeleteFolderRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            DeleteFolderRequest request = new DeleteFolderRequest
            {
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                FolderName = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]"),
            };
            // Make the request
            storageControlClient.DeleteFolder(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderRequestObjectAsync()
        {
            // Snippet: DeleteFolderAsync(DeleteFolderRequest, CallSettings)
            // Additional: DeleteFolderAsync(DeleteFolderRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFolderRequest request = new DeleteFolderRequest
            {
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                FolderName = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]"),
            };
            // Make the request
            await storageControlClient.DeleteFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolder()
        {
            // Snippet: DeleteFolder(string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/folders/[FOLDER]";
            // Make the request
            storageControlClient.DeleteFolder(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderAsync()
        {
            // Snippet: DeleteFolderAsync(string, CallSettings)
            // Additional: DeleteFolderAsync(string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/folders/[FOLDER]";
            // Make the request
            await storageControlClient.DeleteFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolderResourceNames()
        {
            // Snippet: DeleteFolder(FolderName, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]");
            // Make the request
            storageControlClient.DeleteFolder(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderResourceNamesAsync()
        {
            // Snippet: DeleteFolderAsync(FolderName, CallSettings)
            // Additional: DeleteFolderAsync(FolderName, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]");
            // Make the request
            await storageControlClient.DeleteFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolder</summary>
        public void GetFolderRequestObject()
        {
            // Snippet: GetFolder(GetFolderRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            GetFolderRequest request = new GetFolderRequest
            {
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                FolderName = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]"),
            };
            // Make the request
            Folder response = storageControlClient.GetFolder(request);
            // End snippet
        }

        /// <summary>Snippet for GetFolderAsync</summary>
        public async Task GetFolderRequestObjectAsync()
        {
            // Snippet: GetFolderAsync(GetFolderRequest, CallSettings)
            // Additional: GetFolderAsync(GetFolderRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            GetFolderRequest request = new GetFolderRequest
            {
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                FolderName = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]"),
            };
            // Make the request
            Folder response = await storageControlClient.GetFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFolder</summary>
        public void GetFolder()
        {
            // Snippet: GetFolder(string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/folders/[FOLDER]";
            // Make the request
            Folder response = storageControlClient.GetFolder(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolderAsync</summary>
        public async Task GetFolderAsync()
        {
            // Snippet: GetFolderAsync(string, CallSettings)
            // Additional: GetFolderAsync(string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/folders/[FOLDER]";
            // Make the request
            Folder response = await storageControlClient.GetFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolder</summary>
        public void GetFolderResourceNames()
        {
            // Snippet: GetFolder(FolderName, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]");
            // Make the request
            Folder response = storageControlClient.GetFolder(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolderAsync</summary>
        public async Task GetFolderResourceNamesAsync()
        {
            // Snippet: GetFolderAsync(FolderName, CallSettings)
            // Additional: GetFolderAsync(FolderName, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]");
            // Make the request
            Folder response = await storageControlClient.GetFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFolders</summary>
        public void ListFoldersRequestObject()
        {
            // Snippet: ListFolders(ListFoldersRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            ListFoldersRequest request = new ListFoldersRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Prefix = "",
                LexicographicStart = "",
                LexicographicEnd = "",
                Delimiter = "",
                RequestId = "",
            };
            // Make the request
            PagedEnumerable<ListFoldersResponse, Folder> response = storageControlClient.ListFolders(request);

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
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            ListFoldersRequest request = new ListFoldersRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Prefix = "",
                LexicographicStart = "",
                LexicographicEnd = "",
                Delimiter = "",
                RequestId = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFoldersResponse, Folder> response = storageControlClient.ListFoldersAsync(request);

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
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedEnumerable<ListFoldersResponse, Folder> response = storageControlClient.ListFolders(parent);

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
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedAsyncEnumerable<ListFoldersResponse, Folder> response = storageControlClient.ListFoldersAsync(parent);

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
            // Snippet: ListFolders(BucketName, string, int?, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedEnumerable<ListFoldersResponse, Folder> response = storageControlClient.ListFolders(parent);

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
            // Snippet: ListFoldersAsync(BucketName, string, int?, CallSettings)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedAsyncEnumerable<ListFoldersResponse, Folder> response = storageControlClient.ListFoldersAsync(parent);

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

        /// <summary>Snippet for RenameFolder</summary>
        public void RenameFolderRequestObject()
        {
            // Snippet: RenameFolder(RenameFolderRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            RenameFolderRequest request = new RenameFolderRequest
            {
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                FolderName = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]"),
                DestinationFolderId = "",
            };
            // Make the request
            Operation<Folder, RenameFolderMetadata> response = storageControlClient.RenameFolder(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, RenameFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, RenameFolderMetadata> retrievedResponse = storageControlClient.PollOnceRenameFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RenameFolderAsync</summary>
        public async Task RenameFolderRequestObjectAsync()
        {
            // Snippet: RenameFolderAsync(RenameFolderRequest, CallSettings)
            // Additional: RenameFolderAsync(RenameFolderRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            RenameFolderRequest request = new RenameFolderRequest
            {
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                FolderName = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]"),
                DestinationFolderId = "",
            };
            // Make the request
            Operation<Folder, RenameFolderMetadata> response = await storageControlClient.RenameFolderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Folder, RenameFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, RenameFolderMetadata> retrievedResponse = await storageControlClient.PollOnceRenameFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RenameFolder</summary>
        public void RenameFolder()
        {
            // Snippet: RenameFolder(string, string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/folders/[FOLDER]";
            string destinationFolderId = "";
            // Make the request
            Operation<Folder, RenameFolderMetadata> response = storageControlClient.RenameFolder(name, destinationFolderId);

            // Poll until the returned long-running operation is complete
            Operation<Folder, RenameFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, RenameFolderMetadata> retrievedResponse = storageControlClient.PollOnceRenameFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RenameFolderAsync</summary>
        public async Task RenameFolderAsync()
        {
            // Snippet: RenameFolderAsync(string, string, CallSettings)
            // Additional: RenameFolderAsync(string, string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/folders/[FOLDER]";
            string destinationFolderId = "";
            // Make the request
            Operation<Folder, RenameFolderMetadata> response = await storageControlClient.RenameFolderAsync(name, destinationFolderId);

            // Poll until the returned long-running operation is complete
            Operation<Folder, RenameFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, RenameFolderMetadata> retrievedResponse = await storageControlClient.PollOnceRenameFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RenameFolder</summary>
        public void RenameFolderResourceNames()
        {
            // Snippet: RenameFolder(FolderName, string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]");
            string destinationFolderId = "";
            // Make the request
            Operation<Folder, RenameFolderMetadata> response = storageControlClient.RenameFolder(name, destinationFolderId);

            // Poll until the returned long-running operation is complete
            Operation<Folder, RenameFolderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, RenameFolderMetadata> retrievedResponse = storageControlClient.PollOnceRenameFolder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RenameFolderAsync</summary>
        public async Task RenameFolderResourceNamesAsync()
        {
            // Snippet: RenameFolderAsync(FolderName, string, CallSettings)
            // Additional: RenameFolderAsync(FolderName, string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromProjectBucketFolder("[PROJECT]", "[BUCKET]", "[FOLDER]");
            string destinationFolderId = "";
            // Make the request
            Operation<Folder, RenameFolderMetadata> response = await storageControlClient.RenameFolderAsync(name, destinationFolderId);

            // Poll until the returned long-running operation is complete
            Operation<Folder, RenameFolderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Folder result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Folder, RenameFolderMetadata> retrievedResponse = await storageControlClient.PollOnceRenameFolderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Folder retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetStorageLayout</summary>
        public void GetStorageLayoutRequestObject()
        {
            // Snippet: GetStorageLayout(GetStorageLayoutRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            GetStorageLayoutRequest request = new GetStorageLayoutRequest
            {
                StorageLayoutName = StorageLayoutName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Prefix = "",
            };
            // Make the request
            StorageLayout response = storageControlClient.GetStorageLayout(request);
            // End snippet
        }

        /// <summary>Snippet for GetStorageLayoutAsync</summary>
        public async Task GetStorageLayoutRequestObjectAsync()
        {
            // Snippet: GetStorageLayoutAsync(GetStorageLayoutRequest, CallSettings)
            // Additional: GetStorageLayoutAsync(GetStorageLayoutRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            GetStorageLayoutRequest request = new GetStorageLayoutRequest
            {
                StorageLayoutName = StorageLayoutName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Prefix = "",
            };
            // Make the request
            StorageLayout response = await storageControlClient.GetStorageLayoutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStorageLayout</summary>
        public void GetStorageLayout()
        {
            // Snippet: GetStorageLayout(string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/storageLayout";
            // Make the request
            StorageLayout response = storageControlClient.GetStorageLayout(name);
            // End snippet
        }

        /// <summary>Snippet for GetStorageLayoutAsync</summary>
        public async Task GetStorageLayoutAsync()
        {
            // Snippet: GetStorageLayoutAsync(string, CallSettings)
            // Additional: GetStorageLayoutAsync(string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/storageLayout";
            // Make the request
            StorageLayout response = await storageControlClient.GetStorageLayoutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStorageLayout</summary>
        public void GetStorageLayoutResourceNames()
        {
            // Snippet: GetStorageLayout(StorageLayoutName, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            StorageLayoutName name = StorageLayoutName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            StorageLayout response = storageControlClient.GetStorageLayout(name);
            // End snippet
        }

        /// <summary>Snippet for GetStorageLayoutAsync</summary>
        public async Task GetStorageLayoutResourceNamesAsync()
        {
            // Snippet: GetStorageLayoutAsync(StorageLayoutName, CallSettings)
            // Additional: GetStorageLayoutAsync(StorageLayoutName, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            StorageLayoutName name = StorageLayoutName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            StorageLayout response = await storageControlClient.GetStorageLayoutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateManagedFolder</summary>
        public void CreateManagedFolderRequestObject()
        {
            // Snippet: CreateManagedFolder(CreateManagedFolderRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            CreateManagedFolderRequest request = new CreateManagedFolderRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                ManagedFolder = new ManagedFolder(),
                ManagedFolderId = "",
            };
            // Make the request
            ManagedFolder response = storageControlClient.CreateManagedFolder(request);
            // End snippet
        }

        /// <summary>Snippet for CreateManagedFolderAsync</summary>
        public async Task CreateManagedFolderRequestObjectAsync()
        {
            // Snippet: CreateManagedFolderAsync(CreateManagedFolderRequest, CallSettings)
            // Additional: CreateManagedFolderAsync(CreateManagedFolderRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            CreateManagedFolderRequest request = new CreateManagedFolderRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                ManagedFolder = new ManagedFolder(),
                ManagedFolderId = "",
            };
            // Make the request
            ManagedFolder response = await storageControlClient.CreateManagedFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateManagedFolder</summary>
        public void CreateManagedFolder()
        {
            // Snippet: CreateManagedFolder(string, ManagedFolder, string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            ManagedFolder managedFolder = new ManagedFolder();
            string managedFolderId = "";
            // Make the request
            ManagedFolder response = storageControlClient.CreateManagedFolder(parent, managedFolder, managedFolderId);
            // End snippet
        }

        /// <summary>Snippet for CreateManagedFolderAsync</summary>
        public async Task CreateManagedFolderAsync()
        {
            // Snippet: CreateManagedFolderAsync(string, ManagedFolder, string, CallSettings)
            // Additional: CreateManagedFolderAsync(string, ManagedFolder, string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            ManagedFolder managedFolder = new ManagedFolder();
            string managedFolderId = "";
            // Make the request
            ManagedFolder response = await storageControlClient.CreateManagedFolderAsync(parent, managedFolder, managedFolderId);
            // End snippet
        }

        /// <summary>Snippet for CreateManagedFolder</summary>
        public void CreateManagedFolderResourceNames()
        {
            // Snippet: CreateManagedFolder(BucketName, ManagedFolder, string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            ManagedFolder managedFolder = new ManagedFolder();
            string managedFolderId = "";
            // Make the request
            ManagedFolder response = storageControlClient.CreateManagedFolder(parent, managedFolder, managedFolderId);
            // End snippet
        }

        /// <summary>Snippet for CreateManagedFolderAsync</summary>
        public async Task CreateManagedFolderResourceNamesAsync()
        {
            // Snippet: CreateManagedFolderAsync(BucketName, ManagedFolder, string, CallSettings)
            // Additional: CreateManagedFolderAsync(BucketName, ManagedFolder, string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            ManagedFolder managedFolder = new ManagedFolder();
            string managedFolderId = "";
            // Make the request
            ManagedFolder response = await storageControlClient.CreateManagedFolderAsync(parent, managedFolder, managedFolderId);
            // End snippet
        }

        /// <summary>Snippet for DeleteManagedFolder</summary>
        public void DeleteManagedFolderRequestObject()
        {
            // Snippet: DeleteManagedFolder(DeleteManagedFolderRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            DeleteManagedFolderRequest request = new DeleteManagedFolderRequest
            {
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                AllowNonEmpty = false,
                ManagedFolderName = ManagedFolderName.FromProjectBucketManagedFolder("[PROJECT]", "[BUCKET]", "[MANAGED_FOLDER]"),
            };
            // Make the request
            storageControlClient.DeleteManagedFolder(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteManagedFolderAsync</summary>
        public async Task DeleteManagedFolderRequestObjectAsync()
        {
            // Snippet: DeleteManagedFolderAsync(DeleteManagedFolderRequest, CallSettings)
            // Additional: DeleteManagedFolderAsync(DeleteManagedFolderRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            DeleteManagedFolderRequest request = new DeleteManagedFolderRequest
            {
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                AllowNonEmpty = false,
                ManagedFolderName = ManagedFolderName.FromProjectBucketManagedFolder("[PROJECT]", "[BUCKET]", "[MANAGED_FOLDER]"),
            };
            // Make the request
            await storageControlClient.DeleteManagedFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteManagedFolder</summary>
        public void DeleteManagedFolder()
        {
            // Snippet: DeleteManagedFolder(string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/managedFolders/[MANAGED_FOLDER]";
            // Make the request
            storageControlClient.DeleteManagedFolder(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteManagedFolderAsync</summary>
        public async Task DeleteManagedFolderAsync()
        {
            // Snippet: DeleteManagedFolderAsync(string, CallSettings)
            // Additional: DeleteManagedFolderAsync(string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/managedFolders/[MANAGED_FOLDER]";
            // Make the request
            await storageControlClient.DeleteManagedFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteManagedFolder</summary>
        public void DeleteManagedFolderResourceNames()
        {
            // Snippet: DeleteManagedFolder(ManagedFolderName, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            ManagedFolderName name = ManagedFolderName.FromProjectBucketManagedFolder("[PROJECT]", "[BUCKET]", "[MANAGED_FOLDER]");
            // Make the request
            storageControlClient.DeleteManagedFolder(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteManagedFolderAsync</summary>
        public async Task DeleteManagedFolderResourceNamesAsync()
        {
            // Snippet: DeleteManagedFolderAsync(ManagedFolderName, CallSettings)
            // Additional: DeleteManagedFolderAsync(ManagedFolderName, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            ManagedFolderName name = ManagedFolderName.FromProjectBucketManagedFolder("[PROJECT]", "[BUCKET]", "[MANAGED_FOLDER]");
            // Make the request
            await storageControlClient.DeleteManagedFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetManagedFolder</summary>
        public void GetManagedFolderRequestObject()
        {
            // Snippet: GetManagedFolder(GetManagedFolderRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            GetManagedFolderRequest request = new GetManagedFolderRequest
            {
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                ManagedFolderName = ManagedFolderName.FromProjectBucketManagedFolder("[PROJECT]", "[BUCKET]", "[MANAGED_FOLDER]"),
            };
            // Make the request
            ManagedFolder response = storageControlClient.GetManagedFolder(request);
            // End snippet
        }

        /// <summary>Snippet for GetManagedFolderAsync</summary>
        public async Task GetManagedFolderRequestObjectAsync()
        {
            // Snippet: GetManagedFolderAsync(GetManagedFolderRequest, CallSettings)
            // Additional: GetManagedFolderAsync(GetManagedFolderRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            GetManagedFolderRequest request = new GetManagedFolderRequest
            {
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                ManagedFolderName = ManagedFolderName.FromProjectBucketManagedFolder("[PROJECT]", "[BUCKET]", "[MANAGED_FOLDER]"),
            };
            // Make the request
            ManagedFolder response = await storageControlClient.GetManagedFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetManagedFolder</summary>
        public void GetManagedFolder()
        {
            // Snippet: GetManagedFolder(string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/managedFolders/[MANAGED_FOLDER]";
            // Make the request
            ManagedFolder response = storageControlClient.GetManagedFolder(name);
            // End snippet
        }

        /// <summary>Snippet for GetManagedFolderAsync</summary>
        public async Task GetManagedFolderAsync()
        {
            // Snippet: GetManagedFolderAsync(string, CallSettings)
            // Additional: GetManagedFolderAsync(string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/managedFolders/[MANAGED_FOLDER]";
            // Make the request
            ManagedFolder response = await storageControlClient.GetManagedFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetManagedFolder</summary>
        public void GetManagedFolderResourceNames()
        {
            // Snippet: GetManagedFolder(ManagedFolderName, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            ManagedFolderName name = ManagedFolderName.FromProjectBucketManagedFolder("[PROJECT]", "[BUCKET]", "[MANAGED_FOLDER]");
            // Make the request
            ManagedFolder response = storageControlClient.GetManagedFolder(name);
            // End snippet
        }

        /// <summary>Snippet for GetManagedFolderAsync</summary>
        public async Task GetManagedFolderResourceNamesAsync()
        {
            // Snippet: GetManagedFolderAsync(ManagedFolderName, CallSettings)
            // Additional: GetManagedFolderAsync(ManagedFolderName, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            ManagedFolderName name = ManagedFolderName.FromProjectBucketManagedFolder("[PROJECT]", "[BUCKET]", "[MANAGED_FOLDER]");
            // Make the request
            ManagedFolder response = await storageControlClient.GetManagedFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListManagedFolders</summary>
        public void ListManagedFoldersRequestObject()
        {
            // Snippet: ListManagedFolders(ListManagedFoldersRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            ListManagedFoldersRequest request = new ListManagedFoldersRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Prefix = "",
            };
            // Make the request
            PagedEnumerable<ListManagedFoldersResponse, ManagedFolder> response = storageControlClient.ListManagedFolders(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagedFolder item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListManagedFoldersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedFolder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedFolder> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedFolder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedFoldersAsync</summary>
        public async Task ListManagedFoldersRequestObjectAsync()
        {
            // Snippet: ListManagedFoldersAsync(ListManagedFoldersRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            ListManagedFoldersRequest request = new ListManagedFoldersRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Prefix = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListManagedFoldersResponse, ManagedFolder> response = storageControlClient.ListManagedFoldersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagedFolder item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListManagedFoldersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedFolder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedFolder> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedFolder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedFolders</summary>
        public void ListManagedFolders()
        {
            // Snippet: ListManagedFolders(string, string, int?, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedEnumerable<ListManagedFoldersResponse, ManagedFolder> response = storageControlClient.ListManagedFolders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagedFolder item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListManagedFoldersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedFolder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedFolder> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedFolder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedFoldersAsync</summary>
        public async Task ListManagedFoldersAsync()
        {
            // Snippet: ListManagedFoldersAsync(string, string, int?, CallSettings)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedAsyncEnumerable<ListManagedFoldersResponse, ManagedFolder> response = storageControlClient.ListManagedFoldersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagedFolder item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListManagedFoldersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedFolder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedFolder> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedFolder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedFolders</summary>
        public void ListManagedFoldersResourceNames()
        {
            // Snippet: ListManagedFolders(BucketName, string, int?, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedEnumerable<ListManagedFoldersResponse, ManagedFolder> response = storageControlClient.ListManagedFolders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagedFolder item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListManagedFoldersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedFolder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedFolder> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedFolder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedFoldersAsync</summary>
        public async Task ListManagedFoldersResourceNamesAsync()
        {
            // Snippet: ListManagedFoldersAsync(BucketName, string, int?, CallSettings)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedAsyncEnumerable<ListManagedFoldersResponse, ManagedFolder> response = storageControlClient.ListManagedFoldersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagedFolder item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListManagedFoldersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedFolder item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedFolder> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedFolder item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAnywhereCache</summary>
        public void CreateAnywhereCacheRequestObject()
        {
            // Snippet: CreateAnywhereCache(CreateAnywhereCacheRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            CreateAnywhereCacheRequest request = new CreateAnywhereCacheRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                AnywhereCache = new AnywhereCache(),
            };
            // Make the request
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> response = storageControlClient.CreateAnywhereCache(request);

            // Poll until the returned long-running operation is complete
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnywhereCache result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> retrievedResponse = storageControlClient.PollOnceCreateAnywhereCache(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnywhereCache retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnywhereCacheAsync</summary>
        public async Task CreateAnywhereCacheRequestObjectAsync()
        {
            // Snippet: CreateAnywhereCacheAsync(CreateAnywhereCacheRequest, CallSettings)
            // Additional: CreateAnywhereCacheAsync(CreateAnywhereCacheRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            CreateAnywhereCacheRequest request = new CreateAnywhereCacheRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                AnywhereCache = new AnywhereCache(),
            };
            // Make the request
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> response = await storageControlClient.CreateAnywhereCacheAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnywhereCache result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> retrievedResponse = await storageControlClient.PollOnceCreateAnywhereCacheAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnywhereCache retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnywhereCache</summary>
        public void CreateAnywhereCache()
        {
            // Snippet: CreateAnywhereCache(string, AnywhereCache, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            AnywhereCache anywhereCache = new AnywhereCache();
            // Make the request
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> response = storageControlClient.CreateAnywhereCache(parent, anywhereCache);

            // Poll until the returned long-running operation is complete
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnywhereCache result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> retrievedResponse = storageControlClient.PollOnceCreateAnywhereCache(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnywhereCache retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnywhereCacheAsync</summary>
        public async Task CreateAnywhereCacheAsync()
        {
            // Snippet: CreateAnywhereCacheAsync(string, AnywhereCache, CallSettings)
            // Additional: CreateAnywhereCacheAsync(string, AnywhereCache, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            AnywhereCache anywhereCache = new AnywhereCache();
            // Make the request
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> response = await storageControlClient.CreateAnywhereCacheAsync(parent, anywhereCache);

            // Poll until the returned long-running operation is complete
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnywhereCache result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> retrievedResponse = await storageControlClient.PollOnceCreateAnywhereCacheAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnywhereCache retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnywhereCache</summary>
        public void CreateAnywhereCacheResourceNames()
        {
            // Snippet: CreateAnywhereCache(BucketName, AnywhereCache, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            AnywhereCache anywhereCache = new AnywhereCache();
            // Make the request
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> response = storageControlClient.CreateAnywhereCache(parent, anywhereCache);

            // Poll until the returned long-running operation is complete
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnywhereCache result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> retrievedResponse = storageControlClient.PollOnceCreateAnywhereCache(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnywhereCache retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnywhereCacheAsync</summary>
        public async Task CreateAnywhereCacheResourceNamesAsync()
        {
            // Snippet: CreateAnywhereCacheAsync(BucketName, AnywhereCache, CallSettings)
            // Additional: CreateAnywhereCacheAsync(BucketName, AnywhereCache, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            AnywhereCache anywhereCache = new AnywhereCache();
            // Make the request
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> response = await storageControlClient.CreateAnywhereCacheAsync(parent, anywhereCache);

            // Poll until the returned long-running operation is complete
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnywhereCache result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnywhereCache, CreateAnywhereCacheMetadata> retrievedResponse = await storageControlClient.PollOnceCreateAnywhereCacheAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnywhereCache retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAnywhereCache</summary>
        public void UpdateAnywhereCacheRequestObject()
        {
            // Snippet: UpdateAnywhereCache(UpdateAnywhereCacheRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            UpdateAnywhereCacheRequest request = new UpdateAnywhereCacheRequest
            {
                AnywhereCache = new AnywhereCache(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> response = storageControlClient.UpdateAnywhereCache(request);

            // Poll until the returned long-running operation is complete
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnywhereCache result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> retrievedResponse = storageControlClient.PollOnceUpdateAnywhereCache(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnywhereCache retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAnywhereCacheAsync</summary>
        public async Task UpdateAnywhereCacheRequestObjectAsync()
        {
            // Snippet: UpdateAnywhereCacheAsync(UpdateAnywhereCacheRequest, CallSettings)
            // Additional: UpdateAnywhereCacheAsync(UpdateAnywhereCacheRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAnywhereCacheRequest request = new UpdateAnywhereCacheRequest
            {
                AnywhereCache = new AnywhereCache(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> response = await storageControlClient.UpdateAnywhereCacheAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnywhereCache result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> retrievedResponse = await storageControlClient.PollOnceUpdateAnywhereCacheAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnywhereCache retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAnywhereCache</summary>
        public void UpdateAnywhereCache()
        {
            // Snippet: UpdateAnywhereCache(AnywhereCache, FieldMask, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            AnywhereCache anywhereCache = new AnywhereCache();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> response = storageControlClient.UpdateAnywhereCache(anywhereCache, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnywhereCache result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> retrievedResponse = storageControlClient.PollOnceUpdateAnywhereCache(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnywhereCache retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAnywhereCacheAsync</summary>
        public async Task UpdateAnywhereCacheAsync()
        {
            // Snippet: UpdateAnywhereCacheAsync(AnywhereCache, FieldMask, CallSettings)
            // Additional: UpdateAnywhereCacheAsync(AnywhereCache, FieldMask, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            AnywhereCache anywhereCache = new AnywhereCache();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> response = await storageControlClient.UpdateAnywhereCacheAsync(anywhereCache, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnywhereCache result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnywhereCache, UpdateAnywhereCacheMetadata> retrievedResponse = await storageControlClient.PollOnceUpdateAnywhereCacheAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnywhereCache retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableAnywhereCache</summary>
        public void DisableAnywhereCacheRequestObject()
        {
            // Snippet: DisableAnywhereCache(DisableAnywhereCacheRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            DisableAnywhereCacheRequest request = new DisableAnywhereCacheRequest
            {
                AnywhereCacheName = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]"),
            };
            // Make the request
            AnywhereCache response = storageControlClient.DisableAnywhereCache(request);
            // End snippet
        }

        /// <summary>Snippet for DisableAnywhereCacheAsync</summary>
        public async Task DisableAnywhereCacheRequestObjectAsync()
        {
            // Snippet: DisableAnywhereCacheAsync(DisableAnywhereCacheRequest, CallSettings)
            // Additional: DisableAnywhereCacheAsync(DisableAnywhereCacheRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            DisableAnywhereCacheRequest request = new DisableAnywhereCacheRequest
            {
                AnywhereCacheName = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]"),
            };
            // Make the request
            AnywhereCache response = await storageControlClient.DisableAnywhereCacheAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DisableAnywhereCache</summary>
        public void DisableAnywhereCache()
        {
            // Snippet: DisableAnywhereCache(string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/anywhereCaches/[ANYWHERE_CACHE]";
            // Make the request
            AnywhereCache response = storageControlClient.DisableAnywhereCache(name);
            // End snippet
        }

        /// <summary>Snippet for DisableAnywhereCacheAsync</summary>
        public async Task DisableAnywhereCacheAsync()
        {
            // Snippet: DisableAnywhereCacheAsync(string, CallSettings)
            // Additional: DisableAnywhereCacheAsync(string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/anywhereCaches/[ANYWHERE_CACHE]";
            // Make the request
            AnywhereCache response = await storageControlClient.DisableAnywhereCacheAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisableAnywhereCache</summary>
        public void DisableAnywhereCacheResourceNames()
        {
            // Snippet: DisableAnywhereCache(AnywhereCacheName, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            AnywhereCacheName name = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]");
            // Make the request
            AnywhereCache response = storageControlClient.DisableAnywhereCache(name);
            // End snippet
        }

        /// <summary>Snippet for DisableAnywhereCacheAsync</summary>
        public async Task DisableAnywhereCacheResourceNamesAsync()
        {
            // Snippet: DisableAnywhereCacheAsync(AnywhereCacheName, CallSettings)
            // Additional: DisableAnywhereCacheAsync(AnywhereCacheName, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            AnywhereCacheName name = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]");
            // Make the request
            AnywhereCache response = await storageControlClient.DisableAnywhereCacheAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseAnywhereCache</summary>
        public void PauseAnywhereCacheRequestObject()
        {
            // Snippet: PauseAnywhereCache(PauseAnywhereCacheRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            PauseAnywhereCacheRequest request = new PauseAnywhereCacheRequest
            {
                AnywhereCacheName = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]"),
            };
            // Make the request
            AnywhereCache response = storageControlClient.PauseAnywhereCache(request);
            // End snippet
        }

        /// <summary>Snippet for PauseAnywhereCacheAsync</summary>
        public async Task PauseAnywhereCacheRequestObjectAsync()
        {
            // Snippet: PauseAnywhereCacheAsync(PauseAnywhereCacheRequest, CallSettings)
            // Additional: PauseAnywhereCacheAsync(PauseAnywhereCacheRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            PauseAnywhereCacheRequest request = new PauseAnywhereCacheRequest
            {
                AnywhereCacheName = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]"),
            };
            // Make the request
            AnywhereCache response = await storageControlClient.PauseAnywhereCacheAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseAnywhereCache</summary>
        public void PauseAnywhereCache()
        {
            // Snippet: PauseAnywhereCache(string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/anywhereCaches/[ANYWHERE_CACHE]";
            // Make the request
            AnywhereCache response = storageControlClient.PauseAnywhereCache(name);
            // End snippet
        }

        /// <summary>Snippet for PauseAnywhereCacheAsync</summary>
        public async Task PauseAnywhereCacheAsync()
        {
            // Snippet: PauseAnywhereCacheAsync(string, CallSettings)
            // Additional: PauseAnywhereCacheAsync(string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/anywhereCaches/[ANYWHERE_CACHE]";
            // Make the request
            AnywhereCache response = await storageControlClient.PauseAnywhereCacheAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseAnywhereCache</summary>
        public void PauseAnywhereCacheResourceNames()
        {
            // Snippet: PauseAnywhereCache(AnywhereCacheName, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            AnywhereCacheName name = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]");
            // Make the request
            AnywhereCache response = storageControlClient.PauseAnywhereCache(name);
            // End snippet
        }

        /// <summary>Snippet for PauseAnywhereCacheAsync</summary>
        public async Task PauseAnywhereCacheResourceNamesAsync()
        {
            // Snippet: PauseAnywhereCacheAsync(AnywhereCacheName, CallSettings)
            // Additional: PauseAnywhereCacheAsync(AnywhereCacheName, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            AnywhereCacheName name = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]");
            // Make the request
            AnywhereCache response = await storageControlClient.PauseAnywhereCacheAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeAnywhereCache</summary>
        public void ResumeAnywhereCacheRequestObject()
        {
            // Snippet: ResumeAnywhereCache(ResumeAnywhereCacheRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            ResumeAnywhereCacheRequest request = new ResumeAnywhereCacheRequest
            {
                AnywhereCacheName = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]"),
            };
            // Make the request
            AnywhereCache response = storageControlClient.ResumeAnywhereCache(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeAnywhereCacheAsync</summary>
        public async Task ResumeAnywhereCacheRequestObjectAsync()
        {
            // Snippet: ResumeAnywhereCacheAsync(ResumeAnywhereCacheRequest, CallSettings)
            // Additional: ResumeAnywhereCacheAsync(ResumeAnywhereCacheRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            ResumeAnywhereCacheRequest request = new ResumeAnywhereCacheRequest
            {
                AnywhereCacheName = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]"),
            };
            // Make the request
            AnywhereCache response = await storageControlClient.ResumeAnywhereCacheAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeAnywhereCache</summary>
        public void ResumeAnywhereCache()
        {
            // Snippet: ResumeAnywhereCache(string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/anywhereCaches/[ANYWHERE_CACHE]";
            // Make the request
            AnywhereCache response = storageControlClient.ResumeAnywhereCache(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeAnywhereCacheAsync</summary>
        public async Task ResumeAnywhereCacheAsync()
        {
            // Snippet: ResumeAnywhereCacheAsync(string, CallSettings)
            // Additional: ResumeAnywhereCacheAsync(string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/anywhereCaches/[ANYWHERE_CACHE]";
            // Make the request
            AnywhereCache response = await storageControlClient.ResumeAnywhereCacheAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeAnywhereCache</summary>
        public void ResumeAnywhereCacheResourceNames()
        {
            // Snippet: ResumeAnywhereCache(AnywhereCacheName, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            AnywhereCacheName name = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]");
            // Make the request
            AnywhereCache response = storageControlClient.ResumeAnywhereCache(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeAnywhereCacheAsync</summary>
        public async Task ResumeAnywhereCacheResourceNamesAsync()
        {
            // Snippet: ResumeAnywhereCacheAsync(AnywhereCacheName, CallSettings)
            // Additional: ResumeAnywhereCacheAsync(AnywhereCacheName, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            AnywhereCacheName name = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]");
            // Make the request
            AnywhereCache response = await storageControlClient.ResumeAnywhereCacheAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnywhereCache</summary>
        public void GetAnywhereCacheRequestObject()
        {
            // Snippet: GetAnywhereCache(GetAnywhereCacheRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            GetAnywhereCacheRequest request = new GetAnywhereCacheRequest
            {
                AnywhereCacheName = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]"),
            };
            // Make the request
            AnywhereCache response = storageControlClient.GetAnywhereCache(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnywhereCacheAsync</summary>
        public async Task GetAnywhereCacheRequestObjectAsync()
        {
            // Snippet: GetAnywhereCacheAsync(GetAnywhereCacheRequest, CallSettings)
            // Additional: GetAnywhereCacheAsync(GetAnywhereCacheRequest, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            GetAnywhereCacheRequest request = new GetAnywhereCacheRequest
            {
                AnywhereCacheName = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]"),
            };
            // Make the request
            AnywhereCache response = await storageControlClient.GetAnywhereCacheAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnywhereCache</summary>
        public void GetAnywhereCache()
        {
            // Snippet: GetAnywhereCache(string, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/anywhereCaches/[ANYWHERE_CACHE]";
            // Make the request
            AnywhereCache response = storageControlClient.GetAnywhereCache(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnywhereCacheAsync</summary>
        public async Task GetAnywhereCacheAsync()
        {
            // Snippet: GetAnywhereCacheAsync(string, CallSettings)
            // Additional: GetAnywhereCacheAsync(string, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/anywhereCaches/[ANYWHERE_CACHE]";
            // Make the request
            AnywhereCache response = await storageControlClient.GetAnywhereCacheAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnywhereCache</summary>
        public void GetAnywhereCacheResourceNames()
        {
            // Snippet: GetAnywhereCache(AnywhereCacheName, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            AnywhereCacheName name = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]");
            // Make the request
            AnywhereCache response = storageControlClient.GetAnywhereCache(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnywhereCacheAsync</summary>
        public async Task GetAnywhereCacheResourceNamesAsync()
        {
            // Snippet: GetAnywhereCacheAsync(AnywhereCacheName, CallSettings)
            // Additional: GetAnywhereCacheAsync(AnywhereCacheName, CancellationToken)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            AnywhereCacheName name = AnywhereCacheName.FromProjectBucketAnywhereCache("[PROJECT]", "[BUCKET]", "[ANYWHERE_CACHE]");
            // Make the request
            AnywhereCache response = await storageControlClient.GetAnywhereCacheAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAnywhereCaches</summary>
        public void ListAnywhereCachesRequestObject()
        {
            // Snippet: ListAnywhereCaches(ListAnywhereCachesRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            ListAnywhereCachesRequest request = new ListAnywhereCachesRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
            };
            // Make the request
            PagedEnumerable<ListAnywhereCachesResponse, AnywhereCache> response = storageControlClient.ListAnywhereCaches(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnywhereCache item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnywhereCachesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnywhereCache item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnywhereCache> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnywhereCache item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnywhereCachesAsync</summary>
        public async Task ListAnywhereCachesRequestObjectAsync()
        {
            // Snippet: ListAnywhereCachesAsync(ListAnywhereCachesRequest, CallSettings)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            ListAnywhereCachesRequest request = new ListAnywhereCachesRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAnywhereCachesResponse, AnywhereCache> response = storageControlClient.ListAnywhereCachesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnywhereCache item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnywhereCachesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnywhereCache item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnywhereCache> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnywhereCache item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnywhereCaches</summary>
        public void ListAnywhereCaches()
        {
            // Snippet: ListAnywhereCaches(string, string, int?, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedEnumerable<ListAnywhereCachesResponse, AnywhereCache> response = storageControlClient.ListAnywhereCaches(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnywhereCache item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnywhereCachesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnywhereCache item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnywhereCache> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnywhereCache item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnywhereCachesAsync</summary>
        public async Task ListAnywhereCachesAsync()
        {
            // Snippet: ListAnywhereCachesAsync(string, string, int?, CallSettings)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedAsyncEnumerable<ListAnywhereCachesResponse, AnywhereCache> response = storageControlClient.ListAnywhereCachesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnywhereCache item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnywhereCachesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnywhereCache item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnywhereCache> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnywhereCache item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnywhereCaches</summary>
        public void ListAnywhereCachesResourceNames()
        {
            // Snippet: ListAnywhereCaches(BucketName, string, int?, CallSettings)
            // Create client
            StorageControlClient storageControlClient = StorageControlClient.Create();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedEnumerable<ListAnywhereCachesResponse, AnywhereCache> response = storageControlClient.ListAnywhereCaches(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnywhereCache item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnywhereCachesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnywhereCache item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnywhereCache> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnywhereCache item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnywhereCachesAsync</summary>
        public async Task ListAnywhereCachesResourceNamesAsync()
        {
            // Snippet: ListAnywhereCachesAsync(BucketName, string, int?, CallSettings)
            // Create client
            StorageControlClient storageControlClient = await StorageControlClient.CreateAsync();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedAsyncEnumerable<ListAnywhereCachesResponse, AnywhereCache> response = storageControlClient.ListAnywhereCachesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnywhereCache item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnywhereCachesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnywhereCache item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnywhereCache> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnywhereCache item in singlePage)
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
