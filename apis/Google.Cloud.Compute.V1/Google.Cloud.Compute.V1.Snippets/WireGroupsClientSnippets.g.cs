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
    public sealed class AllGeneratedWireGroupsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteWireGroupRequest, CallSettings)
            // Create client
            WireGroupsClient wireGroupsClient = WireGroupsClient.Create();
            // Initialize request argument(s)
            DeleteWireGroupRequest request = new DeleteWireGroupRequest
            {
                RequestId = "",
                CrossSiteNetwork = "",
                WireGroup = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = wireGroupsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = wireGroupsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteWireGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteWireGroupRequest, CancellationToken)
            // Create client
            WireGroupsClient wireGroupsClient = await WireGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWireGroupRequest request = new DeleteWireGroupRequest
            {
                RequestId = "",
                CrossSiteNetwork = "",
                WireGroup = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await wireGroupsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await wireGroupsClient.PollOnceDeleteAsync(operationName);
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
            WireGroupsClient wireGroupsClient = WireGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            string wireGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = wireGroupsClient.Delete(project, crossSiteNetwork, wireGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = wireGroupsClient.PollOnceDelete(operationName);
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
            WireGroupsClient wireGroupsClient = await WireGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            string wireGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await wireGroupsClient.DeleteAsync(project, crossSiteNetwork, wireGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await wireGroupsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetWireGroupRequest, CallSettings)
            // Create client
            WireGroupsClient wireGroupsClient = WireGroupsClient.Create();
            // Initialize request argument(s)
            GetWireGroupRequest request = new GetWireGroupRequest
            {
                CrossSiteNetwork = "",
                WireGroup = "",
                Project = "",
            };
            // Make the request
            WireGroup response = wireGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetWireGroupRequest, CallSettings)
            // Additional: GetAsync(GetWireGroupRequest, CancellationToken)
            // Create client
            WireGroupsClient wireGroupsClient = await WireGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetWireGroupRequest request = new GetWireGroupRequest
            {
                CrossSiteNetwork = "",
                WireGroup = "",
                Project = "",
            };
            // Make the request
            WireGroup response = await wireGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            WireGroupsClient wireGroupsClient = WireGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            string wireGroup = "";
            // Make the request
            WireGroup response = wireGroupsClient.Get(project, crossSiteNetwork, wireGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            WireGroupsClient wireGroupsClient = await WireGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            string wireGroup = "";
            // Make the request
            WireGroup response = await wireGroupsClient.GetAsync(project, crossSiteNetwork, wireGroup);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertWireGroupRequest, CallSettings)
            // Create client
            WireGroupsClient wireGroupsClient = WireGroupsClient.Create();
            // Initialize request argument(s)
            InsertWireGroupRequest request = new InsertWireGroupRequest
            {
                RequestId = "",
                CrossSiteNetwork = "",
                WireGroupResource = new WireGroup(),
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = wireGroupsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = wireGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertWireGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertWireGroupRequest, CancellationToken)
            // Create client
            WireGroupsClient wireGroupsClient = await WireGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertWireGroupRequest request = new InsertWireGroupRequest
            {
                RequestId = "",
                CrossSiteNetwork = "",
                WireGroupResource = new WireGroup(),
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await wireGroupsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await wireGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, WireGroup, CallSettings)
            // Create client
            WireGroupsClient wireGroupsClient = WireGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            WireGroup wireGroupResource = new WireGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = wireGroupsClient.Insert(project, crossSiteNetwork, wireGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = wireGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, WireGroup, CallSettings)
            // Additional: InsertAsync(string, string, WireGroup, CancellationToken)
            // Create client
            WireGroupsClient wireGroupsClient = await WireGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            WireGroup wireGroupResource = new WireGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await wireGroupsClient.InsertAsync(project, crossSiteNetwork, wireGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await wireGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListWireGroupsRequest, CallSettings)
            // Create client
            WireGroupsClient wireGroupsClient = WireGroupsClient.Create();
            // Initialize request argument(s)
            ListWireGroupsRequest request = new ListWireGroupsRequest
            {
                CrossSiteNetwork = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<WireGroupList, WireGroup> response = wireGroupsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WireGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (WireGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WireGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WireGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WireGroup item in singlePage)
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
            // Snippet: ListAsync(ListWireGroupsRequest, CallSettings)
            // Create client
            WireGroupsClient wireGroupsClient = await WireGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListWireGroupsRequest request = new ListWireGroupsRequest
            {
                CrossSiteNetwork = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<WireGroupList, WireGroup> response = wireGroupsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (WireGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (WireGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WireGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WireGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WireGroup item in singlePage)
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
            WireGroupsClient wireGroupsClient = WireGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            // Make the request
            PagedEnumerable<WireGroupList, WireGroup> response = wireGroupsClient.List(project, crossSiteNetwork);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WireGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (WireGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WireGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WireGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WireGroup item in singlePage)
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
            WireGroupsClient wireGroupsClient = await WireGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            // Make the request
            PagedAsyncEnumerable<WireGroupList, WireGroup> response = wireGroupsClient.ListAsync(project, crossSiteNetwork);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (WireGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (WireGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WireGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WireGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WireGroup item in singlePage)
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
            // Snippet: Patch(PatchWireGroupRequest, CallSettings)
            // Create client
            WireGroupsClient wireGroupsClient = WireGroupsClient.Create();
            // Initialize request argument(s)
            PatchWireGroupRequest request = new PatchWireGroupRequest
            {
                RequestId = "",
                CrossSiteNetwork = "",
                WireGroupResource = new WireGroup(),
                WireGroup = "",
                Project = "",
                ValidateOnly = false,
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = wireGroupsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = wireGroupsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchWireGroupRequest, CallSettings)
            // Additional: PatchAsync(PatchWireGroupRequest, CancellationToken)
            // Create client
            WireGroupsClient wireGroupsClient = await WireGroupsClient.CreateAsync();
            // Initialize request argument(s)
            PatchWireGroupRequest request = new PatchWireGroupRequest
            {
                RequestId = "",
                CrossSiteNetwork = "",
                WireGroupResource = new WireGroup(),
                WireGroup = "",
                Project = "",
                ValidateOnly = false,
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await wireGroupsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await wireGroupsClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, WireGroup, CallSettings)
            // Create client
            WireGroupsClient wireGroupsClient = WireGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            string wireGroup = "";
            WireGroup wireGroupResource = new WireGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = wireGroupsClient.Patch(project, crossSiteNetwork, wireGroup, wireGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = wireGroupsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, WireGroup, CallSettings)
            // Additional: PatchAsync(string, string, string, WireGroup, CancellationToken)
            // Create client
            WireGroupsClient wireGroupsClient = await WireGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string crossSiteNetwork = "";
            string wireGroup = "";
            WireGroup wireGroupResource = new WireGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await wireGroupsClient.PatchAsync(project, crossSiteNetwork, wireGroup, wireGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await wireGroupsClient.PollOncePatchAsync(operationName);
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
