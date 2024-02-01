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
    public sealed class AllGeneratedRegionNotificationEndpointsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionNotificationEndpointRequest, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            DeleteRegionNotificationEndpointRequest request = new DeleteRegionNotificationEndpointRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                NotificationEndpoint = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNotificationEndpointsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNotificationEndpointsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionNotificationEndpointRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionNotificationEndpointRequest, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionNotificationEndpointRequest request = new DeleteRegionNotificationEndpointRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                NotificationEndpoint = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNotificationEndpointsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNotificationEndpointsClient.PollOnceDeleteAsync(operationName);
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
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string notificationEndpoint = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionNotificationEndpointsClient.Delete(project, region, notificationEndpoint);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNotificationEndpointsClient.PollOnceDelete(operationName);
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
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string notificationEndpoint = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNotificationEndpointsClient.DeleteAsync(project, region, notificationEndpoint);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNotificationEndpointsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionNotificationEndpointRequest, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            GetRegionNotificationEndpointRequest request = new GetRegionNotificationEndpointRequest
            {
                Region = "",
                Project = "",
                NotificationEndpoint = "",
            };
            // Make the request
            NotificationEndpoint response = regionNotificationEndpointsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionNotificationEndpointRequest, CallSettings)
            // Additional: GetAsync(GetRegionNotificationEndpointRequest, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionNotificationEndpointRequest request = new GetRegionNotificationEndpointRequest
            {
                Region = "",
                Project = "",
                NotificationEndpoint = "",
            };
            // Make the request
            NotificationEndpoint response = await regionNotificationEndpointsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string notificationEndpoint = "";
            // Make the request
            NotificationEndpoint response = regionNotificationEndpointsClient.Get(project, region, notificationEndpoint);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string notificationEndpoint = "";
            // Make the request
            NotificationEndpoint response = await regionNotificationEndpointsClient.GetAsync(project, region, notificationEndpoint);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionNotificationEndpointRequest, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            InsertRegionNotificationEndpointRequest request = new InsertRegionNotificationEndpointRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                NotificationEndpointResource = new NotificationEndpoint(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNotificationEndpointsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNotificationEndpointsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionNotificationEndpointRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionNotificationEndpointRequest, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionNotificationEndpointRequest request = new InsertRegionNotificationEndpointRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                NotificationEndpointResource = new NotificationEndpoint(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNotificationEndpointsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNotificationEndpointsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, NotificationEndpoint, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NotificationEndpoint notificationEndpointResource = new NotificationEndpoint();
            // Make the request
            lro::Operation<Operation, Operation> response = regionNotificationEndpointsClient.Insert(project, region, notificationEndpointResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNotificationEndpointsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, NotificationEndpoint, CallSettings)
            // Additional: InsertAsync(string, string, NotificationEndpoint, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NotificationEndpoint notificationEndpointResource = new NotificationEndpoint();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNotificationEndpointsClient.InsertAsync(project, region, notificationEndpointResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNotificationEndpointsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionNotificationEndpointsRequest, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            ListRegionNotificationEndpointsRequest request = new ListRegionNotificationEndpointsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NotificationEndpointList, NotificationEndpoint> response = regionNotificationEndpointsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NotificationEndpointList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationEndpoint item in singlePage)
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
            // Snippet: ListAsync(ListRegionNotificationEndpointsRequest, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionNotificationEndpointsRequest request = new ListRegionNotificationEndpointsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NotificationEndpointList, NotificationEndpoint> response = regionNotificationEndpointsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationEndpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NotificationEndpointList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationEndpoint item in singlePage)
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
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<NotificationEndpointList, NotificationEndpoint> response = regionNotificationEndpointsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NotificationEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NotificationEndpointList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationEndpoint item in singlePage)
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
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<NotificationEndpointList, NotificationEndpoint> response = regionNotificationEndpointsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NotificationEndpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NotificationEndpointList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NotificationEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NotificationEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NotificationEndpoint item in singlePage)
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
