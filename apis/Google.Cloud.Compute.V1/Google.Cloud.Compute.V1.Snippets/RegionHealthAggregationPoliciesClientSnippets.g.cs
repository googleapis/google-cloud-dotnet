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
    public sealed class AllGeneratedRegionHealthAggregationPoliciesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListRegionHealthAggregationPoliciesRequest, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            AggregatedListRegionHealthAggregationPoliciesRequest request = new AggregatedListRegionHealthAggregationPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<HealthAggregationPolicyAggregatedList, KeyValuePair<string, HealthAggregationPoliciesScopedList>> response = regionHealthAggregationPoliciesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HealthAggregationPolicyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, HealthAggregationPoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListRegionHealthAggregationPoliciesRequest, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListRegionHealthAggregationPoliciesRequest request = new AggregatedListRegionHealthAggregationPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<HealthAggregationPolicyAggregatedList, KeyValuePair<string, HealthAggregationPoliciesScopedList>> response = regionHealthAggregationPoliciesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (HealthAggregationPolicyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, HealthAggregationPoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in singlePage)
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
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<HealthAggregationPolicyAggregatedList, KeyValuePair<string, HealthAggregationPoliciesScopedList>> response = regionHealthAggregationPoliciesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HealthAggregationPolicyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, HealthAggregationPoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in singlePage)
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
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<HealthAggregationPolicyAggregatedList, KeyValuePair<string, HealthAggregationPoliciesScopedList>> response = regionHealthAggregationPoliciesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (HealthAggregationPolicyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, HealthAggregationPoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, HealthAggregationPoliciesScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteRegionHealthAggregationPolicyRequest, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteRegionHealthAggregationPolicyRequest request = new DeleteRegionHealthAggregationPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthAggregationPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthAggregationPoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthAggregationPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionHealthAggregationPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionHealthAggregationPolicyRequest, CancellationToken)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionHealthAggregationPolicyRequest request = new DeleteRegionHealthAggregationPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthAggregationPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthAggregationPoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthAggregationPoliciesClient.PollOnceDeleteAsync(operationName);
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
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthAggregationPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthAggregationPoliciesClient.Delete(project, region, healthAggregationPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthAggregationPoliciesClient.PollOnceDelete(operationName);
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
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthAggregationPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthAggregationPoliciesClient.DeleteAsync(project, region, healthAggregationPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthAggregationPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionHealthAggregationPolicyRequest, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            GetRegionHealthAggregationPolicyRequest request = new GetRegionHealthAggregationPolicyRequest
            {
                Region = "",
                Project = "",
                HealthAggregationPolicy = "",
            };
            // Make the request
            HealthAggregationPolicy response = regionHealthAggregationPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionHealthAggregationPolicyRequest, CallSettings)
            // Additional: GetAsync(GetRegionHealthAggregationPolicyRequest, CancellationToken)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionHealthAggregationPolicyRequest request = new GetRegionHealthAggregationPolicyRequest
            {
                Region = "",
                Project = "",
                HealthAggregationPolicy = "",
            };
            // Make the request
            HealthAggregationPolicy response = await regionHealthAggregationPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthAggregationPolicy = "";
            // Make the request
            HealthAggregationPolicy response = regionHealthAggregationPoliciesClient.Get(project, region, healthAggregationPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthAggregationPolicy = "";
            // Make the request
            HealthAggregationPolicy response = await regionHealthAggregationPoliciesClient.GetAsync(project, region, healthAggregationPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionHealthAggregationPolicyRequest, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            InsertRegionHealthAggregationPolicyRequest request = new InsertRegionHealthAggregationPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthAggregationPolicyResource = new HealthAggregationPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthAggregationPoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthAggregationPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionHealthAggregationPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionHealthAggregationPolicyRequest, CancellationToken)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionHealthAggregationPolicyRequest request = new InsertRegionHealthAggregationPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthAggregationPolicyResource = new HealthAggregationPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthAggregationPoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthAggregationPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, HealthAggregationPolicy, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            HealthAggregationPolicy healthAggregationPolicyResource = new HealthAggregationPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthAggregationPoliciesClient.Insert(project, region, healthAggregationPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthAggregationPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, HealthAggregationPolicy, CallSettings)
            // Additional: InsertAsync(string, string, HealthAggregationPolicy, CancellationToken)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            HealthAggregationPolicy healthAggregationPolicyResource = new HealthAggregationPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthAggregationPoliciesClient.InsertAsync(project, region, healthAggregationPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthAggregationPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionHealthAggregationPoliciesRequest, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            ListRegionHealthAggregationPoliciesRequest request = new ListRegionHealthAggregationPoliciesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<HealthAggregationPolicyList, HealthAggregationPolicy> response = regionHealthAggregationPoliciesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HealthAggregationPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HealthAggregationPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthAggregationPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthAggregationPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthAggregationPolicy item in singlePage)
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
            // Snippet: ListAsync(ListRegionHealthAggregationPoliciesRequest, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionHealthAggregationPoliciesRequest request = new ListRegionHealthAggregationPoliciesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<HealthAggregationPolicyList, HealthAggregationPolicy> response = regionHealthAggregationPoliciesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (HealthAggregationPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (HealthAggregationPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthAggregationPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthAggregationPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthAggregationPolicy item in singlePage)
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
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<HealthAggregationPolicyList, HealthAggregationPolicy> response = regionHealthAggregationPoliciesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HealthAggregationPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HealthAggregationPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthAggregationPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthAggregationPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthAggregationPolicy item in singlePage)
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
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<HealthAggregationPolicyList, HealthAggregationPolicy> response = regionHealthAggregationPoliciesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (HealthAggregationPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (HealthAggregationPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthAggregationPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthAggregationPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthAggregationPolicy item in singlePage)
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
            // Snippet: Patch(PatchRegionHealthAggregationPolicyRequest, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            PatchRegionHealthAggregationPolicyRequest request = new PatchRegionHealthAggregationPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthAggregationPolicy = "",
                HealthAggregationPolicyResource = new HealthAggregationPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthAggregationPoliciesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthAggregationPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRegionHealthAggregationPolicyRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionHealthAggregationPolicyRequest, CancellationToken)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionHealthAggregationPolicyRequest request = new PatchRegionHealthAggregationPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthAggregationPolicy = "",
                HealthAggregationPolicyResource = new HealthAggregationPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthAggregationPoliciesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthAggregationPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, HealthAggregationPolicy, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthAggregationPolicy = "";
            HealthAggregationPolicy healthAggregationPolicyResource = new HealthAggregationPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthAggregationPoliciesClient.Patch(project, region, healthAggregationPolicy, healthAggregationPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthAggregationPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, HealthAggregationPolicy, CallSettings)
            // Additional: PatchAsync(string, string, string, HealthAggregationPolicy, CancellationToken)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthAggregationPolicy = "";
            HealthAggregationPolicy healthAggregationPolicyResource = new HealthAggregationPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthAggregationPoliciesClient.PatchAsync(project, region, healthAggregationPolicy, healthAggregationPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthAggregationPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: TestIamPermissions(TestIamPermissionsRegionHealthAggregationPolicyRequest, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRegionHealthAggregationPolicyRequest request = new TestIamPermissionsRegionHealthAggregationPolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = regionHealthAggregationPoliciesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRegionHealthAggregationPolicyRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRegionHealthAggregationPolicyRequest, CancellationToken)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRegionHealthAggregationPolicyRequest request = new TestIamPermissionsRegionHealthAggregationPolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await regionHealthAggregationPoliciesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = RegionHealthAggregationPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = regionHealthAggregationPoliciesClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            RegionHealthAggregationPoliciesClient regionHealthAggregationPoliciesClient = await RegionHealthAggregationPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await regionHealthAggregationPoliciesClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
