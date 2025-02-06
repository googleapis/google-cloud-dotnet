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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.BeyondCorp.AppGateways.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAppGatewaysServiceClientSnippets
    {
        /// <summary>Snippet for ListAppGateways</summary>
        public void ListAppGatewaysRequestObject()
        {
            // Snippet: ListAppGateways(ListAppGatewaysRequest, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            ListAppGatewaysRequest request = new ListAppGatewaysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAppGatewaysResponse, AppGateway> response = appGatewaysServiceClient.ListAppGateways(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppGateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppGateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppGatewaysAsync</summary>
        public async Task ListAppGatewaysRequestObjectAsync()
        {
            // Snippet: ListAppGatewaysAsync(ListAppGatewaysRequest, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAppGatewaysRequest request = new ListAppGatewaysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAppGatewaysResponse, AppGateway> response = appGatewaysServiceClient.ListAppGatewaysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AppGateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAppGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppGateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppGateways</summary>
        public void ListAppGateways()
        {
            // Snippet: ListAppGateways(string, string, int?, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAppGatewaysResponse, AppGateway> response = appGatewaysServiceClient.ListAppGateways(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppGateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppGateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppGatewaysAsync</summary>
        public async Task ListAppGatewaysAsync()
        {
            // Snippet: ListAppGatewaysAsync(string, string, int?, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAppGatewaysResponse, AppGateway> response = appGatewaysServiceClient.ListAppGatewaysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AppGateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAppGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppGateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppGateways</summary>
        public void ListAppGatewaysResourceNames()
        {
            // Snippet: ListAppGateways(LocationName, string, int?, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAppGatewaysResponse, AppGateway> response = appGatewaysServiceClient.ListAppGateways(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppGateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppGateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppGatewaysAsync</summary>
        public async Task ListAppGatewaysResourceNamesAsync()
        {
            // Snippet: ListAppGatewaysAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAppGatewaysResponse, AppGateway> response = appGatewaysServiceClient.ListAppGatewaysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AppGateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAppGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppGateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAppGateway</summary>
        public void GetAppGatewayRequestObject()
        {
            // Snippet: GetAppGateway(GetAppGatewayRequest, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            GetAppGatewayRequest request = new GetAppGatewayRequest
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
            };
            // Make the request
            AppGateway response = appGatewaysServiceClient.GetAppGateway(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppGatewayAsync</summary>
        public async Task GetAppGatewayRequestObjectAsync()
        {
            // Snippet: GetAppGatewayAsync(GetAppGatewayRequest, CallSettings)
            // Additional: GetAppGatewayAsync(GetAppGatewayRequest, CancellationToken)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAppGatewayRequest request = new GetAppGatewayRequest
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
            };
            // Make the request
            AppGateway response = await appGatewaysServiceClient.GetAppGatewayAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppGateway</summary>
        public void GetAppGateway()
        {
            // Snippet: GetAppGateway(string, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appGateways/[APP_GATEWAY]";
            // Make the request
            AppGateway response = appGatewaysServiceClient.GetAppGateway(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppGatewayAsync</summary>
        public async Task GetAppGatewayAsync()
        {
            // Snippet: GetAppGatewayAsync(string, CallSettings)
            // Additional: GetAppGatewayAsync(string, CancellationToken)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appGateways/[APP_GATEWAY]";
            // Make the request
            AppGateway response = await appGatewaysServiceClient.GetAppGatewayAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppGateway</summary>
        public void GetAppGatewayResourceNames()
        {
            // Snippet: GetAppGateway(AppGatewayName, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            AppGatewayName name = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]");
            // Make the request
            AppGateway response = appGatewaysServiceClient.GetAppGateway(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppGatewayAsync</summary>
        public async Task GetAppGatewayResourceNamesAsync()
        {
            // Snippet: GetAppGatewayAsync(AppGatewayName, CallSettings)
            // Additional: GetAppGatewayAsync(AppGatewayName, CancellationToken)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppGatewayName name = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]");
            // Make the request
            AppGateway response = await appGatewaysServiceClient.GetAppGatewayAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAppGateway</summary>
        public void CreateAppGatewayRequestObject()
        {
            // Snippet: CreateAppGateway(CreateAppGatewayRequest, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            CreateAppGatewayRequest request = new CreateAppGatewayRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AppGatewayId = "",
                AppGateway = new AppGateway(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AppGateway, AppGatewayOperationMetadata> response = appGatewaysServiceClient.CreateAppGateway(request);

            // Poll until the returned long-running operation is complete
            Operation<AppGateway, AppGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppGateway, AppGatewayOperationMetadata> retrievedResponse = appGatewaysServiceClient.PollOnceCreateAppGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppGatewayAsync</summary>
        public async Task CreateAppGatewayRequestObjectAsync()
        {
            // Snippet: CreateAppGatewayAsync(CreateAppGatewayRequest, CallSettings)
            // Additional: CreateAppGatewayAsync(CreateAppGatewayRequest, CancellationToken)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAppGatewayRequest request = new CreateAppGatewayRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AppGatewayId = "",
                AppGateway = new AppGateway(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AppGateway, AppGatewayOperationMetadata> response = await appGatewaysServiceClient.CreateAppGatewayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AppGateway, AppGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppGateway, AppGatewayOperationMetadata> retrievedResponse = await appGatewaysServiceClient.PollOnceCreateAppGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppGateway</summary>
        public void CreateAppGateway()
        {
            // Snippet: CreateAppGateway(string, AppGateway, string, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AppGateway appGateway = new AppGateway();
            string appGatewayId = "";
            // Make the request
            Operation<AppGateway, AppGatewayOperationMetadata> response = appGatewaysServiceClient.CreateAppGateway(parent, appGateway, appGatewayId);

            // Poll until the returned long-running operation is complete
            Operation<AppGateway, AppGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppGateway, AppGatewayOperationMetadata> retrievedResponse = appGatewaysServiceClient.PollOnceCreateAppGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppGatewayAsync</summary>
        public async Task CreateAppGatewayAsync()
        {
            // Snippet: CreateAppGatewayAsync(string, AppGateway, string, CallSettings)
            // Additional: CreateAppGatewayAsync(string, AppGateway, string, CancellationToken)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AppGateway appGateway = new AppGateway();
            string appGatewayId = "";
            // Make the request
            Operation<AppGateway, AppGatewayOperationMetadata> response = await appGatewaysServiceClient.CreateAppGatewayAsync(parent, appGateway, appGatewayId);

            // Poll until the returned long-running operation is complete
            Operation<AppGateway, AppGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppGateway, AppGatewayOperationMetadata> retrievedResponse = await appGatewaysServiceClient.PollOnceCreateAppGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppGateway</summary>
        public void CreateAppGatewayResourceNames()
        {
            // Snippet: CreateAppGateway(LocationName, AppGateway, string, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AppGateway appGateway = new AppGateway();
            string appGatewayId = "";
            // Make the request
            Operation<AppGateway, AppGatewayOperationMetadata> response = appGatewaysServiceClient.CreateAppGateway(parent, appGateway, appGatewayId);

            // Poll until the returned long-running operation is complete
            Operation<AppGateway, AppGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppGateway, AppGatewayOperationMetadata> retrievedResponse = appGatewaysServiceClient.PollOnceCreateAppGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppGatewayAsync</summary>
        public async Task CreateAppGatewayResourceNamesAsync()
        {
            // Snippet: CreateAppGatewayAsync(LocationName, AppGateway, string, CallSettings)
            // Additional: CreateAppGatewayAsync(LocationName, AppGateway, string, CancellationToken)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AppGateway appGateway = new AppGateway();
            string appGatewayId = "";
            // Make the request
            Operation<AppGateway, AppGatewayOperationMetadata> response = await appGatewaysServiceClient.CreateAppGatewayAsync(parent, appGateway, appGatewayId);

            // Poll until the returned long-running operation is complete
            Operation<AppGateway, AppGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppGateway, AppGatewayOperationMetadata> retrievedResponse = await appGatewaysServiceClient.PollOnceCreateAppGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppGateway</summary>
        public void DeleteAppGatewayRequestObject()
        {
            // Snippet: DeleteAppGateway(DeleteAppGatewayRequest, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            DeleteAppGatewayRequest request = new DeleteAppGatewayRequest
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, AppGatewayOperationMetadata> response = appGatewaysServiceClient.DeleteAppGateway(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppGatewayOperationMetadata> retrievedResponse = appGatewaysServiceClient.PollOnceDeleteAppGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppGatewayAsync</summary>
        public async Task DeleteAppGatewayRequestObjectAsync()
        {
            // Snippet: DeleteAppGatewayAsync(DeleteAppGatewayRequest, CallSettings)
            // Additional: DeleteAppGatewayAsync(DeleteAppGatewayRequest, CancellationToken)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAppGatewayRequest request = new DeleteAppGatewayRequest
            {
                AppGatewayName = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, AppGatewayOperationMetadata> response = await appGatewaysServiceClient.DeleteAppGatewayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppGatewayOperationMetadata> retrievedResponse = await appGatewaysServiceClient.PollOnceDeleteAppGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppGateway</summary>
        public void DeleteAppGateway()
        {
            // Snippet: DeleteAppGateway(string, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appGateways/[APP_GATEWAY]";
            // Make the request
            Operation<Empty, AppGatewayOperationMetadata> response = appGatewaysServiceClient.DeleteAppGateway(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppGatewayOperationMetadata> retrievedResponse = appGatewaysServiceClient.PollOnceDeleteAppGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppGatewayAsync</summary>
        public async Task DeleteAppGatewayAsync()
        {
            // Snippet: DeleteAppGatewayAsync(string, CallSettings)
            // Additional: DeleteAppGatewayAsync(string, CancellationToken)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appGateways/[APP_GATEWAY]";
            // Make the request
            Operation<Empty, AppGatewayOperationMetadata> response = await appGatewaysServiceClient.DeleteAppGatewayAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppGatewayOperationMetadata> retrievedResponse = await appGatewaysServiceClient.PollOnceDeleteAppGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppGateway</summary>
        public void DeleteAppGatewayResourceNames()
        {
            // Snippet: DeleteAppGateway(AppGatewayName, CallSettings)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = AppGatewaysServiceClient.Create();
            // Initialize request argument(s)
            AppGatewayName name = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]");
            // Make the request
            Operation<Empty, AppGatewayOperationMetadata> response = appGatewaysServiceClient.DeleteAppGateway(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppGatewayOperationMetadata> retrievedResponse = appGatewaysServiceClient.PollOnceDeleteAppGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppGatewayAsync</summary>
        public async Task DeleteAppGatewayResourceNamesAsync()
        {
            // Snippet: DeleteAppGatewayAsync(AppGatewayName, CallSettings)
            // Additional: DeleteAppGatewayAsync(AppGatewayName, CancellationToken)
            // Create client
            AppGatewaysServiceClient appGatewaysServiceClient = await AppGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppGatewayName name = AppGatewayName.FromProjectLocationAppGateway("[PROJECT]", "[LOCATION]", "[APP_GATEWAY]");
            // Make the request
            Operation<Empty, AppGatewayOperationMetadata> response = await appGatewaysServiceClient.DeleteAppGatewayAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppGatewayOperationMetadata> retrievedResponse = await appGatewaysServiceClient.PollOnceDeleteAppGatewayAsync(operationName);
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
