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
    public sealed class AllGeneratedTargetPoolsClientSnippets
    {
        /// <summary>Snippet for AddHealthCheck</summary>
        public void AddHealthCheckRequestObject()
        {
            // Snippet: AddHealthCheck(AddHealthCheckTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            AddHealthCheckTargetPoolRequest request = new AddHealthCheckTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
                TargetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.AddHealthCheck(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceAddHealthCheck(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddHealthCheckAsync</summary>
        public async Task AddHealthCheckRequestObjectAsync()
        {
            // Snippet: AddHealthCheckAsync(AddHealthCheckTargetPoolRequest, CallSettings)
            // Additional: AddHealthCheckAsync(AddHealthCheckTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            AddHealthCheckTargetPoolRequest request = new AddHealthCheckTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
                TargetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.AddHealthCheckAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceAddHealthCheckAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddHealthCheck</summary>
        public void AddHealthCheck()
        {
            // Snippet: AddHealthCheck(string, string, string, TargetPoolsAddHealthCheckRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsAddHealthCheckRequest targetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.AddHealthCheck(project, region, targetPool, targetPoolsAddHealthCheckRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceAddHealthCheck(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddHealthCheckAsync</summary>
        public async Task AddHealthCheckAsync()
        {
            // Snippet: AddHealthCheckAsync(string, string, string, TargetPoolsAddHealthCheckRequest, CallSettings)
            // Additional: AddHealthCheckAsync(string, string, string, TargetPoolsAddHealthCheckRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsAddHealthCheckRequest targetPoolsAddHealthCheckRequestResource = new TargetPoolsAddHealthCheckRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.AddHealthCheckAsync(project, region, targetPool, targetPoolsAddHealthCheckRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceAddHealthCheckAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddInstance</summary>
        public void AddInstanceRequestObject()
        {
            // Snippet: AddInstance(AddInstanceTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            AddInstanceTargetPoolRequest request = new AddInstanceTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
                TargetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.AddInstance(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceAddInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddInstanceAsync</summary>
        public async Task AddInstanceRequestObjectAsync()
        {
            // Snippet: AddInstanceAsync(AddInstanceTargetPoolRequest, CallSettings)
            // Additional: AddInstanceAsync(AddInstanceTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            AddInstanceTargetPoolRequest request = new AddInstanceTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
                TargetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.AddInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceAddInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddInstance</summary>
        public void AddInstance()
        {
            // Snippet: AddInstance(string, string, string, TargetPoolsAddInstanceRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsAddInstanceRequest targetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.AddInstance(project, region, targetPool, targetPoolsAddInstanceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceAddInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddInstanceAsync</summary>
        public async Task AddInstanceAsync()
        {
            // Snippet: AddInstanceAsync(string, string, string, TargetPoolsAddInstanceRequest, CallSettings)
            // Additional: AddInstanceAsync(string, string, string, TargetPoolsAddInstanceRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsAddInstanceRequest targetPoolsAddInstanceRequestResource = new TargetPoolsAddInstanceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.AddInstanceAsync(project, region, targetPool, targetPoolsAddInstanceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceAddInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListTargetPoolsRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            AggregatedListTargetPoolsRequest request = new AggregatedListTargetPoolsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetPoolAggregatedList, KeyValuePair<string, TargetPoolsScopedList>> response = targetPoolsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, TargetPoolsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetPoolAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetPoolsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetPoolsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetPoolsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListTargetPoolsRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListTargetPoolsRequest request = new AggregatedListTargetPoolsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetPoolAggregatedList, KeyValuePair<string, TargetPoolsScopedList>> response = targetPoolsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, TargetPoolsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetPoolAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetPoolsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetPoolsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetPoolsScopedList> item in singlePage)
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
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<TargetPoolAggregatedList, KeyValuePair<string, TargetPoolsScopedList>> response = targetPoolsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, TargetPoolsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetPoolAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetPoolsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetPoolsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetPoolsScopedList> item in singlePage)
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
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<TargetPoolAggregatedList, KeyValuePair<string, TargetPoolsScopedList>> response = targetPoolsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, TargetPoolsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetPoolAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetPoolsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetPoolsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetPoolsScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            DeleteTargetPoolRequest request = new DeleteTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteTargetPoolRequest, CallSettings)
            // Additional: DeleteAsync(DeleteTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetPoolRequest request = new DeleteTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceDeleteAsync(operationName);
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
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.Delete(project, region, targetPool);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceDelete(operationName);
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
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.DeleteAsync(project, region, targetPool);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            TargetPool response = targetPoolsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetTargetPoolRequest, CallSettings)
            // Additional: GetAsync(GetTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            TargetPool response = await targetPoolsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            // Make the request
            TargetPool response = targetPoolsClient.Get(project, region, targetPool);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            // Make the request
            TargetPool response = await targetPoolsClient.GetAsync(project, region, targetPool);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealthRequestObject()
        {
            // Snippet: GetHealth(GetHealthTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                TargetPool = "",
                Region = "",
                Project = "",
                InstanceReferenceResource = new InstanceReference(),
            };
            // Make the request
            TargetPoolInstanceHealth response = targetPoolsClient.GetHealth(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthRequestObjectAsync()
        {
            // Snippet: GetHealthAsync(GetHealthTargetPoolRequest, CallSettings)
            // Additional: GetHealthAsync(GetHealthTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                TargetPool = "",
                Region = "",
                Project = "",
                InstanceReferenceResource = new InstanceReference(),
            };
            // Make the request
            TargetPoolInstanceHealth response = await targetPoolsClient.GetHealthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealth()
        {
            // Snippet: GetHealth(string, string, string, InstanceReference, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            InstanceReference instanceReferenceResource = new InstanceReference();
            // Make the request
            TargetPoolInstanceHealth response = targetPoolsClient.GetHealth(project, region, targetPool, instanceReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthAsync()
        {
            // Snippet: GetHealthAsync(string, string, string, InstanceReference, CallSettings)
            // Additional: GetHealthAsync(string, string, string, InstanceReference, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            InstanceReference instanceReferenceResource = new InstanceReference();
            // Make the request
            TargetPoolInstanceHealth response = await targetPoolsClient.GetHealthAsync(project, region, targetPool, instanceReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            InsertTargetPoolRequest request = new InsertTargetPoolRequest
            {
                RequestId = "",
                TargetPoolResource = new TargetPool(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertTargetPoolRequest, CallSettings)
            // Additional: InsertAsync(InsertTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            InsertTargetPoolRequest request = new InsertTargetPoolRequest
            {
                RequestId = "",
                TargetPoolResource = new TargetPool(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, TargetPool, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetPool targetPoolResource = new TargetPool();
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.Insert(project, region, targetPoolResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, TargetPool, CallSettings)
            // Additional: InsertAsync(string, string, TargetPool, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetPool targetPoolResource = new TargetPool();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.InsertAsync(project, region, targetPoolResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListTargetPoolsRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            ListTargetPoolsRequest request = new ListTargetPoolsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetPoolList, TargetPool> response = targetPoolsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetPoolList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetPool item in singlePage)
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
            // Snippet: ListAsync(ListTargetPoolsRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetPoolsRequest request = new ListTargetPoolsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetPoolList, TargetPool> response = targetPoolsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetPoolList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetPool item in singlePage)
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
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<TargetPoolList, TargetPool> response = targetPoolsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetPoolList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetPool item in singlePage)
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
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<TargetPoolList, TargetPool> response = targetPoolsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetPoolList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RemoveHealthCheck</summary>
        public void RemoveHealthCheckRequestObject()
        {
            // Snippet: RemoveHealthCheck(RemoveHealthCheckTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            RemoveHealthCheckTargetPoolRequest request = new RemoveHealthCheckTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
                TargetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.RemoveHealthCheck(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceRemoveHealthCheck(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveHealthCheckAsync</summary>
        public async Task RemoveHealthCheckRequestObjectAsync()
        {
            // Snippet: RemoveHealthCheckAsync(RemoveHealthCheckTargetPoolRequest, CallSettings)
            // Additional: RemoveHealthCheckAsync(RemoveHealthCheckTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            RemoveHealthCheckTargetPoolRequest request = new RemoveHealthCheckTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
                TargetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.RemoveHealthCheckAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceRemoveHealthCheckAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveHealthCheck</summary>
        public void RemoveHealthCheck()
        {
            // Snippet: RemoveHealthCheck(string, string, string, TargetPoolsRemoveHealthCheckRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsRemoveHealthCheckRequest targetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.RemoveHealthCheck(project, region, targetPool, targetPoolsRemoveHealthCheckRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceRemoveHealthCheck(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveHealthCheckAsync</summary>
        public async Task RemoveHealthCheckAsync()
        {
            // Snippet: RemoveHealthCheckAsync(string, string, string, TargetPoolsRemoveHealthCheckRequest, CallSettings)
            // Additional: RemoveHealthCheckAsync(string, string, string, TargetPoolsRemoveHealthCheckRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsRemoveHealthCheckRequest targetPoolsRemoveHealthCheckRequestResource = new TargetPoolsRemoveHealthCheckRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.RemoveHealthCheckAsync(project, region, targetPool, targetPoolsRemoveHealthCheckRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceRemoveHealthCheckAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveInstance</summary>
        public void RemoveInstanceRequestObject()
        {
            // Snippet: RemoveInstance(RemoveInstanceTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            RemoveInstanceTargetPoolRequest request = new RemoveInstanceTargetPoolRequest
            {
                TargetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest(),
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.RemoveInstance(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceRemoveInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveInstanceAsync</summary>
        public async Task RemoveInstanceRequestObjectAsync()
        {
            // Snippet: RemoveInstanceAsync(RemoveInstanceTargetPoolRequest, CallSettings)
            // Additional: RemoveInstanceAsync(RemoveInstanceTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            RemoveInstanceTargetPoolRequest request = new RemoveInstanceTargetPoolRequest
            {
                TargetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest(),
                RequestId = "",
                TargetPool = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.RemoveInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceRemoveInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveInstance</summary>
        public void RemoveInstance()
        {
            // Snippet: RemoveInstance(string, string, string, TargetPoolsRemoveInstanceRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsRemoveInstanceRequest targetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.RemoveInstance(project, region, targetPool, targetPoolsRemoveInstanceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceRemoveInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveInstanceAsync</summary>
        public async Task RemoveInstanceAsync()
        {
            // Snippet: RemoveInstanceAsync(string, string, string, TargetPoolsRemoveInstanceRequest, CallSettings)
            // Additional: RemoveInstanceAsync(string, string, string, TargetPoolsRemoveInstanceRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetPoolsRemoveInstanceRequest targetPoolsRemoveInstanceRequestResource = new TargetPoolsRemoveInstanceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.RemoveInstanceAsync(project, region, targetPool, targetPoolsRemoveInstanceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceRemoveInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetBackup</summary>
        public void SetBackupRequestObject()
        {
            // Snippet: SetBackup(SetBackupTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            SetBackupTargetPoolRequest request = new SetBackupTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                FailoverRatio = 0F,
                Project = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.SetBackup(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceSetBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetBackupAsync</summary>
        public async Task SetBackupRequestObjectAsync()
        {
            // Snippet: SetBackupAsync(SetBackupTargetPoolRequest, CallSettings)
            // Additional: SetBackupAsync(SetBackupTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            SetBackupTargetPoolRequest request = new SetBackupTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                FailoverRatio = 0F,
                Project = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.SetBackupAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceSetBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetBackup</summary>
        public void SetBackup()
        {
            // Snippet: SetBackup(string, string, string, TargetReference, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.SetBackup(project, region, targetPool, targetReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceSetBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetBackupAsync</summary>
        public async Task SetBackupAsync()
        {
            // Snippet: SetBackupAsync(string, string, string, TargetReference, CallSettings)
            // Additional: SetBackupAsync(string, string, string, TargetReference, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.SetBackupAsync(project, region, targetPool, targetReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceSetBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicy</summary>
        public void SetSecurityPolicyRequestObject()
        {
            // Snippet: SetSecurityPolicy(SetSecurityPolicyTargetPoolRequest, CallSettings)
            // Create client
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            SetSecurityPolicyTargetPoolRequest request = new SetSecurityPolicyTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.SetSecurityPolicy(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceSetSecurityPolicy(operationName);
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
            // Snippet: SetSecurityPolicyAsync(SetSecurityPolicyTargetPoolRequest, CallSettings)
            // Additional: SetSecurityPolicyAsync(SetSecurityPolicyTargetPoolRequest, CancellationToken)
            // Create client
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            SetSecurityPolicyTargetPoolRequest request = new SetSecurityPolicyTargetPoolRequest
            {
                RequestId = "",
                TargetPool = "",
                Region = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.SetSecurityPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceSetSecurityPolicyAsync(operationName);
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
            TargetPoolsClient targetPoolsClient = TargetPoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = targetPoolsClient.SetSecurityPolicy(project, region, targetPool, securityPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetPoolsClient.PollOnceSetSecurityPolicy(operationName);
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
            TargetPoolsClient targetPoolsClient = await TargetPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetPool = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetPoolsClient.SetSecurityPolicyAsync(project, region, targetPool, securityPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetPoolsClient.PollOnceSetSecurityPolicyAsync(operationName);
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
