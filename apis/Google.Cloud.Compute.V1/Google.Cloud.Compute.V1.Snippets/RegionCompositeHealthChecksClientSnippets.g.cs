// Copyright 2026 Google LLC
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
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionCompositeHealthChecksClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListRegionCompositeHealthChecksRequest, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            AggregatedListRegionCompositeHealthChecksRequest request = new AggregatedListRegionCompositeHealthChecksRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<CompositeHealthCheckAggregatedList, KeyValuePair<string, CompositeHealthChecksScopedList>> response = regionCompositeHealthChecksClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (CompositeHealthCheckAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, CompositeHealthChecksScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListRegionCompositeHealthChecksRequest, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListRegionCompositeHealthChecksRequest request = new AggregatedListRegionCompositeHealthChecksRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<CompositeHealthCheckAggregatedList, KeyValuePair<string, CompositeHealthChecksScopedList>> response = regionCompositeHealthChecksClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (CompositeHealthCheckAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, CompositeHealthChecksScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in singlePage)
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
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<CompositeHealthCheckAggregatedList, KeyValuePair<string, CompositeHealthChecksScopedList>> response = regionCompositeHealthChecksClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (CompositeHealthCheckAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, CompositeHealthChecksScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in singlePage)
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
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<CompositeHealthCheckAggregatedList, KeyValuePair<string, CompositeHealthChecksScopedList>> response = regionCompositeHealthChecksClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (CompositeHealthCheckAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, CompositeHealthChecksScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, CompositeHealthChecksScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteRegionCompositeHealthCheckRequest, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            DeleteRegionCompositeHealthCheckRequest request = new DeleteRegionCompositeHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                CompositeHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionCompositeHealthChecksClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionCompositeHealthChecksClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionCompositeHealthCheckRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionCompositeHealthCheckRequest, CancellationToken)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionCompositeHealthCheckRequest request = new DeleteRegionCompositeHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                CompositeHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionCompositeHealthChecksClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionCompositeHealthChecksClient.PollOnceDeleteAsync(operationName);
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
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string compositeHealthCheck = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionCompositeHealthChecksClient.Delete(project, region, compositeHealthCheck);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionCompositeHealthChecksClient.PollOnceDelete(operationName);
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
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string compositeHealthCheck = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionCompositeHealthChecksClient.DeleteAsync(project, region, compositeHealthCheck);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionCompositeHealthChecksClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionCompositeHealthCheckRequest, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            GetRegionCompositeHealthCheckRequest request = new GetRegionCompositeHealthCheckRequest
            {
                Region = "",
                Project = "",
                CompositeHealthCheck = "",
            };
            // Make the request
            CompositeHealthCheck response = regionCompositeHealthChecksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionCompositeHealthCheckRequest, CallSettings)
            // Additional: GetAsync(GetRegionCompositeHealthCheckRequest, CancellationToken)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionCompositeHealthCheckRequest request = new GetRegionCompositeHealthCheckRequest
            {
                Region = "",
                Project = "",
                CompositeHealthCheck = "",
            };
            // Make the request
            CompositeHealthCheck response = await regionCompositeHealthChecksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string compositeHealthCheck = "";
            // Make the request
            CompositeHealthCheck response = regionCompositeHealthChecksClient.Get(project, region, compositeHealthCheck);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string compositeHealthCheck = "";
            // Make the request
            CompositeHealthCheck response = await regionCompositeHealthChecksClient.GetAsync(project, region, compositeHealthCheck);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealthRequestObject()
        {
            // Snippet: GetHealth(GetHealthRegionCompositeHealthCheckRequest, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            GetHealthRegionCompositeHealthCheckRequest request = new GetHealthRegionCompositeHealthCheckRequest
            {
                Region = "",
                Project = "",
                CompositeHealthCheck = "",
            };
            // Make the request
            CompositeHealthCheckHealth response = regionCompositeHealthChecksClient.GetHealth(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthRequestObjectAsync()
        {
            // Snippet: GetHealthAsync(GetHealthRegionCompositeHealthCheckRequest, CallSettings)
            // Additional: GetHealthAsync(GetHealthRegionCompositeHealthCheckRequest, CancellationToken)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            GetHealthRegionCompositeHealthCheckRequest request = new GetHealthRegionCompositeHealthCheckRequest
            {
                Region = "",
                Project = "",
                CompositeHealthCheck = "",
            };
            // Make the request
            CompositeHealthCheckHealth response = await regionCompositeHealthChecksClient.GetHealthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealth()
        {
            // Snippet: GetHealth(string, string, string, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string compositeHealthCheck = "";
            // Make the request
            CompositeHealthCheckHealth response = regionCompositeHealthChecksClient.GetHealth(project, region, compositeHealthCheck);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthAsync()
        {
            // Snippet: GetHealthAsync(string, string, string, CallSettings)
            // Additional: GetHealthAsync(string, string, string, CancellationToken)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string compositeHealthCheck = "";
            // Make the request
            CompositeHealthCheckHealth response = await regionCompositeHealthChecksClient.GetHealthAsync(project, region, compositeHealthCheck);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionCompositeHealthCheckRequest, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            InsertRegionCompositeHealthCheckRequest request = new InsertRegionCompositeHealthCheckRequest
            {
                RequestId = "",
                CompositeHealthCheckResource = new CompositeHealthCheck(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionCompositeHealthChecksClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionCompositeHealthChecksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionCompositeHealthCheckRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionCompositeHealthCheckRequest, CancellationToken)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionCompositeHealthCheckRequest request = new InsertRegionCompositeHealthCheckRequest
            {
                RequestId = "",
                CompositeHealthCheckResource = new CompositeHealthCheck(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionCompositeHealthChecksClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionCompositeHealthChecksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, CompositeHealthCheck, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            CompositeHealthCheck compositeHealthCheckResource = new CompositeHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = regionCompositeHealthChecksClient.Insert(project, region, compositeHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionCompositeHealthChecksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, CompositeHealthCheck, CallSettings)
            // Additional: InsertAsync(string, string, CompositeHealthCheck, CancellationToken)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            CompositeHealthCheck compositeHealthCheckResource = new CompositeHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionCompositeHealthChecksClient.InsertAsync(project, region, compositeHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionCompositeHealthChecksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionCompositeHealthChecksRequest, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            ListRegionCompositeHealthChecksRequest request = new ListRegionCompositeHealthChecksRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<CompositeHealthCheckList, CompositeHealthCheck> response = regionCompositeHealthChecksClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CompositeHealthCheck item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (CompositeHealthCheckList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompositeHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompositeHealthCheck> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompositeHealthCheck item in singlePage)
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
            // Snippet: ListAsync(ListRegionCompositeHealthChecksRequest, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionCompositeHealthChecksRequest request = new ListRegionCompositeHealthChecksRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<CompositeHealthCheckList, CompositeHealthCheck> response = regionCompositeHealthChecksClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CompositeHealthCheck item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (CompositeHealthCheckList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompositeHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompositeHealthCheck> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompositeHealthCheck item in singlePage)
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
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<CompositeHealthCheckList, CompositeHealthCheck> response = regionCompositeHealthChecksClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CompositeHealthCheck item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (CompositeHealthCheckList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompositeHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompositeHealthCheck> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompositeHealthCheck item in singlePage)
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
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<CompositeHealthCheckList, CompositeHealthCheck> response = regionCompositeHealthChecksClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CompositeHealthCheck item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (CompositeHealthCheckList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompositeHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompositeHealthCheck> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompositeHealthCheck item in singlePage)
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
            // Snippet: Patch(PatchRegionCompositeHealthCheckRequest, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            PatchRegionCompositeHealthCheckRequest request = new PatchRegionCompositeHealthCheckRequest
            {
                RequestId = "",
                CompositeHealthCheckResource = new CompositeHealthCheck(),
                Region = "",
                Project = "",
                CompositeHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionCompositeHealthChecksClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionCompositeHealthChecksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRegionCompositeHealthCheckRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionCompositeHealthCheckRequest, CancellationToken)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionCompositeHealthCheckRequest request = new PatchRegionCompositeHealthCheckRequest
            {
                RequestId = "",
                CompositeHealthCheckResource = new CompositeHealthCheck(),
                Region = "",
                Project = "",
                CompositeHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionCompositeHealthChecksClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionCompositeHealthChecksClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, CompositeHealthCheck, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string compositeHealthCheck = "";
            CompositeHealthCheck compositeHealthCheckResource = new CompositeHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = regionCompositeHealthChecksClient.Patch(project, region, compositeHealthCheck, compositeHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionCompositeHealthChecksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, CompositeHealthCheck, CallSettings)
            // Additional: PatchAsync(string, string, string, CompositeHealthCheck, CancellationToken)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string compositeHealthCheck = "";
            CompositeHealthCheck compositeHealthCheckResource = new CompositeHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionCompositeHealthChecksClient.PatchAsync(project, region, compositeHealthCheck, compositeHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionCompositeHealthChecksClient.PollOncePatchAsync(operationName);
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
            // Snippet: TestIamPermissions(TestIamPermissionsRegionCompositeHealthCheckRequest, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRegionCompositeHealthCheckRequest request = new TestIamPermissionsRegionCompositeHealthCheckRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = regionCompositeHealthChecksClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRegionCompositeHealthCheckRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRegionCompositeHealthCheckRequest, CancellationToken)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRegionCompositeHealthCheckRequest request = new TestIamPermissionsRegionCompositeHealthCheckRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await regionCompositeHealthChecksClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = RegionCompositeHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = regionCompositeHealthChecksClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            RegionCompositeHealthChecksClient regionCompositeHealthChecksClient = await RegionCompositeHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await regionCompositeHealthChecksClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
