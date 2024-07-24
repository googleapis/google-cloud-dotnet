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
    public sealed class AllGeneratedForwardingRulesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListForwardingRulesRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            AggregatedListForwardingRulesRequest request = new AggregatedListForwardingRulesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ForwardingRuleAggregatedList, KeyValuePair<string, ForwardingRulesScopedList>> response = forwardingRulesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, ForwardingRulesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ForwardingRuleAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ForwardingRulesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ForwardingRulesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ForwardingRulesScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListForwardingRulesRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListForwardingRulesRequest request = new AggregatedListForwardingRulesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ForwardingRuleAggregatedList, KeyValuePair<string, ForwardingRulesScopedList>> response = forwardingRulesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, ForwardingRulesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ForwardingRuleAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ForwardingRulesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ForwardingRulesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ForwardingRulesScopedList> item in singlePage)
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
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<ForwardingRuleAggregatedList, KeyValuePair<string, ForwardingRulesScopedList>> response = forwardingRulesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, ForwardingRulesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ForwardingRuleAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ForwardingRulesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ForwardingRulesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ForwardingRulesScopedList> item in singlePage)
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
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<ForwardingRuleAggregatedList, KeyValuePair<string, ForwardingRulesScopedList>> response = forwardingRulesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, ForwardingRulesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ForwardingRuleAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ForwardingRulesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ForwardingRulesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ForwardingRulesScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            DeleteForwardingRuleRequest request = new DeleteForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = forwardingRulesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = forwardingRulesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteForwardingRuleRequest, CallSettings)
            // Additional: DeleteAsync(DeleteForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteForwardingRuleRequest request = new DeleteForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await forwardingRulesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await forwardingRulesClient.PollOnceDeleteAsync(operationName);
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
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            // Make the request
            lro::Operation<Operation, Operation> response = forwardingRulesClient.Delete(project, region, forwardingRule);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = forwardingRulesClient.PollOnceDelete(operationName);
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
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await forwardingRulesClient.DeleteAsync(project, region, forwardingRule);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await forwardingRulesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            GetForwardingRuleRequest request = new GetForwardingRuleRequest
            {
                Region = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            ForwardingRule response = forwardingRulesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetForwardingRuleRequest, CallSettings)
            // Additional: GetAsync(GetForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            GetForwardingRuleRequest request = new GetForwardingRuleRequest
            {
                Region = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            ForwardingRule response = await forwardingRulesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            // Make the request
            ForwardingRule response = forwardingRulesClient.Get(project, region, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            // Make the request
            ForwardingRule response = await forwardingRulesClient.GetAsync(project, region, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            InsertForwardingRuleRequest request = new InsertForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = forwardingRulesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = forwardingRulesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertForwardingRuleRequest, CallSettings)
            // Additional: InsertAsync(InsertForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            InsertForwardingRuleRequest request = new InsertForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await forwardingRulesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await forwardingRulesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, ForwardingRule, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            lro::Operation<Operation, Operation> response = forwardingRulesClient.Insert(project, region, forwardingRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = forwardingRulesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, ForwardingRule, CallSettings)
            // Additional: InsertAsync(string, string, ForwardingRule, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await forwardingRulesClient.InsertAsync(project, region, forwardingRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await forwardingRulesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListForwardingRulesRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            ListForwardingRulesRequest request = new ListForwardingRulesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ForwardingRuleList, ForwardingRule> response = forwardingRulesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ForwardingRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ForwardingRuleList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForwardingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForwardingRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForwardingRule item in singlePage)
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
            // Snippet: ListAsync(ListForwardingRulesRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            ListForwardingRulesRequest request = new ListForwardingRulesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ForwardingRuleList, ForwardingRule> response = forwardingRulesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ForwardingRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ForwardingRuleList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForwardingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForwardingRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForwardingRule item in singlePage)
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
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<ForwardingRuleList, ForwardingRule> response = forwardingRulesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ForwardingRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ForwardingRuleList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForwardingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForwardingRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForwardingRule item in singlePage)
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
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<ForwardingRuleList, ForwardingRule> response = forwardingRulesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ForwardingRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ForwardingRuleList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForwardingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForwardingRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForwardingRule item in singlePage)
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
            // Snippet: Patch(PatchForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            PatchForwardingRuleRequest request = new PatchForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = forwardingRulesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = forwardingRulesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchForwardingRuleRequest, CallSettings)
            // Additional: PatchAsync(PatchForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            PatchForwardingRuleRequest request = new PatchForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await forwardingRulesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await forwardingRulesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, ForwardingRule, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            lro::Operation<Operation, Operation> response = forwardingRulesClient.Patch(project, region, forwardingRule, forwardingRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = forwardingRulesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, ForwardingRule, CallSettings)
            // Additional: PatchAsync(string, string, string, ForwardingRule, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await forwardingRulesClient.PatchAsync(project, region, forwardingRule, forwardingRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await forwardingRulesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            SetLabelsForwardingRuleRequest request = new SetLabelsForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = forwardingRulesClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = forwardingRulesClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsForwardingRuleRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsForwardingRuleRequest request = new SetLabelsForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await forwardingRulesClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await forwardingRulesClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = forwardingRulesClient.SetLabels(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = forwardingRulesClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await forwardingRulesClient.SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await forwardingRulesClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTarget</summary>
        public void SetTargetRequestObject()
        {
            // Snippet: SetTarget(SetTargetForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            SetTargetForwardingRuleRequest request = new SetTargetForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = forwardingRulesClient.SetTarget(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = forwardingRulesClient.PollOnceSetTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetAsync</summary>
        public async Task SetTargetRequestObjectAsync()
        {
            // Snippet: SetTargetAsync(SetTargetForwardingRuleRequest, CallSettings)
            // Additional: SetTargetAsync(SetTargetForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            SetTargetForwardingRuleRequest request = new SetTargetForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await forwardingRulesClient.SetTargetAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await forwardingRulesClient.PollOnceSetTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTarget</summary>
        public void SetTarget()
        {
            // Snippet: SetTarget(string, string, string, TargetReference, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            lro::Operation<Operation, Operation> response = forwardingRulesClient.SetTarget(project, region, forwardingRule, targetReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = forwardingRulesClient.PollOnceSetTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetAsync</summary>
        public async Task SetTargetAsync()
        {
            // Snippet: SetTargetAsync(string, string, string, TargetReference, CallSettings)
            // Additional: SetTargetAsync(string, string, string, TargetReference, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await forwardingRulesClient.SetTargetAsync(project, region, forwardingRule, targetReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await forwardingRulesClient.PollOnceSetTargetAsync(operationName);
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
