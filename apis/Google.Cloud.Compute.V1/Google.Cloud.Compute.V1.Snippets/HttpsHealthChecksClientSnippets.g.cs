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
    public sealed class AllGeneratedHttpsHealthChecksClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteHttpsHealthCheckRequest, CallSettings)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            DeleteHttpsHealthCheckRequest request = new DeleteHttpsHealthCheckRequest
            {
                RequestId = "",
                Project = "",
                HttpsHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = httpsHealthChecksClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpsHealthChecksClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteHttpsHealthCheckRequest, CallSettings)
            // Additional: DeleteAsync(DeleteHttpsHealthCheckRequest, CancellationToken)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteHttpsHealthCheckRequest request = new DeleteHttpsHealthCheckRequest
            {
                RequestId = "",
                Project = "",
                HttpsHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await httpsHealthChecksClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpsHealthChecksClient.PollOnceDeleteAsync(operationName);
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
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string httpsHealthCheck = "";
            // Make the request
            lro::Operation<Operation, Operation> response = httpsHealthChecksClient.Delete(project, httpsHealthCheck);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpsHealthChecksClient.PollOnceDelete(operationName);
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
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string httpsHealthCheck = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await httpsHealthChecksClient.DeleteAsync(project, httpsHealthCheck);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpsHealthChecksClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetHttpsHealthCheckRequest, CallSettings)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            GetHttpsHealthCheckRequest request = new GetHttpsHealthCheckRequest
            {
                Project = "",
                HttpsHealthCheck = "",
            };
            // Make the request
            HttpsHealthCheck response = httpsHealthChecksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetHttpsHealthCheckRequest, CallSettings)
            // Additional: GetAsync(GetHttpsHealthCheckRequest, CancellationToken)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            GetHttpsHealthCheckRequest request = new GetHttpsHealthCheckRequest
            {
                Project = "",
                HttpsHealthCheck = "",
            };
            // Make the request
            HttpsHealthCheck response = await httpsHealthChecksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string httpsHealthCheck = "";
            // Make the request
            HttpsHealthCheck response = httpsHealthChecksClient.Get(project, httpsHealthCheck);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string httpsHealthCheck = "";
            // Make the request
            HttpsHealthCheck response = await httpsHealthChecksClient.GetAsync(project, httpsHealthCheck);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertHttpsHealthCheckRequest, CallSettings)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            InsertHttpsHealthCheckRequest request = new InsertHttpsHealthCheckRequest
            {
                RequestId = "",
                Project = "",
                HttpsHealthCheckResource = new HttpsHealthCheck(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = httpsHealthChecksClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpsHealthChecksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertHttpsHealthCheckRequest, CallSettings)
            // Additional: InsertAsync(InsertHttpsHealthCheckRequest, CancellationToken)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            InsertHttpsHealthCheckRequest request = new InsertHttpsHealthCheckRequest
            {
                RequestId = "",
                Project = "",
                HttpsHealthCheckResource = new HttpsHealthCheck(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await httpsHealthChecksClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpsHealthChecksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, HttpsHealthCheck, CallSettings)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            HttpsHealthCheck httpsHealthCheckResource = new HttpsHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = httpsHealthChecksClient.Insert(project, httpsHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpsHealthChecksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, HttpsHealthCheck, CallSettings)
            // Additional: InsertAsync(string, HttpsHealthCheck, CancellationToken)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            HttpsHealthCheck httpsHealthCheckResource = new HttpsHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = await httpsHealthChecksClient.InsertAsync(project, httpsHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpsHealthChecksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListHttpsHealthChecksRequest, CallSettings)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            ListHttpsHealthChecksRequest request = new ListHttpsHealthChecksRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<HttpsHealthCheckList, HttpsHealthCheck> response = httpsHealthChecksClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HttpsHealthCheck item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HttpsHealthCheckList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpsHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpsHealthCheck> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpsHealthCheck item in singlePage)
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
            // Snippet: ListAsync(ListHttpsHealthChecksRequest, CallSettings)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            ListHttpsHealthChecksRequest request = new ListHttpsHealthChecksRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<HttpsHealthCheckList, HttpsHealthCheck> response = httpsHealthChecksClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HttpsHealthCheck item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((HttpsHealthCheckList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpsHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpsHealthCheck> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpsHealthCheck item in singlePage)
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
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<HttpsHealthCheckList, HttpsHealthCheck> response = httpsHealthChecksClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HttpsHealthCheck item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HttpsHealthCheckList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpsHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpsHealthCheck> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpsHealthCheck item in singlePage)
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
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<HttpsHealthCheckList, HttpsHealthCheck> response = httpsHealthChecksClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HttpsHealthCheck item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((HttpsHealthCheckList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HttpsHealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HttpsHealthCheck> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HttpsHealthCheck item in singlePage)
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
            // Snippet: Patch(PatchHttpsHealthCheckRequest, CallSettings)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            PatchHttpsHealthCheckRequest request = new PatchHttpsHealthCheckRequest
            {
                RequestId = "",
                Project = "",
                HttpsHealthCheckResource = new HttpsHealthCheck(),
                HttpsHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = httpsHealthChecksClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpsHealthChecksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchHttpsHealthCheckRequest, CallSettings)
            // Additional: PatchAsync(PatchHttpsHealthCheckRequest, CancellationToken)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            PatchHttpsHealthCheckRequest request = new PatchHttpsHealthCheckRequest
            {
                RequestId = "",
                Project = "",
                HttpsHealthCheckResource = new HttpsHealthCheck(),
                HttpsHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await httpsHealthChecksClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpsHealthChecksClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, HttpsHealthCheck, CallSettings)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string httpsHealthCheck = "";
            HttpsHealthCheck httpsHealthCheckResource = new HttpsHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = httpsHealthChecksClient.Patch(project, httpsHealthCheck, httpsHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpsHealthChecksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, HttpsHealthCheck, CallSettings)
            // Additional: PatchAsync(string, string, HttpsHealthCheck, CancellationToken)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string httpsHealthCheck = "";
            HttpsHealthCheck httpsHealthCheckResource = new HttpsHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = await httpsHealthChecksClient.PatchAsync(project, httpsHealthCheck, httpsHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpsHealthChecksClient.PollOncePatchAsync(operationName);
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
            // Snippet: Update(UpdateHttpsHealthCheckRequest, CallSettings)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            UpdateHttpsHealthCheckRequest request = new UpdateHttpsHealthCheckRequest
            {
                RequestId = "",
                Project = "",
                HttpsHealthCheckResource = new HttpsHealthCheck(),
                HttpsHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = httpsHealthChecksClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpsHealthChecksClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateHttpsHealthCheckRequest, CallSettings)
            // Additional: UpdateAsync(UpdateHttpsHealthCheckRequest, CancellationToken)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateHttpsHealthCheckRequest request = new UpdateHttpsHealthCheckRequest
            {
                RequestId = "",
                Project = "",
                HttpsHealthCheckResource = new HttpsHealthCheck(),
                HttpsHealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await httpsHealthChecksClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpsHealthChecksClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, HttpsHealthCheck, CallSettings)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = HttpsHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string httpsHealthCheck = "";
            HttpsHealthCheck httpsHealthCheckResource = new HttpsHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = httpsHealthChecksClient.Update(project, httpsHealthCheck, httpsHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = httpsHealthChecksClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, HttpsHealthCheck, CallSettings)
            // Additional: UpdateAsync(string, string, HttpsHealthCheck, CancellationToken)
            // Create client
            HttpsHealthChecksClient httpsHealthChecksClient = await HttpsHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string httpsHealthCheck = "";
            HttpsHealthCheck httpsHealthCheckResource = new HttpsHealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = await httpsHealthChecksClient.UpdateAsync(project, httpsHealthCheck, httpsHealthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await httpsHealthChecksClient.PollOnceUpdateAsync(operationName);
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
