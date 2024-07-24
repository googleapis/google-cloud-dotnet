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
    public sealed class AllGeneratedSslPoliciesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListSslPoliciesRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            AggregatedListSslPoliciesRequest request = new AggregatedListSslPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<SslPoliciesAggregatedList, KeyValuePair<string, SslPoliciesScopedList>> response = sslPoliciesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, SslPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SslPoliciesAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SslPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SslPoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SslPoliciesScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListSslPoliciesRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListSslPoliciesRequest request = new AggregatedListSslPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<SslPoliciesAggregatedList, KeyValuePair<string, SslPoliciesScopedList>> response = sslPoliciesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, SslPoliciesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SslPoliciesAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SslPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SslPoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SslPoliciesScopedList> item in singlePage)
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
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<SslPoliciesAggregatedList, KeyValuePair<string, SslPoliciesScopedList>> response = sslPoliciesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, SslPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SslPoliciesAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SslPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SslPoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SslPoliciesScopedList> item in singlePage)
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
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<SslPoliciesAggregatedList, KeyValuePair<string, SslPoliciesScopedList>> response = sslPoliciesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, SslPoliciesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SslPoliciesAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, SslPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, SslPoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, SslPoliciesScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteSslPolicyRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteSslPolicyRequest request = new DeleteSslPolicyRequest
            {
                RequestId = "",
                Project = "",
                SslPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = sslPoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = sslPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteSslPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteSslPolicyRequest, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSslPolicyRequest request = new DeleteSslPolicyRequest
            {
                RequestId = "",
                Project = "",
                SslPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await sslPoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await sslPoliciesClient.PollOnceDeleteAsync(operationName);
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
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = sslPoliciesClient.Delete(project, sslPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = sslPoliciesClient.PollOnceDelete(operationName);
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
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await sslPoliciesClient.DeleteAsync(project, sslPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await sslPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetSslPolicyRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            GetSslPolicyRequest request = new GetSslPolicyRequest
            {
                Project = "",
                SslPolicy = "",
            };
            // Make the request
            SslPolicy response = sslPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetSslPolicyRequest, CallSettings)
            // Additional: GetAsync(GetSslPolicyRequest, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetSslPolicyRequest request = new GetSslPolicyRequest
            {
                Project = "",
                SslPolicy = "",
            };
            // Make the request
            SslPolicy response = await sslPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            // Make the request
            SslPolicy response = sslPoliciesClient.Get(project, sslPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            // Make the request
            SslPolicy response = await sslPoliciesClient.GetAsync(project, sslPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertSslPolicyRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            InsertSslPolicyRequest request = new InsertSslPolicyRequest
            {
                RequestId = "",
                Project = "",
                SslPolicyResource = new SslPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = sslPoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = sslPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertSslPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertSslPolicyRequest, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertSslPolicyRequest request = new InsertSslPolicyRequest
            {
                RequestId = "",
                Project = "",
                SslPolicyResource = new SslPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await sslPoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await sslPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, SslPolicy, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = sslPoliciesClient.Insert(project, sslPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = sslPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, SslPolicy, CallSettings)
            // Additional: InsertAsync(string, SslPolicy, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await sslPoliciesClient.InsertAsync(project, sslPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await sslPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListSslPoliciesRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            ListSslPoliciesRequest request = new ListSslPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<SslPoliciesList, SslPolicy> response = sslPoliciesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SslPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SslPoliciesList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslPolicy item in singlePage)
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
            // Snippet: ListAsync(ListSslPoliciesRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListSslPoliciesRequest request = new ListSslPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<SslPoliciesList, SslPolicy> response = sslPoliciesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SslPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SslPoliciesList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslPolicy item in singlePage)
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
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<SslPoliciesList, SslPolicy> response = sslPoliciesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SslPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SslPoliciesList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslPolicy item in singlePage)
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
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<SslPoliciesList, SslPolicy> response = sslPoliciesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SslPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SslPoliciesList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SslPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SslPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SslPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeatures</summary>
        public void ListAvailableFeaturesRequestObject()
        {
            // Snippet: ListAvailableFeatures(ListAvailableFeaturesSslPoliciesRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            ListAvailableFeaturesSslPoliciesRequest request = new ListAvailableFeaturesSslPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = sslPoliciesClient.ListAvailableFeatures(request);
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeaturesAsync</summary>
        public async Task ListAvailableFeaturesRequestObjectAsync()
        {
            // Snippet: ListAvailableFeaturesAsync(ListAvailableFeaturesSslPoliciesRequest, CallSettings)
            // Additional: ListAvailableFeaturesAsync(ListAvailableFeaturesSslPoliciesRequest, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListAvailableFeaturesSslPoliciesRequest request = new ListAvailableFeaturesSslPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = await sslPoliciesClient.ListAvailableFeaturesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeatures</summary>
        public void ListAvailableFeatures()
        {
            // Snippet: ListAvailableFeatures(string, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = sslPoliciesClient.ListAvailableFeatures(project);
            // End snippet
        }

        /// <summary>Snippet for ListAvailableFeaturesAsync</summary>
        public async Task ListAvailableFeaturesAsync()
        {
            // Snippet: ListAvailableFeaturesAsync(string, CallSettings)
            // Additional: ListAvailableFeaturesAsync(string, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = await sslPoliciesClient.ListAvailableFeaturesAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchSslPolicyRequest, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            PatchSslPolicyRequest request = new PatchSslPolicyRequest
            {
                RequestId = "",
                Project = "",
                SslPolicyResource = new SslPolicy(),
                SslPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = sslPoliciesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = sslPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchSslPolicyRequest, CallSettings)
            // Additional: PatchAsync(PatchSslPolicyRequest, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchSslPolicyRequest request = new PatchSslPolicyRequest
            {
                RequestId = "",
                Project = "",
                SslPolicyResource = new SslPolicy(),
                SslPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await sslPoliciesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await sslPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, SslPolicy, CallSettings)
            // Create client
            SslPoliciesClient sslPoliciesClient = SslPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = sslPoliciesClient.Patch(project, sslPolicy, sslPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = sslPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, SslPolicy, CallSettings)
            // Additional: PatchAsync(string, string, SslPolicy, CancellationToken)
            // Create client
            SslPoliciesClient sslPoliciesClient = await SslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string sslPolicy = "";
            SslPolicy sslPolicyResource = new SslPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await sslPoliciesClient.PatchAsync(project, sslPolicy, sslPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await sslPoliciesClient.PollOncePatchAsync(operationName);
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
