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
    public sealed class AllGeneratedRegionSslPoliciesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionSslPolicyRequest, CallSettings)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteRegionSslPolicyRequest request = new DeleteRegionSslPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                SslPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSslPoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSslPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionSslPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionSslPolicyRequest, CancellationToken)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionSslPolicyRequest request = new DeleteRegionSslPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                SslPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSslPoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSslPoliciesClient.PollOnceDeleteAsync(operationName);
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
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string sslPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionSslPoliciesClient.Delete(project, region, sslPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSslPoliciesClient.PollOnceDelete(operationName);
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
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string sslPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSslPoliciesClient.DeleteAsync(project, region, sslPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSslPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionSslPolicyRequest, CallSettings)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            GetRegionSslPolicyRequest request = new GetRegionSslPolicyRequest
            {
                Region = "",
                Project = "",
                SslPolicy = "",
            };
            // Make the request
            SslPolicy response = regionSslPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionSslPolicyRequest, CallSettings)
            // Additional: GetAsync(GetRegionSslPolicyRequest, CancellationToken)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionSslPolicyRequest request = new GetRegionSslPolicyRequest
            {
                Region = "",
                Project = "",
                SslPolicy = "",
            };
            // Make the request
            SslPolicy response = await regionSslPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string sslPolicy = "";
            // Make the request
            SslPolicy response = regionSslPoliciesClient.Get(project, region, sslPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string sslPolicy = "";
            // Make the request
            SslPolicy response = await regionSslPoliciesClient.GetAsync(project, region, sslPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionSslPolicyRequest, CallSettings)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            InsertRegionSslPolicyRequest request = new InsertRegionSslPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                SslPolicyResource = new SslPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSslPoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSslPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionSslPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionSslPolicyRequest, CancellationToken)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionSslPolicyRequest request = new InsertRegionSslPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                SslPolicyResource = new SslPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSslPoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSslPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, SslPolicy, CallSettings)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionSslPoliciesClient.Insert(project, region, sslPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSslPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, SslPolicy, CallSettings)
            // Additional: InsertAsync(string, string, SslPolicy, CancellationToken)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSslPoliciesClient.InsertAsync(project, region, sslPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSslPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionSslPoliciesRequest, CallSettings)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            ListRegionSslPoliciesRequest request = new ListRegionSslPoliciesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<SslPoliciesList, SslPolicy> response = regionSslPoliciesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SslPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SslPoliciesList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslPolicy item in singlePage)
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
            // Snippet: ListAsync(ListRegionSslPoliciesRequest, CallSettings)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionSslPoliciesRequest request = new ListRegionSslPoliciesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<SslPoliciesList, SslPolicy> response = regionSslPoliciesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SslPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SslPoliciesList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslPolicy item in singlePage)
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
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<SslPoliciesList, SslPolicy> response = regionSslPoliciesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SslPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SslPoliciesList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslPolicy item in singlePage)
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
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<SslPoliciesList, SslPolicy> response = regionSslPoliciesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SslPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SslPoliciesList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeatures</summary>
        public void ListAvailableFeaturesRequestObject()
        {
            // Snippet: ListAvailableFeatures(ListAvailableFeaturesRegionSslPoliciesRequest, CallSettings)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            ListAvailableFeaturesRegionSslPoliciesRequest request = new ListAvailableFeaturesRegionSslPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = regionSslPoliciesClient.ListAvailableFeatures(request);
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeaturesAsync</summary>
        public async Task ListAvailableFeaturesRequestObjectAsync()
        {
            // Snippet: ListAvailableFeaturesAsync(ListAvailableFeaturesRegionSslPoliciesRequest, CallSettings)
            // Additional: ListAvailableFeaturesAsync(ListAvailableFeaturesRegionSslPoliciesRequest, CancellationToken)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListAvailableFeaturesRegionSslPoliciesRequest request = new ListAvailableFeaturesRegionSslPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = await regionSslPoliciesClient.ListAvailableFeaturesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeatures</summary>
        public void ListAvailableFeatures()
        {
            // Snippet: ListAvailableFeatures(string, string, CallSettings)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = regionSslPoliciesClient.ListAvailableFeatures(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeaturesAsync</summary>
        public async Task ListAvailableFeaturesAsync()
        {
            // Snippet: ListAvailableFeaturesAsync(string, string, CallSettings)
            // Additional: ListAvailableFeaturesAsync(string, string, CancellationToken)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = await regionSslPoliciesClient.ListAvailableFeaturesAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchRegionSslPolicyRequest, CallSettings)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            PatchRegionSslPolicyRequest request = new PatchRegionSslPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                SslPolicyResource = new SslPolicy(),
                SslPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSslPoliciesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSslPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRegionSslPolicyRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionSslPolicyRequest, CancellationToken)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionSslPolicyRequest request = new PatchRegionSslPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                SslPolicyResource = new SslPolicy(),
                SslPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSslPoliciesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSslPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, SslPolicy, CallSettings)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = RegionSslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string sslPolicy = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionSslPoliciesClient.Patch(project, region, sslPolicy, sslPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSslPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, SslPolicy, CallSettings)
            // Additional: PatchAsync(string, string, string, SslPolicy, CancellationToken)
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string sslPolicy = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSslPoliciesClient.PatchAsync(project, region, sslPolicy, sslPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSslPoliciesClient.PollOncePatchAsync(operationName);
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
