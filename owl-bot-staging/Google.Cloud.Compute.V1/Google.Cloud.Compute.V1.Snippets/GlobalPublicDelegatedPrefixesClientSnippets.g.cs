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
    public sealed class AllGeneratedGlobalPublicDelegatedPrefixesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            DeleteGlobalPublicDelegatedPrefixeRequest request = new DeleteGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalPublicDelegatedPrefixesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalPublicDelegatedPrefixesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalPublicDelegatedPrefixeRequest request = new DeleteGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalPublicDelegatedPrefixesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalPublicDelegatedPrefixesClient.PollOnceDeleteAsync(operationName);
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
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = globalPublicDelegatedPrefixesClient.Delete(project, publicDelegatedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalPublicDelegatedPrefixesClient.PollOnceDelete(operationName);
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
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await globalPublicDelegatedPrefixesClient.DeleteAsync(project, publicDelegatedPrefix);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalPublicDelegatedPrefixesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            GetGlobalPublicDelegatedPrefixeRequest request = new GetGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicDelegatedPrefix response = globalPublicDelegatedPrefixesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: GetAsync(GetGlobalPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalPublicDelegatedPrefixeRequest request = new GetGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            PublicDelegatedPrefix response = await globalPublicDelegatedPrefixesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            // Make the request
            PublicDelegatedPrefix response = globalPublicDelegatedPrefixesClient.Get(project, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            // Make the request
            PublicDelegatedPrefix response = await globalPublicDelegatedPrefixesClient.GetAsync(project, publicDelegatedPrefix);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            InsertGlobalPublicDelegatedPrefixeRequest request = new InsertGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalPublicDelegatedPrefixesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalPublicDelegatedPrefixesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: InsertAsync(InsertGlobalPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            InsertGlobalPublicDelegatedPrefixeRequest request = new InsertGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalPublicDelegatedPrefixesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalPublicDelegatedPrefixesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, PublicDelegatedPrefix, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = globalPublicDelegatedPrefixesClient.Insert(project, publicDelegatedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalPublicDelegatedPrefixesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, PublicDelegatedPrefix, CallSettings)
            // Additional: InsertAsync(string, PublicDelegatedPrefix, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalPublicDelegatedPrefixesClient.InsertAsync(project, publicDelegatedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalPublicDelegatedPrefixesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListGlobalPublicDelegatedPrefixesRequest, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            ListGlobalPublicDelegatedPrefixesRequest request = new ListGlobalPublicDelegatedPrefixesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<PublicDelegatedPrefixList, PublicDelegatedPrefix> response = globalPublicDelegatedPrefixesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublicDelegatedPrefix item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PublicDelegatedPrefixList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicDelegatedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicDelegatedPrefix> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicDelegatedPrefix item in singlePage)
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
            // Snippet: ListAsync(ListGlobalPublicDelegatedPrefixesRequest, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalPublicDelegatedPrefixesRequest request = new ListGlobalPublicDelegatedPrefixesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<PublicDelegatedPrefixList, PublicDelegatedPrefix> response = globalPublicDelegatedPrefixesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublicDelegatedPrefix item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PublicDelegatedPrefixList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicDelegatedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicDelegatedPrefix> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicDelegatedPrefix item in singlePage)
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
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<PublicDelegatedPrefixList, PublicDelegatedPrefix> response = globalPublicDelegatedPrefixesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublicDelegatedPrefix item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PublicDelegatedPrefixList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicDelegatedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicDelegatedPrefix> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicDelegatedPrefix item in singlePage)
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
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<PublicDelegatedPrefixList, PublicDelegatedPrefix> response = globalPublicDelegatedPrefixesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublicDelegatedPrefix item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PublicDelegatedPrefixList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicDelegatedPrefix item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicDelegatedPrefix> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicDelegatedPrefix item in singlePage)
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
            // Snippet: Patch(PatchGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            PatchGlobalPublicDelegatedPrefixeRequest request = new PatchGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalPublicDelegatedPrefixesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalPublicDelegatedPrefixesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchGlobalPublicDelegatedPrefixeRequest, CallSettings)
            // Additional: PatchAsync(PatchGlobalPublicDelegatedPrefixeRequest, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            PatchGlobalPublicDelegatedPrefixeRequest request = new PatchGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                PublicDelegatedPrefix = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalPublicDelegatedPrefixesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalPublicDelegatedPrefixesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, PublicDelegatedPrefix, CallSettings)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = GlobalPublicDelegatedPrefixesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = globalPublicDelegatedPrefixesClient.Patch(project, publicDelegatedPrefix, publicDelegatedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalPublicDelegatedPrefixesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, PublicDelegatedPrefix, CallSettings)
            // Additional: PatchAsync(string, string, PublicDelegatedPrefix, CancellationToken)
            // Create client
            GlobalPublicDelegatedPrefixesClient globalPublicDelegatedPrefixesClient = await GlobalPublicDelegatedPrefixesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string publicDelegatedPrefix = "";
            PublicDelegatedPrefix publicDelegatedPrefixResource = new PublicDelegatedPrefix();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalPublicDelegatedPrefixesClient.PatchAsync(project, publicDelegatedPrefix, publicDelegatedPrefixResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalPublicDelegatedPrefixesClient.PollOncePatchAsync(operationName);
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
