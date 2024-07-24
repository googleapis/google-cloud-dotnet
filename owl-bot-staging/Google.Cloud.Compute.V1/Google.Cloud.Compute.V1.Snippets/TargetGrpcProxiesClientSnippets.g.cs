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
    public sealed class AllGeneratedTargetGrpcProxiesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteTargetGrpcProxyRequest, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            DeleteTargetGrpcProxyRequest request = new DeleteTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetGrpcProxiesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetGrpcProxiesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteTargetGrpcProxyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteTargetGrpcProxyRequest, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetGrpcProxyRequest request = new DeleteTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetGrpcProxiesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetGrpcProxiesClient.PollOnceDeleteAsync(operationName);
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
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = targetGrpcProxiesClient.Delete(project, targetGrpcProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetGrpcProxiesClient.PollOnceDelete(operationName);
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
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await targetGrpcProxiesClient.DeleteAsync(project, targetGrpcProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetGrpcProxiesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetTargetGrpcProxyRequest, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            GetTargetGrpcProxyRequest request = new GetTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                Project = "",
            };
            // Make the request
            TargetGrpcProxy response = targetGrpcProxiesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetTargetGrpcProxyRequest, CallSettings)
            // Additional: GetAsync(GetTargetGrpcProxyRequest, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetGrpcProxyRequest request = new GetTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                Project = "",
            };
            // Make the request
            TargetGrpcProxy response = await targetGrpcProxiesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            // Make the request
            TargetGrpcProxy response = targetGrpcProxiesClient.Get(project, targetGrpcProxy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            // Make the request
            TargetGrpcProxy response = await targetGrpcProxiesClient.GetAsync(project, targetGrpcProxy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertTargetGrpcProxyRequest, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            InsertTargetGrpcProxyRequest request = new InsertTargetGrpcProxyRequest
            {
                RequestId = "",
                Project = "",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetGrpcProxiesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetGrpcProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertTargetGrpcProxyRequest, CallSettings)
            // Additional: InsertAsync(InsertTargetGrpcProxyRequest, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            InsertTargetGrpcProxyRequest request = new InsertTargetGrpcProxyRequest
            {
                RequestId = "",
                Project = "",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetGrpcProxiesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetGrpcProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, TargetGrpcProxy, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            TargetGrpcProxy targetGrpcProxyResource = new TargetGrpcProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = targetGrpcProxiesClient.Insert(project, targetGrpcProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetGrpcProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, TargetGrpcProxy, CallSettings)
            // Additional: InsertAsync(string, TargetGrpcProxy, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            TargetGrpcProxy targetGrpcProxyResource = new TargetGrpcProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetGrpcProxiesClient.InsertAsync(project, targetGrpcProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetGrpcProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListTargetGrpcProxiesRequest, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            ListTargetGrpcProxiesRequest request = new ListTargetGrpcProxiesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetGrpcProxyList, TargetGrpcProxy> response = targetGrpcProxiesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetGrpcProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetGrpcProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetGrpcProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetGrpcProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetGrpcProxy item in singlePage)
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
            // Snippet: ListAsync(ListTargetGrpcProxiesRequest, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetGrpcProxiesRequest request = new ListTargetGrpcProxiesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetGrpcProxyList, TargetGrpcProxy> response = targetGrpcProxiesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetGrpcProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetGrpcProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetGrpcProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetGrpcProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetGrpcProxy item in singlePage)
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
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<TargetGrpcProxyList, TargetGrpcProxy> response = targetGrpcProxiesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetGrpcProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetGrpcProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetGrpcProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetGrpcProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetGrpcProxy item in singlePage)
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
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<TargetGrpcProxyList, TargetGrpcProxy> response = targetGrpcProxiesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetGrpcProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetGrpcProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetGrpcProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetGrpcProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetGrpcProxy item in singlePage)
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
            // Snippet: Patch(PatchTargetGrpcProxyRequest, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            PatchTargetGrpcProxyRequest request = new PatchTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                RequestId = "",
                Project = "",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetGrpcProxiesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetGrpcProxiesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchTargetGrpcProxyRequest, CallSettings)
            // Additional: PatchAsync(PatchTargetGrpcProxyRequest, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            PatchTargetGrpcProxyRequest request = new PatchTargetGrpcProxyRequest
            {
                TargetGrpcProxy = "",
                RequestId = "",
                Project = "",
                TargetGrpcProxyResource = new TargetGrpcProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetGrpcProxiesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetGrpcProxiesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, TargetGrpcProxy, CallSettings)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = TargetGrpcProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            TargetGrpcProxy targetGrpcProxyResource = new TargetGrpcProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = targetGrpcProxiesClient.Patch(project, targetGrpcProxy, targetGrpcProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetGrpcProxiesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, TargetGrpcProxy, CallSettings)
            // Additional: PatchAsync(string, string, TargetGrpcProxy, CancellationToken)
            // Create client
            TargetGrpcProxiesClient targetGrpcProxiesClient = await TargetGrpcProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetGrpcProxy = "";
            TargetGrpcProxy targetGrpcProxyResource = new TargetGrpcProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetGrpcProxiesClient.PatchAsync(project, targetGrpcProxy, targetGrpcProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetGrpcProxiesClient.PollOncePatchAsync(operationName);
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
