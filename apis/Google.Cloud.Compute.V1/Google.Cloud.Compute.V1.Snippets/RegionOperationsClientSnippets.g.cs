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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionOperationsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionOperationRequest, CallSettings)
            // Create client
            RegionOperationsClient regionOperationsClient = RegionOperationsClient.Create();
            // Initialize request argument(s)
            DeleteRegionOperationRequest request = new DeleteRegionOperationRequest
            {
                Operation = "",
                Region = "",
                Project = "",
            };
            // Make the request
            DeleteRegionOperationResponse response = regionOperationsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteRegionOperationRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionOperationRequest, CancellationToken)
            // Create client
            RegionOperationsClient regionOperationsClient = await RegionOperationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionOperationRequest request = new DeleteRegionOperationRequest
            {
                Operation = "",
                Region = "",
                Project = "",
            };
            // Make the request
            DeleteRegionOperationResponse response = await regionOperationsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            RegionOperationsClient regionOperationsClient = RegionOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string operation = "";
            // Make the request
            DeleteRegionOperationResponse response = regionOperationsClient.Delete(project, region, operation);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            RegionOperationsClient regionOperationsClient = await RegionOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string operation = "";
            // Make the request
            DeleteRegionOperationResponse response = await regionOperationsClient.DeleteAsync(project, region, operation);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionOperationRequest, CallSettings)
            // Create client
            RegionOperationsClient regionOperationsClient = RegionOperationsClient.Create();
            // Initialize request argument(s)
            GetRegionOperationRequest request = new GetRegionOperationRequest
            {
                Operation = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = regionOperationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionOperationRequest, CallSettings)
            // Additional: GetAsync(GetRegionOperationRequest, CancellationToken)
            // Create client
            RegionOperationsClient regionOperationsClient = await RegionOperationsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionOperationRequest request = new GetRegionOperationRequest
            {
                Operation = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await regionOperationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionOperationsClient regionOperationsClient = RegionOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string operation = "";
            // Make the request
            Operation response = regionOperationsClient.Get(project, region, operation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionOperationsClient regionOperationsClient = await RegionOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string operation = "";
            // Make the request
            Operation response = await regionOperationsClient.GetAsync(project, region, operation);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionOperationsRequest, CallSettings)
            // Create client
            RegionOperationsClient regionOperationsClient = RegionOperationsClient.Create();
            // Initialize request argument(s)
            ListRegionOperationsRequest request = new ListRegionOperationsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<OperationList, Operation> response = regionOperationsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (OperationList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
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
            // Snippet: ListAsync(ListRegionOperationsRequest, CallSettings)
            // Create client
            RegionOperationsClient regionOperationsClient = await RegionOperationsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionOperationsRequest request = new ListRegionOperationsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<OperationList, Operation> response = regionOperationsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((OperationList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
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
            RegionOperationsClient regionOperationsClient = RegionOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<OperationList, Operation> response = regionOperationsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (OperationList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
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
            RegionOperationsClient regionOperationsClient = await RegionOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<OperationList, Operation> response = regionOperationsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((OperationList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Wait</summary>
        public void WaitRequestObject()
        {
            // Snippet: Wait(WaitRegionOperationRequest, CallSettings)
            // Create client
            RegionOperationsClient regionOperationsClient = RegionOperationsClient.Create();
            // Initialize request argument(s)
            WaitRegionOperationRequest request = new WaitRegionOperationRequest
            {
                Operation = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = regionOperationsClient.Wait(request);
            // End snippet
        }

        /// <summary>Snippet for WaitAsync</summary>
        public async Task WaitRequestObjectAsync()
        {
            // Snippet: WaitAsync(WaitRegionOperationRequest, CallSettings)
            // Additional: WaitAsync(WaitRegionOperationRequest, CancellationToken)
            // Create client
            RegionOperationsClient regionOperationsClient = await RegionOperationsClient.CreateAsync();
            // Initialize request argument(s)
            WaitRegionOperationRequest request = new WaitRegionOperationRequest
            {
                Operation = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await regionOperationsClient.WaitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Wait</summary>
        public void Wait()
        {
            // Snippet: Wait(string, string, string, CallSettings)
            // Create client
            RegionOperationsClient regionOperationsClient = RegionOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string operation = "";
            // Make the request
            Operation response = regionOperationsClient.Wait(project, region, operation);
            // End snippet
        }

        /// <summary>Snippet for WaitAsync</summary>
        public async Task WaitAsync()
        {
            // Snippet: WaitAsync(string, string, string, CallSettings)
            // Additional: WaitAsync(string, string, string, CancellationToken)
            // Create client
            RegionOperationsClient regionOperationsClient = await RegionOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string operation = "";
            // Make the request
            Operation response = await regionOperationsClient.WaitAsync(project, region, operation);
            // End snippet
        }
    }
}
