// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Cloud.Firestore.Admin.V1Beta1;
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

namespace Google.Cloud.Firestore.V1Beta1.Snippets
{
    public class GeneratedFirestoreAdminClientSnippets
    {
        public async Task CreateIndexAsync()
        {
            // Snippet: CreateIndexAsync(string,Index,CallSettings)
            // Additional: CreateIndexAsync(string,Index,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new DatabaseName("[PROJECT]", "[DATABASE]").ToString();
            Index index = new Index();
            // Make the request
            Operation response = await firestoreAdminClient.CreateIndexAsync(formattedParent, index);
            // End snippet
        }

        public void CreateIndex()
        {
            // Snippet: CreateIndex(string,Index,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string formattedParent = new DatabaseName("[PROJECT]", "[DATABASE]").ToString();
            Index index = new Index();
            // Make the request
            Operation response = firestoreAdminClient.CreateIndex(formattedParent, index);
            // End snippet
        }

        public async Task CreateIndexAsync_RequestObject()
        {
            // Snippet: CreateIndexAsync(CreateIndexRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateIndexRequest request = new CreateIndexRequest
            {
                Parent = new DatabaseName("[PROJECT]", "[DATABASE]").ToString(),
                Index = new Index(),
            };
            // Make the request
            Operation response = await firestoreAdminClient.CreateIndexAsync(request);
            // End snippet
        }

        public void CreateIndex_RequestObject()
        {
            // Snippet: CreateIndex(CreateIndexRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            CreateIndexRequest request = new CreateIndexRequest
            {
                Parent = new DatabaseName("[PROJECT]", "[DATABASE]").ToString(),
                Index = new Index(),
            };
            // Make the request
            Operation response = firestoreAdminClient.CreateIndex(request);
            // End snippet
        }

        public async Task ListIndexesAsync()
        {
            // Snippet: ListIndexesAsync(string,string,int?,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new DatabaseName("[PROJECT]", "[DATABASE]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListIndexesResponse, Index> response =
                firestoreAdminClient.ListIndexesAsync(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Index item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Index item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListIndexes()
        {
            // Snippet: ListIndexes(string,string,int?,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string formattedParent = new DatabaseName("[PROJECT]", "[DATABASE]").ToString();
            // Make the request
            PagedEnumerable<ListIndexesResponse, Index> response =
                firestoreAdminClient.ListIndexes(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Index item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Index item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListIndexesAsync_RequestObject()
        {
            // Snippet: ListIndexesAsync(ListIndexesRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListIndexesRequest request = new ListIndexesRequest
            {
                Parent = new DatabaseName("[PROJECT]", "[DATABASE]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListIndexesResponse, Index> response =
                firestoreAdminClient.ListIndexesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Index item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Index item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListIndexes_RequestObject()
        {
            // Snippet: ListIndexes(ListIndexesRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ListIndexesRequest request = new ListIndexesRequest
            {
                Parent = new DatabaseName("[PROJECT]", "[DATABASE]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListIndexesResponse, Index> response =
                firestoreAdminClient.ListIndexes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Index item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Index item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task GetIndexAsync()
        {
            // Snippet: GetIndexAsync(string,CallSettings)
            // Additional: GetIndexAsync(string,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new IndexName("[PROJECT]", "[DATABASE]", "[INDEX]").ToString();
            // Make the request
            Index response = await firestoreAdminClient.GetIndexAsync(formattedName);
            // End snippet
        }

        public void GetIndex()
        {
            // Snippet: GetIndex(string,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string formattedName = new IndexName("[PROJECT]", "[DATABASE]", "[INDEX]").ToString();
            // Make the request
            Index response = firestoreAdminClient.GetIndex(formattedName);
            // End snippet
        }

        public async Task GetIndexAsync_RequestObject()
        {
            // Snippet: GetIndexAsync(GetIndexRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIndexRequest request = new GetIndexRequest
            {
                Name = new IndexName("[PROJECT]", "[DATABASE]", "[INDEX]").ToString(),
            };
            // Make the request
            Index response = await firestoreAdminClient.GetIndexAsync(request);
            // End snippet
        }

        public void GetIndex_RequestObject()
        {
            // Snippet: GetIndex(GetIndexRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            GetIndexRequest request = new GetIndexRequest
            {
                Name = new IndexName("[PROJECT]", "[DATABASE]", "[INDEX]").ToString(),
            };
            // Make the request
            Index response = firestoreAdminClient.GetIndex(request);
            // End snippet
        }

        public async Task DeleteIndexAsync()
        {
            // Snippet: DeleteIndexAsync(string,CallSettings)
            // Additional: DeleteIndexAsync(string,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new IndexName("[PROJECT]", "[DATABASE]", "[INDEX]").ToString();
            // Make the request
            await firestoreAdminClient.DeleteIndexAsync(formattedName);
            // End snippet
        }

        public void DeleteIndex()
        {
            // Snippet: DeleteIndex(string,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string formattedName = new IndexName("[PROJECT]", "[DATABASE]", "[INDEX]").ToString();
            // Make the request
            firestoreAdminClient.DeleteIndex(formattedName);
            // End snippet
        }

        public async Task DeleteIndexAsync_RequestObject()
        {
            // Snippet: DeleteIndexAsync(DeleteIndexRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                Name = new IndexName("[PROJECT]", "[DATABASE]", "[INDEX]").ToString(),
            };
            // Make the request
            await firestoreAdminClient.DeleteIndexAsync(request);
            // End snippet
        }

        public void DeleteIndex_RequestObject()
        {
            // Snippet: DeleteIndex(DeleteIndexRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                Name = new IndexName("[PROJECT]", "[DATABASE]", "[INDEX]").ToString(),
            };
            // Make the request
            firestoreAdminClient.DeleteIndex(request);
            // End snippet
        }

    }
}
