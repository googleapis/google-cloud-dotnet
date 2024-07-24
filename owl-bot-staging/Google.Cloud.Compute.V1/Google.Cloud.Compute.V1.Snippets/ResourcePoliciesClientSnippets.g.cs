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
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedResourcePoliciesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListResourcePoliciesRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            AggregatedListResourcePoliciesRequest request = new AggregatedListResourcePoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ResourcePolicyAggregatedList, KeyValuePair<string, ResourcePoliciesScopedList>> response = resourcePoliciesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, ResourcePoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ResourcePolicyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ResourcePoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ResourcePoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ResourcePoliciesScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListResourcePoliciesRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListResourcePoliciesRequest request = new AggregatedListResourcePoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ResourcePolicyAggregatedList, KeyValuePair<string, ResourcePoliciesScopedList>> response = resourcePoliciesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, ResourcePoliciesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ResourcePolicyAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ResourcePoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ResourcePoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ResourcePoliciesScopedList> item in singlePage)
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
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<ResourcePolicyAggregatedList, KeyValuePair<string, ResourcePoliciesScopedList>> response = resourcePoliciesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, ResourcePoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ResourcePolicyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ResourcePoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ResourcePoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ResourcePoliciesScopedList> item in singlePage)
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
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<ResourcePolicyAggregatedList, KeyValuePair<string, ResourcePoliciesScopedList>> response = resourcePoliciesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, ResourcePoliciesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ResourcePolicyAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ResourcePoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ResourcePoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ResourcePoliciesScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteResourcePolicyRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            DeleteResourcePolicyRequest request = new DeleteResourcePolicyRequest
            {
                RequestId = "",
                Region = "",
                ResourcePolicy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = resourcePoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = resourcePoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteResourcePolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteResourcePolicyRequest, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteResourcePolicyRequest request = new DeleteResourcePolicyRequest
            {
                RequestId = "",
                Region = "",
                ResourcePolicy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await resourcePoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await resourcePoliciesClient.PollOnceDeleteAsync(operationName);
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
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resourcePolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = resourcePoliciesClient.Delete(project, region, resourcePolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = resourcePoliciesClient.PollOnceDelete(operationName);
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
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resourcePolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await resourcePoliciesClient.DeleteAsync(project, region, resourcePolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await resourcePoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetResourcePolicyRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            GetResourcePolicyRequest request = new GetResourcePolicyRequest
            {
                Region = "",
                ResourcePolicy = "",
                Project = "",
            };
            // Make the request
            ResourcePolicy response = resourcePoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetResourcePolicyRequest, CallSettings)
            // Additional: GetAsync(GetResourcePolicyRequest, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetResourcePolicyRequest request = new GetResourcePolicyRequest
            {
                Region = "",
                ResourcePolicy = "",
                Project = "",
            };
            // Make the request
            ResourcePolicy response = await resourcePoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resourcePolicy = "";
            // Make the request
            ResourcePolicy response = resourcePoliciesClient.Get(project, region, resourcePolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resourcePolicy = "";
            // Make the request
            ResourcePolicy response = await resourcePoliciesClient.GetAsync(project, region, resourcePolicy);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyResourcePolicyRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyResourcePolicyRequest request = new GetIamPolicyResourcePolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = resourcePoliciesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyResourcePolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyResourcePolicyRequest, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyResourcePolicyRequest request = new GetIamPolicyResourcePolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await resourcePoliciesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = resourcePoliciesClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await resourcePoliciesClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertResourcePolicyRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            InsertResourcePolicyRequest request = new InsertResourcePolicyRequest
            {
                RequestId = "",
                ResourcePolicyResource = new ResourcePolicy(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = resourcePoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = resourcePoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertResourcePolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertResourcePolicyRequest, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertResourcePolicyRequest request = new InsertResourcePolicyRequest
            {
                RequestId = "",
                ResourcePolicyResource = new ResourcePolicy(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await resourcePoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await resourcePoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, ResourcePolicy, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            ResourcePolicy resourcePolicyResource = new ResourcePolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = resourcePoliciesClient.Insert(project, region, resourcePolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = resourcePoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, ResourcePolicy, CallSettings)
            // Additional: InsertAsync(string, string, ResourcePolicy, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            ResourcePolicy resourcePolicyResource = new ResourcePolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await resourcePoliciesClient.InsertAsync(project, region, resourcePolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await resourcePoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListResourcePoliciesRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            ListResourcePoliciesRequest request = new ListResourcePoliciesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ResourcePolicyList, ResourcePolicy> response = resourcePoliciesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourcePolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ResourcePolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourcePolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourcePolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourcePolicy item in singlePage)
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
            // Snippet: ListAsync(ListResourcePoliciesRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListResourcePoliciesRequest request = new ListResourcePoliciesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ResourcePolicyList, ResourcePolicy> response = resourcePoliciesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourcePolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ResourcePolicyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourcePolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourcePolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourcePolicy item in singlePage)
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
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<ResourcePolicyList, ResourcePolicy> response = resourcePoliciesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourcePolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ResourcePolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourcePolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourcePolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourcePolicy item in singlePage)
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
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<ResourcePolicyList, ResourcePolicy> response = resourcePoliciesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourcePolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ResourcePolicyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourcePolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourcePolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourcePolicy item in singlePage)
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
            // Snippet: Patch(PatchResourcePolicyRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            PatchResourcePolicyRequest request = new PatchResourcePolicyRequest
            {
                RequestId = "",
                ResourcePolicyResource = new ResourcePolicy(),
                Region = "",
                ResourcePolicy = "",
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = resourcePoliciesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = resourcePoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchResourcePolicyRequest, CallSettings)
            // Additional: PatchAsync(PatchResourcePolicyRequest, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchResourcePolicyRequest request = new PatchResourcePolicyRequest
            {
                RequestId = "",
                ResourcePolicyResource = new ResourcePolicy(),
                Region = "",
                ResourcePolicy = "",
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await resourcePoliciesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await resourcePoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, ResourcePolicy, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resourcePolicy = "";
            ResourcePolicy resourcePolicyResource = new ResourcePolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = resourcePoliciesClient.Patch(project, region, resourcePolicy, resourcePolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = resourcePoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, ResourcePolicy, CallSettings)
            // Additional: PatchAsync(string, string, string, ResourcePolicy, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resourcePolicy = "";
            ResourcePolicy resourcePolicyResource = new ResourcePolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await resourcePoliciesClient.PatchAsync(project, region, resourcePolicy, resourcePolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await resourcePoliciesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyResourcePolicyRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyResourcePolicyRequest request = new SetIamPolicyResourcePolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = resourcePoliciesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyResourcePolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyResourcePolicyRequest, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyResourcePolicyRequest request = new SetIamPolicyResourcePolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = await resourcePoliciesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = resourcePoliciesClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await resourcePoliciesClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsResourcePolicyRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsResourcePolicyRequest request = new TestIamPermissionsResourcePolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = resourcePoliciesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsResourcePolicyRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsResourcePolicyRequest, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsResourcePolicyRequest request = new TestIamPermissionsResourcePolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await resourcePoliciesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = ResourcePoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = resourcePoliciesClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            ResourcePoliciesClient resourcePoliciesClient = await ResourcePoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await resourcePoliciesClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
