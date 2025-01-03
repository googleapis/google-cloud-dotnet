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
    public sealed class AllGeneratedPublicDelegatedPrefixesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListPublicDelegatedPrefixesRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            AggregatedListPublicDelegatedPrefixesRequest request = new AggregatedListPublicDelegatedPrefixesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<PublicDelegatedPrefixAggregatedList, KeyValuePair<string, PublicDelegatedPrefixesScopedList>> response = publicDelegatedPrefixesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, PublicDelegatedPrefixesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PublicDelegatedPrefixAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, PublicDelegatedPrefixesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, PublicDelegatedPrefixesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, PublicDelegatedPrefixesScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListPublicDelegatedPrefixesRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListPublicDelegatedPrefixesRequest request = new AggregatedListPublicDelegatedPrefixesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<PublicDelegatedPrefixAggregatedList, KeyValuePair<string, PublicDelegatedPrefixesScopedList>> response = publicDelegatedPrefixesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, PublicDelegatedPrefixesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PublicDelegatedPrefixAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, PublicDelegatedPrefixesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, PublicDelegatedPrefixesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, PublicDelegatedPrefixesScopedList> item in singlePage)
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
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<PublicDelegatedPrefixAggregatedList, KeyValuePair<string, PublicDelegatedPrefixesScopedList>> response = publicDelegatedPrefixesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, PublicDelegatedPrefixesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PublicDelegatedPrefixAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, PublicDelegatedPrefixesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, PublicDelegatedPrefixesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, PublicDelegatedPrefixesScopedList> item in singlePage)
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
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<PublicDelegatedPrefixAggregatedList, KeyValuePair<string, PublicDelegatedPrefixesScopedList>> response = publicDelegatedPrefixesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, PublicDelegatedPrefixesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PublicDelegatedPrefixAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, PublicDelegatedPrefixesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, PublicDelegatedPrefixesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, PublicDelegatedPrefixesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Announce</summary>
        public void AnnounceRequestObject()
        {
            // Snippet: Announce(AnnouncePublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            AnnouncePublicDelegatedPrefixeRequest request = new AnnouncePublicDelegatedPrefixeRequest
            {
                RequestId = "",
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = publicDelegatedPrefixesClient.Announce(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicDelegatedPrefixesClient.PollOnceAnnounce(operationName);
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
            // Snippet: AnnounceAsync(AnnouncePublicDelegatedPrefixeRequest, CallSettings)
            // Additional: AnnounceAsync(AnnouncePublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            AnnouncePublicDelegatedPrefixeRequest request = new AnnouncePublicDelegatedPrefixeRequest
            {
                RequestId = "",
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await publicDelegatedPrefixesClient.AnnounceAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicDelegatedPrefixesClient.PollOnceAnnounceAsync(operationName);
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
            // Snippet: Announce(string, string, string, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = publicDelegatedPrefixesClient.Announce(project, region, publicDelegatedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicDelegatedPrefixesClient.PollOnceAnnounce(operationName);
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
            // Snippet: AnnounceAsync(string, string, string, CallSettings)
            // Additional: AnnounceAsync(string, string, string, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await publicDelegatedPrefixesClient.AnnounceAsync(project, region, publicDelegatedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicDelegatedPrefixesClient.PollOnceAnnounceAsync(operationName);
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
            // Snippet: Delete(DeletePublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            DeletePublicDelegatedPrefixeRequest request = new DeletePublicDelegatedPrefixeRequest
            {
                RequestId = "",
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = publicDelegatedPrefixesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicDelegatedPrefixesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeletePublicDelegatedPrefixeRequest, CallSettings)
            // Additional: DeleteAsync(DeletePublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            DeletePublicDelegatedPrefixeRequest request = new DeletePublicDelegatedPrefixeRequest
            {
                RequestId = "",
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await publicDelegatedPrefixesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicDelegatedPrefixesClient.PollOnceDeleteAsync(operationName);
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
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = publicDelegatedPrefixesClient.Delete(project, region, publicDelegatedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicDelegatedPrefixesClient.PollOnceDelete(operationName);
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
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await publicDelegatedPrefixesClient.DeleteAsync(project, region, publicDelegatedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicDelegatedPrefixesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            GetPublicDelegatedPrefixeRequest request = new GetPublicDelegatedPrefixeRequest
            {
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicDelegatedPrefix response = publicDelegatedPrefixesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: GetAsync(GetPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            GetPublicDelegatedPrefixeRequest request = new GetPublicDelegatedPrefixeRequest
            {
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicDelegatedPrefix response = await publicDelegatedPrefixesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            PublicDelegatedPrefix response = publicDelegatedPrefixesClient.Get(project, region, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            PublicDelegatedPrefix response = await publicDelegatedPrefixesClient.GetAsync(project, region, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            InsertPublicDelegatedPrefixeRequest request = new InsertPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = publicDelegatedPrefixesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicDelegatedPrefixesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: InsertAsync(InsertPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            InsertPublicDelegatedPrefixeRequest request = new InsertPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await publicDelegatedPrefixesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicDelegatedPrefixesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, PublicDelegatedPrefix, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = publicDelegatedPrefixesClient.Insert(project, region, publicDelegatedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicDelegatedPrefixesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, PublicDelegatedPrefix, CallSettings)
            // Additional: InsertAsync(string, string, PublicDelegatedPrefix, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = await publicDelegatedPrefixesClient.InsertAsync(project, region, publicDelegatedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicDelegatedPrefixesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListPublicDelegatedPrefixesRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            ListPublicDelegatedPrefixesRequest request = new ListPublicDelegatedPrefixesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<PublicDelegatedPrefixList, PublicDelegatedPrefix> response = publicDelegatedPrefixesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublicDelegatedPrefix item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PublicDelegatedPrefixList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicDelegatedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicDelegatedPrefix> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicDelegatedPrefix item in singlePage)
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
            // Snippet: ListAsync(ListPublicDelegatedPrefixesRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            ListPublicDelegatedPrefixesRequest request = new ListPublicDelegatedPrefixesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<PublicDelegatedPrefixList, PublicDelegatedPrefix> response = publicDelegatedPrefixesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublicDelegatedPrefix item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PublicDelegatedPrefixList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicDelegatedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicDelegatedPrefix> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicDelegatedPrefix item in singlePage)
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
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<PublicDelegatedPrefixList, PublicDelegatedPrefix> response = publicDelegatedPrefixesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublicDelegatedPrefix item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PublicDelegatedPrefixList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicDelegatedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicDelegatedPrefix> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicDelegatedPrefix item in singlePage)
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
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<PublicDelegatedPrefixList, PublicDelegatedPrefix> response = publicDelegatedPrefixesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublicDelegatedPrefix item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PublicDelegatedPrefixList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicDelegatedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicDelegatedPrefix> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicDelegatedPrefix item in singlePage)
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
            // Snippet: Patch(PatchPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            PatchPublicDelegatedPrefixeRequest request = new PatchPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = publicDelegatedPrefixesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicDelegatedPrefixesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: PatchAsync(PatchPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            PatchPublicDelegatedPrefixeRequest request = new PatchPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await publicDelegatedPrefixesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicDelegatedPrefixesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, PublicDelegatedPrefix, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = publicDelegatedPrefixesClient.Patch(project, region, publicDelegatedPrefix, publicDelegatedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicDelegatedPrefixesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, PublicDelegatedPrefix, CallSettings)
            // Additional: PatchAsync(string, string, string, PublicDelegatedPrefix, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = await publicDelegatedPrefixesClient.PatchAsync(project, region, publicDelegatedPrefix, publicDelegatedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicDelegatedPrefixesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Withdraw(WithdrawPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            WithdrawPublicDelegatedPrefixeRequest request = new WithdrawPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = publicDelegatedPrefixesClient.Withdraw(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicDelegatedPrefixesClient.PollOnceWithdraw(operationName);
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
            // Snippet: WithdrawAsync(WithdrawPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: WithdrawAsync(WithdrawPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            WithdrawPublicDelegatedPrefixeRequest request = new WithdrawPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                Region = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await publicDelegatedPrefixesClient.WithdrawAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicDelegatedPrefixesClient.PollOnceWithdrawAsync(operationName);
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
            // Snippet: Withdraw(string, string, string, CallSettings)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = PublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = publicDelegatedPrefixesClient.Withdraw(project, region, publicDelegatedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = publicDelegatedPrefixesClient.PollOnceWithdraw(operationName);
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
            // Snippet: WithdrawAsync(string, string, string, CallSettings)
            // Additional: WithdrawAsync(string, string, string, CancellationToken)
            // Create client
            PublicDelegatedPrefixesClient publicDelegatedPrefixesClient = await PublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string publicDelegatedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await publicDelegatedPrefixesClient.WithdrawAsync(project, region, publicDelegatedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await publicDelegatedPrefixesClient.PollOnceWithdrawAsync(operationName);
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
