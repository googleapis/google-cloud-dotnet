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
    public sealed class AllGeneratedRolloutsClientSnippets
    {
        /// <summary>Snippet for Cancel</summary>
        public void CancelRequestObject()
        {
            // Snippet: Cancel(CancelRolloutRequest, CallSettings)
            // Create client
            RolloutsClient rolloutsClient = RolloutsClient.Create();
            // Initialize request argument(s)
            CancelRolloutRequest request = new CancelRolloutRequest
            {
                RequestId = "",
                Project = "",
                Rollback = false,
                Rollout = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = rolloutsClient.Cancel(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = rolloutsClient.PollOnceCancel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelAsync</summary>
        public async Task CancelRequestObjectAsync()
        {
            // Snippet: CancelAsync(CancelRolloutRequest, CallSettings)
            // Additional: CancelAsync(CancelRolloutRequest, CancellationToken)
            // Create client
            RolloutsClient rolloutsClient = await RolloutsClient.CreateAsync();
            // Initialize request argument(s)
            CancelRolloutRequest request = new CancelRolloutRequest
            {
                RequestId = "",
                Project = "",
                Rollback = false,
                Rollout = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await rolloutsClient.CancelAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await rolloutsClient.PollOnceCancelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Cancel</summary>
        public void Cancel()
        {
            // Snippet: Cancel(string, string, CallSettings)
            // Create client
            RolloutsClient rolloutsClient = RolloutsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string rollout = "";
            // Make the request
            lro::Operation<Operation, Operation> response = rolloutsClient.Cancel(project, rollout);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = rolloutsClient.PollOnceCancel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelAsync</summary>
        public async Task CancelAsync()
        {
            // Snippet: CancelAsync(string, string, CallSettings)
            // Additional: CancelAsync(string, string, CancellationToken)
            // Create client
            RolloutsClient rolloutsClient = await RolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string rollout = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await rolloutsClient.CancelAsync(project, rollout);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await rolloutsClient.PollOnceCancelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRolloutRequest, CallSettings)
            // Create client
            RolloutsClient rolloutsClient = RolloutsClient.Create();
            // Initialize request argument(s)
            DeleteRolloutRequest request = new DeleteRolloutRequest
            {
                RequestId = "",
                Project = "",
                Rollout = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = rolloutsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = rolloutsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRolloutRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRolloutRequest, CancellationToken)
            // Create client
            RolloutsClient rolloutsClient = await RolloutsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRolloutRequest request = new DeleteRolloutRequest
            {
                RequestId = "",
                Project = "",
                Rollout = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await rolloutsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await rolloutsClient.PollOnceDeleteAsync(operationName);
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
            RolloutsClient rolloutsClient = RolloutsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string rollout = "";
            // Make the request
            lro::Operation<Operation, Operation> response = rolloutsClient.Delete(project, rollout);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = rolloutsClient.PollOnceDelete(operationName);
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
            RolloutsClient rolloutsClient = await RolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string rollout = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await rolloutsClient.DeleteAsync(project, rollout);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await rolloutsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRolloutRequest, CallSettings)
            // Create client
            RolloutsClient rolloutsClient = RolloutsClient.Create();
            // Initialize request argument(s)
            GetRolloutRequest request = new GetRolloutRequest
            {
                Project = "",
                Rollout = "",
            };
            // Make the request
            Rollout response = rolloutsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRolloutRequest, CallSettings)
            // Additional: GetAsync(GetRolloutRequest, CancellationToken)
            // Create client
            RolloutsClient rolloutsClient = await RolloutsClient.CreateAsync();
            // Initialize request argument(s)
            GetRolloutRequest request = new GetRolloutRequest
            {
                Project = "",
                Rollout = "",
            };
            // Make the request
            Rollout response = await rolloutsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            RolloutsClient rolloutsClient = RolloutsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string rollout = "";
            // Make the request
            Rollout response = rolloutsClient.Get(project, rollout);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            RolloutsClient rolloutsClient = await RolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string rollout = "";
            // Make the request
            Rollout response = await rolloutsClient.GetAsync(project, rollout);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRolloutsRequest, CallSettings)
            // Create client
            RolloutsClient rolloutsClient = RolloutsClient.Create();
            // Initialize request argument(s)
            ListRolloutsRequest request = new ListRolloutsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RolloutsListResponse, Rollout> response = rolloutsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RolloutsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
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
            // Snippet: ListAsync(ListRolloutsRequest, CallSettings)
            // Create client
            RolloutsClient rolloutsClient = await RolloutsClient.CreateAsync();
            // Initialize request argument(s)
            ListRolloutsRequest request = new ListRolloutsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RolloutsListResponse, Rollout> response = rolloutsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (RolloutsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
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
            RolloutsClient rolloutsClient = RolloutsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<RolloutsListResponse, Rollout> response = rolloutsClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RolloutsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
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
            RolloutsClient rolloutsClient = await RolloutsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<RolloutsListResponse, Rollout> response = rolloutsClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (RolloutsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
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
