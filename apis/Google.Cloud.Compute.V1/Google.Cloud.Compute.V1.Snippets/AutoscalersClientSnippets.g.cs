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
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAutoscalersClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListAutoscalersRequest, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            AggregatedListAutoscalersRequest request = new AggregatedListAutoscalersRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<AutoscalerAggregatedList, KeyValuePair<string, AutoscalersScopedList>> response = autoscalersClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, AutoscalersScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AutoscalerAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, AutoscalersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, AutoscalersScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, AutoscalersScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListAutoscalersRequest, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListAutoscalersRequest request = new AggregatedListAutoscalersRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<AutoscalerAggregatedList, KeyValuePair<string, AutoscalersScopedList>> response = autoscalersClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, AutoscalersScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AutoscalerAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, AutoscalersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, AutoscalersScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, AutoscalersScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, string, int?, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<AutoscalerAggregatedList, KeyValuePair<string, AutoscalersScopedList>> response = autoscalersClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, AutoscalersScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AutoscalerAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, AutoscalersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, AutoscalersScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, AutoscalersScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, string, int?, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<AutoscalerAggregatedList, KeyValuePair<string, AutoscalersScopedList>> response = autoscalersClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, AutoscalersScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AutoscalerAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, AutoscalersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, AutoscalersScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, AutoscalersScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteAutoscalerRequest, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            DeleteAutoscalerRequest request = new DeleteAutoscalerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = autoscalersClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = autoscalersClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteAutoscalerRequest, CallSettings)
            // Additional: DeleteAsync(DeleteAutoscalerRequest, CancellationToken)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAutoscalerRequest request = new DeleteAutoscalerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await autoscalersClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await autoscalersClient.PollOnceDeleteAsync(operationName);
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
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string autoscaler = "";
            // Make the request
            lro::Operation<Operation, Operation> response = autoscalersClient.Delete(project, zone, autoscaler);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = autoscalersClient.PollOnceDelete(operationName);
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
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string autoscaler = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await autoscalersClient.DeleteAsync(project, zone, autoscaler);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await autoscalersClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetAutoscalerRequest, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            GetAutoscalerRequest request = new GetAutoscalerRequest
            {
                Zone = "",
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            Autoscaler response = autoscalersClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetAutoscalerRequest, CallSettings)
            // Additional: GetAsync(GetAutoscalerRequest, CancellationToken)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            GetAutoscalerRequest request = new GetAutoscalerRequest
            {
                Zone = "",
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            Autoscaler response = await autoscalersClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string autoscaler = "";
            // Make the request
            Autoscaler response = autoscalersClient.Get(project, zone, autoscaler);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string autoscaler = "";
            // Make the request
            Autoscaler response = await autoscalersClient.GetAsync(project, zone, autoscaler);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertAutoscalerRequest, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            InsertAutoscalerRequest request = new InsertAutoscalerRequest
            {
                Zone = "",
                RequestId = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = autoscalersClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = autoscalersClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertAutoscalerRequest, CallSettings)
            // Additional: InsertAsync(InsertAutoscalerRequest, CancellationToken)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            InsertAutoscalerRequest request = new InsertAutoscalerRequest
            {
                Zone = "",
                RequestId = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await autoscalersClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await autoscalersClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, Autoscaler, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = autoscalersClient.Insert(project, zone, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = autoscalersClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, Autoscaler, CallSettings)
            // Additional: InsertAsync(string, string, Autoscaler, CancellationToken)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = await autoscalersClient.InsertAsync(project, zone, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await autoscalersClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListAutoscalersRequest, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            ListAutoscalersRequest request = new ListAutoscalersRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<AutoscalerList, Autoscaler> response = autoscalersClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Autoscaler item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AutoscalerList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Autoscaler item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Autoscaler> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Autoscaler item in singlePage)
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
            // Snippet: ListAsync(ListAutoscalersRequest, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            ListAutoscalersRequest request = new ListAutoscalersRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<AutoscalerList, Autoscaler> response = autoscalersClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Autoscaler item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AutoscalerList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Autoscaler item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Autoscaler> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Autoscaler item in singlePage)
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
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<AutoscalerList, Autoscaler> response = autoscalersClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Autoscaler item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AutoscalerList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Autoscaler item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Autoscaler> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Autoscaler item in singlePage)
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
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<AutoscalerList, Autoscaler> response = autoscalersClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Autoscaler item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AutoscalerList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Autoscaler item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Autoscaler> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Autoscaler item in singlePage)
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
            // Snippet: Patch(PatchAutoscalerRequest, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            PatchAutoscalerRequest request = new PatchAutoscalerRequest
            {
                Zone = "",
                RequestId = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = autoscalersClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = autoscalersClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchAutoscalerRequest, CallSettings)
            // Additional: PatchAsync(PatchAutoscalerRequest, CancellationToken)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            PatchAutoscalerRequest request = new PatchAutoscalerRequest
            {
                Zone = "",
                RequestId = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await autoscalersClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await autoscalersClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, Autoscaler, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = autoscalersClient.Patch(project, zone, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = autoscalersClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, Autoscaler, CallSettings)
            // Additional: PatchAsync(string, string, Autoscaler, CancellationToken)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = await autoscalersClient.PatchAsync(project, zone, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await autoscalersClient.PollOncePatchAsync(operationName);
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
            // Snippet: Update(UpdateAutoscalerRequest, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            UpdateAutoscalerRequest request = new UpdateAutoscalerRequest
            {
                Zone = "",
                RequestId = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = autoscalersClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = autoscalersClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateAutoscalerRequest, CallSettings)
            // Additional: UpdateAsync(UpdateAutoscalerRequest, CancellationToken)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAutoscalerRequest request = new UpdateAutoscalerRequest
            {
                Zone = "",
                RequestId = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await autoscalersClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await autoscalersClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, Autoscaler, CallSettings)
            // Create client
            AutoscalersClient autoscalersClient = AutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = autoscalersClient.Update(project, zone, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = autoscalersClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, Autoscaler, CallSettings)
            // Additional: UpdateAsync(string, string, Autoscaler, CancellationToken)
            // Create client
            AutoscalersClient autoscalersClient = await AutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = await autoscalersClient.UpdateAsync(project, zone, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await autoscalersClient.PollOnceUpdateAsync(operationName);
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
