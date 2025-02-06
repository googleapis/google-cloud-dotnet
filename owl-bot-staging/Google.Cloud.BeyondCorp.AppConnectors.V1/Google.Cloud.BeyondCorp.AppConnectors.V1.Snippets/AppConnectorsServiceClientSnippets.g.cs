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
    using Google.Cloud.BeyondCorp.AppConnectors.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAppConnectorsServiceClientSnippets
    {
        /// <summary>Snippet for ListAppConnectors</summary>
        public void ListAppConnectorsRequestObject()
        {
            // Snippet: ListAppConnectors(ListAppConnectorsRequest, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            ListAppConnectorsRequest request = new ListAppConnectorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAppConnectorsResponse, AppConnector> response = appConnectorsServiceClient.ListAppConnectors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppConnectorsAsync</summary>
        public async Task ListAppConnectorsRequestObjectAsync()
        {
            // Snippet: ListAppConnectorsAsync(ListAppConnectorsRequest, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAppConnectorsRequest request = new ListAppConnectorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAppConnectorsResponse, AppConnector> response = appConnectorsServiceClient.ListAppConnectorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AppConnector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAppConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppConnectors</summary>
        public void ListAppConnectors()
        {
            // Snippet: ListAppConnectors(string, string, int?, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAppConnectorsResponse, AppConnector> response = appConnectorsServiceClient.ListAppConnectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppConnectorsAsync</summary>
        public async Task ListAppConnectorsAsync()
        {
            // Snippet: ListAppConnectorsAsync(string, string, int?, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAppConnectorsResponse, AppConnector> response = appConnectorsServiceClient.ListAppConnectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AppConnector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAppConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppConnectors</summary>
        public void ListAppConnectorsResourceNames()
        {
            // Snippet: ListAppConnectors(LocationName, string, int?, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAppConnectorsResponse, AppConnector> response = appConnectorsServiceClient.ListAppConnectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppConnectorsAsync</summary>
        public async Task ListAppConnectorsResourceNamesAsync()
        {
            // Snippet: ListAppConnectorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAppConnectorsResponse, AppConnector> response = appConnectorsServiceClient.ListAppConnectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AppConnector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAppConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppConnector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAppConnector</summary>
        public void GetAppConnectorRequestObject()
        {
            // Snippet: GetAppConnector(GetAppConnectorRequest, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            GetAppConnectorRequest request = new GetAppConnectorRequest
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
            };
            // Make the request
            AppConnector response = appConnectorsServiceClient.GetAppConnector(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppConnectorAsync</summary>
        public async Task GetAppConnectorRequestObjectAsync()
        {
            // Snippet: GetAppConnectorAsync(GetAppConnectorRequest, CallSettings)
            // Additional: GetAppConnectorAsync(GetAppConnectorRequest, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAppConnectorRequest request = new GetAppConnectorRequest
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
            };
            // Make the request
            AppConnector response = await appConnectorsServiceClient.GetAppConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppConnector</summary>
        public void GetAppConnector()
        {
            // Snippet: GetAppConnector(string, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appConnectors/[APP_CONNECTOR]";
            // Make the request
            AppConnector response = appConnectorsServiceClient.GetAppConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppConnectorAsync</summary>
        public async Task GetAppConnectorAsync()
        {
            // Snippet: GetAppConnectorAsync(string, CallSettings)
            // Additional: GetAppConnectorAsync(string, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appConnectors/[APP_CONNECTOR]";
            // Make the request
            AppConnector response = await appConnectorsServiceClient.GetAppConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppConnector</summary>
        public void GetAppConnectorResourceNames()
        {
            // Snippet: GetAppConnector(AppConnectorName, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            AppConnectorName name = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]");
            // Make the request
            AppConnector response = appConnectorsServiceClient.GetAppConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppConnectorAsync</summary>
        public async Task GetAppConnectorResourceNamesAsync()
        {
            // Snippet: GetAppConnectorAsync(AppConnectorName, CallSettings)
            // Additional: GetAppConnectorAsync(AppConnectorName, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppConnectorName name = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]");
            // Make the request
            AppConnector response = await appConnectorsServiceClient.GetAppConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnector</summary>
        public void CreateAppConnectorRequestObject()
        {
            // Snippet: CreateAppConnector(CreateAppConnectorRequest, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            CreateAppConnectorRequest request = new CreateAppConnectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AppConnectorId = "",
                AppConnector = new AppConnector(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = appConnectorsServiceClient.CreateAppConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceCreateAppConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnectorAsync</summary>
        public async Task CreateAppConnectorRequestObjectAsync()
        {
            // Snippet: CreateAppConnectorAsync(CreateAppConnectorRequest, CallSettings)
            // Additional: CreateAppConnectorAsync(CreateAppConnectorRequest, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAppConnectorRequest request = new CreateAppConnectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AppConnectorId = "",
                AppConnector = new AppConnector(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = await appConnectorsServiceClient.CreateAppConnectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = await appConnectorsServiceClient.PollOnceCreateAppConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnector</summary>
        public void CreateAppConnector()
        {
            // Snippet: CreateAppConnector(string, AppConnector, string, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AppConnector appConnector = new AppConnector();
            string appConnectorId = "";
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = appConnectorsServiceClient.CreateAppConnector(parent, appConnector, appConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceCreateAppConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnectorAsync</summary>
        public async Task CreateAppConnectorAsync()
        {
            // Snippet: CreateAppConnectorAsync(string, AppConnector, string, CallSettings)
            // Additional: CreateAppConnectorAsync(string, AppConnector, string, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AppConnector appConnector = new AppConnector();
            string appConnectorId = "";
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = await appConnectorsServiceClient.CreateAppConnectorAsync(parent, appConnector, appConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = await appConnectorsServiceClient.PollOnceCreateAppConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnector</summary>
        public void CreateAppConnectorResourceNames()
        {
            // Snippet: CreateAppConnector(LocationName, AppConnector, string, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AppConnector appConnector = new AppConnector();
            string appConnectorId = "";
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = appConnectorsServiceClient.CreateAppConnector(parent, appConnector, appConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceCreateAppConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppConnectorAsync</summary>
        public async Task CreateAppConnectorResourceNamesAsync()
        {
            // Snippet: CreateAppConnectorAsync(LocationName, AppConnector, string, CallSettings)
            // Additional: CreateAppConnectorAsync(LocationName, AppConnector, string, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AppConnector appConnector = new AppConnector();
            string appConnectorId = "";
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = await appConnectorsServiceClient.CreateAppConnectorAsync(parent, appConnector, appConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = await appConnectorsServiceClient.PollOnceCreateAppConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppConnector</summary>
        public void UpdateAppConnectorRequestObject()
        {
            // Snippet: UpdateAppConnector(UpdateAppConnectorRequest, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            UpdateAppConnectorRequest request = new UpdateAppConnectorRequest
            {
                UpdateMask = new FieldMask(),
                AppConnector = new AppConnector(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = appConnectorsServiceClient.UpdateAppConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceUpdateAppConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppConnectorAsync</summary>
        public async Task UpdateAppConnectorRequestObjectAsync()
        {
            // Snippet: UpdateAppConnectorAsync(UpdateAppConnectorRequest, CallSettings)
            // Additional: UpdateAppConnectorAsync(UpdateAppConnectorRequest, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAppConnectorRequest request = new UpdateAppConnectorRequest
            {
                UpdateMask = new FieldMask(),
                AppConnector = new AppConnector(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = await appConnectorsServiceClient.UpdateAppConnectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = await appConnectorsServiceClient.PollOnceUpdateAppConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppConnector</summary>
        public void UpdateAppConnector()
        {
            // Snippet: UpdateAppConnector(AppConnector, FieldMask, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            AppConnector appConnector = new AppConnector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = appConnectorsServiceClient.UpdateAppConnector(appConnector, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceUpdateAppConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppConnectorAsync</summary>
        public async Task UpdateAppConnectorAsync()
        {
            // Snippet: UpdateAppConnectorAsync(AppConnector, FieldMask, CallSettings)
            // Additional: UpdateAppConnectorAsync(AppConnector, FieldMask, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppConnector appConnector = new AppConnector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = await appConnectorsServiceClient.UpdateAppConnectorAsync(appConnector, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = await appConnectorsServiceClient.PollOnceUpdateAppConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnector</summary>
        public void DeleteAppConnectorRequestObject()
        {
            // Snippet: DeleteAppConnector(DeleteAppConnectorRequest, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            DeleteAppConnectorRequest request = new DeleteAppConnectorRequest
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, AppConnectorOperationMetadata> response = appConnectorsServiceClient.DeleteAppConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceDeleteAppConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnectorAsync</summary>
        public async Task DeleteAppConnectorRequestObjectAsync()
        {
            // Snippet: DeleteAppConnectorAsync(DeleteAppConnectorRequest, CallSettings)
            // Additional: DeleteAppConnectorAsync(DeleteAppConnectorRequest, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAppConnectorRequest request = new DeleteAppConnectorRequest
            {
                AppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, AppConnectorOperationMetadata> response = await appConnectorsServiceClient.DeleteAppConnectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectorOperationMetadata> retrievedResponse = await appConnectorsServiceClient.PollOnceDeleteAppConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnector</summary>
        public void DeleteAppConnector()
        {
            // Snippet: DeleteAppConnector(string, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appConnectors/[APP_CONNECTOR]";
            // Make the request
            Operation<Empty, AppConnectorOperationMetadata> response = appConnectorsServiceClient.DeleteAppConnector(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceDeleteAppConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnectorAsync</summary>
        public async Task DeleteAppConnectorAsync()
        {
            // Snippet: DeleteAppConnectorAsync(string, CallSettings)
            // Additional: DeleteAppConnectorAsync(string, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/appConnectors/[APP_CONNECTOR]";
            // Make the request
            Operation<Empty, AppConnectorOperationMetadata> response = await appConnectorsServiceClient.DeleteAppConnectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectorOperationMetadata> retrievedResponse = await appConnectorsServiceClient.PollOnceDeleteAppConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnector</summary>
        public void DeleteAppConnectorResourceNames()
        {
            // Snippet: DeleteAppConnector(AppConnectorName, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            AppConnectorName name = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]");
            // Make the request
            Operation<Empty, AppConnectorOperationMetadata> response = appConnectorsServiceClient.DeleteAppConnector(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceDeleteAppConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppConnectorAsync</summary>
        public async Task DeleteAppConnectorResourceNamesAsync()
        {
            // Snippet: DeleteAppConnectorAsync(AppConnectorName, CallSettings)
            // Additional: DeleteAppConnectorAsync(AppConnectorName, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppConnectorName name = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]");
            // Make the request
            Operation<Empty, AppConnectorOperationMetadata> response = await appConnectorsServiceClient.DeleteAppConnectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, AppConnectorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, AppConnectorOperationMetadata> retrievedResponse = await appConnectorsServiceClient.PollOnceDeleteAppConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportStatus</summary>
        public void ReportStatusRequestObject()
        {
            // Snippet: ReportStatus(ReportStatusRequest, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            ReportStatusRequest request = new ReportStatusRequest
            {
                AppConnectorAsAppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
                ResourceInfo = new ResourceInfo(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = appConnectorsServiceClient.ReportStatus(request);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceReportStatus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportStatusAsync</summary>
        public async Task ReportStatusRequestObjectAsync()
        {
            // Snippet: ReportStatusAsync(ReportStatusRequest, CallSettings)
            // Additional: ReportStatusAsync(ReportStatusRequest, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportStatusRequest request = new ReportStatusRequest
            {
                AppConnectorAsAppConnectorName = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]"),
                ResourceInfo = new ResourceInfo(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = await appConnectorsServiceClient.ReportStatusAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = await appConnectorsServiceClient.PollOnceReportStatusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportStatus</summary>
        public void ReportStatus()
        {
            // Snippet: ReportStatus(string, ResourceInfo, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            string appConnector = "projects/[PROJECT]/locations/[LOCATION]/appConnectors/[APP_CONNECTOR]";
            ResourceInfo resourceInfo = new ResourceInfo();
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = appConnectorsServiceClient.ReportStatus(appConnector, resourceInfo);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceReportStatus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportStatusAsync</summary>
        public async Task ReportStatusAsync()
        {
            // Snippet: ReportStatusAsync(string, ResourceInfo, CallSettings)
            // Additional: ReportStatusAsync(string, ResourceInfo, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string appConnector = "projects/[PROJECT]/locations/[LOCATION]/appConnectors/[APP_CONNECTOR]";
            ResourceInfo resourceInfo = new ResourceInfo();
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = await appConnectorsServiceClient.ReportStatusAsync(appConnector, resourceInfo);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = await appConnectorsServiceClient.PollOnceReportStatusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportStatus</summary>
        public void ReportStatusResourceNames()
        {
            // Snippet: ReportStatus(AppConnectorName, ResourceInfo, CallSettings)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            AppConnectorName appConnector = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]");
            ResourceInfo resourceInfo = new ResourceInfo();
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = appConnectorsServiceClient.ReportStatus(appConnector, resourceInfo);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceReportStatus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportStatusAsync</summary>
        public async Task ReportStatusResourceNamesAsync()
        {
            // Snippet: ReportStatusAsync(AppConnectorName, ResourceInfo, CallSettings)
            // Additional: ReportStatusAsync(AppConnectorName, ResourceInfo, CancellationToken)
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = await AppConnectorsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppConnectorName appConnector = AppConnectorName.FromProjectLocationAppConnector("[PROJECT]", "[LOCATION]", "[APP_CONNECTOR]");
            ResourceInfo resourceInfo = new ResourceInfo();
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = await appConnectorsServiceClient.ReportStatusAsync(appConnector, resourceInfo);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = await appConnectorsServiceClient.PollOnceReportStatusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
