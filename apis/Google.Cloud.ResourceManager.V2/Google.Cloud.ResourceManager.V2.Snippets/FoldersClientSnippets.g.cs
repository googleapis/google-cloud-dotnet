// Copyright 2017, Google LLC All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Iam.V1;
using Google.Cloud.ResourceManager.V2;
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.ResourceManager.V2.Snippets
{
    /// <summary>Generated snippets</summary>
    public class GeneratedFoldersClientSnippets
    {
        /// <summary>Snippet for ListFoldersAsync</summary>
        public async Task ListFoldersAsync1()
        {
            // Snippet: ListFoldersAsync(ParentNameOneof,bool?,string,int?,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new OrganizationName("[ORG_ID]"));
            bool showDeleted = false;
            // Make the request
            PagedAsyncEnumerable<ListFoldersResponse, Folder> response =
                foldersClient.ListFoldersAsync(parent, showDeleted);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFolders</summary>
        public void ListFolders1()
        {
            // Snippet: ListFolders(ParentNameOneof,bool?,string,int?,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new OrganizationName("[ORG_ID]"));
            bool showDeleted = false;
            // Make the request
            PagedEnumerable<ListFoldersResponse, Folder> response =
                foldersClient.ListFolders(parent, showDeleted);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFoldersAsync</summary>
        public async Task ListFoldersAsync2()
        {
            // Snippet: ListFoldersAsync(ParentNameOneof,string,int?,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new OrganizationName("[ORG_ID]"));
            // Make the request
            PagedAsyncEnumerable<ListFoldersResponse, Folder> response =
                foldersClient.ListFoldersAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFolders</summary>
        public void ListFolders2()
        {
            // Snippet: ListFolders(ParentNameOneof,string,int?,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new OrganizationName("[ORG_ID]"));
            // Make the request
            PagedEnumerable<ListFoldersResponse, Folder> response =
                foldersClient.ListFolders(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFoldersAsync</summary>
        public async Task ListFoldersAsync_RequestObject()
        {
            // Snippet: ListFoldersAsync(ListFoldersRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            ListFoldersRequest request = new ListFoldersRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new OrganizationName("[ORG_ID]")),
            };
            // Make the request
            PagedAsyncEnumerable<ListFoldersResponse, Folder> response =
                foldersClient.ListFoldersAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFolders</summary>
        public void ListFolders_RequestObject()
        {
            // Snippet: ListFolders(ListFoldersRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            ListFoldersRequest request = new ListFoldersRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new OrganizationName("[ORG_ID]")),
            };
            // Make the request
            PagedEnumerable<ListFoldersResponse, Folder> response =
                foldersClient.ListFolders(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFoldersAsync</summary>
        public async Task SearchFoldersAsync()
        {
            // Snippet: SearchFoldersAsync(string,string,int?,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchFoldersResponse, Folder> response =
                foldersClient.SearchFoldersAsync(query);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFolders</summary>
        public void SearchFolders()
        {
            // Snippet: SearchFolders(string,string,int?,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string query = "";
            // Make the request
            PagedEnumerable<SearchFoldersResponse, Folder> response =
                foldersClient.SearchFolders(query);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFoldersAsync</summary>
        public async Task SearchFoldersAsync_RequestObject()
        {
            // Snippet: SearchFoldersAsync(SearchFoldersRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            SearchFoldersRequest request = new SearchFoldersRequest
            {
                Query = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchFoldersResponse, Folder> response =
                foldersClient.SearchFoldersAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFolders</summary>
        public void SearchFolders_RequestObject()
        {
            // Snippet: SearchFolders(SearchFoldersRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            SearchFoldersRequest request = new SearchFoldersRequest
            {
                Query = "",
            };
            // Make the request
            PagedEnumerable<SearchFoldersResponse, Folder> response =
                foldersClient.SearchFolders(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFolderAsync</summary>
        public async Task GetFolderAsync()
        {
            // Snippet: GetFolderAsync(FolderName,CallSettings)
            // Additional: GetFolderAsync(FolderName,CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = new FolderName("[FOLDER]");
            // Make the request
            Folder response = await foldersClient.GetFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolder</summary>
        public void GetFolder()
        {
            // Snippet: GetFolder(FolderName,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            FolderName name = new FolderName("[FOLDER]");
            // Make the request
            Folder response = foldersClient.GetFolder(name);
            // End snippet
        }

        /// <summary>Snippet for GetFolderAsync</summary>
        public async Task GetFolderAsync_RequestObject()
        {
            // Snippet: GetFolderAsync(GetFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            GetFolderRequest request = new GetFolderRequest
            {
                FolderName = new FolderName("[FOLDER]"),
            };
            // Make the request
            Folder response = await foldersClient.GetFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFolder</summary>
        public void GetFolder_RequestObject()
        {
            // Snippet: GetFolder(GetFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            GetFolderRequest request = new GetFolderRequest
            {
                FolderName = new FolderName("[FOLDER]"),
            };
            // Make the request
            Folder response = foldersClient.GetFolder(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFolderAsync</summary>
        public async Task CreateFolderAsync()
        {
            // Snippet: CreateFolderAsync(ParentNameOneof,Folder,CallSettings)
            // Additional: CreateFolderAsync(ParentNameOneof,Folder,CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new OrganizationName("[ORG_ID]"));
            Folder folder = new Folder();
            // Make the request
            Operation response = await foldersClient.CreateFolderAsync(parent, folder);
            // End snippet
        }

        /// <summary>Snippet for CreateFolder</summary>
        public void CreateFolder()
        {
            // Snippet: CreateFolder(ParentNameOneof,Folder,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new OrganizationName("[ORG_ID]"));
            Folder folder = new Folder();
            // Make the request
            Operation response = foldersClient.CreateFolder(parent, folder);
            // End snippet
        }

        /// <summary>Snippet for CreateFolderAsync</summary>
        public async Task CreateFolderAsync_RequestObject()
        {
            // Snippet: CreateFolderAsync(CreateFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            CreateFolderRequest request = new CreateFolderRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new OrganizationName("[ORG_ID]")),
                Folder = new Folder(),
            };
            // Make the request
            Operation response = await foldersClient.CreateFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFolder</summary>
        public void CreateFolder_RequestObject()
        {
            // Snippet: CreateFolder(CreateFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            CreateFolderRequest request = new CreateFolderRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new OrganizationName("[ORG_ID]")),
                Folder = new Folder(),
            };
            // Make the request
            Operation response = foldersClient.CreateFolder(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFolderAsync</summary>
        public async Task UpdateFolderAsync()
        {
            // Snippet: UpdateFolderAsync(Folder,FieldMask,CallSettings)
            // Additional: UpdateFolderAsync(Folder,FieldMask,CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            Folder folder = new Folder();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Folder response = await foldersClient.UpdateFolderAsync(folder, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFolder</summary>
        public void UpdateFolder()
        {
            // Snippet: UpdateFolder(Folder,FieldMask,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            Folder folder = new Folder();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Folder response = foldersClient.UpdateFolder(folder, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFolderAsync</summary>
        public async Task UpdateFolderAsync_RequestObject()
        {
            // Snippet: UpdateFolderAsync(UpdateFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFolderRequest request = new UpdateFolderRequest
            {
                Folder = new Folder(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Folder response = await foldersClient.UpdateFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFolder</summary>
        public void UpdateFolder_RequestObject()
        {
            // Snippet: UpdateFolder(UpdateFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            UpdateFolderRequest request = new UpdateFolderRequest
            {
                Folder = new Folder(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Folder response = foldersClient.UpdateFolder(request);
            // End snippet
        }

        /// <summary>Snippet for MoveFolderAsync</summary>
        public async Task MoveFolderAsync()
        {
            // Snippet: MoveFolderAsync(FolderName,ParentNameOneof,CallSettings)
            // Additional: MoveFolderAsync(FolderName,ParentNameOneof,CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = new FolderName("[FOLDER]");
            ParentNameOneof destinationParent = ParentNameOneof.From(new OrganizationName("[ORG_ID]"));
            // Make the request
            Operation response = await foldersClient.MoveFolderAsync(name, destinationParent);
            // End snippet
        }

        /// <summary>Snippet for MoveFolder</summary>
        public void MoveFolder()
        {
            // Snippet: MoveFolder(FolderName,ParentNameOneof,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            FolderName name = new FolderName("[FOLDER]");
            ParentNameOneof destinationParent = ParentNameOneof.From(new OrganizationName("[ORG_ID]"));
            // Make the request
            Operation response = foldersClient.MoveFolder(name, destinationParent);
            // End snippet
        }

        /// <summary>Snippet for MoveFolderAsync</summary>
        public async Task MoveFolderAsync_RequestObject()
        {
            // Snippet: MoveFolderAsync(MoveFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            MoveFolderRequest request = new MoveFolderRequest
            {
                FolderName = new FolderName("[FOLDER]"),
                DestinationParentAsParentNameOneof = ParentNameOneof.From(new OrganizationName("[ORG_ID]")),
            };
            // Make the request
            Operation response = await foldersClient.MoveFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MoveFolder</summary>
        public void MoveFolder_RequestObject()
        {
            // Snippet: MoveFolder(MoveFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            MoveFolderRequest request = new MoveFolderRequest
            {
                FolderName = new FolderName("[FOLDER]"),
                DestinationParentAsParentNameOneof = ParentNameOneof.From(new OrganizationName("[ORG_ID]")),
            };
            // Make the request
            Operation response = foldersClient.MoveFolder(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderAsync1()
        {
            // Snippet: DeleteFolderAsync(FolderName,CallSettings)
            // Additional: DeleteFolderAsync(FolderName,CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = new FolderName("[FOLDER]");
            // Make the request
            Folder response = await foldersClient.DeleteFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolder1()
        {
            // Snippet: DeleteFolder(FolderName,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            FolderName name = new FolderName("[FOLDER]");
            // Make the request
            Folder response = foldersClient.DeleteFolder(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderAsync2()
        {
            // Snippet: DeleteFolderAsync(FolderName,bool?,CallSettings)
            // Additional: DeleteFolderAsync(FolderName,bool?,CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = new FolderName("[FOLDER]");
            bool recursiveDelete = false;
            // Make the request
            Folder response = await foldersClient.DeleteFolderAsync(name, recursiveDelete);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolder2()
        {
            // Snippet: DeleteFolder(FolderName,bool?,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            FolderName name = new FolderName("[FOLDER]");
            bool recursiveDelete = false;
            // Make the request
            Folder response = foldersClient.DeleteFolder(name, recursiveDelete);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolderAsync</summary>
        public async Task DeleteFolderAsync_RequestObject()
        {
            // Snippet: DeleteFolderAsync(DeleteFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFolderRequest request = new DeleteFolderRequest
            {
                FolderName = new FolderName("[FOLDER]"),
            };
            // Make the request
            Folder response = await foldersClient.DeleteFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFolder</summary>
        public void DeleteFolder_RequestObject()
        {
            // Snippet: DeleteFolder(DeleteFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            DeleteFolderRequest request = new DeleteFolderRequest
            {
                FolderName = new FolderName("[FOLDER]"),
            };
            // Make the request
            Folder response = foldersClient.DeleteFolder(request);
            // End snippet
        }

        /// <summary>Snippet for UndeleteFolderAsync</summary>
        public async Task UndeleteFolderAsync()
        {
            // Snippet: UndeleteFolderAsync(FolderName,CallSettings)
            // Additional: UndeleteFolderAsync(FolderName,CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = new FolderName("[FOLDER]");
            // Make the request
            Folder response = await foldersClient.UndeleteFolderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UndeleteFolder</summary>
        public void UndeleteFolder()
        {
            // Snippet: UndeleteFolder(FolderName,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            FolderName name = new FolderName("[FOLDER]");
            // Make the request
            Folder response = foldersClient.UndeleteFolder(name);
            // End snippet
        }

        /// <summary>Snippet for UndeleteFolderAsync</summary>
        public async Task UndeleteFolderAsync_RequestObject()
        {
            // Snippet: UndeleteFolderAsync(UndeleteFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteFolderRequest request = new UndeleteFolderRequest
            {
                FolderName = new FolderName("[FOLDER]"),
            };
            // Make the request
            Folder response = await foldersClient.UndeleteFolderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UndeleteFolder</summary>
        public void UndeleteFolder_RequestObject()
        {
            // Snippet: UndeleteFolder(UndeleteFolderRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            UndeleteFolderRequest request = new UndeleteFolderRequest
            {
                FolderName = new FolderName("[FOLDER]"),
            };
            // Make the request
            Folder response = foldersClient.UndeleteFolder(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string,CallSettings)
            // Additional: GetIamPolicyAsync(string,CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new FolderName("[FOLDER]").ToString();
            // Make the request
            Policy response = await foldersClient.GetIamPolicyAsync(formattedResource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string formattedResource = new FolderName("[FOLDER]").ToString();
            // Make the request
            Policy response = foldersClient.GetIamPolicy(formattedResource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new FolderName("[FOLDER]").ToString(),
            };
            // Make the request
            Policy response = await foldersClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new FolderName("[FOLDER]").ToString(),
            };
            // Make the request
            Policy response = foldersClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(string,Policy,CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new FolderName("[FOLDER]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = await foldersClient.SetIamPolicyAsync(formattedResource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string,Policy,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string formattedResource = new FolderName("[FOLDER]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = foldersClient.SetIamPolicy(formattedResource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new FolderName("[FOLDER]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await foldersClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new FolderName("[FOLDER]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = foldersClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new FolderName("[FOLDER]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await foldersClient.TestIamPermissionsAsync(formattedResource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string,IEnumerable<string>,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            string formattedResource = new FolderName("[FOLDER]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = foldersClient.TestIamPermissions(formattedResource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = await FoldersClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new FolderName("[FOLDER]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await foldersClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            FoldersClient foldersClient = FoldersClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new FolderName("[FOLDER]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = foldersClient.TestIamPermissions(request);
            // End snippet
        }

    }
}
