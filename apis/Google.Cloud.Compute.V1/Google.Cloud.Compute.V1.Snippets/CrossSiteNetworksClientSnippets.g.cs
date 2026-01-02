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
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCrossSiteNetworksClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteCrossSiteNetworkRequest, CallSettings)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = CrossSiteNetworksClient.Create();
            // Initialize request argument(s)
            DeleteCrossSiteNetworkRequest request = new DeleteCrossSiteNetworkRequest
            {
                RequestId = "",
                CrossSiteNetwork = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = crossSiteNetworksClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = crossSiteNetworksClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteCrossSiteNetworkRequest, CallSettings)
            // Additional: DeleteAsync(DeleteCrossSiteNetworkRequest, CancellationToken)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = await CrossSiteNetworksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCrossSiteNetworkRequest request = new DeleteCrossSiteNetworkRequest
            {
                RequestId = "",
                CrossSiteNetwork = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await crossSiteNetworksClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await crossSiteNetworksClient.PollOnceDeleteAsync(operationName);
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
            CrossSiteNetworksClient crossSiteNetworksClient = CrossSiteNetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            // Make the request
            lro::Operation<Operation, Operation> response = crossSiteNetworksClient.Delete(project, crossSiteNetwork);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = crossSiteNetworksClient.PollOnceDelete(operationName);
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
            CrossSiteNetworksClient crossSiteNetworksClient = await CrossSiteNetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await crossSiteNetworksClient.DeleteAsync(project, crossSiteNetwork);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await crossSiteNetworksClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetCrossSiteNetworkRequest, CallSettings)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = CrossSiteNetworksClient.Create();
            // Initialize request argument(s)
            GetCrossSiteNetworkRequest request = new GetCrossSiteNetworkRequest
            {
                CrossSiteNetwork = "",
                Project = "",
            };
            // Make the request
            CrossSiteNetwork response = crossSiteNetworksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetCrossSiteNetworkRequest, CallSettings)
            // Additional: GetAsync(GetCrossSiteNetworkRequest, CancellationToken)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = await CrossSiteNetworksClient.CreateAsync();
            // Initialize request argument(s)
            GetCrossSiteNetworkRequest request = new GetCrossSiteNetworkRequest
            {
                CrossSiteNetwork = "",
                Project = "",
            };
            // Make the request
            CrossSiteNetwork response = await crossSiteNetworksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = CrossSiteNetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            // Make the request
            CrossSiteNetwork response = crossSiteNetworksClient.Get(project, crossSiteNetwork);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = await CrossSiteNetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            // Make the request
            CrossSiteNetwork response = await crossSiteNetworksClient.GetAsync(project, crossSiteNetwork);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertCrossSiteNetworkRequest, CallSettings)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = CrossSiteNetworksClient.Create();
            // Initialize request argument(s)
            InsertCrossSiteNetworkRequest request = new InsertCrossSiteNetworkRequest
            {
                CrossSiteNetworkResource = new CrossSiteNetwork(),
                RequestId = "",
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = crossSiteNetworksClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = crossSiteNetworksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertCrossSiteNetworkRequest, CallSettings)
            // Additional: InsertAsync(InsertCrossSiteNetworkRequest, CancellationToken)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = await CrossSiteNetworksClient.CreateAsync();
            // Initialize request argument(s)
            InsertCrossSiteNetworkRequest request = new InsertCrossSiteNetworkRequest
            {
                CrossSiteNetworkResource = new CrossSiteNetwork(),
                RequestId = "",
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await crossSiteNetworksClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await crossSiteNetworksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, CrossSiteNetwork, CallSettings)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = CrossSiteNetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            CrossSiteNetwork crossSiteNetworkResource = new CrossSiteNetwork();
            // Make the request
            lro::Operation<Operation, Operation> response = crossSiteNetworksClient.Insert(project, crossSiteNetworkResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = crossSiteNetworksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, CrossSiteNetwork, CallSettings)
            // Additional: InsertAsync(string, CrossSiteNetwork, CancellationToken)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = await CrossSiteNetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            CrossSiteNetwork crossSiteNetworkResource = new CrossSiteNetwork();
            // Make the request
            lro::Operation<Operation, Operation> response = await crossSiteNetworksClient.InsertAsync(project, crossSiteNetworkResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await crossSiteNetworksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListCrossSiteNetworksRequest, CallSettings)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = CrossSiteNetworksClient.Create();
            // Initialize request argument(s)
            ListCrossSiteNetworksRequest request = new ListCrossSiteNetworksRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<CrossSiteNetworkList, CrossSiteNetwork> response = crossSiteNetworksClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CrossSiteNetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (CrossSiteNetworkList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrossSiteNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrossSiteNetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrossSiteNetwork item in singlePage)
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
            // Snippet: ListAsync(ListCrossSiteNetworksRequest, CallSettings)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = await CrossSiteNetworksClient.CreateAsync();
            // Initialize request argument(s)
            ListCrossSiteNetworksRequest request = new ListCrossSiteNetworksRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<CrossSiteNetworkList, CrossSiteNetwork> response = crossSiteNetworksClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CrossSiteNetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((CrossSiteNetworkList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrossSiteNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrossSiteNetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrossSiteNetwork item in singlePage)
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
            CrossSiteNetworksClient crossSiteNetworksClient = CrossSiteNetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<CrossSiteNetworkList, CrossSiteNetwork> response = crossSiteNetworksClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CrossSiteNetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (CrossSiteNetworkList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrossSiteNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrossSiteNetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrossSiteNetwork item in singlePage)
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
            CrossSiteNetworksClient crossSiteNetworksClient = await CrossSiteNetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<CrossSiteNetworkList, CrossSiteNetwork> response = crossSiteNetworksClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CrossSiteNetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((CrossSiteNetworkList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrossSiteNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrossSiteNetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrossSiteNetwork item in singlePage)
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
            // Snippet: Patch(PatchCrossSiteNetworkRequest, CallSettings)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = CrossSiteNetworksClient.Create();
            // Initialize request argument(s)
            PatchCrossSiteNetworkRequest request = new PatchCrossSiteNetworkRequest
            {
                CrossSiteNetworkResource = new CrossSiteNetwork(),
                RequestId = "",
                CrossSiteNetwork = "",
                Project = "",
                ValidateOnly = false,
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = crossSiteNetworksClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = crossSiteNetworksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchCrossSiteNetworkRequest, CallSettings)
            // Additional: PatchAsync(PatchCrossSiteNetworkRequest, CancellationToken)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = await CrossSiteNetworksClient.CreateAsync();
            // Initialize request argument(s)
            PatchCrossSiteNetworkRequest request = new PatchCrossSiteNetworkRequest
            {
                CrossSiteNetworkResource = new CrossSiteNetwork(),
                RequestId = "",
                CrossSiteNetwork = "",
                Project = "",
                ValidateOnly = false,
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await crossSiteNetworksClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await crossSiteNetworksClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, CrossSiteNetwork, CallSettings)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = CrossSiteNetworksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            CrossSiteNetwork crossSiteNetworkResource = new CrossSiteNetwork();
            // Make the request
            lro::Operation<Operation, Operation> response = crossSiteNetworksClient.Patch(project, crossSiteNetwork, crossSiteNetworkResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = crossSiteNetworksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, CrossSiteNetwork, CallSettings)
            // Additional: PatchAsync(string, string, CrossSiteNetwork, CancellationToken)
            // Create client
            CrossSiteNetworksClient crossSiteNetworksClient = await CrossSiteNetworksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            CrossSiteNetwork crossSiteNetworkResource = new CrossSiteNetwork();
            // Make the request
            lro::Operation<Operation, Operation> response = await crossSiteNetworksClient.PatchAsync(project, crossSiteNetwork, crossSiteNetworkResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await crossSiteNetworksClient.PollOncePatchAsync(operationName);
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
