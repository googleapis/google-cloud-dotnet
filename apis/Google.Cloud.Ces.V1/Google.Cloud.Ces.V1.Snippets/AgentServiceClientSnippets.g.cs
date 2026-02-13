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
    using Google.Cloud.Ces.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAgentServiceClientSnippets
    {
        /// <summary>Snippet for ListApps</summary>
        public void ListAppsRequestObject()
        {
            // Snippet: ListApps(ListAppsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ListAppsRequest request = new ListAppsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAppsResponse, App> response = agentServiceClient.ListApps(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (App item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (App item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<App> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (App item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppsAsync</summary>
        public async Task ListAppsRequestObjectAsync()
        {
            // Snippet: ListAppsAsync(ListAppsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAppsRequest request = new ListAppsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAppsResponse, App> response = agentServiceClient.ListAppsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (App item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAppsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (App item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<App> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (App item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApps</summary>
        public void ListApps()
        {
            // Snippet: ListApps(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAppsResponse, App> response = agentServiceClient.ListApps(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (App item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (App item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<App> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (App item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppsAsync</summary>
        public async Task ListAppsAsync()
        {
            // Snippet: ListAppsAsync(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAppsResponse, App> response = agentServiceClient.ListAppsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (App item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAppsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (App item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<App> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (App item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApps</summary>
        public void ListAppsResourceNames()
        {
            // Snippet: ListApps(LocationName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAppsResponse, App> response = agentServiceClient.ListApps(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (App item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (App item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<App> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (App item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppsAsync</summary>
        public async Task ListAppsResourceNamesAsync()
        {
            // Snippet: ListAppsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAppsResponse, App> response = agentServiceClient.ListAppsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (App item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAppsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (App item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<App> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (App item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetApp</summary>
        public void GetAppRequestObject()
        {
            // Snippet: GetApp(GetAppRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GetAppRequest request = new GetAppRequest
            {
                AppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
            };
            // Make the request
            App response = agentServiceClient.GetApp(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppAsync</summary>
        public async Task GetAppRequestObjectAsync()
        {
            // Snippet: GetAppAsync(GetAppRequest, CallSettings)
            // Additional: GetAppAsync(GetAppRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAppRequest request = new GetAppRequest
            {
                AppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
            };
            // Make the request
            App response = await agentServiceClient.GetAppAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApp</summary>
        public void GetApp()
        {
            // Snippet: GetApp(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            App response = agentServiceClient.GetApp(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppAsync</summary>
        public async Task GetAppAsync()
        {
            // Snippet: GetAppAsync(string, CallSettings)
            // Additional: GetAppAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            App response = await agentServiceClient.GetAppAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApp</summary>
        public void GetAppResourceNames()
        {
            // Snippet: GetApp(AppName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName name = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            App response = agentServiceClient.GetApp(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppAsync</summary>
        public async Task GetAppResourceNamesAsync()
        {
            // Snippet: GetAppAsync(AppName, CallSettings)
            // Additional: GetAppAsync(AppName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName name = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            App response = await agentServiceClient.GetAppAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateApp</summary>
        public void CreateAppRequestObject()
        {
            // Snippet: CreateApp(CreateAppRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            CreateAppRequest request = new CreateAppRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AppId = "",
                App = new App(),
            };
            // Make the request
            Operation<App, OperationMetadata> response = agentServiceClient.CreateApp(request);

            // Poll until the returned long-running operation is complete
            Operation<App, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            App result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<App, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceCreateApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                App retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppAsync</summary>
        public async Task CreateAppRequestObjectAsync()
        {
            // Snippet: CreateAppAsync(CreateAppRequest, CallSettings)
            // Additional: CreateAppAsync(CreateAppRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAppRequest request = new CreateAppRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AppId = "",
                App = new App(),
            };
            // Make the request
            Operation<App, OperationMetadata> response = await agentServiceClient.CreateAppAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<App, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            App result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<App, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceCreateAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                App retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApp</summary>
        public void CreateApp1()
        {
            // Snippet: CreateApp(string, App, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            App app = new App();
            string appId = "";
            // Make the request
            Operation<App, OperationMetadata> response = agentServiceClient.CreateApp(parent, app, appId);

            // Poll until the returned long-running operation is complete
            Operation<App, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            App result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<App, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceCreateApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                App retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppAsync</summary>
        public async Task CreateApp1Async()
        {
            // Snippet: CreateAppAsync(string, App, string, CallSettings)
            // Additional: CreateAppAsync(string, App, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            App app = new App();
            string appId = "";
            // Make the request
            Operation<App, OperationMetadata> response = await agentServiceClient.CreateAppAsync(parent, app, appId);

            // Poll until the returned long-running operation is complete
            Operation<App, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            App result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<App, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceCreateAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                App retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApp</summary>
        public void CreateApp1ResourceNames()
        {
            // Snippet: CreateApp(LocationName, App, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            App app = new App();
            string appId = "";
            // Make the request
            Operation<App, OperationMetadata> response = agentServiceClient.CreateApp(parent, app, appId);

            // Poll until the returned long-running operation is complete
            Operation<App, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            App result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<App, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceCreateApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                App retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppAsync</summary>
        public async Task CreateApp1ResourceNamesAsync()
        {
            // Snippet: CreateAppAsync(LocationName, App, string, CallSettings)
            // Additional: CreateAppAsync(LocationName, App, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            App app = new App();
            string appId = "";
            // Make the request
            Operation<App, OperationMetadata> response = await agentServiceClient.CreateAppAsync(parent, app, appId);

            // Poll until the returned long-running operation is complete
            Operation<App, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            App result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<App, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceCreateAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                App retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApp</summary>
        public void CreateApp2()
        {
            // Snippet: CreateApp(string, App, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            App app = new App();
            // Make the request
            Operation<App, OperationMetadata> response = agentServiceClient.CreateApp(parent, app);

            // Poll until the returned long-running operation is complete
            Operation<App, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            App result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<App, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceCreateApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                App retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppAsync</summary>
        public async Task CreateApp2Async()
        {
            // Snippet: CreateAppAsync(string, App, CallSettings)
            // Additional: CreateAppAsync(string, App, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            App app = new App();
            // Make the request
            Operation<App, OperationMetadata> response = await agentServiceClient.CreateAppAsync(parent, app);

            // Poll until the returned long-running operation is complete
            Operation<App, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            App result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<App, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceCreateAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                App retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApp</summary>
        public void CreateApp2ResourceNames()
        {
            // Snippet: CreateApp(LocationName, App, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            App app = new App();
            // Make the request
            Operation<App, OperationMetadata> response = agentServiceClient.CreateApp(parent, app);

            // Poll until the returned long-running operation is complete
            Operation<App, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            App result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<App, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceCreateApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                App retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAppAsync</summary>
        public async Task CreateApp2ResourceNamesAsync()
        {
            // Snippet: CreateAppAsync(LocationName, App, CallSettings)
            // Additional: CreateAppAsync(LocationName, App, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            App app = new App();
            // Make the request
            Operation<App, OperationMetadata> response = await agentServiceClient.CreateAppAsync(parent, app);

            // Poll until the returned long-running operation is complete
            Operation<App, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            App result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<App, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceCreateAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                App retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApp</summary>
        public void UpdateAppRequestObject()
        {
            // Snippet: UpdateApp(UpdateAppRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            UpdateAppRequest request = new UpdateAppRequest
            {
                App = new App(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            App response = agentServiceClient.UpdateApp(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAppAsync</summary>
        public async Task UpdateAppRequestObjectAsync()
        {
            // Snippet: UpdateAppAsync(UpdateAppRequest, CallSettings)
            // Additional: UpdateAppAsync(UpdateAppRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAppRequest request = new UpdateAppRequest
            {
                App = new App(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            App response = await agentServiceClient.UpdateAppAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApp</summary>
        public void UpdateApp()
        {
            // Snippet: UpdateApp(App, FieldMask, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            App app = new App();
            FieldMask updateMask = new FieldMask();
            // Make the request
            App response = agentServiceClient.UpdateApp(app, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAppAsync</summary>
        public async Task UpdateAppAsync()
        {
            // Snippet: UpdateAppAsync(App, FieldMask, CallSettings)
            // Additional: UpdateAppAsync(App, FieldMask, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            App app = new App();
            FieldMask updateMask = new FieldMask();
            // Make the request
            App response = await agentServiceClient.UpdateAppAsync(app, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteApp</summary>
        public void DeleteAppRequestObject()
        {
            // Snippet: DeleteApp(DeleteAppRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            DeleteAppRequest request = new DeleteAppRequest
            {
                AppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = agentServiceClient.DeleteApp(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceDeleteApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppAsync</summary>
        public async Task DeleteAppRequestObjectAsync()
        {
            // Snippet: DeleteAppAsync(DeleteAppRequest, CallSettings)
            // Additional: DeleteAppAsync(DeleteAppRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAppRequest request = new DeleteAppRequest
            {
                AppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentServiceClient.DeleteAppAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceDeleteAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApp</summary>
        public void DeleteApp()
        {
            // Snippet: DeleteApp(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = agentServiceClient.DeleteApp(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceDeleteApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppAsync</summary>
        public async Task DeleteAppAsync()
        {
            // Snippet: DeleteAppAsync(string, CallSettings)
            // Additional: DeleteAppAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentServiceClient.DeleteAppAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceDeleteAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApp</summary>
        public void DeleteAppResourceNames()
        {
            // Snippet: DeleteApp(AppName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName name = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = agentServiceClient.DeleteApp(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceDeleteApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppAsync</summary>
        public async Task DeleteAppResourceNamesAsync()
        {
            // Snippet: DeleteAppAsync(AppName, CallSettings)
            // Additional: DeleteAppAsync(AppName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName name = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await agentServiceClient.DeleteAppAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceDeleteAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApp</summary>
        public void ExportAppRequestObject()
        {
            // Snippet: ExportApp(ExportAppRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ExportAppRequest request = new ExportAppRequest
            {
                AppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ExportFormat = ExportAppRequest.Types.ExportFormat.Unspecified,
                GcsUri = "",
            };
            // Make the request
            Operation<ExportAppResponse, OperationMetadata> response = agentServiceClient.ExportApp(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAppResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAppResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceExportApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAppAsync</summary>
        public async Task ExportAppRequestObjectAsync()
        {
            // Snippet: ExportAppAsync(ExportAppRequest, CallSettings)
            // Additional: ExportAppAsync(ExportAppRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportAppRequest request = new ExportAppRequest
            {
                AppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ExportFormat = ExportAppRequest.Types.ExportFormat.Unspecified,
                GcsUri = "",
            };
            // Make the request
            Operation<ExportAppResponse, OperationMetadata> response = await agentServiceClient.ExportAppAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAppResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAppResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceExportAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApp</summary>
        public void ExportApp()
        {
            // Snippet: ExportApp(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            Operation<ExportAppResponse, OperationMetadata> response = agentServiceClient.ExportApp(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportAppResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAppResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceExportApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAppAsync</summary>
        public async Task ExportAppAsync()
        {
            // Snippet: ExportAppAsync(string, CallSettings)
            // Additional: ExportAppAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            Operation<ExportAppResponse, OperationMetadata> response = await agentServiceClient.ExportAppAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportAppResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAppResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceExportAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportApp</summary>
        public void ExportAppResourceNames()
        {
            // Snippet: ExportApp(AppName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName name = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            Operation<ExportAppResponse, OperationMetadata> response = agentServiceClient.ExportApp(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportAppResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAppResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceExportApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAppAsync</summary>
        public async Task ExportAppResourceNamesAsync()
        {
            // Snippet: ExportAppAsync(AppName, CallSettings)
            // Additional: ExportAppAsync(AppName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName name = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            Operation<ExportAppResponse, OperationMetadata> response = await agentServiceClient.ExportAppAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportAppResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAppResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceExportAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportApp</summary>
        public void ImportAppRequestObject()
        {
            // Snippet: ImportApp(ImportAppRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ImportAppRequest request = new ImportAppRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DisplayName = "",
                AppId = "",
                GcsUri = "",
                ImportOptions = new ImportAppRequest.Types.ImportOptions(),
                IgnoreAppLock = false,
            };
            // Make the request
            Operation<ImportAppResponse, OperationMetadata> response = agentServiceClient.ImportApp(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportAppResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportAppResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceImportApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAppAsync</summary>
        public async Task ImportAppRequestObjectAsync()
        {
            // Snippet: ImportAppAsync(ImportAppRequest, CallSettings)
            // Additional: ImportAppAsync(ImportAppRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportAppRequest request = new ImportAppRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DisplayName = "",
                AppId = "",
                GcsUri = "",
                ImportOptions = new ImportAppRequest.Types.ImportOptions(),
                IgnoreAppLock = false,
            };
            // Make the request
            Operation<ImportAppResponse, OperationMetadata> response = await agentServiceClient.ImportAppAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportAppResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportAppResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceImportAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportApp</summary>
        public void ImportApp()
        {
            // Snippet: ImportApp(string, string, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string displayName = "";
            string appId = "";
            // Make the request
            Operation<ImportAppResponse, OperationMetadata> response = agentServiceClient.ImportApp(parent, displayName, appId);

            // Poll until the returned long-running operation is complete
            Operation<ImportAppResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportAppResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceImportApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAppAsync</summary>
        public async Task ImportAppAsync()
        {
            // Snippet: ImportAppAsync(string, string, string, CallSettings)
            // Additional: ImportAppAsync(string, string, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string displayName = "";
            string appId = "";
            // Make the request
            Operation<ImportAppResponse, OperationMetadata> response = await agentServiceClient.ImportAppAsync(parent, displayName, appId);

            // Poll until the returned long-running operation is complete
            Operation<ImportAppResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportAppResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceImportAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportApp</summary>
        public void ImportAppResourceNames()
        {
            // Snippet: ImportApp(LocationName, string, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string displayName = "";
            string appId = "";
            // Make the request
            Operation<ImportAppResponse, OperationMetadata> response = agentServiceClient.ImportApp(parent, displayName, appId);

            // Poll until the returned long-running operation is complete
            Operation<ImportAppResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportAppResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceImportApp(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAppAsync</summary>
        public async Task ImportAppResourceNamesAsync()
        {
            // Snippet: ImportAppAsync(LocationName, string, string, CallSettings)
            // Additional: ImportAppAsync(LocationName, string, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string displayName = "";
            string appId = "";
            // Make the request
            Operation<ImportAppResponse, OperationMetadata> response = await agentServiceClient.ImportAppAsync(parent, displayName, appId);

            // Poll until the returned long-running operation is complete
            Operation<ImportAppResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportAppResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportAppResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceImportAppAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportAppResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAgents</summary>
        public void ListAgentsRequestObject()
        {
            // Snippet: ListAgents(ListAgentsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ListAgentsRequest request = new ListAgentsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAgentsResponse, Agent> response = agentServiceClient.ListAgents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentsAsync</summary>
        public async Task ListAgentsRequestObjectAsync()
        {
            // Snippet: ListAgentsAsync(ListAgentsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAgentsRequest request = new ListAgentsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAgentsResponse, Agent> response = agentServiceClient.ListAgentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgents</summary>
        public void ListAgents()
        {
            // Snippet: ListAgents(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListAgentsResponse, Agent> response = agentServiceClient.ListAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentsAsync</summary>
        public async Task ListAgentsAsync()
        {
            // Snippet: ListAgentsAsync(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListAgentsResponse, Agent> response = agentServiceClient.ListAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgents</summary>
        public void ListAgentsResourceNames()
        {
            // Snippet: ListAgents(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListAgentsResponse, Agent> response = agentServiceClient.ListAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentsAsync</summary>
        public async Task ListAgentsResourceNamesAsync()
        {
            // Snippet: ListAgentsAsync(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListAgentsResponse, Agent> response = agentServiceClient.ListAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Agent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Agent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Agent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Agent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAgent</summary>
        public void GetAgentRequestObject()
        {
            // Snippet: GetAgent(GetAgentRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GetAgentRequest request = new GetAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAppAgent("[PROJECT]", "[LOCATION]", "[APP]", "[AGENT]"),
            };
            // Make the request
            Agent response = agentServiceClient.GetAgent(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAsync</summary>
        public async Task GetAgentRequestObjectAsync()
        {
            // Snippet: GetAgentAsync(GetAgentRequest, CallSettings)
            // Additional: GetAgentAsync(GetAgentRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAgentRequest request = new GetAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAppAgent("[PROJECT]", "[LOCATION]", "[APP]", "[AGENT]"),
            };
            // Make the request
            Agent response = await agentServiceClient.GetAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgent</summary>
        public void GetAgent()
        {
            // Snippet: GetAgent(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/agents/[AGENT]";
            // Make the request
            Agent response = agentServiceClient.GetAgent(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAsync</summary>
        public async Task GetAgentAsync()
        {
            // Snippet: GetAgentAsync(string, CallSettings)
            // Additional: GetAgentAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/agents/[AGENT]";
            // Make the request
            Agent response = await agentServiceClient.GetAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgent</summary>
        public void GetAgentResourceNames()
        {
            // Snippet: GetAgent(AgentName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAppAgent("[PROJECT]", "[LOCATION]", "[APP]", "[AGENT]");
            // Make the request
            Agent response = agentServiceClient.GetAgent(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentAsync</summary>
        public async Task GetAgentResourceNamesAsync()
        {
            // Snippet: GetAgentAsync(AgentName, CallSettings)
            // Additional: GetAgentAsync(AgentName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAppAgent("[PROJECT]", "[LOCATION]", "[APP]", "[AGENT]");
            // Make the request
            Agent response = await agentServiceClient.GetAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAgent</summary>
        public void CreateAgentRequestObject()
        {
            // Snippet: CreateAgent(CreateAgentRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            CreateAgentRequest request = new CreateAgentRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AgentId = "",
                Agent = new Agent(),
            };
            // Make the request
            Agent response = agentServiceClient.CreateAgent(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAsync</summary>
        public async Task CreateAgentRequestObjectAsync()
        {
            // Snippet: CreateAgentAsync(CreateAgentRequest, CallSettings)
            // Additional: CreateAgentAsync(CreateAgentRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAgentRequest request = new CreateAgentRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AgentId = "",
                Agent = new Agent(),
            };
            // Make the request
            Agent response = await agentServiceClient.CreateAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAgent</summary>
        public void CreateAgent1()
        {
            // Snippet: CreateAgent(string, Agent, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Agent agent = new Agent();
            string agentId = "";
            // Make the request
            Agent response = agentServiceClient.CreateAgent(parent, agent, agentId);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAsync</summary>
        public async Task CreateAgent1Async()
        {
            // Snippet: CreateAgentAsync(string, Agent, string, CallSettings)
            // Additional: CreateAgentAsync(string, Agent, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Agent agent = new Agent();
            string agentId = "";
            // Make the request
            Agent response = await agentServiceClient.CreateAgentAsync(parent, agent, agentId);
            // End snippet
        }

        /// <summary>Snippet for CreateAgent</summary>
        public void CreateAgent1ResourceNames()
        {
            // Snippet: CreateAgent(AppName, Agent, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Agent agent = new Agent();
            string agentId = "";
            // Make the request
            Agent response = agentServiceClient.CreateAgent(parent, agent, agentId);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAsync</summary>
        public async Task CreateAgent1ResourceNamesAsync()
        {
            // Snippet: CreateAgentAsync(AppName, Agent, string, CallSettings)
            // Additional: CreateAgentAsync(AppName, Agent, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Agent agent = new Agent();
            string agentId = "";
            // Make the request
            Agent response = await agentServiceClient.CreateAgentAsync(parent, agent, agentId);
            // End snippet
        }

        /// <summary>Snippet for CreateAgent</summary>
        public void CreateAgent2()
        {
            // Snippet: CreateAgent(string, Agent, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Agent agent = new Agent();
            // Make the request
            Agent response = agentServiceClient.CreateAgent(parent, agent);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAsync</summary>
        public async Task CreateAgent2Async()
        {
            // Snippet: CreateAgentAsync(string, Agent, CallSettings)
            // Additional: CreateAgentAsync(string, Agent, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Agent agent = new Agent();
            // Make the request
            Agent response = await agentServiceClient.CreateAgentAsync(parent, agent);
            // End snippet
        }

        /// <summary>Snippet for CreateAgent</summary>
        public void CreateAgent2ResourceNames()
        {
            // Snippet: CreateAgent(AppName, Agent, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Agent agent = new Agent();
            // Make the request
            Agent response = agentServiceClient.CreateAgent(parent, agent);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentAsync</summary>
        public async Task CreateAgent2ResourceNamesAsync()
        {
            // Snippet: CreateAgentAsync(AppName, Agent, CallSettings)
            // Additional: CreateAgentAsync(AppName, Agent, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Agent agent = new Agent();
            // Make the request
            Agent response = await agentServiceClient.CreateAgentAsync(parent, agent);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgent</summary>
        public void UpdateAgentRequestObject()
        {
            // Snippet: UpdateAgent(UpdateAgentRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            UpdateAgentRequest request = new UpdateAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Agent response = agentServiceClient.UpdateAgent(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgentAsync</summary>
        public async Task UpdateAgentRequestObjectAsync()
        {
            // Snippet: UpdateAgentAsync(UpdateAgentRequest, CallSettings)
            // Additional: UpdateAgentAsync(UpdateAgentRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAgentRequest request = new UpdateAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Agent response = await agentServiceClient.UpdateAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgent</summary>
        public void UpdateAgent()
        {
            // Snippet: UpdateAgent(Agent, FieldMask, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            Agent agent = new Agent();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Agent response = agentServiceClient.UpdateAgent(agent, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgentAsync</summary>
        public async Task UpdateAgentAsync()
        {
            // Snippet: UpdateAgentAsync(Agent, FieldMask, CallSettings)
            // Additional: UpdateAgentAsync(Agent, FieldMask, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Agent agent = new Agent();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Agent response = await agentServiceClient.UpdateAgentAsync(agent, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgent</summary>
        public void DeleteAgentRequestObject()
        {
            // Snippet: DeleteAgent(DeleteAgentRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAppAgent("[PROJECT]", "[LOCATION]", "[APP]", "[AGENT]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            agentServiceClient.DeleteAgent(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAsync</summary>
        public async Task DeleteAgentRequestObjectAsync()
        {
            // Snippet: DeleteAgentAsync(DeleteAgentRequest, CallSettings)
            // Additional: DeleteAgentAsync(DeleteAgentRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAppAgent("[PROJECT]", "[LOCATION]", "[APP]", "[AGENT]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            await agentServiceClient.DeleteAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgent</summary>
        public void DeleteAgent()
        {
            // Snippet: DeleteAgent(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/agents/[AGENT]";
            // Make the request
            agentServiceClient.DeleteAgent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAsync</summary>
        public async Task DeleteAgentAsync()
        {
            // Snippet: DeleteAgentAsync(string, CallSettings)
            // Additional: DeleteAgentAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/agents/[AGENT]";
            // Make the request
            await agentServiceClient.DeleteAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgent</summary>
        public void DeleteAgentResourceNames()
        {
            // Snippet: DeleteAgent(AgentName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAppAgent("[PROJECT]", "[LOCATION]", "[APP]", "[AGENT]");
            // Make the request
            agentServiceClient.DeleteAgent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentAsync</summary>
        public async Task DeleteAgentResourceNamesAsync()
        {
            // Snippet: DeleteAgentAsync(AgentName, CallSettings)
            // Additional: DeleteAgentAsync(AgentName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AgentName name = AgentName.FromProjectLocationAppAgent("[PROJECT]", "[LOCATION]", "[APP]", "[AGENT]");
            // Make the request
            await agentServiceClient.DeleteAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamplesRequestObject()
        {
            // Snippet: ListExamples(ListExamplesRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = agentServiceClient.ListExamples(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesRequestObjectAsync()
        {
            // Snippet: ListExamplesAsync(ListExamplesRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = agentServiceClient.ListExamplesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamples()
        {
            // Snippet: ListExamples(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = agentServiceClient.ListExamples(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesAsync()
        {
            // Snippet: ListExamplesAsync(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = agentServiceClient.ListExamplesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamplesResourceNames()
        {
            // Snippet: ListExamples(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = agentServiceClient.ListExamples(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesResourceNamesAsync()
        {
            // Snippet: ListExamplesAsync(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = agentServiceClient.ListExamplesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExample</summary>
        public void GetExampleRequestObject()
        {
            // Snippet: GetExample(GetExampleRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectLocationAppExample("[PROJECT]", "[LOCATION]", "[APP]", "[EXAMPLE]"),
            };
            // Make the request
            Example response = agentServiceClient.GetExample(request);
            // End snippet
        }

        /// <summary>Snippet for GetExampleAsync</summary>
        public async Task GetExampleRequestObjectAsync()
        {
            // Snippet: GetExampleAsync(GetExampleRequest, CallSettings)
            // Additional: GetExampleAsync(GetExampleRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectLocationAppExample("[PROJECT]", "[LOCATION]", "[APP]", "[EXAMPLE]"),
            };
            // Make the request
            Example response = await agentServiceClient.GetExampleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExample</summary>
        public void GetExample()
        {
            // Snippet: GetExample(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/examples/[EXAMPLE]";
            // Make the request
            Example response = agentServiceClient.GetExample(name);
            // End snippet
        }

        /// <summary>Snippet for GetExampleAsync</summary>
        public async Task GetExampleAsync()
        {
            // Snippet: GetExampleAsync(string, CallSettings)
            // Additional: GetExampleAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/examples/[EXAMPLE]";
            // Make the request
            Example response = await agentServiceClient.GetExampleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExample</summary>
        public void GetExampleResourceNames()
        {
            // Snippet: GetExample(ExampleName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ExampleName name = ExampleName.FromProjectLocationAppExample("[PROJECT]", "[LOCATION]", "[APP]", "[EXAMPLE]");
            // Make the request
            Example response = agentServiceClient.GetExample(name);
            // End snippet
        }

        /// <summary>Snippet for GetExampleAsync</summary>
        public async Task GetExampleResourceNamesAsync()
        {
            // Snippet: GetExampleAsync(ExampleName, CallSettings)
            // Additional: GetExampleAsync(ExampleName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExampleName name = ExampleName.FromProjectLocationAppExample("[PROJECT]", "[LOCATION]", "[APP]", "[EXAMPLE]");
            // Make the request
            Example response = await agentServiceClient.GetExampleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateExample</summary>
        public void CreateExampleRequestObject()
        {
            // Snippet: CreateExample(CreateExampleRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            CreateExampleRequest request = new CreateExampleRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ExampleId = "",
                Example = new Example(),
            };
            // Make the request
            Example response = agentServiceClient.CreateExample(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExampleAsync</summary>
        public async Task CreateExampleRequestObjectAsync()
        {
            // Snippet: CreateExampleAsync(CreateExampleRequest, CallSettings)
            // Additional: CreateExampleAsync(CreateExampleRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateExampleRequest request = new CreateExampleRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ExampleId = "",
                Example = new Example(),
            };
            // Make the request
            Example response = await agentServiceClient.CreateExampleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExample</summary>
        public void CreateExample1()
        {
            // Snippet: CreateExample(string, Example, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Example example = new Example();
            string exampleId = "";
            // Make the request
            Example response = agentServiceClient.CreateExample(parent, example, exampleId);
            // End snippet
        }

        /// <summary>Snippet for CreateExampleAsync</summary>
        public async Task CreateExample1Async()
        {
            // Snippet: CreateExampleAsync(string, Example, string, CallSettings)
            // Additional: CreateExampleAsync(string, Example, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Example example = new Example();
            string exampleId = "";
            // Make the request
            Example response = await agentServiceClient.CreateExampleAsync(parent, example, exampleId);
            // End snippet
        }

        /// <summary>Snippet for CreateExample</summary>
        public void CreateExample1ResourceNames()
        {
            // Snippet: CreateExample(AppName, Example, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Example example = new Example();
            string exampleId = "";
            // Make the request
            Example response = agentServiceClient.CreateExample(parent, example, exampleId);
            // End snippet
        }

        /// <summary>Snippet for CreateExampleAsync</summary>
        public async Task CreateExample1ResourceNamesAsync()
        {
            // Snippet: CreateExampleAsync(AppName, Example, string, CallSettings)
            // Additional: CreateExampleAsync(AppName, Example, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Example example = new Example();
            string exampleId = "";
            // Make the request
            Example response = await agentServiceClient.CreateExampleAsync(parent, example, exampleId);
            // End snippet
        }

        /// <summary>Snippet for CreateExample</summary>
        public void CreateExample2()
        {
            // Snippet: CreateExample(string, Example, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Example example = new Example();
            // Make the request
            Example response = agentServiceClient.CreateExample(parent, example);
            // End snippet
        }

        /// <summary>Snippet for CreateExampleAsync</summary>
        public async Task CreateExample2Async()
        {
            // Snippet: CreateExampleAsync(string, Example, CallSettings)
            // Additional: CreateExampleAsync(string, Example, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Example example = new Example();
            // Make the request
            Example response = await agentServiceClient.CreateExampleAsync(parent, example);
            // End snippet
        }

        /// <summary>Snippet for CreateExample</summary>
        public void CreateExample2ResourceNames()
        {
            // Snippet: CreateExample(AppName, Example, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Example example = new Example();
            // Make the request
            Example response = agentServiceClient.CreateExample(parent, example);
            // End snippet
        }

        /// <summary>Snippet for CreateExampleAsync</summary>
        public async Task CreateExample2ResourceNamesAsync()
        {
            // Snippet: CreateExampleAsync(AppName, Example, CallSettings)
            // Additional: CreateExampleAsync(AppName, Example, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Example example = new Example();
            // Make the request
            Example response = await agentServiceClient.CreateExampleAsync(parent, example);
            // End snippet
        }

        /// <summary>Snippet for UpdateExample</summary>
        public void UpdateExampleRequestObject()
        {
            // Snippet: UpdateExample(UpdateExampleRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            UpdateExampleRequest request = new UpdateExampleRequest
            {
                Example = new Example(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Example response = agentServiceClient.UpdateExample(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExampleAsync</summary>
        public async Task UpdateExampleRequestObjectAsync()
        {
            // Snippet: UpdateExampleAsync(UpdateExampleRequest, CallSettings)
            // Additional: UpdateExampleAsync(UpdateExampleRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExampleRequest request = new UpdateExampleRequest
            {
                Example = new Example(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Example response = await agentServiceClient.UpdateExampleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExample</summary>
        public void UpdateExample()
        {
            // Snippet: UpdateExample(Example, FieldMask, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            Example example = new Example();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Example response = agentServiceClient.UpdateExample(example, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExampleAsync</summary>
        public async Task UpdateExampleAsync()
        {
            // Snippet: UpdateExampleAsync(Example, FieldMask, CallSettings)
            // Additional: UpdateExampleAsync(Example, FieldMask, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Example example = new Example();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Example response = await agentServiceClient.UpdateExampleAsync(example, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteExample</summary>
        public void DeleteExampleRequestObject()
        {
            // Snippet: DeleteExample(DeleteExampleRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            DeleteExampleRequest request = new DeleteExampleRequest
            {
                ExampleName = ExampleName.FromProjectLocationAppExample("[PROJECT]", "[LOCATION]", "[APP]", "[EXAMPLE]"),
                Etag = "",
            };
            // Make the request
            agentServiceClient.DeleteExample(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleAsync</summary>
        public async Task DeleteExampleRequestObjectAsync()
        {
            // Snippet: DeleteExampleAsync(DeleteExampleRequest, CallSettings)
            // Additional: DeleteExampleAsync(DeleteExampleRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExampleRequest request = new DeleteExampleRequest
            {
                ExampleName = ExampleName.FromProjectLocationAppExample("[PROJECT]", "[LOCATION]", "[APP]", "[EXAMPLE]"),
                Etag = "",
            };
            // Make the request
            await agentServiceClient.DeleteExampleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExample</summary>
        public void DeleteExample()
        {
            // Snippet: DeleteExample(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/examples/[EXAMPLE]";
            // Make the request
            agentServiceClient.DeleteExample(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleAsync</summary>
        public async Task DeleteExampleAsync()
        {
            // Snippet: DeleteExampleAsync(string, CallSettings)
            // Additional: DeleteExampleAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/examples/[EXAMPLE]";
            // Make the request
            await agentServiceClient.DeleteExampleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExample</summary>
        public void DeleteExampleResourceNames()
        {
            // Snippet: DeleteExample(ExampleName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ExampleName name = ExampleName.FromProjectLocationAppExample("[PROJECT]", "[LOCATION]", "[APP]", "[EXAMPLE]");
            // Make the request
            agentServiceClient.DeleteExample(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleAsync</summary>
        public async Task DeleteExampleResourceNamesAsync()
        {
            // Snippet: DeleteExampleAsync(ExampleName, CallSettings)
            // Additional: DeleteExampleAsync(ExampleName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExampleName name = ExampleName.FromProjectLocationAppExample("[PROJECT]", "[LOCATION]", "[APP]", "[EXAMPLE]");
            // Make the request
            await agentServiceClient.DeleteExampleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTools</summary>
        public void ListToolsRequestObject()
        {
            // Snippet: ListTools(ListToolsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ListToolsRequest request = new ListToolsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListToolsResponse, Tool> response = agentServiceClient.ListTools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolsAsync</summary>
        public async Task ListToolsRequestObjectAsync()
        {
            // Snippet: ListToolsAsync(ListToolsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListToolsRequest request = new ListToolsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListToolsResponse, Tool> response = agentServiceClient.ListToolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTools</summary>
        public void ListTools()
        {
            // Snippet: ListTools(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListToolsResponse, Tool> response = agentServiceClient.ListTools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolsAsync</summary>
        public async Task ListToolsAsync()
        {
            // Snippet: ListToolsAsync(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListToolsResponse, Tool> response = agentServiceClient.ListToolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTools</summary>
        public void ListToolsResourceNames()
        {
            // Snippet: ListTools(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListToolsResponse, Tool> response = agentServiceClient.ListTools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolsAsync</summary>
        public async Task ListToolsResourceNamesAsync()
        {
            // Snippet: ListToolsAsync(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListToolsResponse, Tool> response = agentServiceClient.ListToolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Tool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTool</summary>
        public void GetToolRequestObject()
        {
            // Snippet: GetTool(GetToolRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GetToolRequest request = new GetToolRequest
            {
                ToolName = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]"),
            };
            // Make the request
            Tool response = agentServiceClient.GetTool(request);
            // End snippet
        }

        /// <summary>Snippet for GetToolAsync</summary>
        public async Task GetToolRequestObjectAsync()
        {
            // Snippet: GetToolAsync(GetToolRequest, CallSettings)
            // Additional: GetToolAsync(GetToolRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetToolRequest request = new GetToolRequest
            {
                ToolName = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]"),
            };
            // Make the request
            Tool response = await agentServiceClient.GetToolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTool</summary>
        public void GetTool()
        {
            // Snippet: GetTool(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/tools/[TOOL]";
            // Make the request
            Tool response = agentServiceClient.GetTool(name);
            // End snippet
        }

        /// <summary>Snippet for GetToolAsync</summary>
        public async Task GetToolAsync()
        {
            // Snippet: GetToolAsync(string, CallSettings)
            // Additional: GetToolAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/tools/[TOOL]";
            // Make the request
            Tool response = await agentServiceClient.GetToolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTool</summary>
        public void GetToolResourceNames()
        {
            // Snippet: GetTool(ToolName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ToolName name = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]");
            // Make the request
            Tool response = agentServiceClient.GetTool(name);
            // End snippet
        }

        /// <summary>Snippet for GetToolAsync</summary>
        public async Task GetToolResourceNamesAsync()
        {
            // Snippet: GetToolAsync(ToolName, CallSettings)
            // Additional: GetToolAsync(ToolName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ToolName name = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]");
            // Make the request
            Tool response = await agentServiceClient.GetToolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConversations</summary>
        public void ListConversationsRequestObject()
        {
            // Snippet: ListConversations(ListConversationsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                Source = Conversation.Types.Source.Unspecified,
                Sources =
                {
                    Conversation.Types.Source.Unspecified,
                },
            };
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = agentServiceClient.ListConversations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Conversation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationsAsync</summary>
        public async Task ListConversationsRequestObjectAsync()
        {
            // Snippet: ListConversationsAsync(ListConversationsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                Source = Conversation.Types.Source.Unspecified,
                Sources =
                {
                    Conversation.Types.Source.Unspecified,
                },
            };
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = agentServiceClient.ListConversationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Conversation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListConversationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversations</summary>
        public void ListConversations()
        {
            // Snippet: ListConversations(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = agentServiceClient.ListConversations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Conversation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationsAsync</summary>
        public async Task ListConversationsAsync()
        {
            // Snippet: ListConversationsAsync(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = agentServiceClient.ListConversationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Conversation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListConversationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversations</summary>
        public void ListConversationsResourceNames()
        {
            // Snippet: ListConversations(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = agentServiceClient.ListConversations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Conversation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationsAsync</summary>
        public async Task ListConversationsResourceNamesAsync()
        {
            // Snippet: ListConversationsAsync(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = agentServiceClient.ListConversationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Conversation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListConversationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversationRequestObject()
        {
            // Snippet: GetConversation(GetConversationRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]"),
            };
            // Make the request
            Conversation response = agentServiceClient.GetConversation(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationRequestObjectAsync()
        {
            // Snippet: GetConversationAsync(GetConversationRequest, CallSettings)
            // Additional: GetConversationAsync(GetConversationRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]"),
            };
            // Make the request
            Conversation response = await agentServiceClient.GetConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversation()
        {
            // Snippet: GetConversation(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/conversations/[CONVERSATION]";
            // Make the request
            Conversation response = agentServiceClient.GetConversation(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationAsync()
        {
            // Snippet: GetConversationAsync(string, CallSettings)
            // Additional: GetConversationAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/conversations/[CONVERSATION]";
            // Make the request
            Conversation response = await agentServiceClient.GetConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversationResourceNames()
        {
            // Snippet: GetConversation(ConversationName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]");
            // Make the request
            Conversation response = agentServiceClient.GetConversation(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationResourceNamesAsync()
        {
            // Snippet: GetConversationAsync(ConversationName, CallSettings)
            // Additional: GetConversationAsync(ConversationName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]");
            // Make the request
            Conversation response = await agentServiceClient.GetConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversation</summary>
        public void DeleteConversationRequestObject()
        {
            // Snippet: DeleteConversation(DeleteConversationRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]"),
            };
            // Make the request
            agentServiceClient.DeleteConversation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationAsync</summary>
        public async Task DeleteConversationRequestObjectAsync()
        {
            // Snippet: DeleteConversationAsync(DeleteConversationRequest, CallSettings)
            // Additional: DeleteConversationAsync(DeleteConversationRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]"),
            };
            // Make the request
            await agentServiceClient.DeleteConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversation</summary>
        public void DeleteConversation()
        {
            // Snippet: DeleteConversation(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/conversations/[CONVERSATION]";
            // Make the request
            agentServiceClient.DeleteConversation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationAsync</summary>
        public async Task DeleteConversationAsync()
        {
            // Snippet: DeleteConversationAsync(string, CallSettings)
            // Additional: DeleteConversationAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/conversations/[CONVERSATION]";
            // Make the request
            await agentServiceClient.DeleteConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversation</summary>
        public void DeleteConversationResourceNames()
        {
            // Snippet: DeleteConversation(ConversationName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]");
            // Make the request
            agentServiceClient.DeleteConversation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationAsync</summary>
        public async Task DeleteConversationResourceNamesAsync()
        {
            // Snippet: DeleteConversationAsync(ConversationName, CallSettings)
            // Additional: DeleteConversationAsync(ConversationName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]");
            // Make the request
            await agentServiceClient.DeleteConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteConversations</summary>
        public void BatchDeleteConversationsRequestObject()
        {
            // Snippet: BatchDeleteConversations(BatchDeleteConversationsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteConversationsRequest request = new BatchDeleteConversationsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ConversationsAsConversationNames =
                {
                    ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]"),
                },
            };
            // Make the request
            Operation<BatchDeleteConversationsResponse, OperationMetadata> response = agentServiceClient.BatchDeleteConversations(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteConversationsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteConversationsResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceBatchDeleteConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteConversationsAsync</summary>
        public async Task BatchDeleteConversationsRequestObjectAsync()
        {
            // Snippet: BatchDeleteConversationsAsync(BatchDeleteConversationsRequest, CallSettings)
            // Additional: BatchDeleteConversationsAsync(BatchDeleteConversationsRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteConversationsRequest request = new BatchDeleteConversationsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ConversationsAsConversationNames =
                {
                    ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]"),
                },
            };
            // Make the request
            Operation<BatchDeleteConversationsResponse, OperationMetadata> response = await agentServiceClient.BatchDeleteConversationsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteConversationsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteConversationsResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceBatchDeleteConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteConversations</summary>
        public void BatchDeleteConversations()
        {
            // Snippet: BatchDeleteConversations(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            Operation<BatchDeleteConversationsResponse, OperationMetadata> response = agentServiceClient.BatchDeleteConversations(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteConversationsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteConversationsResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceBatchDeleteConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteConversationsAsync</summary>
        public async Task BatchDeleteConversationsAsync()
        {
            // Snippet: BatchDeleteConversationsAsync(string, CallSettings)
            // Additional: BatchDeleteConversationsAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            Operation<BatchDeleteConversationsResponse, OperationMetadata> response = await agentServiceClient.BatchDeleteConversationsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteConversationsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteConversationsResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceBatchDeleteConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteConversations</summary>
        public void BatchDeleteConversationsResourceNames()
        {
            // Snippet: BatchDeleteConversations(AppName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            Operation<BatchDeleteConversationsResponse, OperationMetadata> response = agentServiceClient.BatchDeleteConversations(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteConversationsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteConversationsResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceBatchDeleteConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteConversationsAsync</summary>
        public async Task BatchDeleteConversationsResourceNamesAsync()
        {
            // Snippet: BatchDeleteConversationsAsync(AppName, CallSettings)
            // Additional: BatchDeleteConversationsAsync(AppName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            Operation<BatchDeleteConversationsResponse, OperationMetadata> response = await agentServiceClient.BatchDeleteConversationsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteConversationsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteConversationsResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceBatchDeleteConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTool</summary>
        public void CreateToolRequestObject()
        {
            // Snippet: CreateTool(CreateToolRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            CreateToolRequest request = new CreateToolRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ToolId = "",
                Tool = new Tool(),
            };
            // Make the request
            Tool response = agentServiceClient.CreateTool(request);
            // End snippet
        }

        /// <summary>Snippet for CreateToolAsync</summary>
        public async Task CreateToolRequestObjectAsync()
        {
            // Snippet: CreateToolAsync(CreateToolRequest, CallSettings)
            // Additional: CreateToolAsync(CreateToolRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateToolRequest request = new CreateToolRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ToolId = "",
                Tool = new Tool(),
            };
            // Make the request
            Tool response = await agentServiceClient.CreateToolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTool</summary>
        public void CreateTool1()
        {
            // Snippet: CreateTool(string, Tool, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Tool tool = new Tool();
            string toolId = "";
            // Make the request
            Tool response = agentServiceClient.CreateTool(parent, tool, toolId);
            // End snippet
        }

        /// <summary>Snippet for CreateToolAsync</summary>
        public async Task CreateTool1Async()
        {
            // Snippet: CreateToolAsync(string, Tool, string, CallSettings)
            // Additional: CreateToolAsync(string, Tool, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Tool tool = new Tool();
            string toolId = "";
            // Make the request
            Tool response = await agentServiceClient.CreateToolAsync(parent, tool, toolId);
            // End snippet
        }

        /// <summary>Snippet for CreateTool</summary>
        public void CreateTool1ResourceNames()
        {
            // Snippet: CreateTool(AppName, Tool, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Tool tool = new Tool();
            string toolId = "";
            // Make the request
            Tool response = agentServiceClient.CreateTool(parent, tool, toolId);
            // End snippet
        }

        /// <summary>Snippet for CreateToolAsync</summary>
        public async Task CreateTool1ResourceNamesAsync()
        {
            // Snippet: CreateToolAsync(AppName, Tool, string, CallSettings)
            // Additional: CreateToolAsync(AppName, Tool, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Tool tool = new Tool();
            string toolId = "";
            // Make the request
            Tool response = await agentServiceClient.CreateToolAsync(parent, tool, toolId);
            // End snippet
        }

        /// <summary>Snippet for CreateTool</summary>
        public void CreateTool2()
        {
            // Snippet: CreateTool(string, Tool, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Tool tool = new Tool();
            // Make the request
            Tool response = agentServiceClient.CreateTool(parent, tool);
            // End snippet
        }

        /// <summary>Snippet for CreateToolAsync</summary>
        public async Task CreateTool2Async()
        {
            // Snippet: CreateToolAsync(string, Tool, CallSettings)
            // Additional: CreateToolAsync(string, Tool, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Tool tool = new Tool();
            // Make the request
            Tool response = await agentServiceClient.CreateToolAsync(parent, tool);
            // End snippet
        }

        /// <summary>Snippet for CreateTool</summary>
        public void CreateTool2ResourceNames()
        {
            // Snippet: CreateTool(AppName, Tool, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Tool tool = new Tool();
            // Make the request
            Tool response = agentServiceClient.CreateTool(parent, tool);
            // End snippet
        }

        /// <summary>Snippet for CreateToolAsync</summary>
        public async Task CreateTool2ResourceNamesAsync()
        {
            // Snippet: CreateToolAsync(AppName, Tool, CallSettings)
            // Additional: CreateToolAsync(AppName, Tool, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Tool tool = new Tool();
            // Make the request
            Tool response = await agentServiceClient.CreateToolAsync(parent, tool);
            // End snippet
        }

        /// <summary>Snippet for UpdateTool</summary>
        public void UpdateToolRequestObject()
        {
            // Snippet: UpdateTool(UpdateToolRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            UpdateToolRequest request = new UpdateToolRequest
            {
                Tool = new Tool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Tool response = agentServiceClient.UpdateTool(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateToolAsync</summary>
        public async Task UpdateToolRequestObjectAsync()
        {
            // Snippet: UpdateToolAsync(UpdateToolRequest, CallSettings)
            // Additional: UpdateToolAsync(UpdateToolRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateToolRequest request = new UpdateToolRequest
            {
                Tool = new Tool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Tool response = await agentServiceClient.UpdateToolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTool</summary>
        public void UpdateTool()
        {
            // Snippet: UpdateTool(Tool, FieldMask, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            Tool tool = new Tool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Tool response = agentServiceClient.UpdateTool(tool, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateToolAsync</summary>
        public async Task UpdateToolAsync()
        {
            // Snippet: UpdateToolAsync(Tool, FieldMask, CallSettings)
            // Additional: UpdateToolAsync(Tool, FieldMask, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Tool tool = new Tool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Tool response = await agentServiceClient.UpdateToolAsync(tool, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTool</summary>
        public void DeleteToolRequestObject()
        {
            // Snippet: DeleteTool(DeleteToolRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            DeleteToolRequest request = new DeleteToolRequest
            {
                ToolName = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            agentServiceClient.DeleteTool(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolAsync</summary>
        public async Task DeleteToolRequestObjectAsync()
        {
            // Snippet: DeleteToolAsync(DeleteToolRequest, CallSettings)
            // Additional: DeleteToolAsync(DeleteToolRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteToolRequest request = new DeleteToolRequest
            {
                ToolName = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            await agentServiceClient.DeleteToolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTool</summary>
        public void DeleteTool()
        {
            // Snippet: DeleteTool(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/tools/[TOOL]";
            // Make the request
            agentServiceClient.DeleteTool(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolAsync</summary>
        public async Task DeleteToolAsync()
        {
            // Snippet: DeleteToolAsync(string, CallSettings)
            // Additional: DeleteToolAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/tools/[TOOL]";
            // Make the request
            await agentServiceClient.DeleteToolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTool</summary>
        public void DeleteToolResourceNames()
        {
            // Snippet: DeleteTool(ToolName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ToolName name = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]");
            // Make the request
            agentServiceClient.DeleteTool(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolAsync</summary>
        public async Task DeleteToolResourceNamesAsync()
        {
            // Snippet: DeleteToolAsync(ToolName, CallSettings)
            // Additional: DeleteToolAsync(ToolName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ToolName name = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]");
            // Make the request
            await agentServiceClient.DeleteToolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGuardrails</summary>
        public void ListGuardrailsRequestObject()
        {
            // Snippet: ListGuardrails(ListGuardrailsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ListGuardrailsRequest request = new ListGuardrailsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListGuardrailsResponse, Guardrail> response = agentServiceClient.ListGuardrails(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Guardrail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGuardrailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Guardrail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Guardrail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Guardrail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGuardrailsAsync</summary>
        public async Task ListGuardrailsRequestObjectAsync()
        {
            // Snippet: ListGuardrailsAsync(ListGuardrailsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGuardrailsRequest request = new ListGuardrailsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListGuardrailsResponse, Guardrail> response = agentServiceClient.ListGuardrailsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Guardrail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGuardrailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Guardrail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Guardrail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Guardrail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGuardrails</summary>
        public void ListGuardrails()
        {
            // Snippet: ListGuardrails(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListGuardrailsResponse, Guardrail> response = agentServiceClient.ListGuardrails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Guardrail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGuardrailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Guardrail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Guardrail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Guardrail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGuardrailsAsync</summary>
        public async Task ListGuardrailsAsync()
        {
            // Snippet: ListGuardrailsAsync(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListGuardrailsResponse, Guardrail> response = agentServiceClient.ListGuardrailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Guardrail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGuardrailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Guardrail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Guardrail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Guardrail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGuardrails</summary>
        public void ListGuardrailsResourceNames()
        {
            // Snippet: ListGuardrails(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListGuardrailsResponse, Guardrail> response = agentServiceClient.ListGuardrails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Guardrail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGuardrailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Guardrail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Guardrail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Guardrail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGuardrailsAsync</summary>
        public async Task ListGuardrailsResourceNamesAsync()
        {
            // Snippet: ListGuardrailsAsync(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListGuardrailsResponse, Guardrail> response = agentServiceClient.ListGuardrailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Guardrail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGuardrailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Guardrail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Guardrail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Guardrail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGuardrail</summary>
        public void GetGuardrailRequestObject()
        {
            // Snippet: GetGuardrail(GetGuardrailRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GetGuardrailRequest request = new GetGuardrailRequest
            {
                GuardrailName = GuardrailName.FromProjectLocationAppGuardrail("[PROJECT]", "[LOCATION]", "[APP]", "[GUARDRAIL]"),
            };
            // Make the request
            Guardrail response = agentServiceClient.GetGuardrail(request);
            // End snippet
        }

        /// <summary>Snippet for GetGuardrailAsync</summary>
        public async Task GetGuardrailRequestObjectAsync()
        {
            // Snippet: GetGuardrailAsync(GetGuardrailRequest, CallSettings)
            // Additional: GetGuardrailAsync(GetGuardrailRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGuardrailRequest request = new GetGuardrailRequest
            {
                GuardrailName = GuardrailName.FromProjectLocationAppGuardrail("[PROJECT]", "[LOCATION]", "[APP]", "[GUARDRAIL]"),
            };
            // Make the request
            Guardrail response = await agentServiceClient.GetGuardrailAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGuardrail</summary>
        public void GetGuardrail()
        {
            // Snippet: GetGuardrail(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/guardrails/[GUARDRAIL]";
            // Make the request
            Guardrail response = agentServiceClient.GetGuardrail(name);
            // End snippet
        }

        /// <summary>Snippet for GetGuardrailAsync</summary>
        public async Task GetGuardrailAsync()
        {
            // Snippet: GetGuardrailAsync(string, CallSettings)
            // Additional: GetGuardrailAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/guardrails/[GUARDRAIL]";
            // Make the request
            Guardrail response = await agentServiceClient.GetGuardrailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGuardrail</summary>
        public void GetGuardrailResourceNames()
        {
            // Snippet: GetGuardrail(GuardrailName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GuardrailName name = GuardrailName.FromProjectLocationAppGuardrail("[PROJECT]", "[LOCATION]", "[APP]", "[GUARDRAIL]");
            // Make the request
            Guardrail response = agentServiceClient.GetGuardrail(name);
            // End snippet
        }

        /// <summary>Snippet for GetGuardrailAsync</summary>
        public async Task GetGuardrailResourceNamesAsync()
        {
            // Snippet: GetGuardrailAsync(GuardrailName, CallSettings)
            // Additional: GetGuardrailAsync(GuardrailName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GuardrailName name = GuardrailName.FromProjectLocationAppGuardrail("[PROJECT]", "[LOCATION]", "[APP]", "[GUARDRAIL]");
            // Make the request
            Guardrail response = await agentServiceClient.GetGuardrailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGuardrail</summary>
        public void CreateGuardrailRequestObject()
        {
            // Snippet: CreateGuardrail(CreateGuardrailRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            CreateGuardrailRequest request = new CreateGuardrailRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                GuardrailId = "",
                Guardrail = new Guardrail(),
            };
            // Make the request
            Guardrail response = agentServiceClient.CreateGuardrail(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGuardrailAsync</summary>
        public async Task CreateGuardrailRequestObjectAsync()
        {
            // Snippet: CreateGuardrailAsync(CreateGuardrailRequest, CallSettings)
            // Additional: CreateGuardrailAsync(CreateGuardrailRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGuardrailRequest request = new CreateGuardrailRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                GuardrailId = "",
                Guardrail = new Guardrail(),
            };
            // Make the request
            Guardrail response = await agentServiceClient.CreateGuardrailAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGuardrail</summary>
        public void CreateGuardrail1()
        {
            // Snippet: CreateGuardrail(string, Guardrail, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Guardrail guardrail = new Guardrail();
            string guardrailId = "";
            // Make the request
            Guardrail response = agentServiceClient.CreateGuardrail(parent, guardrail, guardrailId);
            // End snippet
        }

        /// <summary>Snippet for CreateGuardrailAsync</summary>
        public async Task CreateGuardrail1Async()
        {
            // Snippet: CreateGuardrailAsync(string, Guardrail, string, CallSettings)
            // Additional: CreateGuardrailAsync(string, Guardrail, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Guardrail guardrail = new Guardrail();
            string guardrailId = "";
            // Make the request
            Guardrail response = await agentServiceClient.CreateGuardrailAsync(parent, guardrail, guardrailId);
            // End snippet
        }

        /// <summary>Snippet for CreateGuardrail</summary>
        public void CreateGuardrail1ResourceNames()
        {
            // Snippet: CreateGuardrail(AppName, Guardrail, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Guardrail guardrail = new Guardrail();
            string guardrailId = "";
            // Make the request
            Guardrail response = agentServiceClient.CreateGuardrail(parent, guardrail, guardrailId);
            // End snippet
        }

        /// <summary>Snippet for CreateGuardrailAsync</summary>
        public async Task CreateGuardrail1ResourceNamesAsync()
        {
            // Snippet: CreateGuardrailAsync(AppName, Guardrail, string, CallSettings)
            // Additional: CreateGuardrailAsync(AppName, Guardrail, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Guardrail guardrail = new Guardrail();
            string guardrailId = "";
            // Make the request
            Guardrail response = await agentServiceClient.CreateGuardrailAsync(parent, guardrail, guardrailId);
            // End snippet
        }

        /// <summary>Snippet for CreateGuardrail</summary>
        public void CreateGuardrail2()
        {
            // Snippet: CreateGuardrail(string, Guardrail, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Guardrail guardrail = new Guardrail();
            // Make the request
            Guardrail response = agentServiceClient.CreateGuardrail(parent, guardrail);
            // End snippet
        }

        /// <summary>Snippet for CreateGuardrailAsync</summary>
        public async Task CreateGuardrail2Async()
        {
            // Snippet: CreateGuardrailAsync(string, Guardrail, CallSettings)
            // Additional: CreateGuardrailAsync(string, Guardrail, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Guardrail guardrail = new Guardrail();
            // Make the request
            Guardrail response = await agentServiceClient.CreateGuardrailAsync(parent, guardrail);
            // End snippet
        }

        /// <summary>Snippet for CreateGuardrail</summary>
        public void CreateGuardrail2ResourceNames()
        {
            // Snippet: CreateGuardrail(AppName, Guardrail, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Guardrail guardrail = new Guardrail();
            // Make the request
            Guardrail response = agentServiceClient.CreateGuardrail(parent, guardrail);
            // End snippet
        }

        /// <summary>Snippet for CreateGuardrailAsync</summary>
        public async Task CreateGuardrail2ResourceNamesAsync()
        {
            // Snippet: CreateGuardrailAsync(AppName, Guardrail, CallSettings)
            // Additional: CreateGuardrailAsync(AppName, Guardrail, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Guardrail guardrail = new Guardrail();
            // Make the request
            Guardrail response = await agentServiceClient.CreateGuardrailAsync(parent, guardrail);
            // End snippet
        }

        /// <summary>Snippet for UpdateGuardrail</summary>
        public void UpdateGuardrailRequestObject()
        {
            // Snippet: UpdateGuardrail(UpdateGuardrailRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            UpdateGuardrailRequest request = new UpdateGuardrailRequest
            {
                Guardrail = new Guardrail(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Guardrail response = agentServiceClient.UpdateGuardrail(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGuardrailAsync</summary>
        public async Task UpdateGuardrailRequestObjectAsync()
        {
            // Snippet: UpdateGuardrailAsync(UpdateGuardrailRequest, CallSettings)
            // Additional: UpdateGuardrailAsync(UpdateGuardrailRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGuardrailRequest request = new UpdateGuardrailRequest
            {
                Guardrail = new Guardrail(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Guardrail response = await agentServiceClient.UpdateGuardrailAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGuardrail</summary>
        public void UpdateGuardrail()
        {
            // Snippet: UpdateGuardrail(Guardrail, FieldMask, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            Guardrail guardrail = new Guardrail();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Guardrail response = agentServiceClient.UpdateGuardrail(guardrail, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateGuardrailAsync</summary>
        public async Task UpdateGuardrailAsync()
        {
            // Snippet: UpdateGuardrailAsync(Guardrail, FieldMask, CallSettings)
            // Additional: UpdateGuardrailAsync(Guardrail, FieldMask, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Guardrail guardrail = new Guardrail();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Guardrail response = await agentServiceClient.UpdateGuardrailAsync(guardrail, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuardrail</summary>
        public void DeleteGuardrailRequestObject()
        {
            // Snippet: DeleteGuardrail(DeleteGuardrailRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            DeleteGuardrailRequest request = new DeleteGuardrailRequest
            {
                GuardrailName = GuardrailName.FromProjectLocationAppGuardrail("[PROJECT]", "[LOCATION]", "[APP]", "[GUARDRAIL]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            agentServiceClient.DeleteGuardrail(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuardrailAsync</summary>
        public async Task DeleteGuardrailRequestObjectAsync()
        {
            // Snippet: DeleteGuardrailAsync(DeleteGuardrailRequest, CallSettings)
            // Additional: DeleteGuardrailAsync(DeleteGuardrailRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGuardrailRequest request = new DeleteGuardrailRequest
            {
                GuardrailName = GuardrailName.FromProjectLocationAppGuardrail("[PROJECT]", "[LOCATION]", "[APP]", "[GUARDRAIL]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            await agentServiceClient.DeleteGuardrailAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuardrail</summary>
        public void DeleteGuardrail()
        {
            // Snippet: DeleteGuardrail(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/guardrails/[GUARDRAIL]";
            // Make the request
            agentServiceClient.DeleteGuardrail(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuardrailAsync</summary>
        public async Task DeleteGuardrailAsync()
        {
            // Snippet: DeleteGuardrailAsync(string, CallSettings)
            // Additional: DeleteGuardrailAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/guardrails/[GUARDRAIL]";
            // Make the request
            await agentServiceClient.DeleteGuardrailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuardrail</summary>
        public void DeleteGuardrailResourceNames()
        {
            // Snippet: DeleteGuardrail(GuardrailName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GuardrailName name = GuardrailName.FromProjectLocationAppGuardrail("[PROJECT]", "[LOCATION]", "[APP]", "[GUARDRAIL]");
            // Make the request
            agentServiceClient.DeleteGuardrail(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGuardrailAsync</summary>
        public async Task DeleteGuardrailResourceNamesAsync()
        {
            // Snippet: DeleteGuardrailAsync(GuardrailName, CallSettings)
            // Additional: DeleteGuardrailAsync(GuardrailName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GuardrailName name = GuardrailName.FromProjectLocationAppGuardrail("[PROJECT]", "[LOCATION]", "[APP]", "[GUARDRAIL]");
            // Make the request
            await agentServiceClient.DeleteGuardrailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeploymentsRequestObject()
        {
            // Snippet: ListDeployments(ListDeploymentsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = agentServiceClient.ListDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsRequestObjectAsync()
        {
            // Snippet: ListDeploymentsAsync(ListDeploymentsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = agentServiceClient.ListDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeployments()
        {
            // Snippet: ListDeployments(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = agentServiceClient.ListDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsAsync()
        {
            // Snippet: ListDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = agentServiceClient.ListDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeploymentsResourceNames()
        {
            // Snippet: ListDeployments(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = agentServiceClient.ListDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsResourceNamesAsync()
        {
            // Snippet: ListDeploymentsAsync(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = agentServiceClient.ListDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentRequestObject()
        {
            // Snippet: GetDeployment(GetDeploymentRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAppDeployment("[PROJECT]", "[LOCATION]", "[APP]", "[DEPLOYMENT]"),
            };
            // Make the request
            Deployment response = agentServiceClient.GetDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentRequestObjectAsync()
        {
            // Snippet: GetDeploymentAsync(GetDeploymentRequest, CallSettings)
            // Additional: GetDeploymentAsync(GetDeploymentRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAppDeployment("[PROJECT]", "[LOCATION]", "[APP]", "[DEPLOYMENT]"),
            };
            // Make the request
            Deployment response = await agentServiceClient.GetDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeployment()
        {
            // Snippet: GetDeployment(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = agentServiceClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentAsync()
        {
            // Snippet: GetDeploymentAsync(string, CallSettings)
            // Additional: GetDeploymentAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = await agentServiceClient.GetDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentResourceNames()
        {
            // Snippet: GetDeployment(DeploymentName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationAppDeployment("[PROJECT]", "[LOCATION]", "[APP]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = agentServiceClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentResourceNamesAsync()
        {
            // Snippet: GetDeploymentAsync(DeploymentName, CallSettings)
            // Additional: GetDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationAppDeployment("[PROJECT]", "[LOCATION]", "[APP]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = await agentServiceClient.GetDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeploymentRequestObject()
        {
            // Snippet: CreateDeployment(CreateDeploymentRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Deployment = new Deployment(),
                DeploymentId = "",
            };
            // Make the request
            Deployment response = agentServiceClient.CreateDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentRequestObjectAsync()
        {
            // Snippet: CreateDeploymentAsync(CreateDeploymentRequest, CallSettings)
            // Additional: CreateDeploymentAsync(CreateDeploymentRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Deployment = new Deployment(),
                DeploymentId = "",
            };
            // Make the request
            Deployment response = await agentServiceClient.CreateDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeployment1()
        {
            // Snippet: CreateDeployment(string, Deployment, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = agentServiceClient.CreateDeployment(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeployment1Async()
        {
            // Snippet: CreateDeploymentAsync(string, Deployment, string, CallSettings)
            // Additional: CreateDeploymentAsync(string, Deployment, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = await agentServiceClient.CreateDeploymentAsync(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeployment1ResourceNames()
        {
            // Snippet: CreateDeployment(AppName, Deployment, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = agentServiceClient.CreateDeployment(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeployment1ResourceNamesAsync()
        {
            // Snippet: CreateDeploymentAsync(AppName, Deployment, string, CallSettings)
            // Additional: CreateDeploymentAsync(AppName, Deployment, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = await agentServiceClient.CreateDeploymentAsync(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeployment2()
        {
            // Snippet: CreateDeployment(string, Deployment, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Deployment deployment = new Deployment();
            // Make the request
            Deployment response = agentServiceClient.CreateDeployment(parent, deployment);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeployment2Async()
        {
            // Snippet: CreateDeploymentAsync(string, Deployment, CallSettings)
            // Additional: CreateDeploymentAsync(string, Deployment, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Deployment deployment = new Deployment();
            // Make the request
            Deployment response = await agentServiceClient.CreateDeploymentAsync(parent, deployment);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeployment2ResourceNames()
        {
            // Snippet: CreateDeployment(AppName, Deployment, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Deployment deployment = new Deployment();
            // Make the request
            Deployment response = agentServiceClient.CreateDeployment(parent, deployment);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeployment2ResourceNamesAsync()
        {
            // Snippet: CreateDeploymentAsync(AppName, Deployment, CallSettings)
            // Additional: CreateDeploymentAsync(AppName, Deployment, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Deployment deployment = new Deployment();
            // Make the request
            Deployment response = await agentServiceClient.CreateDeploymentAsync(parent, deployment);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployment</summary>
        public void UpdateDeploymentRequestObject()
        {
            // Snippet: UpdateDeployment(UpdateDeploymentRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            UpdateDeploymentRequest request = new UpdateDeploymentRequest
            {
                Deployment = new Deployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Deployment response = agentServiceClient.UpdateDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentAsync</summary>
        public async Task UpdateDeploymentRequestObjectAsync()
        {
            // Snippet: UpdateDeploymentAsync(UpdateDeploymentRequest, CallSettings)
            // Additional: UpdateDeploymentAsync(UpdateDeploymentRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeploymentRequest request = new UpdateDeploymentRequest
            {
                Deployment = new Deployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Deployment response = await agentServiceClient.UpdateDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployment</summary>
        public void UpdateDeployment()
        {
            // Snippet: UpdateDeployment(Deployment, FieldMask, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            Deployment deployment = new Deployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Deployment response = agentServiceClient.UpdateDeployment(deployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentAsync</summary>
        public async Task UpdateDeploymentAsync()
        {
            // Snippet: UpdateDeploymentAsync(Deployment, FieldMask, CallSettings)
            // Additional: UpdateDeploymentAsync(Deployment, FieldMask, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Deployment deployment = new Deployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Deployment response = await agentServiceClient.UpdateDeploymentAsync(deployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeploymentRequestObject()
        {
            // Snippet: DeleteDeployment(DeleteDeploymentRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAppDeployment("[PROJECT]", "[LOCATION]", "[APP]", "[DEPLOYMENT]"),
                Etag = "",
            };
            // Make the request
            agentServiceClient.DeleteDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentRequestObjectAsync()
        {
            // Snippet: DeleteDeploymentAsync(DeleteDeploymentRequest, CallSettings)
            // Additional: DeleteDeploymentAsync(DeleteDeploymentRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationAppDeployment("[PROJECT]", "[LOCATION]", "[APP]", "[DEPLOYMENT]"),
                Etag = "",
            };
            // Make the request
            await agentServiceClient.DeleteDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeployment()
        {
            // Snippet: DeleteDeployment(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/deployments/[DEPLOYMENT]";
            // Make the request
            agentServiceClient.DeleteDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentAsync()
        {
            // Snippet: DeleteDeploymentAsync(string, CallSettings)
            // Additional: DeleteDeploymentAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/deployments/[DEPLOYMENT]";
            // Make the request
            await agentServiceClient.DeleteDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployment</summary>
        public void DeleteDeploymentResourceNames()
        {
            // Snippet: DeleteDeployment(DeploymentName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationAppDeployment("[PROJECT]", "[LOCATION]", "[APP]", "[DEPLOYMENT]");
            // Make the request
            agentServiceClient.DeleteDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentAsync</summary>
        public async Task DeleteDeploymentResourceNamesAsync()
        {
            // Snippet: DeleteDeploymentAsync(DeploymentName, CallSettings)
            // Additional: DeleteDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationAppDeployment("[PROJECT]", "[LOCATION]", "[APP]", "[DEPLOYMENT]");
            // Make the request
            await agentServiceClient.DeleteDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListToolsets</summary>
        public void ListToolsetsRequestObject()
        {
            // Snippet: ListToolsets(ListToolsetsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ListToolsetsRequest request = new ListToolsetsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListToolsetsResponse, Toolset> response = agentServiceClient.ListToolsets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Toolset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolsetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Toolset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Toolset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Toolset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolsetsAsync</summary>
        public async Task ListToolsetsRequestObjectAsync()
        {
            // Snippet: ListToolsetsAsync(ListToolsetsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListToolsetsRequest request = new ListToolsetsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListToolsetsResponse, Toolset> response = agentServiceClient.ListToolsetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Toolset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolsetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Toolset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Toolset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Toolset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolsets</summary>
        public void ListToolsets()
        {
            // Snippet: ListToolsets(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListToolsetsResponse, Toolset> response = agentServiceClient.ListToolsets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Toolset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolsetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Toolset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Toolset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Toolset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolsetsAsync</summary>
        public async Task ListToolsetsAsync()
        {
            // Snippet: ListToolsetsAsync(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListToolsetsResponse, Toolset> response = agentServiceClient.ListToolsetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Toolset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolsetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Toolset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Toolset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Toolset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolsets</summary>
        public void ListToolsetsResourceNames()
        {
            // Snippet: ListToolsets(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListToolsetsResponse, Toolset> response = agentServiceClient.ListToolsets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Toolset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListToolsetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Toolset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Toolset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Toolset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListToolsetsAsync</summary>
        public async Task ListToolsetsResourceNamesAsync()
        {
            // Snippet: ListToolsetsAsync(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListToolsetsResponse, Toolset> response = agentServiceClient.ListToolsetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Toolset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListToolsetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Toolset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Toolset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Toolset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetToolset</summary>
        public void GetToolsetRequestObject()
        {
            // Snippet: GetToolset(GetToolsetRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GetToolsetRequest request = new GetToolsetRequest
            {
                ToolsetName = ToolsetName.FromProjectLocationAppToolset("[PROJECT]", "[LOCATION]", "[APP]", "[TOOLSET]"),
            };
            // Make the request
            Toolset response = agentServiceClient.GetToolset(request);
            // End snippet
        }

        /// <summary>Snippet for GetToolsetAsync</summary>
        public async Task GetToolsetRequestObjectAsync()
        {
            // Snippet: GetToolsetAsync(GetToolsetRequest, CallSettings)
            // Additional: GetToolsetAsync(GetToolsetRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetToolsetRequest request = new GetToolsetRequest
            {
                ToolsetName = ToolsetName.FromProjectLocationAppToolset("[PROJECT]", "[LOCATION]", "[APP]", "[TOOLSET]"),
            };
            // Make the request
            Toolset response = await agentServiceClient.GetToolsetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetToolset</summary>
        public void GetToolset()
        {
            // Snippet: GetToolset(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/toolsets/[TOOLSET]";
            // Make the request
            Toolset response = agentServiceClient.GetToolset(name);
            // End snippet
        }

        /// <summary>Snippet for GetToolsetAsync</summary>
        public async Task GetToolsetAsync()
        {
            // Snippet: GetToolsetAsync(string, CallSettings)
            // Additional: GetToolsetAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/toolsets/[TOOLSET]";
            // Make the request
            Toolset response = await agentServiceClient.GetToolsetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetToolset</summary>
        public void GetToolsetResourceNames()
        {
            // Snippet: GetToolset(ToolsetName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ToolsetName name = ToolsetName.FromProjectLocationAppToolset("[PROJECT]", "[LOCATION]", "[APP]", "[TOOLSET]");
            // Make the request
            Toolset response = agentServiceClient.GetToolset(name);
            // End snippet
        }

        /// <summary>Snippet for GetToolsetAsync</summary>
        public async Task GetToolsetResourceNamesAsync()
        {
            // Snippet: GetToolsetAsync(ToolsetName, CallSettings)
            // Additional: GetToolsetAsync(ToolsetName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ToolsetName name = ToolsetName.FromProjectLocationAppToolset("[PROJECT]", "[LOCATION]", "[APP]", "[TOOLSET]");
            // Make the request
            Toolset response = await agentServiceClient.GetToolsetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateToolset</summary>
        public void CreateToolsetRequestObject()
        {
            // Snippet: CreateToolset(CreateToolsetRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            CreateToolsetRequest request = new CreateToolsetRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ToolsetId = "",
                Toolset = new Toolset(),
            };
            // Make the request
            Toolset response = agentServiceClient.CreateToolset(request);
            // End snippet
        }

        /// <summary>Snippet for CreateToolsetAsync</summary>
        public async Task CreateToolsetRequestObjectAsync()
        {
            // Snippet: CreateToolsetAsync(CreateToolsetRequest, CallSettings)
            // Additional: CreateToolsetAsync(CreateToolsetRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateToolsetRequest request = new CreateToolsetRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ToolsetId = "",
                Toolset = new Toolset(),
            };
            // Make the request
            Toolset response = await agentServiceClient.CreateToolsetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateToolset</summary>
        public void CreateToolset1()
        {
            // Snippet: CreateToolset(string, Toolset, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Toolset toolset = new Toolset();
            string toolsetId = "";
            // Make the request
            Toolset response = agentServiceClient.CreateToolset(parent, toolset, toolsetId);
            // End snippet
        }

        /// <summary>Snippet for CreateToolsetAsync</summary>
        public async Task CreateToolset1Async()
        {
            // Snippet: CreateToolsetAsync(string, Toolset, string, CallSettings)
            // Additional: CreateToolsetAsync(string, Toolset, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Toolset toolset = new Toolset();
            string toolsetId = "";
            // Make the request
            Toolset response = await agentServiceClient.CreateToolsetAsync(parent, toolset, toolsetId);
            // End snippet
        }

        /// <summary>Snippet for CreateToolset</summary>
        public void CreateToolset1ResourceNames()
        {
            // Snippet: CreateToolset(AppName, Toolset, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Toolset toolset = new Toolset();
            string toolsetId = "";
            // Make the request
            Toolset response = agentServiceClient.CreateToolset(parent, toolset, toolsetId);
            // End snippet
        }

        /// <summary>Snippet for CreateToolsetAsync</summary>
        public async Task CreateToolset1ResourceNamesAsync()
        {
            // Snippet: CreateToolsetAsync(AppName, Toolset, string, CallSettings)
            // Additional: CreateToolsetAsync(AppName, Toolset, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Toolset toolset = new Toolset();
            string toolsetId = "";
            // Make the request
            Toolset response = await agentServiceClient.CreateToolsetAsync(parent, toolset, toolsetId);
            // End snippet
        }

        /// <summary>Snippet for CreateToolset</summary>
        public void CreateToolset2()
        {
            // Snippet: CreateToolset(string, Toolset, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Toolset toolset = new Toolset();
            // Make the request
            Toolset response = agentServiceClient.CreateToolset(parent, toolset);
            // End snippet
        }

        /// <summary>Snippet for CreateToolsetAsync</summary>
        public async Task CreateToolset2Async()
        {
            // Snippet: CreateToolsetAsync(string, Toolset, CallSettings)
            // Additional: CreateToolsetAsync(string, Toolset, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Toolset toolset = new Toolset();
            // Make the request
            Toolset response = await agentServiceClient.CreateToolsetAsync(parent, toolset);
            // End snippet
        }

        /// <summary>Snippet for CreateToolset</summary>
        public void CreateToolset2ResourceNames()
        {
            // Snippet: CreateToolset(AppName, Toolset, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Toolset toolset = new Toolset();
            // Make the request
            Toolset response = agentServiceClient.CreateToolset(parent, toolset);
            // End snippet
        }

        /// <summary>Snippet for CreateToolsetAsync</summary>
        public async Task CreateToolset2ResourceNamesAsync()
        {
            // Snippet: CreateToolsetAsync(AppName, Toolset, CallSettings)
            // Additional: CreateToolsetAsync(AppName, Toolset, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Toolset toolset = new Toolset();
            // Make the request
            Toolset response = await agentServiceClient.CreateToolsetAsync(parent, toolset);
            // End snippet
        }

        /// <summary>Snippet for UpdateToolset</summary>
        public void UpdateToolsetRequestObject()
        {
            // Snippet: UpdateToolset(UpdateToolsetRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            UpdateToolsetRequest request = new UpdateToolsetRequest
            {
                Toolset = new Toolset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Toolset response = agentServiceClient.UpdateToolset(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateToolsetAsync</summary>
        public async Task UpdateToolsetRequestObjectAsync()
        {
            // Snippet: UpdateToolsetAsync(UpdateToolsetRequest, CallSettings)
            // Additional: UpdateToolsetAsync(UpdateToolsetRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateToolsetRequest request = new UpdateToolsetRequest
            {
                Toolset = new Toolset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Toolset response = await agentServiceClient.UpdateToolsetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateToolset</summary>
        public void UpdateToolset()
        {
            // Snippet: UpdateToolset(Toolset, FieldMask, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            Toolset toolset = new Toolset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Toolset response = agentServiceClient.UpdateToolset(toolset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateToolsetAsync</summary>
        public async Task UpdateToolsetAsync()
        {
            // Snippet: UpdateToolsetAsync(Toolset, FieldMask, CallSettings)
            // Additional: UpdateToolsetAsync(Toolset, FieldMask, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Toolset toolset = new Toolset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Toolset response = await agentServiceClient.UpdateToolsetAsync(toolset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolset</summary>
        public void DeleteToolsetRequestObject()
        {
            // Snippet: DeleteToolset(DeleteToolsetRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            DeleteToolsetRequest request = new DeleteToolsetRequest
            {
                ToolsetName = ToolsetName.FromProjectLocationAppToolset("[PROJECT]", "[LOCATION]", "[APP]", "[TOOLSET]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            agentServiceClient.DeleteToolset(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolsetAsync</summary>
        public async Task DeleteToolsetRequestObjectAsync()
        {
            // Snippet: DeleteToolsetAsync(DeleteToolsetRequest, CallSettings)
            // Additional: DeleteToolsetAsync(DeleteToolsetRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteToolsetRequest request = new DeleteToolsetRequest
            {
                ToolsetName = ToolsetName.FromProjectLocationAppToolset("[PROJECT]", "[LOCATION]", "[APP]", "[TOOLSET]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            await agentServiceClient.DeleteToolsetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolset</summary>
        public void DeleteToolset()
        {
            // Snippet: DeleteToolset(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/toolsets/[TOOLSET]";
            // Make the request
            agentServiceClient.DeleteToolset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolsetAsync</summary>
        public async Task DeleteToolsetAsync()
        {
            // Snippet: DeleteToolsetAsync(string, CallSettings)
            // Additional: DeleteToolsetAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/toolsets/[TOOLSET]";
            // Make the request
            await agentServiceClient.DeleteToolsetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolset</summary>
        public void DeleteToolsetResourceNames()
        {
            // Snippet: DeleteToolset(ToolsetName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ToolsetName name = ToolsetName.FromProjectLocationAppToolset("[PROJECT]", "[LOCATION]", "[APP]", "[TOOLSET]");
            // Make the request
            agentServiceClient.DeleteToolset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteToolsetAsync</summary>
        public async Task DeleteToolsetResourceNamesAsync()
        {
            // Snippet: DeleteToolsetAsync(ToolsetName, CallSettings)
            // Additional: DeleteToolsetAsync(ToolsetName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ToolsetName name = ToolsetName.FromProjectLocationAppToolset("[PROJECT]", "[LOCATION]", "[APP]", "[TOOLSET]");
            // Make the request
            await agentServiceClient.DeleteToolsetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAppVersions</summary>
        public void ListAppVersionsRequestObject()
        {
            // Snippet: ListAppVersions(ListAppVersionsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ListAppVersionsRequest request = new ListAppVersionsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAppVersionsResponse, AppVersion> response = agentServiceClient.ListAppVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppVersionsAsync</summary>
        public async Task ListAppVersionsRequestObjectAsync()
        {
            // Snippet: ListAppVersionsAsync(ListAppVersionsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAppVersionsRequest request = new ListAppVersionsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAppVersionsResponse, AppVersion> response = agentServiceClient.ListAppVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AppVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAppVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppVersions</summary>
        public void ListAppVersions()
        {
            // Snippet: ListAppVersions(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListAppVersionsResponse, AppVersion> response = agentServiceClient.ListAppVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppVersionsAsync</summary>
        public async Task ListAppVersionsAsync()
        {
            // Snippet: ListAppVersionsAsync(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListAppVersionsResponse, AppVersion> response = agentServiceClient.ListAppVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AppVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAppVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppVersions</summary>
        public void ListAppVersionsResourceNames()
        {
            // Snippet: ListAppVersions(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListAppVersionsResponse, AppVersion> response = agentServiceClient.ListAppVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppVersionsAsync</summary>
        public async Task ListAppVersionsResourceNamesAsync()
        {
            // Snippet: ListAppVersionsAsync(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListAppVersionsResponse, AppVersion> response = agentServiceClient.ListAppVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AppVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAppVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAppVersion</summary>
        public void GetAppVersionRequestObject()
        {
            // Snippet: GetAppVersion(GetAppVersionRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GetAppVersionRequest request = new GetAppVersionRequest
            {
                AppVersionName = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]"),
            };
            // Make the request
            AppVersion response = agentServiceClient.GetAppVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppVersionAsync</summary>
        public async Task GetAppVersionRequestObjectAsync()
        {
            // Snippet: GetAppVersionAsync(GetAppVersionRequest, CallSettings)
            // Additional: GetAppVersionAsync(GetAppVersionRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAppVersionRequest request = new GetAppVersionRequest
            {
                AppVersionName = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]"),
            };
            // Make the request
            AppVersion response = await agentServiceClient.GetAppVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppVersion</summary>
        public void GetAppVersion()
        {
            // Snippet: GetAppVersion(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/versions/[VERSION]";
            // Make the request
            AppVersion response = agentServiceClient.GetAppVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppVersionAsync</summary>
        public async Task GetAppVersionAsync()
        {
            // Snippet: GetAppVersionAsync(string, CallSettings)
            // Additional: GetAppVersionAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/versions/[VERSION]";
            // Make the request
            AppVersion response = await agentServiceClient.GetAppVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppVersion</summary>
        public void GetAppVersionResourceNames()
        {
            // Snippet: GetAppVersion(AppVersionName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppVersionName name = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]");
            // Make the request
            AppVersion response = agentServiceClient.GetAppVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppVersionAsync</summary>
        public async Task GetAppVersionResourceNamesAsync()
        {
            // Snippet: GetAppVersionAsync(AppVersionName, CallSettings)
            // Additional: GetAppVersionAsync(AppVersionName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppVersionName name = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]");
            // Make the request
            AppVersion response = await agentServiceClient.GetAppVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAppVersion</summary>
        public void CreateAppVersionRequestObject()
        {
            // Snippet: CreateAppVersion(CreateAppVersionRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            CreateAppVersionRequest request = new CreateAppVersionRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AppVersionId = "",
                AppVersion = new AppVersion(),
            };
            // Make the request
            AppVersion response = agentServiceClient.CreateAppVersion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAppVersionAsync</summary>
        public async Task CreateAppVersionRequestObjectAsync()
        {
            // Snippet: CreateAppVersionAsync(CreateAppVersionRequest, CallSettings)
            // Additional: CreateAppVersionAsync(CreateAppVersionRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAppVersionRequest request = new CreateAppVersionRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AppVersionId = "",
                AppVersion = new AppVersion(),
            };
            // Make the request
            AppVersion response = await agentServiceClient.CreateAppVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAppVersion</summary>
        public void CreateAppVersion1()
        {
            // Snippet: CreateAppVersion(string, AppVersion, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            AppVersion appVersion = new AppVersion();
            string appVersionId = "";
            // Make the request
            AppVersion response = agentServiceClient.CreateAppVersion(parent, appVersion, appVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateAppVersionAsync</summary>
        public async Task CreateAppVersion1Async()
        {
            // Snippet: CreateAppVersionAsync(string, AppVersion, string, CallSettings)
            // Additional: CreateAppVersionAsync(string, AppVersion, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            AppVersion appVersion = new AppVersion();
            string appVersionId = "";
            // Make the request
            AppVersion response = await agentServiceClient.CreateAppVersionAsync(parent, appVersion, appVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateAppVersion</summary>
        public void CreateAppVersion1ResourceNames()
        {
            // Snippet: CreateAppVersion(AppName, AppVersion, string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            AppVersion appVersion = new AppVersion();
            string appVersionId = "";
            // Make the request
            AppVersion response = agentServiceClient.CreateAppVersion(parent, appVersion, appVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateAppVersionAsync</summary>
        public async Task CreateAppVersion1ResourceNamesAsync()
        {
            // Snippet: CreateAppVersionAsync(AppName, AppVersion, string, CallSettings)
            // Additional: CreateAppVersionAsync(AppName, AppVersion, string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            AppVersion appVersion = new AppVersion();
            string appVersionId = "";
            // Make the request
            AppVersion response = await agentServiceClient.CreateAppVersionAsync(parent, appVersion, appVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateAppVersion</summary>
        public void CreateAppVersion2()
        {
            // Snippet: CreateAppVersion(string, AppVersion, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            AppVersion appVersion = new AppVersion();
            // Make the request
            AppVersion response = agentServiceClient.CreateAppVersion(parent, appVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateAppVersionAsync</summary>
        public async Task CreateAppVersion2Async()
        {
            // Snippet: CreateAppVersionAsync(string, AppVersion, CallSettings)
            // Additional: CreateAppVersionAsync(string, AppVersion, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            AppVersion appVersion = new AppVersion();
            // Make the request
            AppVersion response = await agentServiceClient.CreateAppVersionAsync(parent, appVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateAppVersion</summary>
        public void CreateAppVersion2ResourceNames()
        {
            // Snippet: CreateAppVersion(AppName, AppVersion, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            AppVersion appVersion = new AppVersion();
            // Make the request
            AppVersion response = agentServiceClient.CreateAppVersion(parent, appVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateAppVersionAsync</summary>
        public async Task CreateAppVersion2ResourceNamesAsync()
        {
            // Snippet: CreateAppVersionAsync(AppName, AppVersion, CallSettings)
            // Additional: CreateAppVersionAsync(AppName, AppVersion, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            AppVersion appVersion = new AppVersion();
            // Make the request
            AppVersion response = await agentServiceClient.CreateAppVersionAsync(parent, appVersion);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppVersion</summary>
        public void DeleteAppVersionRequestObject()
        {
            // Snippet: DeleteAppVersion(DeleteAppVersionRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            DeleteAppVersionRequest request = new DeleteAppVersionRequest
            {
                AppVersionName = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]"),
                Etag = "",
            };
            // Make the request
            agentServiceClient.DeleteAppVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppVersionAsync</summary>
        public async Task DeleteAppVersionRequestObjectAsync()
        {
            // Snippet: DeleteAppVersionAsync(DeleteAppVersionRequest, CallSettings)
            // Additional: DeleteAppVersionAsync(DeleteAppVersionRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAppVersionRequest request = new DeleteAppVersionRequest
            {
                AppVersionName = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]"),
                Etag = "",
            };
            // Make the request
            await agentServiceClient.DeleteAppVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppVersion</summary>
        public void DeleteAppVersion()
        {
            // Snippet: DeleteAppVersion(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/versions/[VERSION]";
            // Make the request
            agentServiceClient.DeleteAppVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppVersionAsync</summary>
        public async Task DeleteAppVersionAsync()
        {
            // Snippet: DeleteAppVersionAsync(string, CallSettings)
            // Additional: DeleteAppVersionAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/versions/[VERSION]";
            // Make the request
            await agentServiceClient.DeleteAppVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppVersion</summary>
        public void DeleteAppVersionResourceNames()
        {
            // Snippet: DeleteAppVersion(AppVersionName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppVersionName name = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]");
            // Make the request
            agentServiceClient.DeleteAppVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppVersionAsync</summary>
        public async Task DeleteAppVersionResourceNamesAsync()
        {
            // Snippet: DeleteAppVersionAsync(AppVersionName, CallSettings)
            // Additional: DeleteAppVersionAsync(AppVersionName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppVersionName name = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]");
            // Make the request
            await agentServiceClient.DeleteAppVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreAppVersion</summary>
        public void RestoreAppVersionRequestObject()
        {
            // Snippet: RestoreAppVersion(RestoreAppVersionRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            RestoreAppVersionRequest request = new RestoreAppVersionRequest
            {
                AppVersionName = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]"),
            };
            // Make the request
            Operation<RestoreAppVersionResponse, OperationMetadata> response = agentServiceClient.RestoreAppVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<RestoreAppVersionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RestoreAppVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreAppVersionResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceRestoreAppVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreAppVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAppVersionAsync</summary>
        public async Task RestoreAppVersionRequestObjectAsync()
        {
            // Snippet: RestoreAppVersionAsync(RestoreAppVersionRequest, CallSettings)
            // Additional: RestoreAppVersionAsync(RestoreAppVersionRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            RestoreAppVersionRequest request = new RestoreAppVersionRequest
            {
                AppVersionName = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]"),
            };
            // Make the request
            Operation<RestoreAppVersionResponse, OperationMetadata> response = await agentServiceClient.RestoreAppVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RestoreAppVersionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestoreAppVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreAppVersionResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceRestoreAppVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreAppVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAppVersion</summary>
        public void RestoreAppVersion()
        {
            // Snippet: RestoreAppVersion(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/versions/[VERSION]";
            // Make the request
            Operation<RestoreAppVersionResponse, OperationMetadata> response = agentServiceClient.RestoreAppVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<RestoreAppVersionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RestoreAppVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreAppVersionResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceRestoreAppVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreAppVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAppVersionAsync</summary>
        public async Task RestoreAppVersionAsync()
        {
            // Snippet: RestoreAppVersionAsync(string, CallSettings)
            // Additional: RestoreAppVersionAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/versions/[VERSION]";
            // Make the request
            Operation<RestoreAppVersionResponse, OperationMetadata> response = await agentServiceClient.RestoreAppVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<RestoreAppVersionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestoreAppVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreAppVersionResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceRestoreAppVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreAppVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAppVersion</summary>
        public void RestoreAppVersionResourceNames()
        {
            // Snippet: RestoreAppVersion(AppVersionName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppVersionName name = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]");
            // Make the request
            Operation<RestoreAppVersionResponse, OperationMetadata> response = agentServiceClient.RestoreAppVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<RestoreAppVersionResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RestoreAppVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreAppVersionResponse, OperationMetadata> retrievedResponse = agentServiceClient.PollOnceRestoreAppVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreAppVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAppVersionAsync</summary>
        public async Task RestoreAppVersionResourceNamesAsync()
        {
            // Snippet: RestoreAppVersionAsync(AppVersionName, CallSettings)
            // Additional: RestoreAppVersionAsync(AppVersionName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppVersionName name = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]");
            // Make the request
            Operation<RestoreAppVersionResponse, OperationMetadata> response = await agentServiceClient.RestoreAppVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<RestoreAppVersionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestoreAppVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreAppVersionResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceRestoreAppVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreAppVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListChangelogs</summary>
        public void ListChangelogsRequestObject()
        {
            // Snippet: ListChangelogs(ListChangelogsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ListChangelogsRequest request = new ListChangelogsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListChangelogsResponse, Changelog> response = agentServiceClient.ListChangelogs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Changelog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangelogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangelogsAsync</summary>
        public async Task ListChangelogsRequestObjectAsync()
        {
            // Snippet: ListChangelogsAsync(ListChangelogsRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListChangelogsRequest request = new ListChangelogsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListChangelogsResponse, Changelog> response = agentServiceClient.ListChangelogsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Changelog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListChangelogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangelogs</summary>
        public void ListChangelogs()
        {
            // Snippet: ListChangelogs(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListChangelogsResponse, Changelog> response = agentServiceClient.ListChangelogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Changelog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangelogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangelogsAsync</summary>
        public async Task ListChangelogsAsync()
        {
            // Snippet: ListChangelogsAsync(string, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListChangelogsResponse, Changelog> response = agentServiceClient.ListChangelogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Changelog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListChangelogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangelogs</summary>
        public void ListChangelogsResourceNames()
        {
            // Snippet: ListChangelogs(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListChangelogsResponse, Changelog> response = agentServiceClient.ListChangelogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Changelog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangelogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangelogsAsync</summary>
        public async Task ListChangelogsResourceNamesAsync()
        {
            // Snippet: ListChangelogsAsync(AppName, string, int?, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListChangelogsResponse, Changelog> response = agentServiceClient.ListChangelogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Changelog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListChangelogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetChangelog</summary>
        public void GetChangelogRequestObject()
        {
            // Snippet: GetChangelog(GetChangelogRequest, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            GetChangelogRequest request = new GetChangelogRequest
            {
                ChangelogName = ChangelogName.FromProjectLocationAppChangelog("[PROJECT]", "[LOCATION]", "[APP]", "[CHANGELOG]"),
            };
            // Make the request
            Changelog response = agentServiceClient.GetChangelog(request);
            // End snippet
        }

        /// <summary>Snippet for GetChangelogAsync</summary>
        public async Task GetChangelogRequestObjectAsync()
        {
            // Snippet: GetChangelogAsync(GetChangelogRequest, CallSettings)
            // Additional: GetChangelogAsync(GetChangelogRequest, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetChangelogRequest request = new GetChangelogRequest
            {
                ChangelogName = ChangelogName.FromProjectLocationAppChangelog("[PROJECT]", "[LOCATION]", "[APP]", "[CHANGELOG]"),
            };
            // Make the request
            Changelog response = await agentServiceClient.GetChangelogAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetChangelog</summary>
        public void GetChangelog()
        {
            // Snippet: GetChangelog(string, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/changelogs/[CHANGELOG]";
            // Make the request
            Changelog response = agentServiceClient.GetChangelog(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangelogAsync</summary>
        public async Task GetChangelogAsync()
        {
            // Snippet: GetChangelogAsync(string, CallSettings)
            // Additional: GetChangelogAsync(string, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/changelogs/[CHANGELOG]";
            // Make the request
            Changelog response = await agentServiceClient.GetChangelogAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangelog</summary>
        public void GetChangelogResourceNames()
        {
            // Snippet: GetChangelog(ChangelogName, CallSettings)
            // Create client
            AgentServiceClient agentServiceClient = AgentServiceClient.Create();
            // Initialize request argument(s)
            ChangelogName name = ChangelogName.FromProjectLocationAppChangelog("[PROJECT]", "[LOCATION]", "[APP]", "[CHANGELOG]");
            // Make the request
            Changelog response = agentServiceClient.GetChangelog(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangelogAsync</summary>
        public async Task GetChangelogResourceNamesAsync()
        {
            // Snippet: GetChangelogAsync(ChangelogName, CallSettings)
            // Additional: GetChangelogAsync(ChangelogName, CancellationToken)
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChangelogName name = ChangelogName.FromProjectLocationAppChangelog("[PROJECT]", "[LOCATION]", "[APP]", "[CHANGELOG]");
            // Make the request
            Changelog response = await agentServiceClient.GetChangelogAsync(name);
            // End snippet
        }
    }
}
