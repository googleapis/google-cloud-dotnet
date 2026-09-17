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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.NetworkServices.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDepServiceClientSnippets
    {
        /// <summary>Snippet for ListLbTrafficExtensions</summary>
        public void ListLbTrafficExtensionsRequestObject()
        {
            // Snippet: ListLbTrafficExtensions(ListLbTrafficExtensionsRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            ListLbTrafficExtensionsRequest request = new ListLbTrafficExtensionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> response = depServiceClient.ListLbTrafficExtensions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LbTrafficExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLbTrafficExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbTrafficExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbTrafficExtension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbTrafficExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLbTrafficExtensionsAsync</summary>
        public async Task ListLbTrafficExtensionsRequestObjectAsync()
        {
            // Snippet: ListLbTrafficExtensionsAsync(ListLbTrafficExtensionsRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLbTrafficExtensionsRequest request = new ListLbTrafficExtensionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> response = depServiceClient.ListLbTrafficExtensionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LbTrafficExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLbTrafficExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbTrafficExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbTrafficExtension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbTrafficExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLbTrafficExtensions</summary>
        public void ListLbTrafficExtensions()
        {
            // Snippet: ListLbTrafficExtensions(string, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> response = depServiceClient.ListLbTrafficExtensions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LbTrafficExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLbTrafficExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbTrafficExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbTrafficExtension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbTrafficExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLbTrafficExtensionsAsync</summary>
        public async Task ListLbTrafficExtensionsAsync()
        {
            // Snippet: ListLbTrafficExtensionsAsync(string, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> response = depServiceClient.ListLbTrafficExtensionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LbTrafficExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLbTrafficExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbTrafficExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbTrafficExtension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbTrafficExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLbTrafficExtensions</summary>
        public void ListLbTrafficExtensionsResourceNames()
        {
            // Snippet: ListLbTrafficExtensions(LocationName, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> response = depServiceClient.ListLbTrafficExtensions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LbTrafficExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLbTrafficExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbTrafficExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbTrafficExtension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbTrafficExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLbTrafficExtensionsAsync</summary>
        public async Task ListLbTrafficExtensionsResourceNamesAsync()
        {
            // Snippet: ListLbTrafficExtensionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> response = depServiceClient.ListLbTrafficExtensionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LbTrafficExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLbTrafficExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbTrafficExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbTrafficExtension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbTrafficExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLbTrafficExtension</summary>
        public void GetLbTrafficExtensionRequestObject()
        {
            // Snippet: GetLbTrafficExtension(GetLbTrafficExtensionRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            GetLbTrafficExtensionRequest request = new GetLbTrafficExtensionRequest
            {
                LbTrafficExtensionName = LbTrafficExtensionName.FromProjectLocationLbTrafficExtension("[PROJECT]", "[LOCATION]", "[LB_TRAFFIC_EXTENSION]"),
            };
            // Make the request
            LbTrafficExtension response = depServiceClient.GetLbTrafficExtension(request);
            // End snippet
        }

        /// <summary>Snippet for GetLbTrafficExtensionAsync</summary>
        public async Task GetLbTrafficExtensionRequestObjectAsync()
        {
            // Snippet: GetLbTrafficExtensionAsync(GetLbTrafficExtensionRequest, CallSettings)
            // Additional: GetLbTrafficExtensionAsync(GetLbTrafficExtensionRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLbTrafficExtensionRequest request = new GetLbTrafficExtensionRequest
            {
                LbTrafficExtensionName = LbTrafficExtensionName.FromProjectLocationLbTrafficExtension("[PROJECT]", "[LOCATION]", "[LB_TRAFFIC_EXTENSION]"),
            };
            // Make the request
            LbTrafficExtension response = await depServiceClient.GetLbTrafficExtensionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLbTrafficExtension</summary>
        public void GetLbTrafficExtension()
        {
            // Snippet: GetLbTrafficExtension(string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lbTrafficExtensions/[LB_TRAFFIC_EXTENSION]";
            // Make the request
            LbTrafficExtension response = depServiceClient.GetLbTrafficExtension(name);
            // End snippet
        }

        /// <summary>Snippet for GetLbTrafficExtensionAsync</summary>
        public async Task GetLbTrafficExtensionAsync()
        {
            // Snippet: GetLbTrafficExtensionAsync(string, CallSettings)
            // Additional: GetLbTrafficExtensionAsync(string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lbTrafficExtensions/[LB_TRAFFIC_EXTENSION]";
            // Make the request
            LbTrafficExtension response = await depServiceClient.GetLbTrafficExtensionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLbTrafficExtension</summary>
        public void GetLbTrafficExtensionResourceNames()
        {
            // Snippet: GetLbTrafficExtension(LbTrafficExtensionName, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LbTrafficExtensionName name = LbTrafficExtensionName.FromProjectLocationLbTrafficExtension("[PROJECT]", "[LOCATION]", "[LB_TRAFFIC_EXTENSION]");
            // Make the request
            LbTrafficExtension response = depServiceClient.GetLbTrafficExtension(name);
            // End snippet
        }

        /// <summary>Snippet for GetLbTrafficExtensionAsync</summary>
        public async Task GetLbTrafficExtensionResourceNamesAsync()
        {
            // Snippet: GetLbTrafficExtensionAsync(LbTrafficExtensionName, CallSettings)
            // Additional: GetLbTrafficExtensionAsync(LbTrafficExtensionName, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LbTrafficExtensionName name = LbTrafficExtensionName.FromProjectLocationLbTrafficExtension("[PROJECT]", "[LOCATION]", "[LB_TRAFFIC_EXTENSION]");
            // Make the request
            LbTrafficExtension response = await depServiceClient.GetLbTrafficExtensionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateLbTrafficExtension</summary>
        public void CreateLbTrafficExtensionRequestObject()
        {
            // Snippet: CreateLbTrafficExtension(CreateLbTrafficExtensionRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            CreateLbTrafficExtensionRequest request = new CreateLbTrafficExtensionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                LbTrafficExtensionId = "",
                LbTrafficExtension = new LbTrafficExtension(),
                RequestId = "",
            };
            // Make the request
            Operation<LbTrafficExtension, OperationMetadata> response = depServiceClient.CreateLbTrafficExtension(request);

            // Poll until the returned long-running operation is complete
            Operation<LbTrafficExtension, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LbTrafficExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbTrafficExtension, OperationMetadata> retrievedResponse = depServiceClient.PollOnceCreateLbTrafficExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbTrafficExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLbTrafficExtensionAsync</summary>
        public async Task CreateLbTrafficExtensionRequestObjectAsync()
        {
            // Snippet: CreateLbTrafficExtensionAsync(CreateLbTrafficExtensionRequest, CallSettings)
            // Additional: CreateLbTrafficExtensionAsync(CreateLbTrafficExtensionRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateLbTrafficExtensionRequest request = new CreateLbTrafficExtensionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                LbTrafficExtensionId = "",
                LbTrafficExtension = new LbTrafficExtension(),
                RequestId = "",
            };
            // Make the request
            Operation<LbTrafficExtension, OperationMetadata> response = await depServiceClient.CreateLbTrafficExtensionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<LbTrafficExtension, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LbTrafficExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbTrafficExtension, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceCreateLbTrafficExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbTrafficExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLbTrafficExtension</summary>
        public void CreateLbTrafficExtension()
        {
            // Snippet: CreateLbTrafficExtension(string, LbTrafficExtension, string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            LbTrafficExtension lbTrafficExtension = new LbTrafficExtension();
            string lbTrafficExtensionId = "";
            // Make the request
            Operation<LbTrafficExtension, OperationMetadata> response = depServiceClient.CreateLbTrafficExtension(parent, lbTrafficExtension, lbTrafficExtensionId);

            // Poll until the returned long-running operation is complete
            Operation<LbTrafficExtension, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LbTrafficExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbTrafficExtension, OperationMetadata> retrievedResponse = depServiceClient.PollOnceCreateLbTrafficExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbTrafficExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLbTrafficExtensionAsync</summary>
        public async Task CreateLbTrafficExtensionAsync()
        {
            // Snippet: CreateLbTrafficExtensionAsync(string, LbTrafficExtension, string, CallSettings)
            // Additional: CreateLbTrafficExtensionAsync(string, LbTrafficExtension, string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            LbTrafficExtension lbTrafficExtension = new LbTrafficExtension();
            string lbTrafficExtensionId = "";
            // Make the request
            Operation<LbTrafficExtension, OperationMetadata> response = await depServiceClient.CreateLbTrafficExtensionAsync(parent, lbTrafficExtension, lbTrafficExtensionId);

            // Poll until the returned long-running operation is complete
            Operation<LbTrafficExtension, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LbTrafficExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbTrafficExtension, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceCreateLbTrafficExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbTrafficExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLbTrafficExtension</summary>
        public void CreateLbTrafficExtensionResourceNames()
        {
            // Snippet: CreateLbTrafficExtension(LocationName, LbTrafficExtension, string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            LbTrafficExtension lbTrafficExtension = new LbTrafficExtension();
            string lbTrafficExtensionId = "";
            // Make the request
            Operation<LbTrafficExtension, OperationMetadata> response = depServiceClient.CreateLbTrafficExtension(parent, lbTrafficExtension, lbTrafficExtensionId);

            // Poll until the returned long-running operation is complete
            Operation<LbTrafficExtension, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LbTrafficExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbTrafficExtension, OperationMetadata> retrievedResponse = depServiceClient.PollOnceCreateLbTrafficExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbTrafficExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLbTrafficExtensionAsync</summary>
        public async Task CreateLbTrafficExtensionResourceNamesAsync()
        {
            // Snippet: CreateLbTrafficExtensionAsync(LocationName, LbTrafficExtension, string, CallSettings)
            // Additional: CreateLbTrafficExtensionAsync(LocationName, LbTrafficExtension, string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            LbTrafficExtension lbTrafficExtension = new LbTrafficExtension();
            string lbTrafficExtensionId = "";
            // Make the request
            Operation<LbTrafficExtension, OperationMetadata> response = await depServiceClient.CreateLbTrafficExtensionAsync(parent, lbTrafficExtension, lbTrafficExtensionId);

            // Poll until the returned long-running operation is complete
            Operation<LbTrafficExtension, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LbTrafficExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbTrafficExtension, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceCreateLbTrafficExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbTrafficExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLbTrafficExtension</summary>
        public void UpdateLbTrafficExtensionRequestObject()
        {
            // Snippet: UpdateLbTrafficExtension(UpdateLbTrafficExtensionRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            UpdateLbTrafficExtensionRequest request = new UpdateLbTrafficExtensionRequest
            {
                UpdateMask = new FieldMask(),
                LbTrafficExtension = new LbTrafficExtension(),
                RequestId = "",
            };
            // Make the request
            Operation<LbTrafficExtension, OperationMetadata> response = depServiceClient.UpdateLbTrafficExtension(request);

            // Poll until the returned long-running operation is complete
            Operation<LbTrafficExtension, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LbTrafficExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbTrafficExtension, OperationMetadata> retrievedResponse = depServiceClient.PollOnceUpdateLbTrafficExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbTrafficExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLbTrafficExtensionAsync</summary>
        public async Task UpdateLbTrafficExtensionRequestObjectAsync()
        {
            // Snippet: UpdateLbTrafficExtensionAsync(UpdateLbTrafficExtensionRequest, CallSettings)
            // Additional: UpdateLbTrafficExtensionAsync(UpdateLbTrafficExtensionRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateLbTrafficExtensionRequest request = new UpdateLbTrafficExtensionRequest
            {
                UpdateMask = new FieldMask(),
                LbTrafficExtension = new LbTrafficExtension(),
                RequestId = "",
            };
            // Make the request
            Operation<LbTrafficExtension, OperationMetadata> response = await depServiceClient.UpdateLbTrafficExtensionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<LbTrafficExtension, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LbTrafficExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbTrafficExtension, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceUpdateLbTrafficExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbTrafficExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLbTrafficExtension</summary>
        public void UpdateLbTrafficExtension()
        {
            // Snippet: UpdateLbTrafficExtension(LbTrafficExtension, FieldMask, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LbTrafficExtension lbTrafficExtension = new LbTrafficExtension();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<LbTrafficExtension, OperationMetadata> response = depServiceClient.UpdateLbTrafficExtension(lbTrafficExtension, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<LbTrafficExtension, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LbTrafficExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbTrafficExtension, OperationMetadata> retrievedResponse = depServiceClient.PollOnceUpdateLbTrafficExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbTrafficExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLbTrafficExtensionAsync</summary>
        public async Task UpdateLbTrafficExtensionAsync()
        {
            // Snippet: UpdateLbTrafficExtensionAsync(LbTrafficExtension, FieldMask, CallSettings)
            // Additional: UpdateLbTrafficExtensionAsync(LbTrafficExtension, FieldMask, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LbTrafficExtension lbTrafficExtension = new LbTrafficExtension();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<LbTrafficExtension, OperationMetadata> response = await depServiceClient.UpdateLbTrafficExtensionAsync(lbTrafficExtension, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<LbTrafficExtension, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LbTrafficExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbTrafficExtension, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceUpdateLbTrafficExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbTrafficExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbTrafficExtension</summary>
        public void DeleteLbTrafficExtensionRequestObject()
        {
            // Snippet: DeleteLbTrafficExtension(DeleteLbTrafficExtensionRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            DeleteLbTrafficExtensionRequest request = new DeleteLbTrafficExtensionRequest
            {
                LbTrafficExtensionName = LbTrafficExtensionName.FromProjectLocationLbTrafficExtension("[PROJECT]", "[LOCATION]", "[LB_TRAFFIC_EXTENSION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = depServiceClient.DeleteLbTrafficExtension(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = depServiceClient.PollOnceDeleteLbTrafficExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbTrafficExtensionAsync</summary>
        public async Task DeleteLbTrafficExtensionRequestObjectAsync()
        {
            // Snippet: DeleteLbTrafficExtensionAsync(DeleteLbTrafficExtensionRequest, CallSettings)
            // Additional: DeleteLbTrafficExtensionAsync(DeleteLbTrafficExtensionRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteLbTrafficExtensionRequest request = new DeleteLbTrafficExtensionRequest
            {
                LbTrafficExtensionName = LbTrafficExtensionName.FromProjectLocationLbTrafficExtension("[PROJECT]", "[LOCATION]", "[LB_TRAFFIC_EXTENSION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await depServiceClient.DeleteLbTrafficExtensionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceDeleteLbTrafficExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbTrafficExtension</summary>
        public void DeleteLbTrafficExtension()
        {
            // Snippet: DeleteLbTrafficExtension(string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lbTrafficExtensions/[LB_TRAFFIC_EXTENSION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = depServiceClient.DeleteLbTrafficExtension(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = depServiceClient.PollOnceDeleteLbTrafficExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbTrafficExtensionAsync</summary>
        public async Task DeleteLbTrafficExtensionAsync()
        {
            // Snippet: DeleteLbTrafficExtensionAsync(string, CallSettings)
            // Additional: DeleteLbTrafficExtensionAsync(string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lbTrafficExtensions/[LB_TRAFFIC_EXTENSION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await depServiceClient.DeleteLbTrafficExtensionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceDeleteLbTrafficExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbTrafficExtension</summary>
        public void DeleteLbTrafficExtensionResourceNames()
        {
            // Snippet: DeleteLbTrafficExtension(LbTrafficExtensionName, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LbTrafficExtensionName name = LbTrafficExtensionName.FromProjectLocationLbTrafficExtension("[PROJECT]", "[LOCATION]", "[LB_TRAFFIC_EXTENSION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = depServiceClient.DeleteLbTrafficExtension(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = depServiceClient.PollOnceDeleteLbTrafficExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbTrafficExtensionAsync</summary>
        public async Task DeleteLbTrafficExtensionResourceNamesAsync()
        {
            // Snippet: DeleteLbTrafficExtensionAsync(LbTrafficExtensionName, CallSettings)
            // Additional: DeleteLbTrafficExtensionAsync(LbTrafficExtensionName, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LbTrafficExtensionName name = LbTrafficExtensionName.FromProjectLocationLbTrafficExtension("[PROJECT]", "[LOCATION]", "[LB_TRAFFIC_EXTENSION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await depServiceClient.DeleteLbTrafficExtensionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceDeleteLbTrafficExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListLbRouteExtensions</summary>
        public void ListLbRouteExtensionsRequestObject()
        {
            // Snippet: ListLbRouteExtensions(ListLbRouteExtensionsRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            ListLbRouteExtensionsRequest request = new ListLbRouteExtensionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> response = depServiceClient.ListLbRouteExtensions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LbRouteExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLbRouteExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbRouteExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbRouteExtension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbRouteExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLbRouteExtensionsAsync</summary>
        public async Task ListLbRouteExtensionsRequestObjectAsync()
        {
            // Snippet: ListLbRouteExtensionsAsync(ListLbRouteExtensionsRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLbRouteExtensionsRequest request = new ListLbRouteExtensionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> response = depServiceClient.ListLbRouteExtensionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LbRouteExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLbRouteExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbRouteExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbRouteExtension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbRouteExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLbRouteExtensions</summary>
        public void ListLbRouteExtensions()
        {
            // Snippet: ListLbRouteExtensions(string, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> response = depServiceClient.ListLbRouteExtensions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LbRouteExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLbRouteExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbRouteExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbRouteExtension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbRouteExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLbRouteExtensionsAsync</summary>
        public async Task ListLbRouteExtensionsAsync()
        {
            // Snippet: ListLbRouteExtensionsAsync(string, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> response = depServiceClient.ListLbRouteExtensionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LbRouteExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLbRouteExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbRouteExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbRouteExtension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbRouteExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLbRouteExtensions</summary>
        public void ListLbRouteExtensionsResourceNames()
        {
            // Snippet: ListLbRouteExtensions(LocationName, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> response = depServiceClient.ListLbRouteExtensions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LbRouteExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLbRouteExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbRouteExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbRouteExtension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbRouteExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLbRouteExtensionsAsync</summary>
        public async Task ListLbRouteExtensionsResourceNamesAsync()
        {
            // Snippet: ListLbRouteExtensionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> response = depServiceClient.ListLbRouteExtensionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LbRouteExtension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLbRouteExtensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LbRouteExtension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LbRouteExtension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LbRouteExtension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLbRouteExtension</summary>
        public void GetLbRouteExtensionRequestObject()
        {
            // Snippet: GetLbRouteExtension(GetLbRouteExtensionRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            GetLbRouteExtensionRequest request = new GetLbRouteExtensionRequest
            {
                LbRouteExtensionName = LbRouteExtensionName.FromProjectLocationLbRouteExtension("[PROJECT]", "[LOCATION]", "[LB_ROUTE_EXTENSION]"),
            };
            // Make the request
            LbRouteExtension response = depServiceClient.GetLbRouteExtension(request);
            // End snippet
        }

        /// <summary>Snippet for GetLbRouteExtensionAsync</summary>
        public async Task GetLbRouteExtensionRequestObjectAsync()
        {
            // Snippet: GetLbRouteExtensionAsync(GetLbRouteExtensionRequest, CallSettings)
            // Additional: GetLbRouteExtensionAsync(GetLbRouteExtensionRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLbRouteExtensionRequest request = new GetLbRouteExtensionRequest
            {
                LbRouteExtensionName = LbRouteExtensionName.FromProjectLocationLbRouteExtension("[PROJECT]", "[LOCATION]", "[LB_ROUTE_EXTENSION]"),
            };
            // Make the request
            LbRouteExtension response = await depServiceClient.GetLbRouteExtensionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLbRouteExtension</summary>
        public void GetLbRouteExtension()
        {
            // Snippet: GetLbRouteExtension(string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lbRouteExtensions/[LB_ROUTE_EXTENSION]";
            // Make the request
            LbRouteExtension response = depServiceClient.GetLbRouteExtension(name);
            // End snippet
        }

        /// <summary>Snippet for GetLbRouteExtensionAsync</summary>
        public async Task GetLbRouteExtensionAsync()
        {
            // Snippet: GetLbRouteExtensionAsync(string, CallSettings)
            // Additional: GetLbRouteExtensionAsync(string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lbRouteExtensions/[LB_ROUTE_EXTENSION]";
            // Make the request
            LbRouteExtension response = await depServiceClient.GetLbRouteExtensionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLbRouteExtension</summary>
        public void GetLbRouteExtensionResourceNames()
        {
            // Snippet: GetLbRouteExtension(LbRouteExtensionName, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LbRouteExtensionName name = LbRouteExtensionName.FromProjectLocationLbRouteExtension("[PROJECT]", "[LOCATION]", "[LB_ROUTE_EXTENSION]");
            // Make the request
            LbRouteExtension response = depServiceClient.GetLbRouteExtension(name);
            // End snippet
        }

        /// <summary>Snippet for GetLbRouteExtensionAsync</summary>
        public async Task GetLbRouteExtensionResourceNamesAsync()
        {
            // Snippet: GetLbRouteExtensionAsync(LbRouteExtensionName, CallSettings)
            // Additional: GetLbRouteExtensionAsync(LbRouteExtensionName, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LbRouteExtensionName name = LbRouteExtensionName.FromProjectLocationLbRouteExtension("[PROJECT]", "[LOCATION]", "[LB_ROUTE_EXTENSION]");
            // Make the request
            LbRouteExtension response = await depServiceClient.GetLbRouteExtensionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateLbRouteExtension</summary>
        public void CreateLbRouteExtensionRequestObject()
        {
            // Snippet: CreateLbRouteExtension(CreateLbRouteExtensionRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            CreateLbRouteExtensionRequest request = new CreateLbRouteExtensionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                LbRouteExtensionId = "",
                LbRouteExtension = new LbRouteExtension(),
                RequestId = "",
            };
            // Make the request
            Operation<LbRouteExtension, OperationMetadata> response = depServiceClient.CreateLbRouteExtension(request);

            // Poll until the returned long-running operation is complete
            Operation<LbRouteExtension, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LbRouteExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbRouteExtension, OperationMetadata> retrievedResponse = depServiceClient.PollOnceCreateLbRouteExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbRouteExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLbRouteExtensionAsync</summary>
        public async Task CreateLbRouteExtensionRequestObjectAsync()
        {
            // Snippet: CreateLbRouteExtensionAsync(CreateLbRouteExtensionRequest, CallSettings)
            // Additional: CreateLbRouteExtensionAsync(CreateLbRouteExtensionRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateLbRouteExtensionRequest request = new CreateLbRouteExtensionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                LbRouteExtensionId = "",
                LbRouteExtension = new LbRouteExtension(),
                RequestId = "",
            };
            // Make the request
            Operation<LbRouteExtension, OperationMetadata> response = await depServiceClient.CreateLbRouteExtensionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<LbRouteExtension, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LbRouteExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbRouteExtension, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceCreateLbRouteExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbRouteExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLbRouteExtension</summary>
        public void CreateLbRouteExtension()
        {
            // Snippet: CreateLbRouteExtension(string, LbRouteExtension, string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            LbRouteExtension lbRouteExtension = new LbRouteExtension();
            string lbRouteExtensionId = "";
            // Make the request
            Operation<LbRouteExtension, OperationMetadata> response = depServiceClient.CreateLbRouteExtension(parent, lbRouteExtension, lbRouteExtensionId);

            // Poll until the returned long-running operation is complete
            Operation<LbRouteExtension, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LbRouteExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbRouteExtension, OperationMetadata> retrievedResponse = depServiceClient.PollOnceCreateLbRouteExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbRouteExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLbRouteExtensionAsync</summary>
        public async Task CreateLbRouteExtensionAsync()
        {
            // Snippet: CreateLbRouteExtensionAsync(string, LbRouteExtension, string, CallSettings)
            // Additional: CreateLbRouteExtensionAsync(string, LbRouteExtension, string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            LbRouteExtension lbRouteExtension = new LbRouteExtension();
            string lbRouteExtensionId = "";
            // Make the request
            Operation<LbRouteExtension, OperationMetadata> response = await depServiceClient.CreateLbRouteExtensionAsync(parent, lbRouteExtension, lbRouteExtensionId);

            // Poll until the returned long-running operation is complete
            Operation<LbRouteExtension, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LbRouteExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbRouteExtension, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceCreateLbRouteExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbRouteExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLbRouteExtension</summary>
        public void CreateLbRouteExtensionResourceNames()
        {
            // Snippet: CreateLbRouteExtension(LocationName, LbRouteExtension, string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            LbRouteExtension lbRouteExtension = new LbRouteExtension();
            string lbRouteExtensionId = "";
            // Make the request
            Operation<LbRouteExtension, OperationMetadata> response = depServiceClient.CreateLbRouteExtension(parent, lbRouteExtension, lbRouteExtensionId);

            // Poll until the returned long-running operation is complete
            Operation<LbRouteExtension, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LbRouteExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbRouteExtension, OperationMetadata> retrievedResponse = depServiceClient.PollOnceCreateLbRouteExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbRouteExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLbRouteExtensionAsync</summary>
        public async Task CreateLbRouteExtensionResourceNamesAsync()
        {
            // Snippet: CreateLbRouteExtensionAsync(LocationName, LbRouteExtension, string, CallSettings)
            // Additional: CreateLbRouteExtensionAsync(LocationName, LbRouteExtension, string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            LbRouteExtension lbRouteExtension = new LbRouteExtension();
            string lbRouteExtensionId = "";
            // Make the request
            Operation<LbRouteExtension, OperationMetadata> response = await depServiceClient.CreateLbRouteExtensionAsync(parent, lbRouteExtension, lbRouteExtensionId);

            // Poll until the returned long-running operation is complete
            Operation<LbRouteExtension, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LbRouteExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbRouteExtension, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceCreateLbRouteExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbRouteExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLbRouteExtension</summary>
        public void UpdateLbRouteExtensionRequestObject()
        {
            // Snippet: UpdateLbRouteExtension(UpdateLbRouteExtensionRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            UpdateLbRouteExtensionRequest request = new UpdateLbRouteExtensionRequest
            {
                UpdateMask = new FieldMask(),
                LbRouteExtension = new LbRouteExtension(),
                RequestId = "",
            };
            // Make the request
            Operation<LbRouteExtension, OperationMetadata> response = depServiceClient.UpdateLbRouteExtension(request);

            // Poll until the returned long-running operation is complete
            Operation<LbRouteExtension, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LbRouteExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbRouteExtension, OperationMetadata> retrievedResponse = depServiceClient.PollOnceUpdateLbRouteExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbRouteExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLbRouteExtensionAsync</summary>
        public async Task UpdateLbRouteExtensionRequestObjectAsync()
        {
            // Snippet: UpdateLbRouteExtensionAsync(UpdateLbRouteExtensionRequest, CallSettings)
            // Additional: UpdateLbRouteExtensionAsync(UpdateLbRouteExtensionRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateLbRouteExtensionRequest request = new UpdateLbRouteExtensionRequest
            {
                UpdateMask = new FieldMask(),
                LbRouteExtension = new LbRouteExtension(),
                RequestId = "",
            };
            // Make the request
            Operation<LbRouteExtension, OperationMetadata> response = await depServiceClient.UpdateLbRouteExtensionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<LbRouteExtension, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LbRouteExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbRouteExtension, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceUpdateLbRouteExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbRouteExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLbRouteExtension</summary>
        public void UpdateLbRouteExtension()
        {
            // Snippet: UpdateLbRouteExtension(LbRouteExtension, FieldMask, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LbRouteExtension lbRouteExtension = new LbRouteExtension();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<LbRouteExtension, OperationMetadata> response = depServiceClient.UpdateLbRouteExtension(lbRouteExtension, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<LbRouteExtension, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LbRouteExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbRouteExtension, OperationMetadata> retrievedResponse = depServiceClient.PollOnceUpdateLbRouteExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbRouteExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLbRouteExtensionAsync</summary>
        public async Task UpdateLbRouteExtensionAsync()
        {
            // Snippet: UpdateLbRouteExtensionAsync(LbRouteExtension, FieldMask, CallSettings)
            // Additional: UpdateLbRouteExtensionAsync(LbRouteExtension, FieldMask, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LbRouteExtension lbRouteExtension = new LbRouteExtension();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<LbRouteExtension, OperationMetadata> response = await depServiceClient.UpdateLbRouteExtensionAsync(lbRouteExtension, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<LbRouteExtension, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LbRouteExtension result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LbRouteExtension, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceUpdateLbRouteExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LbRouteExtension retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbRouteExtension</summary>
        public void DeleteLbRouteExtensionRequestObject()
        {
            // Snippet: DeleteLbRouteExtension(DeleteLbRouteExtensionRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            DeleteLbRouteExtensionRequest request = new DeleteLbRouteExtensionRequest
            {
                LbRouteExtensionName = LbRouteExtensionName.FromProjectLocationLbRouteExtension("[PROJECT]", "[LOCATION]", "[LB_ROUTE_EXTENSION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = depServiceClient.DeleteLbRouteExtension(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = depServiceClient.PollOnceDeleteLbRouteExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbRouteExtensionAsync</summary>
        public async Task DeleteLbRouteExtensionRequestObjectAsync()
        {
            // Snippet: DeleteLbRouteExtensionAsync(DeleteLbRouteExtensionRequest, CallSettings)
            // Additional: DeleteLbRouteExtensionAsync(DeleteLbRouteExtensionRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteLbRouteExtensionRequest request = new DeleteLbRouteExtensionRequest
            {
                LbRouteExtensionName = LbRouteExtensionName.FromProjectLocationLbRouteExtension("[PROJECT]", "[LOCATION]", "[LB_ROUTE_EXTENSION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await depServiceClient.DeleteLbRouteExtensionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceDeleteLbRouteExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbRouteExtension</summary>
        public void DeleteLbRouteExtension()
        {
            // Snippet: DeleteLbRouteExtension(string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lbRouteExtensions/[LB_ROUTE_EXTENSION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = depServiceClient.DeleteLbRouteExtension(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = depServiceClient.PollOnceDeleteLbRouteExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbRouteExtensionAsync</summary>
        public async Task DeleteLbRouteExtensionAsync()
        {
            // Snippet: DeleteLbRouteExtensionAsync(string, CallSettings)
            // Additional: DeleteLbRouteExtensionAsync(string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lbRouteExtensions/[LB_ROUTE_EXTENSION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await depServiceClient.DeleteLbRouteExtensionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceDeleteLbRouteExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbRouteExtension</summary>
        public void DeleteLbRouteExtensionResourceNames()
        {
            // Snippet: DeleteLbRouteExtension(LbRouteExtensionName, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LbRouteExtensionName name = LbRouteExtensionName.FromProjectLocationLbRouteExtension("[PROJECT]", "[LOCATION]", "[LB_ROUTE_EXTENSION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = depServiceClient.DeleteLbRouteExtension(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = depServiceClient.PollOnceDeleteLbRouteExtension(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLbRouteExtensionAsync</summary>
        public async Task DeleteLbRouteExtensionResourceNamesAsync()
        {
            // Snippet: DeleteLbRouteExtensionAsync(LbRouteExtensionName, CallSettings)
            // Additional: DeleteLbRouteExtensionAsync(LbRouteExtensionName, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LbRouteExtensionName name = LbRouteExtensionName.FromProjectLocationLbRouteExtension("[PROJECT]", "[LOCATION]", "[LB_ROUTE_EXTENSION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await depServiceClient.DeleteLbRouteExtensionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceDeleteLbRouteExtensionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListExtensionBindings</summary>
        public void ListExtensionBindingsRequestObject()
        {
            // Snippet: ListExtensionBindings(ListExtensionBindingsRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            ListExtensionBindingsRequest request = new ListExtensionBindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListExtensionBindingsResponse, ExtensionBinding> response = depServiceClient.ListExtensionBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExtensionBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExtensionBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExtensionBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExtensionBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExtensionBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExtensionBindingsAsync</summary>
        public async Task ListExtensionBindingsRequestObjectAsync()
        {
            // Snippet: ListExtensionBindingsAsync(ListExtensionBindingsRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListExtensionBindingsRequest request = new ListExtensionBindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListExtensionBindingsResponse, ExtensionBinding> response = depServiceClient.ListExtensionBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ExtensionBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExtensionBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExtensionBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExtensionBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExtensionBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExtensionBindings</summary>
        public void ListExtensionBindings()
        {
            // Snippet: ListExtensionBindings(string, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListExtensionBindingsResponse, ExtensionBinding> response = depServiceClient.ListExtensionBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExtensionBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExtensionBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExtensionBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExtensionBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExtensionBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExtensionBindingsAsync</summary>
        public async Task ListExtensionBindingsAsync()
        {
            // Snippet: ListExtensionBindingsAsync(string, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListExtensionBindingsResponse, ExtensionBinding> response = depServiceClient.ListExtensionBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ExtensionBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExtensionBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExtensionBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExtensionBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExtensionBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExtensionBindings</summary>
        public void ListExtensionBindingsResourceNames()
        {
            // Snippet: ListExtensionBindings(LocationName, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListExtensionBindingsResponse, ExtensionBinding> response = depServiceClient.ListExtensionBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExtensionBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExtensionBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExtensionBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExtensionBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExtensionBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExtensionBindingsAsync</summary>
        public async Task ListExtensionBindingsResourceNamesAsync()
        {
            // Snippet: ListExtensionBindingsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListExtensionBindingsResponse, ExtensionBinding> response = depServiceClient.ListExtensionBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ExtensionBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExtensionBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExtensionBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExtensionBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExtensionBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExtensionBinding</summary>
        public void GetExtensionBindingRequestObject()
        {
            // Snippet: GetExtensionBinding(GetExtensionBindingRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            GetExtensionBindingRequest request = new GetExtensionBindingRequest
            {
                ExtensionBindingName = ExtensionBindingName.FromProjectLocationExtensionBinding("[PROJECT]", "[LOCATION]", "[EXTENSION_BINDING]"),
            };
            // Make the request
            ExtensionBinding response = depServiceClient.GetExtensionBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionBindingAsync</summary>
        public async Task GetExtensionBindingRequestObjectAsync()
        {
            // Snippet: GetExtensionBindingAsync(GetExtensionBindingRequest, CallSettings)
            // Additional: GetExtensionBindingAsync(GetExtensionBindingRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetExtensionBindingRequest request = new GetExtensionBindingRequest
            {
                ExtensionBindingName = ExtensionBindingName.FromProjectLocationExtensionBinding("[PROJECT]", "[LOCATION]", "[EXTENSION_BINDING]"),
            };
            // Make the request
            ExtensionBinding response = await depServiceClient.GetExtensionBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionBinding</summary>
        public void GetExtensionBinding()
        {
            // Snippet: GetExtensionBinding(string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensionBindings/[EXTENSION_BINDING]";
            // Make the request
            ExtensionBinding response = depServiceClient.GetExtensionBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionBindingAsync</summary>
        public async Task GetExtensionBindingAsync()
        {
            // Snippet: GetExtensionBindingAsync(string, CallSettings)
            // Additional: GetExtensionBindingAsync(string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensionBindings/[EXTENSION_BINDING]";
            // Make the request
            ExtensionBinding response = await depServiceClient.GetExtensionBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionBinding</summary>
        public void GetExtensionBindingResourceNames()
        {
            // Snippet: GetExtensionBinding(ExtensionBindingName, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            ExtensionBindingName name = ExtensionBindingName.FromProjectLocationExtensionBinding("[PROJECT]", "[LOCATION]", "[EXTENSION_BINDING]");
            // Make the request
            ExtensionBinding response = depServiceClient.GetExtensionBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetExtensionBindingAsync</summary>
        public async Task GetExtensionBindingResourceNamesAsync()
        {
            // Snippet: GetExtensionBindingAsync(ExtensionBindingName, CallSettings)
            // Additional: GetExtensionBindingAsync(ExtensionBindingName, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExtensionBindingName name = ExtensionBindingName.FromProjectLocationExtensionBinding("[PROJECT]", "[LOCATION]", "[EXTENSION_BINDING]");
            // Make the request
            ExtensionBinding response = await depServiceClient.GetExtensionBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateExtensionBinding</summary>
        public void CreateExtensionBindingRequestObject()
        {
            // Snippet: CreateExtensionBinding(CreateExtensionBindingRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            CreateExtensionBindingRequest request = new CreateExtensionBindingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExtensionBindingId = "",
                ExtensionBinding = new ExtensionBinding(),
            };
            // Make the request
            Operation<ExtensionBinding, OperationMetadata> response = depServiceClient.CreateExtensionBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<ExtensionBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExtensionBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExtensionBinding, OperationMetadata> retrievedResponse = depServiceClient.PollOnceCreateExtensionBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExtensionBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExtensionBindingAsync</summary>
        public async Task CreateExtensionBindingRequestObjectAsync()
        {
            // Snippet: CreateExtensionBindingAsync(CreateExtensionBindingRequest, CallSettings)
            // Additional: CreateExtensionBindingAsync(CreateExtensionBindingRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateExtensionBindingRequest request = new CreateExtensionBindingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExtensionBindingId = "",
                ExtensionBinding = new ExtensionBinding(),
            };
            // Make the request
            Operation<ExtensionBinding, OperationMetadata> response = await depServiceClient.CreateExtensionBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExtensionBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExtensionBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExtensionBinding, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceCreateExtensionBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExtensionBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExtensionBinding</summary>
        public void CreateExtensionBinding()
        {
            // Snippet: CreateExtensionBinding(string, ExtensionBinding, string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ExtensionBinding extensionBinding = new ExtensionBinding();
            string extensionBindingId = "";
            // Make the request
            Operation<ExtensionBinding, OperationMetadata> response = depServiceClient.CreateExtensionBinding(parent, extensionBinding, extensionBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ExtensionBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExtensionBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExtensionBinding, OperationMetadata> retrievedResponse = depServiceClient.PollOnceCreateExtensionBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExtensionBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExtensionBindingAsync</summary>
        public async Task CreateExtensionBindingAsync()
        {
            // Snippet: CreateExtensionBindingAsync(string, ExtensionBinding, string, CallSettings)
            // Additional: CreateExtensionBindingAsync(string, ExtensionBinding, string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ExtensionBinding extensionBinding = new ExtensionBinding();
            string extensionBindingId = "";
            // Make the request
            Operation<ExtensionBinding, OperationMetadata> response = await depServiceClient.CreateExtensionBindingAsync(parent, extensionBinding, extensionBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ExtensionBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExtensionBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExtensionBinding, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceCreateExtensionBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExtensionBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExtensionBinding</summary>
        public void CreateExtensionBindingResourceNames()
        {
            // Snippet: CreateExtensionBinding(LocationName, ExtensionBinding, string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ExtensionBinding extensionBinding = new ExtensionBinding();
            string extensionBindingId = "";
            // Make the request
            Operation<ExtensionBinding, OperationMetadata> response = depServiceClient.CreateExtensionBinding(parent, extensionBinding, extensionBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ExtensionBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExtensionBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExtensionBinding, OperationMetadata> retrievedResponse = depServiceClient.PollOnceCreateExtensionBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExtensionBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExtensionBindingAsync</summary>
        public async Task CreateExtensionBindingResourceNamesAsync()
        {
            // Snippet: CreateExtensionBindingAsync(LocationName, ExtensionBinding, string, CallSettings)
            // Additional: CreateExtensionBindingAsync(LocationName, ExtensionBinding, string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ExtensionBinding extensionBinding = new ExtensionBinding();
            string extensionBindingId = "";
            // Make the request
            Operation<ExtensionBinding, OperationMetadata> response = await depServiceClient.CreateExtensionBindingAsync(parent, extensionBinding, extensionBindingId);

            // Poll until the returned long-running operation is complete
            Operation<ExtensionBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExtensionBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExtensionBinding, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceCreateExtensionBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExtensionBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExtensionBinding</summary>
        public void UpdateExtensionBindingRequestObject()
        {
            // Snippet: UpdateExtensionBinding(UpdateExtensionBindingRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            UpdateExtensionBindingRequest request = new UpdateExtensionBindingRequest
            {
                UpdateMask = new FieldMask(),
                ExtensionBinding = new ExtensionBinding(),
            };
            // Make the request
            Operation<ExtensionBinding, OperationMetadata> response = depServiceClient.UpdateExtensionBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<ExtensionBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExtensionBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExtensionBinding, OperationMetadata> retrievedResponse = depServiceClient.PollOnceUpdateExtensionBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExtensionBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExtensionBindingAsync</summary>
        public async Task UpdateExtensionBindingRequestObjectAsync()
        {
            // Snippet: UpdateExtensionBindingAsync(UpdateExtensionBindingRequest, CallSettings)
            // Additional: UpdateExtensionBindingAsync(UpdateExtensionBindingRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExtensionBindingRequest request = new UpdateExtensionBindingRequest
            {
                UpdateMask = new FieldMask(),
                ExtensionBinding = new ExtensionBinding(),
            };
            // Make the request
            Operation<ExtensionBinding, OperationMetadata> response = await depServiceClient.UpdateExtensionBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExtensionBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExtensionBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExtensionBinding, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceUpdateExtensionBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExtensionBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExtensionBinding</summary>
        public void UpdateExtensionBinding()
        {
            // Snippet: UpdateExtensionBinding(ExtensionBinding, FieldMask, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            ExtensionBinding extensionBinding = new ExtensionBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ExtensionBinding, OperationMetadata> response = depServiceClient.UpdateExtensionBinding(extensionBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ExtensionBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExtensionBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExtensionBinding, OperationMetadata> retrievedResponse = depServiceClient.PollOnceUpdateExtensionBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExtensionBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExtensionBindingAsync</summary>
        public async Task UpdateExtensionBindingAsync()
        {
            // Snippet: UpdateExtensionBindingAsync(ExtensionBinding, FieldMask, CallSettings)
            // Additional: UpdateExtensionBindingAsync(ExtensionBinding, FieldMask, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExtensionBinding extensionBinding = new ExtensionBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ExtensionBinding, OperationMetadata> response = await depServiceClient.UpdateExtensionBindingAsync(extensionBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ExtensionBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExtensionBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExtensionBinding, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceUpdateExtensionBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExtensionBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExtensionBinding</summary>
        public void DeleteExtensionBindingRequestObject()
        {
            // Snippet: DeleteExtensionBinding(DeleteExtensionBindingRequest, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            DeleteExtensionBindingRequest request = new DeleteExtensionBindingRequest
            {
                ExtensionBindingName = ExtensionBindingName.FromProjectLocationExtensionBinding("[PROJECT]", "[LOCATION]", "[EXTENSION_BINDING]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = depServiceClient.DeleteExtensionBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = depServiceClient.PollOnceDeleteExtensionBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExtensionBindingAsync</summary>
        public async Task DeleteExtensionBindingRequestObjectAsync()
        {
            // Snippet: DeleteExtensionBindingAsync(DeleteExtensionBindingRequest, CallSettings)
            // Additional: DeleteExtensionBindingAsync(DeleteExtensionBindingRequest, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExtensionBindingRequest request = new DeleteExtensionBindingRequest
            {
                ExtensionBindingName = ExtensionBindingName.FromProjectLocationExtensionBinding("[PROJECT]", "[LOCATION]", "[EXTENSION_BINDING]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await depServiceClient.DeleteExtensionBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceDeleteExtensionBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExtensionBinding</summary>
        public void DeleteExtensionBinding()
        {
            // Snippet: DeleteExtensionBinding(string, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensionBindings/[EXTENSION_BINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = depServiceClient.DeleteExtensionBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = depServiceClient.PollOnceDeleteExtensionBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExtensionBindingAsync</summary>
        public async Task DeleteExtensionBindingAsync()
        {
            // Snippet: DeleteExtensionBindingAsync(string, CallSettings)
            // Additional: DeleteExtensionBindingAsync(string, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensionBindings/[EXTENSION_BINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await depServiceClient.DeleteExtensionBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceDeleteExtensionBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExtensionBinding</summary>
        public void DeleteExtensionBindingResourceNames()
        {
            // Snippet: DeleteExtensionBinding(ExtensionBindingName, CallSettings)
            // Create client
            DepServiceClient depServiceClient = DepServiceClient.Create();
            // Initialize request argument(s)
            ExtensionBindingName name = ExtensionBindingName.FromProjectLocationExtensionBinding("[PROJECT]", "[LOCATION]", "[EXTENSION_BINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = depServiceClient.DeleteExtensionBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = depServiceClient.PollOnceDeleteExtensionBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExtensionBindingAsync</summary>
        public async Task DeleteExtensionBindingResourceNamesAsync()
        {
            // Snippet: DeleteExtensionBindingAsync(ExtensionBindingName, CallSettings)
            // Additional: DeleteExtensionBindingAsync(ExtensionBindingName, CancellationToken)
            // Create client
            DepServiceClient depServiceClient = await DepServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExtensionBindingName name = ExtensionBindingName.FromProjectLocationExtensionBinding("[PROJECT]", "[LOCATION]", "[EXTENSION_BINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await depServiceClient.DeleteExtensionBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await depServiceClient.PollOnceDeleteExtensionBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
