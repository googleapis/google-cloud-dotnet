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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPublicAdvertisedPrefixesClientSnippets
    {
        /// <summary>Snippet for Announce</summary>
        public void AnnounceRequestObject()
        {
            // Snippet: Announce(AnnouncePublicAdvertisedPrefixeRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            AnnouncePublicAdvertisedPrefixeRequest request = new AnnouncePublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = publicAdvertisedPrefixesClient.Announce(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicAdvertisedPrefixesClient.PollOnceAnnounce(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnnounceAsync</summary>
        public async Task AnnounceRequestObjectAsync()
        {
            // Snippet: AnnounceAsync(AnnouncePublicAdvertisedPrefixeRequest, CallSettings)
            // Additional: AnnounceAsync(AnnouncePublicAdvertisedPrefixeRequest, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            AnnouncePublicAdvertisedPrefixeRequest request = new AnnouncePublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await publicAdvertisedPrefixesClient.AnnounceAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicAdvertisedPrefixesClient.PollOnceAnnounceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Announce</summary>
        public void Announce()
        {
            // Snippet: Announce(string, string, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = publicAdvertisedPrefixesClient.Announce(project, publicAdvertisedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicAdvertisedPrefixesClient.PollOnceAnnounce(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnnounceAsync</summary>
        public async Task AnnounceAsync()
        {
            // Snippet: AnnounceAsync(string, string, CallSettings)
            // Additional: AnnounceAsync(string, string, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await publicAdvertisedPrefixesClient.AnnounceAsync(project, publicAdvertisedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicAdvertisedPrefixesClient.PollOnceAnnounceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeletePublicAdvertisedPrefixeRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            DeletePublicAdvertisedPrefixeRequest request = new DeletePublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = publicAdvertisedPrefixesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicAdvertisedPrefixesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeletePublicAdvertisedPrefixeRequest, CallSettings)
            // Additional: DeleteAsync(DeletePublicAdvertisedPrefixeRequest, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            DeletePublicAdvertisedPrefixeRequest request = new DeletePublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await publicAdvertisedPrefixesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicAdvertisedPrefixesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = publicAdvertisedPrefixesClient.Delete(project, publicAdvertisedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicAdvertisedPrefixesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await publicAdvertisedPrefixesClient.DeleteAsync(project, publicAdvertisedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicAdvertisedPrefixesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetPublicAdvertisedPrefixeRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            GetPublicAdvertisedPrefixeRequest request = new GetPublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicAdvertisedPrefix response = publicAdvertisedPrefixesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetPublicAdvertisedPrefixeRequest, CallSettings)
            // Additional: GetAsync(GetPublicAdvertisedPrefixeRequest, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            GetPublicAdvertisedPrefixeRequest request = new GetPublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicAdvertisedPrefix response = await publicAdvertisedPrefixesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            PublicAdvertisedPrefix response = publicAdvertisedPrefixesClient.Get(project, publicAdvertisedPrefix);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            PublicAdvertisedPrefix response = await publicAdvertisedPrefixesClient.GetAsync(project, publicAdvertisedPrefix);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertPublicAdvertisedPrefixeRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            InsertPublicAdvertisedPrefixeRequest request = new InsertPublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                Project = "",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = publicAdvertisedPrefixesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicAdvertisedPrefixesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertPublicAdvertisedPrefixeRequest, CallSettings)
            // Additional: InsertAsync(InsertPublicAdvertisedPrefixeRequest, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            InsertPublicAdvertisedPrefixeRequest request = new InsertPublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                Project = "",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await publicAdvertisedPrefixesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicAdvertisedPrefixesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, PublicAdvertisedPrefix, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            PublicAdvertisedPrefix publicAdvertisedPrefixResource = new PublicAdvertisedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = publicAdvertisedPrefixesClient.Insert(project, publicAdvertisedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicAdvertisedPrefixesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, PublicAdvertisedPrefix, CallSettings)
            // Additional: InsertAsync(string, PublicAdvertisedPrefix, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            PublicAdvertisedPrefix publicAdvertisedPrefixResource = new PublicAdvertisedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = await publicAdvertisedPrefixesClient.InsertAsync(project, publicAdvertisedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicAdvertisedPrefixesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListPublicAdvertisedPrefixesRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            ListPublicAdvertisedPrefixesRequest request = new ListPublicAdvertisedPrefixesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<PublicAdvertisedPrefixList, PublicAdvertisedPrefix> response = publicAdvertisedPrefixesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublicAdvertisedPrefix item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PublicAdvertisedPrefixList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicAdvertisedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicAdvertisedPrefix> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicAdvertisedPrefix item in singlePage)
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
            // Snippet: ListAsync(ListPublicAdvertisedPrefixesRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            ListPublicAdvertisedPrefixesRequest request = new ListPublicAdvertisedPrefixesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<PublicAdvertisedPrefixList, PublicAdvertisedPrefix> response = publicAdvertisedPrefixesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublicAdvertisedPrefix item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PublicAdvertisedPrefixList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicAdvertisedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicAdvertisedPrefix> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicAdvertisedPrefix item in singlePage)
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
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<PublicAdvertisedPrefixList, PublicAdvertisedPrefix> response = publicAdvertisedPrefixesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublicAdvertisedPrefix item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PublicAdvertisedPrefixList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicAdvertisedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicAdvertisedPrefix> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicAdvertisedPrefix item in singlePage)
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
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<PublicAdvertisedPrefixList, PublicAdvertisedPrefix> response = publicAdvertisedPrefixesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublicAdvertisedPrefix item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PublicAdvertisedPrefixList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicAdvertisedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicAdvertisedPrefix> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicAdvertisedPrefix item in singlePage)
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
            // Snippet: Patch(PatchPublicAdvertisedPrefixeRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            PatchPublicAdvertisedPrefixeRequest request = new PatchPublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = publicAdvertisedPrefixesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicAdvertisedPrefixesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchPublicAdvertisedPrefixeRequest, CallSettings)
            // Additional: PatchAsync(PatchPublicAdvertisedPrefixeRequest, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            PatchPublicAdvertisedPrefixeRequest request = new PatchPublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await publicAdvertisedPrefixesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicAdvertisedPrefixesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, PublicAdvertisedPrefix, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            PublicAdvertisedPrefix publicAdvertisedPrefixResource = new PublicAdvertisedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = publicAdvertisedPrefixesClient.Patch(project, publicAdvertisedPrefix, publicAdvertisedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicAdvertisedPrefixesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, PublicAdvertisedPrefix, CallSettings)
            // Additional: PatchAsync(string, string, PublicAdvertisedPrefix, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            PublicAdvertisedPrefix publicAdvertisedPrefixResource = new PublicAdvertisedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = await publicAdvertisedPrefixesClient.PatchAsync(project, publicAdvertisedPrefix, publicAdvertisedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicAdvertisedPrefixesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Withdraw</summary>
        public void WithdrawRequestObject()
        {
            // Snippet: Withdraw(WithdrawPublicAdvertisedPrefixeRequest, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            WithdrawPublicAdvertisedPrefixeRequest request = new WithdrawPublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = publicAdvertisedPrefixesClient.Withdraw(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicAdvertisedPrefixesClient.PollOnceWithdraw(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for WithdrawAsync</summary>
        public async Task WithdrawRequestObjectAsync()
        {
            // Snippet: WithdrawAsync(WithdrawPublicAdvertisedPrefixeRequest, CallSettings)
            // Additional: WithdrawAsync(WithdrawPublicAdvertisedPrefixeRequest, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            WithdrawPublicAdvertisedPrefixeRequest request = new WithdrawPublicAdvertisedPrefixeRequest
            {
                RequestId = "",
                PublicAdvertisedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await publicAdvertisedPrefixesClient.WithdrawAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicAdvertisedPrefixesClient.PollOnceWithdrawAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Withdraw</summary>
        public void Withdraw()
        {
            // Snippet: Withdraw(string, string, CallSettings)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = PublicAdvertisedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = publicAdvertisedPrefixesClient.Withdraw(project, publicAdvertisedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicAdvertisedPrefixesClient.PollOnceWithdraw(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for WithdrawAsync</summary>
        public async Task WithdrawAsync()
        {
            // Snippet: WithdrawAsync(string, string, CallSettings)
            // Additional: WithdrawAsync(string, string, CancellationToken)
            // Create client
            PublicAdvertisedPrefixesClient publicAdvertisedPrefixesClient = await PublicAdvertisedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicAdvertisedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await publicAdvertisedPrefixesClient.WithdrawAsync(project, publicAdvertisedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicAdvertisedPrefixesClient.PollOnceWithdrawAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
