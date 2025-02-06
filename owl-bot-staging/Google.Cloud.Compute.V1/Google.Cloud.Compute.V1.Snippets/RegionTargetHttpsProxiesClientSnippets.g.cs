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
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionTargetHttpsProxiesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionTargetHttpsProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            DeleteRegionTargetHttpsProxyRequest request = new DeleteRegionTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpsProxiesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpsProxiesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionTargetHttpsProxyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionTargetHttpsProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionTargetHttpsProxyRequest request = new DeleteRegionTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpsProxiesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpsProxiesClient.PollOnceDeleteAsync(operationName);
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
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpsProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpsProxiesClient.Delete(project, region, targetHttpsProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpsProxiesClient.PollOnceDelete(operationName);
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
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpsProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpsProxiesClient.DeleteAsync(project, region, targetHttpsProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpsProxiesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionTargetHttpsProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            GetRegionTargetHttpsProxyRequest request = new GetRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "",
                Region = "",
                Project = "",
            };
            // Make the request
            TargetHttpsProxy response = regionTargetHttpsProxiesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionTargetHttpsProxyRequest, CallSettings)
            // Additional: GetAsync(GetRegionTargetHttpsProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionTargetHttpsProxyRequest request = new GetRegionTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "",
                Region = "",
                Project = "",
            };
            // Make the request
            TargetHttpsProxy response = await regionTargetHttpsProxiesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpsProxy = "";
            // Make the request
            TargetHttpsProxy response = regionTargetHttpsProxiesClient.Get(project, region, targetHttpsProxy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpsProxy = "";
            // Make the request
            TargetHttpsProxy response = await regionTargetHttpsProxiesClient.GetAsync(project, region, targetHttpsProxy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionTargetHttpsProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            InsertRegionTargetHttpsProxyRequest request = new InsertRegionTargetHttpsProxyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpsProxiesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpsProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionTargetHttpsProxyRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionTargetHttpsProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionTargetHttpsProxyRequest request = new InsertRegionTargetHttpsProxyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpsProxiesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpsProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, TargetHttpsProxy, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetHttpsProxy targetHttpsProxyResource = new TargetHttpsProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpsProxiesClient.Insert(project, region, targetHttpsProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpsProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, TargetHttpsProxy, CallSettings)
            // Additional: InsertAsync(string, string, TargetHttpsProxy, CancellationToken)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetHttpsProxy targetHttpsProxyResource = new TargetHttpsProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpsProxiesClient.InsertAsync(project, region, targetHttpsProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpsProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionTargetHttpsProxiesRequest, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            ListRegionTargetHttpsProxiesRequest request = new ListRegionTargetHttpsProxiesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetHttpsProxyList, TargetHttpsProxy> response = regionTargetHttpsProxiesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetHttpsProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpsProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpsProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpsProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpsProxy item in singlePage)
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
            // Snippet: ListAsync(ListRegionTargetHttpsProxiesRequest, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionTargetHttpsProxiesRequest request = new ListRegionTargetHttpsProxiesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetHttpsProxyList, TargetHttpsProxy> response = regionTargetHttpsProxiesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetHttpsProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpsProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpsProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpsProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpsProxy item in singlePage)
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
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<TargetHttpsProxyList, TargetHttpsProxy> response = regionTargetHttpsProxiesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetHttpsProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpsProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpsProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpsProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpsProxy item in singlePage)
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
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<TargetHttpsProxyList, TargetHttpsProxy> response = regionTargetHttpsProxiesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetHttpsProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpsProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpsProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpsProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpsProxy item in singlePage)
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
            // Snippet: Patch(PatchRegionTargetHttpsProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            PatchRegionTargetHttpsProxyRequest request = new PatchRegionTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Region = "",
                Project = "",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpsProxiesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpsProxiesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRegionTargetHttpsProxyRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionTargetHttpsProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionTargetHttpsProxyRequest request = new PatchRegionTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Region = "",
                Project = "",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpsProxiesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpsProxiesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, TargetHttpsProxy, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpsProxy = "";
            TargetHttpsProxy targetHttpsProxyResource = new TargetHttpsProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpsProxiesClient.Patch(project, region, targetHttpsProxy, targetHttpsProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpsProxiesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, TargetHttpsProxy, CallSettings)
            // Additional: PatchAsync(string, string, string, TargetHttpsProxy, CancellationToken)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpsProxy = "";
            TargetHttpsProxy targetHttpsProxyResource = new TargetHttpsProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpsProxiesClient.PatchAsync(project, region, targetHttpsProxy, targetHttpsProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpsProxiesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificates</summary>
        public void SetSslCertificatesRequestObject()
        {
            // Snippet: SetSslCertificates(SetSslCertificatesRegionTargetHttpsProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            SetSslCertificatesRegionTargetHttpsProxyRequest request = new SetSslCertificatesRegionTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Region = "",
                Project = "",
                RegionTargetHttpsProxiesSetSslCertificatesRequestResource = new RegionTargetHttpsProxiesSetSslCertificatesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpsProxiesClient.SetSslCertificates(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpsProxiesClient.PollOnceSetSslCertificates(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificatesAsync</summary>
        public async Task SetSslCertificatesRequestObjectAsync()
        {
            // Snippet: SetSslCertificatesAsync(SetSslCertificatesRegionTargetHttpsProxyRequest, CallSettings)
            // Additional: SetSslCertificatesAsync(SetSslCertificatesRegionTargetHttpsProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetSslCertificatesRegionTargetHttpsProxyRequest request = new SetSslCertificatesRegionTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Region = "",
                Project = "",
                RegionTargetHttpsProxiesSetSslCertificatesRequestResource = new RegionTargetHttpsProxiesSetSslCertificatesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpsProxiesClient.SetSslCertificatesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpsProxiesClient.PollOnceSetSslCertificatesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificates</summary>
        public void SetSslCertificates()
        {
            // Snippet: SetSslCertificates(string, string, string, RegionTargetHttpsProxiesSetSslCertificatesRequest, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpsProxy = "";
            RegionTargetHttpsProxiesSetSslCertificatesRequest regionTargetHttpsProxiesSetSslCertificatesRequestResource = new RegionTargetHttpsProxiesSetSslCertificatesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpsProxiesClient.SetSslCertificates(project, region, targetHttpsProxy, regionTargetHttpsProxiesSetSslCertificatesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpsProxiesClient.PollOnceSetSslCertificates(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificatesAsync</summary>
        public async Task SetSslCertificatesAsync()
        {
            // Snippet: SetSslCertificatesAsync(string, string, string, RegionTargetHttpsProxiesSetSslCertificatesRequest, CallSettings)
            // Additional: SetSslCertificatesAsync(string, string, string, RegionTargetHttpsProxiesSetSslCertificatesRequest, CancellationToken)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpsProxy = "";
            RegionTargetHttpsProxiesSetSslCertificatesRequest regionTargetHttpsProxiesSetSslCertificatesRequestResource = new RegionTargetHttpsProxiesSetSslCertificatesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpsProxiesClient.SetSslCertificatesAsync(project, region, targetHttpsProxy, regionTargetHttpsProxiesSetSslCertificatesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpsProxiesClient.PollOnceSetSslCertificatesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUrlMap</summary>
        public void SetUrlMapRequestObject()
        {
            // Snippet: SetUrlMap(SetUrlMapRegionTargetHttpsProxyRequest, CallSettings)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            SetUrlMapRegionTargetHttpsProxyRequest request = new SetUrlMapRegionTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Region = "",
                Project = "",
                UrlMapReferenceResource = new UrlMapReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpsProxiesClient.SetUrlMap(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpsProxiesClient.PollOnceSetUrlMap(operationName);
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
            // Snippet: SetUrlMapAsync(SetUrlMapRegionTargetHttpsProxyRequest, CallSettings)
            // Additional: SetUrlMapAsync(SetUrlMapRegionTargetHttpsProxyRequest, CancellationToken)
            // Create client
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetUrlMapRegionTargetHttpsProxyRequest request = new SetUrlMapRegionTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Region = "",
                Project = "",
                UrlMapReferenceResource = new UrlMapReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpsProxiesClient.SetUrlMapAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpsProxiesClient.PollOnceSetUrlMapAsync(operationName);
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
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = RegionTargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpsProxy = "";
            UrlMapReference urlMapReferenceResource = new UrlMapReference();
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetHttpsProxiesClient.SetUrlMap(project, region, targetHttpsProxy, urlMapReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetHttpsProxiesClient.PollOnceSetUrlMap(operationName);
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
            RegionTargetHttpsProxiesClient regionTargetHttpsProxiesClient = await RegionTargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetHttpsProxy = "";
            UrlMapReference urlMapReferenceResource = new UrlMapReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetHttpsProxiesClient.SetUrlMapAsync(project, region, targetHttpsProxy, urlMapReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetHttpsProxiesClient.PollOnceSetUrlMapAsync(operationName);
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
