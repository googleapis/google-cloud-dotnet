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
    public sealed class AllGeneratedHttpHealthChecksClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteHttpHealthCheckRequest, CallSettings)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            DeleteHttpHealthCheckRequest request = new DeleteHttpHealthCheckRequest
            {
                RequestId = "",
                Project = "",
                HttpHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = httpHealthChecksClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpHealthChecksClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteHttpHealthCheckRequest, CallSettings)
            // Additional: DeleteAsync(DeleteHttpHealthCheckRequest, CancellationToken)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteHttpHealthCheckRequest request = new DeleteHttpHealthCheckRequest
            {
                RequestId = "",
                Project = "",
                HttpHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await httpHealthChecksClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpHealthChecksClient.PollOnceDeleteAsync(operationName);
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
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string httpHealthCheck = "";
            // Make the request
            lro::Operation<Operation, Operation> response = httpHealthChecksClient.Delete(project, httpHealthCheck);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpHealthChecksClient.PollOnceDelete(operationName);
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
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string httpHealthCheck = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await httpHealthChecksClient.DeleteAsync(project, httpHealthCheck);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpHealthChecksClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetHttpHealthCheckRequest, CallSettings)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            GetHttpHealthCheckRequest request = new GetHttpHealthCheckRequest
            {
                Project = "",
                HttpHealthCheck = "",
            };
            // Make the request
            HttpHealthCheck response = httpHealthChecksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetHttpHealthCheckRequest, CallSettings)
            // Additional: GetAsync(GetHttpHealthCheckRequest, CancellationToken)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            GetHttpHealthCheckRequest request = new GetHttpHealthCheckRequest
            {
                Project = "",
                HttpHealthCheck = "",
            };
            // Make the request
            HttpHealthCheck response = await httpHealthChecksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string httpHealthCheck = "";
            // Make the request
            HttpHealthCheck response = httpHealthChecksClient.Get(project, httpHealthCheck);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string httpHealthCheck = "";
            // Make the request
            HttpHealthCheck response = await httpHealthChecksClient.GetAsync(project, httpHealthCheck);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertHttpHealthCheckRequest, CallSettings)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            InsertHttpHealthCheckRequest request = new InsertHttpHealthCheckRequest
            {
                RequestId = "",
                HttpHealthCheckResource = new HttpHealthCheck(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = httpHealthChecksClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpHealthChecksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertHttpHealthCheckRequest, CallSettings)
            // Additional: InsertAsync(InsertHttpHealthCheckRequest, CancellationToken)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            InsertHttpHealthCheckRequest request = new InsertHttpHealthCheckRequest
            {
                RequestId = "",
                HttpHealthCheckResource = new HttpHealthCheck(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await httpHealthChecksClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpHealthChecksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, HttpHealthCheck, CallSettings)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            HttpHealthCheck httpHealthCheckResource = new HttpHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = httpHealthChecksClient.Insert(project, httpHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpHealthChecksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, HttpHealthCheck, CallSettings)
            // Additional: InsertAsync(string, HttpHealthCheck, CancellationToken)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            HttpHealthCheck httpHealthCheckResource = new HttpHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = await httpHealthChecksClient.InsertAsync(project, httpHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpHealthChecksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListHttpHealthChecksRequest, CallSettings)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            ListHttpHealthChecksRequest request = new ListHttpHealthChecksRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<HttpHealthCheckList, HttpHealthCheck> response = httpHealthChecksClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HttpHealthCheck item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HttpHealthCheckList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpHealthCheck> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpHealthCheck item in singlePage)
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
            // Snippet: ListAsync(ListHttpHealthChecksRequest, CallSettings)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            ListHttpHealthChecksRequest request = new ListHttpHealthChecksRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<HttpHealthCheckList, HttpHealthCheck> response = httpHealthChecksClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HttpHealthCheck item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((HttpHealthCheckList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpHealthCheck> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpHealthCheck item in singlePage)
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
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<HttpHealthCheckList, HttpHealthCheck> response = httpHealthChecksClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HttpHealthCheck item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HttpHealthCheckList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpHealthCheck> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpHealthCheck item in singlePage)
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
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<HttpHealthCheckList, HttpHealthCheck> response = httpHealthChecksClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HttpHealthCheck item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((HttpHealthCheckList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpHealthCheck> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpHealthCheck item in singlePage)
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
            // Snippet: Patch(PatchHttpHealthCheckRequest, CallSettings)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            PatchHttpHealthCheckRequest request = new PatchHttpHealthCheckRequest
            {
                RequestId = "",
                HttpHealthCheckResource = new HttpHealthCheck(),
                Project = "",
                HttpHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = httpHealthChecksClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpHealthChecksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchHttpHealthCheckRequest, CallSettings)
            // Additional: PatchAsync(PatchHttpHealthCheckRequest, CancellationToken)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            PatchHttpHealthCheckRequest request = new PatchHttpHealthCheckRequest
            {
                RequestId = "",
                HttpHealthCheckResource = new HttpHealthCheck(),
                Project = "",
                HttpHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await httpHealthChecksClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpHealthChecksClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, HttpHealthCheck, CallSettings)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string httpHealthCheck = "";
            HttpHealthCheck httpHealthCheckResource = new HttpHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = httpHealthChecksClient.Patch(project, httpHealthCheck, httpHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpHealthChecksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, HttpHealthCheck, CallSettings)
            // Additional: PatchAsync(string, string, HttpHealthCheck, CancellationToken)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string httpHealthCheck = "";
            HttpHealthCheck httpHealthCheckResource = new HttpHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = await httpHealthChecksClient.PatchAsync(project, httpHealthCheck, httpHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpHealthChecksClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateHttpHealthCheckRequest, CallSettings)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            UpdateHttpHealthCheckRequest request = new UpdateHttpHealthCheckRequest
            {
                RequestId = "",
                HttpHealthCheckResource = new HttpHealthCheck(),
                Project = "",
                HttpHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = httpHealthChecksClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpHealthChecksClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdateHttpHealthCheckRequest, CallSettings)
            // Additional: UpdateAsync(UpdateHttpHealthCheckRequest, CancellationToken)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateHttpHealthCheckRequest request = new UpdateHttpHealthCheckRequest
            {
                RequestId = "",
                HttpHealthCheckResource = new HttpHealthCheck(),
                Project = "",
                HttpHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await httpHealthChecksClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpHealthChecksClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, HttpHealthCheck, CallSettings)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = HttpHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string httpHealthCheck = "";
            HttpHealthCheck httpHealthCheckResource = new HttpHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = httpHealthChecksClient.Update(project, httpHealthCheck, httpHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpHealthChecksClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, HttpHealthCheck, CallSettings)
            // Additional: UpdateAsync(string, string, HttpHealthCheck, CancellationToken)
            // Create client
            HttpHealthChecksClient httpHealthChecksClient = await HttpHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string httpHealthCheck = "";
            HttpHealthCheck httpHealthCheckResource = new HttpHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = await httpHealthChecksClient.UpdateAsync(project, httpHealthCheck, httpHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpHealthChecksClient.PollOnceUpdateAsync(operationName);
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
