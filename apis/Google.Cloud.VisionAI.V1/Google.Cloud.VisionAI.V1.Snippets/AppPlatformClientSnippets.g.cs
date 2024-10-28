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
    using Google.Cloud.VisionAI.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAppPlatformClientSnippets
    {
        /// <summary>Snippet for ListApplications</summary>
        public void ListApplicationsRequestObject()
        {
            // Snippet: ListApplications(ListApplicationsRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = appPlatformClient.ListApplications(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsRequestObjectAsync()
        {
            // Snippet: ListApplicationsAsync(ListApplicationsRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = appPlatformClient.ListApplicationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplications()
        {
            // Snippet: ListApplications(string, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = appPlatformClient.ListApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsAsync()
        {
            // Snippet: ListApplicationsAsync(string, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = appPlatformClient.ListApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplicationsResourceNames()
        {
            // Snippet: ListApplications(LocationName, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = appPlatformClient.ListApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsResourceNamesAsync()
        {
            // Snippet: ListApplicationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = appPlatformClient.ListApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplicationRequestObject()
        {
            // Snippet: GetApplication(GetApplicationRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
            };
            // Make the request
            Application response = appPlatformClient.GetApplication(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationRequestObjectAsync()
        {
            // Snippet: GetApplicationAsync(GetApplicationRequest, CallSettings)
            // Additional: GetApplicationAsync(GetApplicationRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
            };
            // Make the request
            Application response = await appPlatformClient.GetApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplication()
        {
            // Snippet: GetApplication(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Application response = appPlatformClient.GetApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationAsync()
        {
            // Snippet: GetApplicationAsync(string, CallSettings)
            // Additional: GetApplicationAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Application response = await appPlatformClient.GetApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplicationResourceNames()
        {
            // Snippet: GetApplication(ApplicationName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Application response = appPlatformClient.GetApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationResourceNamesAsync()
        {
            // Snippet: GetApplicationAsync(ApplicationName, CallSettings)
            // Additional: GetApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Application response = await appPlatformClient.GetApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplicationRequestObject()
        {
            // Snippet: CreateApplication(CreateApplicationRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ApplicationId = "",
                Application = new Application(),
                RequestId = "",
            };
            // Make the request
            Operation<Application, OperationMetadata> response = appPlatformClient.CreateApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationRequestObjectAsync()
        {
            // Snippet: CreateApplicationAsync(CreateApplicationRequest, CallSettings)
            // Additional: CreateApplicationAsync(CreateApplicationRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ApplicationId = "",
                Application = new Application(),
                RequestId = "",
            };
            // Make the request
            Operation<Application, OperationMetadata> response = await appPlatformClient.CreateApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplication()
        {
            // Snippet: CreateApplication(string, Application, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Application application = new Application();
            // Make the request
            Operation<Application, OperationMetadata> response = appPlatformClient.CreateApplication(parent, application);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationAsync()
        {
            // Snippet: CreateApplicationAsync(string, Application, CallSettings)
            // Additional: CreateApplicationAsync(string, Application, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Application application = new Application();
            // Make the request
            Operation<Application, OperationMetadata> response = await appPlatformClient.CreateApplicationAsync(parent, application);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplicationResourceNames()
        {
            // Snippet: CreateApplication(LocationName, Application, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Application application = new Application();
            // Make the request
            Operation<Application, OperationMetadata> response = appPlatformClient.CreateApplication(parent, application);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationResourceNamesAsync()
        {
            // Snippet: CreateApplicationAsync(LocationName, Application, CallSettings)
            // Additional: CreateApplicationAsync(LocationName, Application, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Application application = new Application();
            // Make the request
            Operation<Application, OperationMetadata> response = await appPlatformClient.CreateApplicationAsync(parent, application);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplication</summary>
        public void UpdateApplicationRequestObject()
        {
            // Snippet: UpdateApplication(UpdateApplicationRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                UpdateMask = new FieldMask(),
                Application = new Application(),
                RequestId = "",
            };
            // Make the request
            Operation<Application, OperationMetadata> response = appPlatformClient.UpdateApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationAsync</summary>
        public async Task UpdateApplicationRequestObjectAsync()
        {
            // Snippet: UpdateApplicationAsync(UpdateApplicationRequest, CallSettings)
            // Additional: UpdateApplicationAsync(UpdateApplicationRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                UpdateMask = new FieldMask(),
                Application = new Application(),
                RequestId = "",
            };
            // Make the request
            Operation<Application, OperationMetadata> response = await appPlatformClient.UpdateApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplication</summary>
        public void UpdateApplication()
        {
            // Snippet: UpdateApplication(Application, FieldMask, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            Application application = new Application();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Application, OperationMetadata> response = appPlatformClient.UpdateApplication(application, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationAsync</summary>
        public async Task UpdateApplicationAsync()
        {
            // Snippet: UpdateApplicationAsync(Application, FieldMask, CallSettings)
            // Additional: UpdateApplicationAsync(Application, FieldMask, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            Application application = new Application();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Application, OperationMetadata> response = await appPlatformClient.UpdateApplicationAsync(application, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplicationRequestObject()
        {
            // Snippet: DeleteApplication(DeleteApplicationRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = appPlatformClient.DeleteApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationRequestObjectAsync()
        {
            // Snippet: DeleteApplicationAsync(DeleteApplicationRequest, CallSettings)
            // Additional: DeleteApplicationAsync(DeleteApplicationRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await appPlatformClient.DeleteApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplication()
        {
            // Snippet: DeleteApplication(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = appPlatformClient.DeleteApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationAsync()
        {
            // Snippet: DeleteApplicationAsync(string, CallSettings)
            // Additional: DeleteApplicationAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await appPlatformClient.DeleteApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplicationResourceNames()
        {
            // Snippet: DeleteApplication(ApplicationName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = appPlatformClient.DeleteApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationResourceNamesAsync()
        {
            // Snippet: DeleteApplicationAsync(ApplicationName, CallSettings)
            // Additional: DeleteApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await appPlatformClient.DeleteApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplication</summary>
        public void DeployApplicationRequestObject()
        {
            // Snippet: DeployApplication(DeployApplicationRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            DeployApplicationRequest request = new DeployApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ValidateOnly = false,
                RequestId = "",
                EnableMonitoring = false,
            };
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = appPlatformClient.DeployApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeployApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplicationAsync</summary>
        public async Task DeployApplicationRequestObjectAsync()
        {
            // Snippet: DeployApplicationAsync(DeployApplicationRequest, CallSettings)
            // Additional: DeployApplicationAsync(DeployApplicationRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            DeployApplicationRequest request = new DeployApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ValidateOnly = false,
                RequestId = "",
                EnableMonitoring = false,
            };
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = await appPlatformClient.DeployApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeployApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplication</summary>
        public void DeployApplication()
        {
            // Snippet: DeployApplication(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = appPlatformClient.DeployApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeployApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplicationAsync</summary>
        public async Task DeployApplicationAsync()
        {
            // Snippet: DeployApplicationAsync(string, CallSettings)
            // Additional: DeployApplicationAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = await appPlatformClient.DeployApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeployApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplication</summary>
        public void DeployApplicationResourceNames()
        {
            // Snippet: DeployApplication(ApplicationName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = appPlatformClient.DeployApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeployApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployApplicationAsync</summary>
        public async Task DeployApplicationResourceNamesAsync()
        {
            // Snippet: DeployApplicationAsync(ApplicationName, CallSettings)
            // Additional: DeployApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<DeployApplicationResponse, OperationMetadata> response = await appPlatformClient.DeployApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployApplicationResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeployApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployApplication</summary>
        public void UndeployApplicationRequestObject()
        {
            // Snippet: UndeployApplication(UndeployApplicationRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            UndeployApplicationRequest request = new UndeployApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<UndeployApplicationResponse, OperationMetadata> response = appPlatformClient.UndeployApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeployApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployApplicationResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUndeployApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployApplicationAsync</summary>
        public async Task UndeployApplicationRequestObjectAsync()
        {
            // Snippet: UndeployApplicationAsync(UndeployApplicationRequest, CallSettings)
            // Additional: UndeployApplicationAsync(UndeployApplicationRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            UndeployApplicationRequest request = new UndeployApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<UndeployApplicationResponse, OperationMetadata> response = await appPlatformClient.UndeployApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeployApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployApplicationResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUndeployApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployApplication</summary>
        public void UndeployApplication()
        {
            // Snippet: UndeployApplication(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<UndeployApplicationResponse, OperationMetadata> response = appPlatformClient.UndeployApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployApplicationResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUndeployApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployApplicationAsync</summary>
        public async Task UndeployApplicationAsync()
        {
            // Snippet: UndeployApplicationAsync(string, CallSettings)
            // Additional: UndeployApplicationAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<UndeployApplicationResponse, OperationMetadata> response = await appPlatformClient.UndeployApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployApplicationResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUndeployApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployApplication</summary>
        public void UndeployApplicationResourceNames()
        {
            // Snippet: UndeployApplication(ApplicationName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<UndeployApplicationResponse, OperationMetadata> response = appPlatformClient.UndeployApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployApplicationResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployApplicationResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUndeployApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployApplicationAsync</summary>
        public async Task UndeployApplicationResourceNamesAsync()
        {
            // Snippet: UndeployApplicationAsync(ApplicationName, CallSettings)
            // Additional: UndeployApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<UndeployApplicationResponse, OperationMetadata> response = await appPlatformClient.UndeployApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployApplicationResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployApplicationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployApplicationResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUndeployApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployApplicationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddApplicationStreamInput</summary>
        public void AddApplicationStreamInputRequestObject()
        {
            // Snippet: AddApplicationStreamInput(AddApplicationStreamInputRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            AddApplicationStreamInputRequest request = new AddApplicationStreamInputRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ApplicationStreamInputs =
                {
                    new ApplicationStreamInput(),
                },
                RequestId = "",
            };
            // Make the request
            Operation<AddApplicationStreamInputResponse, OperationMetadata> response = appPlatformClient.AddApplicationStreamInput(request);

            // Poll until the returned long-running operation is complete
            Operation<AddApplicationStreamInputResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddApplicationStreamInputResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceAddApplicationStreamInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddApplicationStreamInputAsync</summary>
        public async Task AddApplicationStreamInputRequestObjectAsync()
        {
            // Snippet: AddApplicationStreamInputAsync(AddApplicationStreamInputRequest, CallSettings)
            // Additional: AddApplicationStreamInputAsync(AddApplicationStreamInputRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            AddApplicationStreamInputRequest request = new AddApplicationStreamInputRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ApplicationStreamInputs =
                {
                    new ApplicationStreamInput(),
                },
                RequestId = "",
            };
            // Make the request
            Operation<AddApplicationStreamInputResponse, OperationMetadata> response = await appPlatformClient.AddApplicationStreamInputAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AddApplicationStreamInputResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddApplicationStreamInputResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceAddApplicationStreamInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddApplicationStreamInput</summary>
        public void AddApplicationStreamInput()
        {
            // Snippet: AddApplicationStreamInput(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<AddApplicationStreamInputResponse, OperationMetadata> response = appPlatformClient.AddApplicationStreamInput(name);

            // Poll until the returned long-running operation is complete
            Operation<AddApplicationStreamInputResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddApplicationStreamInputResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceAddApplicationStreamInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddApplicationStreamInputAsync</summary>
        public async Task AddApplicationStreamInputAsync()
        {
            // Snippet: AddApplicationStreamInputAsync(string, CallSettings)
            // Additional: AddApplicationStreamInputAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<AddApplicationStreamInputResponse, OperationMetadata> response = await appPlatformClient.AddApplicationStreamInputAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<AddApplicationStreamInputResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddApplicationStreamInputResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceAddApplicationStreamInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddApplicationStreamInput</summary>
        public void AddApplicationStreamInputResourceNames()
        {
            // Snippet: AddApplicationStreamInput(ApplicationName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<AddApplicationStreamInputResponse, OperationMetadata> response = appPlatformClient.AddApplicationStreamInput(name);

            // Poll until the returned long-running operation is complete
            Operation<AddApplicationStreamInputResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddApplicationStreamInputResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceAddApplicationStreamInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddApplicationStreamInputAsync</summary>
        public async Task AddApplicationStreamInputResourceNamesAsync()
        {
            // Snippet: AddApplicationStreamInputAsync(ApplicationName, CallSettings)
            // Additional: AddApplicationStreamInputAsync(ApplicationName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<AddApplicationStreamInputResponse, OperationMetadata> response = await appPlatformClient.AddApplicationStreamInputAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<AddApplicationStreamInputResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddApplicationStreamInputResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceAddApplicationStreamInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveApplicationStreamInput</summary>
        public void RemoveApplicationStreamInputRequestObject()
        {
            // Snippet: RemoveApplicationStreamInput(RemoveApplicationStreamInputRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            RemoveApplicationStreamInputRequest request = new RemoveApplicationStreamInputRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                TargetStreamInputs =
                {
                    new RemoveApplicationStreamInputRequest.Types.TargetStreamInput(),
                },
                RequestId = "",
            };
            // Make the request
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> response = appPlatformClient.RemoveApplicationStreamInput(request);

            // Poll until the returned long-running operation is complete
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceRemoveApplicationStreamInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveApplicationStreamInputAsync</summary>
        public async Task RemoveApplicationStreamInputRequestObjectAsync()
        {
            // Snippet: RemoveApplicationStreamInputAsync(RemoveApplicationStreamInputRequest, CallSettings)
            // Additional: RemoveApplicationStreamInputAsync(RemoveApplicationStreamInputRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            RemoveApplicationStreamInputRequest request = new RemoveApplicationStreamInputRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                TargetStreamInputs =
                {
                    new RemoveApplicationStreamInputRequest.Types.TargetStreamInput(),
                },
                RequestId = "",
            };
            // Make the request
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> response = await appPlatformClient.RemoveApplicationStreamInputAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceRemoveApplicationStreamInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveApplicationStreamInput</summary>
        public void RemoveApplicationStreamInput()
        {
            // Snippet: RemoveApplicationStreamInput(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> response = appPlatformClient.RemoveApplicationStreamInput(name);

            // Poll until the returned long-running operation is complete
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceRemoveApplicationStreamInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveApplicationStreamInputAsync</summary>
        public async Task RemoveApplicationStreamInputAsync()
        {
            // Snippet: RemoveApplicationStreamInputAsync(string, CallSettings)
            // Additional: RemoveApplicationStreamInputAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> response = await appPlatformClient.RemoveApplicationStreamInputAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceRemoveApplicationStreamInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveApplicationStreamInput</summary>
        public void RemoveApplicationStreamInputResourceNames()
        {
            // Snippet: RemoveApplicationStreamInput(ApplicationName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> response = appPlatformClient.RemoveApplicationStreamInput(name);

            // Poll until the returned long-running operation is complete
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceRemoveApplicationStreamInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveApplicationStreamInputAsync</summary>
        public async Task RemoveApplicationStreamInputResourceNamesAsync()
        {
            // Snippet: RemoveApplicationStreamInputAsync(ApplicationName, CallSettings)
            // Additional: RemoveApplicationStreamInputAsync(ApplicationName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> response = await appPlatformClient.RemoveApplicationStreamInputAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveApplicationStreamInputResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceRemoveApplicationStreamInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationStreamInput</summary>
        public void UpdateApplicationStreamInputRequestObject()
        {
            // Snippet: UpdateApplicationStreamInput(UpdateApplicationStreamInputRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            UpdateApplicationStreamInputRequest request = new UpdateApplicationStreamInputRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ApplicationStreamInputs =
                {
                    new ApplicationStreamInput(),
                },
                RequestId = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> response = appPlatformClient.UpdateApplicationStreamInput(request);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpdateApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateApplicationStreamInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationStreamInputAsync</summary>
        public async Task UpdateApplicationStreamInputRequestObjectAsync()
        {
            // Snippet: UpdateApplicationStreamInputAsync(UpdateApplicationStreamInputRequest, CallSettings)
            // Additional: UpdateApplicationStreamInputAsync(UpdateApplicationStreamInputRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApplicationStreamInputRequest request = new UpdateApplicationStreamInputRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ApplicationStreamInputs =
                {
                    new ApplicationStreamInput(),
                },
                RequestId = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> response = await appPlatformClient.UpdateApplicationStreamInputAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpdateApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateApplicationStreamInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationStreamInput</summary>
        public void UpdateApplicationStreamInput()
        {
            // Snippet: UpdateApplicationStreamInput(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> response = appPlatformClient.UpdateApplicationStreamInput(name);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpdateApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateApplicationStreamInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationStreamInputAsync</summary>
        public async Task UpdateApplicationStreamInputAsync()
        {
            // Snippet: UpdateApplicationStreamInputAsync(string, CallSettings)
            // Additional: UpdateApplicationStreamInputAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> response = await appPlatformClient.UpdateApplicationStreamInputAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpdateApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateApplicationStreamInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationStreamInput</summary>
        public void UpdateApplicationStreamInputResourceNames()
        {
            // Snippet: UpdateApplicationStreamInput(ApplicationName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> response = appPlatformClient.UpdateApplicationStreamInput(name);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpdateApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateApplicationStreamInput(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationStreamInputAsync</summary>
        public async Task UpdateApplicationStreamInputResourceNamesAsync()
        {
            // Snippet: UpdateApplicationStreamInputAsync(ApplicationName, CallSettings)
            // Additional: UpdateApplicationStreamInputAsync(ApplicationName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> response = await appPlatformClient.UpdateApplicationStreamInputAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpdateApplicationStreamInputResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationStreamInputResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateApplicationStreamInputAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationStreamInputResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = appPlatformClient.ListInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesRequestObjectAsync()
        {
            // Snippet: ListInstancesAsync(ListInstancesRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = appPlatformClient.ListInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(string, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = appPlatformClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(string, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = appPlatformClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesResourceNames()
        {
            // Snippet: ListInstances(ApplicationName, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = appPlatformClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesResourceNamesAsync()
        {
            // Snippet: ListInstancesAsync(ApplicationName, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = appPlatformClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceRequestObject()
        {
            // Snippet: GetInstance(GetInstanceRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationApplicationInstance("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = appPlatformClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationApplicationInstance("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await appPlatformClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = appPlatformClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = await appPlatformClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationApplicationInstance("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[INSTANCE]");
            // Make the request
            Instance response = appPlatformClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationApplicationInstance("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[INSTANCE]");
            // Make the request
            Instance response = await appPlatformClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationInstances</summary>
        public void CreateApplicationInstancesRequestObject()
        {
            // Snippet: CreateApplicationInstances(CreateApplicationInstancesRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            CreateApplicationInstancesRequest request = new CreateApplicationInstancesRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ApplicationInstances =
                {
                    new ApplicationInstance(),
                },
                RequestId = "",
            };
            // Make the request
            Operation<CreateApplicationInstancesResponse, OperationMetadata> response = appPlatformClient.CreateApplicationInstances(request);

            // Poll until the returned long-running operation is complete
            Operation<CreateApplicationInstancesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CreateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CreateApplicationInstancesResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateApplicationInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CreateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationInstancesAsync</summary>
        public async Task CreateApplicationInstancesRequestObjectAsync()
        {
            // Snippet: CreateApplicationInstancesAsync(CreateApplicationInstancesRequest, CallSettings)
            // Additional: CreateApplicationInstancesAsync(CreateApplicationInstancesRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            CreateApplicationInstancesRequest request = new CreateApplicationInstancesRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ApplicationInstances =
                {
                    new ApplicationInstance(),
                },
                RequestId = "",
            };
            // Make the request
            Operation<CreateApplicationInstancesResponse, OperationMetadata> response = await appPlatformClient.CreateApplicationInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CreateApplicationInstancesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CreateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CreateApplicationInstancesResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateApplicationInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CreateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationInstances</summary>
        public void CreateApplicationInstances()
        {
            // Snippet: CreateApplicationInstances(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<CreateApplicationInstancesResponse, OperationMetadata> response = appPlatformClient.CreateApplicationInstances(name);

            // Poll until the returned long-running operation is complete
            Operation<CreateApplicationInstancesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CreateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CreateApplicationInstancesResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateApplicationInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CreateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationInstancesAsync</summary>
        public async Task CreateApplicationInstancesAsync()
        {
            // Snippet: CreateApplicationInstancesAsync(string, CallSettings)
            // Additional: CreateApplicationInstancesAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<CreateApplicationInstancesResponse, OperationMetadata> response = await appPlatformClient.CreateApplicationInstancesAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CreateApplicationInstancesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CreateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CreateApplicationInstancesResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateApplicationInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CreateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationInstances</summary>
        public void CreateApplicationInstancesResourceNames()
        {
            // Snippet: CreateApplicationInstances(ApplicationName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<CreateApplicationInstancesResponse, OperationMetadata> response = appPlatformClient.CreateApplicationInstances(name);

            // Poll until the returned long-running operation is complete
            Operation<CreateApplicationInstancesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CreateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CreateApplicationInstancesResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateApplicationInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CreateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationInstancesAsync</summary>
        public async Task CreateApplicationInstancesResourceNamesAsync()
        {
            // Snippet: CreateApplicationInstancesAsync(ApplicationName, CallSettings)
            // Additional: CreateApplicationInstancesAsync(ApplicationName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<CreateApplicationInstancesResponse, OperationMetadata> response = await appPlatformClient.CreateApplicationInstancesAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CreateApplicationInstancesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CreateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CreateApplicationInstancesResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateApplicationInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CreateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationInstances</summary>
        public void DeleteApplicationInstancesRequestObject()
        {
            // Snippet: DeleteApplicationInstances(DeleteApplicationInstancesRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            DeleteApplicationInstancesRequest request = new DeleteApplicationInstancesRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                InstanceIdsAsInstanceNames =
                {
                    InstanceName.FromProjectLocationApplicationInstance("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[INSTANCE]"),
                },
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = appPlatformClient.DeleteApplicationInstances(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteApplicationInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationInstancesAsync</summary>
        public async Task DeleteApplicationInstancesRequestObjectAsync()
        {
            // Snippet: DeleteApplicationInstancesAsync(DeleteApplicationInstancesRequest, CallSettings)
            // Additional: DeleteApplicationInstancesAsync(DeleteApplicationInstancesRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApplicationInstancesRequest request = new DeleteApplicationInstancesRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                InstanceIdsAsInstanceNames =
                {
                    InstanceName.FromProjectLocationApplicationInstance("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[INSTANCE]"),
                },
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await appPlatformClient.DeleteApplicationInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteApplicationInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationInstances</summary>
        public void DeleteApplicationInstances()
        {
            // Snippet: DeleteApplicationInstances(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<Instance, OperationMetadata> response = appPlatformClient.DeleteApplicationInstances(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteApplicationInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationInstancesAsync</summary>
        public async Task DeleteApplicationInstancesAsync()
        {
            // Snippet: DeleteApplicationInstancesAsync(string, CallSettings)
            // Additional: DeleteApplicationInstancesAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<Instance, OperationMetadata> response = await appPlatformClient.DeleteApplicationInstancesAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteApplicationInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationInstances</summary>
        public void DeleteApplicationInstancesResourceNames()
        {
            // Snippet: DeleteApplicationInstances(ApplicationName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<Instance, OperationMetadata> response = appPlatformClient.DeleteApplicationInstances(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteApplicationInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationInstancesAsync</summary>
        public async Task DeleteApplicationInstancesResourceNamesAsync()
        {
            // Snippet: DeleteApplicationInstancesAsync(ApplicationName, CallSettings)
            // Additional: DeleteApplicationInstancesAsync(ApplicationName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<Instance, OperationMetadata> response = await appPlatformClient.DeleteApplicationInstancesAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteApplicationInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationInstances</summary>
        public void UpdateApplicationInstancesRequestObject()
        {
            // Snippet: UpdateApplicationInstances(UpdateApplicationInstancesRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            UpdateApplicationInstancesRequest request = new UpdateApplicationInstancesRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ApplicationInstances =
                {
                    new UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance(),
                },
                RequestId = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> response = appPlatformClient.UpdateApplicationInstances(request);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpdateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateApplicationInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationInstancesAsync</summary>
        public async Task UpdateApplicationInstancesRequestObjectAsync()
        {
            // Snippet: UpdateApplicationInstancesAsync(UpdateApplicationInstancesRequest, CallSettings)
            // Additional: UpdateApplicationInstancesAsync(UpdateApplicationInstancesRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApplicationInstancesRequest request = new UpdateApplicationInstancesRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ApplicationInstances =
                {
                    new UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance(),
                },
                RequestId = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> response = await appPlatformClient.UpdateApplicationInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpdateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateApplicationInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationInstances</summary>
        public void UpdateApplicationInstances()
        {
            // Snippet: UpdateApplicationInstances(string, IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance>, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance> applicationInstances = new UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance[]
            {
                new UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance(),
            };
            // Make the request
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> response = appPlatformClient.UpdateApplicationInstances(name, applicationInstances);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpdateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateApplicationInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationInstancesAsync</summary>
        public async Task UpdateApplicationInstancesAsync()
        {
            // Snippet: UpdateApplicationInstancesAsync(string, IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance>, CallSettings)
            // Additional: UpdateApplicationInstancesAsync(string, IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance>, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance> applicationInstances = new UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance[]
            {
                new UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance(),
            };
            // Make the request
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> response = await appPlatformClient.UpdateApplicationInstancesAsync(name, applicationInstances);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpdateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateApplicationInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationInstances</summary>
        public void UpdateApplicationInstancesResourceNames()
        {
            // Snippet: UpdateApplicationInstances(ApplicationName, IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance>, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance> applicationInstances = new UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance[]
            {
                new UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance(),
            };
            // Make the request
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> response = appPlatformClient.UpdateApplicationInstances(name, applicationInstances);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpdateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateApplicationInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationInstancesAsync</summary>
        public async Task UpdateApplicationInstancesResourceNamesAsync()
        {
            // Snippet: UpdateApplicationInstancesAsync(ApplicationName, IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance>, CallSettings)
            // Additional: UpdateApplicationInstancesAsync(ApplicationName, IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance>, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            IEnumerable<UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance> applicationInstances = new UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance[]
            {
                new UpdateApplicationInstancesRequest.Types.UpdateApplicationInstance(),
            };
            // Make the request
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> response = await appPlatformClient.UpdateApplicationInstancesAsync(name, applicationInstances);

            // Poll until the returned long-running operation is complete
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpdateApplicationInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpdateApplicationInstancesResponse, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateApplicationInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpdateApplicationInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDrafts</summary>
        public void ListDraftsRequestObject()
        {
            // Snippet: ListDrafts(ListDraftsRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ListDraftsRequest request = new ListDraftsRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDraftsResponse, Draft> response = appPlatformClient.ListDrafts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Draft item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDraftsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Draft item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Draft> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Draft item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDraftsAsync</summary>
        public async Task ListDraftsRequestObjectAsync()
        {
            // Snippet: ListDraftsAsync(ListDraftsRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ListDraftsRequest request = new ListDraftsRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDraftsResponse, Draft> response = appPlatformClient.ListDraftsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Draft item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDraftsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Draft item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Draft> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Draft item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDrafts</summary>
        public void ListDrafts()
        {
            // Snippet: ListDrafts(string, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            PagedEnumerable<ListDraftsResponse, Draft> response = appPlatformClient.ListDrafts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Draft item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDraftsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Draft item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Draft> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Draft item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDraftsAsync</summary>
        public async Task ListDraftsAsync()
        {
            // Snippet: ListDraftsAsync(string, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            PagedAsyncEnumerable<ListDraftsResponse, Draft> response = appPlatformClient.ListDraftsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Draft item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDraftsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Draft item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Draft> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Draft item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDrafts</summary>
        public void ListDraftsResourceNames()
        {
            // Snippet: ListDrafts(ApplicationName, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            PagedEnumerable<ListDraftsResponse, Draft> response = appPlatformClient.ListDrafts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Draft item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDraftsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Draft item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Draft> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Draft item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDraftsAsync</summary>
        public async Task ListDraftsResourceNamesAsync()
        {
            // Snippet: ListDraftsAsync(ApplicationName, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            PagedAsyncEnumerable<ListDraftsResponse, Draft> response = appPlatformClient.ListDraftsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Draft item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDraftsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Draft item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Draft> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Draft item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDraft</summary>
        public void GetDraftRequestObject()
        {
            // Snippet: GetDraft(GetDraftRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            GetDraftRequest request = new GetDraftRequest
            {
                DraftName = DraftName.FromProjectLocationApplicationDraft("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[DRAFT]"),
            };
            // Make the request
            Draft response = appPlatformClient.GetDraft(request);
            // End snippet
        }

        /// <summary>Snippet for GetDraftAsync</summary>
        public async Task GetDraftRequestObjectAsync()
        {
            // Snippet: GetDraftAsync(GetDraftRequest, CallSettings)
            // Additional: GetDraftAsync(GetDraftRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            GetDraftRequest request = new GetDraftRequest
            {
                DraftName = DraftName.FromProjectLocationApplicationDraft("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[DRAFT]"),
            };
            // Make the request
            Draft response = await appPlatformClient.GetDraftAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDraft</summary>
        public void GetDraft()
        {
            // Snippet: GetDraft(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/drafts/[DRAFT]";
            // Make the request
            Draft response = appPlatformClient.GetDraft(name);
            // End snippet
        }

        /// <summary>Snippet for GetDraftAsync</summary>
        public async Task GetDraftAsync()
        {
            // Snippet: GetDraftAsync(string, CallSettings)
            // Additional: GetDraftAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/drafts/[DRAFT]";
            // Make the request
            Draft response = await appPlatformClient.GetDraftAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDraft</summary>
        public void GetDraftResourceNames()
        {
            // Snippet: GetDraft(DraftName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            DraftName name = DraftName.FromProjectLocationApplicationDraft("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[DRAFT]");
            // Make the request
            Draft response = appPlatformClient.GetDraft(name);
            // End snippet
        }

        /// <summary>Snippet for GetDraftAsync</summary>
        public async Task GetDraftResourceNamesAsync()
        {
            // Snippet: GetDraftAsync(DraftName, CallSettings)
            // Additional: GetDraftAsync(DraftName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            DraftName name = DraftName.FromProjectLocationApplicationDraft("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[DRAFT]");
            // Make the request
            Draft response = await appPlatformClient.GetDraftAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDraft</summary>
        public void CreateDraftRequestObject()
        {
            // Snippet: CreateDraft(CreateDraftRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            CreateDraftRequest request = new CreateDraftRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                DraftId = "",
                Draft = new Draft(),
                RequestId = "",
            };
            // Make the request
            Operation<Draft, OperationMetadata> response = appPlatformClient.CreateDraft(request);

            // Poll until the returned long-running operation is complete
            Operation<Draft, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Draft result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Draft, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateDraft(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Draft retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDraftAsync</summary>
        public async Task CreateDraftRequestObjectAsync()
        {
            // Snippet: CreateDraftAsync(CreateDraftRequest, CallSettings)
            // Additional: CreateDraftAsync(CreateDraftRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            CreateDraftRequest request = new CreateDraftRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                DraftId = "",
                Draft = new Draft(),
                RequestId = "",
            };
            // Make the request
            Operation<Draft, OperationMetadata> response = await appPlatformClient.CreateDraftAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Draft, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Draft result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Draft, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateDraftAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Draft retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDraft</summary>
        public void CreateDraft()
        {
            // Snippet: CreateDraft(string, Draft, string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            Draft draft = new Draft();
            string draftId = "";
            // Make the request
            Operation<Draft, OperationMetadata> response = appPlatformClient.CreateDraft(parent, draft, draftId);

            // Poll until the returned long-running operation is complete
            Operation<Draft, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Draft result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Draft, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateDraft(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Draft retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDraftAsync</summary>
        public async Task CreateDraftAsync()
        {
            // Snippet: CreateDraftAsync(string, Draft, string, CallSettings)
            // Additional: CreateDraftAsync(string, Draft, string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            Draft draft = new Draft();
            string draftId = "";
            // Make the request
            Operation<Draft, OperationMetadata> response = await appPlatformClient.CreateDraftAsync(parent, draft, draftId);

            // Poll until the returned long-running operation is complete
            Operation<Draft, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Draft result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Draft, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateDraftAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Draft retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDraft</summary>
        public void CreateDraftResourceNames()
        {
            // Snippet: CreateDraft(ApplicationName, Draft, string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            Draft draft = new Draft();
            string draftId = "";
            // Make the request
            Operation<Draft, OperationMetadata> response = appPlatformClient.CreateDraft(parent, draft, draftId);

            // Poll until the returned long-running operation is complete
            Operation<Draft, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Draft result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Draft, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateDraft(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Draft retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDraftAsync</summary>
        public async Task CreateDraftResourceNamesAsync()
        {
            // Snippet: CreateDraftAsync(ApplicationName, Draft, string, CallSettings)
            // Additional: CreateDraftAsync(ApplicationName, Draft, string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            Draft draft = new Draft();
            string draftId = "";
            // Make the request
            Operation<Draft, OperationMetadata> response = await appPlatformClient.CreateDraftAsync(parent, draft, draftId);

            // Poll until the returned long-running operation is complete
            Operation<Draft, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Draft result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Draft, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateDraftAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Draft retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDraft</summary>
        public void UpdateDraftRequestObject()
        {
            // Snippet: UpdateDraft(UpdateDraftRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            UpdateDraftRequest request = new UpdateDraftRequest
            {
                UpdateMask = new FieldMask(),
                Draft = new Draft(),
                RequestId = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<Draft, OperationMetadata> response = appPlatformClient.UpdateDraft(request);

            // Poll until the returned long-running operation is complete
            Operation<Draft, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Draft result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Draft, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateDraft(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Draft retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDraftAsync</summary>
        public async Task UpdateDraftRequestObjectAsync()
        {
            // Snippet: UpdateDraftAsync(UpdateDraftRequest, CallSettings)
            // Additional: UpdateDraftAsync(UpdateDraftRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDraftRequest request = new UpdateDraftRequest
            {
                UpdateMask = new FieldMask(),
                Draft = new Draft(),
                RequestId = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<Draft, OperationMetadata> response = await appPlatformClient.UpdateDraftAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Draft, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Draft result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Draft, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateDraftAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Draft retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDraft</summary>
        public void UpdateDraft()
        {
            // Snippet: UpdateDraft(Draft, FieldMask, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            Draft draft = new Draft();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Draft, OperationMetadata> response = appPlatformClient.UpdateDraft(draft, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Draft, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Draft result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Draft, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateDraft(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Draft retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDraftAsync</summary>
        public async Task UpdateDraftAsync()
        {
            // Snippet: UpdateDraftAsync(Draft, FieldMask, CallSettings)
            // Additional: UpdateDraftAsync(Draft, FieldMask, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            Draft draft = new Draft();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Draft, OperationMetadata> response = await appPlatformClient.UpdateDraftAsync(draft, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Draft, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Draft result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Draft, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateDraftAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Draft retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDraft</summary>
        public void DeleteDraftRequestObject()
        {
            // Snippet: DeleteDraft(DeleteDraftRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            DeleteDraftRequest request = new DeleteDraftRequest
            {
                DraftName = DraftName.FromProjectLocationApplicationDraft("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[DRAFT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = appPlatformClient.DeleteDraft(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteDraft(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDraftAsync</summary>
        public async Task DeleteDraftRequestObjectAsync()
        {
            // Snippet: DeleteDraftAsync(DeleteDraftRequest, CallSettings)
            // Additional: DeleteDraftAsync(DeleteDraftRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDraftRequest request = new DeleteDraftRequest
            {
                DraftName = DraftName.FromProjectLocationApplicationDraft("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[DRAFT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await appPlatformClient.DeleteDraftAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteDraftAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDraft</summary>
        public void DeleteDraft()
        {
            // Snippet: DeleteDraft(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/drafts/[DRAFT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = appPlatformClient.DeleteDraft(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteDraft(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDraftAsync</summary>
        public async Task DeleteDraftAsync()
        {
            // Snippet: DeleteDraftAsync(string, CallSettings)
            // Additional: DeleteDraftAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/drafts/[DRAFT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await appPlatformClient.DeleteDraftAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteDraftAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDraft</summary>
        public void DeleteDraftResourceNames()
        {
            // Snippet: DeleteDraft(DraftName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            DraftName name = DraftName.FromProjectLocationApplicationDraft("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[DRAFT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = appPlatformClient.DeleteDraft(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteDraft(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDraftAsync</summary>
        public async Task DeleteDraftResourceNamesAsync()
        {
            // Snippet: DeleteDraftAsync(DraftName, CallSettings)
            // Additional: DeleteDraftAsync(DraftName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            DraftName name = DraftName.FromProjectLocationApplicationDraft("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[DRAFT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await appPlatformClient.DeleteDraftAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteDraftAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListProcessors</summary>
        public void ListProcessorsRequestObject()
        {
            // Snippet: ListProcessors(ListProcessorsRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ListProcessorsRequest request = new ListProcessorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListProcessorsResponse, Processor> response = appPlatformClient.ListProcessors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Processor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorsAsync</summary>
        public async Task ListProcessorsRequestObjectAsync()
        {
            // Snippet: ListProcessorsAsync(ListProcessorsRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ListProcessorsRequest request = new ListProcessorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListProcessorsResponse, Processor> response = appPlatformClient.ListProcessorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Processor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessors</summary>
        public void ListProcessors()
        {
            // Snippet: ListProcessors(string, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListProcessorsResponse, Processor> response = appPlatformClient.ListProcessors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Processor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorsAsync</summary>
        public async Task ListProcessorsAsync()
        {
            // Snippet: ListProcessorsAsync(string, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListProcessorsResponse, Processor> response = appPlatformClient.ListProcessorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Processor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessors</summary>
        public void ListProcessorsResourceNames()
        {
            // Snippet: ListProcessors(LocationName, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProcessorsResponse, Processor> response = appPlatformClient.ListProcessors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Processor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorsAsync</summary>
        public async Task ListProcessorsResourceNamesAsync()
        {
            // Snippet: ListProcessorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProcessorsResponse, Processor> response = appPlatformClient.ListProcessorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Processor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrebuiltProcessors</summary>
        public void ListPrebuiltProcessorsRequestObject()
        {
            // Snippet: ListPrebuiltProcessors(ListPrebuiltProcessorsRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ListPrebuiltProcessorsRequest request = new ListPrebuiltProcessorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            ListPrebuiltProcessorsResponse response = appPlatformClient.ListPrebuiltProcessors(request);
            // End snippet
        }

        /// <summary>Snippet for ListPrebuiltProcessorsAsync</summary>
        public async Task ListPrebuiltProcessorsRequestObjectAsync()
        {
            // Snippet: ListPrebuiltProcessorsAsync(ListPrebuiltProcessorsRequest, CallSettings)
            // Additional: ListPrebuiltProcessorsAsync(ListPrebuiltProcessorsRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ListPrebuiltProcessorsRequest request = new ListPrebuiltProcessorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            ListPrebuiltProcessorsResponse response = await appPlatformClient.ListPrebuiltProcessorsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPrebuiltProcessors</summary>
        public void ListPrebuiltProcessors()
        {
            // Snippet: ListPrebuiltProcessors(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListPrebuiltProcessorsResponse response = appPlatformClient.ListPrebuiltProcessors(parent);
            // End snippet
        }

        /// <summary>Snippet for ListPrebuiltProcessorsAsync</summary>
        public async Task ListPrebuiltProcessorsAsync()
        {
            // Snippet: ListPrebuiltProcessorsAsync(string, CallSettings)
            // Additional: ListPrebuiltProcessorsAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListPrebuiltProcessorsResponse response = await appPlatformClient.ListPrebuiltProcessorsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListPrebuiltProcessors</summary>
        public void ListPrebuiltProcessorsResourceNames()
        {
            // Snippet: ListPrebuiltProcessors(LocationName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListPrebuiltProcessorsResponse response = appPlatformClient.ListPrebuiltProcessors(parent);
            // End snippet
        }

        /// <summary>Snippet for ListPrebuiltProcessorsAsync</summary>
        public async Task ListPrebuiltProcessorsResourceNamesAsync()
        {
            // Snippet: ListPrebuiltProcessorsAsync(LocationName, CallSettings)
            // Additional: ListPrebuiltProcessorsAsync(LocationName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListPrebuiltProcessorsResponse response = await appPlatformClient.ListPrebuiltProcessorsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GetProcessor</summary>
        public void GetProcessorRequestObject()
        {
            // Snippet: GetProcessor(GetProcessorRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            GetProcessorRequest request = new GetProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Processor response = appPlatformClient.GetProcessor(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorAsync</summary>
        public async Task GetProcessorRequestObjectAsync()
        {
            // Snippet: GetProcessorAsync(GetProcessorRequest, CallSettings)
            // Additional: GetProcessorAsync(GetProcessorRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            GetProcessorRequest request = new GetProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Processor response = await appPlatformClient.GetProcessorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessor</summary>
        public void GetProcessor()
        {
            // Snippet: GetProcessor(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            Processor response = appPlatformClient.GetProcessor(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorAsync</summary>
        public async Task GetProcessorAsync()
        {
            // Snippet: GetProcessorAsync(string, CallSettings)
            // Additional: GetProcessorAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            Processor response = await appPlatformClient.GetProcessorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessor</summary>
        public void GetProcessorResourceNames()
        {
            // Snippet: GetProcessor(ProcessorName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Processor response = appPlatformClient.GetProcessor(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorAsync</summary>
        public async Task GetProcessorResourceNamesAsync()
        {
            // Snippet: GetProcessorAsync(ProcessorName, CallSettings)
            // Additional: GetProcessorAsync(ProcessorName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Processor response = await appPlatformClient.GetProcessorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessor</summary>
        public void CreateProcessorRequestObject()
        {
            // Snippet: CreateProcessor(CreateProcessorRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            CreateProcessorRequest request = new CreateProcessorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProcessorId = "",
                Processor = new Processor(),
                RequestId = "",
            };
            // Make the request
            Operation<Processor, OperationMetadata> response = appPlatformClient.CreateProcessor(request);

            // Poll until the returned long-running operation is complete
            Operation<Processor, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Processor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Processor, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Processor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcessorAsync</summary>
        public async Task CreateProcessorRequestObjectAsync()
        {
            // Snippet: CreateProcessorAsync(CreateProcessorRequest, CallSettings)
            // Additional: CreateProcessorAsync(CreateProcessorRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            CreateProcessorRequest request = new CreateProcessorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProcessorId = "",
                Processor = new Processor(),
                RequestId = "",
            };
            // Make the request
            Operation<Processor, OperationMetadata> response = await appPlatformClient.CreateProcessorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Processor, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Processor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Processor, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Processor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcessor</summary>
        public void CreateProcessor()
        {
            // Snippet: CreateProcessor(string, Processor, string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Processor processor = new Processor();
            string processorId = "";
            // Make the request
            Operation<Processor, OperationMetadata> response = appPlatformClient.CreateProcessor(parent, processor, processorId);

            // Poll until the returned long-running operation is complete
            Operation<Processor, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Processor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Processor, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Processor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcessorAsync</summary>
        public async Task CreateProcessorAsync()
        {
            // Snippet: CreateProcessorAsync(string, Processor, string, CallSettings)
            // Additional: CreateProcessorAsync(string, Processor, string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Processor processor = new Processor();
            string processorId = "";
            // Make the request
            Operation<Processor, OperationMetadata> response = await appPlatformClient.CreateProcessorAsync(parent, processor, processorId);

            // Poll until the returned long-running operation is complete
            Operation<Processor, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Processor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Processor, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Processor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcessor</summary>
        public void CreateProcessorResourceNames()
        {
            // Snippet: CreateProcessor(LocationName, Processor, string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Processor processor = new Processor();
            string processorId = "";
            // Make the request
            Operation<Processor, OperationMetadata> response = appPlatformClient.CreateProcessor(parent, processor, processorId);

            // Poll until the returned long-running operation is complete
            Operation<Processor, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Processor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Processor, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceCreateProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Processor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcessorAsync</summary>
        public async Task CreateProcessorResourceNamesAsync()
        {
            // Snippet: CreateProcessorAsync(LocationName, Processor, string, CallSettings)
            // Additional: CreateProcessorAsync(LocationName, Processor, string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Processor processor = new Processor();
            string processorId = "";
            // Make the request
            Operation<Processor, OperationMetadata> response = await appPlatformClient.CreateProcessorAsync(parent, processor, processorId);

            // Poll until the returned long-running operation is complete
            Operation<Processor, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Processor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Processor, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceCreateProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Processor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProcessor</summary>
        public void UpdateProcessorRequestObject()
        {
            // Snippet: UpdateProcessor(UpdateProcessorRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            UpdateProcessorRequest request = new UpdateProcessorRequest
            {
                UpdateMask = new FieldMask(),
                Processor = new Processor(),
                RequestId = "",
            };
            // Make the request
            Operation<Processor, OperationMetadata> response = appPlatformClient.UpdateProcessor(request);

            // Poll until the returned long-running operation is complete
            Operation<Processor, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Processor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Processor, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Processor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProcessorAsync</summary>
        public async Task UpdateProcessorRequestObjectAsync()
        {
            // Snippet: UpdateProcessorAsync(UpdateProcessorRequest, CallSettings)
            // Additional: UpdateProcessorAsync(UpdateProcessorRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProcessorRequest request = new UpdateProcessorRequest
            {
                UpdateMask = new FieldMask(),
                Processor = new Processor(),
                RequestId = "",
            };
            // Make the request
            Operation<Processor, OperationMetadata> response = await appPlatformClient.UpdateProcessorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Processor, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Processor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Processor, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Processor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProcessor</summary>
        public void UpdateProcessor()
        {
            // Snippet: UpdateProcessor(Processor, FieldMask, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            Processor processor = new Processor();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Processor, OperationMetadata> response = appPlatformClient.UpdateProcessor(processor, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Processor, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Processor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Processor, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceUpdateProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Processor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProcessorAsync</summary>
        public async Task UpdateProcessorAsync()
        {
            // Snippet: UpdateProcessorAsync(Processor, FieldMask, CallSettings)
            // Additional: UpdateProcessorAsync(Processor, FieldMask, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            Processor processor = new Processor();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Processor, OperationMetadata> response = await appPlatformClient.UpdateProcessorAsync(processor, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Processor, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Processor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Processor, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceUpdateProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Processor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessor</summary>
        public void DeleteProcessorRequestObject()
        {
            // Snippet: DeleteProcessor(DeleteProcessorRequest, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            DeleteProcessorRequest request = new DeleteProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = appPlatformClient.DeleteProcessor(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorAsync</summary>
        public async Task DeleteProcessorRequestObjectAsync()
        {
            // Snippet: DeleteProcessorAsync(DeleteProcessorRequest, CallSettings)
            // Additional: DeleteProcessorAsync(DeleteProcessorRequest, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProcessorRequest request = new DeleteProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await appPlatformClient.DeleteProcessorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessor</summary>
        public void DeleteProcessor()
        {
            // Snippet: DeleteProcessor(string, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = appPlatformClient.DeleteProcessor(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorAsync</summary>
        public async Task DeleteProcessorAsync()
        {
            // Snippet: DeleteProcessorAsync(string, CallSettings)
            // Additional: DeleteProcessorAsync(string, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await appPlatformClient.DeleteProcessorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessor</summary>
        public void DeleteProcessorResourceNames()
        {
            // Snippet: DeleteProcessor(ProcessorName, CallSettings)
            // Create client
            AppPlatformClient appPlatformClient = AppPlatformClient.Create();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = appPlatformClient.DeleteProcessor(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appPlatformClient.PollOnceDeleteProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorAsync</summary>
        public async Task DeleteProcessorResourceNamesAsync()
        {
            // Snippet: DeleteProcessorAsync(ProcessorName, CallSettings)
            // Additional: DeleteProcessorAsync(ProcessorName, CancellationToken)
            // Create client
            AppPlatformClient appPlatformClient = await AppPlatformClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await appPlatformClient.DeleteProcessorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appPlatformClient.PollOnceDeleteProcessorAsync(operationName);
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
