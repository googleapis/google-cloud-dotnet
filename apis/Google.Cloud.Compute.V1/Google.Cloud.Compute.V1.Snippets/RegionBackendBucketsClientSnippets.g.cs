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
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionBackendBucketsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionBackendBucketRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            DeleteRegionBackendBucketRequest request = new DeleteRegionBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendBucketsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendBucketsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionBackendBucketRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionBackendBucketRequest, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionBackendBucketRequest request = new DeleteRegionBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendBucketsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendBucketsClient.PollOnceDeleteAsync(operationName);
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
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendBucket = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendBucketsClient.Delete(project, region, backendBucket);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendBucketsClient.PollOnceDelete(operationName);
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
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendBucket = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendBucketsClient.DeleteAsync(project, region, backendBucket);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendBucketsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionBackendBucketRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            GetRegionBackendBucketRequest request = new GetRegionBackendBucketRequest
            {
                BackendBucket = "",
                Region = "",
                Project = "",
            };
            // Make the request
            BackendBucket response = regionBackendBucketsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionBackendBucketRequest, CallSettings)
            // Additional: GetAsync(GetRegionBackendBucketRequest, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionBackendBucketRequest request = new GetRegionBackendBucketRequest
            {
                BackendBucket = "",
                Region = "",
                Project = "",
            };
            // Make the request
            BackendBucket response = await regionBackendBucketsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendBucket = "";
            // Make the request
            BackendBucket response = regionBackendBucketsClient.Get(project, region, backendBucket);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendBucket = "";
            // Make the request
            BackendBucket response = await regionBackendBucketsClient.GetAsync(project, region, backendBucket);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRegionBackendBucketRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRegionBackendBucketRequest request = new GetIamPolicyRegionBackendBucketRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = regionBackendBucketsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRegionBackendBucketRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRegionBackendBucketRequest, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRegionBackendBucketRequest request = new GetIamPolicyRegionBackendBucketRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await regionBackendBucketsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = regionBackendBucketsClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await regionBackendBucketsClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionBackendBucketRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            InsertRegionBackendBucketRequest request = new InsertRegionBackendBucketRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BackendBucketResource = new BackendBucket(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendBucketsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendBucketsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionBackendBucketRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionBackendBucketRequest, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionBackendBucketRequest request = new InsertRegionBackendBucketRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BackendBucketResource = new BackendBucket(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendBucketsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendBucketsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, BackendBucket, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            BackendBucket backendBucketResource = new BackendBucket();
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendBucketsClient.Insert(project, region, backendBucketResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendBucketsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, BackendBucket, CallSettings)
            // Additional: InsertAsync(string, string, BackendBucket, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            BackendBucket backendBucketResource = new BackendBucket();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendBucketsClient.InsertAsync(project, region, backendBucketResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendBucketsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionBackendBucketsRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            ListRegionBackendBucketsRequest request = new ListRegionBackendBucketsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<BackendBucketList, BackendBucket> response = regionBackendBucketsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendBucketList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
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
            // Snippet: ListAsync(ListRegionBackendBucketsRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionBackendBucketsRequest request = new ListRegionBackendBucketsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<BackendBucketList, BackendBucket> response = regionBackendBucketsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BackendBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (BackendBucketList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
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
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<BackendBucketList, BackendBucket> response = regionBackendBucketsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendBucketList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
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
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<BackendBucketList, BackendBucket> response = regionBackendBucketsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BackendBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (BackendBucketList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsable</summary>
        public void ListUsableRequestObject()
        {
            // Snippet: ListUsable(ListUsableRegionBackendBucketsRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            ListUsableRegionBackendBucketsRequest request = new ListUsableRegionBackendBucketsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<BackendBucketListUsable, BackendBucket> response = regionBackendBucketsClient.ListUsable(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendBucketListUsable page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableAsync</summary>
        public async Task ListUsableRequestObjectAsync()
        {
            // Snippet: ListUsableAsync(ListUsableRegionBackendBucketsRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            ListUsableRegionBackendBucketsRequest request = new ListUsableRegionBackendBucketsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<BackendBucketListUsable, BackendBucket> response = regionBackendBucketsClient.ListUsableAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BackendBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (BackendBucketListUsable page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsable</summary>
        public void ListUsable()
        {
            // Snippet: ListUsable(string, string, string, int?, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<BackendBucketListUsable, BackendBucket> response = regionBackendBucketsClient.ListUsable(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendBucketListUsable page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableAsync</summary>
        public async Task ListUsableAsync()
        {
            // Snippet: ListUsableAsync(string, string, string, int?, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<BackendBucketListUsable, BackendBucket> response = regionBackendBucketsClient.ListUsableAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BackendBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (BackendBucketListUsable page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendBucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendBucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendBucket item in singlePage)
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
            // Snippet: Patch(PatchRegionBackendBucketRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            PatchRegionBackendBucketRequest request = new PatchRegionBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Region = "",
                Project = "",
                BackendBucketResource = new BackendBucket(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendBucketsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendBucketsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRegionBackendBucketRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionBackendBucketRequest, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionBackendBucketRequest request = new PatchRegionBackendBucketRequest
            {
                RequestId = "",
                BackendBucket = "",
                Region = "",
                Project = "",
                BackendBucketResource = new BackendBucket(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendBucketsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendBucketsClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, BackendBucket, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendBucket = "";
            BackendBucket backendBucketResource = new BackendBucket();
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendBucketsClient.Patch(project, region, backendBucket, backendBucketResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendBucketsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, BackendBucket, CallSettings)
            // Additional: PatchAsync(string, string, string, BackendBucket, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendBucket = "";
            BackendBucket backendBucketResource = new BackendBucket();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendBucketsClient.PatchAsync(project, region, backendBucket, backendBucketResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendBucketsClient.PollOncePatchAsync(operationName);
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
            // Snippet: SetIamPolicy(SetIamPolicyRegionBackendBucketRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRegionBackendBucketRequest request = new SetIamPolicyRegionBackendBucketRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = regionBackendBucketsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRegionBackendBucketRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRegionBackendBucketRequest, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRegionBackendBucketRequest request = new SetIamPolicyRegionBackendBucketRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = await regionBackendBucketsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = regionBackendBucketsClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await regionBackendBucketsClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRegionBackendBucketRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRegionBackendBucketRequest request = new TestIamPermissionsRegionBackendBucketRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = regionBackendBucketsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRegionBackendBucketRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRegionBackendBucketRequest, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRegionBackendBucketRequest request = new TestIamPermissionsRegionBackendBucketRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await regionBackendBucketsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = RegionBackendBucketsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = regionBackendBucketsClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            RegionBackendBucketsClient regionBackendBucketsClient = await RegionBackendBucketsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await regionBackendBucketsClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
