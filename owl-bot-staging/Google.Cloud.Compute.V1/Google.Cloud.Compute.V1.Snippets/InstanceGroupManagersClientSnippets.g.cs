// Copyright 2025 Google LLC
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
    public sealed class AllGeneratedInstanceGroupManagersClientSnippets
    {
        /// <summary>Snippet for AbandonInstances</summary>
        public void AbandonInstancesRequestObject()
        {
            // Snippet: AbandonInstances(AbandonInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            AbandonInstancesInstanceGroupManagerRequest request = new AbandonInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.AbandonInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceAbandonInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonInstancesAsync</summary>
        public async Task AbandonInstancesRequestObjectAsync()
        {
            // Snippet: AbandonInstancesAsync(AbandonInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: AbandonInstancesAsync(AbandonInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            AbandonInstancesInstanceGroupManagerRequest request = new AbandonInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.AbandonInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceAbandonInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonInstances</summary>
        public void AbandonInstances()
        {
            // Snippet: AbandonInstances(string, string, string, InstanceGroupManagersAbandonInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersAbandonInstancesRequest instanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.AbandonInstances(project, zone, instanceGroupManager, instanceGroupManagersAbandonInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceAbandonInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonInstancesAsync</summary>
        public async Task AbandonInstancesAsync()
        {
            // Snippet: AbandonInstancesAsync(string, string, string, InstanceGroupManagersAbandonInstancesRequest, CallSettings)
            // Additional: AbandonInstancesAsync(string, string, string, InstanceGroupManagersAbandonInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersAbandonInstancesRequest instanceGroupManagersAbandonInstancesRequestResource = new InstanceGroupManagersAbandonInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.AbandonInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersAbandonInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceAbandonInstancesAsync(operationName);
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
            // Snippet: AggregatedList(AggregatedListInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            AggregatedListInstanceGroupManagersRequest request = new AggregatedListInstanceGroupManagersRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstanceGroupManagerAggregatedList, KeyValuePair<string, InstanceGroupManagersScopedList>> response = instanceGroupManagersClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, InstanceGroupManagersScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupManagerAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstanceGroupManagersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstanceGroupManagersScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstanceGroupManagersScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListInstanceGroupManagersRequest request = new AggregatedListInstanceGroupManagersRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstanceGroupManagerAggregatedList, KeyValuePair<string, InstanceGroupManagersScopedList>> response = instanceGroupManagersClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, InstanceGroupManagersScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupManagerAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstanceGroupManagersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstanceGroupManagersScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstanceGroupManagersScopedList> item in singlePage)
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
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<InstanceGroupManagerAggregatedList, KeyValuePair<string, InstanceGroupManagersScopedList>> response = instanceGroupManagersClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, InstanceGroupManagersScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupManagerAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstanceGroupManagersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstanceGroupManagersScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstanceGroupManagersScopedList> item in singlePage)
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
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<InstanceGroupManagerAggregatedList, KeyValuePair<string, InstanceGroupManagersScopedList>> response = instanceGroupManagersClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, InstanceGroupManagersScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupManagerAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstanceGroupManagersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstanceGroupManagersScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstanceGroupManagersScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstances</summary>
        public void ApplyUpdatesToInstancesRequestObject()
        {
            // Snippet: ApplyUpdatesToInstances(ApplyUpdatesToInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ApplyUpdatesToInstancesInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.ApplyUpdatesToInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceApplyUpdatesToInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstancesAsync</summary>
        public async Task ApplyUpdatesToInstancesRequestObjectAsync()
        {
            // Snippet: ApplyUpdatesToInstancesAsync(ApplyUpdatesToInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: ApplyUpdatesToInstancesAsync(ApplyUpdatesToInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ApplyUpdatesToInstancesInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.ApplyUpdatesToInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceApplyUpdatesToInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstances</summary>
        public void ApplyUpdatesToInstances()
        {
            // Snippet: ApplyUpdatesToInstances(string, string, string, InstanceGroupManagersApplyUpdatesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersApplyUpdatesRequest instanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.ApplyUpdatesToInstances(project, zone, instanceGroupManager, instanceGroupManagersApplyUpdatesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceApplyUpdatesToInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstancesAsync</summary>
        public async Task ApplyUpdatesToInstancesAsync()
        {
            // Snippet: ApplyUpdatesToInstancesAsync(string, string, string, InstanceGroupManagersApplyUpdatesRequest, CallSettings)
            // Additional: ApplyUpdatesToInstancesAsync(string, string, string, InstanceGroupManagersApplyUpdatesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersApplyUpdatesRequest instanceGroupManagersApplyUpdatesRequestResource = new InstanceGroupManagersApplyUpdatesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.ApplyUpdatesToInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersApplyUpdatesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceApplyUpdatesToInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstances</summary>
        public void CreateInstancesRequestObject()
        {
            // Snippet: CreateInstances(CreateInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            CreateInstancesInstanceGroupManagerRequest request = new CreateInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.CreateInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceCreateInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstancesAsync</summary>
        public async Task CreateInstancesRequestObjectAsync()
        {
            // Snippet: CreateInstancesAsync(CreateInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: CreateInstancesAsync(CreateInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstancesInstanceGroupManagerRequest request = new CreateInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.CreateInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceCreateInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstances</summary>
        public void CreateInstances()
        {
            // Snippet: CreateInstances(string, string, string, InstanceGroupManagersCreateInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersCreateInstancesRequest instanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.CreateInstances(project, zone, instanceGroupManager, instanceGroupManagersCreateInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceCreateInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstancesAsync</summary>
        public async Task CreateInstancesAsync()
        {
            // Snippet: CreateInstancesAsync(string, string, string, InstanceGroupManagersCreateInstancesRequest, CallSettings)
            // Additional: CreateInstancesAsync(string, string, string, InstanceGroupManagersCreateInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersCreateInstancesRequest instanceGroupManagersCreateInstancesRequestResource = new InstanceGroupManagersCreateInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.CreateInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersCreateInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceCreateInstancesAsync(operationName);
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
            // Snippet: Delete(DeleteInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeleteInstanceGroupManagerRequest request = new DeleteInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteInstanceGroupManagerRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceGroupManagerRequest request = new DeleteInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceDeleteAsync(operationName);
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
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.Delete(project, zone, instanceGroupManager);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceDelete(operationName);
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
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.DeleteAsync(project, zone, instanceGroupManager);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstances</summary>
        public void DeleteInstancesRequestObject()
        {
            // Snippet: DeleteInstances(DeleteInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeleteInstancesInstanceGroupManagerRequest request = new DeleteInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.DeleteInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceDeleteInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancesAsync</summary>
        public async Task DeleteInstancesRequestObjectAsync()
        {
            // Snippet: DeleteInstancesAsync(DeleteInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: DeleteInstancesAsync(DeleteInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstancesInstanceGroupManagerRequest request = new DeleteInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.DeleteInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceDeleteInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstances</summary>
        public void DeleteInstances()
        {
            // Snippet: DeleteInstances(string, string, string, InstanceGroupManagersDeleteInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersDeleteInstancesRequest instanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.DeleteInstances(project, zone, instanceGroupManager, instanceGroupManagersDeleteInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceDeleteInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancesAsync</summary>
        public async Task DeleteInstancesAsync()
        {
            // Snippet: DeleteInstancesAsync(string, string, string, InstanceGroupManagersDeleteInstancesRequest, CallSettings)
            // Additional: DeleteInstancesAsync(string, string, string, InstanceGroupManagersDeleteInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersDeleteInstancesRequest instanceGroupManagersDeleteInstancesRequestResource = new InstanceGroupManagersDeleteInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.DeleteInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersDeleteInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceDeleteInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigs</summary>
        public void DeletePerInstanceConfigsRequestObject()
        {
            // Snippet: DeletePerInstanceConfigs(DeletePerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeletePerInstanceConfigsInstanceGroupManagerRequest request = new DeletePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.DeletePerInstanceConfigs(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceDeletePerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigsAsync</summary>
        public async Task DeletePerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: DeletePerInstanceConfigsAsync(DeletePerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Additional: DeletePerInstanceConfigsAsync(DeletePerInstanceConfigsInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeletePerInstanceConfigsInstanceGroupManagerRequest request = new DeletePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.DeletePerInstanceConfigsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceDeletePerInstanceConfigsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigs</summary>
        public void DeletePerInstanceConfigs()
        {
            // Snippet: DeletePerInstanceConfigs(string, string, string, InstanceGroupManagersDeletePerInstanceConfigsReq, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersDeletePerInstanceConfigsReq instanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.DeletePerInstanceConfigs(project, zone, instanceGroupManager, instanceGroupManagersDeletePerInstanceConfigsReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceDeletePerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigsAsync</summary>
        public async Task DeletePerInstanceConfigsAsync()
        {
            // Snippet: DeletePerInstanceConfigsAsync(string, string, string, InstanceGroupManagersDeletePerInstanceConfigsReq, CallSettings)
            // Additional: DeletePerInstanceConfigsAsync(string, string, string, InstanceGroupManagersDeletePerInstanceConfigsReq, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersDeletePerInstanceConfigsReq instanceGroupManagersDeletePerInstanceConfigsReqResource = new InstanceGroupManagersDeletePerInstanceConfigsReq();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.DeletePerInstanceConfigsAsync(project, zone, instanceGroupManager, instanceGroupManagersDeletePerInstanceConfigsReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceDeletePerInstanceConfigsAsync(operationName);
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
            // Snippet: Get(GetInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            GetInstanceGroupManagerRequest request = new GetInstanceGroupManagerRequest
            {
                Zone = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManager response = instanceGroupManagersClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInstanceGroupManagerRequest, CallSettings)
            // Additional: GetAsync(GetInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceGroupManagerRequest request = new GetInstanceGroupManagerRequest
            {
                Zone = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManager response = await instanceGroupManagersClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManager response = instanceGroupManagersClient.Get(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManager response = await instanceGroupManagersClient.GetAsync(project, zone, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            InsertInstanceGroupManagerRequest request = new InsertInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertInstanceGroupManagerRequest, CallSettings)
            // Additional: InsertAsync(InsertInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            InsertInstanceGroupManagerRequest request = new InsertInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, InstanceGroupManager, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.Insert(project, zone, instanceGroupManagerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, InstanceGroupManager, CallSettings)
            // Additional: InsertAsync(string, string, InstanceGroupManager, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.InsertAsync(project, zone, instanceGroupManagerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListInstanceGroupManagersRequest request = new ListInstanceGroupManagersRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstanceGroupManagerList, InstanceGroupManager> response = instanceGroupManagersClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceGroupManager item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupManagerList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManager item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManager> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManager item in singlePage)
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
            // Snippet: ListAsync(ListInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListInstanceGroupManagersRequest request = new ListInstanceGroupManagersRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstanceGroupManagerList, InstanceGroupManager> response = instanceGroupManagersClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceGroupManager item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupManagerList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManager item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManager> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManager item in singlePage)
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
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<InstanceGroupManagerList, InstanceGroupManager> response = instanceGroupManagersClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceGroupManager item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupManagerList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManager item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManager> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManager item in singlePage)
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
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<InstanceGroupManagerList, InstanceGroupManager> response = instanceGroupManagersClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceGroupManager item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupManagerList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManager item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManager> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManager item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrors</summary>
        public void ListErrorsRequestObject()
        {
            // Snippet: ListErrors(ListErrorsInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListErrorsInstanceGroupManagersRequest request = new ListErrorsInstanceGroupManagersRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstanceGroupManagersListErrorsResponse, InstanceManagedByIgmError> response = instanceGroupManagersClient.ListErrors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceManagedByIgmError item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupManagersListErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceManagedByIgmError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceManagedByIgmError> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceManagedByIgmError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrorsAsync</summary>
        public async Task ListErrorsRequestObjectAsync()
        {
            // Snippet: ListErrorsAsync(ListErrorsInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListErrorsInstanceGroupManagersRequest request = new ListErrorsInstanceGroupManagersRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstanceGroupManagersListErrorsResponse, InstanceManagedByIgmError> response = instanceGroupManagersClient.ListErrorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceManagedByIgmError item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupManagersListErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceManagedByIgmError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceManagedByIgmError> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceManagedByIgmError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrors</summary>
        public void ListErrors()
        {
            // Snippet: ListErrors(string, string, string, string, int?, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            PagedEnumerable<InstanceGroupManagersListErrorsResponse, InstanceManagedByIgmError> response = instanceGroupManagersClient.ListErrors(project, zone, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceManagedByIgmError item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupManagersListErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceManagedByIgmError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceManagedByIgmError> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceManagedByIgmError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrorsAsync</summary>
        public async Task ListErrorsAsync()
        {
            // Snippet: ListErrorsAsync(string, string, string, string, int?, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            PagedAsyncEnumerable<InstanceGroupManagersListErrorsResponse, InstanceManagedByIgmError> response = instanceGroupManagersClient.ListErrorsAsync(project, zone, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceManagedByIgmError item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupManagersListErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceManagedByIgmError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceManagedByIgmError> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceManagedByIgmError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstances</summary>
        public void ListManagedInstancesRequestObject()
        {
            // Snippet: ListManagedInstances(ListManagedInstancesInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListManagedInstancesInstanceGroupManagersRequest request = new ListManagedInstancesInstanceGroupManagersRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstanceGroupManagersListManagedInstancesResponse, ManagedInstance> response = instanceGroupManagersClient.ListManagedInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagedInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupManagersListManagedInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstancesAsync</summary>
        public async Task ListManagedInstancesRequestObjectAsync()
        {
            // Snippet: ListManagedInstancesAsync(ListManagedInstancesInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListManagedInstancesInstanceGroupManagersRequest request = new ListManagedInstancesInstanceGroupManagersRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstanceGroupManagersListManagedInstancesResponse, ManagedInstance> response = instanceGroupManagersClient.ListManagedInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagedInstance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupManagersListManagedInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstances</summary>
        public void ListManagedInstances()
        {
            // Snippet: ListManagedInstances(string, string, string, string, int?, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            PagedEnumerable<InstanceGroupManagersListManagedInstancesResponse, ManagedInstance> response = instanceGroupManagersClient.ListManagedInstances(project, zone, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagedInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupManagersListManagedInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstancesAsync</summary>
        public async Task ListManagedInstancesAsync()
        {
            // Snippet: ListManagedInstancesAsync(string, string, string, string, int?, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            PagedAsyncEnumerable<InstanceGroupManagersListManagedInstancesResponse, ManagedInstance> response = instanceGroupManagersClient.ListManagedInstancesAsync(project, zone, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagedInstance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupManagersListManagedInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigs</summary>
        public void ListPerInstanceConfigsRequestObject()
        {
            // Snippet: ListPerInstanceConfigs(ListPerInstanceConfigsInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListPerInstanceConfigsInstanceGroupManagersRequest request = new ListPerInstanceConfigsInstanceGroupManagersRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstanceGroupManagersListPerInstanceConfigsResp, PerInstanceConfig> response = instanceGroupManagersClient.ListPerInstanceConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PerInstanceConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupManagersListPerInstanceConfigsResp page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PerInstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PerInstanceConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PerInstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigsAsync</summary>
        public async Task ListPerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: ListPerInstanceConfigsAsync(ListPerInstanceConfigsInstanceGroupManagersRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListPerInstanceConfigsInstanceGroupManagersRequest request = new ListPerInstanceConfigsInstanceGroupManagersRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstanceGroupManagersListPerInstanceConfigsResp, PerInstanceConfig> response = instanceGroupManagersClient.ListPerInstanceConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PerInstanceConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupManagersListPerInstanceConfigsResp page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PerInstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PerInstanceConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PerInstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigs</summary>
        public void ListPerInstanceConfigs()
        {
            // Snippet: ListPerInstanceConfigs(string, string, string, string, int?, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            PagedEnumerable<InstanceGroupManagersListPerInstanceConfigsResp, PerInstanceConfig> response = instanceGroupManagersClient.ListPerInstanceConfigs(project, zone, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PerInstanceConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupManagersListPerInstanceConfigsResp page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PerInstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PerInstanceConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PerInstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigsAsync</summary>
        public async Task ListPerInstanceConfigsAsync()
        {
            // Snippet: ListPerInstanceConfigsAsync(string, string, string, string, int?, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            // Make the request
            PagedAsyncEnumerable<InstanceGroupManagersListPerInstanceConfigsResp, PerInstanceConfig> response = instanceGroupManagersClient.ListPerInstanceConfigsAsync(project, zone, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PerInstanceConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupManagersListPerInstanceConfigsResp page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PerInstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PerInstanceConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PerInstanceConfig item in singlePage)
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
            // Snippet: Patch(PatchInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            PatchInstanceGroupManagerRequest request = new PatchInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchInstanceGroupManagerRequest, CallSettings)
            // Additional: PatchAsync(PatchInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            PatchInstanceGroupManagerRequest request = new PatchInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, InstanceGroupManager, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.Patch(project, zone, instanceGroupManager, instanceGroupManagerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, InstanceGroupManager, CallSettings)
            // Additional: PatchAsync(string, string, string, InstanceGroupManager, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.PatchAsync(project, zone, instanceGroupManager, instanceGroupManagerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigs</summary>
        public void PatchPerInstanceConfigsRequestObject()
        {
            // Snippet: PatchPerInstanceConfigs(PatchPerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            PatchPerInstanceConfigsInstanceGroupManagerRequest request = new PatchPerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.PatchPerInstanceConfigs(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOncePatchPerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigsAsync</summary>
        public async Task PatchPerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: PatchPerInstanceConfigsAsync(PatchPerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Additional: PatchPerInstanceConfigsAsync(PatchPerInstanceConfigsInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            PatchPerInstanceConfigsInstanceGroupManagerRequest request = new PatchPerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.PatchPerInstanceConfigsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOncePatchPerInstanceConfigsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigs</summary>
        public void PatchPerInstanceConfigs()
        {
            // Snippet: PatchPerInstanceConfigs(string, string, string, InstanceGroupManagersPatchPerInstanceConfigsReq, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersPatchPerInstanceConfigsReq instanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.PatchPerInstanceConfigs(project, zone, instanceGroupManager, instanceGroupManagersPatchPerInstanceConfigsReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOncePatchPerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigsAsync</summary>
        public async Task PatchPerInstanceConfigsAsync()
        {
            // Snippet: PatchPerInstanceConfigsAsync(string, string, string, InstanceGroupManagersPatchPerInstanceConfigsReq, CallSettings)
            // Additional: PatchPerInstanceConfigsAsync(string, string, string, InstanceGroupManagersPatchPerInstanceConfigsReq, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersPatchPerInstanceConfigsReq instanceGroupManagersPatchPerInstanceConfigsReqResource = new InstanceGroupManagersPatchPerInstanceConfigsReq();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.PatchPerInstanceConfigsAsync(project, zone, instanceGroupManager, instanceGroupManagersPatchPerInstanceConfigsReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOncePatchPerInstanceConfigsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecreateInstances</summary>
        public void RecreateInstancesRequestObject()
        {
            // Snippet: RecreateInstances(RecreateInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            RecreateInstancesInstanceGroupManagerRequest request = new RecreateInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.RecreateInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceRecreateInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecreateInstancesAsync</summary>
        public async Task RecreateInstancesRequestObjectAsync()
        {
            // Snippet: RecreateInstancesAsync(RecreateInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: RecreateInstancesAsync(RecreateInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            RecreateInstancesInstanceGroupManagerRequest request = new RecreateInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.RecreateInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceRecreateInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecreateInstances</summary>
        public void RecreateInstances()
        {
            // Snippet: RecreateInstances(string, string, string, InstanceGroupManagersRecreateInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersRecreateInstancesRequest instanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.RecreateInstances(project, zone, instanceGroupManager, instanceGroupManagersRecreateInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceRecreateInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecreateInstancesAsync</summary>
        public async Task RecreateInstancesAsync()
        {
            // Snippet: RecreateInstancesAsync(string, string, string, InstanceGroupManagersRecreateInstancesRequest, CallSettings)
            // Additional: RecreateInstancesAsync(string, string, string, InstanceGroupManagersRecreateInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersRecreateInstancesRequest instanceGroupManagersRecreateInstancesRequestResource = new InstanceGroupManagersRecreateInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.RecreateInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersRecreateInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceRecreateInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void ResizeRequestObject()
        {
            // Snippet: Resize(ResizeInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ResizeInstanceGroupManagerRequest request = new ResizeInstanceGroupManagerRequest
            {
                Size = 0,
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.Resize(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceResize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeRequestObjectAsync()
        {
            // Snippet: ResizeAsync(ResizeInstanceGroupManagerRequest, CallSettings)
            // Additional: ResizeAsync(ResizeInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ResizeInstanceGroupManagerRequest request = new ResizeInstanceGroupManagerRequest
            {
                Size = 0,
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.ResizeAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceResizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void Resize()
        {
            // Snippet: Resize(string, string, string, int, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            int size = 0;
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.Resize(project, zone, instanceGroupManager, size);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceResize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeAsync()
        {
            // Snippet: ResizeAsync(string, string, string, int, CallSettings)
            // Additional: ResizeAsync(string, string, string, int, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            int size = 0;
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.ResizeAsync(project, zone, instanceGroupManager, size);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceResizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeInstances</summary>
        public void ResumeInstancesRequestObject()
        {
            // Snippet: ResumeInstances(ResumeInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ResumeInstancesInstanceGroupManagerRequest request = new ResumeInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersResumeInstancesRequestResource = new InstanceGroupManagersResumeInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.ResumeInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceResumeInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeInstancesAsync</summary>
        public async Task ResumeInstancesRequestObjectAsync()
        {
            // Snippet: ResumeInstancesAsync(ResumeInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: ResumeInstancesAsync(ResumeInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ResumeInstancesInstanceGroupManagerRequest request = new ResumeInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersResumeInstancesRequestResource = new InstanceGroupManagersResumeInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.ResumeInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceResumeInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeInstances</summary>
        public void ResumeInstances()
        {
            // Snippet: ResumeInstances(string, string, string, InstanceGroupManagersResumeInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersResumeInstancesRequest instanceGroupManagersResumeInstancesRequestResource = new InstanceGroupManagersResumeInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.ResumeInstances(project, zone, instanceGroupManager, instanceGroupManagersResumeInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceResumeInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeInstancesAsync</summary>
        public async Task ResumeInstancesAsync()
        {
            // Snippet: ResumeInstancesAsync(string, string, string, InstanceGroupManagersResumeInstancesRequest, CallSettings)
            // Additional: ResumeInstancesAsync(string, string, string, InstanceGroupManagersResumeInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersResumeInstancesRequest instanceGroupManagersResumeInstancesRequestResource = new InstanceGroupManagersResumeInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.ResumeInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersResumeInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceResumeInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplate</summary>
        public void SetInstanceTemplateRequestObject()
        {
            // Snippet: SetInstanceTemplate(SetInstanceTemplateInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            SetInstanceTemplateInstanceGroupManagerRequest request = new SetInstanceTemplateInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.SetInstanceTemplate(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceSetInstanceTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplateAsync</summary>
        public async Task SetInstanceTemplateRequestObjectAsync()
        {
            // Snippet: SetInstanceTemplateAsync(SetInstanceTemplateInstanceGroupManagerRequest, CallSettings)
            // Additional: SetInstanceTemplateAsync(SetInstanceTemplateInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            SetInstanceTemplateInstanceGroupManagerRequest request = new SetInstanceTemplateInstanceGroupManagerRequest
            {
                Zone = "",
                InstanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest(),
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.SetInstanceTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceSetInstanceTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplate</summary>
        public void SetInstanceTemplate()
        {
            // Snippet: SetInstanceTemplate(string, string, string, InstanceGroupManagersSetInstanceTemplateRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersSetInstanceTemplateRequest instanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.SetInstanceTemplate(project, zone, instanceGroupManager, instanceGroupManagersSetInstanceTemplateRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceSetInstanceTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplateAsync</summary>
        public async Task SetInstanceTemplateAsync()
        {
            // Snippet: SetInstanceTemplateAsync(string, string, string, InstanceGroupManagersSetInstanceTemplateRequest, CallSettings)
            // Additional: SetInstanceTemplateAsync(string, string, string, InstanceGroupManagersSetInstanceTemplateRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersSetInstanceTemplateRequest instanceGroupManagersSetInstanceTemplateRequestResource = new InstanceGroupManagersSetInstanceTemplateRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.SetInstanceTemplateAsync(project, zone, instanceGroupManager, instanceGroupManagersSetInstanceTemplateRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceSetInstanceTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetPools</summary>
        public void SetTargetPoolsRequestObject()
        {
            // Snippet: SetTargetPools(SetTargetPoolsInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            SetTargetPoolsInstanceGroupManagerRequest request = new SetTargetPoolsInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.SetTargetPools(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceSetTargetPools(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetPoolsAsync</summary>
        public async Task SetTargetPoolsRequestObjectAsync()
        {
            // Snippet: SetTargetPoolsAsync(SetTargetPoolsInstanceGroupManagerRequest, CallSettings)
            // Additional: SetTargetPoolsAsync(SetTargetPoolsInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            SetTargetPoolsInstanceGroupManagerRequest request = new SetTargetPoolsInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.SetTargetPoolsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceSetTargetPoolsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetPools</summary>
        public void SetTargetPools()
        {
            // Snippet: SetTargetPools(string, string, string, InstanceGroupManagersSetTargetPoolsRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersSetTargetPoolsRequest instanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.SetTargetPools(project, zone, instanceGroupManager, instanceGroupManagersSetTargetPoolsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceSetTargetPools(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetPoolsAsync</summary>
        public async Task SetTargetPoolsAsync()
        {
            // Snippet: SetTargetPoolsAsync(string, string, string, InstanceGroupManagersSetTargetPoolsRequest, CallSettings)
            // Additional: SetTargetPoolsAsync(string, string, string, InstanceGroupManagersSetTargetPoolsRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersSetTargetPoolsRequest instanceGroupManagersSetTargetPoolsRequestResource = new InstanceGroupManagersSetTargetPoolsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.SetTargetPoolsAsync(project, zone, instanceGroupManager, instanceGroupManagersSetTargetPoolsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceSetTargetPoolsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstances</summary>
        public void StartInstancesRequestObject()
        {
            // Snippet: StartInstances(StartInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            StartInstancesInstanceGroupManagerRequest request = new StartInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersStartInstancesRequestResource = new InstanceGroupManagersStartInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.StartInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceStartInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstancesAsync</summary>
        public async Task StartInstancesRequestObjectAsync()
        {
            // Snippet: StartInstancesAsync(StartInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: StartInstancesAsync(StartInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            StartInstancesInstanceGroupManagerRequest request = new StartInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagersStartInstancesRequestResource = new InstanceGroupManagersStartInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.StartInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceStartInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstances</summary>
        public void StartInstances()
        {
            // Snippet: StartInstances(string, string, string, InstanceGroupManagersStartInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersStartInstancesRequest instanceGroupManagersStartInstancesRequestResource = new InstanceGroupManagersStartInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.StartInstances(project, zone, instanceGroupManager, instanceGroupManagersStartInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceStartInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstancesAsync</summary>
        public async Task StartInstancesAsync()
        {
            // Snippet: StartInstancesAsync(string, string, string, InstanceGroupManagersStartInstancesRequest, CallSettings)
            // Additional: StartInstancesAsync(string, string, string, InstanceGroupManagersStartInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersStartInstancesRequest instanceGroupManagersStartInstancesRequestResource = new InstanceGroupManagersStartInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.StartInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersStartInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceStartInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstances</summary>
        public void StopInstancesRequestObject()
        {
            // Snippet: StopInstances(StopInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            StopInstancesInstanceGroupManagerRequest request = new StopInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersStopInstancesRequestResource = new InstanceGroupManagersStopInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.StopInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceStopInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstancesAsync</summary>
        public async Task StopInstancesRequestObjectAsync()
        {
            // Snippet: StopInstancesAsync(StopInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: StopInstancesAsync(StopInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            StopInstancesInstanceGroupManagerRequest request = new StopInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersStopInstancesRequestResource = new InstanceGroupManagersStopInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.StopInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceStopInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstances</summary>
        public void StopInstances()
        {
            // Snippet: StopInstances(string, string, string, InstanceGroupManagersStopInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersStopInstancesRequest instanceGroupManagersStopInstancesRequestResource = new InstanceGroupManagersStopInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.StopInstances(project, zone, instanceGroupManager, instanceGroupManagersStopInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceStopInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstancesAsync</summary>
        public async Task StopInstancesAsync()
        {
            // Snippet: StopInstancesAsync(string, string, string, InstanceGroupManagersStopInstancesRequest, CallSettings)
            // Additional: StopInstancesAsync(string, string, string, InstanceGroupManagersStopInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersStopInstancesRequest instanceGroupManagersStopInstancesRequestResource = new InstanceGroupManagersStopInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.StopInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersStopInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceStopInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendInstances</summary>
        public void SuspendInstancesRequestObject()
        {
            // Snippet: SuspendInstances(SuspendInstancesInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            SuspendInstancesInstanceGroupManagerRequest request = new SuspendInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersSuspendInstancesRequestResource = new InstanceGroupManagersSuspendInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.SuspendInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceSuspendInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendInstancesAsync</summary>
        public async Task SuspendInstancesRequestObjectAsync()
        {
            // Snippet: SuspendInstancesAsync(SuspendInstancesInstanceGroupManagerRequest, CallSettings)
            // Additional: SuspendInstancesAsync(SuspendInstancesInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            SuspendInstancesInstanceGroupManagerRequest request = new SuspendInstancesInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersSuspendInstancesRequestResource = new InstanceGroupManagersSuspendInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.SuspendInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceSuspendInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendInstances</summary>
        public void SuspendInstances()
        {
            // Snippet: SuspendInstances(string, string, string, InstanceGroupManagersSuspendInstancesRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersSuspendInstancesRequest instanceGroupManagersSuspendInstancesRequestResource = new InstanceGroupManagersSuspendInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.SuspendInstances(project, zone, instanceGroupManager, instanceGroupManagersSuspendInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceSuspendInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendInstancesAsync</summary>
        public async Task SuspendInstancesAsync()
        {
            // Snippet: SuspendInstancesAsync(string, string, string, InstanceGroupManagersSuspendInstancesRequest, CallSettings)
            // Additional: SuspendInstancesAsync(string, string, string, InstanceGroupManagersSuspendInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersSuspendInstancesRequest instanceGroupManagersSuspendInstancesRequestResource = new InstanceGroupManagersSuspendInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.SuspendInstancesAsync(project, zone, instanceGroupManager, instanceGroupManagersSuspendInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceSuspendInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigs</summary>
        public void UpdatePerInstanceConfigsRequestObject()
        {
            // Snippet: UpdatePerInstanceConfigs(UpdatePerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            UpdatePerInstanceConfigsInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.UpdatePerInstanceConfigs(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceUpdatePerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigsAsync</summary>
        public async Task UpdatePerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: UpdatePerInstanceConfigsAsync(UpdatePerInstanceConfigsInstanceGroupManagerRequest, CallSettings)
            // Additional: UpdatePerInstanceConfigsAsync(UpdatePerInstanceConfigsInstanceGroupManagerRequest, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePerInstanceConfigsInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsInstanceGroupManagerRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.UpdatePerInstanceConfigsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceUpdatePerInstanceConfigsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigs</summary>
        public void UpdatePerInstanceConfigs()
        {
            // Snippet: UpdatePerInstanceConfigs(string, string, string, InstanceGroupManagersUpdatePerInstanceConfigsReq, CallSettings)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersUpdatePerInstanceConfigsReq instanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupManagersClient.UpdatePerInstanceConfigs(project, zone, instanceGroupManager, instanceGroupManagersUpdatePerInstanceConfigsReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupManagersClient.PollOnceUpdatePerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigsAsync</summary>
        public async Task UpdatePerInstanceConfigsAsync()
        {
            // Snippet: UpdatePerInstanceConfigsAsync(string, string, string, InstanceGroupManagersUpdatePerInstanceConfigsReq, CallSettings)
            // Additional: UpdatePerInstanceConfigsAsync(string, string, string, InstanceGroupManagersUpdatePerInstanceConfigsReq, CancellationToken)
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = await InstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroupManager = "";
            InstanceGroupManagersUpdatePerInstanceConfigsReq instanceGroupManagersUpdatePerInstanceConfigsReqResource = new InstanceGroupManagersUpdatePerInstanceConfigsReq();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupManagersClient.UpdatePerInstanceConfigsAsync(project, zone, instanceGroupManager, instanceGroupManagersUpdatePerInstanceConfigsReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupManagersClient.PollOnceUpdatePerInstanceConfigsAsync(operationName);
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
