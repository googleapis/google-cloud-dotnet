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
    using Google.Cloud.BeyondCorp.AppConnections.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAppConnectionsServiceClientSnippets
    {
        /// <summary>Snippet for ListAppConnections</summary>
        public void ListAppConnectionsRequestObject()
        {
            // Snippet: ListAppConnections(ListAppConnectionsRequest, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            ListAppConnectionsRequest request = new ListAppConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAppConnectionsResponse, AppConnection> response = appConnectionsServiceClient.ListAppConnections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppConnectionsAsync</summary>
        public async Task ListAppConnectionsRequestObjectAsync()
        {
            // Snippet: ListAppConnectionsAsync(ListAppConnectionsRequest, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAppConnectionsRequest request = new ListAppConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAppConnectionsResponse, AppConnection> response = appConnectionsServiceClient.ListAppConnectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AppConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAppConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppConnections</summary>
        public void ListAppConnections()
        {
            // Snippet: ListAppConnections(string, string, int?, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAppConnectionsResponse, AppConnection> response = appConnectionsServiceClient.ListAppConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppConnectionsAsync</summary>
        public async Task ListAppConnectionsAsync()
        {
            // Snippet: ListAppConnectionsAsync(string, string, int?, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAppConnectionsResponse, AppConnection> response = appConnectionsServiceClient.ListAppConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AppConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAppConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppConnections</summary>
        public void ListAppConnectionsResourceNames()
        {
            // Snippet: ListAppConnections(LocationName, string, int?, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAppConnectionsResponse, AppConnection> response = appConnectionsServiceClient.ListAppConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppConnectionsAsync</summary>
        public async Task ListAppConnectionsResourceNamesAsync()
        {
            // Snippet: ListAppConnectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAppConnectionsResponse, AppConnection> response = appConnectionsServiceClient.ListAppConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AppConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAppConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAppConnection</summary>
        public void GetAppConnectionRequestObject()
        {
            // Snippet: GetAppConnection(GetAppConnectionRequest, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            GetAppConnectionRequest request = new GetAppConnectionRequest
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
            };
            // Make the request
            AppConnection response = appConnectionsServiceClient.GetAppConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppConnectionAsync</summary>
        public async Task GetAppConnectionRequestObjectAsync()
        {
            // Snippet: GetAppConnectionAsync(GetAppConnectionRequest, CallSettings)
            // Additional: GetAppConnectionAsync(GetAppConnectionRequest, CancellationToken)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAppConnectionRequest request = new GetAppConnectionRequest
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
            };
            // Make the request
            AppConnection response = await appConnectionsServiceClient.GetAppConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppConnection</summary>
        public void GetAppConnection()
        {
            // Snippet: GetAppConnection(string, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appConnections/[APP_CONNECTION]";
            // Make the request
            AppConnection response = appConnectionsServiceClient.GetAppConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppConnectionAsync</summary>
        public async Task GetAppConnectionAsync()
        {
            // Snippet: GetAppConnectionAsync(string, CallSettings)
            // Additional: GetAppConnectionAsync(string, CancellationToken)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appConnections/[APP_CONNECTION]";
            // Make the request
            AppConnection response = await appConnectionsServiceClient.GetAppConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppConnection</summary>
        public void GetAppConnectionResourceNames()
        {
            // Snippet: GetAppConnection(AppConnectionName, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            AppConnectionName name = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]");
            // Make the request
            AppConnection response = appConnectionsServiceClient.GetAppConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppConnectionAsync</summary>
        public async Task GetAppConnectionResourceNamesAsync()
        {
            // Snippet: GetAppConnectionAsync(AppConnectionName, CallSettings)
            // Additional: GetAppConnectionAsync(AppConnectionName, CancellationToken)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppConnectionName name = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]");
            // Make the request
            AppConnection response = await appConnectionsServiceClient.GetAppConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnection</summary>
        public void CreateAppConnectionRequestObject()
        {
            // Snippet: CreateAppConnection(CreateAppConnectionRequest, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            CreateAppConnectionRequest request = new CreateAppConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AppConnectionId = "",
                AppConnection = new AppConnection(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AppConnection, AppConnectionOperationMetadata> response = appConnectionsServiceClient.CreateAppConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<AppConnection, AppConnectionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnection, AppConnectionOperationMetadata> retrievedResponse = appConnectionsServiceClient.PollOnceCreateAppConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnectionAsync</summary>
        public async Task CreateAppConnectionRequestObjectAsync()
        {
            // Snippet: CreateAppConnectionAsync(CreateAppConnectionRequest, CallSettings)
            // Additional: CreateAppConnectionAsync(CreateAppConnectionRequest, CancellationToken)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAppConnectionRequest request = new CreateAppConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AppConnectionId = "",
                AppConnection = new AppConnection(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AppConnection, AppConnectionOperationMetadata> response = await appConnectionsServiceClient.CreateAppConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AppConnection, AppConnectionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnection, AppConnectionOperationMetadata> retrievedResponse = await appConnectionsServiceClient.PollOnceCreateAppConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnection</summary>
        public void CreateAppConnection()
        {
            // Snippet: CreateAppConnection(string, AppConnection, string, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AppConnection appConnection = new AppConnection();
            string appConnectionId = "";
            // Make the request
            Operation<AppConnection, AppConnectionOperationMetadata> response = appConnectionsServiceClient.CreateAppConnection(parent, appConnection, appConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<AppConnection, AppConnectionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnection, AppConnectionOperationMetadata> retrievedResponse = appConnectionsServiceClient.PollOnceCreateAppConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnectionAsync</summary>
        public async Task CreateAppConnectionAsync()
        {
            // Snippet: CreateAppConnectionAsync(string, AppConnection, string, CallSettings)
            // Additional: CreateAppConnectionAsync(string, AppConnection, string, CancellationToken)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AppConnection appConnection = new AppConnection();
            string appConnectionId = "";
            // Make the request
            Operation<AppConnection, AppConnectionOperationMetadata> response = await appConnectionsServiceClient.CreateAppConnectionAsync(parent, appConnection, appConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<AppConnection, AppConnectionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnection, AppConnectionOperationMetadata> retrievedResponse = await appConnectionsServiceClient.PollOnceCreateAppConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnection</summary>
        public void CreateAppConnectionResourceNames()
        {
            // Snippet: CreateAppConnection(LocationName, AppConnection, string, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AppConnection appConnection = new AppConnection();
            string appConnectionId = "";
            // Make the request
            Operation<AppConnection, AppConnectionOperationMetadata> response = appConnectionsServiceClient.CreateAppConnection(parent, appConnection, appConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<AppConnection, AppConnectionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnection, AppConnectionOperationMetadata> retrievedResponse = appConnectionsServiceClient.PollOnceCreateAppConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnectionAsync</summary>
        public async Task CreateAppConnectionResourceNamesAsync()
        {
            // Snippet: CreateAppConnectionAsync(LocationName, AppConnection, string, CallSettings)
            // Additional: CreateAppConnectionAsync(LocationName, AppConnection, string, CancellationToken)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AppConnection appConnection = new AppConnection();
            string appConnectionId = "";
            // Make the request
            Operation<AppConnection, AppConnectionOperationMetadata> response = await appConnectionsServiceClient.CreateAppConnectionAsync(parent, appConnection, appConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<AppConnection, AppConnectionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnection, AppConnectionOperationMetadata> retrievedResponse = await appConnectionsServiceClient.PollOnceCreateAppConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppConnection</summary>
        public void UpdateAppConnectionRequestObject()
        {
            // Snippet: UpdateAppConnection(UpdateAppConnectionRequest, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            UpdateAppConnectionRequest request = new UpdateAppConnectionRequest
            {
                UpdateMask = new FieldMask(),
                AppConnection = new AppConnection(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<AppConnection, AppConnectionOperationMetadata> response = appConnectionsServiceClient.UpdateAppConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<AppConnection, AppConnectionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnection, AppConnectionOperationMetadata> retrievedResponse = appConnectionsServiceClient.PollOnceUpdateAppConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppConnectionAsync</summary>
        public async Task UpdateAppConnectionRequestObjectAsync()
        {
            // Snippet: UpdateAppConnectionAsync(UpdateAppConnectionRequest, CallSettings)
            // Additional: UpdateAppConnectionAsync(UpdateAppConnectionRequest, CancellationToken)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAppConnectionRequest request = new UpdateAppConnectionRequest
            {
                UpdateMask = new FieldMask(),
                AppConnection = new AppConnection(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<AppConnection, AppConnectionOperationMetadata> response = await appConnectionsServiceClient.UpdateAppConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AppConnection, AppConnectionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnection, AppConnectionOperationMetadata> retrievedResponse = await appConnectionsServiceClient.PollOnceUpdateAppConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppConnection</summary>
        public void UpdateAppConnection()
        {
            // Snippet: UpdateAppConnection(AppConnection, FieldMask, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            AppConnection appConnection = new AppConnection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AppConnection, AppConnectionOperationMetadata> response = appConnectionsServiceClient.UpdateAppConnection(appConnection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AppConnection, AppConnectionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnection, AppConnectionOperationMetadata> retrievedResponse = appConnectionsServiceClient.PollOnceUpdateAppConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppConnectionAsync</summary>
        public async Task UpdateAppConnectionAsync()
        {
            // Snippet: UpdateAppConnectionAsync(AppConnection, FieldMask, CallSettings)
            // Additional: UpdateAppConnectionAsync(AppConnection, FieldMask, CancellationToken)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppConnection appConnection = new AppConnection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AppConnection, AppConnectionOperationMetadata> response = await appConnectionsServiceClient.UpdateAppConnectionAsync(appConnection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AppConnection, AppConnectionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnection, AppConnectionOperationMetadata> retrievedResponse = await appConnectionsServiceClient.PollOnceUpdateAppConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnection</summary>
        public void DeleteAppConnectionRequestObject()
        {
            // Snippet: DeleteAppConnection(DeleteAppConnectionRequest, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            DeleteAppConnectionRequest request = new DeleteAppConnectionRequest
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, AppConnectionOperationMetadata> response = appConnectionsServiceClient.DeleteAppConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectionOperationMetadata> retrievedResponse = appConnectionsServiceClient.PollOnceDeleteAppConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnectionAsync</summary>
        public async Task DeleteAppConnectionRequestObjectAsync()
        {
            // Snippet: DeleteAppConnectionAsync(DeleteAppConnectionRequest, CallSettings)
            // Additional: DeleteAppConnectionAsync(DeleteAppConnectionRequest, CancellationToken)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAppConnectionRequest request = new DeleteAppConnectionRequest
            {
                AppConnectionName = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, AppConnectionOperationMetadata> response = await appConnectionsServiceClient.DeleteAppConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectionOperationMetadata> retrievedResponse = await appConnectionsServiceClient.PollOnceDeleteAppConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnection</summary>
        public void DeleteAppConnection()
        {
            // Snippet: DeleteAppConnection(string, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appConnections/[APP_CONNECTION]";
            // Make the request
            Operation<Empty, AppConnectionOperationMetadata> response = appConnectionsServiceClient.DeleteAppConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectionOperationMetadata> retrievedResponse = appConnectionsServiceClient.PollOnceDeleteAppConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnectionAsync</summary>
        public async Task DeleteAppConnectionAsync()
        {
            // Snippet: DeleteAppConnectionAsync(string, CallSettings)
            // Additional: DeleteAppConnectionAsync(string, CancellationToken)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appConnections/[APP_CONNECTION]";
            // Make the request
            Operation<Empty, AppConnectionOperationMetadata> response = await appConnectionsServiceClient.DeleteAppConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectionOperationMetadata> retrievedResponse = await appConnectionsServiceClient.PollOnceDeleteAppConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnection</summary>
        public void DeleteAppConnectionResourceNames()
        {
            // Snippet: DeleteAppConnection(AppConnectionName, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            AppConnectionName name = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]");
            // Make the request
            Operation<Empty, AppConnectionOperationMetadata> response = appConnectionsServiceClient.DeleteAppConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectionOperationMetadata> retrievedResponse = appConnectionsServiceClient.PollOnceDeleteAppConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnectionAsync</summary>
        public async Task DeleteAppConnectionResourceNamesAsync()
        {
            // Snippet: DeleteAppConnectionAsync(AppConnectionName, CallSettings)
            // Additional: DeleteAppConnectionAsync(AppConnectionName, CancellationToken)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppConnectionName name = AppConnectionName.FromProjectLocationAppConnection("[PROJECT]", "[LOCATION]", "[APP_CONNECTION]");
            // Make the request
            Operation<Empty, AppConnectionOperationMetadata> response = await appConnectionsServiceClient.DeleteAppConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectionOperationMetadata> retrievedResponse = await appConnectionsServiceClient.PollOnceDeleteAppConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResolveAppConnections</summary>
        public void ResolveAppConnectionsRequestObject()
        {
            // Snippet: ResolveAppConnections(ResolveAppConnectionsRequest, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            ResolveAppConnectionsRequest request = new ResolveAppConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AppConnectorIdAsAppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
            };
            // Make the request
            PagedEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> response = appConnectionsServiceClient.ResolveAppConnections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ResolveAppConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResolveAppConnectionsResponse.Types.AppConnectionDetails> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ResolveAppConnectionsAsync</summary>
        public async Task ResolveAppConnectionsRequestObjectAsync()
        {
            // Snippet: ResolveAppConnectionsAsync(ResolveAppConnectionsRequest, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResolveAppConnectionsRequest request = new ResolveAppConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AppConnectorIdAsAppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
            };
            // Make the request
            PagedAsyncEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> response = appConnectionsServiceClient.ResolveAppConnectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResolveAppConnectionsResponse.Types.AppConnectionDetails item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ResolveAppConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResolveAppConnectionsResponse.Types.AppConnectionDetails> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ResolveAppConnections</summary>
        public void ResolveAppConnections()
        {
            // Snippet: ResolveAppConnections(string, string, int?, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> response = appConnectionsServiceClient.ResolveAppConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ResolveAppConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResolveAppConnectionsResponse.Types.AppConnectionDetails> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ResolveAppConnectionsAsync</summary>
        public async Task ResolveAppConnectionsAsync()
        {
            // Snippet: ResolveAppConnectionsAsync(string, string, int?, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> response = appConnectionsServiceClient.ResolveAppConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResolveAppConnectionsResponse.Types.AppConnectionDetails item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ResolveAppConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResolveAppConnectionsResponse.Types.AppConnectionDetails> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ResolveAppConnections</summary>
        public void ResolveAppConnectionsResourceNames()
        {
            // Snippet: ResolveAppConnections(LocationName, string, int?, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = AppConnectionsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> response = appConnectionsServiceClient.ResolveAppConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ResolveAppConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResolveAppConnectionsResponse.Types.AppConnectionDetails> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ResolveAppConnectionsAsync</summary>
        public async Task ResolveAppConnectionsResourceNamesAsync()
        {
            // Snippet: ResolveAppConnectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppConnectionsServiceClient appConnectionsServiceClient = await AppConnectionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> response = appConnectionsServiceClient.ResolveAppConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResolveAppConnectionsResponse.Types.AppConnectionDetails item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ResolveAppConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResolveAppConnectionsResponse.Types.AppConnectionDetails> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResolveAppConnectionsResponse.Types.AppConnectionDetails item in singlePage)
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
