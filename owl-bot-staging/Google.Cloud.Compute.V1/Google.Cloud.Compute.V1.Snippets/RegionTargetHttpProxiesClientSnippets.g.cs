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
    public sealed class AllGeneratedRegionTargetHttpProxiesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionTargetHttpProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            DeleteRegionTargetHttpProxyRequest request = new DeleteRegionTargetHttpProxyRequest
            {
                RequestId = "",
                Region = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpProxiesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpProxiesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionTargetHttpProxyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionTargetHttpProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionTargetHttpProxyRequest request = new DeleteRegionTargetHttpProxyRequest
            {
                RequestId = "",
                Region = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpProxiesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpProxiesClient.PollOnceDeleteAsync(operationName);
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
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpProxiesClient.Delete(project, region, targetHttpProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpProxiesClient.PollOnceDelete(operationName);
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
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpProxiesClient.DeleteAsync(project, region, targetHttpProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpProxiesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionTargetHttpProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            TargetHttpProxy response = regionTargetHttpProxiesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionTargetHttpProxyRequest, CallSettings)
            // Additional: GetAsync(GetRegionTargetHttpProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionTargetHttpProxyRequest request = new GetRegionTargetHttpProxyRequest
            {
                Region = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            TargetHttpProxy response = await regionTargetHttpProxiesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            // Make the request
            TargetHttpProxy response = regionTargetHttpProxiesClient.Get(project, region, targetHttpProxy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            // Make the request
            TargetHttpProxy response = await regionTargetHttpProxiesClient.GetAsync(project, region, targetHttpProxy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionTargetHttpProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            InsertRegionTargetHttpProxyRequest request = new InsertRegionTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpProxiesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionTargetHttpProxyRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionTargetHttpProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionTargetHttpProxyRequest request = new InsertRegionTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpProxiesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, TargetHttpProxy, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetHttpProxy targetHttpProxyResource = new TargetHttpProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpProxiesClient.Insert(project, region, targetHttpProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, TargetHttpProxy, CallSettings)
            // Additional: InsertAsync(string, string, TargetHttpProxy, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetHttpProxy targetHttpProxyResource = new TargetHttpProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpProxiesClient.InsertAsync(project, region, targetHttpProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionTargetHttpProxiesRequest, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            ListRegionTargetHttpProxiesRequest request = new ListRegionTargetHttpProxiesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetHttpProxyList, TargetHttpProxy> response = regionTargetHttpProxiesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetHttpProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpProxy item in singlePage)
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
            // Snippet: ListAsync(ListRegionTargetHttpProxiesRequest, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionTargetHttpProxiesRequest request = new ListRegionTargetHttpProxiesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetHttpProxyList, TargetHttpProxy> response = regionTargetHttpProxiesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetHttpProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpProxy item in singlePage)
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
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<TargetHttpProxyList, TargetHttpProxy> response = regionTargetHttpProxiesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetHttpProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpProxy item in singlePage)
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
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<TargetHttpProxyList, TargetHttpProxy> response = regionTargetHttpProxiesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetHttpProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpProxy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SetUrlMap</summary>
        public void SetUrlMapRequestObject()
        {
            // Snippet: SetUrlMap(SetUrlMapRegionTargetHttpProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            SetUrlMapRegionTargetHttpProxyRequest request = new SetUrlMapRegionTargetHttpProxyRequest
            {
                RequestId = "",
                Region = "",
                TargetHttpProxy = "",
                Project = "",
                UrlMapReferenceResource = new UrlMapReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpProxiesClient.SetUrlMap(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpProxiesClient.PollOnceSetUrlMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUrlMapAsync</summary>
        public async Task SetUrlMapRequestObjectAsync()
        {
            // Snippet: SetUrlMapAsync(SetUrlMapRegionTargetHttpProxyRequest, CallSettings)
            // Additional: SetUrlMapAsync(SetUrlMapRegionTargetHttpProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetUrlMapRegionTargetHttpProxyRequest request = new SetUrlMapRegionTargetHttpProxyRequest
            {
                RequestId = "",
                Region = "",
                TargetHttpProxy = "",
                Project = "",
                UrlMapReferenceResource = new UrlMapReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpProxiesClient.SetUrlMapAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpProxiesClient.PollOnceSetUrlMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUrlMap</summary>
        public void SetUrlMap()
        {
            // Snippet: SetUrlMap(string, string, string, UrlMapReference, CallSettings)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = RegionTargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            UrlMapReference urlMapReferenceResource = new UrlMapReference();
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpProxiesClient.SetUrlMap(project, region, targetHttpProxy, urlMapReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpProxiesClient.PollOnceSetUrlMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUrlMapAsync</summary>
        public async Task SetUrlMapAsync()
        {
            // Snippet: SetUrlMapAsync(string, string, string, UrlMapReference, CallSettings)
            // Additional: SetUrlMapAsync(string, string, string, UrlMapReference, CancellationToken)
            // Create client
            RegionTargetHttpProxiesClient regionTargetHttpProxiesClient = await RegionTargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpProxy = "";
            UrlMapReference urlMapReferenceResource = new UrlMapReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpProxiesClient.SetUrlMapAsync(project, region, targetHttpProxy, urlMapReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpProxiesClient.PollOnceSetUrlMapAsync(operationName);
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
