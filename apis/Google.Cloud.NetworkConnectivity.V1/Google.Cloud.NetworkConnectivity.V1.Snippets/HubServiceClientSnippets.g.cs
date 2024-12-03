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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.NetworkConnectivity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedHubServiceClientSnippets
    {
        /// <summary>Snippet for ListHubs</summary>
        public void ListHubsRequestObject()
        {
            // Snippet: ListHubs(ListHubsRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            ListHubsRequest request = new ListHubsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListHubsResponse, Hub> response = hubServiceClient.ListHubs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Hub item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHubsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hub item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hub> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hub item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHubsAsync</summary>
        public async Task ListHubsRequestObjectAsync()
        {
            // Snippet: ListHubsAsync(ListHubsRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListHubsRequest request = new ListHubsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListHubsResponse, Hub> response = hubServiceClient.ListHubsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Hub item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHubsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hub item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hub> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hub item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHubs</summary>
        public void ListHubs()
        {
            // Snippet: ListHubs(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListHubsResponse, Hub> response = hubServiceClient.ListHubs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Hub item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHubsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hub item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hub> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hub item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHubsAsync</summary>
        public async Task ListHubsAsync()
        {
            // Snippet: ListHubsAsync(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListHubsResponse, Hub> response = hubServiceClient.ListHubsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Hub item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHubsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hub item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hub> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hub item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHubs</summary>
        public void ListHubsResourceNames()
        {
            // Snippet: ListHubs(LocationName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListHubsResponse, Hub> response = hubServiceClient.ListHubs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Hub item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHubsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hub item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hub> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hub item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHubsAsync</summary>
        public async Task ListHubsResourceNamesAsync()
        {
            // Snippet: ListHubsAsync(LocationName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListHubsResponse, Hub> response = hubServiceClient.ListHubsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Hub item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHubsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hub item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hub> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hub item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetHub</summary>
        public void GetHubRequestObject()
        {
            // Snippet: GetHub(GetHubRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            GetHubRequest request = new GetHubRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
            };
            // Make the request
            Hub response = hubServiceClient.GetHub(request);
            // End snippet
        }

        /// <summary>Snippet for GetHubAsync</summary>
        public async Task GetHubRequestObjectAsync()
        {
            // Snippet: GetHubAsync(GetHubRequest, CallSettings)
            // Additional: GetHubAsync(GetHubRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetHubRequest request = new GetHubRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
            };
            // Make the request
            Hub response = await hubServiceClient.GetHubAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHub</summary>
        public void GetHub()
        {
            // Snippet: GetHub(string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            Hub response = hubServiceClient.GetHub(name);
            // End snippet
        }

        /// <summary>Snippet for GetHubAsync</summary>
        public async Task GetHubAsync()
        {
            // Snippet: GetHubAsync(string, CallSettings)
            // Additional: GetHubAsync(string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            Hub response = await hubServiceClient.GetHubAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetHub</summary>
        public void GetHubResourceNames()
        {
            // Snippet: GetHub(HubName, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            Hub response = hubServiceClient.GetHub(name);
            // End snippet
        }

        /// <summary>Snippet for GetHubAsync</summary>
        public async Task GetHubResourceNamesAsync()
        {
            // Snippet: GetHubAsync(HubName, CallSettings)
            // Additional: GetHubAsync(HubName, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            Hub response = await hubServiceClient.GetHubAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateHub</summary>
        public void CreateHubRequestObject()
        {
            // Snippet: CreateHub(CreateHubRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            CreateHubRequest request = new CreateHubRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HubId = "",
                Hub = new Hub(),
                RequestId = "",
            };
            // Make the request
            Operation<Hub, OperationMetadata> response = hubServiceClient.CreateHub(request);

            // Poll until the returned long-running operation is complete
            Operation<Hub, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hub result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hub, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceCreateHub(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hub retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHubAsync</summary>
        public async Task CreateHubRequestObjectAsync()
        {
            // Snippet: CreateHubAsync(CreateHubRequest, CallSettings)
            // Additional: CreateHubAsync(CreateHubRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateHubRequest request = new CreateHubRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HubId = "",
                Hub = new Hub(),
                RequestId = "",
            };
            // Make the request
            Operation<Hub, OperationMetadata> response = await hubServiceClient.CreateHubAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Hub, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hub result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hub, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceCreateHubAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hub retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHub</summary>
        public void CreateHub()
        {
            // Snippet: CreateHub(string, Hub, string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Hub hub = new Hub();
            string hubId = "";
            // Make the request
            Operation<Hub, OperationMetadata> response = hubServiceClient.CreateHub(parent, hub, hubId);

            // Poll until the returned long-running operation is complete
            Operation<Hub, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hub result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hub, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceCreateHub(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hub retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHubAsync</summary>
        public async Task CreateHubAsync()
        {
            // Snippet: CreateHubAsync(string, Hub, string, CallSettings)
            // Additional: CreateHubAsync(string, Hub, string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Hub hub = new Hub();
            string hubId = "";
            // Make the request
            Operation<Hub, OperationMetadata> response = await hubServiceClient.CreateHubAsync(parent, hub, hubId);

            // Poll until the returned long-running operation is complete
            Operation<Hub, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hub result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hub, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceCreateHubAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hub retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHub</summary>
        public void CreateHubResourceNames()
        {
            // Snippet: CreateHub(LocationName, Hub, string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Hub hub = new Hub();
            string hubId = "";
            // Make the request
            Operation<Hub, OperationMetadata> response = hubServiceClient.CreateHub(parent, hub, hubId);

            // Poll until the returned long-running operation is complete
            Operation<Hub, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hub result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hub, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceCreateHub(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hub retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHubAsync</summary>
        public async Task CreateHubResourceNamesAsync()
        {
            // Snippet: CreateHubAsync(LocationName, Hub, string, CallSettings)
            // Additional: CreateHubAsync(LocationName, Hub, string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Hub hub = new Hub();
            string hubId = "";
            // Make the request
            Operation<Hub, OperationMetadata> response = await hubServiceClient.CreateHubAsync(parent, hub, hubId);

            // Poll until the returned long-running operation is complete
            Operation<Hub, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hub result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hub, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceCreateHubAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hub retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHub</summary>
        public void UpdateHubRequestObject()
        {
            // Snippet: UpdateHub(UpdateHubRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            UpdateHubRequest request = new UpdateHubRequest
            {
                UpdateMask = new FieldMask(),
                Hub = new Hub(),
                RequestId = "",
            };
            // Make the request
            Operation<Hub, OperationMetadata> response = hubServiceClient.UpdateHub(request);

            // Poll until the returned long-running operation is complete
            Operation<Hub, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hub result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hub, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceUpdateHub(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hub retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHubAsync</summary>
        public async Task UpdateHubRequestObjectAsync()
        {
            // Snippet: UpdateHubAsync(UpdateHubRequest, CallSettings)
            // Additional: UpdateHubAsync(UpdateHubRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateHubRequest request = new UpdateHubRequest
            {
                UpdateMask = new FieldMask(),
                Hub = new Hub(),
                RequestId = "",
            };
            // Make the request
            Operation<Hub, OperationMetadata> response = await hubServiceClient.UpdateHubAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Hub, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hub result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hub, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceUpdateHubAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hub retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHub</summary>
        public void UpdateHub()
        {
            // Snippet: UpdateHub(Hub, FieldMask, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            Hub hub = new Hub();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Hub, OperationMetadata> response = hubServiceClient.UpdateHub(hub, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Hub, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hub result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hub, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceUpdateHub(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hub retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHubAsync</summary>
        public async Task UpdateHubAsync()
        {
            // Snippet: UpdateHubAsync(Hub, FieldMask, CallSettings)
            // Additional: UpdateHubAsync(Hub, FieldMask, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            Hub hub = new Hub();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Hub, OperationMetadata> response = await hubServiceClient.UpdateHubAsync(hub, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Hub, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hub result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hub, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceUpdateHubAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hub retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHub</summary>
        public void DeleteHubRequestObject()
        {
            // Snippet: DeleteHub(DeleteHubRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            DeleteHubRequest request = new DeleteHubRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = hubServiceClient.DeleteHub(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceDeleteHub(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHubAsync</summary>
        public async Task DeleteHubRequestObjectAsync()
        {
            // Snippet: DeleteHubAsync(DeleteHubRequest, CallSettings)
            // Additional: DeleteHubAsync(DeleteHubRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteHubRequest request = new DeleteHubRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await hubServiceClient.DeleteHubAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceDeleteHubAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHub</summary>
        public void DeleteHub()
        {
            // Snippet: DeleteHub(string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            Operation<Empty, OperationMetadata> response = hubServiceClient.DeleteHub(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceDeleteHub(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHubAsync</summary>
        public async Task DeleteHubAsync()
        {
            // Snippet: DeleteHubAsync(string, CallSettings)
            // Additional: DeleteHubAsync(string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await hubServiceClient.DeleteHubAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceDeleteHubAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHub</summary>
        public void DeleteHubResourceNames()
        {
            // Snippet: DeleteHub(HubName, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            Operation<Empty, OperationMetadata> response = hubServiceClient.DeleteHub(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceDeleteHub(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHubAsync</summary>
        public async Task DeleteHubResourceNamesAsync()
        {
            // Snippet: DeleteHubAsync(HubName, CallSettings)
            // Additional: DeleteHubAsync(HubName, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await hubServiceClient.DeleteHubAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceDeleteHubAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListHubSpokes</summary>
        public void ListHubSpokesRequestObject()
        {
            // Snippet: ListHubSpokes(ListHubSpokesRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            ListHubSpokesRequest request = new ListHubSpokesRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                SpokeLocations = { "", },
                Filter = "",
                OrderBy = "",
                View = ListHubSpokesRequest.Types.SpokeView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListHubSpokesResponse, Spoke> response = hubServiceClient.ListHubSpokes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Spoke item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHubSpokesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHubSpokesAsync</summary>
        public async Task ListHubSpokesRequestObjectAsync()
        {
            // Snippet: ListHubSpokesAsync(ListHubSpokesRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListHubSpokesRequest request = new ListHubSpokesRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                SpokeLocations = { "", },
                Filter = "",
                OrderBy = "",
                View = ListHubSpokesRequest.Types.SpokeView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListHubSpokesResponse, Spoke> response = hubServiceClient.ListHubSpokesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Spoke item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHubSpokesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHubSpokes</summary>
        public void ListHubSpokes()
        {
            // Snippet: ListHubSpokes(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            PagedEnumerable<ListHubSpokesResponse, Spoke> response = hubServiceClient.ListHubSpokes(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Spoke item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHubSpokesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHubSpokesAsync</summary>
        public async Task ListHubSpokesAsync()
        {
            // Snippet: ListHubSpokesAsync(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            PagedAsyncEnumerable<ListHubSpokesResponse, Spoke> response = hubServiceClient.ListHubSpokesAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Spoke item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHubSpokesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHubSpokes</summary>
        public void ListHubSpokesResourceNames()
        {
            // Snippet: ListHubSpokes(HubName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            PagedEnumerable<ListHubSpokesResponse, Spoke> response = hubServiceClient.ListHubSpokes(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Spoke item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHubSpokesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHubSpokesAsync</summary>
        public async Task ListHubSpokesResourceNamesAsync()
        {
            // Snippet: ListHubSpokesAsync(HubName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            PagedAsyncEnumerable<ListHubSpokesResponse, Spoke> response = hubServiceClient.ListHubSpokesAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Spoke item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHubSpokesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryHubStatus</summary>
        public void QueryHubStatusRequestObject()
        {
            // Snippet: QueryHubStatus(QueryHubStatusRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            QueryHubStatusRequest request = new QueryHubStatusRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                Filter = "",
                OrderBy = "",
                GroupBy = "",
            };
            // Make the request
            PagedEnumerable<QueryHubStatusResponse, HubStatusEntry> response = hubServiceClient.QueryHubStatus(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HubStatusEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryHubStatusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HubStatusEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HubStatusEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HubStatusEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryHubStatusAsync</summary>
        public async Task QueryHubStatusRequestObjectAsync()
        {
            // Snippet: QueryHubStatusAsync(QueryHubStatusRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryHubStatusRequest request = new QueryHubStatusRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                Filter = "",
                OrderBy = "",
                GroupBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<QueryHubStatusResponse, HubStatusEntry> response = hubServiceClient.QueryHubStatusAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HubStatusEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryHubStatusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HubStatusEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HubStatusEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HubStatusEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryHubStatus</summary>
        public void QueryHubStatus()
        {
            // Snippet: QueryHubStatus(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            PagedEnumerable<QueryHubStatusResponse, HubStatusEntry> response = hubServiceClient.QueryHubStatus(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HubStatusEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryHubStatusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HubStatusEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HubStatusEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HubStatusEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryHubStatusAsync</summary>
        public async Task QueryHubStatusAsync()
        {
            // Snippet: QueryHubStatusAsync(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            PagedAsyncEnumerable<QueryHubStatusResponse, HubStatusEntry> response = hubServiceClient.QueryHubStatusAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HubStatusEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryHubStatusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HubStatusEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HubStatusEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HubStatusEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryHubStatus</summary>
        public void QueryHubStatusResourceNames()
        {
            // Snippet: QueryHubStatus(HubName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            PagedEnumerable<QueryHubStatusResponse, HubStatusEntry> response = hubServiceClient.QueryHubStatus(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HubStatusEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryHubStatusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HubStatusEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HubStatusEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HubStatusEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryHubStatusAsync</summary>
        public async Task QueryHubStatusResourceNamesAsync()
        {
            // Snippet: QueryHubStatusAsync(HubName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            PagedAsyncEnumerable<QueryHubStatusResponse, HubStatusEntry> response = hubServiceClient.QueryHubStatusAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HubStatusEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryHubStatusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HubStatusEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HubStatusEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HubStatusEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpokes</summary>
        public void ListSpokesRequestObject()
        {
            // Snippet: ListSpokes(ListSpokesRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            ListSpokesRequest request = new ListSpokesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSpokesResponse, Spoke> response = hubServiceClient.ListSpokes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Spoke item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpokesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpokesAsync</summary>
        public async Task ListSpokesRequestObjectAsync()
        {
            // Snippet: ListSpokesAsync(ListSpokesRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSpokesRequest request = new ListSpokesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSpokesResponse, Spoke> response = hubServiceClient.ListSpokesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Spoke item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSpokesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpokes</summary>
        public void ListSpokes()
        {
            // Snippet: ListSpokes(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSpokesResponse, Spoke> response = hubServiceClient.ListSpokes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Spoke item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpokesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpokesAsync</summary>
        public async Task ListSpokesAsync()
        {
            // Snippet: ListSpokesAsync(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSpokesResponse, Spoke> response = hubServiceClient.ListSpokesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Spoke item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSpokesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpokes</summary>
        public void ListSpokesResourceNames()
        {
            // Snippet: ListSpokes(LocationName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSpokesResponse, Spoke> response = hubServiceClient.ListSpokes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Spoke item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpokesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpokesAsync</summary>
        public async Task ListSpokesResourceNamesAsync()
        {
            // Snippet: ListSpokesAsync(LocationName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSpokesResponse, Spoke> response = hubServiceClient.ListSpokesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Spoke item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSpokesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Spoke item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Spoke> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Spoke item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSpoke</summary>
        public void GetSpokeRequestObject()
        {
            // Snippet: GetSpoke(GetSpokeRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            GetSpokeRequest request = new GetSpokeRequest
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
            };
            // Make the request
            Spoke response = hubServiceClient.GetSpoke(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpokeAsync</summary>
        public async Task GetSpokeRequestObjectAsync()
        {
            // Snippet: GetSpokeAsync(GetSpokeRequest, CallSettings)
            // Additional: GetSpokeAsync(GetSpokeRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSpokeRequest request = new GetSpokeRequest
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
            };
            // Make the request
            Spoke response = await hubServiceClient.GetSpokeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpoke</summary>
        public void GetSpoke()
        {
            // Snippet: GetSpoke(string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spokes/[SPOKE]";
            // Make the request
            Spoke response = hubServiceClient.GetSpoke(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpokeAsync</summary>
        public async Task GetSpokeAsync()
        {
            // Snippet: GetSpokeAsync(string, CallSettings)
            // Additional: GetSpokeAsync(string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spokes/[SPOKE]";
            // Make the request
            Spoke response = await hubServiceClient.GetSpokeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpoke</summary>
        public void GetSpokeResourceNames()
        {
            // Snippet: GetSpoke(SpokeName, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            SpokeName name = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]");
            // Make the request
            Spoke response = hubServiceClient.GetSpoke(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpokeAsync</summary>
        public async Task GetSpokeResourceNamesAsync()
        {
            // Snippet: GetSpokeAsync(SpokeName, CallSettings)
            // Additional: GetSpokeAsync(SpokeName, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpokeName name = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]");
            // Make the request
            Spoke response = await hubServiceClient.GetSpokeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSpoke</summary>
        public void CreateSpokeRequestObject()
        {
            // Snippet: CreateSpoke(CreateSpokeRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            CreateSpokeRequest request = new CreateSpokeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SpokeId = "",
                Spoke = new Spoke(),
                RequestId = "",
            };
            // Make the request
            Operation<Spoke, OperationMetadata> response = hubServiceClient.CreateSpoke(request);

            // Poll until the returned long-running operation is complete
            Operation<Spoke, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Spoke result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Spoke, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceCreateSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Spoke retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSpokeAsync</summary>
        public async Task CreateSpokeRequestObjectAsync()
        {
            // Snippet: CreateSpokeAsync(CreateSpokeRequest, CallSettings)
            // Additional: CreateSpokeAsync(CreateSpokeRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSpokeRequest request = new CreateSpokeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SpokeId = "",
                Spoke = new Spoke(),
                RequestId = "",
            };
            // Make the request
            Operation<Spoke, OperationMetadata> response = await hubServiceClient.CreateSpokeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Spoke, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Spoke result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Spoke, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceCreateSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Spoke retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSpoke</summary>
        public void CreateSpoke()
        {
            // Snippet: CreateSpoke(string, Spoke, string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Spoke spoke = new Spoke();
            string spokeId = "";
            // Make the request
            Operation<Spoke, OperationMetadata> response = hubServiceClient.CreateSpoke(parent, spoke, spokeId);

            // Poll until the returned long-running operation is complete
            Operation<Spoke, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Spoke result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Spoke, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceCreateSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Spoke retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSpokeAsync</summary>
        public async Task CreateSpokeAsync()
        {
            // Snippet: CreateSpokeAsync(string, Spoke, string, CallSettings)
            // Additional: CreateSpokeAsync(string, Spoke, string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Spoke spoke = new Spoke();
            string spokeId = "";
            // Make the request
            Operation<Spoke, OperationMetadata> response = await hubServiceClient.CreateSpokeAsync(parent, spoke, spokeId);

            // Poll until the returned long-running operation is complete
            Operation<Spoke, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Spoke result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Spoke, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceCreateSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Spoke retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSpoke</summary>
        public void CreateSpokeResourceNames()
        {
            // Snippet: CreateSpoke(LocationName, Spoke, string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Spoke spoke = new Spoke();
            string spokeId = "";
            // Make the request
            Operation<Spoke, OperationMetadata> response = hubServiceClient.CreateSpoke(parent, spoke, spokeId);

            // Poll until the returned long-running operation is complete
            Operation<Spoke, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Spoke result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Spoke, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceCreateSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Spoke retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSpokeAsync</summary>
        public async Task CreateSpokeResourceNamesAsync()
        {
            // Snippet: CreateSpokeAsync(LocationName, Spoke, string, CallSettings)
            // Additional: CreateSpokeAsync(LocationName, Spoke, string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Spoke spoke = new Spoke();
            string spokeId = "";
            // Make the request
            Operation<Spoke, OperationMetadata> response = await hubServiceClient.CreateSpokeAsync(parent, spoke, spokeId);

            // Poll until the returned long-running operation is complete
            Operation<Spoke, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Spoke result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Spoke, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceCreateSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Spoke retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSpoke</summary>
        public void UpdateSpokeRequestObject()
        {
            // Snippet: UpdateSpoke(UpdateSpokeRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            UpdateSpokeRequest request = new UpdateSpokeRequest
            {
                UpdateMask = new FieldMask(),
                Spoke = new Spoke(),
                RequestId = "",
            };
            // Make the request
            Operation<Spoke, OperationMetadata> response = hubServiceClient.UpdateSpoke(request);

            // Poll until the returned long-running operation is complete
            Operation<Spoke, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Spoke result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Spoke, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceUpdateSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Spoke retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSpokeAsync</summary>
        public async Task UpdateSpokeRequestObjectAsync()
        {
            // Snippet: UpdateSpokeAsync(UpdateSpokeRequest, CallSettings)
            // Additional: UpdateSpokeAsync(UpdateSpokeRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSpokeRequest request = new UpdateSpokeRequest
            {
                UpdateMask = new FieldMask(),
                Spoke = new Spoke(),
                RequestId = "",
            };
            // Make the request
            Operation<Spoke, OperationMetadata> response = await hubServiceClient.UpdateSpokeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Spoke, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Spoke result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Spoke, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceUpdateSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Spoke retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSpoke</summary>
        public void UpdateSpoke()
        {
            // Snippet: UpdateSpoke(Spoke, FieldMask, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            Spoke spoke = new Spoke();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Spoke, OperationMetadata> response = hubServiceClient.UpdateSpoke(spoke, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Spoke, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Spoke result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Spoke, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceUpdateSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Spoke retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSpokeAsync</summary>
        public async Task UpdateSpokeAsync()
        {
            // Snippet: UpdateSpokeAsync(Spoke, FieldMask, CallSettings)
            // Additional: UpdateSpokeAsync(Spoke, FieldMask, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            Spoke spoke = new Spoke();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Spoke, OperationMetadata> response = await hubServiceClient.UpdateSpokeAsync(spoke, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Spoke, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Spoke result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Spoke, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceUpdateSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Spoke retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RejectHubSpoke</summary>
        public void RejectHubSpokeRequestObject()
        {
            // Snippet: RejectHubSpoke(RejectHubSpokeRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            RejectHubSpokeRequest request = new RejectHubSpokeRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                SpokeUriAsSpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                RequestId = "",
                Details = "",
            };
            // Make the request
            Operation<RejectHubSpokeResponse, OperationMetadata> response = hubServiceClient.RejectHubSpoke(request);

            // Poll until the returned long-running operation is complete
            Operation<RejectHubSpokeResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RejectHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RejectHubSpokeResponse, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceRejectHubSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RejectHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RejectHubSpokeAsync</summary>
        public async Task RejectHubSpokeRequestObjectAsync()
        {
            // Snippet: RejectHubSpokeAsync(RejectHubSpokeRequest, CallSettings)
            // Additional: RejectHubSpokeAsync(RejectHubSpokeRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            RejectHubSpokeRequest request = new RejectHubSpokeRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                SpokeUriAsSpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                RequestId = "",
                Details = "",
            };
            // Make the request
            Operation<RejectHubSpokeResponse, OperationMetadata> response = await hubServiceClient.RejectHubSpokeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RejectHubSpokeResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RejectHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RejectHubSpokeResponse, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceRejectHubSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RejectHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RejectHubSpoke</summary>
        public void RejectHubSpoke()
        {
            // Snippet: RejectHubSpoke(string, string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            string spokeUri = "projects/[PROJECT]/locations/[LOCATION]/spokes/[SPOKE]";
            // Make the request
            Operation<RejectHubSpokeResponse, OperationMetadata> response = hubServiceClient.RejectHubSpoke(name, spokeUri);

            // Poll until the returned long-running operation is complete
            Operation<RejectHubSpokeResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RejectHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RejectHubSpokeResponse, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceRejectHubSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RejectHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RejectHubSpokeAsync</summary>
        public async Task RejectHubSpokeAsync()
        {
            // Snippet: RejectHubSpokeAsync(string, string, CallSettings)
            // Additional: RejectHubSpokeAsync(string, string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            string spokeUri = "projects/[PROJECT]/locations/[LOCATION]/spokes/[SPOKE]";
            // Make the request
            Operation<RejectHubSpokeResponse, OperationMetadata> response = await hubServiceClient.RejectHubSpokeAsync(name, spokeUri);

            // Poll until the returned long-running operation is complete
            Operation<RejectHubSpokeResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RejectHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RejectHubSpokeResponse, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceRejectHubSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RejectHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RejectHubSpoke</summary>
        public void RejectHubSpokeResourceNames()
        {
            // Snippet: RejectHubSpoke(HubName, SpokeName, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            SpokeName spokeUri = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]");
            // Make the request
            Operation<RejectHubSpokeResponse, OperationMetadata> response = hubServiceClient.RejectHubSpoke(name, spokeUri);

            // Poll until the returned long-running operation is complete
            Operation<RejectHubSpokeResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RejectHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RejectHubSpokeResponse, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceRejectHubSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RejectHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RejectHubSpokeAsync</summary>
        public async Task RejectHubSpokeResourceNamesAsync()
        {
            // Snippet: RejectHubSpokeAsync(HubName, SpokeName, CallSettings)
            // Additional: RejectHubSpokeAsync(HubName, SpokeName, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            SpokeName spokeUri = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]");
            // Make the request
            Operation<RejectHubSpokeResponse, OperationMetadata> response = await hubServiceClient.RejectHubSpokeAsync(name, spokeUri);

            // Poll until the returned long-running operation is complete
            Operation<RejectHubSpokeResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RejectHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RejectHubSpokeResponse, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceRejectHubSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RejectHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AcceptHubSpoke</summary>
        public void AcceptHubSpokeRequestObject()
        {
            // Snippet: AcceptHubSpoke(AcceptHubSpokeRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            AcceptHubSpokeRequest request = new AcceptHubSpokeRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                SpokeUriAsSpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                RequestId = "",
            };
            // Make the request
            Operation<AcceptHubSpokeResponse, OperationMetadata> response = hubServiceClient.AcceptHubSpoke(request);

            // Poll until the returned long-running operation is complete
            Operation<AcceptHubSpokeResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AcceptHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AcceptHubSpokeResponse, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceAcceptHubSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AcceptHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AcceptHubSpokeAsync</summary>
        public async Task AcceptHubSpokeRequestObjectAsync()
        {
            // Snippet: AcceptHubSpokeAsync(AcceptHubSpokeRequest, CallSettings)
            // Additional: AcceptHubSpokeAsync(AcceptHubSpokeRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            AcceptHubSpokeRequest request = new AcceptHubSpokeRequest
            {
                HubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                SpokeUriAsSpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                RequestId = "",
            };
            // Make the request
            Operation<AcceptHubSpokeResponse, OperationMetadata> response = await hubServiceClient.AcceptHubSpokeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AcceptHubSpokeResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AcceptHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AcceptHubSpokeResponse, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceAcceptHubSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AcceptHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AcceptHubSpoke</summary>
        public void AcceptHubSpoke()
        {
            // Snippet: AcceptHubSpoke(string, string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            string spokeUri = "projects/[PROJECT]/locations/[LOCATION]/spokes/[SPOKE]";
            // Make the request
            Operation<AcceptHubSpokeResponse, OperationMetadata> response = hubServiceClient.AcceptHubSpoke(name, spokeUri);

            // Poll until the returned long-running operation is complete
            Operation<AcceptHubSpokeResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AcceptHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AcceptHubSpokeResponse, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceAcceptHubSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AcceptHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AcceptHubSpokeAsync</summary>
        public async Task AcceptHubSpokeAsync()
        {
            // Snippet: AcceptHubSpokeAsync(string, string, CallSettings)
            // Additional: AcceptHubSpokeAsync(string, string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            string spokeUri = "projects/[PROJECT]/locations/[LOCATION]/spokes/[SPOKE]";
            // Make the request
            Operation<AcceptHubSpokeResponse, OperationMetadata> response = await hubServiceClient.AcceptHubSpokeAsync(name, spokeUri);

            // Poll until the returned long-running operation is complete
            Operation<AcceptHubSpokeResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AcceptHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AcceptHubSpokeResponse, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceAcceptHubSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AcceptHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AcceptHubSpoke</summary>
        public void AcceptHubSpokeResourceNames()
        {
            // Snippet: AcceptHubSpoke(HubName, SpokeName, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            SpokeName spokeUri = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]");
            // Make the request
            Operation<AcceptHubSpokeResponse, OperationMetadata> response = hubServiceClient.AcceptHubSpoke(name, spokeUri);

            // Poll until the returned long-running operation is complete
            Operation<AcceptHubSpokeResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AcceptHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AcceptHubSpokeResponse, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceAcceptHubSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AcceptHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AcceptHubSpokeAsync</summary>
        public async Task AcceptHubSpokeResourceNamesAsync()
        {
            // Snippet: AcceptHubSpokeAsync(HubName, SpokeName, CallSettings)
            // Additional: AcceptHubSpokeAsync(HubName, SpokeName, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            HubName name = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            SpokeName spokeUri = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]");
            // Make the request
            Operation<AcceptHubSpokeResponse, OperationMetadata> response = await hubServiceClient.AcceptHubSpokeAsync(name, spokeUri);

            // Poll until the returned long-running operation is complete
            Operation<AcceptHubSpokeResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AcceptHubSpokeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AcceptHubSpokeResponse, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceAcceptHubSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AcceptHubSpokeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSpoke</summary>
        public void DeleteSpokeRequestObject()
        {
            // Snippet: DeleteSpoke(DeleteSpokeRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            DeleteSpokeRequest request = new DeleteSpokeRequest
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = hubServiceClient.DeleteSpoke(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceDeleteSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSpokeAsync</summary>
        public async Task DeleteSpokeRequestObjectAsync()
        {
            // Snippet: DeleteSpokeAsync(DeleteSpokeRequest, CallSettings)
            // Additional: DeleteSpokeAsync(DeleteSpokeRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSpokeRequest request = new DeleteSpokeRequest
            {
                SpokeName = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await hubServiceClient.DeleteSpokeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceDeleteSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSpoke</summary>
        public void DeleteSpoke()
        {
            // Snippet: DeleteSpoke(string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spokes/[SPOKE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = hubServiceClient.DeleteSpoke(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceDeleteSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSpokeAsync</summary>
        public async Task DeleteSpokeAsync()
        {
            // Snippet: DeleteSpokeAsync(string, CallSettings)
            // Additional: DeleteSpokeAsync(string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/spokes/[SPOKE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await hubServiceClient.DeleteSpokeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceDeleteSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSpoke</summary>
        public void DeleteSpokeResourceNames()
        {
            // Snippet: DeleteSpoke(SpokeName, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            SpokeName name = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = hubServiceClient.DeleteSpoke(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceDeleteSpoke(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSpokeAsync</summary>
        public async Task DeleteSpokeResourceNamesAsync()
        {
            // Snippet: DeleteSpokeAsync(SpokeName, CallSettings)
            // Additional: DeleteSpokeAsync(SpokeName, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpokeName name = SpokeName.FromProjectLocationSpoke("[PROJECT]", "[LOCATION]", "[SPOKE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await hubServiceClient.DeleteSpokeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceDeleteSpokeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetRouteTable</summary>
        public void GetRouteTableRequestObject()
        {
            // Snippet: GetRouteTable(GetRouteTableRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            GetRouteTableRequest request = new GetRouteTableRequest
            {
                RouteTableName = RouteTableName.FromProjectHubRouteTable("[PROJECT]", "[HUB]", "[ROUTE_TABLE]"),
            };
            // Make the request
            RouteTable response = hubServiceClient.GetRouteTable(request);
            // End snippet
        }

        /// <summary>Snippet for GetRouteTableAsync</summary>
        public async Task GetRouteTableRequestObjectAsync()
        {
            // Snippet: GetRouteTableAsync(GetRouteTableRequest, CallSettings)
            // Additional: GetRouteTableAsync(GetRouteTableRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRouteTableRequest request = new GetRouteTableRequest
            {
                RouteTableName = RouteTableName.FromProjectHubRouteTable("[PROJECT]", "[HUB]", "[ROUTE_TABLE]"),
            };
            // Make the request
            RouteTable response = await hubServiceClient.GetRouteTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRouteTable</summary>
        public void GetRouteTable()
        {
            // Snippet: GetRouteTable(string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]/routeTables/[ROUTE_TABLE]";
            // Make the request
            RouteTable response = hubServiceClient.GetRouteTable(name);
            // End snippet
        }

        /// <summary>Snippet for GetRouteTableAsync</summary>
        public async Task GetRouteTableAsync()
        {
            // Snippet: GetRouteTableAsync(string, CallSettings)
            // Additional: GetRouteTableAsync(string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]/routeTables/[ROUTE_TABLE]";
            // Make the request
            RouteTable response = await hubServiceClient.GetRouteTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRouteTable</summary>
        public void GetRouteTableResourceNames()
        {
            // Snippet: GetRouteTable(RouteTableName, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            RouteTableName name = RouteTableName.FromProjectHubRouteTable("[PROJECT]", "[HUB]", "[ROUTE_TABLE]");
            // Make the request
            RouteTable response = hubServiceClient.GetRouteTable(name);
            // End snippet
        }

        /// <summary>Snippet for GetRouteTableAsync</summary>
        public async Task GetRouteTableResourceNamesAsync()
        {
            // Snippet: GetRouteTableAsync(RouteTableName, CallSettings)
            // Additional: GetRouteTableAsync(RouteTableName, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            RouteTableName name = RouteTableName.FromProjectHubRouteTable("[PROJECT]", "[HUB]", "[ROUTE_TABLE]");
            // Make the request
            RouteTable response = await hubServiceClient.GetRouteTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRoute</summary>
        public void GetRouteRequestObject()
        {
            // Snippet: GetRoute(GetRouteRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            GetRouteRequest request = new GetRouteRequest
            {
                HubRouteName = HubRouteName.FromProjectHubRouteTableRoute("[PROJECT]", "[HUB]", "[ROUTE_TABLE]", "[ROUTE]"),
            };
            // Make the request
            Route response = hubServiceClient.GetRoute(request);
            // End snippet
        }

        /// <summary>Snippet for GetRouteAsync</summary>
        public async Task GetRouteRequestObjectAsync()
        {
            // Snippet: GetRouteAsync(GetRouteRequest, CallSettings)
            // Additional: GetRouteAsync(GetRouteRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRouteRequest request = new GetRouteRequest
            {
                HubRouteName = HubRouteName.FromProjectHubRouteTableRoute("[PROJECT]", "[HUB]", "[ROUTE_TABLE]", "[ROUTE]"),
            };
            // Make the request
            Route response = await hubServiceClient.GetRouteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRoute</summary>
        public void GetRoute()
        {
            // Snippet: GetRoute(string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]/routeTables/[ROUTE_TABLE]/routes/[ROUTE]";
            // Make the request
            Route response = hubServiceClient.GetRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetRouteAsync</summary>
        public async Task GetRouteAsync()
        {
            // Snippet: GetRouteAsync(string, CallSettings)
            // Additional: GetRouteAsync(string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]/routeTables/[ROUTE_TABLE]/routes/[ROUTE]";
            // Make the request
            Route response = await hubServiceClient.GetRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRoute</summary>
        public void GetRouteResourceNames()
        {
            // Snippet: GetRoute(HubRouteName, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            HubRouteName name = HubRouteName.FromProjectHubRouteTableRoute("[PROJECT]", "[HUB]", "[ROUTE_TABLE]", "[ROUTE]");
            // Make the request
            Route response = hubServiceClient.GetRoute(name);
            // End snippet
        }

        /// <summary>Snippet for GetRouteAsync</summary>
        public async Task GetRouteResourceNamesAsync()
        {
            // Snippet: GetRouteAsync(HubRouteName, CallSettings)
            // Additional: GetRouteAsync(HubRouteName, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            HubRouteName name = HubRouteName.FromProjectHubRouteTableRoute("[PROJECT]", "[HUB]", "[ROUTE_TABLE]", "[ROUTE]");
            // Make the request
            Route response = await hubServiceClient.GetRouteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRoutes</summary>
        public void ListRoutesRequestObject()
        {
            // Snippet: ListRoutes(ListRoutesRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            ListRoutesRequest request = new ListRoutesRequest
            {
                ParentAsRouteTableName = RouteTableName.FromProjectHubRouteTable("[PROJECT]", "[HUB]", "[ROUTE_TABLE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRoutesResponse, Route> response = hubServiceClient.ListRoutes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Route item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutesAsync</summary>
        public async Task ListRoutesRequestObjectAsync()
        {
            // Snippet: ListRoutesAsync(ListRoutesRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRoutesRequest request = new ListRoutesRequest
            {
                ParentAsRouteTableName = RouteTableName.FromProjectHubRouteTable("[PROJECT]", "[HUB]", "[ROUTE_TABLE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRoutesResponse, Route> response = hubServiceClient.ListRoutesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Route item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutes</summary>
        public void ListRoutes()
        {
            // Snippet: ListRoutes(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/global/hubs/[HUB]/routeTables/[ROUTE_TABLE]";
            // Make the request
            PagedEnumerable<ListRoutesResponse, Route> response = hubServiceClient.ListRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Route item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutesAsync</summary>
        public async Task ListRoutesAsync()
        {
            // Snippet: ListRoutesAsync(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/global/hubs/[HUB]/routeTables/[ROUTE_TABLE]";
            // Make the request
            PagedAsyncEnumerable<ListRoutesResponse, Route> response = hubServiceClient.ListRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Route item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutes</summary>
        public void ListRoutesResourceNames()
        {
            // Snippet: ListRoutes(RouteTableName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            RouteTableName parent = RouteTableName.FromProjectHubRouteTable("[PROJECT]", "[HUB]", "[ROUTE_TABLE]");
            // Make the request
            PagedEnumerable<ListRoutesResponse, Route> response = hubServiceClient.ListRoutes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Route item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRoutesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutesAsync</summary>
        public async Task ListRoutesResourceNamesAsync()
        {
            // Snippet: ListRoutesAsync(RouteTableName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            RouteTableName parent = RouteTableName.FromProjectHubRouteTable("[PROJECT]", "[HUB]", "[ROUTE_TABLE]");
            // Make the request
            PagedAsyncEnumerable<ListRoutesResponse, Route> response = hubServiceClient.ListRoutesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Route item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRoutesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Route item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Route> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Route item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRouteTables</summary>
        public void ListRouteTablesRequestObject()
        {
            // Snippet: ListRouteTables(ListRouteTablesRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            ListRouteTablesRequest request = new ListRouteTablesRequest
            {
                ParentAsHubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRouteTablesResponse, RouteTable> response = hubServiceClient.ListRouteTables(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RouteTable item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRouteTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RouteTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RouteTable> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RouteTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRouteTablesAsync</summary>
        public async Task ListRouteTablesRequestObjectAsync()
        {
            // Snippet: ListRouteTablesAsync(ListRouteTablesRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRouteTablesRequest request = new ListRouteTablesRequest
            {
                ParentAsHubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRouteTablesResponse, RouteTable> response = hubServiceClient.ListRouteTablesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RouteTable item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRouteTablesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RouteTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RouteTable> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RouteTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRouteTables</summary>
        public void ListRouteTables()
        {
            // Snippet: ListRouteTables(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            PagedEnumerable<ListRouteTablesResponse, RouteTable> response = hubServiceClient.ListRouteTables(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RouteTable item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRouteTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RouteTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RouteTable> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RouteTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRouteTablesAsync</summary>
        public async Task ListRouteTablesAsync()
        {
            // Snippet: ListRouteTablesAsync(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            PagedAsyncEnumerable<ListRouteTablesResponse, RouteTable> response = hubServiceClient.ListRouteTablesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RouteTable item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRouteTablesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RouteTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RouteTable> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RouteTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRouteTables</summary>
        public void ListRouteTablesResourceNames()
        {
            // Snippet: ListRouteTables(HubName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            HubName parent = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            PagedEnumerable<ListRouteTablesResponse, RouteTable> response = hubServiceClient.ListRouteTables(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RouteTable item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRouteTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RouteTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RouteTable> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RouteTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRouteTablesAsync</summary>
        public async Task ListRouteTablesResourceNamesAsync()
        {
            // Snippet: ListRouteTablesAsync(HubName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            HubName parent = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            PagedAsyncEnumerable<ListRouteTablesResponse, RouteTable> response = hubServiceClient.ListRouteTablesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RouteTable item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRouteTablesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RouteTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RouteTable> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RouteTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroupRequestObject()
        {
            // Snippet: GetGroup(GetGroupRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectHubGroup("[PROJECT]", "[HUB]", "[GROUP]"),
            };
            // Make the request
            Group response = hubServiceClient.GetGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupRequestObjectAsync()
        {
            // Snippet: GetGroupAsync(GetGroupRequest, CallSettings)
            // Additional: GetGroupAsync(GetGroupRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectHubGroup("[PROJECT]", "[HUB]", "[GROUP]"),
            };
            // Make the request
            Group response = await hubServiceClient.GetGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroup()
        {
            // Snippet: GetGroup(string, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]/groups/[GROUP]";
            // Make the request
            Group response = hubServiceClient.GetGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupAsync()
        {
            // Snippet: GetGroupAsync(string, CallSettings)
            // Additional: GetGroupAsync(string, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/hubs/[HUB]/groups/[GROUP]";
            // Make the request
            Group response = await hubServiceClient.GetGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroupResourceNames()
        {
            // Snippet: GetGroup(GroupName, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectHubGroup("[PROJECT]", "[HUB]", "[GROUP]");
            // Make the request
            Group response = hubServiceClient.GetGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupResourceNamesAsync()
        {
            // Snippet: GetGroupAsync(GroupName, CallSettings)
            // Additional: GetGroupAsync(GroupName, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectHubGroup("[PROJECT]", "[HUB]", "[GROUP]");
            // Make the request
            Group response = await hubServiceClient.GetGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroupsRequestObject()
        {
            // Snippet: ListGroups(ListGroupsRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            ListGroupsRequest request = new ListGroupsRequest
            {
                ParentAsHubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = hubServiceClient.ListGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsRequestObjectAsync()
        {
            // Snippet: ListGroupsAsync(ListGroupsRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGroupsRequest request = new ListGroupsRequest
            {
                ParentAsHubName = HubName.FromProjectHub("[PROJECT]", "[HUB]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = hubServiceClient.ListGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroups()
        {
            // Snippet: ListGroups(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = hubServiceClient.ListGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsAsync()
        {
            // Snippet: ListGroupsAsync(string, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/global/hubs/[HUB]";
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = hubServiceClient.ListGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroupsResourceNames()
        {
            // Snippet: ListGroups(HubName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            HubName parent = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = hubServiceClient.ListGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsResourceNamesAsync()
        {
            // Snippet: ListGroupsAsync(HubName, string, int?, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            HubName parent = HubName.FromProjectHub("[PROJECT]", "[HUB]");
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = hubServiceClient.ListGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateGroup</summary>
        public void UpdateGroupRequestObject()
        {
            // Snippet: UpdateGroup(UpdateGroupRequest, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                UpdateMask = new FieldMask(),
                Group = new Group(),
                RequestId = "",
            };
            // Make the request
            Operation<Group, OperationMetadata> response = hubServiceClient.UpdateGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceUpdateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGroupAsync</summary>
        public async Task UpdateGroupRequestObjectAsync()
        {
            // Snippet: UpdateGroupAsync(UpdateGroupRequest, CallSettings)
            // Additional: UpdateGroupAsync(UpdateGroupRequest, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                UpdateMask = new FieldMask(),
                Group = new Group(),
                RequestId = "",
            };
            // Make the request
            Operation<Group, OperationMetadata> response = await hubServiceClient.UpdateGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceUpdateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGroup</summary>
        public void UpdateGroup()
        {
            // Snippet: UpdateGroup(Group, FieldMask, CallSettings)
            // Create client
            HubServiceClient hubServiceClient = HubServiceClient.Create();
            // Initialize request argument(s)
            Group group = new Group();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Group, OperationMetadata> response = hubServiceClient.UpdateGroup(group, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = hubServiceClient.PollOnceUpdateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGroupAsync</summary>
        public async Task UpdateGroupAsync()
        {
            // Snippet: UpdateGroupAsync(Group, FieldMask, CallSettings)
            // Additional: UpdateGroupAsync(Group, FieldMask, CancellationToken)
            // Create client
            HubServiceClient hubServiceClient = await HubServiceClient.CreateAsync();
            // Initialize request argument(s)
            Group group = new Group();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Group, OperationMetadata> response = await hubServiceClient.UpdateGroupAsync(group, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await hubServiceClient.PollOnceUpdateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
