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
    public sealed class AllGeneratedNetworkEndpointGroupsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            AggregatedListNetworkEndpointGroupsRequest request = new AggregatedListNetworkEndpointGroupsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NetworkEndpointGroupAggregatedList, KeyValuePair<string, NetworkEndpointGroupsScopedList>> response = networkEndpointGroupsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, NetworkEndpointGroupsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEndpointGroupAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkEndpointGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkEndpointGroupsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkEndpointGroupsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListNetworkEndpointGroupsRequest request = new AggregatedListNetworkEndpointGroupsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupAggregatedList, KeyValuePair<string, NetworkEndpointGroupsScopedList>> response = networkEndpointGroupsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, NetworkEndpointGroupsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEndpointGroupAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkEndpointGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkEndpointGroupsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkEndpointGroupsScopedList> item in singlePage)
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
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<NetworkEndpointGroupAggregatedList, KeyValuePair<string, NetworkEndpointGroupsScopedList>> response = networkEndpointGroupsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, NetworkEndpointGroupsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEndpointGroupAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkEndpointGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkEndpointGroupsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkEndpointGroupsScopedList> item in singlePage)
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
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupAggregatedList, KeyValuePair<string, NetworkEndpointGroupsScopedList>> response = networkEndpointGroupsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, NetworkEndpointGroupsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEndpointGroupAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkEndpointGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkEndpointGroupsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkEndpointGroupsScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AttachNetworkEndpoints</summary>
        public void AttachNetworkEndpointsRequestObject()
        {
            // Snippet: AttachNetworkEndpoints(AttachNetworkEndpointsNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            AttachNetworkEndpointsNetworkEndpointGroupRequest request = new AttachNetworkEndpointsNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest(),
                Zone = "",
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkEndpointGroupsClient.AttachNetworkEndpoints(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEndpointGroupsClient.PollOnceAttachNetworkEndpoints(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachNetworkEndpointsAsync</summary>
        public async Task AttachNetworkEndpointsRequestObjectAsync()
        {
            // Snippet: AttachNetworkEndpointsAsync(AttachNetworkEndpointsNetworkEndpointGroupRequest, CallSettings)
            // Additional: AttachNetworkEndpointsAsync(AttachNetworkEndpointsNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AttachNetworkEndpointsNetworkEndpointGroupRequest request = new AttachNetworkEndpointsNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest(),
                Zone = "",
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEndpointGroupsClient.AttachNetworkEndpointsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEndpointGroupsClient.PollOnceAttachNetworkEndpointsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachNetworkEndpoints</summary>
        public void AttachNetworkEndpoints()
        {
            // Snippet: AttachNetworkEndpoints(string, string, string, NetworkEndpointGroupsAttachEndpointsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsAttachEndpointsRequest networkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = networkEndpointGroupsClient.AttachNetworkEndpoints(project, zone, networkEndpointGroup, networkEndpointGroupsAttachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEndpointGroupsClient.PollOnceAttachNetworkEndpoints(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachNetworkEndpointsAsync</summary>
        public async Task AttachNetworkEndpointsAsync()
        {
            // Snippet: AttachNetworkEndpointsAsync(string, string, string, NetworkEndpointGroupsAttachEndpointsRequest, CallSettings)
            // Additional: AttachNetworkEndpointsAsync(string, string, string, NetworkEndpointGroupsAttachEndpointsRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsAttachEndpointsRequest networkEndpointGroupsAttachEndpointsRequestResource = new NetworkEndpointGroupsAttachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEndpointGroupsClient.AttachNetworkEndpointsAsync(project, zone, networkEndpointGroup, networkEndpointGroupsAttachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEndpointGroupsClient.PollOnceAttachNetworkEndpointsAsync(operationName);
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
            // Snippet: Delete(DeleteNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            DeleteNetworkEndpointGroupRequest request = new DeleteNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkEndpointGroupsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEndpointGroupsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteNetworkEndpointGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNetworkEndpointGroupRequest request = new DeleteNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEndpointGroupsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEndpointGroupsClient.PollOnceDeleteAsync(operationName);
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
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = networkEndpointGroupsClient.Delete(project, zone, networkEndpointGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEndpointGroupsClient.PollOnceDelete(operationName);
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
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEndpointGroupsClient.DeleteAsync(project, zone, networkEndpointGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEndpointGroupsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpoints</summary>
        public void DetachNetworkEndpointsRequestObject()
        {
            // Snippet: DetachNetworkEndpoints(DetachNetworkEndpointsNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            DetachNetworkEndpointsNetworkEndpointGroupRequest request = new DetachNetworkEndpointsNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
                NetworkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkEndpointGroupsClient.DetachNetworkEndpoints(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEndpointGroupsClient.PollOnceDetachNetworkEndpoints(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpointsAsync</summary>
        public async Task DetachNetworkEndpointsRequestObjectAsync()
        {
            // Snippet: DetachNetworkEndpointsAsync(DetachNetworkEndpointsNetworkEndpointGroupRequest, CallSettings)
            // Additional: DetachNetworkEndpointsAsync(DetachNetworkEndpointsNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DetachNetworkEndpointsNetworkEndpointGroupRequest request = new DetachNetworkEndpointsNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
                NetworkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEndpointGroupsClient.DetachNetworkEndpointsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEndpointGroupsClient.PollOnceDetachNetworkEndpointsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpoints</summary>
        public void DetachNetworkEndpoints()
        {
            // Snippet: DetachNetworkEndpoints(string, string, string, NetworkEndpointGroupsDetachEndpointsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsDetachEndpointsRequest networkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = networkEndpointGroupsClient.DetachNetworkEndpoints(project, zone, networkEndpointGroup, networkEndpointGroupsDetachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEndpointGroupsClient.PollOnceDetachNetworkEndpoints(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpointsAsync</summary>
        public async Task DetachNetworkEndpointsAsync()
        {
            // Snippet: DetachNetworkEndpointsAsync(string, string, string, NetworkEndpointGroupsDetachEndpointsRequest, CallSettings)
            // Additional: DetachNetworkEndpointsAsync(string, string, string, NetworkEndpointGroupsDetachEndpointsRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsDetachEndpointsRequest networkEndpointGroupsDetachEndpointsRequestResource = new NetworkEndpointGroupsDetachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEndpointGroupsClient.DetachNetworkEndpointsAsync(project, zone, networkEndpointGroup, networkEndpointGroupsDetachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEndpointGroupsClient.PollOnceDetachNetworkEndpointsAsync(operationName);
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
            // Snippet: Get(GetNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            GetNetworkEndpointGroupRequest request = new GetNetworkEndpointGroupRequest
            {
                Zone = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            NetworkEndpointGroup response = networkEndpointGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetNetworkEndpointGroupRequest, CallSettings)
            // Additional: GetAsync(GetNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkEndpointGroupRequest request = new GetNetworkEndpointGroupRequest
            {
                Zone = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            NetworkEndpointGroup response = await networkEndpointGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            // Make the request
            NetworkEndpointGroup response = networkEndpointGroupsClient.Get(project, zone, networkEndpointGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            // Make the request
            NetworkEndpointGroup response = await networkEndpointGroupsClient.GetAsync(project, zone, networkEndpointGroup);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            InsertNetworkEndpointGroupRequest request = new InsertNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkEndpointGroupsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEndpointGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertNetworkEndpointGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertNetworkEndpointGroupRequest request = new InsertNetworkEndpointGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEndpointGroupsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEndpointGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, NetworkEndpointGroup, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            NetworkEndpointGroup networkEndpointGroupResource = new NetworkEndpointGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = networkEndpointGroupsClient.Insert(project, zone, networkEndpointGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkEndpointGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, NetworkEndpointGroup, CallSettings)
            // Additional: InsertAsync(string, string, NetworkEndpointGroup, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            NetworkEndpointGroup networkEndpointGroupResource = new NetworkEndpointGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkEndpointGroupsClient.InsertAsync(project, zone, networkEndpointGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkEndpointGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            ListNetworkEndpointGroupsRequest request = new ListNetworkEndpointGroupsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = networkEndpointGroupsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEndpointGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointGroup item in singlePage)
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
            // Snippet: ListAsync(ListNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkEndpointGroupsRequest request = new ListNetworkEndpointGroupsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = networkEndpointGroupsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkEndpointGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEndpointGroupList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointGroup item in singlePage)
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
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = networkEndpointGroupsClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEndpointGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointGroup item in singlePage)
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
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = networkEndpointGroupsClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkEndpointGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEndpointGroupList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpoints</summary>
        public void ListNetworkEndpointsRequestObject()
        {
            // Snippet: ListNetworkEndpoints(ListNetworkEndpointsNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            ListNetworkEndpointsNetworkEndpointGroupsRequest request = new ListNetworkEndpointsNetworkEndpointGroupsRequest
            {
                Zone = "",
                NetworkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest(),
                OrderBy = "",
                Project = "",
                Filter = "",
                NetworkEndpointGroup = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = networkEndpointGroupsClient.ListNetworkEndpoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkEndpointWithHealthStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEndpointGroupsListNetworkEndpoints page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointWithHealthStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointWithHealthStatus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointWithHealthStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpointsAsync</summary>
        public async Task ListNetworkEndpointsRequestObjectAsync()
        {
            // Snippet: ListNetworkEndpointsAsync(ListNetworkEndpointsNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkEndpointsNetworkEndpointGroupsRequest request = new ListNetworkEndpointsNetworkEndpointGroupsRequest
            {
                Zone = "",
                NetworkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest(),
                OrderBy = "",
                Project = "",
                Filter = "",
                NetworkEndpointGroup = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = networkEndpointGroupsClient.ListNetworkEndpointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkEndpointWithHealthStatus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEndpointGroupsListNetworkEndpoints page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointWithHealthStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointWithHealthStatus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointWithHealthStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpoints</summary>
        public void ListNetworkEndpoints()
        {
            // Snippet: ListNetworkEndpoints(string, string, string, NetworkEndpointGroupsListEndpointsRequest, string, int?, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsListEndpointsRequest networkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest();
            // Make the request
            PagedEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = networkEndpointGroupsClient.ListNetworkEndpoints(project, zone, networkEndpointGroup, networkEndpointGroupsListEndpointsRequestResource);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkEndpointWithHealthStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEndpointGroupsListNetworkEndpoints page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointWithHealthStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointWithHealthStatus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointWithHealthStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpointsAsync</summary>
        public async Task ListNetworkEndpointsAsync()
        {
            // Snippet: ListNetworkEndpointsAsync(string, string, string, NetworkEndpointGroupsListEndpointsRequest, string, int?, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string networkEndpointGroup = "";
            NetworkEndpointGroupsListEndpointsRequest networkEndpointGroupsListEndpointsRequestResource = new NetworkEndpointGroupsListEndpointsRequest();
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = networkEndpointGroupsClient.ListNetworkEndpointsAsync(project, zone, networkEndpointGroup, networkEndpointGroupsListEndpointsRequestResource);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkEndpointWithHealthStatus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEndpointGroupsListNetworkEndpoints page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointWithHealthStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointWithHealthStatus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointWithHealthStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsNetworkEndpointGroupRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsNetworkEndpointGroupRequest request = new TestIamPermissionsNetworkEndpointGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = networkEndpointGroupsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsNetworkEndpointGroupRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsNetworkEndpointGroupRequest request = new TestIamPermissionsNetworkEndpointGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await networkEndpointGroupsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = NetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = networkEndpointGroupsClient.TestIamPermissions(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            NetworkEndpointGroupsClient networkEndpointGroupsClient = await NetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await networkEndpointGroupsClient.TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
