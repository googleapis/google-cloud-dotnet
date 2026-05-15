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
    public sealed class AllGeneratedRolloutPlansClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRolloutPlanRequest, CallSettings)
            // Create client
            RolloutPlansClient rolloutPlansClient = RolloutPlansClient.Create();
            // Initialize request argument(s)
            DeleteRolloutPlanRequest request = new DeleteRolloutPlanRequest
            {
                RequestId = "",
                Project = "",
                RolloutPlan = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = rolloutPlansClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = rolloutPlansClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRolloutPlanRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRolloutPlanRequest, CancellationToken)
            // Create client
            RolloutPlansClient rolloutPlansClient = await RolloutPlansClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRolloutPlanRequest request = new DeleteRolloutPlanRequest
            {
                RequestId = "",
                Project = "",
                RolloutPlan = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await rolloutPlansClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await rolloutPlansClient.PollOnceDeleteAsync(operationName);
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
            RolloutPlansClient rolloutPlansClient = RolloutPlansClient.Create();
            // Initialize request argument(s)
            string project = "";
            string rolloutPlan = "";
            // Make the request
            lro::Operation<Operation, Operation> response = rolloutPlansClient.Delete(project, rolloutPlan);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = rolloutPlansClient.PollOnceDelete(operationName);
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
            RolloutPlansClient rolloutPlansClient = await RolloutPlansClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string rolloutPlan = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await rolloutPlansClient.DeleteAsync(project, rolloutPlan);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await rolloutPlansClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRolloutPlanRequest, CallSettings)
            // Create client
            RolloutPlansClient rolloutPlansClient = RolloutPlansClient.Create();
            // Initialize request argument(s)
            GetRolloutPlanRequest request = new GetRolloutPlanRequest
            {
                Project = "",
                RolloutPlan = "",
            };
            // Make the request
            RolloutPlan response = rolloutPlansClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRolloutPlanRequest, CallSettings)
            // Additional: GetAsync(GetRolloutPlanRequest, CancellationToken)
            // Create client
            RolloutPlansClient rolloutPlansClient = await RolloutPlansClient.CreateAsync();
            // Initialize request argument(s)
            GetRolloutPlanRequest request = new GetRolloutPlanRequest
            {
                Project = "",
                RolloutPlan = "",
            };
            // Make the request
            RolloutPlan response = await rolloutPlansClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            RolloutPlansClient rolloutPlansClient = RolloutPlansClient.Create();
            // Initialize request argument(s)
            string project = "";
            string rolloutPlan = "";
            // Make the request
            RolloutPlan response = rolloutPlansClient.Get(project, rolloutPlan);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            RolloutPlansClient rolloutPlansClient = await RolloutPlansClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string rolloutPlan = "";
            // Make the request
            RolloutPlan response = await rolloutPlansClient.GetAsync(project, rolloutPlan);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRolloutPlanRequest, CallSettings)
            // Create client
            RolloutPlansClient rolloutPlansClient = RolloutPlansClient.Create();
            // Initialize request argument(s)
            InsertRolloutPlanRequest request = new InsertRolloutPlanRequest
            {
                RequestId = "",
                RolloutPlanResource = new RolloutPlan(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = rolloutPlansClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = rolloutPlansClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRolloutPlanRequest, CallSettings)
            // Additional: InsertAsync(InsertRolloutPlanRequest, CancellationToken)
            // Create client
            RolloutPlansClient rolloutPlansClient = await RolloutPlansClient.CreateAsync();
            // Initialize request argument(s)
            InsertRolloutPlanRequest request = new InsertRolloutPlanRequest
            {
                RequestId = "",
                RolloutPlanResource = new RolloutPlan(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await rolloutPlansClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await rolloutPlansClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, RolloutPlan, CallSettings)
            // Create client
            RolloutPlansClient rolloutPlansClient = RolloutPlansClient.Create();
            // Initialize request argument(s)
            string project = "";
            RolloutPlan rolloutPlanResource = new RolloutPlan();
            // Make the request
            lro::Operation<Operation, Operation> response = rolloutPlansClient.Insert(project, rolloutPlanResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = rolloutPlansClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, RolloutPlan, CallSettings)
            // Additional: InsertAsync(string, RolloutPlan, CancellationToken)
            // Create client
            RolloutPlansClient rolloutPlansClient = await RolloutPlansClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            RolloutPlan rolloutPlanResource = new RolloutPlan();
            // Make the request
            lro::Operation<Operation, Operation> response = await rolloutPlansClient.InsertAsync(project, rolloutPlanResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await rolloutPlansClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRolloutPlansRequest, CallSettings)
            // Create client
            RolloutPlansClient rolloutPlansClient = RolloutPlansClient.Create();
            // Initialize request argument(s)
            ListRolloutPlansRequest request = new ListRolloutPlansRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RolloutPlansListResponse, RolloutPlan> response = rolloutPlansClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RolloutPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RolloutPlansListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RolloutPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RolloutPlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RolloutPlan item in singlePage)
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
            // Snippet: ListAsync(ListRolloutPlansRequest, CallSettings)
            // Create client
            RolloutPlansClient rolloutPlansClient = await RolloutPlansClient.CreateAsync();
            // Initialize request argument(s)
            ListRolloutPlansRequest request = new ListRolloutPlansRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RolloutPlansListResponse, RolloutPlan> response = rolloutPlansClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RolloutPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (RolloutPlansListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RolloutPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RolloutPlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RolloutPlan item in singlePage)
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
            RolloutPlansClient rolloutPlansClient = RolloutPlansClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<RolloutPlansListResponse, RolloutPlan> response = rolloutPlansClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RolloutPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RolloutPlansListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RolloutPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RolloutPlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RolloutPlan item in singlePage)
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
            RolloutPlansClient rolloutPlansClient = await RolloutPlansClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<RolloutPlansListResponse, RolloutPlan> response = rolloutPlansClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RolloutPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (RolloutPlansListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RolloutPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RolloutPlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RolloutPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
