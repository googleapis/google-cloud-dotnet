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
    public sealed class AllGeneratedTargetInstancesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListTargetInstancesRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            AggregatedListTargetInstancesRequest request = new AggregatedListTargetInstancesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetInstanceAggregatedList, KeyValuePair<string, TargetInstancesScopedList>> response = targetInstancesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, TargetInstancesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetInstanceAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetInstancesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetInstancesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetInstancesScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListTargetInstancesRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListTargetInstancesRequest request = new AggregatedListTargetInstancesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetInstanceAggregatedList, KeyValuePair<string, TargetInstancesScopedList>> response = targetInstancesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, TargetInstancesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetInstanceAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetInstancesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetInstancesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetInstancesScopedList> item in singlePage)
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
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<TargetInstanceAggregatedList, KeyValuePair<string, TargetInstancesScopedList>> response = targetInstancesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, TargetInstancesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetInstanceAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetInstancesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetInstancesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetInstancesScopedList> item in singlePage)
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
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<TargetInstanceAggregatedList, KeyValuePair<string, TargetInstancesScopedList>> response = targetInstancesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, TargetInstancesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetInstanceAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetInstancesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetInstancesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetInstancesScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteTargetInstanceRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            DeleteTargetInstanceRequest request = new DeleteTargetInstanceRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                TargetInstance = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetInstancesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetInstancesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteTargetInstanceRequest, CallSettings)
            // Additional: DeleteAsync(DeleteTargetInstanceRequest, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetInstanceRequest request = new DeleteTargetInstanceRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                TargetInstance = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetInstancesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetInstancesClient.PollOnceDeleteAsync(operationName);
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
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string targetInstance = "";
            // Make the request
            lro::Operation<Operation, Operation> response = targetInstancesClient.Delete(project, zone, targetInstance);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetInstancesClient.PollOnceDelete(operationName);
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
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string targetInstance = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await targetInstancesClient.DeleteAsync(project, zone, targetInstance);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetInstancesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetTargetInstanceRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            GetTargetInstanceRequest request = new GetTargetInstanceRequest
            {
                Zone = "",
                Project = "",
                TargetInstance = "",
            };
            // Make the request
            TargetInstance response = targetInstancesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetTargetInstanceRequest, CallSettings)
            // Additional: GetAsync(GetTargetInstanceRequest, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetInstanceRequest request = new GetTargetInstanceRequest
            {
                Zone = "",
                Project = "",
                TargetInstance = "",
            };
            // Make the request
            TargetInstance response = await targetInstancesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string targetInstance = "";
            // Make the request
            TargetInstance response = targetInstancesClient.Get(project, zone, targetInstance);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string targetInstance = "";
            // Make the request
            TargetInstance response = await targetInstancesClient.GetAsync(project, zone, targetInstance);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertTargetInstanceRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            InsertTargetInstanceRequest request = new InsertTargetInstanceRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                TargetInstanceResource = new TargetInstance(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetInstancesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetInstancesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertTargetInstanceRequest, CallSettings)
            // Additional: InsertAsync(InsertTargetInstanceRequest, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            InsertTargetInstanceRequest request = new InsertTargetInstanceRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                TargetInstanceResource = new TargetInstance(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetInstancesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetInstancesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, TargetInstance, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            TargetInstance targetInstanceResource = new TargetInstance();
            // Make the request
            lro::Operation<Operation, Operation> response = targetInstancesClient.Insert(project, zone, targetInstanceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetInstancesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, TargetInstance, CallSettings)
            // Additional: InsertAsync(string, string, TargetInstance, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            TargetInstance targetInstanceResource = new TargetInstance();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetInstancesClient.InsertAsync(project, zone, targetInstanceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetInstancesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListTargetInstancesRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            ListTargetInstancesRequest request = new ListTargetInstancesRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetInstanceList, TargetInstance> response = targetInstancesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetInstanceList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetInstance item in singlePage)
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
            // Snippet: ListAsync(ListTargetInstancesRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetInstancesRequest request = new ListTargetInstancesRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetInstanceList, TargetInstance> response = targetInstancesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetInstance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetInstanceList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetInstance item in singlePage)
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
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<TargetInstanceList, TargetInstance> response = targetInstancesClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetInstanceList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetInstance item in singlePage)
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
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<TargetInstanceList, TargetInstance> response = targetInstancesClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetInstance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetInstanceList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicy</summary>
        public void SetSecurityPolicyRequestObject()
        {
            // Snippet: SetSecurityPolicy(SetSecurityPolicyTargetInstanceRequest, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            SetSecurityPolicyTargetInstanceRequest request = new SetSecurityPolicyTargetInstanceRequest
            {
                Zone = "",
                RequestId = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
                TargetInstance = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetInstancesClient.SetSecurityPolicy(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetInstancesClient.PollOnceSetSecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicyAsync</summary>
        public async Task SetSecurityPolicyRequestObjectAsync()
        {
            // Snippet: SetSecurityPolicyAsync(SetSecurityPolicyTargetInstanceRequest, CallSettings)
            // Additional: SetSecurityPolicyAsync(SetSecurityPolicyTargetInstanceRequest, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            SetSecurityPolicyTargetInstanceRequest request = new SetSecurityPolicyTargetInstanceRequest
            {
                Zone = "",
                RequestId = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
                TargetInstance = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetInstancesClient.SetSecurityPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetInstancesClient.PollOnceSetSecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicy</summary>
        public void SetSecurityPolicy()
        {
            // Snippet: SetSecurityPolicy(string, string, string, SecurityPolicyReference, CallSettings)
            // Create client
            TargetInstancesClient targetInstancesClient = TargetInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string targetInstance = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = targetInstancesClient.SetSecurityPolicy(project, zone, targetInstance, securityPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetInstancesClient.PollOnceSetSecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicyAsync</summary>
        public async Task SetSecurityPolicyAsync()
        {
            // Snippet: SetSecurityPolicyAsync(string, string, string, SecurityPolicyReference, CallSettings)
            // Additional: SetSecurityPolicyAsync(string, string, string, SecurityPolicyReference, CancellationToken)
            // Create client
            TargetInstancesClient targetInstancesClient = await TargetInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string targetInstance = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetInstancesClient.SetSecurityPolicyAsync(project, zone, targetInstance, securityPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetInstancesClient.PollOnceSetSecurityPolicyAsync(operationName);
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
