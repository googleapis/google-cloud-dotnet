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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPacketMirroringsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListPacketMirroringsRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            AggregatedListPacketMirroringsRequest request = new AggregatedListPacketMirroringsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<PacketMirroringAggregatedList, KeyValuePair<string, PacketMirroringsScopedList>> response = packetMirroringsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, PacketMirroringsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PacketMirroringAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, PacketMirroringsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, PacketMirroringsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, PacketMirroringsScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListPacketMirroringsRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListPacketMirroringsRequest request = new AggregatedListPacketMirroringsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<PacketMirroringAggregatedList, KeyValuePair<string, PacketMirroringsScopedList>> response = packetMirroringsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, PacketMirroringsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PacketMirroringAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, PacketMirroringsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, PacketMirroringsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, PacketMirroringsScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, string, int?, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<PacketMirroringAggregatedList, KeyValuePair<string, PacketMirroringsScopedList>> response = packetMirroringsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, PacketMirroringsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PacketMirroringAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, PacketMirroringsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, PacketMirroringsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, PacketMirroringsScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, string, int?, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<PacketMirroringAggregatedList, KeyValuePair<string, PacketMirroringsScopedList>> response = packetMirroringsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, PacketMirroringsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PacketMirroringAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, PacketMirroringsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, PacketMirroringsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, PacketMirroringsScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeletePacketMirroringRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            DeletePacketMirroringRequest request = new DeletePacketMirroringRequest
            {
                PacketMirroring = "",
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = packetMirroringsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = packetMirroringsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeletePacketMirroringRequest, CallSettings)
            // Additional: DeleteAsync(DeletePacketMirroringRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            DeletePacketMirroringRequest request = new DeletePacketMirroringRequest
            {
                PacketMirroring = "",
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await packetMirroringsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await packetMirroringsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            // Make the request
            lro::Operation<Operation, Operation> response = packetMirroringsClient.Delete(project, region, packetMirroring);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = packetMirroringsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await packetMirroringsClient.DeleteAsync(project, region, packetMirroring);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await packetMirroringsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetPacketMirroringRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "",
                Region = "",
                Project = "",
            };
            // Make the request
            PacketMirroring response = packetMirroringsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetPacketMirroringRequest, CallSettings)
            // Additional: GetAsync(GetPacketMirroringRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "",
                Region = "",
                Project = "",
            };
            // Make the request
            PacketMirroring response = await packetMirroringsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            // Make the request
            PacketMirroring response = packetMirroringsClient.Get(project, region, packetMirroring);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            // Make the request
            PacketMirroring response = await packetMirroringsClient.GetAsync(project, region, packetMirroring);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertPacketMirroringRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            InsertPacketMirroringRequest request = new InsertPacketMirroringRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                PacketMirroringResource = new PacketMirroring(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = packetMirroringsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = packetMirroringsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertPacketMirroringRequest, CallSettings)
            // Additional: InsertAsync(InsertPacketMirroringRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            InsertPacketMirroringRequest request = new InsertPacketMirroringRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                PacketMirroringResource = new PacketMirroring(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await packetMirroringsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await packetMirroringsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, PacketMirroring, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            PacketMirroring packetMirroringResource = new PacketMirroring();
            // Make the request
            lro::Operation<Operation, Operation> response = packetMirroringsClient.Insert(project, region, packetMirroringResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = packetMirroringsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, PacketMirroring, CallSettings)
            // Additional: InsertAsync(string, string, PacketMirroring, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            PacketMirroring packetMirroringResource = new PacketMirroring();
            // Make the request
            lro::Operation<Operation, Operation> response = await packetMirroringsClient.InsertAsync(project, region, packetMirroringResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await packetMirroringsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListPacketMirroringsRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            ListPacketMirroringsRequest request = new ListPacketMirroringsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<PacketMirroringList, PacketMirroring> response = packetMirroringsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PacketMirroring item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PacketMirroringList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PacketMirroring item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PacketMirroring> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PacketMirroring item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListPacketMirroringsRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            ListPacketMirroringsRequest request = new ListPacketMirroringsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<PacketMirroringList, PacketMirroring> response = packetMirroringsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PacketMirroring item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PacketMirroringList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PacketMirroring item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PacketMirroring> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PacketMirroring item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, string, int?, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<PacketMirroringList, PacketMirroring> response = packetMirroringsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PacketMirroring item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PacketMirroringList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PacketMirroring item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PacketMirroring> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PacketMirroring item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, string, int?, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<PacketMirroringList, PacketMirroring> response = packetMirroringsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PacketMirroring item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PacketMirroringList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PacketMirroring item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PacketMirroring> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PacketMirroring item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchPacketMirroringRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            PatchPacketMirroringRequest request = new PatchPacketMirroringRequest
            {
                PacketMirroring = "",
                RequestId = "",
                Region = "",
                Project = "",
                PacketMirroringResource = new PacketMirroring(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = packetMirroringsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = packetMirroringsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchPacketMirroringRequest, CallSettings)
            // Additional: PatchAsync(PatchPacketMirroringRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            PatchPacketMirroringRequest request = new PatchPacketMirroringRequest
            {
                PacketMirroring = "",
                RequestId = "",
                Region = "",
                Project = "",
                PacketMirroringResource = new PacketMirroring(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await packetMirroringsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await packetMirroringsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, PacketMirroring, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            PacketMirroring packetMirroringResource = new PacketMirroring();
            // Make the request
            lro::Operation<Operation, Operation> response = packetMirroringsClient.Patch(project, region, packetMirroring, packetMirroringResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = packetMirroringsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, PacketMirroring, CallSettings)
            // Additional: PatchAsync(string, string, string, PacketMirroring, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            PacketMirroring packetMirroringResource = new PacketMirroring();
            // Make the request
            lro::Operation<Operation, Operation> response = await packetMirroringsClient.PatchAsync(project, region, packetMirroring, packetMirroringResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await packetMirroringsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsPacketMirroringRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = packetMirroringsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsPacketMirroringRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsPacketMirroringRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await packetMirroringsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = packetMirroringsClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await packetMirroringsClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
